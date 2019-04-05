using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaximeterApp.Business;
using System.Windows.Forms;


namespace TaximeterApp.DA
{
    public static class Methods
    {
        public static Time calculation_time(Time start, Time finish)
        {

            // calculate finish time - start time
            Time calcul_time = new Time(0, 0);
            if (finish.Minute < start.Minute)
            {
                finish.Hour -= 1;
                finish.Minute += 60;
            }

            calcul_time.Hour = finish.Hour - start.Hour;
            calcul_time.Minute = finish.Minute - start.Minute;

            return calcul_time;
        }

        public static double calculation_cost(Time start, Time finish)
        {
            double calcul_cost = 0.0;
            double cost1 = 0.0;
            double cost2 = 0.0;
            double cost3 = 0.0;
            double totalhour = 0.0;
            Time t_8 = new Time(8, 0);
            Time t_14 = new Time(14, 0);
            Time t_24 = new Time(24, 0);
            Time t_32 = new Time(32, 0);

            if ((start.Hour >= 0) && (start.Hour <=7))
            {
                if((finish.Hour >= 0) && (finish.Hour <= 7))
                {
                    Time phase1 = calculation_time(start, finish);
                    totalhour = Convert.ToDouble(phase1.Minute) / 60 + Convert.ToDouble(phase1.Hour);
                    calcul_cost = totalhour * 30;
                }
                if((finish.Hour >= 8)&&(finish.Hour <= 13))
                {
                    Time phase1 = calculation_time(start, t_8);
                    totalhour = Convert.ToDouble(phase1.Minute) / 60 + Convert.ToDouble(phase1.Hour);
                    cost1 = totalhour * 30;
                    Time phase2 = calculation_time(t_8, finish);
                    totalhour = Convert.ToDouble(phase2.Minute) / 60 + Convert.ToDouble(phase2.Hour);
                    cost2 = totalhour * 20;
                    calcul_cost = cost1 + cost2;
                }
                if((finish.Hour >= 14)&&(finish.Hour <= 23))
                {
                    Time phase1 = calculation_time(start, t_8);
                    totalhour = Convert.ToDouble(phase1.Minute) / 60 + Convert.ToDouble(phase1.Hour);
                    cost1 = totalhour * 30;
                    cost2 = 6 * 20;
                    Time phase2 = calculation_time(t_14, finish);
                    totalhour = Convert.ToDouble(phase2.Minute) / 60 + Convert.ToDouble(phase2.Hour);
                    cost3 = totalhour * 25;
                    calcul_cost = cost1 + cost2 + cost3;
                }
            }
            else if ((start.Hour >= 8) && (start.Hour <= 13))
            {
                if ((finish.Hour >= 8) && (finish.Hour <= 13))
                {
                    Time phase1 = calculation_time(start, finish);
                    totalhour = Convert.ToDouble(phase1.Minute) / 60 + Convert.ToDouble(phase1.Hour);
                    calcul_cost = totalhour * 20;
                }
                if ((finish.Hour >= 14) && (finish.Hour <= 23))
                {
                    Time phase1 = calculation_time(start, t_14);
                    totalhour = Convert.ToDouble(phase1.Minute) / 60 + Convert.ToDouble(phase1.Hour);
                    cost1 = totalhour * 20;
                    Time phase2 = calculation_time(t_14, finish);
                    totalhour = Convert.ToDouble(phase2.Minute) / 60 + Convert.ToDouble(phase2.Hour);
                    cost2 = totalhour * 25;
                    calcul_cost = cost1 + cost2;
                }
                if ((finish.Hour >= 24) && (finish.Hour <= 31))
                {
                    Time phase1 = calculation_time(start, t_14);
                    totalhour = Convert.ToDouble(phase1.Minute) / 60 + Convert.ToDouble(phase1.Hour);
                    cost1 = totalhour * 20;
                    cost2 = 10 * 25;
                    Time phase2 = calculation_time(t_24, finish);
                    totalhour = Convert.ToDouble(phase2.Minute) / 60 + Convert.ToDouble(phase2.Hour);
                    cost3 = totalhour * 30;
                    calcul_cost = cost1 + cost2 + cost3;
                }
            }
            else
            {
                if ((finish.Hour >= 14) && (finish.Hour <= 23))
                {
                    Time phase1 = calculation_time(start, finish);
                    totalhour = Convert.ToDouble(phase1.Minute) / 60 + Convert.ToDouble(phase1.Hour);
                    calcul_cost = totalhour * 25;
                }
                if ((finish.Hour >= 24) && (finish.Hour <= 31))
                {
                    Time phase1 = calculation_time(start, t_24);
                    totalhour = Convert.ToDouble(phase1.Minute) / 60 + Convert.ToDouble(phase1.Hour);
                    cost1 = totalhour * 25;
                    Time phase2 = calculation_time(t_24, finish);
                    totalhour = Convert.ToDouble(phase2.Minute) / 60 + Convert.ToDouble(phase2.Hour);
                    cost2 = totalhour * 30;
                    calcul_cost = cost1 + cost2;
                }
                if ((finish.Hour >= 32) && (finish.Hour <= 35))
                {
                    Time phase1 = calculation_time(start, t_24);
                    totalhour = Convert.ToDouble(phase1.Minute) / 60 + Convert.ToDouble(phase1.Hour);
                    cost1 = totalhour * 25;
                    cost2 = 8 * 30;
                    Time phase2 = calculation_time(t_32, finish);
                    totalhour = Convert.ToDouble(phase2.Minute) / 60 + Convert.ToDouble(phase2.Hour);
                    cost3 = totalhour * 20;
                    calcul_cost = cost1 + cost2 + cost3;
                }
            }
            calcul_cost = Math.Round(calcul_cost, 2);
            return calcul_cost;
        }

