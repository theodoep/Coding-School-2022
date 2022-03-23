namespace CoffeeShopForms
{
    partial class Beverage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Beverage));
            this.grdBeverage = new DevExpress.XtraGrid.GridControl();
            this.grvBeverage = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.ADD = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbQuantity = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBeverage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvBeverage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbQuantity.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdBeverage
            // 
            this.grdBeverage.Location = new System.Drawing.Point(0, 0);
            this.grdBeverage.MainView = this.grvBeverage;
            this.grdBeverage.Name = "grdBeverage";
            this.grdBeverage.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1});
            this.grdBeverage.Size = new System.Drawing.Size(542, 441);
            this.grdBeverage.TabIndex = 0;
            this.grdBeverage.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvBeverage});
            this.grdBeverage.Click += new System.EventHandler(this.grdBeverage_Click);
            // 
            // grvBeverage
            // 
            this.grvBeverage.CustomizationFormBounds = new System.Drawing.Rectangle(1618, 342, 264, 272);
            this.grvBeverage.GridControl = this.grdBeverage;
            this.grvBeverage.Name = "grvBeverage";
            this.grvBeverage.OptionsBehavior.Editable = false;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // ADD
            // 
            this.ADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ADD.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ADD.Location = new System.Drawing.Point(548, 245);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(114, 71);
            this.ADD.TabIndex = 1;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = false;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(548, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 71);
            this.button2.TabIndex = 2;
            this.button2.Text = "BACK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // cbQuantity
            // 
            this.cbQuantity.EditValue = "0";
            this.cbQuantity.Location = new System.Drawing.Point(548, 186);
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
            this.cbQuantity.TabIndex = 4;
            this.cbQuantity.SelectedIndexChanged += new System.EventHandler(this.cbQuantity_SelectedIndexChanged);
            // 
            // Beverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(778, 453);
            this.Controls.Add(this.cbQuantity);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.grdBeverage);
            this.Name = "Beverage";
            this.Text = "Beverages";
            this.Load += new System.EventHandler(this.Beverage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBeverage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvBeverage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbQuantity.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdBeverage;
        private DevExpress.XtraGrid.Views.Grid.GridView grvBeverage;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private Button ADD;
        private Button button2;
        private DevExpress.XtraEditors.ComboBoxEdit cbQuantity;
    }
}