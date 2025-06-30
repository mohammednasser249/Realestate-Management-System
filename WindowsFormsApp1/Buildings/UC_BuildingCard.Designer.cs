namespace WindowsFormsApp1.Buildings
{
    partial class UC_BuildingCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_BuildingCard));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTenantID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbBuildingName = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbFloors = new System.Windows.Forms.Label();
            this.lbProperties = new System.Windows.Forms.Label();
            this.lbC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(549, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 257);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbTenantID
            // 
            this.lbTenantID.AutoSize = true;
            this.lbTenantID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenantID.Location = new System.Drawing.Point(295, 34);
            this.lbTenantID.Name = "lbTenantID";
            this.lbTenantID.Size = new System.Drawing.Size(47, 25);
            this.lbTenantID.TabIndex = 41;
            this.lbTenantID.Text = "N/A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 28);
            this.label6.TabIndex = 40;
            this.label6.Text = "Building ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 28);
            this.label5.TabIndex = 46;
            this.label5.Text = "Number Of Properties :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 28);
            this.label4.TabIndex = 45;
            this.label4.Text = "Number Of Floors :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 28);
            this.label2.TabIndex = 44;
            this.label2.Text = "City :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 28);
            this.label1.TabIndex = 43;
            this.label1.Text = "Address :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 28);
            this.label3.TabIndex = 42;
            this.label3.Text = "Building Name :";
            // 
            // lbBuildingName
            // 
            this.lbBuildingName.AutoSize = true;
            this.lbBuildingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuildingName.ForeColor = System.Drawing.Color.Red;
            this.lbBuildingName.Location = new System.Drawing.Point(296, 101);
            this.lbBuildingName.Name = "lbBuildingName";
            this.lbBuildingName.Size = new System.Drawing.Size(51, 20);
            this.lbBuildingName.TabIndex = 47;
            this.lbBuildingName.Text = "[???]";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.ForeColor = System.Drawing.Color.Red;
            this.lbAddress.Location = new System.Drawing.Point(296, 173);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(51, 20);
            this.lbAddress.TabIndex = 48;
            this.lbAddress.Text = "[???]";
            // 
            // lbFloors
            // 
            this.lbFloors.AutoSize = true;
            this.lbFloors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFloors.ForeColor = System.Drawing.Color.Red;
            this.lbFloors.Location = new System.Drawing.Point(296, 307);
            this.lbFloors.Name = "lbFloors";
            this.lbFloors.Size = new System.Drawing.Size(51, 20);
            this.lbFloors.TabIndex = 50;
            this.lbFloors.Text = "[???]";
            // 
            // lbProperties
            // 
            this.lbProperties.AutoSize = true;
            this.lbProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProperties.ForeColor = System.Drawing.Color.Red;
            this.lbProperties.Location = new System.Drawing.Point(296, 379);
            this.lbProperties.Name = "lbProperties";
            this.lbProperties.Size = new System.Drawing.Size(51, 20);
            this.lbProperties.TabIndex = 51;
            this.lbProperties.Text = "[???]";
            // 
            // lbC
            // 
            this.lbC.AutoSize = true;
            this.lbC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbC.ForeColor = System.Drawing.Color.Red;
            this.lbC.Location = new System.Drawing.Point(296, 235);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(51, 20);
            this.lbC.TabIndex = 53;
            this.lbC.Text = "[???]";
            // 
            // UC_BuildingCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbC);
            this.Controls.Add(this.lbProperties);
            this.Controls.Add(this.lbFloors);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbBuildingName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTenantID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UC_BuildingCard";
            this.Size = new System.Drawing.Size(830, 442);
            this.Load += new System.EventHandler(this.UC_BuildingCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTenantID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbBuildingName;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbFloors;
        private System.Windows.Forms.Label lbProperties;
        private System.Windows.Forms.Label lbC;
    }
}