        public static double calculation_fuel_consumption(Trip currentTrip)
        {
            double fuellevel = 0.0;
            double totalhour = 0.0;
            double speed = Convert.ToDouble(currentTrip.InitialSpeed);

            // parsing trip duration into double value
            totalhour = Convert.ToDouble(currentTrip.Time.Minute) / 60 + Convert.ToDouble(currentTrip.Time.Hour);

            // applying the fomular for fuel level
            fuellevel = totalhour * (Math.Abs(Math.Tan(speed * totalhour)) + Math.Abs(Math.Cos(speed)));

            fuellevel = Math.Round(fuellevel, 2);

            return fuellevel;
        }


        public static double calculation_mileage(Trip currentTrip)
        {
            double mileage = 0.0;
            // parsing trip duration into double value
            double totalhour = Math.Round((Convert.ToDouble(currentTrip.Time.Minute) / 60 + Convert.ToDouble(currentTrip.Time.Hour)), 2);
            double power = totalhour * 2;
            mileage = Math.Round((Math.Pow(currentTrip.InitialSpeed, 2 * totalhour) - currentTrip.InitialSpeed * totalhour), 2);
            return mileage;
        }
        public static double add_fuel(double currentrate, double payment, TaxiMeter currentTaxi) // add fuel, if the tank is full then return the money that exceeds maximum tank
        {
            double left = 0.0;
            double add = currentrate * payment;
            if (currentTaxi.Fuel == 100.00)
            {
                left = payment;
            }
            else
            {
                currentTaxi.Fuel += add;
                if (currentTaxi.Fuel > 100.00)
                {
                    currentTaxi.NetIncome = currentTaxi.NetIncome - payment;
                    left = currentTaxi.Fuel - 100;
                    left = left * currentrate;
                    left = Math.Round(left, 2);
                    currentTaxi.Fuel = 100.00;
                    currentTaxi.NetIncome += left;
                }
                else
                {
                    currentTaxi.NetIncome -= payment;
                    currentTaxi.NetIncome = Math.Round(currentTaxi.NetIncome);
                }
            }
            return left;
        }

        public static void taximeter_renew(TaxiMeter current, Trip newTrip)
        {
            current.Fuel -= newTrip.Fuel;
            current.Mileage = current.Mileage + newTrip.Mileage;
            current.NumberOfTrips += 1;
            current.NetIncome += newTrip.NetIncome;
        }
    }
}
