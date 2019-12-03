using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projectAqeeel.PL
{
    public partial class Invoice : UserControl
    {
        Code.Invoice invoice = new Code.Invoice();
        public Invoice()
        {
            InitializeComponent();
            
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
           // panel1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //panel1.Enabled = true;
            //addInvoice3.textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            ForInvoice FI = new ForInvoice();

            FI.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 1)
            {
                this.dataGridView1.DataSource = invoice.GetAllCustomer();
            }
            else
            {
                DataTable dt = new DataTable();
                dt = invoice.SearchCustomer(textBox1.Text);
                this.dataGridView1.DataSource = dt;
            }
        }

        public void datagrid (bool type )
        {
            if (type  )
            {
                this.dataGridView1.DataSource = invoice.GetAllCustomer();

            }
            else
            {
                this.dataGridView1.DataSource = invoice.
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            addCoustmer frm = new addCoustmer();
            frm.Show();
            
            
        }

        private void addInvoice3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
