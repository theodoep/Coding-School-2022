namespace UniversityForm
{
    partial class CourseForm
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
            this.buttonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonCourseAdd = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textSubject = new DevExpress.XtraEditors.TextEdit();
            this.textCode = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(308, 230);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // ButtonCourseAdd
            // 
            this.ButtonCourseAdd.Location = new System.Drawing.Point(226, 231);
            this.ButtonCourseAdd.Name = "ButtonCourseAdd";
            this.ButtonCourseAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonCourseAdd.TabIndex = 12;
            this.ButtonCourseAdd.Text = "Add";
            this.ButtonCourseAdd.Click += new System.EventHandler(this.ButtonCourseAdd_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(226, 116);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 13);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Subject";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(226, 90);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(25, 13);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Code";
            // 
            // textSubject
            // 
            this.textSubject.Location = new System.Drawing.Point(326, 113);
            this.textSubject.Name = "textSubject";
            this.textSubject.Size = new System.Drawing.Size(100, 20);
            this.textSubject.TabIndex = 9;
            // 
            // textCode
            // 
            this.textCode.Location = new System.Drawing.Point(326, 87);
            this.textCode.Name = "textCode";
            this.textCode.Size = new System.Drawing.Size(100, 20);
            this.textCode.TabIndex = 8;
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 341);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.ButtonCourseAdd);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textSubject);
            this.Controls.Add(this.textCode);
            this.Name = "CourseForm";
            this.Text = "CourseForm";
            ((System.ComponentModel.ISupportInitialize)(this.textSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton buttonCancel;
        private DevExpress.XtraEditors.SimpleButton ButtonCourseAdd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textSubject;
        private DevExpress.XtraEditors.TextEdit textCode;
    }
}