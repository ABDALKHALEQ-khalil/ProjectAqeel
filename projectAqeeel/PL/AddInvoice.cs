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
        public AddInvoice()
        {
            InitializeComponent();
            this.comboBox1.DataSource = inv.GetAllNameGoods(); ;
            this.comboBox1.DisplayMember = "name";
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
            inv.AddInvoice(textBox1.Text, comboBox1.Text,Convert.ToInt32(numericUpDown1.Value),
                int.Parse(this.textBox2.Text , CultureInfo.InvariantCulture),int.Parse( this.textBox4.Text , CultureInfo.InvariantCulture) );
        }


        private void numericUpDown1_Click(object sender, EventArgs e)
        {
            int x;
            x = Convert.ToInt32(numericUpDown1.Value);
            textBox3.Text = Convert.ToString(Convert.ToInt32(comboBox1.SelectedValue) * x);
        }

    }
}
