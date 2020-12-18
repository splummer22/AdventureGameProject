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
    public partial class ConferenceRoom : Form
    {
        CharacterClass info;

        public ConferenceRoom(CharacterClass c)
        {
            InitializeComponent();
            info = c;
            //calls CharacterClass as c, puts the information into info
        }

        private void ConferenceRoom_Load(object sender, EventArgs e)
        {
            pbConferenceRoom.Image = Properties.Resources.Conference_Room;
            pbConferenceRoom.SizeMode = PictureBoxSizeMode.StretchImage;
            //conference room pic

            lblTypingSpeed.Text = "" + info.TypingSpeed;
            lblAdaptability.Text = "" + info.Adaptibility;
            lblCaffiene.Text = "" + info.Caffeine;
            lblPowerPointSkills.Text = "" + info.Strength;
            //puts stats in stats box
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoseScreen n = new LoseScreen();
            n.Show();
            this.Hide();
            //determines what happens when button 3 is clicked
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random s = new Random();
            int sum;
            sum = s.Next(1, 9) + info.Caffeine + info.Adaptibility;
            if (sum >= 7)
            {
                MessageBox.Show("Success");

                WinScreen x = new WinScreen(info);
                x.Show();
                this.Hide();
            }
            else
            {
                LoseScreen x = new LoseScreen();
                x.Show();
                this.Hide();
            }
            //determines what happens when button 1 is clicked
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random s = new Random();
            int sum;
            sum = s.Next(1, 9) + info.TypingSpeed + info.Strength;
            if (sum >= 6)
            {
                MessageBox.Show("Success!");

                WinScreen x = new WinScreen(info);
                x.Show();
                this.Hide();
            }
            else
            {
                LoseScreen x = new LoseScreen();
                x.Show();
                this.Hide();
            }
            //determines what happens when button 2 is clicked
        }
    }
}
