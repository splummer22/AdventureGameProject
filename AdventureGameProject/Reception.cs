using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureGameProject
{
    public partial class Reception : Form
    {
        CharacterClass info;

        public Reception(CharacterClass c)
        {
            InitializeComponent();
            info = c;
        }

        private void Reception_Load(object sender, EventArgs e)
        {
            pbReception.Image = Properties.Resources.reception;
            pbReception.SizeMode = PictureBoxSizeMode.StretchImage;

            lblTypingSpeed.Text = "" + info.TypingSpeed;
            lblAdaptability.Text = "" + info.Adaptibility;
            lblCaffiene.Text = "" + info.Caffeine;
            lblPowerPointSkills.Text = "" + info.Strength;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random s = new Random();
            int sum;
            sum = s.Next(1, 9) + info.Caffeine;
            if(sum >= 4)
            {
                MessageBox.Show("Success!");
                
                Breakroom n = new Breakroom(info);
                n.Show();
                this.Hide();
            }
            else
            {
                info.Energy = info.Energy - 1;
                if (info.Energy <= 0)
                {
                    LoseScreen x = new LoseScreen();
                    x.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("The Receptionist is in a bad mood.\nThe cup of coffee has been thrown in your face.");

                    Breakroom n = new Breakroom(info);
                    n.Show();
                    this.Hide();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random s = new Random();
            int sum;
            sum = s.Next(1, 9) + info.Caffeine;
            if (sum >= 7)
            {
                MessageBox.Show("Success!");
                
                Breakroom n = new Breakroom(info);
                n.Show();
                this.Hide();
            }
            else
            {
                info.Energy = info.Energy - 2;
                if (info.Energy <= 0)
                {
                    LoseScreen x = new LoseScreen();
                    x.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("You overestimated your stealth. \n The receptionist lets the security dog loose, but you only loose one finger, so you continue on.");
                    
                    Breakroom n = new Breakroom(info);
                    n.Show();
                    this.Hide();
                }
            }
        }
    }
}
