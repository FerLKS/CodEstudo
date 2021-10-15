using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro.Entities
{
    class OutsourcedEmployee : Employee
    {

        public double AdditionalCharge { get; set;}

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(double additionalCharge, string name, int hours, double valuePerHour)
                : base(name,hours,valuePerHour)
        {   
            AdditionalCharge = additionalCharge;
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {

        }

        public   double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;

        }


    }
}
