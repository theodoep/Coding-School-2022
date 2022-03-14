namespace UniversityForm
{
    partial class UniversityForm
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
            this.components = new System.ComponentModel.Container();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.buttonAddStudent = new DevExpress.XtraBars.BarButtonItem();
            this.buttonAddProfessor = new DevExpress.XtraBars.BarButtonItem();
            this.buttonAddSchedule = new DevExpress.XtraBars.BarButtonItem();
            this.buttonAddCourse = new DevExpress.XtraBars.BarButtonItem();
            this.buttonAddGrade = new DevExpress.XtraBars.BarButtonItem();
            this.ButtonSave = new DevExpress.XtraBars.BarButtonItem();
            this.Load = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.listBoxStudents = new DevExpress.XtraEditors.ListBoxControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.listBoxProfessors = new DevExpress.XtraEditors.ListBoxControl();
            this.labelcontrol3 = new DevExpress.XtraEditors.LabelControl();
            this.listBoxCourses = new DevExpress.XtraEditors.ListBoxControl();
            this.listBoxSchedule = new DevExpress.XtraEditors.ListBoxControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxProfessors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.buttonAddStudent,
            this.buttonAddProfessor,
            this.buttonAddSchedule,
            this.buttonAddCourse,
            this.buttonAddGrade,
            this.barButtonItem1,
            this.ButtonSave,
            this.Load});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.ButtonSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.Load)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Add";
            this.barSubItem1.Id = 1;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonAddStudent),
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonAddProfessor),
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonAddSchedule),
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonAddCourse),
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonAddGrade)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Caption = "Student";
            this.buttonAddStudent.Id = 2;
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonAddStudent_ItemClick);
            // 
            // buttonAddProfessor
            // 
            this.buttonAddProfessor.Caption = "Professor";
            this.buttonAddProfessor.Id = 3;
            this.buttonAddProfessor.Name = "buttonAddProfessor";
            this.buttonAddProfessor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonAddProfessor_ItemClick);
            // 
            // buttonAddSchedule
            // 
            this.buttonAddSchedule.Caption = "Schedule";
            this.buttonAddSchedule.Id = 4;
            this.buttonAddSchedule.Name = "buttonAddSchedule";
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.Caption = "Course";
            this.buttonAddCourse.Id = 5;
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonAddCourse_ItemClick);
            // 
            // buttonAddGrade
            // 
            this.buttonAddGrade.Caption = "Grade";
            this.buttonAddGrade.Id = 6;
            this.buttonAddGrade.Name = "buttonAddGrade";
            // 
            // ButtonSave
            // 
            this.ButtonSave.Caption = "Save";
            this.ButtonSave.Id = 8;
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonSave_ItemClick);
            // 
            // Load
            // 
            this.Load.Caption = "Load";
            this.Load.Id = 9;
            this.Load.Name = "Load";
            this.Load.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Load_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(635, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 316);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(635, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 296);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(635, 20);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 296);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Save";
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.Location = new System.Drawing.Point(12, 56);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(99, 218);
            this.listBoxStudents.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Students";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(117, 37);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Professors";
            // 
            // listBoxProfessors
            // 
            this.listBoxProfessors.Location = new System.Drawing.Point(117, 56);
            this.listBoxProfessors.Name = "listBoxProfessors";
            this.listBoxProfessors.Size = new System.Drawing.Size(101, 218);
            this.listBoxProfessors.TabIndex = 6;
            // 
            // labelcontrol3
            // 
            this.labelcontrol3.Location = new System.Drawing.Point(224, 37);
            this.labelcontrol3.Name = "labelcontrol3";
            this.labelcontrol3.Size = new System.Drawing.Size(39, 13);
            this.labelcontrol3.TabIndex = 9;
            this.labelcontrol3.Text = "Courses";
            // 
            // listBoxCourses
            // 
            this.listBoxCourses.Location = new System.Drawing.Point(224, 56);
            this.listBoxCourses.Name = "listBoxCourses";
            this.listBoxCourses.Size = new System.Drawing.Size(105, 218);
            this.listBoxCourses.TabIndex = 8;
            // 
            // listBoxSchedule
            // 
            this.listBoxSchedule.Location = new System.Drawing.Point(336, 56);
            this.listBoxSchedule.Name = "listBoxSchedule";
            this.listBoxSchedule.Size = new System.Drawing.Size(106, 218);
            this.listBoxSchedule.TabIndex = 10;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(336, 37);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 13);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Schedule";
            // 
            // UniversityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 336);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.listBoxSchedule);
            this.Controls.Add(this.labelcontrol3);
            this.Controls.Add(this.listBoxCourses);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.listBoxProfessors);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.listBoxStudents);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UniversityForm";
            this.Text = "UniversityForm";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxProfessors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem buttonAddStudent;
        private DevExpress.XtraBars.BarButtonItem buttonAddProfessor;
        private DevExpress.XtraBars.BarButtonItem buttonAddSchedule;
        private DevExpress.XtraBars.BarButtonItem buttonAddCourse;
        private DevExpress.XtraBars.BarButtonItem buttonAddGrade;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem ButtonSave;
        private DevExpress.XtraBars.BarButtonItem Load;
        private DevExpress.XtraEditors.LabelControl labelcontrol3;
        private DevExpress.XtraEditors.ListBoxControl listBoxCourses;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ListBoxControl listBoxProfessors;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ListBoxControl listBoxStudents;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ListBoxControl listBoxSchedule;
    }
}