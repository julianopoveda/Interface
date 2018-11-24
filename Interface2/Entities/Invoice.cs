using System;
using System.Globalization;
namespace Entities{
    class Invoice{
        public double basicPayment { get; set; }
        public double tax { get; set; }
        public Invoice(double basicPayment,double tax){
            this.basicPayment=basicPayment;
            this.tax=tax;
        }
        public double totalPayment(){
            return basicPayment+tax;            
        }
        public override string ToString(){
            return "Basic payment: "+basicPayment.ToString("F2",CultureInfo.InvariantCulture)
                + "\nTax: "
                + tax.ToString("F2",CultureInfo.InvariantCulture)
                + "\nTotal Payment: "
                + totalPayment.ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}