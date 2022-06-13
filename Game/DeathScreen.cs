using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class DeathScreen : Form
    {
        public DeathScreen()
        {
            InitializeComponent();

        }
        private void ToMainMenu_Click(object sender, EventArgs e)
        {
            //Hide();
            //DataBank.IsDead1 = true;
            //DataBank.DiedGoToDefault();
            //DataBank.TraumaMainMenu.Show();
            Application.Exit();
        }
    }
}
