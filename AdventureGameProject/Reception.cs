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
    public partial class Reception : Form
    {
        CharacterClass info;

        public Reception(CharacterClass c)
        {
            InitializeComponent();
            info = c;
        }

        private void Reception_Load(object sender, EventArgs e)
        {

        }
    }
}
