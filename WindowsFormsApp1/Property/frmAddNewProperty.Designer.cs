namespace WindowsFormsApp1.Property
{
    partial class frmAddNewProperty
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.lbFloors = new System.Windows.Forms.Label();
            this.lbRooms = new System.Windows.Forms.Label();
            this.lbBathrooms = new System.Windows.Forms.Label();
            this.lbArea = new System.Windows.Forms.Label();
            this.lbRentPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtPropertyName = new System.Windows.Forms.TextBox();
            this.txtPropertyType = new System.Windows.Forms.TextBox();
            this.txtNumberOFfloors = new System.Windows.Forms.TextBox();
            this.txtNumberOfrooms = new System.Windows.Forms.TextBox();
            this.txtNumberOfBathrooms = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtRentPrice = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumberOfKitchens = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(365, 20);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(437, 62);
            this.lbTitle.TabIndex = 7;
            this.lbTitle.Text = "Add New Property";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(15, 24);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(168, 28);
            this.lbName.TabIndex = 41;
            this.lbName.Text = "PropertyName  :";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.Location = new System.Drawing.Point(362, 24);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(157, 28);
            this.lbType.TabIndex = 42;
            this.lbType.Text = "PropertyType  :";
            // 
            // lbFloors
            // 
            this.lbFloors.AutoSize = true;
            this.lbFloors.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFloors.Location = new System.Drawing.Point(781, 24);
            this.lbFloors.Name = "lbFloors";
            this.lbFloors.Size = new System.Drawing.Size(193, 28);
            this.lbFloors.TabIndex = 43;
            this.lbFloors.Text = "Number of floors  :";
            // 
            // lbRooms
            // 
            this.lbRooms.AutoSize = true;
            this.lbRooms.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRooms.Location = new System.Drawing.Point(15, 126);
            this.lbRooms.Name = "lbRooms";
            this.lbRooms.Size = new System.Drawing.Size(197, 28);
            this.lbRooms.TabIndex = 44;
            this.lbRooms.Text = "Number of rooms  :";
            // 
            // lbBathrooms
            // 
            this.lbBathrooms.AutoSize = true;
            this.lbBathrooms.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBathrooms.Location = new System.Drawing.Point(362, 126);
            this.lbBathrooms.Name = "lbBathrooms";
            this.lbBathrooms.Size = new System.Drawing.Size(241, 28);
            this.lbBathrooms.TabIndex = 45;
            this.lbBathrooms.Text = "Number of Bathrooms  :";
            // 
            // lbArea
            // 
            this.lbArea.AutoSize = true;
            this.lbArea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArea.Location = new System.Drawing.Point(781, 126);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(73, 28);
            this.lbArea.TabIndex = 46;
            this.lbArea.Text = "Area : ";
            // 
            // lbRentPrice
            // 
            this.lbRentPrice.AutoSize = true;
            this.lbRentPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRentPrice.Location = new System.Drawing.Point(15, 227);
            this.lbRentPrice.Name = "lbRentPrice";
            this.lbRentPrice.Size = new System.Drawing.Size(120, 28);
            this.lbRentPrice.TabIndex = 47;
            this.lbRentPrice.Text = "Rent Price :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 28);
            this.label2.TabIndex = 48;
            this.label2.Text = "Is occupied :";
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Location = new System.Drawing.Point(150, 325);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(55, 20);
            this.rbYes.TabIndex = 49;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Yes ";
            this.rbYes.UseVisualStyleBackColor = true;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(211, 325);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(46, 20);
            this.rbNo.TabIndex = 50;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(362, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 28);
            this.label3.TabIndex = 51;
            this.label3.Text = "Available From :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(781, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 28);
            this.label4.TabIndex = 52;
            this.label4.Text = "Status :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 28);
            this.label6.TabIndex = 54;
            this.label6.Text = "Building ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(362, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 28);
            this.label5.TabIndex = 53;
            this.label5.Text = "Number Of Kitchens :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 28);
            this.label7.TabIndex = 55;
            this.label7.Text = "Notes : ";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(106, 392);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(612, 99);
            this.txtNotes.TabIndex = 56;
            // 
            // txtPropertyName
            // 
            this.txtPropertyName.Location = new System.Drawing.Point(189, 31);
            this.txtPropertyName.Name = "txtPropertyName";
            this.txtPropertyName.Size = new System.Drawing.Size(160, 22);
            this.txtPropertyName.TabIndex = 57;
            // 
            // txtPropertyType
            // 
            this.txtPropertyType.Location = new System.Drawing.Point(525, 31);
            this.txtPropertyType.Name = "txtPropertyType";
            this.txtPropertyType.Size = new System.Drawing.Size(206, 22);
            this.txtPropertyType.TabIndex = 58;
            // 
            // txtNumberOFfloors
            // 
            this.txtNumberOFfloors.Location = new System.Drawing.Point(980, 30);
            this.txtNumberOFfloors.Name = "txtNumberOFfloors";
            this.txtNumberOFfloors.Size = new System.Drawing.Size(69, 22);
            this.txtNumberOFfloors.TabIndex = 59;
            // 
            // txtNumberOfrooms
            // 
            this.txtNumberOfrooms.Location = new System.Drawing.Point(211, 132);
            this.txtNumberOfrooms.Name = "txtNumberOfrooms";
            this.txtNumberOfrooms.Size = new System.Drawing.Size(114, 22);
            this.txtNumberOfrooms.TabIndex = 60;
            // 
            // txtNumberOfBathrooms
            // 
            this.txtNumberOfBathrooms.Location = new System.Drawing.Point(604, 133);
            this.txtNumberOfBathrooms.Name = "txtNumberOfBathrooms";
            this.txtNumberOfBathrooms.Size = new System.Drawing.Size(171, 22);
            this.txtNumberOfBathrooms.TabIndex = 61;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(860, 133);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(171, 22);
            this.txtArea.TabIndex = 62;
            // 
            // txtRentPrice
            // 
            this.txtRentPrice.Location = new System.Drawing.Point(141, 234);
            this.txtRentPrice.Name = "txtRentPrice";
            this.txtRentPrice.Size = new System.Drawing.Size(160, 22);
            this.txtRentPrice.TabIndex = 63;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(869, 231);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 24);
            this.comboBox1.TabIndex = 65;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(533, 233);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(177, 22);
            this.dateTimePicker1.TabIndex = 66;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(916, 439);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 41);
            this.btnSave.TabIndex = 68;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(777, 439);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 41);
            this.btnClose.TabIndex = 67;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumberOfKitchens);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txtRentPrice);
            this.groupBox1.Controls.Add(this.txtArea);
            this.groupBox1.Controls.Add(this.txtNumberOfBathrooms);
            this.groupBox1.Controls.Add(this.txtNumberOfrooms);
            this.groupBox1.Controls.Add(this.txtNumberOFfloors);
            this.groupBox1.Controls.Add(this.txtPropertyType);
            this.groupBox1.Controls.Add(this.txtPropertyName);
            this.groupBox1.Controls.Add(this.txtNotes);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rbNo);
            this.groupBox1.Controls.Add(this.rbYes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbRentPrice);
            this.groupBox1.Controls.Add(this.lbArea);
            this.groupBox1.Controls.Add(this.lbBathrooms);
            this.groupBox1.Controls.Add(this.lbRooms);
            this.groupBox1.Controls.Add(this.lbFloors);
            this.groupBox1.Controls.Add(this.lbType);
            this.groupBox1.Controls.Add(this.lbName);
            this.groupBox1.Location = new System.Drawing.Point(27, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1090, 502);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Property Info";
            // 
            // txtNumberOfKitchens
            // 
            this.txtNumberOfKitchens.Location = new System.Drawing.Point(584, 323);
            this.txtNumberOfKitchens.Name = "txtNumberOfKitchens";
            this.txtNumberOfKitchens.Size = new System.Drawing.Size(171, 22);
            this.txtNumberOfKitchens.TabIndex = 69;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(163, 52);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(0, 22);
            this.lbID.TabIndex = 70;
            // 
            // frmAddNewProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 621);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbTitle);
            this.Name = "frmAddNewProperty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddNewProperty";
            this.Load += new System.EventHandler(this.frmAddNewProperty_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbFloors;
        private System.Windows.Forms.Label lbRooms;
        private System.Windows.Forms.Label lbBathrooms;
        private System.Windows.Forms.Label lbArea;
        private System.Windows.Forms.Label lbRentPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtPropertyName;
        private System.Windows.Forms.TextBox txtPropertyType;
        private System.Windows.Forms.TextBox txtNumberOFfloors;
        private System.Windows.Forms.TextBox txtNumberOfBathrooms;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtRentPrice;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumberOfKitchens;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtNumberOfrooms;
    }
}