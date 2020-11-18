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
        }

        private void Cubicle_Load(object sender, EventArgs e)
        {
            pbCubicle.Image = Properties.Resources.Cubicle;
            pbCubicle.SizeMode = PictureBoxSizeMode.StretchImage;

            lblTypingSpeed.Text = "" + info.TypingSpeed;
            lblAdaptability.Text = "" + info.Adaptibility;
            lblCaffiene.Text = "" + info.Caffeine;
            lblPowerPointSkills.Text = "" + info.Strength;
        }
    }
}
