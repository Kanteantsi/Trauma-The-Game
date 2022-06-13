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
    public partial class ChooseScreen : Form
    {
        public ChooseScreen()

        {
            InitializeComponent();

            DataBank.ScreenNumber = 1;
            Variant3.Visible = false;
            Variant3.Enabled = false;

        }

        //public DeathScreen(ChooseScreen() ChooseScreen)
        //{
        //    InitializeComponent();
        //    f.BackColor = Color.Yellow;
        //}
        //public DataBank.DeathScreen(DataBank.ChooseScreen)
        //  {
        //       InitializeComponent();

        //  }



        //public static bool ButOneisPressed = false;
        //public static bool ButTwoisPressed = false;
        //public static bool ButThreeisPressed = false;
        //public static bool ButFourisPressed = false;
        private void Variant1_Click(object sender, EventArgs e)
        {
            UpdateByClick(1);

        }

        private void Variant2_Click(object sender, EventArgs e)
        {
            UpdateByClick(2);
        }

        private void Variant3_Click(object sender, EventArgs e)
        {
            UpdateByClick(3);
        }

        private void Variant4_Click(object sender, EventArgs e)
        {
            UpdateByClick(4);
        }

        //private void ChooseScreen_Update()
        //{



        //}

        private void UpdateByClick(int ButtonNumber)
        {
            
            void DoFight()
            {
                DataBank.CheckCharSkills();
                Variant1.Text = DataBank.CharSkill1;
                Variant2.Text = DataBank.CharSkill2;
                Variant3.Text = DataBank.CharSkill3;
                Variant4.Text = DataBank.CharSkill4;
                
            }
            //DataBank.ScreenNumber = 1;
            //while (DataBank.ScreenNumber < 7)

            if (DataBank.ScreenNumber == 1)
            {

                label1.Text = DataBank.ScreenNumber.ToString();
                this.Refresh();
                QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                this.Refresh();
                //this.Refresh();

                //
                //QuestionThatPushesTheQuest.Text = DataBank.QuestionThatPushesTheQuest;
                //Variant1.Text = DataBank.TextButtonVariant1;
                //Variant2.Text = DataBank.TextButtonVariant2;
                //Variant3.Text = DataBank.TextButtonVariant3;
                //Variant4.Text = DataBank.TextButtonVariant4;

                if (ButtonNumber == 1)
                {

                    //DataBank.ScreenNumber = 1;
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    this.Refresh();
                    Variant3.Visible = true;
                    Variant3.Enabled = true;

                }

                else if (ButtonNumber == 2)
                {

                    //DataBank.ScreenNumber = 1;
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 24;
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    this.Refresh();
                    Variant3.Visible = true;
                    Variant3.Enabled = true;

                }

                //else if (ButtonNumber == 3)
                //{

                //    //DataBank.ScreenNumber = 1;
                //    DataBank.ScreenNumber = DataBank.ScreenNumber + 68;
                //    DataBank.ShowScreenInfo();
                //    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                //    Variant1.Text = DataBank.TextButtonVariant1;
                //    Variant2.Text = DataBank.TextButtonVariant2;
                //    Variant3.Text = DataBank.TextButtonVariant3;
                //    Variant4.Text = DataBank.TextButtonVariant4;
                //    label1.Text = DataBank.ScreenNumber.ToString();
                //    this.Refresh();


                //}
                else if (ButtonNumber == 4)
                {

                    //DataBank.ScreenNumber = 1;
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 48;
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    this.Refresh();

                    Variant3.Visible = true;
                    Variant3.Enabled = true;
                }
            }

            else if ((DataBank.ScreenNumber == 2) && (ButtonNumber == 1))
            {
                //label1.Text = DataBank.ScreenNumber.ToString();
                //this.Refresh();
                //ButOneisPressed = false;
                DataBank.Gold = Int32.Parse(Variant1.Text);
                DataBank.ScreenNumber = DataBank.ScreenNumber + 2;
                DataBank.ShowScreenInfo();
                QuestionThatPushesTheQuests.Text = "Вы заплатили провожатому 250 монет, и было необходимо арендовать лошадей. Так как на оставшуюся сумму вы не смогли нанять охрану, через лес вам предстояло идти вдвоём. В конюшне на выбор было несколько коней — Вихрь, что являлся самым быстрым, но трусливым; Верный, что самый медленный, но остаётся с владельцем до конца; Дымка, что не самый медленный, и не самый трусливый; Рыжий, что не самый медленный, и не самый трусливый. Какого коня вы взяли?";
                Variant1.Text = DataBank.TextButtonVariant1;
                Variant2.Text = DataBank.TextButtonVariant2;
                Variant3.Text = DataBank.TextButtonVariant3;
                Variant4.Text = DataBank.TextButtonVariant4;
                label1.Text = DataBank.ScreenNumber.ToString();
                //DataBank.ScreenNumber = DataBank.ScreenNumber + 2;
                this.Refresh();


            }

            else if ((DataBank.ScreenNumber == 2) && ((ButtonNumber == 2) || (ButtonNumber == 3) || (ButtonNumber == 4)))
            {

                //this.Refresh();



                if (ButtonNumber == 2)
                    DataBank.Gold = Int32.Parse(Variant2.Text);
                else if (ButtonNumber == 3)
                    DataBank.Gold = Int32.Parse(Variant3.Text);
                else if (ButtonNumber == 4)
                    DataBank.Gold = Int32.Parse(Variant4.Text);

                //ButTwoisPressed = false;
                //ButThreeisPressed = false;
                //ButFourisPressed = false;
                DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                DataBank.ShowScreenInfo();
                QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                Variant1.Text = DataBank.TextButtonVariant1;
                Variant2.Text = DataBank.TextButtonVariant2;
                Variant3.Text = DataBank.TextButtonVariant3;
                Variant4.Text = DataBank.TextButtonVariant4;
                label1.Text = DataBank.ScreenNumber.ToString();
                this.Refresh();

                if (DataBank.Gold < 200)
                {
                    Variant1.Enabled = false;
                    Variant2.Enabled = false;
                    Variant3.Enabled = false;
                    Variant4.Enabled = false;
                }
                else if (DataBank.Gold < 400)
                {
                    Variant2.Enabled = false;
                    Variant3.Enabled = false;
                    Variant4.Enabled = false;
                }
                else if (DataBank.Gold < 600)
                {
                    Variant3.Enabled = false;
                    Variant4.Enabled = false;
                }
                else if (DataBank.Gold - 250 < 1100)
                {
                    Variant4.Enabled = false;
                }
            }

            else if (DataBank.ScreenNumber == 3)
            {
                Variant1.Enabled = true;
                Variant2.Enabled = true;
                Variant3.Enabled = true;
                Variant4.Enabled = true;



                if ((ButtonNumber == 1))
                {
                    //DataBank.Gold = DataBank.Gold - 250;
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                    DataBank.Gold = DataBank.Gold - 200;
                    DataBank.Squad = 3;
                    this.Refresh();



                }
                else if ((ButtonNumber == 2))
                {
                    //DataBank.Gold = DataBank.Gold - 250;
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = "Вы заплатили провожатому 250 монет, и было необходимо арендовать лошадей. В конюшне на выбор было несколько коней — Вихрь, что являлся самым быстрым, но трусливым; Верный, что самый медленный, но остаётся с владельцем до конца; Дымка, что не самый медленный, и не самый трусливый; Рыжий, что не самый медленный, и не самый трусливый. Какого коня вы взяли?"; ;
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                    DataBank.Gold = DataBank.Gold - 400;
                    DataBank.Squad = 4;
                    this.Refresh();


                }
                else if ((ButtonNumber == 3))
                {
                    //DataBank.Gold = DataBank.Gold - 250;
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = "Вы заплатили провожатому 250 монет, и было необходимо арендовать лошадей. В конюшне на выбор было несколько коней — Вихрь, что являлся самым быстрым, но трусливым; Верный, что самый медленный, но остаётся с владельцем до конца; Дымка, что не самый медленный, и не самый трусливый; Рыжий, что не самый медленный, и не самый трусливый. Какого коня вы взяли?"; ;
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                    DataBank.Gold = DataBank.Gold - 600;
                    DataBank.Squad = 5;
                    this.Refresh();


                }
                else if ((ButtonNumber == 4))
                {
                    //DataBank.Gold = DataBank.Gold - 250;
                    //this.Refresh();
                    //ButFourisPressed = false;
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();

                    QuestionThatPushesTheQuests.Text = "Вы заплатили провожатому 250 монет, и было необходимо арендовать лошадей. В конюшне на выбор было несколько коней — Вихрь, что являлся самым быстрым, но трусливым; Верный, что самый медленный, но остаётся с владельцем до конца; Дымка, что не самый медленный, и не самый трусливый; Рыжий, что не самый медленный, и не самый трусливый. Какого коня вы взяли?";
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                    DataBank.Gold = DataBank.Gold - 800;
                    DataBank.Squad = 6;
                    this.Refresh();


                }

            }

            else if (DataBank.ScreenNumber == 4)
            {
                DataBank.Gold = DataBank.Gold - 250;
                Variant1.Enabled = true;
                Variant2.Enabled = true;
                Variant3.Enabled = true;
                Variant4.Enabled = true;
                //DataBank.Gold = DataBank.Gold - 250;
                label1.Text = DataBank.ScreenNumber.ToString();
                //DataBank.ShowScreenInfo();
                //QuestionThatPushesTheQuest.Text = DataBank.QuestionThatPushesTheQuest;
                //Variant1.Text = DataBank.TextButtonVariant1;
                //Variant2.Text = DataBank.TextButtonVariant2;
                //Variant3.Text = DataBank.TextButtonVariant3;
                //Variant4.Text = DataBank.TextButtonVariant4;
                //this.Refresh();
                //DataBank.ShowScreenInfo();
                if (ButtonNumber == 1)
                {
                    //ButOneisPressed = false;
                    DataBank.Horse = Variant1.Text;
                    //this.Refresh();
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                    this.Refresh();
                }
                else if (ButtonNumber == 2)
                {
                    //ButTwoisPressed = false;
                    DataBank.Horse = Variant2.Text;
                    //this.Refresh();

                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                    this.Refresh();

                }

                else if (ButtonNumber == 3)
                {
                    //ButThreeisPressed = false;
                    DataBank.Horse = Variant3.Text;
                    //this.Refresh();

                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                    this.Refresh();
                }
                else if (ButtonNumber == 4)
                {
                    //ButFourisPressed = false;
                    DataBank.Horse = Variant4.Text;
                    //this.Refresh();

                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                    this.Refresh();
                }

            }

            else if (DataBank.ScreenNumber == 5)
            {
                label1.Text = DataBank.ScreenNumber.ToString();
                DataBank.ShowScreenInfo();
                QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                Variant1.Text = DataBank.TextButtonVariant1;
                Variant2.Text = DataBank.TextButtonVariant2;
                Variant3.Text = DataBank.TextButtonVariant3;
                Variant4.Text = DataBank.TextButtonVariant4;
                this.Refresh();

                if ((ButtonNumber == 1) && (DataBank.CharacterClass != "Thief"))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    QuestionThatPushesTheQuests.Text = " На вас напали бандиты! Сражайтесь за свою жизнь!";
                    DoFight();
                    Refresh();
                }

                else if ((ButtonNumber == 2) && (DataBank.CharacterClass != "Warrior"))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    QuestionThatPushesTheQuests.Text = " На вас напали бандиты! Сражайтесь за свою жизнь!";
                    DoFight();
                    Refresh();
                }

                else if ((ButtonNumber == 4) && (DataBank.CharacterClass != "Mage"))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    QuestionThatPushesTheQuests.Text = " На вас напали бандиты! Сражайтесь за свою жизнь!";
                    DoFight();
                    Refresh();
                }

                else if ((ButtonNumber == 3) && (DataBank.CharacterClass != "Priest"))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    QuestionThatPushesTheQuests.Text = " На вас напали бандиты! Сражайтесь за свою жизнь!";
                    DoFight();
                    Refresh();
                }

                else if ((ButtonNumber == 3) && (DataBank.CharacterClass == "Priest"))
                {

                    DataBank.ScreenNumber = DataBank.ScreenNumber + 2;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    QuestionThatPushesTheQuests.Text = " От вашей молитвы, на дерево падает луч света. Видимо, божества решили вас испытать. Поднимается могучий энт. Защитите себя, и докажите, что достойны силы богов!";
                    DoFight();
                    Refresh();
                }


                else if ((ButtonNumber == 1) && (DataBank.CharacterClass == "Thief"))
                {

                    DataBank.ScreenNumber = DataBank.ScreenNumber + 4;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                    this.Refresh();
                }


                else if ((ButtonNumber == 2) && (DataBank.CharacterClass == "Warrior"))
                {

                    DataBank.ScreenNumber = DataBank.ScreenNumber + 4;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                    this.Refresh();
                }

                else if ((ButtonNumber == 4) && (DataBank.CharacterClass == "Mage"))
                {

                    DataBank.ScreenNumber = DataBank.ScreenNumber + 4;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                    this.Refresh();
                }
            }

            else if (DataBank.ScreenNumber == 6)
            {
                //label1.Text = DataBank.ScreenNumber.ToString();
                //Refresh();

                if ((ButtonNumber == 3) || (ButtonNumber == 4) && (DataBank.Squad >= 2))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 3;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                    this.Refresh();
                }
                else if (!(((ButtonNumber == 3) || (ButtonNumber == 4)) && (DataBank.Squad >= 2)))
                {
                    if (DataBank.CheckCharSkills() != "Priest")
                    {
                        DataBank.ScreenNumber = DataBank.ScreenNumber + 2;
                        //this.Hide();
                        DataBank.ShowScreenInfo();
                        DeathScreen DeathForm = new DeathScreen();
                        DataBank.DeathForm.DeathhText.Text = DataBank.DeathMessage;
                        DeathForm.Refresh();
                        DataBank.DeathForm.Show();
                        this.Refresh();
                    }
                    else if (DataBank.CheckCharSkills() == "Priest")
                    {
                        DataBank.ScreenNumber = DataBank.ScreenNumber + 2;
                        DataBank.ShowScreenInfo();
                        //this.Hide();
                        DeathScreen DeathForm = new DeathScreen();
                        DataBank.DeathForm.DeathhText.Text = DataBank.DeathMessage;
                        DataBank.DeathForm.Show();
                        this.Refresh();
                    }
                }
            }

            else if (DataBank.ScreenNumber == 7)
            {
                label1.Text = DataBank.ScreenNumber.ToString();
                Refresh();

                if ((ButtonNumber == 3) || (ButtonNumber == 4) && (DataBank.Squad >= 2))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 2;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                    this.Refresh();
                }
                else if (!(((ButtonNumber == 3) || (ButtonNumber == 4)) && (DataBank.Squad >= 2)))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    Hide();
                    DeathScreen DeathForm = new DeathScreen();
                    DataBank.DeathForm.DeathhText.Text = DataBank.DeathMessage;
                    DataBank.DeathForm.Show();
                }
            }

            else if (DataBank.ScreenNumber == 9)
            {
                label1.Text = DataBank.ScreenNumber.ToString();
                Refresh();

                if ((ButtonNumber == 1) || (ButtonNumber == 2) || (ButtonNumber == 3))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                    this.Refresh();
                }
                else if (((ButtonNumber == 4)))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 2;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;


                    if (DataBank.Gold < 50)
                    {
                        Variant1.Enabled = false;
                        Variant2.Enabled = false;
                        Variant3.Enabled = false;
                        Variant4.Enabled = false;
                        Refresh();
                    }

                    if (DataBank.Gold < 100)
                    {
                        Variant2.Enabled = false;
                        Variant3.Enabled = false;
                        Variant4.Enabled = false;
                        Refresh();
                    }

                    if (DataBank.Gold < 200)
                    {
                        Variant3.Enabled = false;
                        Variant4.Enabled = false;
                        Refresh();
                    }

                    if (DataBank.Gold < 500)
                    {
                        Variant4.Enabled = false;
                        Refresh();
                    }

                    this.Refresh();
                }
            }

            else if (DataBank.ScreenNumber == 10)
            {

                label1.Text = DataBank.ScreenNumber.ToString();
                Refresh();

                if ((ButtonNumber == 1) || (ButtonNumber == 2) || (ButtonNumber == 3) || (ButtonNumber == 4))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 2;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                    this.Refresh();

                    if (DataBank.Gold < 70)
                    {
                        Variant2.Enabled = false;
                        Variant3.Enabled = false;
                        Variant4.Enabled = false;
                        Refresh();
                    }
                }



            }

            else if (DataBank.ScreenNumber == 11)
            {
                label1.Text = DataBank.ScreenNumber.ToString();
                Refresh();

                //if (DataBank.Gold < 50){ 
                //    Variant1.Enabled = false;
                //    Variant2.Enabled = false;
                //    Variant3.Enabled = false;
                //    Variant4.Enabled = false;
                //}

                //if ( < 100)
                //{
                //    Variant2.Enabled = false;
                //    Variant3.Enabled = false;
                //    Variant4.Enabled = false;
                //}

                //if (DataBank.Gold < 200)
                //{
                //    Variant3.Enabled = false;
                //    Variant4.Enabled = false;
                //}

                //if (DataBank.Gold < 500)
                //{
                //    Variant4.Enabled = false;
                //}
                Variant1.Enabled = true;
                Variant2.Enabled = true;
                Variant3.Enabled = true;
                Variant4.Enabled = true;

                if ((ButtonNumber == 1))
                {
                    DataBank.WeaponUpgrade = 5;
                    DataBank.Gold = DataBank.Gold - 50;
                    DataBank.ScreenNumber = DataBank.ScreenNumber - 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                    this.Refresh();
                }

                else if ((ButtonNumber == 2))
                {
                    DataBank.WeaponUpgrade = 10;
                    DataBank.Gold = DataBank.Gold - 100;
                    DataBank.ScreenNumber = DataBank.ScreenNumber - 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                    this.Refresh();
                }

                else if ((ButtonNumber == 3))
                {
                    DataBank.WeaponUpgrade = 20;
                    DataBank.Gold = DataBank.Gold - 200;
                    DataBank.ScreenNumber = DataBank.ScreenNumber - 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                    this.Refresh();
                }

                else if ((ButtonNumber == 4))
                {
                    DataBank.WeaponUpgrade = 50;
                    DataBank.Gold = DataBank.Gold - 500;
                    DataBank.ScreenNumber = DataBank.ScreenNumber - 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                    this.Refresh();
                }

            }

            else if (DataBank.ScreenNumber == 12)
            {

                Refresh();

                label1.Text = DataBank.ScreenNumber.ToString();
                Refresh();
                if ((ButtonNumber == 1) && (DataBank.CharacterClass == "Warrior") || (DataBank.CharacterClass == "Thief"))
                {
                    DataBank.HaveCharacteristicRecovery = true;
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                    this.Refresh();
                }

                else if ((ButtonNumber == 1) && !((DataBank.CharacterClass == "Warrior") || (DataBank.CharacterClass == "Thief")))
                {

                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                    this.Refresh();
                }
                else if ((ButtonNumber == 3) && (DataBank.CharacterClass == "Mage"))
                {
                    DataBank.HaveCharacteristicRecovery = true;
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                    this.Refresh();
                }

                else if ((ButtonNumber == 3) && !(DataBank.CharacterClass == "Mage"))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                    this.Refresh();
                }

                else if ((ButtonNumber == 4) && (DataBank.CharacterClass == "Priest"))
                {
                    DataBank.HaveCharacteristicRecovery = true;
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                    this.Refresh();
                }

                else if ((ButtonNumber == 4) && !(DataBank.CharacterClass == "Priest"))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                    this.Refresh();
                }
                else if (ButtonNumber == 2)
                {

                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                    this.Refresh();

                }


                Variant1.Enabled = true;
                Variant2.Enabled = true;
                Variant3.Enabled = true;
                Variant4.Enabled = true;
            }

            else if (DataBank.ScreenNumber == 13)
            {
                label1.Text = DataBank.ScreenNumber.ToString();
                Refresh();

                if ((ButtonNumber == 2) || (ButtonNumber == 3))
                {

                    DataBank.ScreenNumber = DataBank.ScreenNumber + 5;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    DoFight();
                    Refresh();
                    this.Refresh();

                }

                else if ((ButtonNumber == 1) || (ButtonNumber == 4))
                {

                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    DoFight();
                    Refresh();
                    this.Refresh();

                }
            }

            else if (DataBank.ScreenNumber == 14)
            {
                label1.Text = DataBank.ScreenNumber.ToString();
                Refresh();

                if ((ButtonNumber == 3) || (ButtonNumber == 4) && (DataBank.Squad > 4))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 2;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                    this.Refresh();
                }
                else if ((((ButtonNumber == 1) || (ButtonNumber == 2)) || (DataBank.Squad > 4)))
                {

                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    DataBank.ShowScreenInfo();
                    Hide();
                    DeathScreen DeathForm = new DeathScreen();
                    DataBank.DeathForm.DeathhText.Text = DataBank.DeathMessage;
                    DataBank.DeathForm.Show();
                }
            }

            else if (DataBank.ScreenNumber == 16)
            {


                label1.Text = DataBank.ScreenNumber.ToString();
                Refresh();

                if ((ButtonNumber == 2) || (ButtonNumber == 3))
                {

                    DataBank.ScreenNumber = DataBank.ScreenNumber + 2;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    DoFight();
                    Refresh();
                    this.Refresh();

                }

                else if ((ButtonNumber == 1) || (ButtonNumber == 4))
                {

                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    DataBank.ShowScreenInfo();
                    Hide();
                    DeathScreen DeathForm = new DeathScreen();
                    DataBank.DeathForm.DeathhText.Text = DataBank.DeathMessage;
                    DataBank.DeathForm.Show();
                }
            }


            else if (DataBank.ScreenNumber == 18)
            {
                label1.Text = DataBank.ScreenNumber.ToString();
                this.Refresh();
                if ((ButtonNumber == 3 || ButtonNumber == 4) && (DataBank.Squad == 5 || DataBank.Squad == 6))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 2;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    DoFight();
                    Refresh();
                    this.Refresh();
                }
                else if (!((ButtonNumber == 3 || ButtonNumber == 4) && (DataBank.Squad == 5 || DataBank.Squad == 6)))
                {

                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    DataBank.ShowScreenInfo();
                    Hide();
                    DeathScreen DeathForm = new DeathScreen();
                    DataBank.DeathForm.DeathhText.Text = DataBank.DeathMessage;
                    DataBank.DeathForm.Show();
                }


            }

            else if (DataBank.ScreenNumber == 20)
            {

                if (((ButtonNumber == 3) || (ButtonNumber == 4)) && (DataBank.Squad == 5) && (DataBank.HaveCharacteristicRecovery == true) && (DataBank.WeaponUpgrade > 10) && ((DataBank.CharacterClass == "Thief") || (DataBank.CharacterClass == "Warrior")))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 4;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    Hide();
                    SuccessScreen SuccForm = new SuccessScreen();
                    DataBank.SuccForm.SuccesssMessage.Text = DataBank.SuccessMessage;
                    DataBank.SuccForm.Show();
                    this.Refresh();



                }

                else if (((ButtonNumber == 3) || (ButtonNumber == 4)) && (DataBank.Squad == 6) && (DataBank.HaveCharacteristicRecovery == true) && (DataBank.WeaponUpgrade > 10) && ((DataBank.CharacterClass == "Thief") || (DataBank.CharacterClass == "Warrior")))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 3;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    Hide();
                    DeathScreen DeathForm = new DeathScreen();
                    DataBank.DeathForm.DeathhText.Text = DataBank.DeathMessage;
                    DataBank.DeathForm.Show();
                    this.Refresh();
                }
                else if (((ButtonNumber == 3) || (ButtonNumber == 4)) && ((DataBank.CharacterClass == "Mage") || (DataBank.CharacterClass == "Priest")))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 2;
                    DataBank.ShowScreenInfo();
                    Hide();
                    DeathScreen DeathForm = new DeathScreen();
                    DataBank.DeathForm.DeathhText.Text = DataBank.DeathMessage;
                    DataBank.DeathForm.Show();
                    this.Refresh();
                }
                else
                {

                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    DataBank.ShowScreenInfo();
                    Hide();
                    DeathScreen DeathForm = new DeathScreen();
                    DataBank.DeathForm.DeathhText.Text = DataBank.DeathMessage;
                    DataBank.DeathForm.Show();
                    this.Refresh();
                }



            }


            else if (DataBank.ScreenNumber == 25)
            {
                label1.Text = DataBank.ScreenNumber.ToString();
                this.Refresh();
                if (ButtonNumber == 1)
                {
                    DataBank.Gold = Int32.Parse(Variant1.Text);
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    //DataBank.ScreenNumber = DataBank.ScreenNumber + 2;
                    this.Refresh();
                }



                else if (((ButtonNumber == 2) || (ButtonNumber == 3) || (ButtonNumber == 4)))
                {
                    label1.Text = DataBank.ScreenNumber.ToString();
                    //this.Refresh();
                    if (ButtonNumber == 2)
                        DataBank.Gold = Int32.Parse(Variant2.Text);
                    else if (ButtonNumber == 3)
                        DataBank.Gold = Int32.Parse(Variant3.Text);
                    else if (ButtonNumber == 4)
                        DataBank.Gold = Int32.Parse(Variant4.Text);


                    //ButTwoisPressed = false;
                    //ButThreeisPressed = false;
                    //ButFourisPressed = false;
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 10;

                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    this.Refresh();

                }

            }

            else if (DataBank.ScreenNumber == 26)
            {
                label1.Text = DataBank.ScreenNumber.ToString();
                DataBank.ShowScreenInfo();
                Refresh();

                if (ButtonNumber == 1)
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                }


                else if ((ButtonNumber == 2) || (ButtonNumber == 3))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 5;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                }

                else if (ButtonNumber == 4)
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 3;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                }

            }



            else if (DataBank.ScreenNumber == 27)
            {
                label1.Text = DataBank.ScreenNumber.ToString();
                Refresh();

                if ((ButtonNumber == 1) || (ButtonNumber == 2) || (ButtonNumber == 3))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    Hide();
                    DeathScreen DeathForm = new DeathScreen();
                    DataBank.DeathForm.DeathhText.Text = DataBank.DeathMessage;
                    DeathForm.Refresh();
                    DataBank.DeathForm.Show();
                }


                else if (ButtonNumber == 4)
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 4;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                }

            }

            else if (DataBank.ScreenNumber == 29)
            {
                label1.Text = DataBank.ScreenNumber.ToString();
                Refresh();
                if ((ButtonNumber == 2) || (ButtonNumber == 3) || (ButtonNumber == 4))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    Hide();
                    DeathScreen DeathForm = new DeathScreen();
                    DataBank.DeathForm.DeathhText.Text = DataBank.DeathMessage;
                    DeathForm.Refresh();
                    DataBank.DeathForm.Show();
                }


                else if (ButtonNumber == 1)
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 2;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                }

            }

            else if (DataBank.ScreenNumber == 31)
            {
                label1.Text = DataBank.ScreenNumber.ToString();
                Refresh();
                if ((ButtonNumber == 2) || (ButtonNumber == 3))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 3;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                    Refresh();
                }


                else if (ButtonNumber == 1)
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();

                    QuestionThatPushesTheQuests.Text = "После нескольких часов гребли, вы устали и решили отдохнуть. Внезапно, на вас нападают сирены. Защищайтесь!";
                    DoFight();
                    Refresh();

                }

                else if (ButtonNumber == 4)
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = "Вы просыпаетесь от чудесного пения. На вас нападают сирены. Защищайтесь!";
                    DoFight();
                    Refresh();

                }
            }

            else if (DataBank.ScreenNumber == 32)
            {
                label1.Text = DataBank.ScreenNumber.ToString();
                Refresh();
                if (((ButtonNumber == 1) || (ButtonNumber == 2) || (ButtonNumber == 3) || (ButtonNumber == 4)) && (DataBank.CharacterClass == "Warrior"))
                {
                    Random rnd = new Random();
                    int Chanсe = rnd.Next(0, 100);

                    if (Chanсe < 75)
                    {
                        DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                        label1.Text = DataBank.ScreenNumber.ToString();
                        DataBank.ShowScreenInfo();
                        Hide();
                        DeathScreen DeathForm = new DeathScreen();
                        DataBank.DeathForm.DeathhText.Text = "Ваши действия ничего не могут противопоставить сиренам, они вытаскивают вас из лодки, и тянут на дно. Вы обращены в морскую нечисть.";
                        DeathForm.Refresh();
                        DataBank.DeathForm.Show();
                    }
                    else if (Chanсe >= 75)
                    {
                        DataBank.ScreenNumber = DataBank.ScreenNumber + 6;
                        label1.Text = DataBank.ScreenNumber.ToString();
                        DataBank.ShowScreenInfo();
                        Variant1.Text = " На север";
                        Variant2.Text = " На восток";
                        Variant3.Text = " На запад ";
                        Variant4.Text = " На юг";
                        label1.Text = DataBank.ScreenNumber.ToString();
                        QuestionThatPushesTheQuests.Text = "Вам удаётся отпугнуть сирен. Вы измождённо падаете на дно лодки. Отдохнув, вы принимаетесь грести дальше. Спустя неделю, почти исчерпав все припасы, вы добираетесь до нужного острова. Куда вы пойдёте, после отдыха?";

                    }



                }
                else if ((ButtonNumber == 3) || (ButtonNumber == 4) && (DataBank.CharacterClass == "Thief"))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 3;
                    Variant1.Text = " На север";
                    Variant2.Text = " На восток";
                    Variant3.Text = " На запад ";
                    Variant4.Text = " На юг";
                    label1.Text = DataBank.ScreenNumber.ToString();
                    QuestionThatPushesTheQuests.Text = "Ваши кинжалы попадают в жизненно важные места, и заставляют сирен отступить. Вы измождённо падаете на дно лодки. Отдохнув, вы принимаетесь грести дальше. Спустя неделю, почти исчерпав все припасы, вы добираетесь до нужного острова. Куда вы пойдёте, после отдыха?";
                }
                else if (((ButtonNumber == 1) || (ButtonNumber == 2)) && (DataBank.CharacterClass == "Thief"))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    Hide();
                    DeathScreen DeathForm = new DeathScreen();
                    DataBank.DeathForm.DeathhText.Text = "Ваши действия ничего не могут противопоставить сиренам, они вытаскивают вас из лодки, и тянут на дно. Вы обращены в морскую нечисть.";
                    DeathForm.Refresh();
                    DataBank.DeathForm.Show();
                }
                else if ((ButtonNumber == 1) || (ButtonNumber == 2) || (ButtonNumber == 3) || (ButtonNumber == 4) && (DataBank.CharacterClass == "Mage"))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 6;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    Variant1.Text = " На север";
                    Variant2.Text = " На восток";
                    Variant3.Text = " На запад ";
                    Variant4.Text = " На юг";
                    QuestionThatPushesTheQuests.Text = "Ваши заклинания отпугивают и ранят сирен, и оно отступают. Вы измождённо падаете на дно лодки. Отдохнув, вы принимаетесь грести дальше. Спустя неделю, почти исчерпав все припасы, вы добираетесь до нужного острова. Куда вы пойдёте, после отдыха?";
                    Refresh();
                }

                else if ((ButtonNumber == 1) || (ButtonNumber == 4) && (DataBank.CharacterClass == "Priest"))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 6;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    Variant1.Text = " На север";
                    Variant2.Text = " На восток";
                    Variant3.Text = " На запад ";
                    Variant4.Text = " На юг";
                    QuestionThatPushesTheQuests.Text = "Ваши заклинания отпугивают и ранят сирен, и оно отступают. Вы измождённо падаете на дно лодки. Отдохнув, вы принимаетесь грести дальше. Спустя неделю, почти исчерпав все припасы, вы добираетесь до нужного острова. Куда вы пойдёте, после отдыха?";
                }

                else if (((ButtonNumber == 2) || (ButtonNumber == 3)) && (DataBank.CharacterClass == "Priest"))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    Hide();
                    DeathScreen DeathForm = new DeathScreen();
                    DataBank.DeathForm.DeathhText.Text = "Ваши действия ничего не могут противопоставить сиренам, они вытаскивают вас из лодки, и тянут на дно. Вы обращены в морскую нечисть.";
                    DeathForm.Refresh();
                    DataBank.DeathForm.Show();
                }
            }


            else if (DataBank.ScreenNumber == 34)
            {
                label1.Text = DataBank.ScreenNumber.ToString();
                Refresh();
                if (ButtonNumber == 1)
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 3;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    Hide();
                    DeathScreen DeathForm = new DeathScreen();
                    DataBank.DeathForm.DeathhText.Text = "Палуба блестит от вашей работы. Вы слышите шум и видите, что на корабль напало морское чудовище. Оно обхватило корабль, и не даёт сдвинуться дальше. Несмотря на ваши действия, которые ранят чудовище, пушки не подготовлены к выстрелам, и не могут добить чудовище.  Оно хватает вас, ломает хребет и выбрасывает за борт. ";
                    DeathForm.Refresh();
                    DataBank.DeathForm.Show();
                }
                else if (ButtonNumber == 2)
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 2;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DoFight();
                    QuestionThatPushesTheQuests.Text = "Вы начистили пушки и подготовили ядра. Вы слышите шум, поднимаетесь на палубу и видите, что на корабль напало морское чудовище. Оно обхватило корабль, и не даёт сдвинуться дальше. Боритесь за свою жизнь!";

                    Refresh();
                }
                else if (ButtonNumber == 3)
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 3;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    Hide();
                    DeathScreen DeathForm = new DeathScreen();
                    DataBank.DeathForm.DeathhText.Text = "Вы успешно перенесли вещи с несколькими матросами. Вы слышите шум, поднимаетесь на палубу и видите, что на корабль напало морское чудовище. Оно обхватило корабль, и не даёт сдвинуться дальше. Несмотря на ваши действия, которые ранят чудовище, пушки не подготовлены к выстрелам, и не могут добить чудовище.  Оно хватает вас, ломает хребет и выбрасывает за борт. ";
                    DeathForm.Refresh();
                    DataBank.DeathForm.Show();
                }

                //Паруса в отличном состоянии.
                else if (ButtonNumber == 4)
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 3;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    Hide();
                    DeathScreen DeathForm = new DeathScreen();
                    DataBank.DeathForm.DeathhText.Text = "Вы подготовили запасные паруса. Вы слышите шум, поднимаетесь на палубу и видите, что на корабль напало морское чудовище. Оно обхватило корабль, и не даёт сдвинуться дальше. Несмотря на ваши действия, которые ранят чудовище, пушки не подготовлены к выстрелам, и не могут добить чудовище.  Оно хватает вас, ломает хребет и выбрасывает за борт. ";
                    DeathForm.Refresh();
                    DataBank.DeathForm.Show();
                }
                //Вы не находите в маршруте ошибок.
            }

            //if (DataBank.ScreenNumber == 29)
            //{

            //    if ((ButtonNumber == 2) || (ButtonNumber == 3) || (ButtonNumber == 4))
            //    {
            //        DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
            //        DataBank.ShowScreenInfo();
            //        Hide();
            //        DeathScreen DeathForm = new DeathScreen();
            //        DataBank.DeathForm.DeathhText.Text = DataBank.DeathMessage;
            //        DataBank.DeathForm.Show();
            //    }

            //}



            else if (DataBank.ScreenNumber == 35)
            {
                label1.Text = DataBank.ScreenNumber.ToString();
                Refresh();
                if (ButtonNumber == 1)
                {
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;

                    DoFight();
                    QuestionThatPushesTheQuests.Text = "Пушки не были готовы. Вы сказали об этом матросам, и они начистили их и подготовили ядра. Вы слышите шум, поднимаетесь на палубу и видите, что на корабль напало морское чудовище. Оно обхватило корабль, и не даёт сдвинуться дальше. Боритесь за свою жизнь!";
                    Refresh();
                }
                else if (ButtonNumber == 2)
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 2;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    Hide();
                    DeathScreen DeathForm = new DeathScreen();
                    DataBank.DeathForm.DeathhText.Text = "Паруса в отличном состоянии. Вы слышите шум, поднимаетесь на палубу и видите, что на корабль напало морское чудовище. Оно обхватило корабль, и не даёт сдвинуться дальше. Несмотря на ваши действия, которые ранят чудовище, пушки не подготовлены к выстрелам, и не могут добить чудовище.  Оно хватает вас, ломает хребет и выбрасывает за борт. ";
                    DeathForm.Refresh();
                    DataBank.DeathForm.Show();
                }
                else if (ButtonNumber == 3)
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 3;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    Hide();
                    DeathScreen DeathForm = new DeathScreen();
                    DataBank.DeathForm.DeathhText.Text = "Вы не находите в маршруте ошибок. Вы слышите шум, поднимаетесь на палубу и видите, что на корабль напало морское чудовище. Оно обхватило корабль, и не даёт сдвинуться дальше. Несмотря на ваши действия, которые ранят чудовище, пушки не подготовлены к выстрелам, и не могут добить чудовище.  Оно хватает вас, ломает хребет и выбрасывает за борт. ";
                    Refresh();
                    DeathForm.Refresh();
                    DataBank.DeathForm.Show();
                }

                //Паруса в отличном состоянии.
                else if (ButtonNumber == 4)
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 3;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    Hide();
                    DeathScreen DeathForm = new DeathScreen();
                    DataBank.DeathForm.DeathhText.Text = "Вы просыпаетесь от страшного шума, выбегаете на палубу и видите, что на корабль напало морское чудовище. Оно обхватило корабль, и не даёт сдвинуться дальше. Несмотря на ваши действия, которые ранят чудовище, пушки не подготовлены к выстрелам, и не могут добить чудовище.  Оно хватает вас, ломает хребет и выбрасывает за борт. ";
                    DeathForm.Refresh();
                    DataBank.DeathForm.Show();
                }
            }

            else if (DataBank.ScreenNumber == 36)
            {
                if (((ButtonNumber == 1) || (ButtonNumber == 2) || (ButtonNumber == 3) || (ButtonNumber == 4)) && (DataBank.CharacterClass == "Warrior"))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    DataBank.ShowScreenInfo();
                    Hide();
                    DeathScreen DeathForm = new DeathScreen();
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.DeathForm.DeathhText.Text = "Ваши действия ничего не могут противопоставить морскому чудовищу, оно хватает вас, ломает хребет и выбрасывает за борт.";
                    DeathForm.Refresh();
                    DataBank.DeathForm.Show();
                }
                else if ((ButtonNumber == 3) || (ButtonNumber == 4) && (DataBank.CharacterClass == "Thief"))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 2;
                    Variant1.Text = " На север";
                    Variant2.Text = " На восток";
                    Variant3.Text = " На запад ";
                    Variant4.Text = " На юг";
                    label1.Text = DataBank.ScreenNumber.ToString();
                    QuestionThatPushesTheQuests.Text = "Ваши кинжалы попадают в жизненно важные места, и заставляют чудовище замереть. Пушки ранят его, и оно отступает. Совместными усилиями команды корабль починен, и вы движетесь к нужному острову. Прибыв, вы успешно высаживаетесь, и готовитесь двигаться. Куда вы пойдёте?";
                }
                else if (((ButtonNumber == 1) || (ButtonNumber == 2)) && (DataBank.CharacterClass == "Thief"))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    DataBank.ShowScreenInfo();
                    Hide();
                    DeathScreen DeathForm = new DeathScreen();
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.DeathForm.DeathhText.Text = "Ваши действия ничего не могут противопоставить морскому чудовищу, оно хватает вас, ломает хребет и выбрасывает за борт.";
                    DeathForm.Refresh();
                    DataBank.DeathForm.Show();
                }
                else if ((ButtonNumber == 1) || (ButtonNumber == 2) || (ButtonNumber == 3) || (ButtonNumber == 4) && (DataBank.CharacterClass == "Mage"))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 2;
                    Variant1.Text = " На север";
                    Variant2.Text = " На восток";
                    Variant3.Text = " На запад ";
                    Variant4.Text = " На юг";
                    label1.Text = DataBank.ScreenNumber.ToString();
                    QuestionThatPushesTheQuests.Text = "Ваши заклинания попадают в жизненно важные места, и заставляют чудовище замереть. Пушки ранят его, и оно отступает. Совместными усилиями команды корабль починен, и вы движетесь к нужному острову. Прибыв, вы успешно высаживаетесь, и готовитесь двигаться. Куда вы пойдёте?";
                }

                else if ((ButtonNumber == 1) || (ButtonNumber == 4) && (DataBank.CharacterClass == "Priest"))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 2;
                    Variant1.Text = " На север";
                    Variant2.Text = " На восток";
                    Variant3.Text = " На запад ";
                    Variant4.Text = " На юг";
                    label1.Text = DataBank.ScreenNumber.ToString();
                    QuestionThatPushesTheQuests.Text = "Ваши заклинания попадают в жизненно важные места, и заставляют чудовище замереть. Пушки ранят его, и оно отступает. Совместными усилиями команды корабль починен, и вы движетесь к нужному острову. Прибыв, вы успешно высаживаетесь, и готовитесь двигаться. Куда вы пойдёте?";
                }

                else if (((ButtonNumber == 2) || (ButtonNumber == 3)) && (DataBank.CharacterClass == "Priest"))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    Hide();
                    DeathScreen DeathForm = new DeathScreen();
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.DeathForm.DeathhText.Text = "Ваши действия ничего не могут противопоставить морскому чудовищу, оно хватает вас, ломает хребет и выбрасывает за борт.";
                    DeathForm.Refresh();
                    DataBank.DeathForm.Show();
                }

            }

            else if (DataBank.ScreenNumber == 38)
            {
                if ((ButtonNumber == 1) || (ButtonNumber == 2) || (ButtonNumber == 3) || (ButtonNumber == 4))
                {

                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    Refresh();



                    if (DataBank.CharacterClass == "Warrior")
                    {
                        Variant1.Text = DataBank.TextButtonVariant1;
                        Variant2.Visible = false;
                        Variant3.Visible = false;
                        Variant4.Visible = false;
                        Refresh();
                    }

                    else if (DataBank.CharacterClass == "Thief")
                    {
                        Variant1.Text = DataBank.TextButtonVariant1;
                        Variant2.Visible = false;
                        Variant3.Visible = false;
                        Variant4.Visible = false;

                    }

                    else if (DataBank.CharacterClass == "Mage")
                    {
                        Variant1.Text = DataBank.TextButtonVariant1;
                        Variant2.Text = DataBank.TextButtonVariant2;
                        Variant3.Visible = false;
                        Variant4.Visible = false;
                        Refresh();

                    }


                    else if (DataBank.CharacterClass == "Priest")
                    {
                        Variant1.Text = DataBank.TextButtonVariant1;
                        Variant2.Text = DataBank.TextButtonVariant2;
                        Variant3.Visible = false;
                        Variant4.Visible = false;
                        Refresh();
                    }


                }

            }

            else if (DataBank.ScreenNumber == 39)
            {

                label1.Text = DataBank.ScreenNumber.ToString();

                if (DataBank.CharacterClass == "Warrior")
                {
                    if (ButtonNumber == 1)
                    {
                        Hide();


                        DeathScreen DeathForm = new DeathScreen();
                        DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                        label1.Text = DataBank.ScreenNumber.ToString();
                        DataBank.DeathForm.DeathhText.Text = "Вы шли до тех пор, пока окончательно не исчерпали все свои силы. Упав на землю, вы потеряли сознание. Пустыня поглотила вас. Ваша цель так и не была достигнута, и лишь моряки будут вспоминать то, как вы спасли их.";
                        DataBank.DeathForm.Show();
                        Variant2.Visible = true;
                        Variant3.Visible = true;
                        Variant4.Visible = true;
                    }
                }

                else if (DataBank.CharacterClass == "Thief")
                {

                    if (ButtonNumber == 1)
                    {
                        DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                        label1.Text = DataBank.ScreenNumber.ToString();
                        //label1.Text = DataBank.ScreenNumber.ToString();
                        QuestionThatPushesTheQuests.Text = "Вы шли до тех, пока не увидели гигансткого скорпиона. Заметив вас, он щёлкает клешнями, и идёт в вашу сторону. Сражайтесь!";
                        Variant2.Visible = true;
                        Variant3.Visible = true;
                        Variant4.Visible = true;
                        DoFight();
                        Refresh();
                    }
                }

                else if (DataBank.CharacterClass == "Mage")
                {

                    if (ButtonNumber == 1)
                    {
                        QuestionThatPushesTheQuests.Text = "Вы шли до тех, пока не увидели гигансткого скорпиона. Заметив вас, он щёлкает клешнями, и идёт в вашу сторону. Сражайтесь!";
                        Refresh();
                        DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                        label1.Text = DataBank.ScreenNumber.ToString();
                        Variant2.Visible = true;
                        Variant3.Visible = true;
                        Variant4.Visible = true;
                        DoFight();
                        Refresh();
                    }

                    else if (ButtonNumber == 2)
                    {
                        QuestionThatPushesTheQuests.Text = "Вы применили заклинание поиска, оно указало вам путь. Вы шли до тех, пока не увидели гигансткого скорпиона. Заметив вас, он щёлкает клешнями, и идёт в вашу сторону. Сражайтесь!";
                        Refresh();
                        DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                        label1.Text = DataBank.ScreenNumber.ToString();
                        Variant2.Visible = true;
                        Variant3.Visible = true;
                        Variant4.Visible = true;

                        DoFight();
                        Refresh();
                    }
                }


                else if (DataBank.CharacterClass == "Priest")
                {
                    if (ButtonNumber == 1)
                    {
                        DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                        QuestionThatPushesTheQuests.Text = "Вы шли до тех, пока не увидели гигансткого скорпиона. Заметив вас, он щёлкает клешнями, и идёт в вашу сторону. Сражайтесь!";
                        Refresh();
                        label1.Text = DataBank.ScreenNumber.ToString();
                        Refresh();
                        Variant2.Visible = true;
                        Variant3.Visible = true;
                        Variant4.Visible = true;
                        DoFight();
                        Refresh();
                    }

                    else if (ButtonNumber == 2)
                    {
                        DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                        label1.Text = DataBank.ScreenNumber.ToString();
                        QuestionThatPushesTheQuests.Text = "Вы обратились с молитвой к богам, и они указали вам правильный путь. Вы шли до тех, пока не увидели гигансткого скорпиона. Заметив вас, он щёлкает клешнями, и идёт в вашу сторону. Сражайтесь!";
                        Refresh();
                        Variant2.Visible = true;
                        Variant3.Visible = true;
                        Variant4.Visible = true;
                        DoFight();
                        Refresh();
                    }

                }
            }


            else if (DataBank.ScreenNumber == 40)
            {
                if ((ButtonNumber == 1) || (ButtonNumber == 2))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DeathScreen DeathForm = new DeathScreen();
                    DataBank.DeathForm.DeathhText.Text = "Несмотря на ваши атаки, вы не можете пробить броню скорпиона. Он сдавливает вас, и насквозь пронзает своим жалом. Вы умираете от потери крови. ";
                    DeathForm.Refresh();
                    DataBank.DeathForm.Show();
                }

                else if ((ButtonNumber == 3) || (ButtonNumber == 4))
                {
                    QuestionThatPushesTheQuests.Text = " Вы успешно побеждаете скорпиона, и отрываете его жало. Пройдя ещё какое-то расстояние, вы наконец находите лагерь орков. Вы требуете испытания поединком, и падаете перед воротами. Вас заносят внутрь. Вам предлагают восстановиться перед боем. Как вы будете это делать?";
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 2;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    Refresh();
                }

            }


            else if (DataBank.ScreenNumber == 42)
            {
                if ((ButtonNumber == 1) || (ButtonNumber == 2) || (ButtonNumber == 3) || (ButtonNumber == 4))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    QuestionThatPushesTheQuests.Text = "После отдыха вы вышли на арену, готовый к бою. Орки скандировали свои боевые кличи, и их вождь поднял топор над головой. Блики солнца играли на его лезвии. Прозвучал удар гонга. К бою!";
                    DoFight();
                    Refresh();
                }
            }



            else if (DataBank.ScreenNumber == 43)
            {
                if ((ButtonNumber == 2) && (DataBank.CharacterClass == "Thief"))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    QuestionThatPushesTheQuests.Text = "Вы ослепили вождя орков, успешно дезориентировав его, как вы атакуете дальше?";
                    Refresh();
                }
                else if ((ButtonNumber == 4) && (DataBank.CharacterClass == "Mage"))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    QuestionThatPushesTheQuests.Text = "Вы успешно замедлили вождя орков, как вы атакуете дальше?";
                    Refresh();
                }
                else if ((ButtonNumber == 4) && (DataBank.CharacterClass == "Priest"))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    QuestionThatPushesTheQuests.Text = "Вы ослепили вождя орков, посредством атаки порождения света, как вы атакуете дальше?";
                    Refresh();
                }

                else
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 4;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DeathScreen DeathForm = new DeathScreen();
                    DataBank.DeathForm.DeathhText.Text = "Ваши атаки только злят вождя орков. Он подбегает, хватает вас, и ломаёт рёбра мощными ударами. Затем, ударом топора он срубает вашу голову. Вы мертвы.";
                    DeathForm.Refresh();
                    DataBank.DeathForm.Show();
                }
            }
            else if (DataBank.ScreenNumber == 44)
            {
                if ((ButtonNumber == 3) && (DataBank.CharacterClass == "Thief"))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    QuestionThatPushesTheQuests.Text = "Ваши кинжалы успешно вошли в конечности вождя орков, как вы атакуете дальше?";
                    Refresh();
                }
                else if ((ButtonNumber == 3) && (DataBank.CharacterClass == "Mage"))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    QuestionThatPushesTheQuests.Text = "Вы успешно вонзили ледяную стрелу в вождя орков, как вы атакуете дальше?";
                    Refresh();
                }
                else if ((ButtonNumber == 2) && (DataBank.CharacterClass == "Priest"))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    QuestionThatPushesTheQuests.Text = "Вы расплавили броню вождя когда он попытался подойди, как вы атакуете дальше?";
                    Refresh();
                }

                else
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 3;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DeathScreen DeathForm = new DeathScreen();
                    DataBank.DeathForm.DeathhText.Text = "Ваши атаки только злят вождя орков. Он подбегает, хватает вас, и ломаёт рёбра мощными ударами. Затем, ударом топора он срубает вашу голову. Вы мертвы.";
                    DeathForm.Refresh();
                    DataBank.DeathForm.Show();
                }
            }


            else if (DataBank.ScreenNumber == 45)
            {
                if ((ButtonNumber == 4) && (DataBank.CharacterClass == "Thief"))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    QuestionThatPushesTheQuests.Text = "Ваши, отравленные клинки парализовали вождя орков, как вы атакуете дальше?";
                    Refresh();
                }
                else if ((ButtonNumber == 1) && (DataBank.CharacterClass == "Mage"))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    QuestionThatPushesTheQuests.Text = "Вы успешно расплавили броню вождя орков и опалили его, как вы атакуете дальше?";
                    Refresh();
                }
                else if ((ButtonNumber == 1) && (DataBank.CharacterClass == "Priest"))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    QuestionThatPushesTheQuests.Text = "Вы обожгли вождя, как вы атакуете дальше?";
                    Refresh();
                }

                else
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 2;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DeathScreen DeathForm = new DeathScreen();
                    DataBank.DeathForm.DeathhText.Text = "Ваши атаки только злят вождя орков. Он подбегает, хватает вас, и ломаёт рёбра мощными ударами. Затем, ударом топора он срубает вашу голову. Вы мертвы.";
                    DeathForm.Refresh();
                    DataBank.DeathForm.Show();
                }
            }

            else if (DataBank.ScreenNumber == 46)
            {
                if ((ButtonNumber == 1) && (DataBank.CharacterClass == "Thief"))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 2;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    Hide();
                    SuccessScreen SuccForm = new SuccessScreen();
                    DataBank.SuccForm.SuccesssMessage.Text = DataBank.SuccessMessage;
                    DataBank.SuccForm.Show();
                    this.Refresh();
                }
                else if ((ButtonNumber == 2) && (DataBank.CharacterClass == "Mage"))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 2;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    Hide();
                    SuccessScreen SuccForm = new SuccessScreen();
                    DataBank.SuccForm.SuccesssMessage.Text = DataBank.SuccessMessage;
                    DataBank.SuccForm.Show();
                    this.Refresh();
                }
                else if ((ButtonNumber == 3) && (DataBank.CharacterClass == "Priest"))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 2;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    Hide();
                    SuccessScreen SuccForm = new SuccessScreen();
                    DataBank.SuccForm.SuccesssMessage.Text = DataBank.SuccessMessage;
                    DataBank.SuccForm.Show();
                    this.Refresh();
                }

                else
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 3;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DeathScreen DeathForm = new DeathScreen();
                    DataBank.DeathForm.DeathhText.Text = DataBank.DeathMessage;
                    DeathForm.Refresh();
                    DataBank.DeathForm.Show();
                }
            }


            else if (DataBank.ScreenNumber == 49)
            {
                label1.Text = DataBank.ScreenNumber.ToString();
                this.Refresh();
                if (ButtonNumber == 1)
                {
                    DataBank.Gold = Int32.Parse(Variant1.Text);
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 2;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    this.Refresh();
                    DataBank.ShowScreenInfo();

                    QuestionThatPushesTheQuests.Text = "Вы не знали дорог, ведущих на север, и решили нанять провожатого за 300 монет, на охрану и лошадей вам не хватает монет. Вы вышли за пределы города и направляетесь на север. Пока что тропа пролегает сквозь густой лиственный лес. Спустя несколько часов начинает смеркаться. Вы хотите остановиться и сделать привал или же продолжить свой путь?";
                    DataBank.Gold = DataBank.Gold - 300;
                    Variant1.Text = "Продолжить идти";
                    Variant2.Text = "Сделать привал на краю дороги";
                    Variant3.Text = "Уйти с дороги в лес и сделать привал там";
                    Variant4.Visible = false;

                    label1.Text = DataBank.ScreenNumber.ToString();
                    //DataBank.ScreenNumber = DataBank.ScreenNumber + 2;
                    this.Refresh();
                }



                else if (((ButtonNumber == 2) || (ButtonNumber == 3) || (ButtonNumber == 4)))
                {
                    label1.Text = DataBank.ScreenNumber.ToString();
                    //this.Refresh();
                    if (ButtonNumber == 2)
                        DataBank.Gold = Int32.Parse(Variant2.Text);
                    else if (ButtonNumber == 3)
                        DataBank.Gold = Int32.Parse(Variant3.Text);
                    else if (ButtonNumber == 4)
                        DataBank.Gold = Int32.Parse(Variant4.Text);


                    //ButTwoisPressed = false;
                    //ButThreeisPressed = false;
                    //ButFourisPressed = false;
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    DataBank.Gold = DataBank.Gold - 300;
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = "Вы не знали дорог, ведущих к пустошам, и решили нанять провожатого за 300 монет, у вас еще остались монеты, и вы решаете взять ли вам охрану и лошадей.";
                    Variant1.Text = "Взять только охрану(500 монет)";
                    Variant2.Text = "Взять только лошадей(500 монет)";
                    Variant3.Text = "Взять и охрану, и лошадей(1000 монет)";
                    Variant4.Text = "Не брать ни то, ни другое";
                    label1.Text = DataBank.ScreenNumber.ToString();
                    this.Refresh();

                    if (DataBank.Gold < 500)
                    {
                        Variant1.Enabled = false;
                        Variant2.Enabled = false;
                        Variant3.Enabled = false;

                    }

                    else if (DataBank.Gold < 1000)
                    {

                        Variant3.Enabled = false;
                    }
                }

            }

            else if (DataBank.ScreenNumber == 50)
            {

                Variant1.Enabled = true;
                Variant2.Enabled = true;
                Variant3.Enabled = true;

                label1.Text = DataBank.ScreenNumber.ToString();

                if (ButtonNumber == 1)
                {

                    DataBank.HaveGuard = true;
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = "Вы вышли за пределы города и направляетесь на север. Пока что тропа пролегает сквозь густой лиственный лес. Спустя несколько часов начинает смеркаться. Вы хотите остановиться и сделать привал или же продолжить свой путь?";
                    Variant1.Text = "Продолжить идти";
                    Variant2.Text = "Сделать привал на краю дороги";
                    Variant3.Text = "Уйти с дороги в лес и сделать привал там";
                    Variant4.Visible = false;
                    this.Refresh();
                }
                else if (ButtonNumber == 2)
                {

                    DataBank.HaveHorse = true;
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = "Вы вышли за пределы города и направляетесь на север. Пока что тропа пролегает сквозь густой лиственный лес. Спустя несколько часов начинает смеркаться. Вы хотите остановиться и сделать привал или же продолжить свой путь?";
                    Variant1.Text = "Продолжить идти";
                    Variant2.Text = "Сделать привал на краю дороги";
                    Variant3.Text = "Уйти с дороги в лес и сделать привал там";
                    Variant4.Visible = false;
                    this.Refresh();

                }

                else if (ButtonNumber == 3)
                {

                    DataBank.HaveGuard = true;
                    DataBank.HaveHorse = true;
                    DataBank.Gold = DataBank.Gold - 1000;
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = "Вы вышли за пределы города и направляетесь на север. Пока что тропа пролегает сквозь густой лиственный лес. Спустя несколько часов начинает смеркаться. Вы хотите остановиться и сделать привал или же продолжить свой путь?";
                    Variant1.Text = "Продолжить идти";
                    Variant2.Text = "Сделать привал на краю дороги";
                    Variant3.Text = "Уйти с дороги в лес и сделать привал там";
                    Variant4.Visible = false;
                    this.Refresh();
                }
                else if (ButtonNumber == 4)
                {


                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = "Вы вышли за пределы города и направляетесь на север. Пока что тропа пролегает сквозь густой лиственный лес. Спустя несколько часов начинает смеркаться. Вы хотите остановиться и сделать привал или же продолжить свой путь?";
                    Variant1.Text = "Продолжить идти";
                    Variant2.Text = "Сделать привал на краю дороги";
                    Variant3.Text = "Уйти с дороги в лес и сделать привал там";
                    Variant4.Visible = false;
                    this.Refresh();
                }

            }

            else if (DataBank.ScreenNumber == 51)
            {
                if (ButtonNumber == 1)
                {


                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = "Становится все темнее и темнее, вы уже плохо различаете тропу, видя лишь ее очертания.Вам кажется, что впереди развилка. Куда вы повернете?";
                    Variant1.Text = "Пойти прямо";
                    Variant2.Text = "Пойти направо";
                    Variant3.Text = "Пойти налево";

                    this.Refresh();
                }
                else if (ButtonNumber == 2)
                {

                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();

                    label1.Text = DataBank.ScreenNumber.ToString();
                    DeathScreen DeathForm = new DeathScreen();
                    DataBank.DeathForm.DeathhText.Text = DataBank.DeathMessage;
                    DeathForm.Refresh();
                    DataBank.DeathForm.Show();
                    DataBank.DeathForm.DeathhText.Text = "Вы разложили припасы и развели костер, ночь была холодной. Поужинав и согревшись, вы потушили костер и легли спать. Пусть свет от огня уже погас, пока вы готовили он успел привлечь бандитов. Вас зарезали во сне и украли все припасы.";

                    this.Refresh();

                }

                else if (ButtonNumber == 3)
                {

                    DataBank.ScreenNumber = DataBank.ScreenNumber + 2;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = "Вы сошли с дороги и пробрались поглубже в лес, здесь густые кроны деревьев и множество кустарников надежно защищали вас от посторонних глаз. Поужинав и согревшись у костра, вы легли спать. Следующим утром вы продолжили свой путь. Дойдя до развилки, вы увидели указатель в сторону деревни и решили пойти туда, возможно жители этой деревни знаю что-то о перчатках. Дойдя до домов, вы думаете куда пойти в начале.";
                    Variant1.Text = "В самый большой дом";
                    Variant2.Text = "В ближайший к лесу дом";
                    Variant3.Text = "В дом, наполовину сделанный из камня";
                    Variant4.Visible = true;
                    Variant4.Text = "Пойти дальше по тропе";

                    this.Refresh();
                }
            }


            else if (DataBank.ScreenNumber == 52)
            {
                if (ButtonNumber == 1)
                {


                    //DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    Hide();
                    DeathScreen DeathForm = new DeathScreen();
                    DataBank.DeathForm.DeathhText.Text = "Из-за темноты вам показалось, что впереди есть продолжение тропы, но там был овраг. Вы умираете, упав в него, и напоровшись на корягу.";
                    DeathForm.Refresh();
                    DataBank.DeathForm.Show();



                    this.Refresh();
                }
                else if (ButtonNumber == 2)
                {


                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = "Повернув направо, вы продолжаете свой путь. Вскоре деревья расступаются и в свете луны вы видите небольшую деревню, состоящую всего из пары домов. Вы доходите до одного из них и засыпаете прямо у порога. ";
                    Variant1.Text = "В самый большой дом";
                    Variant2.Text = "В ближайший к лесу дом";
                    Variant3.Text = "В дом, наполовину сделанный из камня";
                    Variant4.Visible = true;
                    Variant4.Text = "Пойти дальше по тропе";
                    this.Refresh();

                }

                else if (ButtonNumber == 3)
                {

                    DataBank.ScreenNumber = DataBank.ScreenNumber + 2;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = "Повернув налево, вы продолжаете свой путь.  Деревья окружают вас плотной стеной, создавая монотонный гул шороха листьев. Вдруг, вы различаете в этом гуле какой-то новый звук, и, внимательно присмотревшись, различаете человеческие силуэты в том месте, откуда раздался этот звук. Что вы будете делать?";
                    Variant1.Text = "Приготовитесь драться";
                    Variant2.Text = "Пустите коней галопом ";
                    Variant3.Text = "Попытаетесь поговорить с незнакомцами";
                    Variant4.Visible = true;
                    Variant4.Text = "Пойдете дальше, не обращая внимания на силуэты";

                    this.Refresh();
                }
            }

            else if (DataBank.ScreenNumber == 54)
            {
                if (ButtonNumber == 1)
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 2;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    this.Refresh();
                    QuestionThatPushesTheQuests.Text = "Вы приготовились к бою и это решение оказалось верным. Из тени деревьев вышла группа людей, в их руках сверкали ножи. Бандиты без лишних слов напали на вас. Что вы будете делать?";
                    Variant1.Text = "Помолиться ";
                    Variant2.Text = "Создать заклинание";
                    Variant3.Text = "Замахнуться топором";
                    Variant4.Visible = true;
                    Variant4.Text = "Достать клинок ";
                    Refresh();

                    if (DataBank.CharacterClass == "Priest")
                    {

                        Variant2.Visible = false;
                        Variant3.Visible = false;
                        Variant4.Visible = false;
                        Variant2.Enabled = false;
                        Variant3.Enabled = false;
                        Variant4.Enabled = false;
                    }
                    else if (DataBank.CharacterClass == "Mage")
                    {

                        Variant1.Visible = false;
                        Variant3.Visible = false;
                        Variant4.Visible = false;
                        Variant1.Enabled = false;
                        Variant3.Enabled = false;
                        Variant4.Enabled = false;
                    }

                    else if (DataBank.CharacterClass == "Warrior")
                    {

                        Variant1.Visible = false;
                        Variant2.Visible = false;
                        Variant4.Visible = false;
                        Variant1.Enabled = false;
                        Variant2.Enabled = false;
                        Variant4.Enabled = false;
                    }

                    else if (DataBank.CharacterClass == "Thief")
                    {

                        Variant1.Visible = false;
                        Variant2.Visible = false;
                        Variant3.Visible = false;
                        Variant1.Enabled = false;
                        Variant2.Enabled = false;
                        Variant3.Enabled = false;
                    }
                }

                else if (ButtonNumber == 2)
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber - 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    this.Refresh();
                    QuestionThatPushesTheQuests.Text = "Решив не узнавать, что он вас хотят незнакомцы, вы пришпорили коней и скоро выехали из леса к небольшой деревне. Все устали после такой долгой дороги, так что вы устроили привал рядом с одним из домов. Проснувшись следующим утром, вы решаете узнать, что это за место. Возможно люди, живущие здесь знают, где вам искать перчатки. Вы думаете, куда вам пойти в начале.";
                    Variant1.Text = "В самый большой дом";
                    Variant2.Text = "В ближайший к лесу дом";
                    Variant3.Text = "В дом, наполовину сделанный из камня";
                    Variant4.Visible = true;
                    Variant4.Text = "Пойти дальше по тропе";
                    this.Refresh();
                }

                else if ((ButtonNumber == 3) || (ButtonNumber == 4))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    Hide();
                    DeathScreen DeathForm = new DeathScreen();
                    DataBank.DeathForm.DeathhText.Text = "Незнакомцы оказались бандитами, они молча напали на вас. Вы не были готовы к такому и бандитам легко удалось вас одолеть, и вы погибли от их рук.";
                    DeathForm.Refresh();
                    DataBank.DeathForm.Show();
                }


            }

            else if (DataBank.ScreenNumber == 56)
            {

                if ((ButtonNumber == 1) || (ButtonNumber == 2) || (ButtonNumber == 3) || (ButtonNumber == 4))
                {
                    if ((DataBank.HaveHorse == true) && (DataBank.HaveGuard == false))
                    {
                        DataBank.ScreenNumber = DataBank.ScreenNumber - 3;
                        label1.Text = DataBank.ScreenNumber.ToString();
                        this.Refresh();
                        QuestionThatPushesTheQuests.Text = "Вам удалось отбить атаку бандитов, но вы сильно ранены. На лошади вы быстро смогли выбраться из леса к небольшой деревне. Уже начинало светать, и жители выходили из своих домов. К вашей удаче, в этой деревне жила травница, она обработала ваши раны и остановила кровотечение. Вы будете жить, но на восстановление уйдет время, пока что вам нужно поспать.";
                        Variant1.Visible = true;
                        Variant2.Visible = true;
                        Variant3.Visible = true;
                        Variant4.Visible = true;
                        Variant1.Enabled = true;
                        Variant2.Enabled = true;
                        Variant3.Enabled = true;
                        Variant4.Enabled = true;

                        Variant1.Text = "В самый большой дом";
                        Variant2.Text = "В ближайший к лесу дом";
                        Variant3.Text = "В дом, наполовину сделанный из камня";
                        Variant4.Visible = true;
                        Variant4.Text = "Пойти дальше по тропе";

                    }

                    else if (DataBank.HaveGuard == true)
                    {
                        QuestionThatPushesTheQuests.Text = "Вы отбили атаку бандитов, их было немного больше вас, но нанятые в городе охранники, оказались очень полезны в бою. Продолжив свой путь по тропе, вы вышли к небольшой деревне. Вы решили передохнуть после боя, устроив привал рядом с одним из домов.";
                        DataBank.ScreenNumber = DataBank.ScreenNumber - 3;
                        label1.Text = DataBank.ScreenNumber.ToString();
                        this.Refresh();
                        Variant1.Visible = true;
                        Variant2.Visible = true;
                        Variant3.Visible = true;
                        Variant4.Visible = true;
                        Variant1.Enabled = true;
                        Variant2.Enabled = true;
                        Variant3.Enabled = true;
                        Variant4.Enabled = true;

                        Variant1.Text = "В самый большой дом";
                        Variant2.Text = "В ближайший к лесу дом";
                        Variant3.Text = "В дом, наполовину сделанный из камня";
                        Variant4.Text = "Пойти дальше по тропе";

                    }

                    else if ((DataBank.HaveGuard == true) && (DataBank.HaveHorse == true))
                    {
                        QuestionThatPushesTheQuests.Text = "Вы отбили атаку бандитов, их было немного больше вас, но нанятые в городе охранники, оказались очень полезны в бою. Продолжив свой путь по тропе, вы вышли к небольшой деревне. Вы решили передохнуть после боя, устроив привал рядом с одним из домов.";
                        DataBank.ScreenNumber = DataBank.ScreenNumber - 3;
                        label1.Text = DataBank.ScreenNumber.ToString();
                        this.Refresh();
                        Variant1.Visible = true;
                        Variant2.Visible = true;
                        Variant3.Visible = true;
                        Variant4.Visible = true;
                        Variant1.Enabled = true;
                        Variant2.Enabled = true;
                        Variant3.Enabled = true;
                        Variant4.Enabled = true;

                        Variant1.Text = "В самый большой дом";
                        Variant2.Text = "В ближайший к лесу дом";
                        Variant3.Text = "В дом, наполовину сделанный из камня";
                        Variant4.Text = "Пойти дальше по тропе";

                    }

                    else if ((DataBank.HaveGuard == false) && (DataBank.HaveHorse == false))
                    {

                        DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                        label1.Text = DataBank.ScreenNumber.ToString();
                        DataBank.ShowScreenInfo();
                        Hide();
                        DeathScreen DeathForm = new DeathScreen();
                        DataBank.DeathForm.DeathhText.Text = "Вам удалось отбить атаку бандитов, но вы сильно ранены. Вы бредете дальше по тропе надеясь найти помощь. Солнце уже освещает верхушки деревьев, окружающих вас со всех сторон. Вы выбиваетесь из сил и погибаете, так и не выйдя из леса.";
                        DeathForm.Refresh();
                        DataBank.DeathForm.Show();

                    }
                }
            }

            else if (DataBank.ScreenNumber == 53)
            {
                if (ButtonNumber == 1)
                {
                    DataBank.TavernVisited = true;
                    DataBank.ScreenNumber += 5;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    this.Refresh();
                    QuestionThatPushesTheQuests.Text = "Это оказалась таверна. Домов в деревне было совсем мало, поэтому неудивительно, что внутри был только трактирщик. Вы решаете спросить его про перчатку, но желудок подсказывает вам, что и купить припасов было бы неплохо (50 монет). Трактирщик рассказал вам про место, о котором ему говорили путешественники с севера. Его можно найти, если пойти дальше по тропе и свернуть в лес, как только наткнешься на ручей, после просто продолжить идти вдоль него по течению. Но странники всегда обходят это место стороной, потому что по слухам, там устроил себе берлогу какой-то страшный зверь, разрывающий любого, кто приблизится к его жилищу. Так же, трактирщик добавил, что совсем недавно к нему заходили люди, тоже спрашивающие про это место, и если мы поторопимся, то сможем нагнать их. Вы узнали все, что хотели.";

                    Variant1.Text = "Взять припасы(50 монет)";
                    Variant2.Text = "Уйти без покупок";

                    Variant1.Visible = true;
                    Variant1.Enabled = true;
                    Variant2.Visible = true;
                    Variant2.Enabled = true;



                    Variant3.Enabled = false;
                    Variant3.Visible = false;

                    Variant4.Enabled = false;
                    Variant4.Visible = false;


                    if (DataBank.Gold < 50)
                    {
                        Variant1.Enabled = false;
                    }
                }

                else if (ButtonNumber == 2)
                {
                    DataBank.HerbalistVisited = true;
                    DataBank.ScreenNumber += 7;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    this.Refresh();
                    QuestionThatPushesTheQuests.Text = "Это оказался дом травницы, у нее вы можете купить целебные зелья";

                    Variant1.Visible = true;
                    Variant2.Visible = true;
                    Variant3.Visible = true;
                    Variant4.Visible = true;
                    Variant1.Enabled = true;
                    Variant2.Enabled = true;
                    Variant3.Enabled = true;
                    Variant4.Enabled = true;

                    if (DataBank.Gold < 100)
                    {
                        Variant1.Enabled = false;


                        Variant2.Enabled = false;


                        Variant3.Enabled = false;

                    }

                    Variant1.Text = "Купить зелье восстановления здоровья (100 монет)";
                    Variant2.Text = "Купить зелье восстановления маны (100 монет)";
                    Variant3.Text = "Купить зелье восстановления праны (100 монет)";
                    Variant4.Text = "Уйти, ничего не купив";


                }

                if (ButtonNumber == 3)
                {
                    DataBank.BlacksmithVisited = true;
                    DataBank.ScreenNumber += 8;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    this.Refresh();
                    QuestionThatPushesTheQuests.Text = "Это оказался дом кузнеца, у него вы можете улучшить свое оружие";

                    Variant1.Visible = true;
                    Variant2.Visible = true;
                    Variant3.Visible = true;
                    Variant4.Visible = true;
                    Variant1.Enabled = true;
                    Variant2.Enabled = true;
                    Variant3.Enabled = true;
                    Variant4.Enabled = true;

                    if (DataBank.Gold < 300)
                    {
                        Variant1.Enabled = false;
                        Variant2.Enabled = false;
                        Variant3.Enabled = false;

                        Refresh();
                    }

                    else if (DataBank.Gold < 500)
                    {
                        Variant2.Enabled = false;
                        Variant3.Enabled = false;

                        Refresh();
                    }

                    else if (DataBank.Gold < 700)
                    {
                        Variant3.Enabled = false;

                        Refresh();
                    }

                    Variant1.Text = "300 монет (+10 урон)";
                    Variant2.Text = "500 монет (+30 урон)";
                    Variant3.Text = "700 монет (+50 урон)";
                    Variant4.Text = "Уйти, без улучшения оружия";

                }

                if ((ButtonNumber == 4))
                {
                    QuestionThatPushesTheQuests.Text = "Вы покидаете деревню и оправляетесь в путь.Со временем из всего разнообразия деревьев, что вас окружали, остаются лишь ели, ветер становится холоднее, вы плотнее закрываете лицо шарфом. К вечеру вы замечаете блеск воды рядом с тропой.Хотите свернуть с тропы и пойти вдоль ручья?";

                    DataBank.ScreenNumber = DataBank.ScreenNumber + 10;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    this.Refresh();

                    Variant1.Visible = true;
                    Variant2.Visible = true;
                    Variant1.Enabled = true;
                    Variant2.Enabled = true;

                    Variant3.Visible = false;
                    Variant4.Visible = false;
                    Variant3.Enabled = false;
                    Variant4.Enabled = false;
                    Variant1.Text = "Свернуть к ручью";
                    Variant2.Text = "Пойти дальше по тропе";

                }
            }

            else if (DataBank.ScreenNumber == 58)
            {

                if (ButtonNumber == 1)
                {
                    DataBank.Gold += -50;
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    this.Refresh();
                    QuestionThatPushesTheQuests.Text = "Куда вы пошли дальше?";


                    Variant1.Visible = true;
                    Variant2.Visible = true;
                    Variant3.Visible = true;
                    Variant4.Visible = true;
                    Variant1.Enabled = true;
                    Variant2.Enabled = true;
                    Variant3.Enabled = true;
                    Variant4.Enabled = true;

                    if (DataBank.TavernVisited)
                    {
                        Variant1.Enabled = false;
                    }
                    else if (DataBank.HerbalistVisited)
                    {
                        Variant2.Enabled = false;
                    }
                    else if (DataBank.BlacksmithVisited)
                    {
                        Variant3.Enabled = false;
                    }

                    Variant1.Text = "В самый большой дом";
                    Variant2.Text = "В ближайший к лесу дом";
                    Variant3.Text = "В дом, наполовину сделанный из камня";
                    Variant4.Text = "Пойти дальше по тропе";
                }

                if (ButtonNumber == 2)
                {
                    DataBank.Gold += -50;
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    this.Refresh();
                    QuestionThatPushesTheQuests.Text = "Куда вы пошли дальше?";

                    Variant1.Visible = true;
                    Variant2.Visible = true;
                    Variant3.Visible = true;
                    Variant4.Visible = true;
                    Variant1.Enabled = true;
                    Variant2.Enabled = true;
                    Variant3.Enabled = true;
                    Variant4.Enabled = true;

                    if (DataBank.TavernVisited)
                    {
                        Variant1.Enabled = false;
                    }
                    else if (DataBank.HerbalistVisited)
                    {
                        Variant2.Enabled = false;
                    }
                    else if (DataBank.BlacksmithVisited)
                    {
                        Variant3.Enabled = false;
                    }

                    Variant1.Text = "В самый большой дом";
                    Variant2.Text = "В ближайший к лесу дом";
                    Variant3.Text = "В дом, наполовину сделанный из камня";
                    Variant4.Text = "Пойти дальше по тропе";
                }

            }

            else if (DataBank.ScreenNumber == 60)
            {

                if (ButtonNumber == 1)
                {
                    DataBank.Gold += -100;
                    DataBank.HaveHeal = true;
                    DataBank.ScreenNumber = DataBank.ScreenNumber - 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    this.Refresh();
                    QuestionThatPushesTheQuests.Text = "Куда вы пошли дальше?";

                    Variant1.Visible = true;
                    Variant2.Visible = true;
                    Variant3.Visible = true;
                    Variant4.Visible = true;
                    Variant1.Enabled = true;
                    Variant2.Enabled = true;
                    Variant3.Enabled = true;
                    Variant4.Enabled = true;






                    if (DataBank.TavernVisited)
                    {
                        Variant1.Enabled = false;
                    }
                    if (DataBank.HerbalistVisited)
                    {
                        Variant2.Enabled = false;
                    }
                    if (DataBank.BlacksmithVisited)
                    {
                        Variant3.Enabled = false;
                    }


                    Variant1.Text = "В самый большой дом";
                    Variant2.Text = "В ближайший к лесу дом";
                    Variant3.Text = "В дом, наполовину сделанный из камня";
                    Variant4.Text = "Пойти дальше по тропе";
                }

                if (ButtonNumber == 2)
                {
                    DataBank.Gold += -100;
                    DataBank.ScreenNumber = DataBank.ScreenNumber - 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    this.Refresh();
                    QuestionThatPushesTheQuests.Text = "Куда вы пошли дальше?";

                    Variant1.Visible = true;
                    Variant2.Visible = true;
                    Variant3.Visible = true;
                    Variant4.Visible = true;
                    Variant1.Enabled = true;
                    Variant2.Enabled = true;
                    Variant3.Enabled = true;
                    Variant4.Enabled = true;

                    if (DataBank.TavernVisited)
                    {
                        Variant1.Enabled = false;
                    }
                    if (DataBank.HerbalistVisited)
                    {
                        Variant2.Enabled = false;
                    }
                    if (DataBank.BlacksmithVisited)
                    {
                        Variant3.Enabled = false;
                    }

                    Variant1.Text = "В самый большой дом";
                    Variant2.Text = "В ближайший к лесу дом";
                    Variant3.Text = "В дом, наполовину сделанный из камня";
                    Variant4.Text = "Пойти дальше по тропе";
                }

                if (ButtonNumber == 3)
                {
                    DataBank.Gold += -100;
                    DataBank.ScreenNumber = DataBank.ScreenNumber - 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    this.Refresh();
                    QuestionThatPushesTheQuests.Text = "Куда вы пошли дальше?";


                    Variant1.Visible = true;
                    Variant2.Visible = true;
                    Variant3.Visible = true;
                    Variant4.Visible = true;
                    Variant1.Enabled = true;
                    Variant2.Enabled = true;
                    Variant3.Enabled = true;
                    Variant4.Enabled = true;


                    if (DataBank.TavernVisited)
                    {
                        Variant1.Enabled = false;
                    }

                    if (DataBank.HerbalistVisited)
                    {
                        Variant2.Enabled = false;
                    }
                    if (DataBank.BlacksmithVisited)
                    {
                        Variant3.Enabled = false;
                    }

                    Variant1.Text = "В самый большой дом";
                    Variant2.Text = "В ближайший к лесу дом";
                    Variant3.Text = "В дом, наполовину сделанный из камня";
                    Variant4.Text = "Пойти дальше по тропе";
                }

                if (ButtonNumber == 4)
                {
                    DataBank.Gold += -100;
                    DataBank.ScreenNumber = DataBank.ScreenNumber - 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    this.Refresh();
                    QuestionThatPushesTheQuests.Text = "Куда вы пошли дальше?";

                    Variant1.Visible = true;
                    Variant2.Visible = true;
                    Variant3.Visible = true;
                    Variant4.Visible = true;
                    Variant1.Enabled = true;
                    Variant2.Enabled = true;
                    Variant3.Enabled = true;
                    Variant4.Enabled = true;

                    if (DataBank.TavernVisited)
                    {
                        Variant1.Enabled = false;
                    }
                    if (DataBank.HerbalistVisited)
                    {
                        Variant2.Enabled = false;
                    }
                    if (DataBank.BlacksmithVisited)
                    {
                        Variant3.Enabled = false;
                    }

                    Variant1.Text = "В самый большой дом";
                    Variant2.Text = "В ближайший к лесу дом";
                    Variant3.Text = "В дом, наполовину сделанный из камня";
                    Variant4.Text = "Пойти дальше по тропе";
                }
            }


            else if (DataBank.ScreenNumber == 61)
            {

                if (ButtonNumber == 1)
                {
                    DataBank.Gold += -300;
                    DataBank.WeaponUpgrade = 10;
                    DataBank.ScreenNumber = DataBank.ScreenNumber - 2;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    this.Refresh();
                    QuestionThatPushesTheQuests.Text = "Куда вы пошли дальше?";

                    Variant1.Visible = true;
                    Variant2.Visible = true;
                    Variant3.Visible = true;
                    Variant4.Visible = true;
                    Variant1.Enabled = true;
                    Variant2.Enabled = true;
                    Variant3.Enabled = true;
                    Variant4.Enabled = true;

                    if (DataBank.TavernVisited)
                    {
                        Variant1.Enabled = false;
                    }
                    if (DataBank.HerbalistVisited)
                    {
                        Variant2.Enabled = false;
                    }
                    if (DataBank.BlacksmithVisited)
                    {
                        Variant3.Enabled = false;
                    }

                    Variant1.Text = "В самый большой дом";
                    Variant2.Text = "В ближайший к лесу дом";
                    Variant3.Text = "В дом, наполовину сделанный из камня";
                    Variant4.Text = "Пойти дальше по тропе";
                }

                if (ButtonNumber == 2)
                {
                    DataBank.Gold += -500;
                    DataBank.WeaponUpgrade = 30;
                    DataBank.ScreenNumber = DataBank.ScreenNumber - 2;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    this.Refresh();
                    QuestionThatPushesTheQuests.Text = "Куда вы пошли дальше?";


                    Variant1.Visible = true;
                    Variant2.Visible = true;
                    Variant3.Visible = true;
                    Variant4.Visible = true;
                    Variant1.Enabled = true;
                    Variant2.Enabled = true;
                    Variant3.Enabled = true;
                    Variant4.Enabled = true;


                    if (DataBank.TavernVisited)
                    {
                        Variant1.Enabled = false;
                    }
                    if (DataBank.HerbalistVisited)
                    {
                        Variant2.Enabled = false;
                    }
                    if (DataBank.BlacksmithVisited)
                    {
                        Variant3.Enabled = false;
                    }

                    Variant1.Text = "В самый большой дом";
                    Variant2.Text = "В ближайший к лесу дом";
                    Variant3.Text = "В дом, наполовину сделанный из камня";
                    Variant4.Text = "Пойти дальше по тропе";
                }

                if (ButtonNumber == 3)
                {
                    DataBank.Gold += -700;
                    DataBank.WeaponUpgrade = 50;
                    DataBank.ScreenNumber = DataBank.ScreenNumber - 2;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    this.Refresh();
                    QuestionThatPushesTheQuests.Text = "Куда вы пошли дальше?";


                    Variant1.Visible = true;
                    Variant2.Visible = true;
                    Variant3.Visible = true;
                    Variant4.Visible = true;
                    Variant1.Enabled = true;
                    Variant2.Enabled = true;
                    Variant3.Enabled = true;
                    Variant4.Enabled = true;

                    if (DataBank.TavernVisited)
                    {
                        Variant1.Enabled = false;
                    }
                    if (DataBank.HerbalistVisited)
                    {
                        Variant2.Enabled = false;
                    }
                    if (DataBank.BlacksmithVisited)
                    {
                        Variant3.Enabled = false;
                    }

                    Variant1.Text = "В самый большой дом";
                    Variant2.Text = "В ближайший к лесу дом";
                    Variant3.Text = "В дом, наполовину сделанный из камня";
                    Variant4.Text = "Пойти дальше по тропе";
                }

                if (ButtonNumber == 4)
                {

                    DataBank.ScreenNumber = DataBank.ScreenNumber - 2;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    this.Refresh();
                    QuestionThatPushesTheQuests.Text = "Куда вы пошли дальше?";

                    Variant1.Visible = true;
                    Variant2.Visible = true;
                    Variant3.Visible = true;
                    Variant4.Visible = true;
                    Variant1.Enabled = true;
                    Variant2.Enabled = true;
                    Variant3.Enabled = true;
                    Variant4.Enabled = true;

                    if (DataBank.TavernVisited)
                    {
                        Variant1.Enabled = false;
                    }
                    if (DataBank.HerbalistVisited)
                    {
                        Variant2.Enabled = false;
                    }
                    if (DataBank.BlacksmithVisited)
                    {
                        Variant3.Enabled = false;
                    }

                    Variant1.Text = "В самый большой дом";
                    Variant2.Text = "В ближайший к лесу дом";
                    Variant3.Text = "В дом, наполовину сделанный из камня";
                    Variant4.Text = "Пойти дальше по тропе";
                }


            }

            else if (DataBank.ScreenNumber == 59)
            {


                if (ButtonNumber == 1)
                {
                    DataBank.TavernVisited = true;
                    DataBank.ScreenNumber += -1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    this.Refresh();
                    QuestionThatPushesTheQuests.Text = "Это оказалась таверна. Домов в деревне было совсем мало, поэтому неудивительно, что внутри был только трактирщик. Вы решаете спросить его про перчатку, но желудок подсказывает вам, что и купить припасов было бы неплохо (50 монет). Трактирщик рассказал вам про место, о котором ему говорили путешественники с севера. Его можно найти, если пойти дальше по тропе и свернуть в лес, как только наткнешься на ручей, после просто продолжить идти вдоль него по течению. Но странники всегда обходят это место стороной, потому что по слухам, там устроил себе берлогу какой-то страшный зверь, разрывающий любого, кто приблизится к его жилищу. Так же, трактирщик добавил, что совсем недавно к нему заходили люди, тоже спрашивающие про это место, и если мы поторопимся, то сможем нагнать их. Вы узнали все, что хотели.";

                    Variant1.Text = "Взять припасы(50 монет)";
                    Variant2.Text = "Уйти без покупок";

                    Variant1.Visible = true;
                    Variant2.Visible = true;
                    Variant1.Enabled = true;
                    Variant2.Enabled = true;

                    Variant3.Enabled = false;
                    Variant3.Visible = false;

                    Variant4.Enabled = false;
                    Variant4.Visible = false;

                    if (DataBank.Gold < 50)
                    {
                        Variant1.Enabled = false;
                    }
                }

                if (ButtonNumber == 2)
                {
                    DataBank.HerbalistVisited = true;
                    DataBank.ScreenNumber += 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    this.Refresh();
                    QuestionThatPushesTheQuests.Text = "Это оказался дом травницы, у нее вы можете купить целебные зелья";


                    Variant1.Visible = true;
                    Variant2.Visible = true;
                    Variant3.Visible = true;
                    Variant4.Visible = true;
                    Variant1.Enabled = true;
                    Variant2.Enabled = true;
                    Variant3.Enabled = true;
                    Variant4.Enabled = true;

                    if (DataBank.Gold < 100)
                    {
                        Variant1.Enabled = false;


                        Variant2.Enabled = false;


                        Variant3.Enabled = false;

                    }

                    Variant1.Text = "Купить зелье восстановления здоровья (100 монет)";
                    Variant2.Text = "Купить зелье восстановления маны (100 монет)";
                    Variant3.Text = "Купить зелье восстановления праны (100 монет)";
                    Variant4.Text = "Уйти, ничего не купив";


                }

                if (ButtonNumber == 3)
                {
                    DataBank.BlacksmithVisited = true;
                    DataBank.ScreenNumber += 2;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    this.Refresh();
                    QuestionThatPushesTheQuests.Text = "Это оказался дом кузнеца, у него вы можете улучшить свое оружие";


                    Variant1.Visible = true;
                    Variant2.Visible = true;
                    Variant3.Visible = true;
                    Variant4.Visible = true;
                    Variant1.Enabled = true;
                    Variant2.Enabled = true;
                    Variant3.Enabled = true;
                    Variant4.Enabled = true;

                    if (DataBank.Gold < 300)
                    {
                        Variant1.Enabled = false;
                        Variant2.Enabled = false;
                        Variant3.Enabled = false;

                        Refresh();
                    }

                    else if (DataBank.Gold < 500)
                    {
                        Variant2.Enabled = false;
                        Variant3.Enabled = false;

                        Refresh();
                    }

                    else if (DataBank.Gold < 700)
                    {
                        Variant3.Enabled = false;

                        Refresh();
                    }

                    Variant1.Text = "300 монет (+10 урон)";
                    Variant2.Text = "500 монет (+30 урон)";
                    Variant3.Text = "700 монет (+50 урон)";
                    Variant4.Text = "Уйти, без улучшения оружия";

                }

                if ((ButtonNumber == 4))
                {
                    QuestionThatPushesTheQuests.Text = "Вы покидаете деревню и оправляетесь в путь.Со временем из всего разнообразия деревьев, что вас окружали, остаются лишь ели, ветер становится холоднее, вы плотнее закрываете лицо шарфом. К вечеру вы замечаете блеск воды рядом с тропой.Хотите свернуть с тропы и пойти вдоль ручья?";

                    DataBank.ScreenNumber = DataBank.ScreenNumber + 4;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    this.Refresh();

                    Variant1.Visible = true;
                    Variant2.Visible = true;
                    Variant1.Enabled = true;
                    Variant2.Enabled = true;

                    Variant3.Visible = false;
                    Variant4.Visible = false;
                    Variant3.Enabled = false;
                    Variant4.Enabled = false;
                    Variant1.Text = "Свернуть к ручью";
                    Variant2.Text = "Пойти дальше по тропе";

                }

            }


            else if (DataBank.ScreenNumber == 63)
            {

                if ((ButtonNumber == 1))
                {
                    QuestionThatPushesTheQuests.Text = ". Вы сворачиваете к ручью и продолжаете идти, решив не устраивать привал, ведь цель уже близко. Через несколько минут ходьбы вы замечаете следы обуви на земле, слегка занесенной снегом. Скорее всего это те люди, что спрашивали трактирщика о перчатке, вы ускоряете шаг. Еще через несколько минут вы замечаете кровь на снегу, и совсем рядом раненого человека. Он зовет вас и просит помочь, что вы сделаете?";


                    DataBank.ScreenNumber = DataBank.ScreenNumber + 2;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    this.Refresh();
                    Variant1.Visible = true;
                    Variant2.Visible = true;
                    Variant3.Visible = true;
                    Variant4.Visible = true;
                    Variant1.Enabled = true;
                    Variant2.Enabled = true;
                    Variant3.Enabled = true;
                    Variant4.Enabled = true;

                    if (DataBank.HaveHeal == false)
                    {
                        Variant1.Enabled = false;
                    }
                    Variant1.Text = "Дать ему зелье восстановления здоровья";
                    Variant2.Text = "Попытаться остановить кровь и перевязать раны";
                    Variant3.Text = "Спросить, что с ним случилось";
                    Variant4.Text = "Пройти мимо";
                }

                if ((ButtonNumber == 2))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    this.Refresh();
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    Hide();
                    DeathScreen DeathForm = new DeathScreen();
                    DataBank.DeathForm.DeathhText.Text = "Вы продолжаете идти по тропе, темнеет, погода становится все холоднее и начинает идти снег. Вы решили устроить привал, поужинали и легли спать. Но ваша одежда оказалась недостаточно теплой, чтобы защитить вас от холода, за ночь вы отмораживаете конечности и не можете идти дальше. По такой северной тропе редко ходят путешественники, вы погибаете от холода.";
                    DeathForm.Refresh();
                    DataBank.DeathForm.Show();

                }
            }

            else if (DataBank.ScreenNumber == 65)
            {

                if ((ButtonNumber == 1) || (ButtonNumber == 2))
                {
                    QuestionThatPushesTheQuests.Text = "Незнакомец благодарит вас за помощь. Он рассказывает, что он исследователь, и отравился сюда со своей группой в поисках загадочного артефакта, но тот оказался под охраной огромного зверя. Исследователь предлагает вам свою помощь в битве с ним, в благодарность за спасение. Вы продолжаете идти вдоль ручья, крови становится больше. И вот наконец вы видите зверя. Это огромное, похожее на медведя животное, но в два раза его больше. Зверь поворачивается в вашу сторону, рычит, и начинает атаковать. Что вы будете делать?";

                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    this.Refresh();
                    DataBank.HavePartner = true;
                    Variant1.Visible = true;
                    Variant2.Visible = true;
                    Variant3.Visible = true;
                    Variant4.Visible = false;
                    Variant1.Enabled = true;
                    Variant2.Enabled = true;
                    Variant3.Enabled = true;
                    Variant4.Enabled = false;


                    Variant1.Text = "Ударить его слева";
                    Variant2.Text = "Ударить его справа";
                    Variant3.Text = "Атаковать в голову";
                    Refresh();

                }


                if ((ButtonNumber == 3))
                {
                    QuestionThatPushesTheQuests.Text = "Незнакомец рассказывает, что он исследователь, и отравился сюда со своей группой в поисках загадочного артефакта, но тот оказался под охраной огромного зверя. Исследователь говорит, что не сможет вам никак помочь в таком состоянии, но добавляет, что одному из его товарищей удалось ранить зверя левую переднюю лапу и теперь он хромает, возможно эта информация поможет вам. Вы продолжаете идти вдоль ручья, крови становится больше. И вот наконец вы видите зверя. Это огромное, похожее на медведя животное, но в два раза его больше. Зверь поворачивается в вашу сторону, рычит, и начинает атаковать. Что вы будете делать?";

                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    this.Refresh();
                    Variant1.Visible = true;
                    Variant2.Visible = true;
                    Variant3.Visible = true;
                    Variant4.Visible = false;
                    Variant1.Enabled = true;
                    Variant2.Enabled = true;
                    Variant3.Enabled = true;
                    Variant4.Enabled = false;
                    Variant1.Text = "Ударить его слева";
                    Variant2.Text = "Ударить его справа";
                    Variant3.Text = "Атаковать в голову";
                    Refresh();
                }

                if ((ButtonNumber == 4))
                {
                    QuestionThatPushesTheQuests.Text = "Вы проходите дальше, продолжаете идти вдоль ручья, крови становится больше. И вот наконец вы видите зверя. Это огромное, похожее на медведя животное, но в два раза его больше. Зверь поворачивается в вашу сторону, рычит, и начинает атаковать. Что вы будете делать?";

                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    this.Refresh();
                    Variant1.Visible = true;
                    Variant2.Visible = true;
                    Variant3.Visible = true;
                    Variant4.Visible = false;
                    Variant1.Enabled = true;
                    Variant2.Enabled = true;
                    Variant3.Enabled = true;
                    Variant4.Enabled = false;

                    Variant1.Text = "Ударить его слева";
                    Variant2.Text = "Ударить его справа";
                    Variant3.Text = "Атаковать в голову";
                    Refresh();

                }
            }

            else if (DataBank.ScreenNumber == 66)
            {

                if (ButtonNumber == 1)
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 2;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    Hide();
                    SuccessScreen SuccForm = new SuccessScreen();
                    DataBank.SuccForm.SuccesssMessage.Text = "Вы атакуете зверя слева.Он пытается отразить атаку, но не может опереться на раненную лапу и вам удается ударить его в шею.Зверь зарычал, и попытался ответить на атаку, но боль и сильная рана не позволили ему это сделать, и он рухнул.Вы обходите тело поверженного врага и замечаете вход в небольшую пещеру, вы направляетесь прямо туда. Войдя, вы видите множество рисунков на стенах пещеры, по выбитым в камне ступеням вы спускаетесь все ниже и наконец оказываетесь в небольшом зале, в центре которого, на камне, лежали те самые перчатки.Вы забираете их и возвращаетесь домой, заслужив уважение семьи.";
                    DataBank.SuccForm.Show();
                    this.Refresh();

                }

                else if (((ButtonNumber == 2) || (ButtonNumber == 3)) && (((DataBank.HaveGuard == false) || (DataBank.HavePartner == false)) && (DataBank.WeaponUpgrade < 20)))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    Hide();
                    DeathScreen DeathForm = new DeathScreen();
                    DataBank.DeathForm.DeathhText.Text = "Вы пытаетесь атаковать зверя, но он легко уходит от вашей атаки. Он встает на задние лапы и обрушивает на вас удар всем своим весом. Вы погибаете, почти достигнув своей цели.";
                    DataBank.DeathForm.Show();
                    this.Refresh();
                }

                else if (((ButtonNumber == 2) || (ButtonNumber == 3)) && (((DataBank.HaveGuard == true) || (DataBank.HavePartner == true)) && (DataBank.WeaponUpgrade >= 20)))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 2;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    Hide();
                    SuccessScreen SuccForm = new SuccessScreen();
                    DataBank.SuccForm.SuccesssMessage.Text = "Вы атакуете зверя. Он пытается отразить атаку, но ваши союзники отвлекают его с другой стороны и вам удается ударить. Зверь зарычал, и попытался ответить на атаку, но боль и сильная рана не позволили ему это сделать, и он рухнул. Вы обходите тело поверженного врага и замечаете вход в небольшую пещеру, вы направляетесь прямо туда. Войдя, вы видите множество рисунков на стенах пещеры, по выбитым в камне ступеням вы спускаетесь все ниже и наконец оказываетесь в небольшом зале, в центре которого, на камне, лежали те самые перчатки. Вы забираете их и возвращаетесь домой, заслужив уважение семьи.";
                    DataBank.SuccForm.Show();
                    this.Refresh();
                }
                else if (((ButtonNumber == 2) || (ButtonNumber == 3)) && ((DataBank.HaveGuard == false) || (DataBank.HavePartner == false)) && (DataBank.WeaponUpgrade >= 20))
                {
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    Hide();
                    DeathScreen DeathForm = new DeathScreen();
                    DataBank.DeathForm.DeathhText.Text = "Вы пытаетесь атаковать зверя, но он легко уходит от вашей атаки. Он встает на задние лапы и обрушивает на вас удар всем своим весом. Вы погибаете, почти достигнув своей цели.";
                    DataBank.DeathForm.Show();
                    this.Refresh();
                }
            }

            else if (DataBank.ScreenNumber == 69)
            {
                if (ButtonNumber == 1)
                {
                    //ButOneisPressed = false;
                    DataBank.Horse = Variant1.Text;
                    //this.Refresh();
                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                    this.Refresh();
                }
                else if (ButtonNumber == 2)
                {
                    //ButTwoisPressed = false;
                    DataBank.Horse = Variant2.Text;
                    //this.Refresh();

                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                    this.Refresh();

                }

                else if (ButtonNumber == 3)
                {
                    //ButThreeisPressed = false;
                    DataBank.Horse = Variant3.Text;
                    //this.Refresh();

                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                    this.Refresh();
                }
                else if (ButtonNumber == 4)
                {
                    //ButFourisPressed = false;
                    DataBank.Horse = Variant4.Text;
                    //this.Refresh();

                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
                    Variant1.Text = DataBank.TextButtonVariant1;
                    Variant2.Text = DataBank.TextButtonVariant2;
                    Variant3.Text = DataBank.TextButtonVariant3;
                    Variant4.Text = DataBank.TextButtonVariant4;
                    this.Refresh();
                }

            }


            else if (DataBank.ScreenNumber == 70)
            {
                if ((ButtonNumber == 1) || (ButtonNumber == 2) || (ButtonNumber == 3) || (ButtonNumber == 4))
                {

                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = "Утро встретило вас холодным накрапывающим дождем и плотным туманом. Пасмурная погода отлично сочеталась с отчужденностью и мраком эльфийских развалин. Ваш провожатый покинул вас за пару верст от города, что-то невнятно пробормотав себе под нос про неоконченную работу. До полуобвалившихся ворот вы добрались за считанные минуты. Запустение и разруха, царящие в этом последнем прибежище давно забытой эры, привели вас в благоговейный страх, сопряженный с любопытством и духом авантюризма. Итак, несмотря на бегущие вдоль позвоночника мурашки, вы въезжаете в город. Но куда вы решаете держать путь в первую очередь?";
                    Variant3.Enabled = false;
                    Variant4.Visible = false;
                    Variant4.Enabled = false;
                    Variant4.Visible = false;
                    Variant1.Text = "Осмотреть ближайшие дома";
                    Variant2.Text = "Направиться к центру поселения";
                    Refresh();
                }
            }

            else if (DataBank.ScreenNumber == 71)
            {
                if (ButtonNumber == 1)
                {

                    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
                    label1.Text = DataBank.ScreenNumber.ToString();
                    DataBank.ShowScreenInfo();
                    QuestionThatPushesTheQuests.Text = "Вы решаете продолжить поиски чего-либо интересного (сами не зная, чего) в жилой зоне города. Следуя по мощеной дороге к более плотно застроенному кварталу, вы вдруг слышите протяжный вой! Долинные волки, почуяв запах добычи, пришли в поисках обеда на руины эльфийского поселения. Пока они на значительном расстоянии, вы все еще можете выбрать – дать им бой или сбежать, поджав хвост? ";
                    Refresh();

                    Variant3.Enabled = true;
                    Variant4.Visible = true;
                    Variant4.Enabled = false;
                    Variant4.Visible = false;
                    Variant1.Text = "Сражаться! ";
                    Variant2.Text = "Бежать!";
                    Variant3.Text = "Выкинуть припасы ";
                }
            }

            //кузнец 

            //if ((ButtonNumber == 1))
            //{
            //    DataBank.WeaponUpgrade = 10;
            //    DataBank.Gold = DataBank.Gold - 300;
            //    DataBank.ScreenNumber = DataBank.ScreenNumber - 1;
            //    label1.Text = DataBank.ScreenNumber.ToString();
            //    DataBank.ShowScreenInfo();
            //    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
            //    Variant1.Text = DataBank.TextButtonVariant1;
            //    Variant2.Text = DataBank.TextButtonVariant2;
            //    Variant3.Text = DataBank.TextButtonVariant3;
            //    Variant4.Text = DataBank.TextButtonVariant4;
            //    this.Refresh();
            //}

            //else if ((ButtonNumber == 2))
            //{
            //    DataBank.WeaponUpgrade = 30;
            //    DataBank.Gold = DataBank.Gold - 500;
            //    DataBank.ScreenNumber = DataBank.ScreenNumber - 1;
            //    label1.Text = DataBank.ScreenNumber.ToString();
            //    DataBank.ShowScreenInfo();
            //    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
            //    Variant1.Text = DataBank.TextButtonVariant1;
            //    Variant2.Text = DataBank.TextButtonVariant2;
            //    Variant3.Text = DataBank.TextButtonVariant3;
            //    Variant4.Text = DataBank.TextButtonVariant4;
            //    this.Refresh();
            //}

            //else if ((ButtonNumber == 3))
            //{
            //    DataBank.WeaponUpgrade = 50;
            //    DataBank.Gold = DataBank.Gold - 700;
            //    DataBank.ScreenNumber = DataBank.ScreenNumber - 1;
            //    label1.Text = DataBank.ScreenNumber.ToString();
            //    DataBank.ShowScreenInfo();
            //    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
            //    Variant1.Text = DataBank.TextButtonVariant1;
            //    Variant2.Text = DataBank.TextButtonVariant2;
            //    Variant3.Text = DataBank.TextButtonVariant3;
            //    Variant4.Text = DataBank.TextButtonVariant4;
            //    this.Refresh();
            //}

            //else if ((ButtonNumber == 4))
            //{
            //    DataBank.WeaponUpgrade = 50;
            //    DataBank.Gold = DataBank.Gold - 500;
            //    DataBank.ScreenNumber = DataBank.ScreenNumber - 1;
            //    label1.Text = DataBank.ScreenNumber.ToString();
            //    DataBank.ShowScreenInfo();
            //    QuestionThatPushesTheQuests.Text = DataBank.QuestionThatPushesTheQuest;
            //    Variant1.Text = DataBank.TextButtonVariant1;
            //    Variant2.Text = DataBank.TextButtonVariant2;
            //    Variant3.Text = DataBank.TextButtonVariant3;
            //    Variant4.Text = DataBank.TextButtonVariant4;
            //    this.Refresh();
            //}

        }

        //        label1.Text = DataBank.ScreenNumber.ToString();
        //        DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
        //        QuestionThatPushesTheQuest.Text = " На вас напали бандиты! Сражайтесь за свою жизнь!";
        //        Variant1.Text = " Мощный удар щитом: (-2 ед выносливости)";
        //        Variant2.Text = " Рассекающий удар: Убрав щит, размашистым ударом топора, воин наносит 10 единиц урона первым ударом, и 15 единиц урона вторым.  (-3 ед выносливости)";
        //        Variant3.Text = " Казнь: Впадая в ярость, сильнейшим ударом в голову, воин наносит 30 единиц урона (-4 ед выносливости) ";
        //        Variant4.Text = " Вихрь клинков: Схватившись двумя руками за топор, воин начинает кружится пока не нанесет 20 единиц урона.  (-5 ед выносливости)";
        //        Refresh();
        //    }

        //    else if (DataBank.CharacterClass == "Mage")
        //    {
        //        label1.Text = DataBank.ScreenNumber.ToString();
        //        DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
        //        QuestionThatPushesTheQuest.Text = " На вас напали бандиты! Сражайтесь за свою жизнь!";
        //        Variant1.Text = " Чародейские стрелы: Ударив посохом о землю, маг вызывает 3 чародейские стрелы, которые наносят 15 единиц урона  (-2 ед характеристики)";
        //        Variant2.Text = " Огненный шар: Сконцентрировавшись, маг наносит 20 единиц урона огненным шаром и поджигает противника, нанеся еще 5 единиц урона. (-3 ед характеристики)  (-3 ед выносливости)";
        //        Variant3.Text = " Ледяная стрела: Маг выпускает на противника огромную ледяную стрелу, которая впивается в тело противника и наносит 30 единиц урона  (-4 ед характеристики) ";
        //        Variant4.Text = " Морозный луч: Направив посох на противника, маг выпускает морозный луч, который наносит 20 единиц урона и замедляет врага. (-5 ед характеристики)";
        //        Refresh();
        //    }

        //    else if (DataBank.CharacterClass == "Priest")
        //    {
        //        label1.Text = DataBank.ScreenNumber.ToString();
        //        DataBank.ScreenNumber = DataBank.ScreenNumber + 2;
        //        QuestionThatPushesTheQuest.Text = " От вашей молитвы, на дерево падает луч света. Видимо, божества решили вас испытать. Поднимается могучий энт. Защитите себя, и докажите, что достойны силы богов!";

        //        Variant1.Text = " Кара божья: Жрец испускает на противника 4 световых луча, наносящих по 4 единиц урона.  (-2 ед характеристики)";
        //        Variant2.Text = " Рябь света: Жрец окутывает себя световым куполом, который взрывается 2 раза, нанося после каждого взрыва по 12 единиц урона.   (-3 ед характеристики)";
        //        Variant3.Text = " Контроль над разумом: Жрец получает контроль над разумом противника, заставляя того вонзить в себя собственное оружие, нанося при этом 30 единиц урона.  (-4 ед характеристики)";
        //        Variant4.Text = " Порождение света: Молитвой жрец взывает о помощи, призывая порождение света, которое атакует противника и наносит ему 20 единиц урона.  (-5 ед характеристики)";

        //        Refresh();
        //    }

        //    //DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
        //    //this.Refresh();
        //}
        //else if ((ButtonNumber == 2) && (DataBank.CharacterClass != "Warrior"))
        //{

        //    //ButOneisPressed = false;

        //    if (DataBank.CharacterClass == "Warrior")
        //    {
        //        label1.Text = DataBank.ScreenNumber.ToString();
        //        DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
        //        QuestionThatPushesTheQuest.Text = " На вас напали бандиты! Сражайтесь за свою жизнь!";

        //         else if (DataBank.CharacterClass == "Thief")
        //        {
        //            label1.Text = DataBank.ScreenNumber.ToString();
        //            DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
        //            QuestionThatPushesTheQuest.Text = " На вас напали бандиты! Сражайтесь за свою жизнь!";
        //            Variant1.Text = " Удар в спину: Вор забегает за спину противнику и вонзает в него кинжал, нанося 20 единиц урона  (-2 ед характеристики)";
        //            Variant2.Text = " Грязные приемы: Бросая пыль в глаза противнику, вор сбивает противника с ног, нанося 5 единиц урона и вонзает в него кинжал, который наносит еще 20 единиц урона. (-3 ед характеристики)";
        //            Variant3.Text = " Веер клинков: Отпрыгнув от врага, вор метает в него 6 кинжалов. Каждый из кинжалов наносит по 5 единиц урона. (-4 ед характеристики)";
        //            Variant4.Text = " Отравленные клинки: Вор отравляет клинки и бросает их в противника, нанося 10 единиц урона, а после яд наносит еще 15 единиц урона.  (-5 ед характеристики)";

        //            Refresh();
        //        }

        //        else if (DataBank.CharacterClass == "Mage")
        //        {
        //            label1.Text = DataBank.ScreenNumber.ToString();
        //            DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
        //            QuestionThatPushesTheQuest.Text = " На вас напали бандиты! Сражайтесь за свою жизнь!";
        //            Variant1.Text = " Чародейские стрелы: Ударив посохом о землю, маг вызывает 3 чародейские стрелы, которые наносят 15 единиц урона  (-2 ед характеристики)";
        //            Variant2.Text = " Огненный шар: Сконцентрировавшись, маг наносит 20 единиц урона огненным шаром и поджигает противника, нанеся еще 5 единиц урона. (-3 ед характеристики)  (-3 ед выносливости)";
        //            Variant3.Text = " Ледяная стрела: Маг выпускает на противника огромную ледяную стрелу, которая впивается в тело противника и наносит 30 единиц урона  (-4 ед характеристики) ";
        //            Variant4.Text = " Морозный луч: Направив посох на противника, маг выпускает морозный луч, который наносит 20 единиц урона и замедляет врага. (-5 ед характеристики)";
        //            Refresh();
        //        }

        //        else if (DataBank.CharacterClass == "Priest")
        //        {
        //            label1.Text = DataBank.ScreenNumber.ToString();
        //            DataBank.ScreenNumber = DataBank.ScreenNumber + 2;
        //            QuestionThatPushesTheQuest.Text = " От вашей молитвы, на дерево падает луч света. Видимо, божества решили вас испытать. Поднимается могучий энт. Защитите себя, и докажите, что достойны силы богов!";

        //            Variant1.Text = " Кара божья: Жрец испускает на противника 4 световых луча, наносящих по 4 единиц урона.  (-2 ед характеристики)";
        //            Variant2.Text = " Рябь света: Жрец окутывает себя световым куполом, который взрывается 2 раза, нанося после каждого взрыва по 12 единиц урона.   (-3 ед характеристики)";
        //            Variant3.Text = " Контроль над разумом: Жрец получает контроль над разумом противника, заставляя того вонзить в себя собственное оружие, нанося при этом 30 единиц урона.  (-4 ед характеристики)";
        //            Variant4.Text = " Порождение света: Молитвой жрец взывает о помощи, призывая порождение света, которое атакует противника и наносит ему 20 единиц урона.  (-5 ед характеристики)";

        //            Refresh();


        //else if ((ButtonNumber == 3) && (DataBank.CharacterClass != "Priest"))
        //{
        //    //ButThreeisPressed = false;
        //    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
        //    //this.Refresh();
        //}

        //else if ((ButtonNumber == 3) && (DataBank.CharacterClass == "Priest"))
        //{
        //    //ButThreeisPressed = false;
        //    DataBank.ScreenNumber = DataBank.ScreenNumber + 2;
        //    //this.Refresh();
        //}

        //else if ((ButtonNumber == 4) && (DataBank.CharacterClass != "Mage"))
        //{
        //    //ButThreeisPressed = false;
        //    DataBank.ScreenNumber = DataBank.ScreenNumber + 1;
        //    //this.Refresh();
        //}         

        private void ToMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataBank.TraumaMainMenu.Show();
        }

        private void ChooseScreen_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
        }
    }

    }

       







    

    
    

