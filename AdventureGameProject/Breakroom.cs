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
            MessageBox.Show("Success!");
            
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
                MessageBox.Show("Success");
                
                SupplyCloset n = new SupplyCloset(info);
                n.Show();
                this.Hide();
            }
            else
            {
                info.Energy = info.Energy - 0;
                if (info.Energy <= 0) 
                {
                    LoseScreen x = new LoseScreen();
                    x.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("You have spilled coffee on yourself.\n\nTrying not to draw attention to yourself, you stifle your screams of pain and escape to the safety of the supply closet.");
                    
                    SupplyCloset n = new SupplyCloset(info);
                    n.Show();
                    this.Hide();
                }
            }
        }
    }
}
