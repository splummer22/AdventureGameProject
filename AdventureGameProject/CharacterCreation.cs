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
        public int PowerPointSkills;
        public string name;

        CharacterClass Characters;

        public CharacterCreation()
        {
            InitializeComponent();
            Characters = new CharacterClass();
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

        private void cbPowerPointSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            PowerPointSkills = Convert.ToInt32(cbPowerPointSkills.Text);
            cbCaffeine.Items.Remove(cbPowerPointSkills.Text);
            cbAdaptibility.Items.Remove(cbPowerPointSkills.Text);
            cbTypingSpeed.Items.Remove(cbPowerPointSkills.Text);
        }

        private void cbTypingSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypingSpeed = Convert.ToInt32(cbTypingSpeed.Text);
            cbCaffeine.Items.Remove(cbTypingSpeed.Text);
            cbPowerPointSkills.Items.Remove(cbTypingSpeed.Text);
            cbAdaptibility.Items.Remove(cbTypingSpeed.Text);
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
                
                Characters.TypingSpeed = TypingSpeed;
                Characters.Adaptibility = Adaptibility;
                Characters.Caffeine = Caffeine;
                Characters.Strength = PowerPointSkills;
                Characters.name = name;
                Characters.picture = pbCharacter.Image;
                Characters.Energy = 10;

                Reception n = new Reception(Characters);
                n.Show();
                this.Hide();

                }
            else
            {
                MessageBox.Show("Please select an option for each category");
            }
           
        }

        private void CharacterCreation_Load(object sender, EventArgs e)
        {

        }

        private void cbPowerPointSkills_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            PowerPointSkills = Convert.ToInt32(cbPowerPointSkills.Text);
            cbCaffeine.Items.Remove(cbPowerPointSkills.Text);
            cbAdaptibility.Items.Remove(cbPowerPointSkills.Text);
            cbTypingSpeed.Items.Remove(cbPowerPointSkills.Text);
        }
    }
}
