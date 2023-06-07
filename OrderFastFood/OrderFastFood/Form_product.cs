using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderFastFood
{
    public partial class Form_Product : Form
    {
        public Form_Product()
        {
            InitializeComponent();
        }

        private void Form_Home_Load(object sender, EventArgs e)
        {

        }


        private void garan_page1_Load(object sender, EventArgs e)
        {

        }

        // Quay về trang Home
        private void button_pro_exit_Click(object sender, EventArgs e)
        {
            Form home = new Form_Home();
            home.Show();
            this.Hide();
        }


        //Chuyển trang user controls
        private void button_garan1_Click(object sender, EventArgs e)
        {
            garan_uc1.BringToFront();
        }
        private void button_garan2_Click(object sender, EventArgs e)
        {
            garan_uc1.BringToFront();
        }

        private void button_pizza_Click(object sender, EventArgs e)
        {
            pizza_uc1.BringToFront();
        }

        private void button_trasua1_Click(object sender, EventArgs e)
        {
            trasua_uc1.BringToFront();
        }

        private void button_trasua2_Click(object sender, EventArgs e)
        {
            trasua_uc1.BringToFront();
        }

        
    }
}
