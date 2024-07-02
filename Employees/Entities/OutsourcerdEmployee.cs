using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Entities
{
    class OutsourcerdEmployee : Employee
    {
        public double AdditionalCharge { get; set; }
        
        public OutsourcerdEmployee() { }

        public OutsourcerdEmployee(double additionalCharge, string name, int hours, double valuePerHour)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
             return base.Payment() + 1.1 * AdditionalCharge;

        }
    }
}
