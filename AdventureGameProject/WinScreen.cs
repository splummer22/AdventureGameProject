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
    public partial class WinScreen : Form
    {
        CharacterClass info;

        public WinScreen(CharacterClass c)
        {
            InitializeComponent();
            info = c;
            //calls CharacterClass as c, puts the information into info
        }

        private void WinScreen_Load(object sender, EventArgs e)
        {
            label2.Text = "" + (info.Energy * 15);
            //calculates score by multiplying energy by 5, displays score
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            CharacterCreation x = new CharacterCreation();
            x.Show();
            this.Hide();
            //Allows player to restart game when button is clicked
        }
    }
}
