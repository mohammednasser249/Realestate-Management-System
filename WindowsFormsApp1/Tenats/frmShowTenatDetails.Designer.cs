namespace WindowsFormsApp1.Tenats
{
    partial class frmShowTenatDetails
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
            this.uC_Tenant1 = new WindowsFormsApp1.Tenats.UC_Tenant();
            this.lbTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uC_Tenant1
            // 
            this.uC_Tenant1.Location = new System.Drawing.Point(12, 66);
            this.uC_Tenant1.Name = "uC_Tenant1";
            this.uC_Tenant1.Size = new System.Drawing.Size(1337, 444);
            this.uC_Tenant1.TabIndex = 0;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(505, 11);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(302, 54);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Tenant Details ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::WindowsFormsApp1.Properties.Resources.Close_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1184, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmShowTenatDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 558);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.uC_Tenant1);
            this.Name = "frmShowTenatDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShowTenatDetails";
            this.Load += new System.EventHandler(this.frmShowTenatDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UC_Tenant uC_Tenant1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button button1;
    }
}