using System;
using TaximeterApp.Business;
using TaximeterApp.GUI;
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
    public partial class TaximeterApp : MetroFramework.Forms.MetroForm
    {
        public TaximeterApp()
        {
            InitializeComponent();
        }

        private NewTrip nt;
        private Fuel f;
        private TaxiMeter currentTM;
        private Trip currentTrip;

        public TaxiMeter CurrentTM
        {
            get { return currentTM; }
            set { currentTM = value; }
        }

        private void btn_newtrip_Click(object sender, EventArgs e)
        {
            if (nt == null)
            {
                nt = new NewTrip();
                nt.FormClosing += Nt_FormClosing;
                nt.Show();
            }            
        }

        private void Nt_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (nt.Trip_Created)
            {
                currentTrip = nt.Current_Trip;

                // check if the fuel is empty  >> if then take $100 from current net income, and add fuel ($ 20)
                if (currentTM.Fuel - currentTrip.Fuel <= 0)
                {
                    currentTM.NetIncome -= 100.00;
                    // create random price for the fuel
                    Random rnd = new Random();
                    int random = rnd.Next(15, 45);
                    string price = "1." + random.ToString();
                    double random_price = Convert.ToDouble(price);
                    MessageBox.Show("You have called a recharging service. You have spent $100(Service fee) and $50(Fuel charge).\nPrice for Fuel was :  $ " + price + " / liter");
                    currentTM.TaxiMeter_Renew(currentTM, currentTrip);
                    currentTM.Add_Fuel(random_price, 50.00, currentTM);
                    TaxiMeter_Reload(currentTM);
                }
                else
                {
                    // add current trip to the current taxi meter
                    currentTM.TaxiMeter_Renew(currentTM, currentTrip);
                    TaxiMeter_Reload(currentTM);
                }
            }
            nt = null;
        }

        private void btn_fuel_Click(object sender, EventArgs e)
        {
            if (f == null)
            {
                f = new Fuel();
                f.Current = CurrentTM;
                f.FormClosing += F_FormClosing;
                f.Show();
            }

        }

        private void F_FormClosing(object sender, FormClosingEventArgs e)
        {
            currentTM = f.Current;
            TaxiMeter_Reload(currentTM);
            f = null;
        }

        private void TaximeterApp_Load(object sender, EventArgs e)
        {
            // initializing the taximeter
            currentTM = new TaxiMeter();
            currentTM.Fuel = 50.0;
            currentTM.NetIncome = 50.00;
            currentTM.Mileage = 0;
            currentTM.NumberOfTrips = 0;

            // loading values from current taximeter
            TaxiMeter_Reload(currentTM);
        }

        private void TaxiMeter_Reload(TaxiMeter current)
        {
            this.lbl_fuellevel.Text = current.Fuel.ToString();
            this.lbl_income.Text = current.NetIncome.ToString();
            this.lbl_mileage.Text = current.Mileage.ToString();
            this.lbl_trips.Text = current.NumberOfTrips.ToString();

            // if the tank is empty, new trip button is disabled
            if (current.Fuel == 0) { btn_newtrip.Visible = false; }
        }
    }
}
