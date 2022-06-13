using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    
    static class Program
    {

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TraumaMainMenu());
            
        }
        public static Character Char1 = new Character();
        public static Character Char2 = new Character();
        public static Character Char3 = new Character();
        public static Character CurrentCharacter = new Character();

        public class Character

        {
            private int strength_;

            public int GetStrength_()
            {
                return strength_;
            }

            public void SetStrength_(int value)
            {
                strength_ = value;
            }

            private int agility_;

            public int GetAgility_()
            {
                return agility_;
            }

            public void SetAgility_(int value)
            {
                agility_ = value;
            }

            private int intellegence_;

            public int GetIntellegence_()
            {
                return intellegence_;
            }

            public void SetIntellegence_(int value)
            {
                intellegence_ = value;
            }

            private int endurance_;

            public int GetEndurance_()
            {
                return endurance_;
            }

            public void SetEndurance_(int value)
            {
                endurance_ = value;
            }

            private int faith_;

            public int GetFaith_()
            {
                return faith_;
            }

            public void SetFaith_(int value)
            {
                faith_ = value;
            }

            private int prana_;

            public int GetPrana_()
            {
                return prana_;
            }

            public void SetPrana_(int value)
            {
                prana_ = value;
            }

            private int screensPassedCounter_;

            public int GetScreensPassedCounter_()
            {
                return screensPassedCounter_;
            }

            public void SetScreensPassedCounter_(int value)
            {
                screensPassedCounter_ = value;
            }

            private string name_;

            public string GetName_()
            {
                return name_;
            }

            public void SetName_(string value)
            {
                name_ = value;
            }

            private string origin_;

            public string GetOrigin_()
            {
                return origin_;
            }

            public void SetOrigin_(string value)
            {
                origin_ = value;
            }

            private int luck_;

            public string GetLuck_()
            {
                return origin_;
            }

            public void SetLuck_(int value)
            {
                luck_ = value;
            }

            public Character()
            {
                this.SetStrength_(0);
                this.SetAgility_(0);
                this.SetIntellegence_(0);
                this.SetEndurance_(0);
                this.SetFaith_(0);
                this.SetPrana_(0);
                this.SetLuck_(0);
                this.SetScreensPassedCounter_(0);
                this.SetName_(" ");
                this.SetOrigin_(" ");
            }
        }
        
    }

   
}