﻿using System;
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
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
            Admin.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void إغلاقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            indexWelcome1.BringToFront();
        }

        private void indexWelcome1_Load(object sender, EventArgs e)
        {
            indexWelcome1.BringToFront();

        }

        private void إضافةفاتورهToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            invoice1.label1.Text = "اسم العميل "; 
            invoice1.BringToFront();
        }

        private void تعديلفاتورهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            invoice1.BringToFront();

        }

        private void طباعةفاتورهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.invoice frm = new Reports.invoice();
            frm.Show();
        }

        private void إدارةالفواتيرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            invoice1.BringToFront();
        }

        private void السحبياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employees1.BringToFront();

        }

        private void إغلاقToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void إغلاقToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void اضافةمنتجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            invoice1.label1.Text = "اسم المورد :";
            invoice1.button4.Text = "إضافة مورد ";
            Invoice.type = true;
            invoice1.BringToFront();
        }

        private void storage1_Load(object sender, EventArgs e)
        {

        }

        private void Index_Load(object sender, EventArgs e)
        {
            indexWelcome1.BringToFront();
        }

        private void invoice1_Load(object sender, EventArgs e)
        {

        }

        private void إدارةالمبيعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            managesells1.BringToFront();
        }

        private void إدارةالموظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageEmployees1.BringToFront();
        }

        private void إدارةالمواردالماليةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            managematrialmony1.BringToFront();
        }

        private void managematrialmony1_Load(object sender, EventArgs e)
        {

        }
    }
}
