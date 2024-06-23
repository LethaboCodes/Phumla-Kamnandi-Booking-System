namespace Phumla_Kamandi_Booking_System.Presentation
{
    partial class Guest_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guest_Form));
            this._firstnamelabel = new System.Windows.Forms.Label();
            this._lastnamelabel = new System.Windows.Forms.Label();
            this._idlabel = new System.Windows.Forms.Label();
            this._phonelabel = new System.Windows.Forms.Label();
            this.first_name_textbox = new System.Windows.Forms.TextBox();
            this.id_textbox = new System.Windows.Forms.TextBox();
            this.last_name_textbox = new System.Windows.Forms.TextBox();
            this.phone_textbox = new System.Windows.Forms.TextBox();
            this.guest_form_create_reservation_button = new System.Windows.Forms.Button();
            this.guest_form_back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _firstnamelabel
            // 
            this._firstnamelabel.AutoSize = true;
            this._firstnamelabel.Location = new System.Drawing.Point(382, 175);
            this._firstnamelabel.Name = "_firstnamelabel";
            this._firstnamelabel.Size = new System.Drawing.Size(101, 24);
            this._firstnamelabel.TabIndex = 0;
            this._firstnamelabel.Text = "First Name";
            // 
            // _lastnamelabel
            // 
            this._lastnamelabel.AutoSize = true;
            this._lastnamelabel.Location = new System.Drawing.Point(605, 175);
            this._lastnamelabel.Name = "_lastnamelabel";
            this._lastnamelabel.Size = new System.Drawing.Size(99, 24);
            this._lastnamelabel.TabIndex = 1;
            this._lastnamelabel.Text = "Last Name";
            // 
            // _idlabel
            // 
            this._idlabel.AutoSize = true;
            this._idlabel.Location = new System.Drawing.Point(382, 289);
            this._idlabel.Name = "_idlabel";
            this._idlabel.Size = new System.Drawing.Size(27, 24);
            this._idlabel.TabIndex = 2;
            this._idlabel.Text = "ID";
            // 
            // _phonelabel
            // 
            this._phonelabel.AutoSize = true;
            this._phonelabel.Location = new System.Drawing.Point(382, 379);
            this._phonelabel.Name = "_phonelabel";
            this._phonelabel.Size = new System.Drawing.Size(66, 24);
            this._phonelabel.TabIndex = 3;
            this._phonelabel.Text = "Phone";
            // 
            // first_name_textbox
            // 
            this.first_name_textbox.Location = new System.Drawing.Point(383, 227);
            this.first_name_textbox.Name = "first_name_textbox";
            this.first_name_textbox.Size = new System.Drawing.Size(190, 29);
            this.first_name_textbox.TabIndex = 4;
            this.first_name_textbox.TextChanged += new System.EventHandler(this.first_name_textbox_TextChanged);
            this.first_name_textbox.Enter += new System.EventHandler(this.first_name_textbox_Enter);
            this.first_name_textbox.Leave += new System.EventHandler(this.first_name_textbox_Leave);
            // 
            // id_textbox
            // 
            this.id_textbox.Location = new System.Drawing.Point(383, 325);
            this.id_textbox.MaxLength = 13;
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.Size = new System.Drawing.Size(190, 29);
            this.id_textbox.TabIndex = 5;
            this.id_textbox.Enter += new System.EventHandler(this.id_textbox_Enter);
            this.id_textbox.Leave += new System.EventHandler(this.id_textbox_Leave);
            // 
            // last_name_textbox
            // 
            this.last_name_textbox.Location = new System.Drawing.Point(609, 227);
            this.last_name_textbox.Name = "last_name_textbox";
            this.last_name_textbox.Size = new System.Drawing.Size(190, 29);
            this.last_name_textbox.TabIndex = 6;
            this.last_name_textbox.Enter += new System.EventHandler(this.last_name_textbox_Enter);
            this.last_name_textbox.Leave += new System.EventHandler(this.last_name_textbox_Leave);
            // 
            // phone_textbox
            // 
            this.phone_textbox.Location = new System.Drawing.Point(383, 433);
            this.phone_textbox.MaxLength = 10;
            this.phone_textbox.Name = "phone_textbox";
            this.phone_textbox.Size = new System.Drawing.Size(190, 29);
            this.phone_textbox.TabIndex = 7;
            // 
            // guest_form_create_reservation_button
            // 
            this.guest_form_create_reservation_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guest_form_create_reservation_button.Location = new System.Drawing.Point(383, 499);
            this.guest_form_create_reservation_button.Name = "guest_form_create_reservation_button";
            this.guest_form_create_reservation_button.Size = new System.Drawing.Size(179, 39);
            this.guest_form_create_reservation_button.TabIndex = 8;
            this.guest_form_create_reservation_button.Text = "Create Reservation";
            this.guest_form_create_reservation_button.UseVisualStyleBackColor = true;
            this.guest_form_create_reservation_button.Click += new System.EventHandler(this.guest_form_submit_button_Click);
            // 
            // guest_form_back_button
            // 
            this.guest_form_back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guest_form_back_button.Location = new System.Drawing.Point(636, 499);
            this.guest_form_back_button.Name = "guest_form_back_button";
            this.guest_form_back_button.Size = new System.Drawing.Size(101, 39);
            this.guest_form_back_button.TabIndex = 9;
            this.guest_form_back_button.Text = "Back";
            this.guest_form_back_button.UseVisualStyleBackColor = true;
            this.guest_form_back_button.Click += new System.EventHandler(this.guest_form_back_button_Click);
            // 
            // Guest_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(851, 560);
            this.Controls.Add(this.guest_form_back_button);
            this.Controls.Add(this.guest_form_create_reservation_button);
            this.Controls.Add(this.phone_textbox);
            this.Controls.Add(this.last_name_textbox);
            this.Controls.Add(this.id_textbox);
            this.Controls.Add(this.first_name_textbox);
            this.Controls.Add(this._phonelabel);
            this.Controls.Add(this._idlabel);
            this.Controls.Add(this._lastnamelabel);
            this.Controls.Add(this._firstnamelabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Guest_Form";
            this.Text = "Guest Form";
            this.Load += new System.EventHandler(this.Guest_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _firstnamelabel;
        private System.Windows.Forms.Label _lastnamelabel;
        private System.Windows.Forms.Label _idlabel;
        private System.Windows.Forms.Label _phonelabel;
        private System.Windows.Forms.TextBox first_name_textbox;
        private System.Windows.Forms.TextBox id_textbox;
        private System.Windows.Forms.TextBox last_name_textbox;
        private System.Windows.Forms.TextBox phone_textbox;
        private System.Windows.Forms.Button guest_form_create_reservation_button;
        private System.Windows.Forms.Button guest_form_back_button;
    }
}