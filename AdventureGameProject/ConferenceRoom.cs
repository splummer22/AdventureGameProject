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
        }

        private void ConferenceRoom_Load(object sender, EventArgs e)
        {
            pbConferenceRoom.Image = Properties.Resources.Conference_Room;
            pbConferenceRoom.SizeMode = PictureBoxSizeMode.StretchImage;

            lblTypingSpeed.Text = "" + info.TypingSpeed;
            lblAdaptability.Text = "" + info.Adaptibility;
            lblCaffiene.Text = "" + info.Caffeine;
            lblPowerPointSkills.Text = "" + info.Strength;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoseScreen n = new LoseScreen();
            n.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random s = new Random();
            int sum;
            sum = s.Next(1, 9) + info.Caffeine;
            if (sum >= 8)
            {
                MessageBox.Show("Success");

                WinScreen x = new WinScreen();
                x.Show();
                this.Hide();
            }
            else
            {
                LoseScreen x = new LoseScreen();
                x.Show();
                this.Hide();
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

                WinScreen x = new WinScreen();
                x.Show();
                this.Hide();
            }
            else
            {
                LoseScreen x = new LoseScreen();
                x.Show();
                this.Hide();
            }
        }
    }
}
