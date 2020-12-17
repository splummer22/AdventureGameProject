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
    public partial class Cubicle : Form
    {
        CharacterClass info;

        public Cubicle(CharacterClass c)
        {
            InitializeComponent();
            info = c;
            //calls CharacterClass as c, puts the information into info
        }

        private void Cubicle_Load(object sender, EventArgs e)
        {
            pbCubicle.Image = Properties.Resources.Cubicle;
            pbCubicle.SizeMode = PictureBoxSizeMode.StretchImage;
            //cubicle pic

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
            if (sum >= 7)
            {
                MessageBox.Show("Success");
                
                ConferenceRoom n = new ConferenceRoom(info);
                n.Show();
                this.Hide();
            }
            else
            {
                info.Energy = info.Energy - 2;
                if (info.Energy <= 0)
                {
                    LoseScreen x = new LoseScreen();
                }
                else
                {
                    MessageBox.Show("Your keyboard malfunctions.\n\nYou are forced to include many grammatical errors in your presentation.");
                    
                    ConferenceRoom n = new ConferenceRoom(info);
                    n.Show();
                    this.Hide();
                }
            }
            //what happens if button 1 is clicked
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random s = new Random();
            int sum;
            sum = s.Next(1, 9) + info.Caffeine;
            if (sum >= 8)
            {
                MessageBox.Show("Success");
                
                ConferenceRoom n = new ConferenceRoom(info);
                n.Show();
                this.Hide();
            }
            else
            {
                info.Energy = info.Energy - 3;

                if (info.Energy <= 0)
                {
                    LoseScreen x = new LoseScreen();
                }
                else
                {
                    MessageBox.Show("Your fingers are fatigued.\n\nYour proposal is badly typed and you do not have time to finish it.");
                    
                    ConferenceRoom n = new ConferenceRoom(info);
                    n.Show();
                    this.Hide();
                }
            }
            //what happens when button 2 is clicked
        }
    }
}
