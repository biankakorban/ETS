namespace View
{
    partial class AddWorkingHours
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
            this.listBoxNumOfEmpWorkHours = new System.Windows.Forms.ListBox();
            this.lblListOfEmpHours = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblIDHours = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtWorkDate = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRecord = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Working Hours";
            // 
            // listBoxNumOfEmpWorkHours
            // 
            this.listBoxNumOfEmpWorkHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNumOfEmpWorkHours.FormattingEnabled = true;
            this.listBoxNumOfEmpWorkHours.ItemHeight = 20;
            this.listBoxNumOfEmpWorkHours.Location = new System.Drawing.Point(26, 93);
            this.listBoxNumOfEmpWorkHours.Name = "listBoxNumOfEmpWorkHours";
            this.listBoxNumOfEmpWorkHours.Size = new System.Drawing.Size(181, 264);
            this.listBoxNumOfEmpWorkHours.TabIndex = 1;
            this.listBoxNumOfEmpWorkHours.SelectedIndexChanged += new System.EventHandler(this.listBoxNumOfEmpWorkHours_SelectedIndexChanged);
            // 
            // lblListOfEmpHours
            // 
            this.lblListOfEmpHours.AutoSize = true;
            this.lblListOfEmpHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListOfEmpHours.Location = new System.Drawing.Point(23, 62);
            this.lblListOfEmpHours.Name = "lblListOfEmpHours";
            this.lblListOfEmpHours.Size = new System.Drawing.Size(155, 20);
            this.lblListOfEmpHours.TabIndex = 2;
            this.lblListOfEmpHours.Text = "Number of employee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Employee ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "First Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Last Name:";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(138, 103);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(138, 26);
            this.txtFName.TabIndex = 6;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(138, 154);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(138, 26);
            this.txtLName.TabIndex = 7;
            // 
            // lblIDHours
            // 
            this.lblIDHours.AutoSize = true;
            this.lblIDHours.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIDHours.Location = new System.Drawing.Point(143, 61);
            this.lblIDHours.Name = "lblIDHours";
            this.lblIDHours.Size = new System.Drawing.Size(61, 20);
            this.lblIDHours.TabIndex = 8;
            this.lblIDHours.Text = "             ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Work Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(306, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Hours:";
            // 
            // txtWorkDate
            // 
            this.txtWorkDate.Location = new System.Drawing.Point(417, 103);
            this.txtWorkDate.Name = "txtWorkDate";
            this.txtWorkDate.Size = new System.Drawing.Size(100, 26);
            this.txtWorkDate.TabIndex = 11;
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(417, 154);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(100, 26);
            this.txtHours.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.btnRecord);
            this.groupBox1.Controls.Add(this.lblIDHours);
            this.groupBox1.Controls.Add(this.txtHours);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtWorkDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtFName);
            this.groupBox1.Controls.Add(this.txtLName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(213, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 264);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Record Hours";
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRecord.Location = new System.Drawing.Point(356, 210);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(161, 39);
            this.btnRecord.TabIndex = 14;
            this.btnRecord.Text = "Record Hours";
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // AddWorkingHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(786, 378);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblListOfEmpHours);
            this.Controls.Add(this.listBoxNumOfEmpWorkHours);
            this.Controls.Add(this.label1);
            this.Name = "AddWorkingHours";
            this.Text = "AddWorkingHours";
            this.Load += new System.EventHandler(this.AddWorkingHours_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxNumOfEmpWorkHours;
        private System.Windows.Forms.Label lblListOfEmpHours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblIDHours;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtWorkDate;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRecord;
    }
}