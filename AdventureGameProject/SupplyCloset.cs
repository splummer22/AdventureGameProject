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
        }

        private void SupplyCloset_Load(object sender, EventArgs e)
        {
            pbSupplyCloset.Image = Properties.Resources.SupplyCloset;
            pbSupplyCloset.SizeMode = PictureBoxSizeMode.StretchImage;

            lblTypingSpeed.Text = "" + info.TypingSpeed;
            lblAdaptability.Text = "" + info.Adaptibility;
            lblCaffiene.Text = "" + info.Caffeine;
            lblPowerPointSkills.Text = "" + info.Strength;
        }
    }
}
