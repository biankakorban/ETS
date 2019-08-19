namespace View
{
    partial class SelectEmployeeByID_Email
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
            this.rdoID = new System.Windows.Forms.RadioButton();
            this.rdoEmail = new System.Windows.Forms.RadioButton();
            this.txtSearchByID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchBy = new System.Windows.Forms.Button();
            this.listBoxEmployeeSearchBy = new System.Windows.Forms.ListBox();
            this.txtSearchByEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rdoID
            // 
            this.rdoID.AutoSize = true;
            this.rdoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoID.Location = new System.Drawing.Point(127, 99);
            this.rdoID.Name = "rdoID";
            this.rdoID.Size = new System.Drawing.Size(122, 24);
            this.rdoID.TabIndex = 0;
            this.rdoID.TabStop = true;
            this.rdoID.Text = "Employee ID:";
            this.rdoID.UseVisualStyleBackColor = true;
            this.rdoID.CheckedChanged += new System.EventHandler(this.rdoID_CheckedChanged);
            // 
            // rdoEmail
            // 
            this.rdoEmail.AutoSize = true;
            this.rdoEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoEmail.Location = new System.Drawing.Point(127, 139);
            this.rdoEmail.Name = "rdoEmail";
            this.rdoEmail.Size = new System.Drawing.Size(144, 24);
            this.rdoEmail.TabIndex = 1;
            this.rdoEmail.TabStop = true;
            this.rdoEmail.Text = "Employee Email:";
            this.rdoEmail.UseVisualStyleBackColor = true;
            this.rdoEmail.CheckedChanged += new System.EventHandler(this.rdoEmail_CheckedChanged);
            // 
            // txtSearchByID
            // 
            this.txtSearchByID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByID.Location = new System.Drawing.Point(316, 97);
            this.txtSearchByID.Name = "txtSearchByID";
            this.txtSearchByID.Size = new System.Drawing.Size(263, 26);
            this.txtSearchByID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Employee by ID or Email";
            // 
            // btnSearchBy
            // 
            this.btnSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBy.Location = new System.Drawing.Point(273, 199);
            this.btnSearchBy.Name = "btnSearchBy";
            this.btnSearchBy.Size = new System.Drawing.Size(132, 40);
            this.btnSearchBy.TabIndex = 20;
            this.btnSearchBy.Text = "Search";
            this.btnSearchBy.UseVisualStyleBackColor = true;
            this.btnSearchBy.Click += new System.EventHandler(this.btnSearchBy_Click);
            // 
            // listBoxEmployeeSearchBy
            // 
            this.listBoxEmployeeSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEmployeeSearchBy.FormattingEnabled = true;
            this.listBoxEmployeeSearchBy.HorizontalScrollbar = true;
            this.listBoxEmployeeSearchBy.ItemHeight = 20;
            this.listBoxEmployeeSearchBy.Location = new System.Drawing.Point(139, 260);
            this.listBoxEmployeeSearchBy.Name = "listBoxEmployeeSearchBy";
            this.listBoxEmployeeSearchBy.Size = new System.Drawing.Size(413, 244);
            this.listBoxEmployeeSearchBy.TabIndex = 23;
            this.listBoxEmployeeSearchBy.UseWaitCursor = true;
            // 
            // txtSearchByEmail
            // 
            this.txtSearchByEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByEmail.Location = new System.Drawing.Point(316, 137);
            this.txtSearchByEmail.Name = "txtSearchByEmail";
            this.txtSearchByEmail.Size = new System.Drawing.Size(263, 26);
            this.txtSearchByEmail.TabIndex = 24;
            // 
            // SelectEmployeeByID_Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(673, 541);
            this.Controls.Add(this.txtSearchByEmail);
            this.Controls.Add(this.listBoxEmployeeSearchBy);
            this.Controls.Add(this.btnSearchBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchByID);
            this.Controls.Add(this.rdoEmail);
            this.Controls.Add(this.rdoID);
            this.Name = "SelectEmployeeByID_Email";
            this.Text = "SelectEmployeeByID_Email";
            this.Load += new System.EventHandler(this.SelectEmployeeByID_Email_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoID;
        private System.Windows.Forms.RadioButton rdoEmail;
        private System.Windows.Forms.TextBox txtSearchByID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchBy;
        private System.Windows.Forms.ListBox listBoxEmployeeSearchBy;
        private System.Windows.Forms.TextBox txtSearchByEmail;
    }
}