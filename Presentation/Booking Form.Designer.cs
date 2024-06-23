namespace Phumla_Kamandi_Booking_System.Presentation
{
    partial class Booking_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking_Form));
            this._checkinlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.booking_form_check_out_dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.booking_form_check_in_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.booking_form_submit_button = new System.Windows.Forms.Button();
            this.booking_form_back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _checkinlabel
            // 
            this._checkinlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._checkinlabel.Location = new System.Drawing.Point(353, 101);
            this._checkinlabel.Name = "_checkinlabel";
            this._checkinlabel.Size = new System.Drawing.Size(143, 31);
            this._checkinlabel.TabIndex = 0;
            this._checkinlabel.Text = "Check-in date";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Check-out date";
            // 
            // booking_form_check_out_dateTimePicker1
            // 
            this.booking_form_check_out_dateTimePicker1.Location = new System.Drawing.Point(353, 264);
            this.booking_form_check_out_dateTimePicker1.Name = "booking_form_check_out_dateTimePicker1";
            this.booking_form_check_out_dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.booking_form_check_out_dateTimePicker1.TabIndex = 1;
            this.booking_form_check_out_dateTimePicker1.ValueChanged += new System.EventHandler(this.booking_form_check_out_dateTimePicker1_ValueChanged);
            // 
            // booking_form_check_in_dateTimePicker
            // 
            this.booking_form_check_in_dateTimePicker.Location = new System.Drawing.Point(353, 152);
            this.booking_form_check_in_dateTimePicker.Name = "booking_form_check_in_dateTimePicker";
            this.booking_form_check_in_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.booking_form_check_in_dateTimePicker.TabIndex = 2;
            this.booking_form_check_in_dateTimePicker.ValueChanged += new System.EventHandler(this.booking_form_check_in_dateTimePicker_ValueChanged);
            // 
            // booking_form_submit_button
            // 
            this.booking_form_submit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booking_form_submit_button.Location = new System.Drawing.Point(353, 347);
            this.booking_form_submit_button.Name = "booking_form_submit_button";
            this.booking_form_submit_button.Size = new System.Drawing.Size(117, 39);
            this.booking_form_submit_button.TabIndex = 3;
            this.booking_form_submit_button.Text = "Submit";
            this.booking_form_submit_button.UseVisualStyleBackColor = true;
            this.booking_form_submit_button.Click += new System.EventHandler(this.booking_form_submit_button_Click);
            // 
            // booking_form_back_button
            // 
            this.booking_form_back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booking_form_back_button.Location = new System.Drawing.Point(581, 347);
            this.booking_form_back_button.Name = "booking_form_back_button";
            this.booking_form_back_button.Size = new System.Drawing.Size(101, 39);
            this.booking_form_back_button.TabIndex = 4;
            this.booking_form_back_button.Text = "Back";
            this.booking_form_back_button.UseVisualStyleBackColor = true;
            this.booking_form_back_button.Click += new System.EventHandler(this.booking_form_back_button_Click);
            // 
            // Booking_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.booking_form_back_button);
            this.Controls.Add(this.booking_form_submit_button);
            this.Controls.Add(this.booking_form_check_in_dateTimePicker);
            this.Controls.Add(this.booking_form_check_out_dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._checkinlabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Booking_Form";
            this.Text = "Booking Form";
            this.Load += new System.EventHandler(this.Booking_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _checkinlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker booking_form_check_out_dateTimePicker1;
        private System.Windows.Forms.DateTimePicker booking_form_check_in_dateTimePicker;
        private System.Windows.Forms.Button booking_form_submit_button;
        private System.Windows.Forms.Button booking_form_back_button;
    }
}