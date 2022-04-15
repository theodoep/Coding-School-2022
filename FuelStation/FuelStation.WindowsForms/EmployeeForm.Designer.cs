namespace FuelStation.WindowsForms
{
    partial class EmployeeForm
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
            this.dataGridEmployees = new System.Windows.Forms.DataGridView();
            this.SaveEmployeeButton = new System.Windows.Forms.Button();
            this.buttonDeleteEmployee = new System.Windows.Forms.Button();
            this.buttonRefreshEmp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridEmployees
            // 
            this.dataGridEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmployees.Location = new System.Drawing.Point(12, 69);
            this.dataGridEmployees.Name = "dataGridEmployees";
            this.dataGridEmployees.RowTemplate.Height = 25;
            this.dataGridEmployees.Size = new System.Drawing.Size(744, 259);
            this.dataGridEmployees.TabIndex = 1;
            // 
            // SaveEmployeeButton
            // 
            this.SaveEmployeeButton.Location = new System.Drawing.Point(12, 40);
            this.SaveEmployeeButton.Name = "SaveEmployeeButton";
            this.SaveEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.SaveEmployeeButton.TabIndex = 2;
            this.SaveEmployeeButton.Text = "Save";
            this.SaveEmployeeButton.UseVisualStyleBackColor = true;
            this.SaveEmployeeButton.Click += new System.EventHandler(this.SaveEmployeeButton_ClickAsync);
            // 
            // buttonDeleteEmployee
            // 
            this.buttonDeleteEmployee.Location = new System.Drawing.Point(93, 40);
            this.buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            this.buttonDeleteEmployee.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteEmployee.TabIndex = 3;
            this.buttonDeleteEmployee.Text = "Delete";
            this.buttonDeleteEmployee.UseVisualStyleBackColor = true;
            //this.buttonDeleteEmployee.Click += new System.EventHandler(this.buttonDeleteEmployee_ClickAsync);
            // 
            // buttonRefreshEmp
            // 
            this.buttonRefreshEmp.Location = new System.Drawing.Point(174, 40);
            this.buttonRefreshEmp.Name = "buttonRefreshEmp";
            this.buttonRefreshEmp.Size = new System.Drawing.Size(75, 23);
            this.buttonRefreshEmp.TabIndex = 4;
            this.buttonRefreshEmp.Text = "Refresh";
            this.buttonRefreshEmp.UseVisualStyleBackColor = true;
            this.buttonRefreshEmp.Click += new System.EventHandler(this.buttonRefreshEmp_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRefreshEmp);
            this.Controls.Add(this.buttonDeleteEmployee);
            this.Controls.Add(this.SaveEmployeeButton);
            this.Controls.Add(this.dataGridEmployees);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridEmployees;
        private Button SaveEmployeeButton;
        private Button buttonDeleteEmployee;
        private Button buttonRefreshEmp;
    }
}