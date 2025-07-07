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
            this.ucShowAllProperties1 = new WindowsFormsApp1.Property.UcShowAllProperties();
            this.SuspendLayout();
            // 
            // ucShowAllProperties1
            // 
            this.ucShowAllProperties1.Location = new System.Drawing.Point(0, 0);
            this.ucShowAllProperties1.Name = "ucShowAllProperties1";
            this.ucShowAllProperties1.Size = new System.Drawing.Size(1268, 357);
            this.ucShowAllProperties1.TabIndex = 0;
            // 
            // frmAllProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 357);
            this.Controls.Add(this.ucShowAllProperties1);
            this.Name = "frmAllProperties";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAllProperties";
            this.Load += new System.EventHandler(this.frmAllProperties_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UcShowAllProperties ucShowAllProperties1;
    }
}