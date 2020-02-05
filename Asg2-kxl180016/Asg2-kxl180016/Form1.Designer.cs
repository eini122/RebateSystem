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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Modify = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Warning = new System.Windows.Forms.Label();
            this.optional = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FName
            // 
            this.FName.AutoSize = true;
            this.FName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FName.Location = new System.Drawing.Point(415, 22);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(60, 13);
            this.FName.TabIndex = 0;
            this.FName.Text = "First Name:";
            // 
            // FNameBox
            // 
            this.FNameBox.AcceptsTab = true;
            this.FNameBox.Location = new System.Drawing.Point(418, 38);
            this.FNameBox.MaxLength = 20;
            this.FNameBox.Name = "FNameBox";
            this.FNameBox.Size = new System.Drawing.Size(132, 20);
            this.FNameBox.TabIndex = 1;
            this.FNameBox.Leave += new System.EventHandler(this.FNameBox_Leave);
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(414, 124);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(61, 13);
            this.LName.TabIndex = 0;
            this.LName.Text = "Last Name:";
            // 
            // LNameBox
            // 
            this.LNameBox.AcceptsTab = true;
            this.LNameBox.Location = new System.Drawing.Point(418, 140);
            this.LNameBox.MaxLength = 20;
            this.LNameBox.Name = "LNameBox";
            this.LNameBox.Size = new System.Drawing.Size(132, 20);
            this.LNameBox.TabIndex = 3;
            // 
            // Middle
            // 
            this.Middle.AutoSize = true;
            this.Middle.Location = new System.Drawing.Point(415, 73);
            this.Middle.Name = "Middle";
            this.Middle.Size = new System.Drawing.Size(68, 13);
            this.Middle.TabIndex = 0;
            this.Middle.Text = "Middle Initial:";
            // 
            // MiddleBox
            // 
            this.MiddleBox.AcceptsTab = true;
            this.MiddleBox.Location = new System.Drawing.Point(418, 89);
            this.MiddleBox.MaxLength = 1;
            this.MiddleBox.Name = "MiddleBox";
            this.MiddleBox.Size = new System.Drawing.Size(20, 20);
            this.MiddleBox.TabIndex = 2;
            this.MiddleBox.TextChanged += new System.EventHandler(this.MiddleBox_TextChanged);
            // 
            // streetName
            // 
            this.streetName.AutoSize = true;
            this.streetName.Location = new System.Drawing.Point(415, 176);
            this.streetName.Name = "streetName";
            this.streetName.Size = new System.Drawing.Size(48, 13);
            this.streetName.TabIndex = 0;
            this.streetName.Text = "Address:";
            // 
            // streetNameBox
            // 
            this.streetNameBox.AcceptsTab = true;
            this.streetNameBox.Location = new System.Drawing.Point(417, 192);
            this.streetNameBox.MaxLength = 35;
            this.streetNameBox.Name = "streetNameBox";
            this.streetNameBox.Size = new System.Drawing.Size(223, 20);
            this.streetNameBox.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.AcceptsTab = true;
            this.textBox1.Location = new System.Drawing.Point(417, 218);
            this.textBox1.MaxLength = 35;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 20);
            this.textBox1.TabIndex = 5;
            // 
            // Add
            // 
            this.Add.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Add.Location = new System.Drawing.Point(222, 663);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(96, 28);
            this.Add.TabIndex = 6;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // Modify
            // 
            this.Modify.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Modify.Location = new System.Drawing.Point(387, 663);
            this.Modify.Name = "Modify";
            this.Modify.Size = new System.Drawing.Size(96, 28);
            this.Modify.TabIndex = 7;
            this.Modify.Text = "Modify";
            this.Modify.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Delete.Location = new System.Drawing.Point(561, 663);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(96, 28);
            this.Delete.TabIndex = 8;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // Warning
            // 
            this.Warning.AutoSize = true;
            this.Warning.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Warning.ForeColor = System.Drawing.Color.Red;
            this.Warning.Location = new System.Drawing.Point(257, 610);
            this.Warning.Name = "Warning";
            this.Warning.Size = new System.Drawing.Size(70, 15);
            this.Warning.TabIndex = 9;
            this.Warning.Text = "Warning";
            this.Warning.Visible = false;
            // 
            // optional
            // 
            this.optional.AutoSize = true;
            this.optional.Location = new System.Drawing.Point(448, 96);
            this.optional.Name = "optional";
            this.optional.Size = new System.Drawing.Size(50, 13);
            this.optional.TabIndex = 10;
            this.optional.Text = "(optional)";
            // 
            // Form1
            // 
            this.AccessibleName = "Rebate";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.optional);
            this.Controls.Add(this.Warning);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Modify);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Modify;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label Warning;
        private System.Windows.Forms.Label optional;
    }
}

