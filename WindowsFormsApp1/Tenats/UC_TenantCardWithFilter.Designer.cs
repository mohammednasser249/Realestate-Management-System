namespace WindowsFormsApp1.Tenats
{
    partial class UC_TenantCardWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uC_Tenant1 = new WindowsFormsApp1.Tenats.UC_Tenant();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddTenant = new System.Windows.Forms.Button();
            this.btnSearchTenant = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uC_Tenant1
            // 
            this.uC_Tenant1.Location = new System.Drawing.Point(16, 115);
            this.uC_Tenant1.Name = "uC_Tenant1";
            this.uC_Tenant1.Size = new System.Drawing.Size(1337, 444);
            this.uC_Tenant1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddTenant);
            this.groupBox1.Controls.Add(this.btnSearchTenant);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.cbFilter);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(28, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1324, 97);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAddTenant
            // 
            this.btnAddTenant.Image = global::WindowsFormsApp1.Properties.Resources.Add_Person_40;
            this.btnAddTenant.Location = new System.Drawing.Point(783, 26);
            this.btnAddTenant.Name = "btnAddTenant";
            this.btnAddTenant.Size = new System.Drawing.Size(60, 46);
            this.btnAddTenant.TabIndex = 53;
            this.btnAddTenant.UseVisualStyleBackColor = true;
            // 
            // btnSearchTenant
            // 
            this.btnSearchTenant.Image = global::WindowsFormsApp1.Properties.Resources.SearchPerson;
            this.btnSearchTenant.Location = new System.Drawing.Point(694, 26);
            this.btnSearchTenant.Name = "btnSearchTenant";
            this.btnSearchTenant.Size = new System.Drawing.Size(60, 46);
            this.btnSearchTenant.TabIndex = 52;
            this.btnSearchTenant.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(351, 41);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(246, 22);
            this.txtSearch.TabIndex = 49;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(136, 42);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(200, 24);
            this.cbFilter.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 28);
            this.label4.TabIndex = 47;
            this.label4.Text = "Filter By :";
            // 
            // UC_TenantCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uC_Tenant1);
            this.Name = "UC_TenantCardWithFilter";
            this.Size = new System.Drawing.Size(1369, 584);
            this.Load += new System.EventHandler(this.UC_TenantCardWithFilter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UC_Tenant uC_Tenant1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearchTenant;
        private System.Windows.Forms.Button btnAddTenant;
    }
}
