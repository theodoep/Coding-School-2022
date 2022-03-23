namespace CoffeeShopForms
{
    partial class Completion
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.rbCard = new System.Windows.Forms.RadioButton();
            this.grdOrder = new DevExpress.XtraGrid.GridControl();
            this.grvOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblDisc = new System.Windows.Forms.Label();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnDisc = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(488, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 66);
            this.button1.TabIndex = 2;
            this.button1.Text = "Proceed";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ProceedButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(655, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 66);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Checked = true;
            this.rbCash.Location = new System.Drawing.Point(681, 343);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(51, 19);
            this.rbCash.TabIndex = 4;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Cash";
            this.rbCash.UseVisualStyleBackColor = true;
            // 
            // rbCard
            // 
            this.rbCard.AutoSize = true;
            this.rbCard.Location = new System.Drawing.Point(681, 318);
            this.rbCard.Name = "rbCard";
            this.rbCard.Size = new System.Drawing.Size(85, 19);
            this.rbCard.TabIndex = 5;
            this.rbCard.Text = "Credit Card";
            this.rbCard.UseVisualStyleBackColor = true;
            // 
            // grdOrder
            // 
            this.grdOrder.Location = new System.Drawing.Point(2, 0);
            this.grdOrder.MainView = this.grvOrder;
            this.grdOrder.Name = "grdOrder";
            this.grdOrder.Size = new System.Drawing.Size(411, 452);
            this.grdOrder.TabIndex = 6;
            this.grdOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvOrder});
            // 
            // grvOrder
            // 
            this.grvOrder.GridControl = this.grdOrder;
            this.grvOrder.Name = "grvOrder";
            this.grvOrder.OptionsBehavior.ReadOnly = true;
            // 
            // lblDisc
            // 
            this.lblDisc.AutoSize = true;
            this.lblDisc.Location = new System.Drawing.Point(488, 339);
            this.lblDisc.Name = "lblDisc";
            this.lblDisc.Size = new System.Drawing.Size(78, 15);
            this.lblDisc.TabIndex = 7;
            this.lblDisc.Text = "Discount: NO";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(12, 415);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(488, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(310, 103);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // btnDisc
            // 
            this.btnDisc.Location = new System.Drawing.Point(488, 357);
            this.btnDisc.Name = "btnDisc";
            this.btnDisc.Size = new System.Drawing.Size(79, 23);
            this.btnDisc.TabIndex = 10;
            this.btnDisc.Text = "Apply Discount";
            this.btnDisc.Visible = false;
            this.btnDisc.Click += new System.EventHandler(this.btnDisc_Click);
            // 
            // Completion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDisc);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblDisc);
            this.Controls.Add(this.grdOrder);
            this.Controls.Add(this.rbCard);
            this.Controls.Add(this.rbCash);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Completion";
            this.Text = "Order Review";
            this.Load += new System.EventHandler(this.Completion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button1;
        private Button button2;
        private RadioButton rbCash;
        private RadioButton rbCard;
        private DevExpress.XtraGrid.GridControl grdOrder;
        private DevExpress.XtraGrid.Views.Grid.GridView grvOrder;
        private Label lblDisc;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
        private RichTextBox richTextBox1;
        private DevExpress.XtraEditors.SimpleButton btnDisc;
    }
}