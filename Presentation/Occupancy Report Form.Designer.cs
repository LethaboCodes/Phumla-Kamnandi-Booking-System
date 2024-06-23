namespace Phumla_Kamandi_Booking_System.Presentation
{
    partial class Occupancy_Report_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Occupancy_Report_Form));
            this.occupancy_report_textbox = new System.Windows.Forms.TextBox();
            this.occupancy_report_back = new System.Windows.Forms.Button();
            this._occupancystartdatelabel = new System.Windows.Forms.Label();
            this.occupancy_start_datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.occupancy_end_datetimepicker = new System.Windows.Forms.DateTimePicker();
            this._occupancyenddatelabel = new System.Windows.Forms.Label();
            this.occupancy_report_generate_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // occupancy_report_textbox
            // 
            this.occupancy_report_textbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.occupancy_report_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occupancy_report_textbox.Location = new System.Drawing.Point(12, 99);
            this.occupancy_report_textbox.Multiline = true;
            this.occupancy_report_textbox.Name = "occupancy_report_textbox";
            this.occupancy_report_textbox.ReadOnly = true;
            this.occupancy_report_textbox.Size = new System.Drawing.Size(895, 386);
            this.occupancy_report_textbox.TabIndex = 0;
            this.occupancy_report_textbox.Text = "Occupancy Report";
            // 
            // occupancy_report_back
            // 
            this.occupancy_report_back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.occupancy_report_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occupancy_report_back.Location = new System.Drawing.Point(218, 504);
            this.occupancy_report_back.Name = "occupancy_report_back";
            this.occupancy_report_back.Size = new System.Drawing.Size(139, 43);
            this.occupancy_report_back.TabIndex = 1;
            this.occupancy_report_back.Text = "Back";
            this.occupancy_report_back.UseVisualStyleBackColor = true;
            this.occupancy_report_back.Click += new System.EventHandler(this.button1_Click);
            // 
            // _occupancystartdatelabel
            // 
            this._occupancystartdatelabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._occupancystartdatelabel.AutoSize = true;
            this._occupancystartdatelabel.BackColor = System.Drawing.Color.Transparent;
            this._occupancystartdatelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._occupancystartdatelabel.Location = new System.Drawing.Point(129, 23);
            this._occupancystartdatelabel.Name = "_occupancystartdatelabel";
            this._occupancystartdatelabel.Size = new System.Drawing.Size(296, 20);
            this._occupancystartdatelabel.TabIndex = 2;
            this._occupancystartdatelabel.Text = "Select Occupancy Report Sart Date";
            this._occupancystartdatelabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // occupancy_start_datetimepicker
            // 
            this.occupancy_start_datetimepicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.occupancy_start_datetimepicker.Location = new System.Drawing.Point(181, 61);
            this.occupancy_start_datetimepicker.Name = "occupancy_start_datetimepicker";
            this.occupancy_start_datetimepicker.Size = new System.Drawing.Size(200, 20);
            this.occupancy_start_datetimepicker.TabIndex = 4;
            // 
            // occupancy_end_datetimepicker
            // 
            this.occupancy_end_datetimepicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.occupancy_end_datetimepicker.Location = new System.Drawing.Point(555, 61);
            this.occupancy_end_datetimepicker.Name = "occupancy_end_datetimepicker";
            this.occupancy_end_datetimepicker.Size = new System.Drawing.Size(200, 20);
            this.occupancy_end_datetimepicker.TabIndex = 5;
            // 
            // _occupancyenddatelabel
            // 
            this._occupancyenddatelabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._occupancyenddatelabel.AutoSize = true;
            this._occupancyenddatelabel.BackColor = System.Drawing.Color.Transparent;
            this._occupancyenddatelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._occupancyenddatelabel.Location = new System.Drawing.Point(499, 23);
            this._occupancyenddatelabel.Name = "_occupancyenddatelabel";
            this._occupancyenddatelabel.Size = new System.Drawing.Size(294, 20);
            this._occupancyenddatelabel.TabIndex = 6;
            this._occupancyenddatelabel.Text = "Select Occupancy Reoprt End Date";
            this._occupancyenddatelabel.Click += new System.EventHandler(this._occupancyenddatelabel_Click);
            // 
            // occupancy_report_generate_button
            // 
            this.occupancy_report_generate_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.occupancy_report_generate_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.occupancy_report_generate_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occupancy_report_generate_button.Location = new System.Drawing.Point(12, 504);
            this.occupancy_report_generate_button.Name = "occupancy_report_generate_button";
            this.occupancy_report_generate_button.Size = new System.Drawing.Size(137, 43);
            this.occupancy_report_generate_button.TabIndex = 7;
            this.occupancy_report_generate_button.Text = "Generate";
            this.occupancy_report_generate_button.UseVisualStyleBackColor = true;
            this.occupancy_report_generate_button.Click += new System.EventHandler(this.occupancy_report_generate_button_Click);
            // 
            // Occupancy_Report_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(919, 570);
            this.Controls.Add(this.occupancy_report_generate_button);
            this.Controls.Add(this._occupancyenddatelabel);
            this.Controls.Add(this.occupancy_end_datetimepicker);
            this.Controls.Add(this.occupancy_start_datetimepicker);
            this.Controls.Add(this._occupancystartdatelabel);
            this.Controls.Add(this.occupancy_report_back);
            this.Controls.Add(this.occupancy_report_textbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Occupancy_Report_Form";
            this.Text = "Occupancy Report Form";
            this.Load += new System.EventHandler(this.Reports_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox occupancy_report_textbox;
        private System.Windows.Forms.Button occupancy_report_back;
        private System.Windows.Forms.Label _occupancystartdatelabel;
        private System.Windows.Forms.DateTimePicker occupancy_start_datetimepicker;
        private System.Windows.Forms.DateTimePicker occupancy_end_datetimepicker;
        private System.Windows.Forms.Label _occupancyenddatelabel;
        private System.Windows.Forms.Button occupancy_report_generate_button;
    }
}