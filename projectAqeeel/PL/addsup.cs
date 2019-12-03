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
    public partial class addsup : UserControl
    {
        Code.supplers sup = new Code.supplers();
        public addsup()
        {
            InitializeComponent();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sup.AddSupplaers(textBox1.Text, comboBox1.Text, Convert.ToInt32(maskedTextBox1.Text), textBox2.Text, textBox3.Text);
            MessageBox.Show("تمت الإضافة بنجاح ");
        }
    }
}
