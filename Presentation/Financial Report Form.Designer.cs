namespace Phumla_Kamandi_Booking_System.Presentation
{
    partial class Financial_Report_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Financial_Report_Form));
            this.financial_report_back_button = new System.Windows.Forms.Button();
            this.financial_report_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // financial_report_back_button
            // 
            this.financial_report_back_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.financial_report_back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.financial_report_back_button.Location = new System.Drawing.Point(395, 486);
            this.financial_report_back_button.Name = "financial_report_back_button";
            this.financial_report_back_button.Size = new System.Drawing.Size(111, 37);
            this.financial_report_back_button.TabIndex = 2;
            this.financial_report_back_button.Text = "Back";
            this.financial_report_back_button.UseVisualStyleBackColor = true;
            this.financial_report_back_button.Click += new System.EventHandler(this.financial_report_back_button_Click);
            // 
            // financial_report_textbox
            // 
            this.financial_report_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.financial_report_textbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.financial_report_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.financial_report_textbox.Location = new System.Drawing.Point(36, 12);
            this.financial_report_textbox.Multiline = true;
            this.financial_report_textbox.Name = "financial_report_textbox";
            this.financial_report_textbox.ReadOnly = true;
            this.financial_report_textbox.Size = new System.Drawing.Size(812, 443);
            this.financial_report_textbox.TabIndex = 12;
            this.financial_report_textbox.Text = "Financial Report";
            // 
            // Financial_Report_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(860, 562);
            this.Controls.Add(this.financial_report_textbox);
            this.Controls.Add(this.financial_report_back_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Financial_Report_Form";
            this.Text = "Financial Report Form";
            this.Load += new System.EventHandler(this.Financial_Report_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button financial_report_back_button;
        private System.Windows.Forms.TextBox financial_report_textbox;
    }
}