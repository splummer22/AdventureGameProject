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
        CharacterClass info;
        public Breakroom(CharacterClass c)
        {
            InitializeComponent();

            info = c;
        }

        private void Breakroom_Load(object sender, EventArgs e)
        {
            pbBreakroom.Image = Properties.Resources.breakroom;
            pbBreakroom.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SupplyCloset n = new SupplyCloset(info);
            n.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random s = new Random();
            int sum;
            sum = s.Next(1, 9) + info.Caffeine;
            if (sum >= 5)
            {
                SupplyCloset n = new SupplyCloset(info);
                n.Show();
                this.Hide();
            }
            else
            {
                SupplyCloset n = new SupplyCloset(info);
                n.Show();
                this.Hide();
            }
        }
    }
}
