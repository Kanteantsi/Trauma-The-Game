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
    
    public partial class SavesScreen : Form
    {
        public SavesScreen()
        {
            InitializeComponent();
        }


        public void Slot1_Click(object sender, EventArgs e)
        {
            if (DataBank.CharNameBySlot1 != "Slot1")
            { 
            Hide();
            DataBank.ChooseS_Screen.Show();
            }
        }

        private void Slot2_Click(object sender, EventArgs e)
        {
            if (DataBank.CharNameBySlot2 != "Slot2")
            {
                Hide();
            DataBank.ChooseS_Screen.Show();
            }
        }

        private void Slot3_Click(object sender, EventArgs e)
        {
            if (DataBank.CharNameBySlot3 != "Slot3")
            {
                Hide();
                DataBank.ChooseS_Screen.Show();
            }
            
        }

        private void SavesScreen_Load(object sender, EventArgs e)
        {
            Slot1.Text = DataBank.CharNameBySlot1;
            Slot2.Text = DataBank.CharNameBySlot2;
            Slot3.Text = DataBank.CharNameBySlot3;
        }

        private void ToMainMenu_Click(object sender, EventArgs e)
        {
            Hide();
            DataBank.TraumaMainMenu.Show();
        }
    }
}
