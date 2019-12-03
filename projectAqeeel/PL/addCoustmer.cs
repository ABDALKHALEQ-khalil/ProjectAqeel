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
    public partial class addCoustmer : Form
    {
        Code.Customers Cus = new Code.Customers();
        public addCoustmer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Cus.CustomerIsHere(textBox1.Text);
            Cus.addCustomer(textBox1.Text,Double.Parse(maskedTextBox1.Text), textBox3.Text);
            MessageBox.Show("تم اضافة عميل بنجاح" , "OK" , MessageBoxButtons.OK , MessageBoxIcon.Information);
            this.Close();
        }
    }
}
