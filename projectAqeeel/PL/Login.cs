using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace projectAqeeel
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PL.Index ind = new PL.Index();
            Code.Login log = new Code.Login(); 
            DataTable dt = new DataTable();
            dt = log.GetInfoUser(textBox1.Text, textBox2.Text);
            if (dt.Rows.Count > 0 )
            {
               
                ind.Show();
                dt = log.isAdmin(textBox1.Text);
                Code.UserInfo.username = textBox1.Text;
                if (dt.Rows.Count > 0 )
                {
                    ind.Admin.Enabled = true;
                }
               
            }
            else
            {
                MessageBox.Show("اسم المستخدم او كلمة المرور غير صحيحه ","خطأ " , MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
