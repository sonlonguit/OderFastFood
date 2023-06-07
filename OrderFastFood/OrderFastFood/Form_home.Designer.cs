
namespace OrderFastFood
{
    partial class Form_Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_product = new System.Windows.Forms.Button();
            this.button_order = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Sienna;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 76);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(177, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "🍗...M-Dragon...🍗";
            // 
            // button_product
            // 
            this.button_product.BackColor = System.Drawing.Color.PeachPuff;
            this.button_product.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_product.Location = new System.Drawing.Point(330, 139);
            this.button_product.Name = "button_product";
            this.button_product.Size = new System.Drawing.Size(154, 56);
            this.button_product.TabIndex = 1;
            this.button_product.Text = "Xem món";
            this.button_product.UseVisualStyleBackColor = false;
            this.button_product.Click += new System.EventHandler(this.button_product_Click);
            // 
            // button_order
            // 
            this.button_order.BackColor = System.Drawing.Color.PeachPuff;
            this.button_order.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_order.Location = new System.Drawing.Point(330, 244);
            this.button_order.Name = "button_order";
            this.button_order.Size = new System.Drawing.Size(154, 56);
            this.button_order.TabIndex = 2;
            this.button_order.Text = "Đặt hàng";
            this.button_order.UseVisualStyleBackColor = false;
            this.button_order.Click += new System.EventHandler(this.button_order_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(106, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(624, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rất hân hạnh được phục vụ quý khách !!!";
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.PeachPuff;
            this.button_exit.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_exit.Location = new System.Drawing.Point(330, 347);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(154, 56);
            this.button_exit.TabIndex = 5;
            this.button_exit.Text = "Thoát";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // Form_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(830, 505);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_order);
            this.Controls.Add(this.button_product);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form_Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_product;
        private System.Windows.Forms.Button button_order;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_exit;
    }
}