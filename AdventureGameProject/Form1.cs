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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Office1;
        }

        private void lblStart_Click_1(object sender, EventArgs e)
        {
            CharacterCreation n = new CharacterCreation();
            n.Show();
            this.Hide();
            //Creates new CharacterCreaton window
        }
    }
}
