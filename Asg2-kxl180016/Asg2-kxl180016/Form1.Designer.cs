namespace Asg2_kxl180016
{
    partial class Form1
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
            this.FName = new System.Windows.Forms.Label();
            this.FNameBox = new System.Windows.Forms.TextBox();
            this.LName = new System.Windows.Forms.Label();
            this.LNameBox = new System.Windows.Forms.TextBox();
            this.Middle = new System.Windows.Forms.Label();
            this.MiddleBox = new System.Windows.Forms.TextBox();
            this.streetName = new System.Windows.Forms.Label();
            this.streetNameBox = new System.Windows.Forms.TextBox();
            this.streetNameBox2 = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Modify = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Warning = new System.Windows.Forms.Label();
            this.optional = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.CityBox = new System.Windows.Forms.TextBox();
            this.State = new System.Windows.Forms.Label();
            this.Zip = new System.Windows.Forms.Label();
            this.StateBox = new System.Windows.Forms.TextBox();
            this.ZipBox = new System.Windows.Forms.TextBox();
            this.Gender = new System.Windows.Forms.Label();
            this.GenderBox = new System.Windows.Forms.TextBox();
            this.GenderTip = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.ProofBox = new System.Windows.Forms.CheckBox();
            this.Date = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NameList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // FName
            // 
            this.FName.AutoSize = true;
            this.FName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FName.Location = new System.Drawing.Point(417, 22);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(68, 12);
            this.FName.TabIndex = 0;
            this.FName.Text = "First Name:";
            // 
            // FNameBox
            // 
            this.FNameBox.AcceptsTab = true;
            this.FNameBox.BackColor = System.Drawing.SystemColors.Window;
            this.FNameBox.Location = new System.Drawing.Point(417, 38);
            this.FNameBox.MaxLength = 20;
            this.FNameBox.Name = "FNameBox";
            this.FNameBox.Size = new System.Drawing.Size(217, 20);
            this.FNameBox.TabIndex = 1;
            this.FNameBox.Leave += new System.EventHandler(this.FNameBox_Leave);
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.LName.Location = new System.Drawing.Point(417, 112);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(67, 12);
            this.LName.TabIndex = 0;
            this.LName.Text = "Last Name:";
            // 
            // LNameBox
            // 
            this.LNameBox.AcceptsTab = true;
            this.LNameBox.Location = new System.Drawing.Point(417, 128);
            this.LNameBox.MaxLength = 20;
            this.LNameBox.Name = "LNameBox";
            this.LNameBox.Size = new System.Drawing.Size(217, 20);
            this.LNameBox.TabIndex = 3;
            // 
            // Middle
            // 
            this.Middle.AutoSize = true;
            this.Middle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.Middle.Location = new System.Drawing.Point(417, 67);
            this.Middle.Name = "Middle";
            this.Middle.Size = new System.Drawing.Size(77, 12);
            this.Middle.TabIndex = 0;
            this.Middle.Text = "Middle Initial:";
            // 
            // MiddleBox
            // 
            this.MiddleBox.AcceptsTab = true;
            this.MiddleBox.Location = new System.Drawing.Point(417, 83);
            this.MiddleBox.MaxLength = 1;
            this.MiddleBox.Name = "MiddleBox";
            this.MiddleBox.Size = new System.Drawing.Size(20, 20);
            this.MiddleBox.TabIndex = 2;
            this.MiddleBox.TextChanged += new System.EventHandler(this.MiddleBox_TextChanged);
            // 
            // streetName
            // 
            this.streetName.AutoSize = true;
            this.streetName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.streetName.Location = new System.Drawing.Point(417, 302);
            this.streetName.Name = "streetName";
            this.streetName.Size = new System.Drawing.Size(54, 12);
            this.streetName.TabIndex = 0;
            this.streetName.Text = "Address:";
            // 
            // streetNameBox
            // 
            this.streetNameBox.AcceptsTab = true;
            this.streetNameBox.Location = new System.Drawing.Point(417, 318);
            this.streetNameBox.MaxLength = 35;
            this.streetNameBox.Name = "streetNameBox";
            this.streetNameBox.Size = new System.Drawing.Size(217, 20);
            this.streetNameBox.TabIndex = 7;
            // 
            // streetNameBox2
            // 
            this.streetNameBox2.AcceptsTab = true;
            this.streetNameBox2.Location = new System.Drawing.Point(417, 344);
            this.streetNameBox2.MaxLength = 35;
            this.streetNameBox2.Name = "streetNameBox2";
            this.streetNameBox2.Size = new System.Drawing.Size(217, 20);
            this.streetNameBox2.TabIndex = 8;
            // 
            // Add
            // 
            this.Add.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Add.Location = new System.Drawing.Point(133, 637);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(96, 28);
            this.Add.TabIndex = 14;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // Modify
            // 
            this.Modify.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Modify.Location = new System.Drawing.Point(298, 637);
            this.Modify.Name = "Modify";
            this.Modify.Size = new System.Drawing.Size(96, 28);
            this.Modify.TabIndex = 15;
            this.Modify.Text = "Modify";
            this.Modify.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Delete.Location = new System.Drawing.Point(472, 637);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(96, 28);
            this.Delete.TabIndex = 16;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // Warning
            // 
            this.Warning.AutoSize = true;
            this.Warning.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Warning.ForeColor = System.Drawing.Color.Red;
            this.Warning.Location = new System.Drawing.Point(232, 603);
            this.Warning.Name = "Warning";
            this.Warning.Size = new System.Drawing.Size(70, 15);
            this.Warning.TabIndex = 0;
            this.Warning.Text = "Warning";
            this.Warning.Visible = false;
            // 
            // optional
            // 
            this.optional.AutoSize = true;
            this.optional.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.optional.Location = new System.Drawing.Point(448, 90);
            this.optional.Name = "optional";
            this.optional.Size = new System.Drawing.Size(58, 12);
            this.optional.TabIndex = 0;
            this.optional.Text = "(optional)";
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.City.Location = new System.Drawing.Point(417, 372);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(26, 12);
            this.City.TabIndex = 0;
            this.City.Text = "City";
            // 
            // CityBox
            // 
            this.CityBox.Location = new System.Drawing.Point(417, 388);
            this.CityBox.MaxLength = 25;
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(217, 20);
            this.CityBox.TabIndex = 9;
            // 
            // State
            // 
            this.State.AutoSize = true;
            this.State.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.State.Location = new System.Drawing.Point(417, 412);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(37, 12);
            this.State.TabIndex = 0;
            this.State.Text = "State:";
            // 
            // Zip
            // 
            this.Zip.AutoSize = true;
            this.Zip.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.Zip.Location = new System.Drawing.Point(417, 463);
            this.Zip.Name = "Zip";
            this.Zip.Size = new System.Drawing.Size(57, 12);
            this.Zip.TabIndex = 0;
            this.Zip.Text = "Zip Code:";
            // 
            // StateBox
            // 
            this.StateBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.StateBox.Location = new System.Drawing.Point(417, 429);
            this.StateBox.MaxLength = 2;
            this.StateBox.Name = "StateBox";
            this.StateBox.Size = new System.Drawing.Size(217, 20);
            this.StateBox.TabIndex = 10;
            // 
            // ZipBox
            // 
            this.ZipBox.Location = new System.Drawing.Point(417, 480);
            this.ZipBox.MaxLength = 9;
            this.ZipBox.Name = "ZipBox";
            this.ZipBox.Size = new System.Drawing.Size(217, 20);
            this.ZipBox.TabIndex = 11;
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.Gender.Location = new System.Drawing.Point(417, 159);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(47, 12);
            this.Gender.TabIndex = 0;
            this.Gender.Text = "Gender";
            // 
            // GenderBox
            // 
            this.GenderBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.GenderBox.Location = new System.Drawing.Point(417, 176);
            this.GenderBox.MaxLength = 1;
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.Size = new System.Drawing.Size(20, 20);
            this.GenderBox.TabIndex = 4;
            // 
            // GenderTip
            // 
            this.GenderTip.AutoSize = true;
            this.GenderTip.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.GenderTip.Location = new System.Drawing.Point(448, 179);
            this.GenderTip.Name = "GenderTip";
            this.GenderTip.Size = new System.Drawing.Size(38, 12);
            this.GenderTip.TabIndex = 0;
            this.GenderTip.Text = "(M / F)";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.Phone.Location = new System.Drawing.Point(417, 204);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(90, 12);
            this.Phone.TabIndex = 0;
            this.Phone.Text = "Phone Number:";
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(417, 221);
            this.PhoneBox.MaxLength = 21;
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(217, 20);
            this.PhoneBox.TabIndex = 5;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.Email.Location = new System.Drawing.Point(417, 249);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(38, 12);
            this.Email.TabIndex = 0;
            this.Email.Text = "Email:";
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(417, 266);
            this.EmailBox.MaxLength = 60;
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(217, 20);
            this.EmailBox.TabIndex = 6;
            // 
            // ProofBox
            // 
            this.ProofBox.AutoSize = true;
            this.ProofBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.ProofBox.Location = new System.Drawing.Point(417, 521);
            this.ProofBox.Name = "ProofBox";
            this.ProofBox.Size = new System.Drawing.Size(178, 16);
            this.ProofBox.TabIndex = 12;
            this.ProofBox.Text = "Proof of Purchase Attached";
            this.ProofBox.UseVisualStyleBackColor = true;
            this.ProofBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProofCheck);
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.Date.Location = new System.Drawing.Point(417, 552);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(31, 12);
            this.Date.TabIndex = 0;
            this.Date.Text = "Date";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(417, 569);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 20);
            this.textBox1.TabIndex = 13;
            // 
            // NameList
            // 
            this.NameList.FormattingEnabled = true;
            this.NameList.Location = new System.Drawing.Point(26, 38);
            this.NameList.Name = "NameList";
            this.NameList.Size = new System.Drawing.Size(368, 485);
            this.NameList.TabIndex = 17;
            // 
            // Form1
            // 
            this.AccessibleName = "Rebate";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 689);
            this.Controls.Add(this.NameList);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.ProofBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.GenderTip);
            this.Controls.Add(this.GenderBox);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.ZipBox);
            this.Controls.Add(this.StateBox);
            this.Controls.Add(this.Zip);
            this.Controls.Add(this.State);
            this.Controls.Add(this.CityBox);
            this.Controls.Add(this.City);
            this.Controls.Add(this.optional);
            this.Controls.Add(this.Warning);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Modify);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.streetNameBox2);
            this.Controls.Add(this.streetNameBox);
            this.Controls.Add(this.streetName);
            this.Controls.Add(this.MiddleBox);
            this.Controls.Add(this.Middle);
            this.Controls.Add(this.LNameBox);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.FNameBox);
            this.Controls.Add(this.FName);
            this.Name = "Form1";
            this.Text = "Rebate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FName;
        private System.Windows.Forms.TextBox FNameBox;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.TextBox LNameBox;
        private System.Windows.Forms.Label Middle;
        private System.Windows.Forms.TextBox MiddleBox;
        private System.Windows.Forms.Label streetName;
        private System.Windows.Forms.TextBox streetNameBox;
        private System.Windows.Forms.TextBox streetNameBox2;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Modify;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label Warning;
        private System.Windows.Forms.Label optional;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.TextBox CityBox;
        private System.Windows.Forms.Label State;
        private System.Windows.Forms.Label Zip;
        private System.Windows.Forms.TextBox StateBox;
        private System.Windows.Forms.TextBox ZipBox;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.TextBox GenderBox;
        private System.Windows.Forms.Label GenderTip;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.CheckBox ProofBox;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox NameList;
    }
}

