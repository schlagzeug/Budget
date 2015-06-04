using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Budget
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public PayPeriod currentPayPeriod = new PayPeriod();
        public List<PayPeriod> payPeriods = new List<PayPeriod>();

        public MainWindow()
        {
            InitializeComponent();
            Setup();
        }

        private void Setup()
        {
            LoadVariables();
            foreach (var period in payPeriods)
            {
                ComboBox_payPeriods.Items.Add(period.PeriodName);
            }
        }

        private void LoadVariables()
        {
            // This will be used to retrieve the payperiods from the xml
            PayPeriod p = new PayPeriod();
            p.PeriodName = "Test Period 1";
            p.StartDate = new DateTime(2015, 04, 03);
            p.EndDate = new DateTime(2015, 04, 16);
            p.Expenses = new List<Expense>();
            p.Incomes = new List<Income>();

            payPeriods.Add(p);
            currentPayPeriod = p;
        }

        private void menu_file_upload_Click(object sender, RoutedEventArgs e)
        {

        }

        private void menu_file_download_Click(object sender, RoutedEventArgs e)
        {

        }

        private void menu_money_income_Click(object sender, RoutedEventArgs e)
        {

        }

        private void menu_money_expenses_Click(object sender, RoutedEventArgs e)
        {
            var x = new ExpenseListWindow();
            x.ShowDialog();
        }

        private void Button_newPayPeriod_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DataGrid_expenses_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void DataGrid_income_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
