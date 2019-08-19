namespace View
{
    partial class DisplaySaveChangesEmp
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
            this.listBoxDisplaySaveChanges = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveEmp = new System.Windows.Forms.Button();
            this.txtPhoneSav = new System.Windows.Forms.TextBox();
            this.txtDOBSav = new System.Windows.Forms.TextBox();
            this.txtEmailSav = new System.Windows.Forms.TextBox();
            this.txtLNameSav = new System.Windows.Forms.TextBox();
            this.txtFNameSav = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIDSavEmp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumOfEmpSav = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of employees";
            // 
            // listBoxDisplaySaveChanges
            // 
            this.listBoxDisplaySaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDisplaySaveChanges.FormattingEnabled = true;
            this.listBoxDisplaySaveChanges.ItemHeight = 20;
            this.listBoxDisplaySaveChanges.Location = new System.Drawing.Point(26, 109);
            this.listBoxDisplaySaveChanges.Name = "listBoxDisplaySaveChanges";
            this.listBoxDisplaySaveChanges.Size = new System.Drawing.Size(220, 324);
            this.listBoxDisplaySaveChanges.TabIndex = 1;
            this.listBoxDisplaySaveChanges.SelectedIndexChanged += new System.EventHandler(this.listBoxDisplaySaveChanges_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.btnSaveEmp);
            this.groupBox1.Controls.Add(this.txtPhoneSav);
            this.groupBox1.Controls.Add(this.txtDOBSav);
            this.groupBox1.Controls.Add(this.txtEmailSav);
            this.groupBox1.Controls.Add(this.txtLNameSav);
            this.groupBox1.Controls.Add(this.txtFNameSav);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblIDSavEmp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(273, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 357);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update details";
            // 
            // btnSaveEmp
            // 
            this.btnSaveEmp.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSaveEmp.Location = new System.Drawing.Point(130, 300);
            this.btnSaveEmp.Name = "btnSaveEmp";
            this.btnSaveEmp.Size = new System.Drawing.Size(192, 37);
            this.btnSaveEmp.TabIndex = 12;
            this.btnSaveEmp.Text = "Save changes";
            this.btnSaveEmp.UseVisualStyleBackColor = false;
            this.btnSaveEmp.Click += new System.EventHandler(this.btnSaveEmp_Click);
            // 
            // txtPhoneSav
            // 
            this.txtPhoneSav.Location = new System.Drawing.Point(180, 255);
            this.txtPhoneSav.Name = "txtPhoneSav";
            this.txtPhoneSav.Size = new System.Drawing.Size(230, 26);
            this.txtPhoneSav.TabIndex = 11;
            // 
            // txtDOBSav
            // 
            this.txtDOBSav.Location = new System.Drawing.Point(180, 214);
            this.txtDOBSav.Name = "txtDOBSav";
            this.txtDOBSav.Size = new System.Drawing.Size(230, 26);
            this.txtDOBSav.TabIndex = 10;
            // 
            // txtEmailSav
            // 
            this.txtEmailSav.Location = new System.Drawing.Point(180, 169);
            this.txtEmailSav.Name = "txtEmailSav";
            this.txtEmailSav.Size = new System.Drawing.Size(230, 26);
            this.txtEmailSav.TabIndex = 9;
            // 
            // txtLNameSav
            // 
            this.txtLNameSav.Location = new System.Drawing.Point(180, 124);
            this.txtLNameSav.Name = "txtLNameSav";
            this.txtLNameSav.Size = new System.Drawing.Size(230, 26);
            this.txtLNameSav.TabIndex = 8;
            // 
            // txtFNameSav
            // 
            this.txtFNameSav.Location = new System.Drawing.Point(180, 81);
            this.txtFNameSav.Name = "txtFNameSav";
            this.txtFNameSav.Size = new System.Drawing.Size(230, 26);
            this.txtFNameSav.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Phone number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Date of Birth:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "First Name:";
            // 
            // lblIDSavEmp
            // 
            this.lblIDSavEmp.AutoSize = true;
            this.lblIDSavEmp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblIDSavEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDSavEmp.Location = new System.Drawing.Point(176, 36);
            this.lblIDSavEmp.Name = "lblIDSavEmp";
            this.lblIDSavEmp.Size = new System.Drawing.Size(41, 20);
            this.lblIDSavEmp.TabIndex = 1;
            this.lblIDSavEmp.Text = "        ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Employee ID:";
            // 
            // lblNumOfEmpSav
            // 
            this.lblNumOfEmpSav.AutoSize = true;
            this.lblNumOfEmpSav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfEmpSav.Location = new System.Drawing.Point(22, 76);
            this.lblNumOfEmpSav.Name = "lblNumOfEmpSav";
            this.lblNumOfEmpSav.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNumOfEmpSav.Size = new System.Drawing.Size(163, 20);
            this.lblNumOfEmpSav.TabIndex = 3;
            this.lblNumOfEmpSav.Text = "Number of employees";
            // 
            // DisplaySaveChangesEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(735, 445);
            this.Controls.Add(this.lblNumOfEmpSav);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxDisplaySaveChanges);
            this.Controls.Add(this.label1);
            this.Name = "DisplaySaveChangesEmp";
            this.Text = "DisplaySaveChangesEmp";
            this.Load += new System.EventHandler(this.DisplaySaveChangesEmp_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxDisplaySaveChanges;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaveEmp;
        private System.Windows.Forms.TextBox txtPhoneSav;
        private System.Windows.Forms.TextBox txtDOBSav;
        private System.Windows.Forms.TextBox txtEmailSav;
        private System.Windows.Forms.TextBox txtLNameSav;
        private System.Windows.Forms.TextBox txtFNameSav;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIDSavEmp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumOfEmpSav;
    }
}