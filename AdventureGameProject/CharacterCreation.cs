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
    public partial class CharacterCreation : Form
    {
        public int TypingSpeed;
        public int Adaptibility;
        public int Caffeine;
        public int Strength;
        public string name;
        public string picture;

        public CharacterCreation()
        {
            InitializeComponent();
        }

        private void cbCaffeine_SelectedIndexChanged(object sender, EventArgs e)
        {
            Caffeine = Convert.ToInt32(cbCaffeine.Text);
            cbAdaptibility.Items.Remove(cbCaffeine.Text);
            cbPowerPointSkills.Items.Remove(cbCaffeine.Text);
            cbTypingSpeed.Items.Remove(cbCaffeine.Text);
        }

        private void cbAdaptibility_SelectedIndexChanged(object sender, EventArgs e)
        {
            Adaptibility = Convert.ToInt32(cbAdaptibility.Text);
            cbCaffeine.Items.Remove(cbAdaptibility.Text);
            cbPowerPointSkills.Items.Remove(cbAdaptibility.Text);
            cbTypingSpeed.Items.Remove(cbAdaptibility.Text);
        }

        private void cbStrength_SelectedIndexChanged(object sender, EventArgs e)
        {
            Caffeine = Convert.ToInt32(cbCaffeine.Text);
            cbCaffeine.Items.Remove(cbPowerPointSkills.Text);
            cbAdaptibility.Items.Remove(cbPowerPointSkills.Text);
            cbTypingSpeed.Items.Remove(cbPowerPointSkills.Text);
        }

        private void cbTypingSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypingSpeed = Convert.ToInt32(cbTypingSpeed.Text);
            cbCaffeine.Items.Remove(cbCaffeine.Text);
            cbPowerPointSkills.Items.Remove(cbCaffeine.Text);
            cbAdaptibility.Items.Remove(cbCaffeine.Text);
        }

        private void cbCharacterPicture_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCharacterPicture.Text == "Notebook Nancy")
            {
                pbCharacter.Image = Properties.Resources.FirstCharacter;
            }
            else if (cbCharacterPicture.Text == "Laptop Larry") 
            {
                pbCharacter.Image = Properties.Resources._2ndCharacter;
            }
            else if(cbCharacterPicture.Text == "Tuxedo Tom")
            {
                pbCharacter.Image = Properties.Resources._3rdCharacter;
            }
            else if(cbCharacterPicture.Text == "Casual Cameron")
            {
                pbCharacter.Image = Properties.Resources._4thCharacter;
            }

            pbCharacter.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(TypingSpeed != 0 && Caffeine != 0 && Adaptibility != 0 && cbCharacterPicture.Text != "")
                { 
                Reception n = new Reception();
                n.Show();
                this.Hide();

                }
            else
            {
                MessageBox warning = new MessageBox("Please select an option for each category");
            }
           
        }
    }
}
