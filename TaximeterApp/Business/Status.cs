using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaximeterApp.Business
{
    public class Status
    {
        double netIncome;
        double mileage;
        double fuel;

        public Status()
        {
            this.NetIncome = 0.0;
            this.Mileage = 0.0;
            this.Fuel = 0.0;
        }
        public Status(double netIncome, double mileage, double fuel)
        {
            this.NetIncome = netIncome;
            this.Mileage = mileage;
            this.Fuel = fuel;
        }

        public double NetIncome { get => netIncome; set => netIncome = value; }
        public double Mileage { get => mileage; set => mileage = value; }
        public double Fuel { get => fuel; set => fuel = value; }
    }
}
