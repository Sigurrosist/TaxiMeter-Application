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
    public partial class Fuel : MetroFramework.Forms.MetroForm
    {
        public Fuel()
        {
            InitializeComponent();
        }

        double currentprice = 0;
        private TaxiMeter current; 
        public TaxiMeter Current
        {
            get { return current; }
            set { current = value; }
        }
        private void Fuel_Load(object sender, EventArgs e)
        {
            // creating a random number for the fuel

            Random rnd = new Random();
            int random = rnd.Next(15, 45);
            string price = "1." + random.ToString();
            lbl_current_price.Text = price;

            // parsing the random price to double for calculation
            double random_price = Convert.ToDouble(price);
            currentprice = random_price;

            // adding options ($) for the payment combobox
            for (int i = 10; i <= 50; i += 10)
            {
                cbo_payment.Items.Add("$ " + i.ToString());
            }
        }

        private void check_full_CheckedChanged(object sender, EventArgs e)
        {
            if (check_full.Checked)
            {
                cbo_payment.Visible = false;
                lbl_payment.Visible = false;
            }
            else
            {
                cbo_payment.Visible = true;
                lbl_payment.Visible = true;
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            double liters = 0;
            double cost = 0;

            if (check_full.Checked)
            {
                liters = 100 - current.Fuel;
                cost = Math.Round(liters * currentprice);
                if (current.NetIncome < cost)
                {
                    MessageBox.Show("To make it full, you need $ " + cost + ". You only have $ " + current.NetIncome + ".");
                }
                else
                {
                    double change = current.Add_Fuel(currentprice, cost, current);
                    MessageBox.Show("The tank is full. You have spent $ " + cost.ToString() + ".");
                    this.Close();
                }
            }
            else
            {
                string c = cbo_payment.SelectedItem.ToString();
                c = c.Replace("$ ", "");
                cost = Convert.ToDouble(c);
                if (current.NetIncome < cost)
                {
                    double cc = cost - current.NetIncome;
                    MessageBox.Show("You only have $ " + current.NetIncome + ". To purchase $ " + cost + ", you need $ " + cc + " more.");
                }
                else
                {
                    double change = current.Add_Fuel(currentprice, cost, current);
                    if (change != 0)
                    {
                        MessageBox.Show("The tank is full and the change is $ " + change.ToString());
                        this.Close();
                    }
                    else
                    {
                        liters = cost / currentprice;
                        liters = Math.Round(liters, 2);
                        MessageBox.Show("You have added " + liters + " liter of fuel.\nCurrent fuel level is " + current.Fuel.ToString() + "%.");
                        this.Close();
                    }
                }
            }
        }
    }
}
