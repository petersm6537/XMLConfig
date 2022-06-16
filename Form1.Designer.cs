namespace XMLConfig
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
            this.writeToXMLOutput = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.inputMoldID = new System.Windows.Forms.TextBox();
            this.inputRevisionNumber = new System.Windows.Forms.TextBox();
            this.inputID = new System.Windows.Forms.NumericUpDown();
            this.inputXS = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.importXMLOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputXS)).BeginInit();
            this.SuspendLayout();
            // 
            // writeToXMLOutput
            // 
            this.writeToXMLOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.writeToXMLOutput.Location = new System.Drawing.Point(145, 175);
            this.writeToXMLOutput.Name = "writeToXMLOutput";
            this.writeToXMLOutput.Size = new System.Drawing.Size(136, 37);
            this.writeToXMLOutput.TabIndex = 4;
            this.writeToXMLOutput.Text = "Write to XML";
            this.writeToXMLOutput.UseVisualStyleBackColor = true;
            this.writeToXMLOutput.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.writeToXMLOutput, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.inputMoldID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.inputRevisionNumber, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.inputID, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.inputXS, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 261);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Part #";
            // 
            // inputMoldID
            // 
            this.inputMoldID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputMoldID.Location = new System.Drawing.Point(145, 3);
            this.inputMoldID.Name = "inputMoldID";
            this.inputMoldID.Size = new System.Drawing.Size(136, 20);
            this.inputMoldID.TabIndex = 0;
            this.inputMoldID.Text = "1-123";
            // 
            // inputRevisionNumber
            // 
            this.inputRevisionNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputRevisionNumber.Location = new System.Drawing.Point(145, 46);
            this.inputRevisionNumber.Name = "inputRevisionNumber";
            this.inputRevisionNumber.Size = new System.Drawing.Size(136, 20);
            this.inputRevisionNumber.TabIndex = 1;
            this.inputRevisionNumber.Text = "PRA1";
            // 
            // inputID
            // 
            this.inputID.DecimalPlaces = 4;
            this.inputID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputID.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.inputID.Location = new System.Drawing.Point(145, 89);
            this.inputID.Name = "inputID";
            this.inputID.Size = new System.Drawing.Size(136, 20);
            this.inputID.TabIndex = 2;
            this.inputID.Value = new decimal(new int[] {
            625,
            0,
            0,
            196608});
            // 
            // inputXS
            // 
            this.inputXS.DecimalPlaces = 4;
            this.inputXS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputXS.Increment = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.inputXS.Location = new System.Drawing.Point(145, 132);
            this.inputXS.Name = "inputXS";
            this.inputXS.Size = new System.Drawing.Size(136, 20);
            this.inputXS.TabIndex = 3;
            this.inputXS.Value = new decimal(new int[] {
            75,
            0,
            0,
            196608});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Revision #";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "XS";
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(3, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 37);
            this.button2.TabIndex = 9;
            this.button2.Text = "ImportXML";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // importXMLOpenFileDialog
            // 
            this.importXMLOpenFileDialog.InitialDirectory = ".\\";
            // 
            // Form1
            // 
            this.AcceptButton = this.writeToXMLOutput;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form1";
            this.Text = "Configuration Creator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputXS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button writeToXMLOutput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputMoldID;
        private System.Windows.Forms.TextBox inputRevisionNumber;
        private System.Windows.Forms.NumericUpDown inputID;
        private System.Windows.Forms.NumericUpDown inputXS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog importXMLOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

