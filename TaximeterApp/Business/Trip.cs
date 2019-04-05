using System;
using TaximeterApp.DA;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaximeterApp.Business
{
    public class Trip : Status
    {
        Time startTime;
        Time finishTime;
        double initialSpeed;
        Time time;

        public Trip() : base()
        {
            this.startTime = new Time(0,0);
            this.finishTime = new Time(0,0);
            this.initialSpeed = 0.0;
            this.time = new Time(0, 0);
        }

        public Trip(double netIncome, double mileage, double fuel, Time startTime, Time finishTime, double initialSpeed, Time time) : base(netIncome, mileage, fuel)
        {
            this.startTime = startTime;
            this.finishTime = finishTime;
            this.initialSpeed = initialSpeed;
            this.time = time;
        }

        public Time StartTime { get => startTime; set => startTime = value; }
        public Time FinishTime { get => finishTime; set => finishTime = value; }
        public double InitialSpeed { get => initialSpeed; set => initialSpeed = value; }
        public Time Time { get => time; set => time = value; }

        public Time Calculated_Duration(Time start, Time end)
        {
            return Methods.calculation_time(start, end);
        }

        public double Calculated_cost(Time start, Time end)
        {
            return Methods.calculation_cost(start, end);
        }

        public double Calculated_fuel_consumption(Trip currentTrip)
        {
            return Methods.calculation_fuel_consumption(currentTrip);
        }

        public double Calculated_Mileage(Trip currentTrip)
        {
            return Methods.calculation_mileage(currentTrip);
        }
    }
}
