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
    public partial class SupplyCloset : Form
    {
        CharacterClass info;

        public SupplyCloset(CharacterClass c)
        {
            InitializeComponent();
            info = c;
            //calls CharacterClass as c, puts the information into info
        }

        private void SupplyCloset_Load(object sender, EventArgs e)
        {
            pbSupplyCloset.Image = Properties.Resources.SupplyCloset;
            pbSupplyCloset.SizeMode = PictureBoxSizeMode.StretchImage;
            //Supply closet pic

            lblTypingSpeed.Text = "" + info.TypingSpeed;
            lblAdaptability.Text = "" + info.Adaptibility;
            lblCaffiene.Text = "" + info.Caffeine;
            lblPowerPointSkills.Text = "" + info.Strength;
            //puts stats in stats box
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random s = new Random();
            int sum;
            sum = s.Next(1, 9) + info.Caffeine;
            if (sum >= 8)
            {
                MessageBox.Show("Success");
                
                Cubicle n = new Cubicle(info);
                n.Show();
                this.Hide();
            }
            else
            {
                info.Energy = info.Energy - 3;
                if (sum <= 0)
                {
                    LoseScreen x = new LoseScreen();
                }
                else
                {
                    MessageBox.Show("The computer has crashed.\n\nYou walk to your cubicle, emptyhanded and unprepared");

                    Cubicle n = new Cubicle(info);
                    n.Show();
                    this.Hide();
                }     
            }
            //what happens when button 1 is clicked
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random s = new Random();
            int sum;
            sum = s.Next(1, 9) + info.Caffeine;
            if (sum >= 7)
            {
                MessageBox.Show("Success");
                
                Cubicle n = new Cubicle(info);
                n.Show();
                this.Hide();
            }
            else
            {
                info.Energy = info.Energy - 4;
                if(sum <= 0)
                {
                    LoseScreen x = new LoseScreen();
                }
                else
                {
                    MessageBox.Show("There is not enough time to find the supplies.\n\nYou walk to your cubicle, emptyhanded and unprepared.");
                    
                    Cubicle n = new Cubicle(info);
                    n.Show();
                    this.Hide();
                }
            }
            //what happens when button 2 is clicked
        }
    }
}
