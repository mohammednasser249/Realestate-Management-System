namespace WindowsFormsApp1.Buildings
{
    partial class frmShowBuildingDetails
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
            this.uC_BuildingCard1 = new WindowsFormsApp1.Buildings.UC_BuildingCard();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::WindowsFormsApp1.Properties.Resources.Close_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(677, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uC_BuildingCard1
            // 
            this.uC_BuildingCard1.Location = new System.Drawing.Point(12, 12);
            this.uC_BuildingCard1.Name = "uC_BuildingCard1";
            this.uC_BuildingCard1.Size = new System.Drawing.Size(794, 438);
            this.uC_BuildingCard1.TabIndex = 0;
            // 
            // frmShowBuildingDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 512);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uC_BuildingCard1);
            this.Name = "frmShowBuildingDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShowBuildingDetails";
            this.Load += new System.EventHandler(this.frmShowBuildingDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UC_BuildingCard uC_BuildingCard1;
        private System.Windows.Forms.Button button1;
    }
}