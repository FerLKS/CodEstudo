/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Primeiro.Entities
{
    class OutsourcedEmployee : Employee
    {
        private double price;

        public double additionalCharge { get; set;}

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee( string name, double price, double additionalCharge)
                : base(name, price)
        {   
            this.additionalCharge = additionalCharge;
        }

       

        public OutsourcedEmployee(string name, double price) : base(name, price)
         {

         }
        
        public   double TotalPrice()
        {
            return price + additionalCharge;
            

        }
        public override string PriceTag()
        {
            return Name
                + " $ "
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " (Customs fee: $ "
                + additionalCharge.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }


    }
}
*/