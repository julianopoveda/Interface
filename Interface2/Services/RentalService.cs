using System;
using Entities;
namespace Services{
    class RentalService{
        public double pricePerHour { get; private set; }
        public double pricePerDay { get; private set; }
        private ITaxService _taxService;
            public RentalService(double pricePerHour,double pricePerDay,ITaxService taxService){
                this.pricePerHour=pricePerHour;
                this.pricePerDay=pricePerDay;
                _taxService=taxService;
            }
            public void ProcessInVoice(CarRental carRental){
                TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
                double basicPayment=0.0;
                if(duration.TotalHours<=12){
                    basicPayment=pricePerHour*Math.Ceiling(duration.TotalHours);
                }
                else{
                    basicPayment=pricePerDay*Math.Ceiling(duration.TotalDays);
                }
                double tax=_taxService.tax(basicPayment);
                carRental.Invoice=new Invoice(basicPayment,tax);
            }
    }
}