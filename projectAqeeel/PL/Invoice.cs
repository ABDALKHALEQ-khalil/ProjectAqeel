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
    public partial class Invoice : UserControl
    {
        public Invoice()
        {
            InitializeComponent();
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
        }
    }
}
