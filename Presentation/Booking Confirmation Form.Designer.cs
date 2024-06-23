namespace Phumla_Kamandi_Booking_System.Presentation
{
    partial class Booking_Confirmation_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking_Confirmation_Form));
            this.details_confirmation_form_back_button = new System.Windows.Forms.Button();
            this.details_confirmation_form_confirmation_button = new System.Windows.Forms.Button();
            this.booking_confirmation_form_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // details_confirmation_form_back_button
            // 
            this.details_confirmation_form_back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.details_confirmation_form_back_button.Location = new System.Drawing.Point(464, 493);
            this.details_confirmation_form_back_button.Name = "details_confirmation_form_back_button";
            this.details_confirmation_form_back_button.Size = new System.Drawing.Size(101, 39);
            this.details_confirmation_form_back_button.TabIndex = 13;
            this.details_confirmation_form_back_button.Text = "Cancel";
            this.details_confirmation_form_back_button.UseVisualStyleBackColor = true;
            this.details_confirmation_form_back_button.Click += new System.EventHandler(this.details_confirmation_form_back_button_Click);
            // 
            // details_confirmation_form_confirmation_button
            // 
            this.details_confirmation_form_confirmation_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.details_confirmation_form_confirmation_button.Location = new System.Drawing.Point(265, 493);
            this.details_confirmation_form_confirmation_button.Name = "details_confirmation_form_confirmation_button";
            this.details_confirmation_form_confirmation_button.Size = new System.Drawing.Size(117, 39);
            this.details_confirmation_form_confirmation_button.TabIndex = 12;
            this.details_confirmation_form_confirmation_button.Text = "Confirm";
            this.details_confirmation_form_confirmation_button.UseVisualStyleBackColor = true;
            this.details_confirmation_form_confirmation_button.Click += new System.EventHandler(this.details_confirmation_form_confirmation_button_Click);
            // 
            // booking_confirmation_form_textbox
            // 
            this.booking_confirmation_form_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.booking_confirmation_form_textbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.booking_confirmation_form_textbox.Location = new System.Drawing.Point(120, 55);
            this.booking_confirmation_form_textbox.Multiline = true;
            this.booking_confirmation_form_textbox.Name = "booking_confirmation_form_textbox";
            this.booking_confirmation_form_textbox.ReadOnly = true;
            this.booking_confirmation_form_textbox.Size = new System.Drawing.Size(706, 348);
            this.booking_confirmation_form_textbox.TabIndex = 11;
            this.booking_confirmation_form_textbox.Text = "Booking Details";
            this.booking_confirmation_form_textbox.TextChanged += new System.EventHandler(this.booking_confirmation_form_textbox_TextChanged);
            // 
            // Booking_Confirmation_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 560);
            this.Controls.Add(this.details_confirmation_form_back_button);
            this.Controls.Add(this.details_confirmation_form_confirmation_button);
            this.Controls.Add(this.booking_confirmation_form_textbox);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Booking_Confirmation_Form";
            this.Text = "Booking Confirmation Form";
            this.Load += new System.EventHandler(this.Booking_Confirmation_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button details_confirmation_form_back_button;
        private System.Windows.Forms.Button details_confirmation_form_confirmation_button;
        private System.Windows.Forms.TextBox booking_confirmation_form_textbox;
    }
}