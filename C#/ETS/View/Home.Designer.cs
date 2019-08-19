namespace View
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayAndUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayAndRecordHoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findAnEmployeeByIDOrEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayAllInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayWorkDateAndHoursSearchByIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayTotalHoursWorkedByEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.addToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.aboutToolStripMenuItem1,
            this.contactToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(435, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 19);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.displayToolStripMenuItem,
            this.displayAndUpdateToolStripMenuItem,
            this.displayAndRecordHoursToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(65, 19);
            this.addToolStripMenuItem.Text = "Manage ";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(291, 22);
            this.addToolStripMenuItem1.Text = "Add an employee";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.displayToolStripMenuItem.Text = "Display list of employees and their details";
            this.displayToolStripMenuItem.Click += new System.EventHandler(this.displayToolStripMenuItem_Click);
            // 
            // displayAndUpdateToolStripMenuItem
            // 
            this.displayAndUpdateToolStripMenuItem.Name = "displayAndUpdateToolStripMenuItem";
            this.displayAndUpdateToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.displayAndUpdateToolStripMenuItem.Text = "Update employee information";
            this.displayAndUpdateToolStripMenuItem.Click += new System.EventHandler(this.displayAndUpdateToolStripMenuItem_Click);
            // 
            // displayAndRecordHoursToolStripMenuItem
            // 
            this.displayAndRecordHoursToolStripMenuItem.Name = "displayAndRecordHoursToolStripMenuItem";
            this.displayAndRecordHoursToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.displayAndRecordHoursToolStripMenuItem.Text = "Record employee\'s working hours";
            this.displayAndRecordHoursToolStripMenuItem.Click += new System.EventHandler(this.displayAndRecordHoursToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findAnEmployeeByIDOrEmailToolStripMenuItem,
            this.displayAllInformationToolStripMenuItem,
            this.displayWorkDateAndHoursSearchByIDToolStripMenuItem,
            this.displayTotalHoursWorkedByEmployeeToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(54, 19);
            this.aboutToolStripMenuItem.Text = "Report";
            // 
            // findAnEmployeeByIDOrEmailToolStripMenuItem
            // 
            this.findAnEmployeeByIDOrEmailToolStripMenuItem.Name = "findAnEmployeeByIDOrEmailToolStripMenuItem";
            this.findAnEmployeeByIDOrEmailToolStripMenuItem.Size = new System.Drawing.Size(301, 22);
            this.findAnEmployeeByIDOrEmailToolStripMenuItem.Text = "Find an employee by ID or Email";
            this.findAnEmployeeByIDOrEmailToolStripMenuItem.Click += new System.EventHandler(this.findAnEmployeeByIDOrEmailToolStripMenuItem_Click);
            // 
            // displayAllInformationToolStripMenuItem
            // 
            this.displayAllInformationToolStripMenuItem.Name = "displayAllInformationToolStripMenuItem";
            this.displayAllInformationToolStripMenuItem.Size = new System.Drawing.Size(301, 22);
            this.displayAllInformationToolStripMenuItem.Text = "Display all employees in the table";
            this.displayAllInformationToolStripMenuItem.Click += new System.EventHandler(this.displayAllInformationToolStripMenuItem_Click);
            // 
            // displayWorkDateAndHoursSearchByIDToolStripMenuItem
            // 
            this.displayWorkDateAndHoursSearchByIDToolStripMenuItem.Name = "displayWorkDateAndHoursSearchByIDToolStripMenuItem";
            this.displayWorkDateAndHoursSearchByIDToolStripMenuItem.Size = new System.Drawing.Size(301, 22);
            this.displayWorkDateAndHoursSearchByIDToolStripMenuItem.Text = "Display work dates with hours, search by ID";
            this.displayWorkDateAndHoursSearchByIDToolStripMenuItem.Click += new System.EventHandler(this.displayWorkDateAndHoursSearchByIDToolStripMenuItem_Click);
            // 
            // displayTotalHoursWorkedByEmployeeToolStripMenuItem
            // 
            this.displayTotalHoursWorkedByEmployeeToolStripMenuItem.Name = "displayTotalHoursWorkedByEmployeeToolStripMenuItem";
            this.displayTotalHoursWorkedByEmployeeToolStripMenuItem.Size = new System.Drawing.Size(301, 22);
            this.displayTotalHoursWorkedByEmployeeToolStripMenuItem.Text = "Display total hours worked by employee";
            this.displayTotalHoursWorkedByEmployeeToolStripMenuItem.Click += new System.EventHandler(this.displayTotalHoursWorkedByEmployeeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(52, 19);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(61, 19);
            this.contactToolStripMenuItem.Text = "Contact";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(435, 200);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Home";
            this.Text = "Employee Tracking System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayAndUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayAndRecordHoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findAnEmployeeByIDOrEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayAllInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayWorkDateAndHoursSearchByIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayTotalHoursWorkedByEmployeeToolStripMenuItem;
    }
}