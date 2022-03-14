namespace UniversityForm
{
    partial class StudentAddForm
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
            this.textName = new DevExpress.XtraEditors.TextEdit();
            this.textAge = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ButtonStudentAdd = new DevExpress.XtraEditors.SimpleButton();
            this.textRegNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.buttonCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRegNumber.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(127, 35);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 0;
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(127, 61);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(100, 20);
            this.textAge.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Name";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(27, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(19, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Age";
            // 
            // ButtonStudentAdd
            // 
            this.ButtonStudentAdd.Location = new System.Drawing.Point(27, 179);
            this.ButtonStudentAdd.Name = "ButtonStudentAdd";
            this.ButtonStudentAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonStudentAdd.TabIndex = 4;
            this.ButtonStudentAdd.Text = "Add";
            this.ButtonStudentAdd.Click += new System.EventHandler(this.ButtonStudentAdd_Click);
            // 
            // textRegNumber
            // 
            this.textRegNumber.Location = new System.Drawing.Point(127, 87);
            this.textRegNumber.Name = "textRegNumber";
            this.textRegNumber.Size = new System.Drawing.Size(100, 20);
            this.textRegNumber.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(27, 91);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(98, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Registration Number";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(109, 178);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // StudentAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 214);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.textRegNumber);
            this.Controls.Add(this.ButtonStudentAdd);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.textName);
            this.Name = "StudentAddForm";
            this.Text = "StudentAddForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentAddForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.textName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRegNumber.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textName;
        private DevExpress.XtraEditors.TextEdit textAge;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton ButtonStudentAdd;
        private DevExpress.XtraEditors.TextEdit textRegNumber;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton buttonCancel;
    }
}