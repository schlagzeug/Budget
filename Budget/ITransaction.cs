using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget
{
    public interface ITransaction
    {
        string Name { get; set; }
        decimal Amount { get; set; }
        DateTime LastPaidDate { get; set; }
        DateTime NextPayDate { get; set; }
        PaymentPlan.Frequency Frequency { get; set; }
    }
}
