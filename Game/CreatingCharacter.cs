using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    
    public partial class CreatingCharacter : Form
    {
        public CreatingCharacter()
        {
            InitializeComponent();
            
        }

        //Program.Character CurrentCharacter = new Program.Character();
        public void CheckCurrentCharacter() {
            if (DataBank.CharNameBySlot1 != "Slot1 ")
            {
                Program.CurrentCharacter = Program.Char2;
            }
            else if (DataBank.CharNameBySlot2 != "Slot2 ")
            {
                Program.CurrentCharacter = Program.Char3;
            }
            else 
            {
                DialogResult result = MessageBox.Show(
                "Вы исчерпали все слоты сохранения для персонажей. Если вы согласны с этим, и хотите продолжить, будет перезаписано первое сохрание. Продолжить?",
                "Предупреждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.Yes)
                    Program.CurrentCharacter = Program.Char1;
            }



        }
        
        private void CreatingCharacter_Load(object sender, EventArgs e)
        {
            CheckCurrentCharacter();

            if (DataBank.IsDead2 == true)
            {
                DataBank.IsDead2 = false;
                CharacterName.Text = " ";
                Origin.Text = " ";
                Strength.Text = " ";
                Agility.Text = " ";
                Intellegence.Text = " ";
                Endurance.Text = " ";
                Faith.Text = " ";
                Prana.Text = " ";
                Luck.Text = " ";

                CharacterClass.Text = " ";
                this.Refresh();
            }

        }

        private void GameClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
       private void Thief_Click(object sender, EventArgs e)
        {
            Program.CurrentCharacter.SetStrength_(8);
            Program.CurrentCharacter.SetAgility_(12);
            Program.CurrentCharacter.SetIntellegence_(4);
            Program.CurrentCharacter.SetEndurance_(8);
            Program.CurrentCharacter.SetFaith_(4);
            Program.CurrentCharacter.SetPrana_(2);
            Program.CurrentCharacter.SetLuck_(3);


            Strength.Text = "8";
            Agility.Text = "12";
            Intellegence.Text = "4";
            Endurance.Text = "8";
            Faith.Text = "4";
            Prana.Text = "2";
            Luck.Text = "3";

            CharacterClass.Text = "Thief";
            DataBank.Health = (Int32.Parse(Strength.Text)*5);
            DataBank.Endurance = (Int32.Parse(Endurance.Text));
            DataBank.Mana = (Int32.Parse(Intellegence.Text)*5);
            DataBank.Prana = (Int32.Parse(Faith.Text) * 5);
        }


        private void Warrior_Click(object sender, EventArgs e)
        {
            Program.CurrentCharacter.SetStrength_(12);
            Program.CurrentCharacter.SetAgility_(8);
            Program.CurrentCharacter.SetIntellegence_(4);
            Program.CurrentCharacter.SetEndurance_(10);
            Program.CurrentCharacter.SetFaith_(4);
            Program.CurrentCharacter.SetPrana_(2);
            Program.CurrentCharacter.SetLuck_(1);


            Strength.Text = "12";
            Agility.Text = "8";
            Intellegence.Text = "4";
            Endurance.Text = "10";
            Faith.Text = "4";
            Prana.Text = "2";
            Luck.Text = "1";

            CharacterClass.Text = "Warrior";
            DataBank.Health = (Int32.Parse(Strength.Text) * 5);
            DataBank.Endurance = (Int32.Parse(Endurance.Text));
            DataBank.Mana = (Int32.Parse(Intellegence.Text) * 5);
            DataBank.Prana = (Int32.Parse(Faith.Text) * 5);
        }


        private void Mage_Click(object sender, EventArgs e)
        {
            Program.CurrentCharacter.SetStrength_(4);
            Program.CurrentCharacter.SetAgility_(4);
            Program.CurrentCharacter.SetIntellegence_(12);
            Program.CurrentCharacter.SetEndurance_(6);
            Program.CurrentCharacter.SetFaith_(8);
            Program.CurrentCharacter.SetPrana_(4);
            Program.CurrentCharacter.SetLuck_(1);


            Strength.Text = "4";
            Agility.Text = "4";
            Intellegence.Text = "12";
            Endurance.Text = "6";
            Faith.Text = "8";
            Prana.Text = "4";
            Luck.Text = "1";

            CharacterClass.Text = "Mage";
            DataBank.Health = (Int32.Parse(Strength.Text) * 5);
            DataBank.Endurance = (Int32.Parse(Endurance.Text));
            DataBank.Mana = (Int32.Parse(Intellegence.Text) * 5);
            DataBank.Prana = (Int32.Parse(Faith.Text) * 5);
        }

        private void Priest_Click(object sender, EventArgs e)
        {
            Program.CurrentCharacter.SetStrength_(6);
            Program.CurrentCharacter.SetAgility_(6);
            Program.CurrentCharacter.SetIntellegence_(8);
            Program.CurrentCharacter.SetEndurance_(4);
            Program.CurrentCharacter.SetFaith_(12);
            Program.CurrentCharacter.SetPrana_(8);
            Program.CurrentCharacter.SetLuck_(2);


            Strength.Text = "6";
            Agility.Text = "6";
            Intellegence.Text = "8";
            Endurance.Text = "4";
            Faith.Text = "12";
            Prana.Text = "8";
            Luck.Text = "2";

            CharacterClass.Text = "Priest";
            DataBank.Health = (Int32.Parse(Strength.Text) * 5);
            DataBank.Endurance = (Int32.Parse(Endurance.Text));
            DataBank.Mana = (Int32.Parse(Intellegence.Text) * 5);
            DataBank.Prana = (Int32.Parse(Faith.Text)*5);
        }

        
        private void CharacterName_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.Match(CharacterName.Text, @"[а-яА-Я]|[a-zA-Z]").Success)
            {
                MessageBox.Show("Ну и бессмыслица, такого имени не бывает!");
            }

            Program.CurrentCharacter.SetName_(CharacterName.Text);

        }

        private void Origin_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.CurrentCharacter.SetOrigin_(Origin.Text);
        }

        private void SaveAndContinue_Click(object sender, EventArgs e)
        {
            Program.CurrentCharacter.SetStrength_(Int32.Parse(Strength.Text));
            Program.CurrentCharacter.SetAgility_(Int32.Parse(Agility.Text));
            Program.CurrentCharacter.SetIntellegence_(Int32.Parse(Intellegence.Text));
            Program.CurrentCharacter.SetEndurance_(Int32.Parse(Endurance.Text));
            Program.CurrentCharacter.SetFaith_(Int32.Parse(Faith.Text));
            Program.CurrentCharacter.SetPrana_(Int32.Parse(Prana.Text));
            Program.CurrentCharacter.SetLuck_(Int32.Parse(Luck.Text));
            Program.CurrentCharacter.SetName_(CharacterName.Text);
            Program.CurrentCharacter.SetOrigin_(Origin.Text);
            DataBank.CharacterClass = CharacterClass.Text;
            DataBank.CharNameBySlot1 = CharacterName.Text;
            DataBank.ScreenNumber = 1;
        }

        
        private void ToMainMenu_Click(object sender, EventArgs e)
        {
            Hide();
            DataBank.TraumaMainMenu.Show();
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            Hide();
            DataBank.ChooseS_Screen.Show();
        }

        private void CharacterClass_TextChanged(object sender, EventArgs e)
        {
            DataBank.CharacterClass = CharacterClass.Text;
        }
    }
}
