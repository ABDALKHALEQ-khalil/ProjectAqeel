using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectAqeeel.PL
{
    public partial class ForInvoice : Form
    {
        Code.Invoice invoice = new Code.Invoice();
        public ForInvoice()
        {
            
            InitializeComponent();
            comboBox1.DataSource = invoice.GetAllNameGoods();
            comboBox1.DisplayMember = "name";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ForInvoice_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            comboBox1.DataSource = invoice.SelectGoods(comboBox1.Text);
            comboBox1.DisplayMember = "NAME";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
