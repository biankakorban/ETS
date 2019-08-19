namespace View
{
    partial class Display
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxEmployees = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIDDis = new System.Windows.Forms.Label();
            this.txtPhoneDis = new System.Windows.Forms.TextBox();
            this.txtDOBDis = new System.Windows.Forms.TextBox();
            this.txtEmailDis = new System.Windows.Forms.TextBox();
            this.txtLNameDis = new System.Windows.Forms.TextBox();
            this.txtFNameDis = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumberOfEmp = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of employees";
            // 
            // listBoxEmployees
            // 
            this.listBoxEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEmployees.FormattingEnabled = true;
            this.listBoxEmployees.ItemHeight = 20;
            this.listBoxEmployees.Location = new System.Drawing.Point(47, 98);
            this.listBoxEmployees.Name = "listBoxEmployees";
            this.listBoxEmployees.Size = new System.Drawing.Size(266, 284);
            this.listBoxEmployees.TabIndex = 1;
            this.listBoxEmployees.SelectedIndexChanged += new System.EventHandler(this.listBoxEmployees_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.lblIDDis);
            this.groupBox1.Controls.Add(this.txtPhoneDis);
            this.groupBox1.Controls.Add(this.txtDOBDis);
            this.groupBox1.Controls.Add(this.txtEmailDis);
            this.groupBox1.Controls.Add(this.txtLNameDis);
            this.groupBox1.Controls.Add(this.txtFNameDis);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(340, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 288);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employees details";
            // 
            // lblIDDis
            // 
            this.lblIDDis.AutoSize = true;
            this.lblIDDis.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblIDDis.Location = new System.Drawing.Point(180, 41);
            this.lblIDDis.Name = "lblIDDis";
            this.lblIDDis.Size = new System.Drawing.Size(65, 20);
            this.lblIDDis.TabIndex = 14;
            this.lblIDDis.Text = "              ";
            // 
            // txtPhoneDis
            // 
            this.txtPhoneDis.Location = new System.Drawing.Point(162, 243);
            this.txtPhoneDis.Name = "txtPhoneDis";
            this.txtPhoneDis.Size = new System.Drawing.Size(235, 26);
            this.txtPhoneDis.TabIndex = 13;
            // 
            // txtDOBDis
            // 
            this.txtDOBDis.Location = new System.Drawing.Point(162, 199);
            this.txtDOBDis.Name = "txtDOBDis";
            this.txtDOBDis.Size = new System.Drawing.Size(235, 26);
            this.txtDOBDis.TabIndex = 12;
            // 
            // txtEmailDis
            // 
            this.txtEmailDis.Location = new System.Drawing.Point(162, 158);
            this.txtEmailDis.Name = "txtEmailDis";
            this.txtEmailDis.Size = new System.Drawing.Size(235, 26);
            this.txtEmailDis.TabIndex = 11;
            // 
            // txtLNameDis
            // 
            this.txtLNameDis.Location = new System.Drawing.Point(162, 118);
            this.txtLNameDis.Name = "txtLNameDis";
            this.txtLNameDis.Size = new System.Drawing.Size(235, 26);
            this.txtLNameDis.TabIndex = 10;
            // 
            // txtFNameDis
            // 
            this.txtFNameDis.Location = new System.Drawing.Point(162, 78);
            this.txtFNameDis.Name = "txtFNameDis";
            this.txtFNameDis.Size = new System.Drawing.Size(235, 26);
            this.txtFNameDis.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Phone Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Date of Birth:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "First Name:";
            // 
            // lblNumberOfEmp
            // 
            this.lblNumberOfEmp.AutoSize = true;
            this.lblNumberOfEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfEmp.Location = new System.Drawing.Point(43, 66);
            this.lblNumberOfEmp.Name = "lblNumberOfEmp";
            this.lblNumberOfEmp.Size = new System.Drawing.Size(163, 20);
            this.lblNumberOfEmp.TabIndex = 4;
            this.lblNumberOfEmp.Text = "Number of employees";
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(777, 404);
            this.Controls.Add(this.lblNumberOfEmp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxEmployees);
            this.Controls.Add(this.label1);
            this.Name = "Display";
            this.Text = "Display information";
            this.Load += new System.EventHandler(this.Display_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxEmployees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblIDDis;
        private System.Windows.Forms.TextBox txtPhoneDis;
        private System.Windows.Forms.TextBox txtDOBDis;
        private System.Windows.Forms.TextBox txtEmailDis;
        private System.Windows.Forms.TextBox txtLNameDis;
        private System.Windows.Forms.TextBox txtFNameDis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumberOfEmp;
    }
}