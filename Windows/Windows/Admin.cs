using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows

{
    public partial class Admin : Form
    {
        Form1 f1;
        public Admin(Form1 frm1)
        {
            InitializeComponent();
            this.f1 = frm1;
            label1.Text = f1.textBox1.Text;
            label9.Text = f1.montUser;
        }

        public void Admin_Load(object sender,EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.TopMost = false;
            this.Close();
        }

        private void Admin_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            depot dp = new depot(null, this);
            dp.Show();
            dp.TopMost = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            retrait rt = new retrait(null, this);
            rt.Show();
            rt.TopMost = true;
        }
    }
}
