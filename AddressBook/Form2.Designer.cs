namespace AddressBook
{
    partial class Form2
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
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblStreetNo = new System.Windows.Forms.Label();
            this.lblStreetName = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPincode = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtStreetNo = new System.Windows.Forms.TextBox();
            this.txtStreetName = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtPincode = new System.Windows.Forms.TextBox();
            this.cbProvince = new System.Windows.Forms.ComboBox();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblstatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.ForeColor = System.Drawing.Color.Black;
            this.lblFirst.Location = new System.Drawing.Point(45, 39);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(72, 13);
            this.lblFirst.TabIndex = 0;
            this.lblFirst.Text = "FIRST NAME";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.ForeColor = System.Drawing.Color.Black;
            this.lblLast.Location = new System.Drawing.Point(45, 71);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(68, 13);
            this.lblLast.TabIndex = 1;
            this.lblLast.Text = "LAST NAME";
            // 
            // lblStreetNo
            // 
            this.lblStreetNo.AutoSize = true;
            this.lblStreetNo.ForeColor = System.Drawing.Color.Black;
            this.lblStreetNo.Location = new System.Drawing.Point(45, 101);
            this.lblStreetNo.Name = "lblStreetNo";
            this.lblStreetNo.Size = new System.Drawing.Size(69, 13);
            this.lblStreetNo.TabIndex = 2;
            this.lblStreetNo.Text = "STREET NO";
            // 
            // lblStreetName
            // 
            this.lblStreetName.AutoSize = true;
            this.lblStreetName.ForeColor = System.Drawing.Color.Black;
            this.lblStreetName.Location = new System.Drawing.Point(45, 132);
            this.lblStreetName.Name = "lblStreetName";
            this.lblStreetName.Size = new System.Drawing.Size(81, 13);
            this.lblStreetName.TabIndex = 3;
            this.lblStreetName.Text = "STREETNAME";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.ForeColor = System.Drawing.Color.Black;
            this.lblContact.Location = new System.Drawing.Point(45, 164);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(58, 13);
            this.lblContact.TabIndex = 4;
            this.lblContact.Text = "CONTACT";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.ForeColor = System.Drawing.Color.Black;
            this.lblProvince.Location = new System.Drawing.Point(45, 192);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(62, 13);
            this.lblProvince.TabIndex = 5;
            this.lblProvince.Text = "PROVINCE";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.ForeColor = System.Drawing.Color.Black;
            this.lblCity.Location = new System.Drawing.Point(45, 225);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(31, 13);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "CITY";
            // 
            // lblPincode
            // 
            this.lblPincode.AutoSize = true;
            this.lblPincode.ForeColor = System.Drawing.Color.Black;
            this.lblPincode.Location = new System.Drawing.Point(45, 259);
            this.lblPincode.Name = "lblPincode";
            this.lblPincode.Size = new System.Drawing.Size(55, 13);
            this.lblPincode.TabIndex = 7;
            this.lblPincode.Text = "PINCODE";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(175, 36);
            this.txtFirst.MaxLength = 30;
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(121, 20);
            this.txtFirst.TabIndex = 8;
            this.txtFirst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.alphabetspressed);
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(175, 68);
            this.txtLast.MaxLength = 30;
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(121, 20);
            this.txtLast.TabIndex = 9;
            this.txtLast.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.alphabetspressed);
            // 
            // txtStreetNo
            // 
            this.txtStreetNo.Location = new System.Drawing.Point(175, 98);
            this.txtStreetNo.MaxLength = 10;
            this.txtStreetNo.Name = "txtStreetNo";
            this.txtStreetNo.Size = new System.Drawing.Size(121, 20);
            this.txtStreetNo.TabIndex = 10;
            this.txtStreetNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberpressed);
            // 
            // txtStreetName
            // 
            this.txtStreetName.Location = new System.Drawing.Point(175, 129);
            this.txtStreetName.MaxLength = 200;
            this.txtStreetName.Name = "txtStreetName";
            this.txtStreetName.Size = new System.Drawing.Size(121, 20);
            this.txtStreetName.TabIndex = 11;
            this.txtStreetName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.alphabetspressed);
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(175, 161);
            this.txtContact.MaxLength = 10;
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(121, 20);
            this.txtContact.TabIndex = 12;
            this.txtContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberpressed);
            // 
            // txtPincode
            // 
            this.txtPincode.Location = new System.Drawing.Point(175, 256);
            this.txtPincode.MaxLength = 6;
            this.txtPincode.Name = "txtPincode";
            this.txtPincode.Size = new System.Drawing.Size(121, 20);
            this.txtPincode.TabIndex = 13;
            // 
            // cbProvince
            // 
            this.cbProvince.FormattingEnabled = true;
            this.cbProvince.Location = new System.Drawing.Point(175, 192);
            this.cbProvince.MaxLength = 50;
            this.cbProvince.Name = "cbProvince";
            this.cbProvince.Size = new System.Drawing.Size(121, 21);
            this.cbProvince.TabIndex = 14;
            this.cbProvince.SelectionChangeCommitted += new System.EventHandler(this.provinceSelected);
            this.cbProvince.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.alphabetspressed);
            // 
            // cbCity
            // 
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(175, 222);
            this.cbCity.MaxLength = 50;
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(121, 21);
            this.cbCity.TabIndex = 15;
            this.cbCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.alphabetspressed);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(25, 326);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnCLICKED);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(277, 326);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(76, 23);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnCLICKED);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.ForeColor = System.Drawing.Color.Black;
            this.btnModify.Location = new System.Drawing.Point(110, 326);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(62, 23);
            this.btnModify.TabIndex = 18;
            this.btnModify.Text = "MODIFY";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnCLICKED);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(195, 326);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnCLICKED);
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.ForeColor = System.Drawing.Color.Black;
            this.lblstatus.Location = new System.Drawing.Point(107, 285);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(0, 13);
            this.lblstatus.TabIndex = 20;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.cbProvince);
            this.Controls.Add(this.txtPincode);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtStreetName);
            this.Controls.Add(this.txtStreetNo);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.lblPincode);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblProvince);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblStreetName);
            this.Controls.Add(this.lblStreetNo);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblFirst);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form2";
            this.Text = "MODIFY/DELETE ADDRESS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblStreetNo;
        private System.Windows.Forms.Label lblStreetName;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblPincode;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtStreetNo;
        private System.Windows.Forms.TextBox txtStreetName;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtPincode;
        private System.Windows.Forms.ComboBox cbProvince;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblstatus;
    }
}