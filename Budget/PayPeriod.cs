using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget
{
    public class PayPeriod
    {
        public string PeriodName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Income> Incomes { get; set; }
        public List<Expense> Expenses { get; set; }
    }
}
