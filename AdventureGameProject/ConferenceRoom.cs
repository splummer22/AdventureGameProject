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
    }
}
