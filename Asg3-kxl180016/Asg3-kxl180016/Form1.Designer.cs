namespace Asg3_kxl180016
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
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.MinRecord = new System.Windows.Forms.Label();
            this.MaxRecord = new System.Windows.Forms.Label();
            this.AvergeRecord = new System.Windows.Forms.Label();
            this.MinimumInter = new System.Windows.Forms.Label();
            this.MaximumInter = new System.Windows.Forms.Label();
            this.AverageInter = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.TotalBack = new System.Windows.Forms.Label();
            this.recordsNumber = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Analyze = new System.Windows.Forms.Button();
            this.SelectFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.recordsNumberDisplay = new System.Windows.Forms.Label();
            this.MinRecordDisplay = new System.Windows.Forms.Label();
            this.MaxRecordDisplay = new System.Windows.Forms.Label();
            this.AveRecordDisplay = new System.Windows.Forms.Label();
            this.MinInterDisplay = new System.Windows.Forms.Label();
            this.MaxInterDisplay = new System.Windows.Forms.Label();
            this.AveInterDisplay = new System.Windows.Forms.Label();
            this.TotalDisplay = new System.Windows.Forms.Label();
            this.BackCountDisplay = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Help = new System.Windows.Forms.Label();
            this.Help2 = new System.Windows.Forms.Label();
            this.tableLayout.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout
            // 
            this.tableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayout.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayout.ColumnCount = 2;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.51534F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.48466F));
            this.tableLayout.Controls.Add(this.MinRecord, 0, 1);
            this.tableLayout.Controls.Add(this.MaxRecord, 0, 2);
            this.tableLayout.Controls.Add(this.AvergeRecord, 0, 3);
            this.tableLayout.Controls.Add(this.MinimumInter, 0, 4);
            this.tableLayout.Controls.Add(this.MaximumInter, 0, 5);
            this.tableLayout.Controls.Add(this.AverageInter, 0, 6);
            this.tableLayout.Controls.Add(this.Total, 0, 7);
            this.tableLayout.Controls.Add(this.TotalBack, 0, 8);
            this.tableLayout.Controls.Add(this.recordsNumber, 0, 0);
            this.tableLayout.Controls.Add(this.recordsNumberDisplay, 1, 0);
            this.tableLayout.Controls.Add(this.MinRecordDisplay, 1, 1);
            this.tableLayout.Controls.Add(this.MaxRecordDisplay, 1, 2);
            this.tableLayout.Controls.Add(this.AveRecordDisplay, 1, 3);
            this.tableLayout.Controls.Add(this.MinInterDisplay, 1, 4);
            this.tableLayout.Controls.Add(this.MaxInterDisplay, 1, 5);
            this.tableLayout.Controls.Add(this.AveInterDisplay, 1, 6);
            this.tableLayout.Controls.Add(this.TotalDisplay, 1, 7);
            this.tableLayout.Controls.Add(this.BackCountDisplay, 1, 8);
            this.tableLayout.Location = new System.Drawing.Point(59, 22);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 9;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayout.Size = new System.Drawing.Size(652, 291);
            this.tableLayout.TabIndex = 0;
            this.tableLayout.Visible = false;
            // 
            // MinRecord
            // 
            this.MinRecord.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MinRecord.AutoSize = true;
            this.MinRecord.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinRecord.Location = new System.Drawing.Point(88, 38);
            this.MinRecord.Name = "MinRecord";
            this.MinRecord.Size = new System.Drawing.Size(121, 20);
            this.MinRecord.TabIndex = 1;
            this.MinRecord.Text = "Minimum entry time:";
            // 
            // MaxRecord
            // 
            this.MaxRecord.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MaxRecord.AutoSize = true;
            this.MaxRecord.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxRecord.Location = new System.Drawing.Point(82, 70);
            this.MaxRecord.Name = "MaxRecord";
            this.MaxRecord.Size = new System.Drawing.Size(127, 20);
            this.MaxRecord.TabIndex = 2;
            this.MaxRecord.Text = "Maximum entry time: ";
            // 
            // AvergeRecord
            // 
            this.AvergeRecord.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AvergeRecord.AutoSize = true;
            this.AvergeRecord.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvergeRecord.Location = new System.Drawing.Point(94, 102);
            this.AvergeRecord.Name = "AvergeRecord";
            this.AvergeRecord.Size = new System.Drawing.Size(115, 20);
            this.AvergeRecord.TabIndex = 3;
            this.AvergeRecord.Text = "Average entry time: ";
            // 
            // MinimumInter
            // 
            this.MinimumInter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MinimumInter.AutoSize = true;
            this.MinimumInter.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumInter.Location = new System.Drawing.Point(47, 134);
            this.MinimumInter.Name = "MinimumInter";
            this.MinimumInter.Size = new System.Drawing.Size(162, 20);
            this.MinimumInter.TabIndex = 4;
            this.MinimumInter.Text = "Minimum inter-record time: ";
            // 
            // MaximumInter
            // 
            this.MaximumInter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MaximumInter.AutoSize = true;
            this.MaximumInter.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumInter.Location = new System.Drawing.Point(44, 166);
            this.MaximumInter.Name = "MaximumInter";
            this.MaximumInter.Size = new System.Drawing.Size(165, 20);
            this.MaximumInter.TabIndex = 5;
            this.MaximumInter.Text = "Maximum inter-record time: ";
            // 
            // AverageInter
            // 
            this.AverageInter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AverageInter.AutoSize = true;
            this.AverageInter.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageInter.Location = new System.Drawing.Point(59, 198);
            this.AverageInter.Name = "AverageInter";
            this.AverageInter.Size = new System.Drawing.Size(150, 20);
            this.AverageInter.TabIndex = 6;
            this.AverageInter.Text = "Average inter-record time:";
            // 
            // Total
            // 
            this.Total.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(138, 230);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(71, 20);
            this.Total.TabIndex = 7;
            this.Total.Text = "Total time: ";
            // 
            // TotalBack
            // 
            this.TotalBack.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TotalBack.AutoSize = true;
            this.TotalBack.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBack.Location = new System.Drawing.Point(101, 263);
            this.TotalBack.Name = "TotalBack";
            this.TotalBack.Size = new System.Drawing.Size(108, 20);
            this.TotalBack.TabIndex = 8;
            this.TotalBack.Text = "Backspace count:";
            // 
            // recordsNumber
            // 
            this.recordsNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.recordsNumber.AutoSize = true;
            this.recordsNumber.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordsNumber.Location = new System.Drawing.Point(94, 6);
            this.recordsNumber.Name = "recordsNumber";
            this.recordsNumber.Size = new System.Drawing.Size(115, 20);
            this.recordsNumber.TabIndex = 0;
            this.recordsNumber.Text = "Number of records:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.Analyze);
            this.panel1.Controls.Add(this.SelectFile);
            this.panel1.Location = new System.Drawing.Point(59, 356);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 44);
            this.panel1.TabIndex = 1;
            // 
            // Analyze
            // 
            this.Analyze.AutoSize = true;
            this.Analyze.Enabled = false;
            this.Analyze.Location = new System.Drawing.Point(382, 0);
            this.Analyze.Name = "Analyze";
            this.Analyze.Size = new System.Drawing.Size(167, 41);
            this.Analyze.TabIndex = 1;
            this.Analyze.Text = "Analyze";
            this.Analyze.UseVisualStyleBackColor = true;
            this.Analyze.Click += new System.EventHandler(this.Analyze_Click);
            // 
            // SelectFile
            // 
            this.SelectFile.AutoSize = true;
            this.SelectFile.Location = new System.Drawing.Point(105, 0);
            this.SelectFile.Name = "SelectFile";
            this.SelectFile.Size = new System.Drawing.Size(167, 41);
            this.SelectFile.TabIndex = 0;
            this.SelectFile.Text = "Select File";
            this.SelectFile.UseVisualStyleBackColor = true;
            this.SelectFile.Click += new System.EventHandler(this.Select_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // recordsNumberDisplay
            // 
            this.recordsNumberDisplay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.recordsNumberDisplay.AutoSize = true;
            this.recordsNumberDisplay.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.recordsNumberDisplay.Location = new System.Drawing.Point(215, 6);
            this.recordsNumberDisplay.Name = "recordsNumberDisplay";
            this.recordsNumberDisplay.Size = new System.Drawing.Size(43, 20);
            this.recordsNumberDisplay.TabIndex = 9;
            this.recordsNumberDisplay.Text = "label1";
            // 
            // MinRecordDisplay
            // 
            this.MinRecordDisplay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MinRecordDisplay.AutoSize = true;
            this.MinRecordDisplay.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.MinRecordDisplay.Location = new System.Drawing.Point(215, 38);
            this.MinRecordDisplay.Name = "MinRecordDisplay";
            this.MinRecordDisplay.Size = new System.Drawing.Size(43, 20);
            this.MinRecordDisplay.TabIndex = 10;
            this.MinRecordDisplay.Text = "label2";
            // 
            // MaxRecordDisplay
            // 
            this.MaxRecordDisplay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MaxRecordDisplay.AutoSize = true;
            this.MaxRecordDisplay.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.MaxRecordDisplay.Location = new System.Drawing.Point(215, 70);
            this.MaxRecordDisplay.Name = "MaxRecordDisplay";
            this.MaxRecordDisplay.Size = new System.Drawing.Size(43, 20);
            this.MaxRecordDisplay.TabIndex = 11;
            this.MaxRecordDisplay.Text = "label3";
            // 
            // AveRecordDisplay
            // 
            this.AveRecordDisplay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AveRecordDisplay.AutoSize = true;
            this.AveRecordDisplay.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.AveRecordDisplay.Location = new System.Drawing.Point(215, 102);
            this.AveRecordDisplay.Name = "AveRecordDisplay";
            this.AveRecordDisplay.Size = new System.Drawing.Size(43, 20);
            this.AveRecordDisplay.TabIndex = 12;
            this.AveRecordDisplay.Text = "label4";
            // 
            // MinInterDisplay
            // 
            this.MinInterDisplay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MinInterDisplay.AutoSize = true;
            this.MinInterDisplay.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.MinInterDisplay.Location = new System.Drawing.Point(215, 134);
            this.MinInterDisplay.Name = "MinInterDisplay";
            this.MinInterDisplay.Size = new System.Drawing.Size(43, 20);
            this.MinInterDisplay.TabIndex = 13;
            this.MinInterDisplay.Text = "label5";
            // 
            // MaxInterDisplay
            // 
            this.MaxInterDisplay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MaxInterDisplay.AutoSize = true;
            this.MaxInterDisplay.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.MaxInterDisplay.Location = new System.Drawing.Point(215, 166);
            this.MaxInterDisplay.Name = "MaxInterDisplay";
            this.MaxInterDisplay.Size = new System.Drawing.Size(43, 20);
            this.MaxInterDisplay.TabIndex = 14;
            this.MaxInterDisplay.Text = "label6";
            // 
            // AveInterDisplay
            // 
            this.AveInterDisplay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AveInterDisplay.AutoSize = true;
            this.AveInterDisplay.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.AveInterDisplay.Location = new System.Drawing.Point(215, 198);
            this.AveInterDisplay.Name = "AveInterDisplay";
            this.AveInterDisplay.Size = new System.Drawing.Size(43, 20);
            this.AveInterDisplay.TabIndex = 15;
            this.AveInterDisplay.Text = "label7";
            // 
            // TotalDisplay
            // 
            this.TotalDisplay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TotalDisplay.AutoSize = true;
            this.TotalDisplay.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.TotalDisplay.Location = new System.Drawing.Point(215, 230);
            this.TotalDisplay.Name = "TotalDisplay";
            this.TotalDisplay.Size = new System.Drawing.Size(43, 20);
            this.TotalDisplay.TabIndex = 16;
            this.TotalDisplay.Text = "label8";
            // 
            // BackCountDisplay
            // 
            this.BackCountDisplay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BackCountDisplay.AutoSize = true;
            this.BackCountDisplay.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.BackCountDisplay.Location = new System.Drawing.Point(215, 263);
            this.BackCountDisplay.Name = "BackCountDisplay";
            this.BackCountDisplay.Size = new System.Drawing.Size(43, 20);
            this.BackCountDisplay.TabIndex = 17;
            this.BackCountDisplay.Text = "label9";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.Help2);
            this.panel2.Controls.Add(this.Help);
            this.panel2.Location = new System.Drawing.Point(59, 407);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(652, 31);
            this.panel2.TabIndex = 2;
            // 
            // Help
            // 
            this.Help.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Help.AutoSize = true;
            this.Help.Location = new System.Drawing.Point(83, 9);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(210, 13);
            this.Help.TabIndex = 0;
            this.Help.Text = "Click Select File to choos txt file for analyze";
            // 
            // Help2
            // 
            this.Help2.AutoSize = true;
            this.Help2.Location = new System.Drawing.Point(363, 9);
            this.Help2.Name = "Help2";
            this.Help2.Size = new System.Drawing.Size(186, 13);
            this.Help2.TabIndex = 1;
            this.Help2.Text = "Click Analyze button to view the result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayout);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Record Analyze";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.Label MinRecord;
        private System.Windows.Forms.Label MaxRecord;
        private System.Windows.Forms.Label AvergeRecord;
        private System.Windows.Forms.Label MinimumInter;
        private System.Windows.Forms.Label MaximumInter;
        private System.Windows.Forms.Label AverageInter;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label TotalBack;
        private System.Windows.Forms.Label recordsNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Analyze;
        private System.Windows.Forms.Button SelectFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label recordsNumberDisplay;
        private System.Windows.Forms.Label MinRecordDisplay;
        private System.Windows.Forms.Label MaxRecordDisplay;
        private System.Windows.Forms.Label AveRecordDisplay;
        private System.Windows.Forms.Label MinInterDisplay;
        private System.Windows.Forms.Label MaxInterDisplay;
        private System.Windows.Forms.Label AveInterDisplay;
        private System.Windows.Forms.Label TotalDisplay;
        private System.Windows.Forms.Label BackCountDisplay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Help2;
        private System.Windows.Forms.Label Help;
    }
}

