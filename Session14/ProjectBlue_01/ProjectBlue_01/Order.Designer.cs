namespace CoffeeShopForms
{
    partial class Order
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
            this.button1 = new System.Windows.Forms.Button();
            this.unboundSource1 = new DevExpress.Data.UnboundSource(this.components);
            this.Coffee = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.unboundSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(725, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "LogOut";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // Coffee
            // 
            this.Coffee.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Coffee.Location = new System.Drawing.Point(23, 188);
            this.Coffee.Name = "Coffee";
            this.Coffee.Size = new System.Drawing.Size(216, 174);
            this.Coffee.TabIndex = 10;
            this.Coffee.Text = "Coffee";
            this.Coffee.UseVisualStyleBackColor = true;
            this.Coffee.Click += new System.EventHandler(this.CoffeeButton_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(292, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(216, 174);
            this.button3.TabIndex = 11;
            this.button3.Text = "Beverage";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BeverageButton_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(560, 188);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(216, 174);
            this.button4.TabIndex = 12;
            this.button4.Text = "Food";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.FoodButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(292, 463);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 117);
            this.button2.TabIndex = 13;
            this.button2.Text = "CONFIRM";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShopForms.Properties.Resources.photo0jpg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(801, 625);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Coffee);
            this.Controls.Add(this.button1);
            this.Name = "Order";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.unboundSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button button1;
        private DevExpress.Data.UnboundSource unboundSource1;
        private Button Coffee;
        private Button button3;
        private Button button4;
        private Button button2;
    }
}