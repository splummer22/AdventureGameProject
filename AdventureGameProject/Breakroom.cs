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
    public partial class Breakroom : Form
    {
        public Breakroom()
        {
            InitializeComponent();
        }

        private void Breakroom_Load(object sender, EventArgs e)
        {
            pbBreakroom.Image = Properties.Resources.breakroom;
            pbBreakroom.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
