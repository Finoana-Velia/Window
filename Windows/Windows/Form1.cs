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
    
    public partial class Form1 : Form
    {
        
            
       
        public Client[] liste = new Client[10];
        public Client admin = new Client("Admin", "", "0000", "14.01.03", "superadmin@gmail.com", "117456789", "1000");
        public Client cl1 = new Client("Rakoto", "Be", "qwerty", "12.05.99", "Rakoto@yahoo.com", "11745123", "500");
        public Client cl2 = new Client("Rajao","Kely","123456","25.12.96","Rajao@hotmail.fr","117456357","0");
        public String montUser;
        public Form1()
        {
            InitializeComponent();
        }

       
        Form2 f2 = new Form2();

        public void Form1_Load(object sender, EventArgs e)
        {
            //f2.Show();
        }


        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            pictureBox2.BackgroundImage = Properties.Resources.free_mail_icon_142_thumb;
            panel1.ForeColor = Color.FromArgb(0, 64, 64);
            textBox1.ForeColor = Color.FromArgb(0, 64, 64); 
        }

        public void textBox2_textChanged(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.PasswordChar = '*';
            pictureBox3.BackgroundImage = Properties.Resources.password_512;
            panel2.ForeColor = Color.FromArgb(0, 64, 64);
            textBox2.ForeColor = Color.FromArgb(0, 64, 64);
        }

        public void sign_Click(object sender, EventArgs e)
        {
            f2.Show();
            timer3.Start();

        }

        public void log_Click(object sender, EventArgs e)
        {
            String textErrorName = "Votre nom est introuvable";
            String textErrorPsw = "Erreur de mot de passe";
            
            String textError = "Veuillez remplir tous les champs!";
            admin.type = true;
            liste[0] = admin;
            liste[1] = cl1;

            if ((textBox1.Text == " Votre Email")|(textBox2.Text == " Votre mot de passe")|(textBox1.Text == "") | (textBox2.Text == ""))
            {
                MessageBox.Show(textError);
            }
            else
            {
                bool check = false;
                for (int i = 0; i < liste.Length; i++)
                {
                    if(liste[i].nom == textBox1.Text)
                    {
                        if (liste[i].mdp == textBox2.Text)
                        {
                            //montUser = liste[i].solde;
                            check = true;
                            if (liste[i].type)
                            {
                                montUser = liste[i].solde;
                                Admin f = new Admin(this);
                                f.Show();
                                f.TopMost = true;
                                break;
                            }
                            else
                            {
                                montUser = liste[i].solde;
                                User u = new User(this);
                                u.Show();
                                u.TopMost = true;
                                break;
                            }
                        }
                        else
                        {
                            MessageBox.Show(textErrorPsw);
                        }
                    }
                }
                if (check == false)
                {
                    MessageBox.Show(textErrorName);
                }


                

            }
        }

        public void timer1_Tick(object sender,EventArgs e)
        {
             
            f2.Left += 10;
            if (f2.Left >= 800)
            {
                timer3.Stop();
                //this.TopMost = false;
                f2.TopMost = true;
                timer4.Start();
            }

        }

        public void timer2_Tick(object sender, EventArgs e)
        {
            f2.Left -= 10;
            if(f2.Left <=290)
            {
                timer4.Stop();
            }
        }

        public void BtnExit(object sender,EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        

    }

}
