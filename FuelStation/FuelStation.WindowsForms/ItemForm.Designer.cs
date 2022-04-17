namespace FuelStation.WindowsForms
{
    partial class ItemForm
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
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.EditItemButton = new System.Windows.Forms.Button();
            this.refreshItemButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Location = new System.Drawing.Point(22, 59);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.RowTemplate.Height = 25;
            this.dataGridViewItems.Size = new System.Drawing.Size(658, 302);
            this.dataGridViewItems.TabIndex = 0;
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.Location = new System.Drawing.Point(190, 30);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(76, 23);
            this.deleteItemButton.TabIndex = 2;
            this.deleteItemButton.Text = "Delete";
            this.deleteItemButton.UseVisualStyleBackColor = true;
            this.deleteItemButton.Click += new System.EventHandler(this.deleteItemButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(22, 30);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // EditItemButton
            // 
            this.EditItemButton.Location = new System.Drawing.Point(103, 30);
            this.EditItemButton.Name = "EditItemButton";
            this.EditItemButton.Size = new System.Drawing.Size(81, 23);
            this.EditItemButton.TabIndex = 5;
            this.EditItemButton.Text = "Edit";
            this.EditItemButton.UseVisualStyleBackColor = true;
            this.EditItemButton.Click += new System.EventHandler(this.EditItemButton_Click);
            // 
            // refreshItemButton
            // 
            this.refreshItemButton.Location = new System.Drawing.Point(272, 30);
            this.refreshItemButton.Name = "refreshItemButton";
            this.refreshItemButton.Size = new System.Drawing.Size(76, 23);
            this.refreshItemButton.TabIndex = 6;
            this.refreshItemButton.Text = "Refresh";
            this.refreshItemButton.UseVisualStyleBackColor = true;
            this.refreshItemButton.Click += new System.EventHandler(this.refreshItemButton_Click);
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 368);
            this.Controls.Add(this.refreshItemButton);
            this.Controls.Add(this.EditItemButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteItemButton);
            this.Controls.Add(this.dataGridViewItems);
            this.Name = "ItemForm";
            this.Text = "ItemForm";
            this.Load += new System.EventHandler(this.ItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewItems;
        private Button deleteItemButton;
        private Button addButton;
        private Button EditItemButton;
        private Button refreshItemButton;
    }
}