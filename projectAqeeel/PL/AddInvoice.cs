using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace projectAqeeel.PL
{
    public partial class AddInvoice : UserControl
    {
        Code.Invoice inv = new Code.Invoice();
        Code.Customers cus = new Code.Customers();

        public AddInvoice()
        {
            InitializeComponent();
            
            this.comboBox1.DataSource = inv.GetAllNameGoods(); ;
           
            this.comboBox1.DisplayMember = "name";
            textBox4.Text = "0";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBox1.ValueMember = "Quantity";
            this.numericUpDown1.Maximum =Convert.ToDecimal(comboBox1.SelectedValue);
            this.comboBox1.ValueMember = "PRICE";
            this.textBox2.Text = Convert.ToString(comboBox1.SelectedValue);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                inv.AddInvoice(textBox1.Text, comboBox1.Text, Convert.ToInt32(numericUpDown1.Value),
            int.Parse(this.textBox2.Text, CultureInfo.InvariantCulture)
            , int.Parse(this.textBox4.Text, CultureInfo.InvariantCulture));
                MessageBox.Show("Add Successfully");
                
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        
        }


        private void numericUpDown1_Click(object sender, EventArgs e)
        {
            int x;
            x = Convert.ToInt32(numericUpDown1.Value);
            textBox3.Text = Convert.ToString(Convert.ToInt32(comboBox1.SelectedValue) * x);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
