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
    public partial class LoseScreen : Form
    {
        public LoseScreen()
        {
            InitializeComponent();
        }

        private void LoseScreen_Load(object sender, EventArgs e)
        {

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
