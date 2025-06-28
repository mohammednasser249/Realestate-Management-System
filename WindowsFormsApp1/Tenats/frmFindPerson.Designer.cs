namespace WindowsFormsApp1.Tenats
{
    partial class frmFindPerson
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.uC_TenantCardWithFilter1 = new WindowsFormsApp1.Tenats.UC_TenantCardWithFilter();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::WindowsFormsApp1.Properties.Resources.Close_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1228, 615);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(586, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(242, 54);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Find Tenant";
            // 
            // uC_TenantCardWithFilter1
            // 
            this.uC_TenantCardWithFilter1.FilterEnabled = true;
            this.uC_TenantCardWithFilter1.Location = new System.Drawing.Point(27, 57);
            this.uC_TenantCardWithFilter1.Name = "uC_TenantCardWithFilter1";
            this.uC_TenantCardWithFilter1.ShowAddTenant = true;
            this.uC_TenantCardWithFilter1.Size = new System.Drawing.Size(1366, 541);
            this.uC_TenantCardWithFilter1.TabIndex = 0;
            // 
            // frmFindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 677);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uC_TenantCardWithFilter1);
            this.Name = "frmFindPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFindPerson";
            this.Load += new System.EventHandler(this.frmFindPerson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UC_TenantCardWithFilter uC_TenantCardWithFilter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbTitle;
    }
}