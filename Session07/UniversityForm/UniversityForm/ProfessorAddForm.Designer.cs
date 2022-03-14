namespace UniversityForm
{
    partial class ProfessorAddForm
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textRank = new DevExpress.XtraEditors.TextEdit();
            this.ButtonProfessorAdd = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textAge = new DevExpress.XtraEditors.TextEdit();
            this.textName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textRank.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(141, 180);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(59, 93);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 13);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Rank";
            // 
            // textRank
            // 
            this.textRank.Location = new System.Drawing.Point(159, 89);
            this.textRank.Name = "textRank";
            this.textRank.Size = new System.Drawing.Size(100, 20);
            this.textRank.TabIndex = 13;
            // 
            // ButtonProfessorAdd
            // 
            this.ButtonProfessorAdd.Location = new System.Drawing.Point(59, 181);
            this.ButtonProfessorAdd.Name = "ButtonProfessorAdd";
            this.ButtonProfessorAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonProfessorAdd.TabIndex = 12;
            this.ButtonProfessorAdd.Text = "Add";
            this.ButtonProfessorAdd.Click += new System.EventHandler(this.ButtonProfessorAdd_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(59, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(19, 13);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Age";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(59, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Name";
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(159, 63);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(100, 20);
            this.textAge.TabIndex = 9;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(159, 37);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 8;
            // 
            // ProfessorAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 279);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.textRank);
            this.Controls.Add(this.ButtonProfessorAdd);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.textName);
            this.Name = "ProfessorAddForm";
            this.Text = "ProfessorAddForm";
            ((System.ComponentModel.ISupportInitialize)(this.textRank.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton buttonCancel;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textRank;
        private DevExpress.XtraEditors.SimpleButton ButtonProfessorAdd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textAge;
        private DevExpress.XtraEditors.TextEdit textName;
    }
}