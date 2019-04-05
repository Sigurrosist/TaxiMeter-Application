namespace TaximeterApp.GUI
{
    partial class NewTrip
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
            this.msm = new MetroFramework.Components.MetroStyleManager(this.components);
            this.cbo_speed = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btn_add_new_trip = new MetroFramework.Controls.MetroButton();
            this.starttimepicker = new System.Windows.Forms.DateTimePicker();
            this.endtimepicker = new System.Windows.Forms.DateTimePicker();
            this.check_next_day = new MetroFramework.Controls.MetroCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.msm)).BeginInit();
            this.SuspendLayout();
            // 
            // msm
            // 
            this.msm.Owner = null;
            // 
            // cbo_speed
            // 
            this.cbo_speed.FormattingEnabled = true;
            this.cbo_speed.ItemHeight = 23;
            this.cbo_speed.Location = new System.Drawing.Point(374, 412);
            this.cbo_speed.Name = "cbo_speed";
            this.cbo_speed.Size = new System.Drawing.Size(200, 29);
            this.cbo_speed.TabIndex = 2;
            this.cbo_speed.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbo_speed.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroLabel1.Location = new System.Drawing.Point(240, 278);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(133, 25);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "S t a r t   T i m e";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroLabel2.Location = new System.Drawing.Point(255, 329);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(118, 25);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "E n d   T i m e";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroLabel3.Location = new System.Drawing.Point(209, 412);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(164, 25);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "I n i t i a l   S p e e d";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btn_add_new_trip
            // 
            this.btn_add_new_trip.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_add_new_trip.Location = new System.Drawing.Point(580, 278);
            this.btn_add_new_trip.Name = "btn_add_new_trip";
            this.btn_add_new_trip.Size = new System.Drawing.Size(181, 163);
            this.btn_add_new_trip.TabIndex = 8;
            this.btn_add_new_trip.Text = "C o n f i r m";
            this.btn_add_new_trip.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_add_new_trip.UseCustomForeColor = true;
            this.btn_add_new_trip.UseSelectable = true;
            this.btn_add_new_trip.Click += new System.EventHandler(this.btn_add_new_trip_Click);
            // 
            // starttimepicker
            // 
            this.starttimepicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starttimepicker.CustomFormat = "HH : mm";
            this.starttimepicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.starttimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.starttimepicker.Location = new System.Drawing.Point(374, 278);
            this.starttimepicker.Name = "starttimepicker";
            this.starttimepicker.ShowUpDown = true;
            this.starttimepicker.Size = new System.Drawing.Size(200, 26);
            this.starttimepicker.TabIndex = 9;
            // 
            // endtimepicker
            // 
            this.endtimepicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endtimepicker.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaptionText;
            this.endtimepicker.CustomFormat = "HH : mm";
            this.endtimepicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.endtimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endtimepicker.Location = new System.Drawing.Point(374, 328);
            this.endtimepicker.Name = "endtimepicker";
            this.endtimepicker.ShowUpDown = true;
            this.endtimepicker.Size = new System.Drawing.Size(200, 26);
            this.endtimepicker.TabIndex = 10;
            // 
            // check_next_day
            // 
            this.check_next_day.AutoSize = true;
            this.check_next_day.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.check_next_day.Location = new System.Drawing.Point(285, 374);
            this.check_next_day.Name = "check_next_day";
            this.check_next_day.Size = new System.Drawing.Size(289, 19);
            this.check_next_day.TabIndex = 11;
            this.check_next_day.Text = "Please check if the trip ends in the next day";
            this.check_next_day.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.check_next_day.UseSelectable = true;
            // 
            // NewTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.check_next_day);
            this.Controls.Add(this.endtimepicker);
            this.Controls.Add(this.starttimepicker);
            this.Controls.Add(this.btn_add_new_trip);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cbo_speed);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Name = "NewTrip";
            this.Text = "A d d    a    n e w    t r i p";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.NewTrip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager msm;
        private MetroFramework.Controls.MetroComboBox cbo_speed;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btn_add_new_trip;
        private System.Windows.Forms.DateTimePicker starttimepicker;
        private System.Windows.Forms.DateTimePicker endtimepicker;
        private MetroFramework.Controls.MetroCheckBox check_next_day;
    }
}