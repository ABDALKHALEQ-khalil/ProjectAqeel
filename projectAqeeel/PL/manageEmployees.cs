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
    public partial class manageEmployees : UserControl
    {
        Code.Employees emp = new Code.Employees();
        public manageEmployees()
        {
            InitializeComponent();
            panel1.Enabled = false;
            dataGridView1.DataSource = emp.GetAllEmployee();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = emp.SearchEmployee(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            textBox2.Text =  dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text =  dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox1.Text =  dataGridView1.CurrentRow.Cells[3].Value.ToString();
            maskedTextBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.TextLength == 9)
            {
                if(maskedTextBox2.TextLength < 13)
                {
                    maskedTextBox2.Text += "0000000000"; 
                }
                else
                emp.AddEmployee(textBox2.Text, textBox3.Text, Convert.ToInt32(maskedTextBox1.Text), Convert.ToInt32(maskedTextBox2.Text));
            }
            else
            {
                MessageBox.Show("يرجى ملئ الفراغات جيداً");
            }
            MessageBox.Show("تمت الإضافه بنجاح ^_^");
            update();
        }
        void update ()
        {
            dataGridView1.DataSource = emp.GetAllEmployee();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            emp.DeleteEmployee(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            update();
            MessageBox.Show("تم الحذف بنجاح ");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            textBox2.Text = "";
            textBox3.Text = "";
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            update();

        }
    }
}
