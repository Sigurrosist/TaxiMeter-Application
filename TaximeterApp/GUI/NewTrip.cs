using System;
using TaximeterApp.Business;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaximeterApp.GUI
{
    public partial class NewTrip : MetroFramework.Forms.MetroForm
    {

        public NewTrip()
        {
            InitializeComponent();
        }

        private bool trip_Created;
        private bool nextday;
        private Trip current_trip;
        public bool Trip_Created
        {
            get { return trip_Created; }
            set { trip_Created = value; }
        }

        public bool Nextday
        {
            get { return nextday; }
            set { nextday = value; }
        }

        public Trip Current_Trip
        {
            get { return current_trip; }
            set { current_trip = value; }
        }
        private void NewTrip_Load(object sender, EventArgs e)
        {
            // form theme change to dark
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            
            // add options to the speed combobox
            for (int i = 60; i < 161; i += 5)
            {
                cbo_speed.Items.Add(i.ToString() + "km/h");
            }
            cbo_speed.SelectedIndex = 0;
        }

        private void btn_add_new_trip_Click(object sender, EventArgs e)
        {
            current_trip = new Trip();
            string starttime = starttimepicker.Text;
            string endtime = endtimepicker.Text;
            string sp = cbo_speed.SelectedItem.ToString();
            double speed = Convert.ToDouble(sp.Replace("km/h", ""));
            nextday = check_next_day.Checked;

            // parsing starting time
            Time start = new Time();
            string[] times = starttime.Split(':');
            int hour = Convert.ToInt32(times[0].Trim());
            int minute = Convert.ToInt32(times[1].Trim());
            start.Hour = hour;
            start.Minute = minute;
            current_trip.StartTime = start;

            // parsing ending time
            Time end = new Time();
            times = endtime.Split(':');
            hour = Convert.ToInt32(times[0].Trim());
            minute = Convert.ToInt32(times[1].Trim());
            end.Hour = hour;
            end.Minute = minute;
            if(check_next_day.Checked)
            {
                end.Hour += 24;
            }
            current_trip.FinishTime = end;

            // trip speed
            current_trip.InitialSpeed = speed;

            // calculate total hour
            current_trip.Time = current_trip.Calculated_Duration(current_trip.StartTime, current_trip.FinishTime);

            // calculate cost
            current_trip.NetIncome = current_trip.Calculated_cost(current_trip.StartTime, current_trip.FinishTime);

            // calculate fuel level
            current_trip.Fuel = current_trip.Calculated_fuel_consumption(current_trip);

            // calculate mileage
            current_trip.Mileage = current_trip.Calculated_Mileage(current_trip);

            if((current_trip.Time.Hour <= 12) && (current_trip.Time.Hour >= 0))
            {
                trip_Created = true;
                MessageBox.Show("You drove for " + current_trip.Time.duration() + ".\nYou earned $" + current_trip.Calculated_cost(start, end).ToString() + ". " );
                this.Close();
            }
            else
            {
                MessageBox.Show("One trip cannot exceed 12 hrs\nStarting time cannot be later than finishing time");
            }
        }
    }
}
