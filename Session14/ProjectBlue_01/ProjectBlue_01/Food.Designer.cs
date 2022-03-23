namespace CoffeeShopForms
{
    partial class Food
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
            this.grdFood = new DevExpress.XtraGrid.GridControl();
            this.grvFood = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ADD = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbQuantity = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbQuantity.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdFood
            // 
            this.grdFood.Location = new System.Drawing.Point(2, 2);
            this.grdFood.MainView = this.grvFood;
            this.grdFood.Name = "grdFood";
            this.grdFood.Size = new System.Drawing.Size(614, 446);
            this.grdFood.TabIndex = 0;
            this.grdFood.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvFood});
            // 
            // grvFood
            // 
            this.grvFood.GridControl = this.grdFood;
            this.grvFood.Name = "grvFood";
            this.grvFood.OptionsBehavior.Editable = false;
            // 
            // ADD
            // 
            this.ADD.BackColor = System.Drawing.Color.Tomato;
            this.ADD.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ADD.Location = new System.Drawing.Point(622, 212);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(114, 69);
            this.ADD.TabIndex = 1;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = false;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(622, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 69);
            this.button1.TabIndex = 2;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // cbQuantity
            // 
            this.cbQuantity.EditValue = "0";
            this.cbQuantity.Location = new System.Drawing.Point(622, 153);
            this.cbQuantity.Name = "cbQuantity";
            this.cbQuantity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbQuantity.Properties.DropDownRows = 12;
            this.cbQuantity.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbQuantity.Size = new System.Drawing.Size(114, 20);
            this.cbQuantity.TabIndex = 3;
            this.cbQuantity.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
            // 
            // Food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShopForms.Properties.Resources.jailbirds_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbQuantity);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.grdFood);
            this.Name = "Food";
            this.Text = "Food";
            this.Load += new System.EventHandler(this.Food_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbQuantity.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdFood;
        private DevExpress.XtraGrid.Views.Grid.GridView grvFood;
        private Button ADD;
        private Button button1;
        private DevExpress.XtraEditors.ComboBoxEdit cbQuantity;
    }
}