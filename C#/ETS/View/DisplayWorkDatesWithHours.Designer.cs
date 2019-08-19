namespace View
{
    partial class DisplayHours
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
            this.btnSelectHours = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmpIDispHours = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxShowHours = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelectHours
            // 
            this.btnSelectHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectHours.Location = new System.Drawing.Point(362, 72);
            this.btnSelectHours.Name = "btnSelectHours";
            this.btnSelectHours.Size = new System.Drawing.Size(229, 27);
            this.btnSelectHours.TabIndex = 0;
            this.btnSelectHours.Text = "Select Work Dates and Hours";
            this.btnSelectHours.UseVisualStyleBackColor = true;
            this.btnSelectHours.Click += new System.EventHandler(this.btnSelectHours_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee ID:";
            // 
            // txtEmpIDispHours
            // 
            this.txtEmpIDispHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpIDispHours.Location = new System.Drawing.Point(212, 73);
            this.txtEmpIDispHours.Name = "txtEmpIDispHours";
            this.txtEmpIDispHours.Size = new System.Drawing.Size(100, 26);
            this.txtEmpIDispHours.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Employee work dates with hours";
            // 
            // listBoxShowHours
            // 
            this.listBoxShowHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxShowHours.FormattingEnabled = true;
            this.listBoxShowHours.HorizontalScrollbar = true;
            this.listBoxShowHours.ItemHeight = 20;
            this.listBoxShowHours.Location = new System.Drawing.Point(63, 181);
            this.listBoxShowHours.Name = "listBoxShowHours";
            this.listBoxShowHours.Size = new System.Drawing.Size(611, 84);
            this.listBoxShowHours.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(414, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Work dates and hours worked by employee";
            // 
            // DisplayHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(789, 309);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxShowHours);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmpIDispHours);
            this.Controls.Add(this.btnSelectHours);
            this.Name = "DisplayHours";
            this.Text = "Display Hours";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmpIDispHours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxShowHours;
        private System.Windows.Forms.Label label2;
    }
}