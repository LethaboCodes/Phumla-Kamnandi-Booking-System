namespace Phumla_Kamandi_Booking_System.Presentation
{
    partial class Details_Confirmation_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Details_Confirmation_Form));
            this.details_confirmation_form_textbox = new System.Windows.Forms.TextBox();
            this.details_confirmation_form_confirmation_button = new System.Windows.Forms.Button();
            this.details_confirmation_form_cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // details_confirmation_form_textbox
            // 
            this.details_confirmation_form_textbox.Location = new System.Drawing.Point(417, 38);
            this.details_confirmation_form_textbox.Multiline = true;
            this.details_confirmation_form_textbox.Name = "details_confirmation_form_textbox";
            this.details_confirmation_form_textbox.ReadOnly = true;
            this.details_confirmation_form_textbox.Size = new System.Drawing.Size(447, 348);
            this.details_confirmation_form_textbox.TabIndex = 0;
            this.details_confirmation_form_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // details_confirmation_form_confirmation_button
            // 
            this.details_confirmation_form_confirmation_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.details_confirmation_form_confirmation_button.Location = new System.Drawing.Point(417, 505);
            this.details_confirmation_form_confirmation_button.Name = "details_confirmation_form_confirmation_button";
            this.details_confirmation_form_confirmation_button.Size = new System.Drawing.Size(117, 39);
            this.details_confirmation_form_confirmation_button.TabIndex = 9;
            this.details_confirmation_form_confirmation_button.Text = "Confirm";
            this.details_confirmation_form_confirmation_button.UseVisualStyleBackColor = true;
            this.details_confirmation_form_confirmation_button.Click += new System.EventHandler(this.details_confirmation_form_confirmation_button_Click);
            // 
            // details_confirmation_form_cancel_button
            // 
            this.details_confirmation_form_cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.details_confirmation_form_cancel_button.Location = new System.Drawing.Point(607, 505);
            this.details_confirmation_form_cancel_button.Name = "details_confirmation_form_cancel_button";
            this.details_confirmation_form_cancel_button.Size = new System.Drawing.Size(101, 39);
            this.details_confirmation_form_cancel_button.TabIndex = 10;
            this.details_confirmation_form_cancel_button.Text = "Cancel Booking";
            this.details_confirmation_form_cancel_button.UseVisualStyleBackColor = true;
            this.details_confirmation_form_cancel_button.Click += new System.EventHandler(this.details_confirmation_form_cancel_button_Click);
            // 
            // Details_Confirmation_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(876, 573);
            this.Controls.Add(this.details_confirmation_form_cancel_button);
            this.Controls.Add(this.details_confirmation_form_confirmation_button);
            this.Controls.Add(this.details_confirmation_form_textbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Details_Confirmation_Form";
            this.Text = "Details Confirmation Form";
            this.Load += new System.EventHandler(this.Details_Confirmation_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox details_confirmation_form_textbox;
        private System.Windows.Forms.Button details_confirmation_form_confirmation_button;
        private System.Windows.Forms.Button details_confirmation_form_cancel_button;
    }
}