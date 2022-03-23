namespace CoffeeShopForms
{
    partial class Coffee
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
            this.grdCoffee = new DevExpress.XtraGrid.GridControl();
            this.grvCoffee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ADD = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbQuantity = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCoffee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCoffee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbQuantity.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCoffee
            // 
            this.grdCoffee.Location = new System.Drawing.Point(2, 2);
            this.grdCoffee.MainView = this.grvCoffee;
            this.grdCoffee.Name = "grdCoffee";
            this.grdCoffee.Size = new System.Drawing.Size(557, 448);
            this.grdCoffee.TabIndex = 0;
            this.grdCoffee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvCoffee});
            // 
            // grvCoffee
            // 
            this.grvCoffee.GridControl = this.grdCoffee;
            this.grvCoffee.Name = "grvCoffee";
            this.grvCoffee.OptionsBehavior.Editable = false;
            // 
            // ADD
            // 
            this.ADD.BackColor = System.Drawing.Color.Sienna;
            this.ADD.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ADD.Location = new System.Drawing.Point(565, 222);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(115, 74);
            this.ADD.TabIndex = 1;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = false;
            this.ADD.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Sienna;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(565, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 74);
            this.button2.TabIndex = 2;
            this.button2.Text = "BACK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // cbQuantity
            // 
            this.cbQuantity.EditValue = "0";
            this.cbQuantity.Location = new System.Drawing.Point(566, 166);
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
            // 
            // Coffee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShopForms.Properties.Resources.coffee_cover_v06;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbQuantity);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.grdCoffee);
            this.Name = "Coffee";
            this.Text = "Coffee";
            this.Load += new System.EventHandler(this.Coffee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCoffee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCoffee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbQuantity.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdCoffee;
        private DevExpress.XtraGrid.Views.Grid.GridView grvCoffee;
        private Button ADD;
        private Button button2;
        private DevExpress.XtraEditors.ComboBoxEdit cbQuantity;
    }
}