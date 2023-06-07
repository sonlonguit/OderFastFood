using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OrderFastFood
{
    public partial class Form_Home : Form
    {
        public Form_Home()
        {
            InitializeComponent();
        }


        //Chuyển trang Product
        private void button_product_Click(object sender, EventArgs e)
        {
            Form products = new Form_Product();
            products.Show();
            this.Hide();

        }


        //Thông báo thoát ứng dụng
        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng này !!!", "🍗...M-Dragon...🍗", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        //Chuyển trang Order
        private void button_order_Click(object sender, EventArgs e)
        {
            Form order = new Form_Order();
            order.Show();
            this.Hide();
        }

        private void Form_Home_Load(object sender, EventArgs e)
        {

        }

    }
}
