using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget
{
    public class Expense : ITransaction
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public DateTime LastPaidDate { get; set; }
        public DateTime NextPayDate { get; set; }
        public PaymentPlan.Frequency Frequency { get; set; }
        
    }
}
