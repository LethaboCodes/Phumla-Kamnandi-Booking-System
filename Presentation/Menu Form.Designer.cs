namespace Phumla_Kamandi_Booking_System.Presentation
{
    partial class Menu_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Form));
            this.financial_report_button = new System.Windows.Forms.Button();
            this.make_booking_button = new System.Windows.Forms.Button();
            this.occupancy_report_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.list_bookings_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // financial_report_button
            // 
            this.financial_report_button.Location = new System.Drawing.Point(64, 259);
            this.financial_report_button.Margin = new System.Windows.Forms.Padding(4);
            this.financial_report_button.Name = "financial_report_button";
            this.financial_report_button.Size = new System.Drawing.Size(221, 28);
            this.financial_report_button.TabIndex = 0;
            this.financial_report_button.Text = "Generate Financial Report";
            this.financial_report_button.UseVisualStyleBackColor = true;
            this.financial_report_button.Click += new System.EventHandler(this.financial_report_button_Click);
            // 
            // make_booking_button
            // 
            this.make_booking_button.Location = new System.Drawing.Point(64, 111);
            this.make_booking_button.Margin = new System.Windows.Forms.Padding(4);
            this.make_booking_button.Name = "make_booking_button";
            this.make_booking_button.Size = new System.Drawing.Size(221, 28);
            this.make_booking_button.TabIndex = 1;
            this.make_booking_button.Text = "Make A Booking";
            this.make_booking_button.UseVisualStyleBackColor = true;
            this.make_booking_button.Click += new System.EventHandler(this.make_booking_button_Click);
            // 
            // occupancy_report_button
            // 
            this.occupancy_report_button.Location = new System.Drawing.Point(64, 330);
            this.occupancy_report_button.Margin = new System.Windows.Forms.Padding(4);
            this.occupancy_report_button.Name = "occupancy_report_button";
            this.occupancy_report_button.Size = new System.Drawing.Size(221, 28);
            this.occupancy_report_button.TabIndex = 2;
            this.occupancy_report_button.Text = "Generate Occupancy Reprt";
            this.occupancy_report_button.UseVisualStyleBackColor = true;
            this.occupancy_report_button.Click += new System.EventHandler(this.occupancy_report_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Option";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // list_bookings_button
            // 
            this.list_bookings_button.Location = new System.Drawing.Point(64, 187);
            this.list_bookings_button.Margin = new System.Windows.Forms.Padding(4);
            this.list_bookings_button.Name = "list_bookings_button";
            this.list_bookings_button.Size = new System.Drawing.Size(221, 28);
            this.list_bookings_button.TabIndex = 4;
            this.list_bookings_button.Text = "Manage Booking";
            this.list_bookings_button.UseVisualStyleBackColor = true;
            this.list_bookings_button.Click += new System.EventHandler(this.list_bookings_button_Click);
            // 
            // Menu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(996, 500);
            this.Controls.Add(this.list_bookings_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.occupancy_report_button);
            this.Controls.Add(this.make_booking_button);
            this.Controls.Add(this.financial_report_button);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu_Form";
            this.Text = "Menu Form";
            this.Load += new System.EventHandler(this.Menu_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button financial_report_button;
        private System.Windows.Forms.Button make_booking_button;
        private System.Windows.Forms.Button occupancy_report_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button list_bookings_button;
    }
}