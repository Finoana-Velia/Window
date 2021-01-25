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
    public partial class User : Form
    {
        Form1 f1;
        
        public User(Form1 frm1)
        {
            InitializeComponent();
            this.f1 = frm1;
            label1.Text = f1.textBox1.Text;
            label8.Text = f1.montUser;
        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.TopMost = false;
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            depot dp = new depot(this,null);
            dp.Show();
            dp.TopMost = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            retrait rt = new retrait(this,null);
            rt.Show();
            rt.TopMost = true;
        }
    }
}
