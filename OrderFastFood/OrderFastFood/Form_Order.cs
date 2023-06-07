using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OrderFastFood
{
    public partial class Form_Order : Form
    {
        //Khách hàng
        protected string name;
        protected string address;
        protected string phone;
        
        //Tính tiền
        protected double total, payment, cost;

        //Giá 
        const double price_garan1 = 25000;
        const double price_garan2 = 28000;
        const double price_garan3 = 28000;
        const double price_garan4 = 20000;

        const double price_pizza1 = 68000;
        const double price_pizza2 = 72000;
        const double price_pizza3 = 65000;
        const double price_pizza4 = 75000;

        const double price_trasua1 = 20000;
        const double price_trasua2 = 15000;
        const double price_trasua3 = 15000;
        const double price_trasua4 = 15000;
        public Form_Order()
        {
            InitializeComponent();
        }
     

        private void Form_order_Load(object sender, EventArgs e)
        {
            
        }


        private void EnableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }




        //Phương thức tính tiền
        private void button_ord_tinh_Click(object sender, EventArgs e)
        {
            double[] itemcost = new double[100];
            itemcost[0] = Convert.ToDouble(txt_garan1.Text) * price_garan1;
            itemcost[2] = Convert.ToDouble(txt_garan2.Text) * price_garan2;
            itemcost[3] = Convert.ToDouble(txt_garan3.Text) * price_garan3;
            itemcost[4] = Convert.ToDouble(txt_garan4.Text) * price_garan4;

            itemcost[5] = Convert.ToDouble(txt_pizza1.Text) * price_pizza1;
            itemcost[6] = Convert.ToDouble(txt_pizza2.Text) * price_pizza2;
            itemcost[7] = Convert.ToDouble(txt_pizza3.Text) * price_pizza3;
            itemcost[8] = Convert.ToDouble(txt_pizza4.Text) * price_pizza4;

            itemcost[9] = Convert.ToDouble(txt_trasua1.Text) * price_trasua1;
            itemcost[10] = Convert.ToDouble(txt_trasua2.Text) * price_trasua2;
            itemcost[11] = Convert.ToDouble(txt_trasua3.Text) * price_trasua3;
            itemcost[12] = Convert.ToDouble(txt_trasua4.Text) * price_trasua4;

            
            total = itemcost[0] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] 
                + itemcost[6] + itemcost[7] + itemcost[8] + itemcost[9] + itemcost[10] 
                + itemcost[11] + itemcost[12];

            txt_tienhoadon.Text = Convert.ToString(total);

            payment = Convert.ToInt32(txt_tienkhach.Text) ;
            cost = payment - total ;
            txt_tienthua.Text = Convert.ToString(cost);

        }


        //Quay về trang Home
        private void button_ord_exit_Click(object sender, EventArgs e)
        {
            Form home = new Form_Home();
            home.Show();
            this.Hide();
        }


        //Thông báo đã đặt hàng thành công
        private void button_ord_dathang_Click(object sender, EventArgs e)

        {
            name = txt_name.Text;
            address = txt_address.Text;
            phone = txt_phone.Text;

            MessageBox.Show("Cảm ơn quý khách " + name + " đã ủng hộ chúng tôi !!! Chúng sẽ giao cho quý khách đến địa chỉ " + address + " - số điện thoại: " + phone, "🍗...M-Dragon...🍗");
        }


        //Xử lý checkbox về giá trị 0
        private void cBox_garan1_CheckedChanged(object sender, EventArgs e)
        {
            if (cBox_garan1.Checked == true)
            {
                txt_garan1.Enabled = true;
                txt_garan1.Text = "";
                txt_garan1.Focus();
            }
            else
            {
                txt_garan1.Enabled = false;
                txt_garan1.Text = "0";
            }
        }

        private void cBox_garan2_CheckedChanged(object sender, EventArgs e)
        {
            if (cBox_garan2.Checked == true)
            {
                txt_garan2.Enabled = true;
                txt_garan2.Text = "";
                txt_garan2.Focus();
            }
            else
            {
                txt_garan2.Enabled = false;
                txt_garan2.Text = "0";
            }
        }

        private void cBox_garan3_CheckedChanged(object sender, EventArgs e)
        {
            if (cBox_garan3.Checked == true)
            {
                txt_garan3.Enabled = true;
                txt_garan3.Text = "";
                txt_garan3.Focus();
            }
            else
            {
                txt_garan3.Enabled = false;
                txt_garan3.Text = "0";
            }
        }

        private void cBox_garan4_CheckedChanged(object sender, EventArgs e)
        {
            if (cBox_garan4.Checked == true)
            {
                txt_garan4.Enabled = true;
                txt_garan4.Text = "";
                txt_garan4.Focus();
            }
            else
            {
                txt_garan4.Enabled = false;
                txt_garan4.Text = "0";
            }
        }

        private void cBox_pizza1_CheckedChanged(object sender, EventArgs e)
        {
            if (cBox_pizza1.Checked == true)
            {
                txt_pizza1.Enabled = true;
                txt_pizza1.Text = "";
                txt_pizza1.Focus();
            }
            else
            {
                txt_pizza1.Enabled = false;
                txt_pizza1.Text = "0";
            }
        }

        private void cBox_pizza2_CheckedChanged(object sender, EventArgs e)
        {
            if(cBox_pizza2.Checked == true)
            {
                txt_pizza2.Enabled = true;
                txt_pizza2.Text = "";
                txt_pizza2.Focus();
            }
            else
            {
                txt_pizza2.Enabled = false;
                txt_pizza2.Text = "0";
            }
        }

        private void cBox_pizza4_CheckedChanged(object sender, EventArgs e)
        {
            if (cBox_pizza4.Checked == true)
            {
                txt_pizza4.Enabled = true;
                txt_pizza4.Text = "";
                txt_pizza4.Focus();
            }
            else
            {
                txt_pizza4.Enabled = false;
                txt_pizza4.Text = "0";
            }
        }

        private void cBox_pizza3_CheckedChanged(object sender, EventArgs e)
        {
            if (cBox_pizza3.Checked == true)
            {
                txt_pizza3.Enabled = true;
                txt_pizza3.Text = "";
                txt_pizza3.Focus();
            }
            else
            {
                txt_pizza3.Enabled = false;
                txt_pizza3.Text = "0";
            }
        }

        private void cBox_trasua1_CheckedChanged(object sender, EventArgs e)
        {
            if (cBox_trasua1.Checked == true)
            {
                txt_trasua1.Enabled = true;
                txt_trasua1.Text = "";
                txt_trasua1.Focus();
            }
            else
            {
                txt_trasua1.Enabled = false;
                txt_trasua1.Text = "0";
            }
        }

        private void cBox_trasua2_CheckedChanged(object sender, EventArgs e)
        {
            if (cBox_trasua2.Checked == true)
            {
                txt_trasua2.Enabled = true;
                txt_trasua2.Text = "";
                txt_trasua2.Focus();
            }
            else
            {
                txt_trasua2.Enabled = false;
                txt_trasua2.Text = "0";
            }
        }

        private void cBox_trasua3_CheckedChanged(object sender, EventArgs e)
        {
            if (cBox_trasua3.Checked == true)
            {
                txt_trasua3.Enabled = true;
                txt_trasua3.Text = "";
                txt_trasua3.Focus();
            }
            else
            {
                txt_trasua3.Enabled = false;
                txt_trasua3.Text = "0";
            }
        }

        private void cBox_trasua4_CheckedChanged(object sender, EventArgs e)
        {
            if (cBox_trasua4.Checked == true)
            {
                txt_trasua4.Enabled = true;
                txt_trasua4.Text = "";
                txt_trasua4.Focus();
            }
            else
            {
                txt_trasua4.Enabled = false;
                txt_trasua4.Text = "0";
            }
        }

        
    }
}
