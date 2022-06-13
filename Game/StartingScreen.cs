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
    public partial class StartingScreen : Form
    {
        public StartingScreen()
        {
            InitializeComponent();
        }
        public Form CreateChar = new CreatingCharacter();
        private void CreatingCharacter_Click(object sender, EventArgs e)
        {
            Hide();
            CreateChar.Show();
        }

        private void StartingScreen_Load(object sender, EventArgs e)
        {
           
        }

        private void GameClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToMainMenu_Click(object sender, EventArgs e)
        {
            Hide();
            DataBank.TraumaMainMenu.Show();
        }
    }
}
