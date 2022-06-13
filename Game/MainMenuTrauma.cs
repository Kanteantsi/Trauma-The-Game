using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{

    public partial class TraumaMainMenu : Form
    {
        SoundPlayer sp = new SoundPlayer(Game.Properties.Resources.Trauma_Theme);
        public TraumaMainMenu()
        {
            InitializeComponent();
        }


        private void Trauma_Load(object sender, EventArgs e)
        {
            if (DataBank.CharNameBySlot1 != "Slot1")
                StartNewGame.Enabled = false;

            
            if (DataBank.MusicOn == false)
            {
                sp.PlayLooping();
                DataBank.MusicOn = true;
            }
            //else if (DataBank.MusicOn == true)
            //{
            //    sp.Stop();
            //    DataBank.MusicOn = false;
            //}
        }

        private void CloseGame(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartGame_Click(object sender, EventArgs e)
        {

            Hide();
            DataBank.StartScreen.Show();
        }

        private void LoadOldGame_Click(object sender, EventArgs e)
        {
            Hide();
            DataBank.SaveScreen.Show();
        }

        private void PlayMusic_Click(object sender, EventArgs e)
        {


            //SoundPlayer sp = new SoundPlayer(Game.Properties.Resources.Trauma_Theme); 
            //if (DataBank.MusicOn == false)
            //{
            //    sp.PlayLooping();
            //    DataBank.MusicOn = true;
            //}
            if (DataBank.MusicOn == true)
            {
                sp.Stop();
                DataBank.MusicOn = false;
            }
        }

    }
}
