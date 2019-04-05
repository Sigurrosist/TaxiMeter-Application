namespace TaximeterApp.GUI
{
    partial class TaximeterApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaximeterApp));
            this.PanelNetIncome = new MetroFramework.Controls.MetroPanel();
            this.lbl_income = new System.Windows.Forms.Label();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.PanelFuelLevel = new MetroFramework.Controls.MetroPanel();
            this.lbl_fuellevel = new System.Windows.Forms.Label();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.PanelNumberTrips = new MetroFramework.Controls.MetroPanel();
            this.lbl_trips = new System.Windows.Forms.Label();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.PanelMileage = new MetroFramework.Controls.MetroPanel();
            this.lbl_mileage = new System.Windows.Forms.Label();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.msm = new MetroFramework.Components.MetroStyleManager(this.components);
            this.btn_newtrip = new MetroFramework.Controls.MetroButton();
            this.btn_fuel = new MetroFramework.Controls.MetroButton();
            this.PanelNetIncome.SuspendLayout();
            this.PanelFuelLevel.SuspendLayout();
            this.PanelNumberTrips.SuspendLayout();
            this.PanelMileage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msm)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelNetIncome
            // 
            this.PanelNetIncome.BackColor = System.Drawing.Color.Black;
            this.PanelNetIncome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PanelNetIncome.Controls.Add(this.lbl_income);
            this.PanelNetIncome.Controls.Add(this.metroLabel5);
            this.PanelNetIncome.Controls.Add(this.metroLabel1);
            this.PanelNetIncome.HorizontalScrollbarBarColor = true;
            this.PanelNetIncome.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelNetIncome.HorizontalScrollbarSize = 10;
            this.PanelNetIncome.Location = new System.Drawing.Point(24, 80);
            this.PanelNetIncome.Name = "PanelNetIncome";
            this.PanelNetIncome.Size = new System.Drawing.Size(367, 187);
            this.PanelNetIncome.TabIndex = 0;
            this.PanelNetIncome.UseCustomBackColor = true;
            this.PanelNetIncome.VerticalScrollbarBarColor = true;
            this.PanelNetIncome.VerticalScrollbarHighlightOnWheel = false;
            this.PanelNetIncome.VerticalScrollbarSize = 10;
            // 
            // lbl_income
            // 
            this.lbl_income.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_income.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_income.Location = new System.Drawing.Point(130, 69);
            this.lbl_income.Name = "lbl_income";
            this.lbl_income.Size = new System.Drawing.Size(90, 49);
            this.lbl_income.TabIndex = 8;
            this.lbl_income.Text = "0";
            this.lbl_income.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Location = new System.Drawing.Point(135, 85);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(109, 23);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "$";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel5.UseCustomBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(13, 14);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(233, 23);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "N e t   I n c o m e";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // PanelFuelLevel
            // 
            this.PanelFuelLevel.BackColor = System.Drawing.Color.Black;
            this.PanelFuelLevel.Controls.Add(this.lbl_fuellevel);
            this.PanelFuelLevel.Controls.Add(this.metroLabel6);
            this.PanelFuelLevel.Controls.Add(this.metroLabel2);
            this.PanelFuelLevel.HorizontalScrollbarBarColor = true;
            this.PanelFuelLevel.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelFuelLevel.HorizontalScrollbarSize = 10;
            this.PanelFuelLevel.Location = new System.Drawing.Point(397, 80);
            this.PanelFuelLevel.Name = "PanelFuelLevel";
            this.PanelFuelLevel.Size = new System.Drawing.Size(367, 187);
            this.PanelFuelLevel.TabIndex = 2;
            this.PanelFuelLevel.UseCustomBackColor = true;
            this.PanelFuelLevel.VerticalScrollbarBarColor = true;
            this.PanelFuelLevel.VerticalScrollbarHighlightOnWheel = false;
            this.PanelFuelLevel.VerticalScrollbarSize = 10;
            // 
            // lbl_fuellevel
            // 
            this.lbl_fuellevel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_fuellevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fuellevel.Location = new System.Drawing.Point(133, 69);
            this.lbl_fuellevel.Name = "lbl_fuellevel";
            this.lbl_fuellevel.Size = new System.Drawing.Size(90, 49);
            this.lbl_fuellevel.TabIndex = 9;
            this.lbl_fuellevel.Text = "0";
            this.lbl_fuellevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel6
            // 
            this.metroLabel6.Location = new System.Drawing.Point(229, 85);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(109, 23);
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "%";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel6.UseCustomBackColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(15, 14);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(190, 36);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "F u e l    L e v e l";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // PanelNumberTrips
            // 
            this.PanelNumberTrips.BackColor = System.Drawing.Color.Black;
            this.PanelNumberTrips.Controls.Add(this.lbl_trips);
            this.PanelNumberTrips.Controls.Add(this.metroLabel7);
            this.PanelNumberTrips.Controls.Add(this.metroLabel3);
            this.PanelNumberTrips.HorizontalScrollbarBarColor = true;
            this.PanelNumberTrips.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelNumberTrips.HorizontalScrollbarSize = 10;
            this.PanelNumberTrips.Location = new System.Drawing.Point(24, 273);
            this.PanelNumberTrips.Name = "PanelNumberTrips";
            this.PanelNumberTrips.Size = new System.Drawing.Size(163, 187);
            this.PanelNumberTrips.TabIndex = 2;
            this.PanelNumberTrips.UseCustomBackColor = true;
            this.PanelNumberTrips.VerticalScrollbarBarColor = true;
            this.PanelNumberTrips.VerticalScrollbarHighlightOnWheel = false;
            this.PanelNumberTrips.VerticalScrollbarSize = 10;
            // 
            // lbl_trips
            // 
            this.lbl_trips.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_trips.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_trips.Location = new System.Drawing.Point(22, 86);
            this.lbl_trips.Name = "lbl_trips";
            this.lbl_trips.Size = new System.Drawing.Size(67, 65);
            this.lbl_trips.TabIndex = 9;
            this.lbl_trips.Text = "0";
            this.lbl_trips.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel7
            // 
            this.metroLabel7.Location = new System.Drawing.Point(95, 108);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(65, 23);
            this.metroLabel7.TabIndex = 9;
            this.metroLabel7.Text = "T i m e s";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel7.UseCustomBackColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(13, 15);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(124, 41);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "T r i p s";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // PanelMileage
            // 
            this.PanelMileage.BackColor = System.Drawing.Color.Black;
            this.PanelMileage.Controls.Add(this.lbl_mileage);
            this.PanelMileage.Controls.Add(this.metroLabel8);
            this.PanelMileage.Controls.Add(this.metroLabel4);
            this.PanelMileage.Controls.Add(this.label8);
            this.PanelMileage.HorizontalScrollbarBarColor = true;
            this.PanelMileage.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelMileage.HorizontalScrollbarSize = 10;
            this.PanelMileage.Location = new System.Drawing.Point(193, 273);
            this.PanelMileage.Name = "PanelMileage";
            this.PanelMileage.Size = new System.Drawing.Size(367, 187);
            this.PanelMileage.TabIndex = 3;
            this.PanelMileage.UseCustomBackColor = true;
            this.PanelMileage.VerticalScrollbarBarColor = true;
            this.PanelMileage.VerticalScrollbarHighlightOnWheel = false;
            this.PanelMileage.VerticalScrollbarSize = 10;
            // 
            // lbl_mileage
            // 
            this.lbl_mileage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_mileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mileage.Location = new System.Drawing.Point(59, 86);
            this.lbl_mileage.Name = "lbl_mileage";
            this.lbl_mileage.Size = new System.Drawing.Size(167, 65);
            this.lbl_mileage.TabIndex = 10;
            this.lbl_mileage.Text = "0";
            this.lbl_mileage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel8
            // 
            this.metroLabel8.Location = new System.Drawing.Point(232, 108);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(121, 23);
            this.metroLabel8.TabIndex = 10;
            this.metroLabel8.Text = "M i l e a g e s";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel8.UseCustomBackColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(19, 15);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(124, 41);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "M i l e a g e";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LimeGreen;
            this.label8.Location = new System.Drawing.Point(-166, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 41);
            this.label8.TabIndex = 6;
            this.label8.Text = "N E T   I N C O M E";
            // 
            // msm
            // 
            this.msm.Owner = null;
            this.msm.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btn_newtrip
            // 
            this.btn_newtrip.BackColor = System.Drawing.Color.Black;
            this.btn_newtrip.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_newtrip.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_newtrip.Location = new System.Drawing.Point(566, 273);
            this.btn_newtrip.Name = "btn_newtrip";
            this.btn_newtrip.Size = new System.Drawing.Size(198, 121);
            this.btn_newtrip.TabIndex = 4;
            this.btn_newtrip.Text = "N e w   t r i p";
            this.btn_newtrip.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_newtrip.UseCustomBackColor = true;
            this.btn_newtrip.UseCustomForeColor = true;
            this.btn_newtrip.UseSelectable = true;
            this.btn_newtrip.Click += new System.EventHandler(this.btn_newtrip_Click);
            // 
            // btn_fuel
            // 
            this.btn_fuel.BackColor = System.Drawing.Color.Black;
            this.btn_fuel.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_fuel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_fuel.Location = new System.Drawing.Point(566, 400);
            this.btn_fuel.Name = "btn_fuel";
            this.btn_fuel.Size = new System.Drawing.Size(198, 60);
            this.btn_fuel.TabIndex = 5;
            this.btn_fuel.Text = "F u e l";
            this.btn_fuel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_fuel.UseCustomBackColor = true;
            this.btn_fuel.UseCustomForeColor = true;
            this.btn_fuel.UseSelectable = true;
            this.btn_fuel.Click += new System.EventHandler(this.btn_fuel_Click);
            // 
            // TaximeterApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btn_fuel);
            this.Controls.Add(this.btn_newtrip);
            this.Controls.Add(this.PanelMileage);
            this.Controls.Add(this.PanelNumberTrips);
            this.Controls.Add(this.PanelFuelLevel);
            this.Controls.Add(this.PanelNetIncome);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Name = "TaximeterApp";
            this.Text = "T A X I   M E T E R";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.TaximeterApp_Load);
            this.PanelNetIncome.ResumeLayout(false);
            this.PanelFuelLevel.ResumeLayout(false);
            this.PanelNumberTrips.ResumeLayout(false);
            this.PanelMileage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.msm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel PanelNetIncome;
        private MetroFramework.Controls.MetroPanel PanelFuelLevel;
        private MetroFramework.Controls.MetroPanel PanelNumberTrips;
        private MetroFramework.Controls.MetroPanel PanelMileage;
        private MetroFramework.Components.MetroStyleManager msm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_income;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Label lbl_fuellevel;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Label lbl_trips;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Label lbl_mileage;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btn_newtrip;
        private MetroFramework.Controls.MetroButton btn_fuel;
    }
}