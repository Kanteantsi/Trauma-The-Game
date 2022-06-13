using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Runtime.InteropServices;

namespace Game
{
    public partial class SuccessScreen : Form
    {
        public SuccessScreen()
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

        private void SuccessScreen_Load(object sender, EventArgs e)
        {
            if (DataBank.ScreenNumber == 24)
            {
                this.BackgroundImage = Game.Properties.Resources.Победа_щит;
                Refresh();
            }
            if (DataBank.ScreenNumber == 48)
            {
                this.BackgroundImage = Game.Properties.Resources.Победа_топор;
                Refresh();
            }

            if (DataBank.ScreenNumber == 68)
            {
                this.BackgroundImage = Game.Properties.Resources.Победа_перчатки;
                Refresh();
            }
        }
    }
}
