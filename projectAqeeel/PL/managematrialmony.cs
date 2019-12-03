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
        Code.supplers sup = new Code.supplers();
        string search;
        
        public managematrialmony()
        {
            InitializeComponent();
            dataGridView2.DataSource= sup.GetAllSupplaers();
        }

        private void managematrialmony_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            panel2.Location=new Point( 3,187);
            label2.Text = "البحث باسم العميل ";
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = inv.GetAllCustomer();
            type = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Location = new Point(3, 110);
            label2.Text = "البحث باسم المورد ";
            dataGridView2.DataSource = sup.GetAllSupplaers();
            dataGridView1.DataSource = null;
            type = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 )
            {
                if (type)
                {
                    
                    dataGridView2.DataSource = inv.SearchCustomer(textBox1.Text);
                }
                else
                {
                    dataGridView2.DataSource = sup.SearchSuppllaers(textBox1.Text);
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if ( textBox2.Text.Length > 0)
            {
                if (type)
                {
                    dataGridView1.DataSource = inv.SearchInvocie(Convert.ToInt32( textBox2.Text));
                }
                else
                {
                    dataGridView1.DataSource = sup.SearchInvoiceSupplaer(Convert.ToInt32(textBox2.Text));
                }
            }
        }
    }
}
