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
    
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
        }

       //Form2 f2 = new Form2();

        private void Form1_Load(object sender, EventArgs e)
        {
         //   f2.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            // this.Close();
            this.TopMost = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client cl = new Client(null,null,null,null,null,null,null);
            

        }
       
        private void Text_Nom(object sender,EventArgs e)
        {
            textBox1.Clear();
            pictureBox2.BackgroundImage = Properties.Resources.user_alt_512;
            panel1.ForeColor = Color.FromArgb(0, 64, 64);
            textBox1.ForeColor = Color.FromArgb(0, 64, 64);
        }

        private void Text_prenom(object sender, EventArgs e)
        {
            textBox2.Clear();
            pictureBox3.BackgroundImage = Properties.Resources.user_alt_512;
            panel2.ForeColor = Color.FromArgb(0, 64, 64);
            textBox2.ForeColor = Color.FromArgb(0, 64, 64);
        }

        private void Text_mdp(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox3.PasswordChar = '*';
            pictureBox4.BackgroundImage = Properties.Resources.password_512;
            panel3.ForeColor = Color.FromArgb(0, 64, 64);
            textBox3.ForeColor = Color.FromArgb(0, 64, 64);
        }

        private void Text_Adresse(object sender,EventArgs e)
        {
            textBox5.Clear();
            pictureBox5.BackgroundImage = Properties.Resources.téléchargement__1_;
            panel5.ForeColor = Color.FromArgb(0, 64, 64);
            textBox5.ForeColor = Color.FromArgb(0, 64, 64);
        }

        private void Text_Email(object sender ,EventArgs e)
        {
            textBox6.Clear();
            pictureBox8.BackgroundImage = Properties.Resources.free_mail_icon_142_thumb;
            panel6.ForeColor = Color.FromArgb(0, 64, 64);
            textBox6.ForeColor = Color.FromArgb(0, 64, 64);
        }

        private void text_CIN(object sender,EventArgs e)
        {
            textBox4.Clear();
            pictureBox4.BackgroundImage = Properties.Resources._88591;
            panel4.ForeColor = Color.FromArgb(0, 64, 64);
            textBox4.ForeColor = Color.FromArgb(0, 64, 64);
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
