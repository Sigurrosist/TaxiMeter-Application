using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaximeterApp.DA;

namespace TaximeterApp.Business
{
    public class TaxiMeter : Status
    {
        int numberOfTrips;

        public TaxiMeter() : base()
        {
            NumberOfTrips = 0;
        }

        public TaxiMeter(double netIncome, double mileage, double fuel, int numberoftrips) : base(netIncome, mileage, fuel)
        {
            this.NumberOfTrips = numberoftrips;
        }

        public int NumberOfTrips { get => numberOfTrips; set => numberOfTrips = value; }

        public void TaxiMeter_Renew(TaxiMeter current_taximeter, Trip current_trip)
        {
            Methods.taximeter_renew(current_taximeter, current_trip);
        }

        public double Add_Fuel(double rate, double cost, TaxiMeter currentTaxi)
        {
            return Methods.add_fuel(rate, cost, currentTaxi);
        }
    }
}
