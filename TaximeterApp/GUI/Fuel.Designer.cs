namespace TaximeterApp.GUI
{
    partial class Fuel
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
            this.cbo_payment = new MetroFramework.Controls.MetroComboBox();
            this.check_full = new MetroFramework.Controls.MetroCheckBox();
            this.lbl_payment = new MetroFramework.Controls.MetroLabel();
            this.btn_confirm = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lbl_current_price = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // cbo_payment
            // 
            this.cbo_payment.FormattingEnabled = true;
            this.cbo_payment.ItemHeight = 23;
            this.cbo_payment.Location = new System.Drawing.Point(558, 323);
            this.cbo_payment.Name = "cbo_payment";
            this.cbo_payment.Size = new System.Drawing.Size(121, 29);
            this.cbo_payment.TabIndex = 0;
            this.cbo_payment.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbo_payment.UseSelectable = true;
            // 
            // check_full
            // 
            this.check_full.AutoSize = true;
            this.check_full.Location = new System.Drawing.Point(708, 331);
            this.check_full.Name = "check_full";
            this.check_full.Size = new System.Drawing.Size(70, 15);
            this.check_full.TabIndex = 1;
            this.check_full.Text = "Full Tank";
            this.check_full.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.check_full.UseSelectable = true;
            this.check_full.CheckedChanged += new System.EventHandler(this.check_full_CheckedChanged);
            // 
            // lbl_payment
            // 
            this.lbl_payment.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_payment.Location = new System.Drawing.Point(420, 322);
            this.lbl_payment.Name = "lbl_payment";
            this.lbl_payment.Size = new System.Drawing.Size(132, 29);
            this.lbl_payment.TabIndex = 2;
            this.lbl_payment.Text = "P a y m e n t :";
            this.lbl_payment.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btn_confirm
            // 
            this.btn_confirm.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_confirm.Location = new System.Drawing.Point(652, 376);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(126, 42);
            this.btn_confirm.TabIndex = 3;
            this.btn_confirm.Text = "C o n f i r m";
            this.btn_confirm.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_confirm.UseSelectable = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(406, 284);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(198, 25);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "C u r r e n t   P r i c e : ";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(690, 284);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(39, 25);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "/  L";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbl_current_price
            // 
            this.lbl_current_price.AutoSize = true;
            this.lbl_current_price.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_current_price.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_current_price.Location = new System.Drawing.Point(637, 284);
            this.lbl_current_price.Name = "lbl_current_price";
            this.lbl_current_price.Size = new System.Drawing.Size(47, 25);
            this.lbl_current_price.TabIndex = 6;
            this.lbl_current_price.Text = "1.00";
            this.lbl_current_price.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(609, 284);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(22, 25);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "$";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Fuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.lbl_current_price);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.lbl_payment);
            this.Controls.Add(this.check_full);
            this.Controls.Add(this.cbo_payment);
            this.Name = "Fuel";
            this.Text = "F u e l";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Fuel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cbo_payment;
        private MetroFramework.Controls.MetroCheckBox check_full;
        private MetroFramework.Controls.MetroLabel lbl_payment;
        private MetroFramework.Controls.MetroButton btn_confirm;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lbl_current_price;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}