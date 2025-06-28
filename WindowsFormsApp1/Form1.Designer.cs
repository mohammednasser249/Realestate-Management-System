namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTenantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addRentalContractsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRentHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewListOfAllBuildingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewBuildingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.testToolStripMenuItem1,
            this.testToolStripMenuItem2,
            this.testToolStripMenuItem3,
            this.buildingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1210, 38);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("testToolStripMenuItem.Image")));
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(152, 34);
            this.testToolStripMenuItem.Text = "Dashboard";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem1
            // 
            this.testToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.addTenantsToolStripMenuItem});
            this.testToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.testToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("testToolStripMenuItem1.Image")));
            this.testToolStripMenuItem1.Name = "testToolStripMenuItem1";
            this.testToolStripMenuItem1.Size = new System.Drawing.Size(120, 34);
            this.testToolStripMenuItem1.Text = "Tenatns";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.viewToolStripMenuItem.Text = "View ";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // addTenantsToolStripMenuItem
            // 
            this.addTenantsToolStripMenuItem.Name = "addTenantsToolStripMenuItem";
            this.addTenantsToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.addTenantsToolStripMenuItem.Text = "Add tenants";
            this.addTenantsToolStripMenuItem.Click += new System.EventHandler(this.addTenantsToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem2
            // 
            this.testToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem1,
            this.addRentalContractsToolStripMenuItem,
            this.renewContractToolStripMenuItem});
            this.testToolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.testToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("testToolStripMenuItem2.Image")));
            this.testToolStripMenuItem2.Name = "testToolStripMenuItem2";
            this.testToolStripMenuItem2.Size = new System.Drawing.Size(138, 34);
            this.testToolStripMenuItem2.Text = "Contracts";
            // 
            // viewToolStripMenuItem1
            // 
            this.viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            this.viewToolStripMenuItem1.Size = new System.Drawing.Size(294, 34);
            this.viewToolStripMenuItem1.Text = "View ";
            // 
            // addRentalContractsToolStripMenuItem
            // 
            this.addRentalContractsToolStripMenuItem.Name = "addRentalContractsToolStripMenuItem";
            this.addRentalContractsToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.addRentalContractsToolStripMenuItem.Text = "Add rental contracts";
            // 
            // renewContractToolStripMenuItem
            // 
            this.renewContractToolStripMenuItem.Name = "renewContractToolStripMenuItem";
            this.renewContractToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.renewContractToolStripMenuItem.Text = "Renew Contract";
            // 
            // testToolStripMenuItem3
            // 
            this.testToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewRentHistoryToolStripMenuItem,
            this.duesToolStripMenuItem});
            this.testToolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.testToolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("testToolStripMenuItem3.Image")));
            this.testToolStripMenuItem3.Name = "testToolStripMenuItem3";
            this.testToolStripMenuItem3.Size = new System.Drawing.Size(139, 34);
            this.testToolStripMenuItem3.Text = "Payments";
            // 
            // viewRentHistoryToolStripMenuItem
            // 
            this.viewRentHistoryToolStripMenuItem.Name = "viewRentHistoryToolStripMenuItem";
            this.viewRentHistoryToolStripMenuItem.Size = new System.Drawing.Size(263, 34);
            this.viewRentHistoryToolStripMenuItem.Text = "View rent history";
            // 
            // duesToolStripMenuItem
            // 
            this.duesToolStripMenuItem.Name = "duesToolStripMenuItem";
            this.duesToolStripMenuItem.Size = new System.Drawing.Size(263, 34);
            this.duesToolStripMenuItem.Text = "dues";
            // 
            // buildingsToolStripMenuItem
            // 
            this.buildingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewListOfAllBuildingsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.addNewBuildingToolStripMenuItem});
            this.buildingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.buildingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("buildingsToolStripMenuItem.Image")));
            this.buildingsToolStripMenuItem.Name = "buildingsToolStripMenuItem";
            this.buildingsToolStripMenuItem.Size = new System.Drawing.Size(134, 34);
            this.buildingsToolStripMenuItem.Text = "Buildings";
            // 
            // viewListOfAllBuildingsToolStripMenuItem
            // 
            this.viewListOfAllBuildingsToolStripMenuItem.Name = "viewListOfAllBuildingsToolStripMenuItem";
            this.viewListOfAllBuildingsToolStripMenuItem.Size = new System.Drawing.Size(325, 34);
            this.viewListOfAllBuildingsToolStripMenuItem.Text = "View list of all buildings";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(322, 6);
            // 
            // addNewBuildingToolStripMenuItem
            // 
            this.addNewBuildingToolStripMenuItem.Name = "addNewBuildingToolStripMenuItem";
            this.addNewBuildingToolStripMenuItem.Size = new System.Drawing.Size(325, 34);
            this.addNewBuildingToolStripMenuItem.Text = "Add new building";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1210, 693);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem buildingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTenantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewListOfAllBuildingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewBuildingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addRentalContractsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRentHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewContractToolStripMenuItem;
    }
}

