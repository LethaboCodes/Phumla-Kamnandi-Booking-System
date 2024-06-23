namespace Phumla_Kamandi_Booking_System.Presentation
{
    partial class Payment_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.Payment_TextBox = new System.Windows.Forms.TextBox();
            this.payment_form_submit_button = new System.Windows.Forms.Button();
            this.payment_form_cancel_button = new System.Windows.Forms.Button();
            this.amount_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Credit Card Number";
            // 
            // Payment_TextBox
            // 
            this.Payment_TextBox.Location = new System.Drawing.Point(443, 252);
            this.Payment_TextBox.MaxLength = 10;
            this.Payment_TextBox.Name = "Payment_TextBox";
            this.Payment_TextBox.Size = new System.Drawing.Size(306, 29);
            this.Payment_TextBox.TabIndex = 1;
            this.Payment_TextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.Payment_TextBox.Enter += new System.EventHandler(this.Payment_TextBox_Enter);
            this.Payment_TextBox.Leave += new System.EventHandler(this.Payment_TextBox_Leave);
            // 
            // payment_form_submit_button
            // 
            this.payment_form_submit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_form_submit_button.Location = new System.Drawing.Point(443, 488);
            this.payment_form_submit_button.Name = "payment_form_submit_button";
            this.payment_form_submit_button.Size = new System.Drawing.Size(100, 39);
            this.payment_form_submit_button.TabIndex = 9;
            this.payment_form_submit_button.Text = "Submit";
            this.payment_form_submit_button.UseVisualStyleBackColor = true;
            this.payment_form_submit_button.Click += new System.EventHandler(this.payment_form_submit_button_Click);
            // 
            // payment_form_cancel_button
            // 
            this.payment_form_cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_form_cancel_button.Location = new System.Drawing.Point(601, 488);
            this.payment_form_cancel_button.Name = "payment_form_cancel_button";
            this.payment_form_cancel_button.Size = new System.Drawing.Size(101, 39);
            this.payment_form_cancel_button.TabIndex = 10;
            this.payment_form_cancel_button.Text = "Cancel";
            this.payment_form_cancel_button.UseVisualStyleBackColor = true;
            this.payment_form_cancel_button.Click += new System.EventHandler(this.payment_form_back_button_Click);
            // 
            // amount_textBox
            // 
            this.amount_textBox.Location = new System.Drawing.Point(443, 382);
            this.amount_textBox.Name = "amount_textBox";
            this.amount_textBox.Size = new System.Drawing.Size(100, 29);
            this.amount_textBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Amount";
            // 
            // Payment_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(875, 556);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amount_textBox);
            this.Controls.Add(this.payment_form_cancel_button);
            this.Controls.Add(this.payment_form_submit_button);
            this.Controls.Add(this.Payment_TextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Payment_Form";
            this.Text = "Payment Form";
            this.Load += new System.EventHandler(this.Payment_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Payment_TextBox;
        private System.Windows.Forms.Button payment_form_submit_button;
        private System.Windows.Forms.Button payment_form_cancel_button;
        private System.Windows.Forms.TextBox amount_textBox;
        private System.Windows.Forms.Label label2;
    }
}