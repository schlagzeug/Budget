using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Budget
{
    public static class PaymentPlan
    {
        public const int EnumCount = 3;
        public enum Frequency
        {
            [Description("Every other week")]
            EveryOtherWeek,
            [Description("Once a month")]
            OnceAMonth,
            [Description("One time")]
            SingleTime
        }

        public static DateTime CalculateNextDate(DateTime previousDate, Frequency frequency)
        {
            DateTime nextDate = DateTime.MinValue;

            if (frequency == Frequency.OnceAMonth)
            {
                nextDate = previousDate.AddMonths(1);
            }
            else if (frequency == Frequency.EveryOtherWeek)
            {
                nextDate = previousDate.AddDays(14);
            }
            else if (frequency == Frequency.SingleTime)
            {
                nextDate = DateTime.MaxValue;
            }

            return nextDate;
        }

        public static string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute),
                false);

            if (attributes != null &&
                attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }
    }
}
