using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Budget
{
    /// <summary>
    /// Interaction logic for ExpenseListWindow.xaml
    /// </summary>
    public partial class ExpenseListWindow : Window
    {
        public List<Expense> expenses = new List<Expense>();

        public ExpenseListWindow()
        {
            InitializeComponent();
            for (int i = 0; i < PaymentPlan.EnumCount; i++)
            {
                ComboBox_frequency.Items.Add(PaymentPlan.GetEnumDescription((PaymentPlan.Frequency)i));
            }
            ComboBox_frequency.SelectedIndex = 0;
        }

        protected override void OnClosed(EventArgs e)
        {
            WriteExpensesToFile();
            base.OnClosed(e);
        }

        private void WriteExpensesToFile()
        {
            throw new NotImplementedException();
        }

        private void Button_add_Click(object sender, RoutedEventArgs e)
        {
            Expense newExpense = new Expense();
            decimal paymentAmt = 0m;
            if (Textbox_name.Text != string.Empty && 
                decimal.TryParse(TextBox_paymentAmt.Text, out paymentAmt))
            {
                DataGrid_expenses.ItemsSource = null;
                DataGrid_expenses.Items.Clear();

                newExpense.Name = Textbox_name.Text;
                newExpense.Amount = paymentAmt;
                newExpense.LastPaidDate = DatePicker_lastPaidDate.SelectedDate.GetValueOrDefault();
                newExpense.Frequency = (PaymentPlan.Frequency)ComboBox_frequency.SelectedIndex;
                newExpense.NextPayDate = PaymentPlan.CalculateNextDate(newExpense.LastPaidDate, newExpense.Frequency);

                expenses.Add(newExpense);

                DataGrid_expenses.ItemsSource = expenses;

                ResetFields();
            }
        }

        private void ResetFields()
        {
            Textbox_name.Text = string.Empty;
            TextBox_paymentAmt.Text = string.Empty;
            DatePicker_lastPaidDate.SelectedDate = null;
            ComboBox_frequency.SelectedIndex = 0;
        }
    }
}
