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
    public partial class managematrialmony : UserControl
    {
        bool type = true;
        Code.Invoice inv = new Code.Invoice();
        
        public managematrialmony()
        {
            InitializeComponent();
        }

        private void managematrialmony_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            panel2.Location=new Point( 3,187);
            label2.Text = "البحث باسم العميل ";
            dataGridView2.DataSource = inv.GetAllCustomer();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Location = new Point(3, 110);
            label2.Text = "البحث باسم المورد ";
            dataGridView2.DataSource = inv.();

            type = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 0 || textBox2.Text.Length < 0)
            {
                if (!type)
                {

                    dataGridView2.DataSource = inv.SearchInvocie(Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString()));
                }
                else
                {
                    dataGridView2.DataSource = inv.SelectGoods(dataGridView2.CurrentRow.Cells[0].Value.ToString());

                }
            }
        }
    }
}
