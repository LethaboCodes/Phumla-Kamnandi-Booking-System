namespace Phumla_Kamandi_Booking_System.Presentation
{
    partial class Booking_Listing_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking_Listing_Form));
            this.submitButton = new System.Windows.Forms.Button();
            this.booking_listing_back_button = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.room_number_textbox = new System.Windows.Forms.TextBox();
            this.amount_due_textbox = new System.Windows.Forms.TextBox();
            this.guest_id_textbox = new System.Windows.Forms.TextBox();
            this.booking_id_textbox = new System.Windows.Forms.TextBox();
            this._checkinlabel = new System.Windows.Forms.Label();
            this._roomnumberlabel = new System.Windows.Forms.Label();
            this._guestidlabel = new System.Windows.Forms.Label();
            this._bookingidlabel = new System.Windows.Forms.Label();
            this.BookingListView = new System.Windows.Forms.ListView();
            this.booking_listing_form_check_in_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.booking_listing_form_check_out_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.checkoutLabel = new System.Windows.Forms.Label();
            this._amountduelabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.submitButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(880, 517);
            this.submitButton.Margin = new System.Windows.Forms.Padding(2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(64, 34);
            this.submitButton.TabIndex = 51;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // booking_listing_back_button
            // 
            this.booking_listing_back_button.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.booking_listing_back_button.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booking_listing_back_button.Location = new System.Drawing.Point(1019, 517);
            this.booking_listing_back_button.Margin = new System.Windows.Forms.Padding(2);
            this.booking_listing_back_button.Name = "booking_listing_back_button";
            this.booking_listing_back_button.Size = new System.Drawing.Size(75, 34);
            this.booking_listing_back_button.TabIndex = 50;
            this.booking_listing_back_button.Text = "Back";
            this.booking_listing_back_button.UseVisualStyleBackColor = false;
            this.booking_listing_back_button.Click += new System.EventHandler(this.booking_listing_back_button_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteButton.BackgroundImage")));
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.Location = new System.Drawing.Point(657, 509);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(45, 47);
            this.deleteButton.TabIndex = 49;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editButton.BackgroundImage")));
            this.editButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editButton.Location = new System.Drawing.Point(548, 509);
            this.editButton.Margin = new System.Windows.Forms.Padding(2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(45, 47);
            this.editButton.TabIndex = 48;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // room_number_textbox
            // 
            this.room_number_textbox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_number_textbox.Location = new System.Drawing.Point(802, 203);
            this.room_number_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.room_number_textbox.Name = "room_number_textbox";
            this.room_number_textbox.Size = new System.Drawing.Size(50, 23);
            this.room_number_textbox.TabIndex = 47;
            // 
            // amount_due_textbox
            // 
            this.amount_due_textbox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_due_textbox.Location = new System.Drawing.Point(802, 463);
            this.amount_due_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.amount_due_textbox.Name = "amount_due_textbox";
            this.amount_due_textbox.Size = new System.Drawing.Size(142, 23);
            this.amount_due_textbox.TabIndex = 46;
            // 
            // guest_id_textbox
            // 
            this.guest_id_textbox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guest_id_textbox.Location = new System.Drawing.Point(800, 111);
            this.guest_id_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.guest_id_textbox.Name = "guest_id_textbox";
            this.guest_id_textbox.Size = new System.Drawing.Size(167, 23);
            this.guest_id_textbox.TabIndex = 43;
            // 
            // booking_id_textbox
            // 
            this.booking_id_textbox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booking_id_textbox.Location = new System.Drawing.Point(801, 42);
            this.booking_id_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.booking_id_textbox.Name = "booking_id_textbox";
            this.booking_id_textbox.Size = new System.Drawing.Size(168, 23);
            this.booking_id_textbox.TabIndex = 42;
            // 
            // _checkinlabel
            // 
            this._checkinlabel.AutoSize = true;
            this._checkinlabel.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._checkinlabel.Location = new System.Drawing.Point(797, 251);
            this._checkinlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._checkinlabel.Name = "_checkinlabel";
            this._checkinlabel.Size = new System.Drawing.Size(79, 17);
            this._checkinlabel.TabIndex = 40;
            this._checkinlabel.Text = "check-in date";
            // 
            // _roomnumberlabel
            // 
            this._roomnumberlabel.AutoSize = true;
            this._roomnumberlabel.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._roomnumberlabel.Location = new System.Drawing.Point(797, 161);
            this._roomnumberlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._roomnumberlabel.Name = "_roomnumberlabel";
            this._roomnumberlabel.Size = new System.Drawing.Size(83, 17);
            this._roomnumberlabel.TabIndex = 39;
            this._roomnumberlabel.Text = "Room Number";
            // 
            // _guestidlabel
            // 
            this._guestidlabel.AutoSize = true;
            this._guestidlabel.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._guestidlabel.Location = new System.Drawing.Point(798, 81);
            this._guestidlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._guestidlabel.Name = "_guestidlabel";
            this._guestidlabel.Size = new System.Drawing.Size(72, 17);
            this._guestidlabel.TabIndex = 38;
            this._guestidlabel.Text = "Guest Name";
            // 
            // _bookingidlabel
            // 
            this._bookingidlabel.AutoSize = true;
            this._bookingidlabel.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bookingidlabel.Location = new System.Drawing.Point(798, 14);
            this._bookingidlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._bookingidlabel.Name = "_bookingidlabel";
            this._bookingidlabel.Size = new System.Drawing.Size(67, 17);
            this._bookingidlabel.TabIndex = 36;
            this._bookingidlabel.Text = "Booking ID";
            // 
            // BookingListView
            // 
            this.BookingListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingListView.HideSelection = false;
            this.BookingListView.Location = new System.Drawing.Point(11, 47);
            this.BookingListView.Margin = new System.Windows.Forms.Padding(2);
            this.BookingListView.Name = "BookingListView";
            this.BookingListView.Size = new System.Drawing.Size(766, 436);
            this.BookingListView.TabIndex = 35;
            this.BookingListView.UseCompatibleStateImageBehavior = false;
            this.BookingListView.SelectedIndexChanged += new System.EventHandler(this.BookingListView_SelectedIndexChanged);
            // 
            // booking_listing_form_check_in_dateTimePicker
            // 
            this.booking_listing_form_check_in_dateTimePicker.Location = new System.Drawing.Point(800, 288);
            this.booking_listing_form_check_in_dateTimePicker.Name = "booking_listing_form_check_in_dateTimePicker";
            this.booking_listing_form_check_in_dateTimePicker.Size = new System.Drawing.Size(284, 26);
            this.booking_listing_form_check_in_dateTimePicker.TabIndex = 52;
            this.booking_listing_form_check_in_dateTimePicker.ValueChanged += new System.EventHandler(this.booking_listing_form_check_in_dateTimePicker_ValueChanged);
            // 
            // booking_listing_form_check_out_dateTimePicker
            // 
            this.booking_listing_form_check_out_dateTimePicker.Location = new System.Drawing.Point(802, 379);
            this.booking_listing_form_check_out_dateTimePicker.Name = "booking_listing_form_check_out_dateTimePicker";
            this.booking_listing_form_check_out_dateTimePicker.Size = new System.Drawing.Size(284, 26);
            this.booking_listing_form_check_out_dateTimePicker.TabIndex = 53;
            this.booking_listing_form_check_out_dateTimePicker.ValueChanged += new System.EventHandler(this.booking_listing_form_check_out_dateTimePicker_ValueChanged);
            // 
            // checkoutLabel
            // 
            this.checkoutLabel.AutoSize = true;
            this.checkoutLabel.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutLabel.Location = new System.Drawing.Point(799, 341);
            this.checkoutLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.checkoutLabel.Name = "checkoutLabel";
            this.checkoutLabel.Size = new System.Drawing.Size(79, 17);
            this.checkoutLabel.TabIndex = 54;
            this.checkoutLabel.Text = "check-in date";
            // 
            // _amountduelabel
            // 
            this._amountduelabel.AutoSize = true;
            this._amountduelabel.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._amountduelabel.Location = new System.Drawing.Point(799, 429);
            this._amountduelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._amountduelabel.Name = "_amountduelabel";
            this._amountduelabel.Size = new System.Drawing.Size(105, 17);
            this._amountduelabel.TabIndex = 55;
            this._amountduelabel.Text = "Total Amount Due";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "Listing of all Booking";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Booking_Listing_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1097, 585);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._amountduelabel);
            this.Controls.Add(this.checkoutLabel);
            this.Controls.Add(this.booking_listing_form_check_out_dateTimePicker);
            this.Controls.Add(this.booking_listing_form_check_in_dateTimePicker);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.booking_listing_back_button);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.room_number_textbox);
            this.Controls.Add(this.amount_due_textbox);
            this.Controls.Add(this.guest_id_textbox);
            this.Controls.Add(this.booking_id_textbox);
            this.Controls.Add(this._checkinlabel);
            this.Controls.Add(this._roomnumberlabel);
            this.Controls.Add(this._guestidlabel);
            this.Controls.Add(this._bookingidlabel);
            this.Controls.Add(this.BookingListView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Booking_Listing_Form";
            this.Text = "Booking Listing Form";
            this.Activated += new System.EventHandler(this.Booking_Listing_Form_Activated);
            this.Load += new System.EventHandler(this.Booking_Listing_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button booking_listing_back_button;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox room_number_textbox;
        private System.Windows.Forms.TextBox amount_due_textbox;
        private System.Windows.Forms.TextBox guest_id_textbox;
        private System.Windows.Forms.TextBox booking_id_textbox;
        private System.Windows.Forms.Label _checkinlabel;
        private System.Windows.Forms.Label _roomnumberlabel;
        private System.Windows.Forms.Label _guestidlabel;
        private System.Windows.Forms.Label _bookingidlabel;
        private System.Windows.Forms.ListView BookingListView;
        private System.Windows.Forms.DateTimePicker booking_listing_form_check_in_dateTimePicker;
        private System.Windows.Forms.DateTimePicker booking_listing_form_check_out_dateTimePicker;
        private System.Windows.Forms.Label checkoutLabel;
        private System.Windows.Forms.Label _amountduelabel;
        private System.Windows.Forms.Label label2;
    }
}