using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectAqeeel.PL
{
    public partial class managesells : UserControl
    {
        Code.Customers cus = new Code.Customers();
        Code.Invoice inv = new Code.Invoice();
        public managesells()
        {
            InitializeComponent();
            dataGridView2.DataSource = inv.GetAllCustomer();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length >0)
            dataGridView2.DataSource= inv.SearchCustomer(textBox2.Text);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)

                dataGridView1.DataSource = inv.SearchInvocie(Convert.ToInt32(textBox1.Text));
        }
    }
}
