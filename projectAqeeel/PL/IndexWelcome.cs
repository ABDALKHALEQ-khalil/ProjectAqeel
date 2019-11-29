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
    public partial class IndexWelcome : UserControl
    {
        public IndexWelcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PL.addCoustmer frm = new addCoustmer();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PL.AddProduct frm = new AddProduct();
            frm.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Reports.invoice frm = new Reports.invoice();
            frm.Show();
        }
    }
}
