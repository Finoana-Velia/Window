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
    
    public partial class depot : Form
    {
        User us;
        Admin ad;
        public String Confirmation = "Transaction effectuer!";

        public depot(User us,Admin ad)
        {
            InitializeComponent();
            this.us = us;
            this.ad = ad;
        }

        private void depot_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ad == null)
            {
                us.label8.Text = textBox1.Text;
                MessageBox.Show(Confirmation);
                this.Close();
            }
            else
            {
                ad.label9.Text = textBox1.Text;
                MessageBox.Show(Confirmation);
                this.Close();
            }
        }
    }
}
