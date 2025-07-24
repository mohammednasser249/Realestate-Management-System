namespace WindowsFormsApp1.Property
{
    partial class frmAllProperties
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
            this.lbBuildingID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ucShowAllProperties1 = new WindowsFormsApp1.Property.UcShowAllProperties();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(391, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 41);
            this.label1.TabIndex = 8;
            this.label1.Text = "Properties for Building : ";
            // 
            // lbBuildingID
            // 
            this.lbBuildingID.AutoSize = true;
            this.lbBuildingID.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuildingID.ForeColor = System.Drawing.Color.Red;
            this.lbBuildingID.Location = new System.Drawing.Point(783, 9);
            this.lbBuildingID.Name = "lbBuildingID";
            this.lbBuildingID.Size = new System.Drawing.Size(0, 41);
            this.lbBuildingID.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Address_32;
            this.pictureBox1.Location = new System.Drawing.Point(1216, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ucShowAllProperties1
            // 
            this.ucShowAllProperties1.Location = new System.Drawing.Point(-9, 68);
            this.ucShowAllProperties1.Name = "ucShowAllProperties1";
            this.ucShowAllProperties1.Size = new System.Drawing.Size(1348, 372);
            this.ucShowAllProperties1.TabIndex = 0;
            // 
            // frmAllProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 438);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbBuildingID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucShowAllProperties1);
            this.Name = "frmAllProperties";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAllProperties";
            this.Load += new System.EventHandler(this.frmAllProperties_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UcShowAllProperties ucShowAllProperties1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbBuildingID;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}