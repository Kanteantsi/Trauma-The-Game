using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Game
{
    static class DataBank
    {

        

        public static Form TraumaMainMenu = new TraumaMainMenu();
        public static Form StartScreen = new StartingScreen();

        public static Form SaveScreen = new SavesScreen();
        public static Form DeathScreen = new DeathScreen();
        public static DeathScreen DeathForm = new DeathScreen();

        public static Form SuccessScreen = new SuccessScreen();
        public static SuccessScreen SuccForm = new SuccessScreen();

        public static string CharNameBySlot1 = "Slot1";
        public static string CharNameBySlot2 = "Slot2";
        public static string CharNameBySlot3 = "Slot3";

       



        public static Form ChooseS_Screen = new ChooseScreen();


        public static bool HaveHorse;
        public static bool HaveGuard;
        public static bool HaveHeal;
        public static bool HavePartner;


        public static bool TavernVisited;
        public static bool HerbalistVisited;
        public static bool BlacksmithVisited;
     

        public static bool MusicOn = false;
        public static int ScreenNumber;
        public static int MaxScreenNumber;
        public static int Health;
        public static int Endurance;
        public static int Mana;
        public static int Prana;
        public static int Gold;
        public static string Horse;
        public static int Squad;
        public static int WeaponUpgrade;
        public static bool HaveCharacteristicRecovery;
        public static string CharacterClass;
        public static String CharSkill1;
        public static String CharSkill2;
        public static String CharSkill3;
        public static String CharSkill4;

        public static String DeathMessage;
        public static String SuccessMessage;

        public static string CheckCharSkills()
        {
            if (CharacterClass == "Warrior")
            {
                CharSkill1 = " Мощный удар щитом: (-2 ед выносливости)";
                CharSkill2 = " Рассекающий удар: Убрав щит, размашистым ударом топора, воин наносит 10 единиц урона первым ударом, и 15 единиц урона вторым.  (-3 ед выносливости)";
                CharSkill3 = " Казнь: Впадая в ярость, сильнейшим ударом в голову, воин наносит 30 единиц урона (-4 ед выносливости) ";
                CharSkill4 = " Вихрь клинков: Схватившись двумя руками за топор, воин начинает кружится пока не нанесет 20 единиц урона.  (-5 ед выносливости)";
                return CharacterClass;
            }
            else if (CharacterClass == "Thief")
            {
                CharSkill1 = " Удар в спину: Вор забегает за спину противнику и вонзает в него кинжал, нанося 20 единиц урона  (-2 ед характеристики)";
                CharSkill2 = " Грязные приемы: Бросая пыль в глаза противнику, вор сбивает противника с ног, нанося 5 единиц урона и вонзает в него кинжал, который наносит еще 20 единиц урона. (-3 ед характеристики)";
                CharSkill3 = " Веер клинков: Отпрыгнув от врага, вор метает в него 6 кинжалов. Каждый из кинжалов наносит по 5 единиц урона. (-4 ед характеристики)";
                CharSkill4 = " Отравленные клинки: Вор отравляет клинки и бросает их в противника, нанося 10 единиц урона, а после яд наносит еще 15 единиц урона.  (-5 ед характеристики)";
                return CharacterClass;
            }
            else if (CharacterClass == "Mage")
            {
                CharSkill1 = " Чародейские стрелы: Ударив посохом о землю, маг вызывает 3 чародейские стрелы, которые наносят 15 единиц урона  (-2 ед характеристики)";
                CharSkill2 = " Огненный шар: Сконцентрировавшись, маг наносит 20 единиц урона огненным шаром и поджигает противника, нанеся еще 5 единиц урона. (-3 ед характеристики)  (-3 ед выносливости)";
                CharSkill3 = " Ледяная стрела: Маг выпускает на противника огромную ледяную стрелу, которая впивается в тело противника и наносит 30 единиц урона  (-4 ед характеристики) ";
                CharSkill4 = " Морозный луч: Направив посох на противника, маг выпускает морозный луч, который наносит 20 единиц урона и замедляет врага. (-5 ед характеристики)";
                return CharacterClass;
            }

            else if (CharacterClass == "Priest")
            {
                CharSkill1 = " Кара божья: Жрец испускает на противника 4 световых луча, наносящих по 4 единиц урона.  (-2 ед характеристики)";
                CharSkill2 = " Рябь света: Жрец окутывает себя световым куполом, который взрывается 2 раза, нанося после каждого взрыва по 12 единиц урона.   (-3 ед характеристики)";
                CharSkill3 = " Контроль над разумом: Жрец получает контроль над разумом противника, заставляя того вонзить в себя собственное оружие, нанося при этом 30 единиц урона.  (-4 ед характеристики)";
                CharSkill4 = " Порождение света: Молитвой жрец взывает о помощи, призывая порождение света, которое атакует противника и наносит ему 20 единиц урона.  (-5 ед характеристики)";
                return CharacterClass;
            }
            else return "Ошибка";
        }
        public static void InitializeCharacters()
        {

        }
        public static string TextButtonVariant1;
        public static string TextButtonVariant2;
        public static string TextButtonVariant3;
        public static string TextButtonVariant4;
        public static string QuestionThatPushesTheQuest;
        public static string TextDeathMessage;


        public static void ShowScreenInfo()
        {
            //ScreenNumber = 0;

            switch (ScreenNumber)
            {
                //Первый квест - зачарованный щит

                case 1:
                    ScreenNumber = 1;
                    QuestionThatPushesTheQuest = "Ваш отец оставил вам некоторое наследство, и поручил, дабы не посрамить честь рода, найти один из древних артефактов.  Подкупив некоторые источники, вы получили сведения о нескольких из них. Первый — искусный щит гномьего, уже забытого мастерства, из особенно редкого сплава, способный отражать некоторые заклинания.  Второй — топор, принадлежавший вожду одного из орочьих племён, способный пробивать любые доспехи, ломать шлемы, крушить в щепки щиты.  Третий — лук эльфов, который проявляет истинную силу лишь в руках одного из их рода, но при должной магической корректировке,  существо любой расы сможет владеть им, и пускать магические стрелы, не тратя на то энергии. Четвёртый — перчатки, увеличивающие физическую силу владельца многократно, до того, что он способен разорвать нападающего быка напополам. За чем вы отправились?";
                    TextButtonVariant1 = " За гномьим щитом";
                    TextButtonVariant2 = " За орочьим топором ";
                    TextButtonVariant3 = " За эльфийским луком ";
                    TextButtonVariant4 = " За зачарованными перчатками";

                    break;
                case 2:
                    ScreenNumber = 2;

                    QuestionThatPushesTheQuest = "Итак, путешествие предстояло быть долгим. Путь проходил через густой лес, заполненный кровожадными тварями и разбойниками, по течению реки необходимо было найти город, взять припасы, и уйдя в глубь пещер, попасть в гробницу. Вы наняли провожатого через лес, и могли взять из банка определённую сумму на расходы.Сколько вы взяли?";
                    TextButtonVariant1 = "500";
                    TextButtonVariant2 = "1000";
                    TextButtonVariant3 = " 1500";
                    TextButtonVariant4 = " 2000";
                    break;
                case 3:
                    ScreenNumber = 3;
                    QuestionThatPushesTheQuest = "Вы заплатили провожатому 250 монет и можете нанять сопровождение.Сколько людей вы наймёте?";
                    TextButtonVariant1 = " Один человек(200 монет)";
                    TextButtonVariant2 = " Два человека (400 монет)";
                    TextButtonVariant3 = " Три человека(600 монет) ";
                    TextButtonVariant4 = " Четыре человека (800 монет)";
                    break;
                case 4:
                    ScreenNumber = 4;
                    QuestionThatPushesTheQuest = "Вы заплатили провожатому 250 монет, и было необходимо арендовать лошадей. Так как на оставшуюся сумму вы не смогли нанять охрану, через лес вам предстояло идти вдвоём. В конюшне на выбор было несколько коней — Вихрь, что являлся самым быстрым, но трусливым; Верный, что самый медленный, но остаётся с владельцем до конца; Дымка, что не самый медленный, и не самый трусливый; Рыжий, что не самый медленный, и не самый трусливый; Какого коня вы взяли? ";
                    TextButtonVariant1 = " Вихрь";
                    TextButtonVariant2 = " Верный";
                    TextButtonVariant3 = " Дымка ";
                    TextButtonVariant4 = " Рыжий";
                    break;
                case 5:
                    QuestionThatPushesTheQuest = "Вы едете верхом, по направлению к лесу. Въехав, и пройдя некоторое расстояние, вы обнаруживаете дерево. Вы можете: попытаться перелезть, сломать, помолиться, сжечь заклинанием.Что вы сделаете ?";
                    TextButtonVariant1 = " Перелезть";
                    TextButtonVariant2 = " Сломать";
                    TextButtonVariant3 = " Помолиться ";
                    TextButtonVariant4 = " Сжечь заклинанием";
                    break;
                case 8:
                    DeathMessage = " Вы погибли в неравной битве. Никто никогда не вспомнит о вас, и ваши тела так и не будут найдены, разодранные дикими зверями.";
                    break;
                case 9:
                    QuestionThatPushesTheQuest = " Вы одержали победу в неравной битве! Наконец,выбравшись из леса к берегу реки, вам необходимо было переправиться на другую сторону. Каким образом вы будете это делать? ";
                    TextButtonVariant1 = " Искать лодку";
                    TextButtonVariant2 = " Ждать рыбаков";
                    TextButtonVariant3 = " Срубить дерево и сделать плот ";
                    TextButtonVariant4 = " Искать дома рыбаков, чтобы купить лодку";
                    break;
                case 10:
                    QuestionThatPushesTheQuest = "Вы успешно перебрались на другой берег. Теперь нам нужно найти город, чтобы взять припасы. Куда мы пойдём?";
                    TextButtonVariant1 = " На север";
                    TextButtonVariant2 = " На восток";
                    TextButtonVariant3 = " На запад ";
                    TextButtonVariant4 = " На юг";
                    break;
                case 11:
                    QuestionThatPushesTheQuest = "Вы находите кузницу. Кузнец готов улучшить ваше оружие за плату. Кузнец также продаёт вам одну из улучшенных им лодок. На сколько вы улучшите его? После улучшения вы переправитесь на другой берег.";
                    TextButtonVariant1 = " 50 монет(+5 урона)";
                    TextButtonVariant2 = " 100 монет(+10 урона)";
                    TextButtonVariant3 = " 200 монет(+20 урона) ";
                    TextButtonVariant4 = " 500 монет(+50 урона)";
                    break;
                case 12:
                    QuestionThatPushesTheQuest = "Спустя несколько часов упорных поисков, вы попадаете в город. Есть возможность купить снаряжение(припасы, зелья). Что вы купите?";
                    TextButtonVariant1 = " Только припасы(20 монет)";
                    TextButtonVariant2 = " Зелье восстановления здоровья и припасы(70 монет)";
                    TextButtonVariant3 = " Зелье восстановления маны и припасы  (70 монет) ";
                    TextButtonVariant4 = " Амулет, восполняющий прану и припасы (70 монет)";
                    break;
                case 13:
                    QuestionThatPushesTheQuest = "Вы взяли необходимое, и направляетесь в сторону горных вершин. Привязав коней, вы начинаете забираться наверх. Наконец, вы попадаете в пещеру. Пройдя глубже, вы обнаруживаете развилку. По какому коридору пойдёте?";
                    TextButtonVariant1 = " Крайний левый";
                    TextButtonVariant2 = " Центральный левый";
                    TextButtonVariant3 = " Центральный правый ";
                    TextButtonVariant4 = " Крайний правый";
                    break;
                case 14:
                    QuestionThatPushesTheQuest = "Вы вступаете в бой с горными троллями. Сражайтесь за свою жизнь!";
                    break;
                case 15:
                    DeathMessage = "К сожалению, ваша попытка разгромить троллей окончилась неудачей. Ваши тела были смяты в труху, и будут с удовольствием съедены монстрами.";
                    break;
                case 16:
                    QuestionThatPushesTheQuest = "Вы победили троллей и идёте дальше. Из-за вашей битвы  потолок начинается обваливаться, нужно двигаться быстрее.Вы натыкаетесь на ещё одну развилку. Куда пойдёте?";
                    TextButtonVariant1 = " Крайний левый";
                    TextButtonVariant2 = " Центральный левый";
                    TextButtonVariant3 = " Центральный правый ";
                    TextButtonVariant4 = " Крайний правый";
                    break;
                case 17:
                    DeathMessage = "Выбранный вами коридор оканчивался тупиком. Потолок пещеры обвалился, и вы были намертво раздавлены. Ваши тела никогда не будут найдены.";
                    break;
                case 18:
                    QuestionThatPushesTheQuest = "Вы проходите в заброшенный зал и видите множество скелетов, сидящих за столом. Виднеется проход дальше. Внезапно, скелеты встают, и начинается бой.";
                    break;
                case 19:
                    DeathMessage = "Получив множественные ранения, и не сумев уничтожить ожившую нечисть, вы погибли в неравной битве со скелетами. Вы пополните армию, охраняющую великий щит.";
                    break;
                case 20:
                    QuestionThatPushesTheQuest = "Вы проходите дальше. Перед вами гробница павшего короля гномов и его слуг. На стене висит зачарованный гномий щит мастерской работы  - цель вашего путешествия. Зажигается свет. Скелеты уже давно умерших гномов обрастают прогнившей плотью, правитель Гнарл берёт своё оружие, и стучит мечом о щит, как бы призывая вас к бою, жадно щёлкая зубами и смотря ледяными глазами насквозь. Начинается битва.";
                    break;
                case 21:
                    DeathMessage = "Вы погибли, дойдя почти до самого конца, не сумев одолеть короля и его свиту, и теперь пополните армию, охраняющую артефакт. Крайне печальный исход.";
                    break;
                case 22:
                    DeathMessage = "Все ваши заклинания успешно отражены королём, и они убивают ваших спутников. Вы в ужасе пятитесь назад и пытаетесь сбежать. Однако ожившие трупы хватают и держат вас. Гнарл медленно подходит и заносит свой меч. Вы закрываете глаза. Ваша отрубленная голова катится вниз. Вы мертвы.";
                    break;
                case 23:
                    DeathMessage = "Вы успешно одолеваете всех врагов, и берёте артефакт в свои руки. Гордо подняв его над головой, вы потрясаете им, примеряя себе. Вы оборачиваетесь, и смотрите на своих спутников, ожидая одобрения. Внезапно, вы замечаете блеск жадности в их глазах, и вступаете в бой. К сожалению, вам не удаётся победить. Ваше мёртвое тело навсегда останется в этом зале, а ваша награда теперь в чужих руках.";
                    break;
                case 24:
                    SuccessMessage = "Вы успешно забираете щит, и сокровища, возвращаясь домой.Поздравляем!";
                    break;

                //Второй квест - Орочий топор
                case 25:
                    QuestionThatPushesTheQuest = "Итак, путешествие предстояло быть долгим. Путь проходил через крутую реку, ведущую в море, кишашее кровожадными тварями и пиратами, затем необходимо было найти лагерь орков и сразиться с их главарём за право обладания артефактом.Вы могли взять из банка определённую сумму на расходы.Сколько вы взяли ?";
                    TextButtonVariant1 = "500";
                    TextButtonVariant2 = "1000";
                    TextButtonVariant3 = " 1500";
                    TextButtonVariant4 = " 2000";
                    break;
                case 26:
                    QuestionThatPushesTheQuest = "  Вы покупаете самую простую лодку, и садитесь в неё. Вас подхватывает течение, и вы быстро движетесь, покидая город.Взяв в руки весла, вы собираетесь начать контролировать направление. Куда вы двинетеь ? ";
                    TextButtonVariant1 = "Налево";
                    TextButtonVariant2 = "Поддадитесь течению";
                    TextButtonVariant3 = "Прямо";
                    TextButtonVariant4 = "Направо";
                    break;
                case 27:
                    QuestionThatPushesTheQuest = "  Вы повернули налево, и лодка ускорилась. Вы выплываете участок реки, делящийся на 4 части. Куда поплывете? ";
                    TextButtonVariant1 = "Крайний левый";
                    TextButtonVariant2 = "Центральный левый";
                    TextButtonVariant3 = "Центральный правый";
                    TextButtonVariant4 = "Крайний правый";
                    break;
                case 28:
                    DeathMessage = " Выбранная вами развилка оканчивается водопадом.Вы разбиваетесь, так как не обладаете навыками спуска.";
                    break;
                case 29:
                    QuestionThatPushesTheQuest = "  Вы повернули направо, и лодка ускорилась. Вы выплываете участок реки, делящийся на 4 части. Куда поплывете? ";
                    TextButtonVariant1 = "Крайний левый";
                    TextButtonVariant2 = "Центральный левый";
                    TextButtonVariant3 = "Центральный правый";
                    TextButtonVariant4 = "Крайний правый";
                    break;
                case 30:
                    DeathMessage = "Дно выбранной вами развилки полно множеством камней. Ваша лодка разбивается, и вы начинаете тонуть. Речные духи тянут вас вниз, не давая шанс выжить.";
                    break;
                case 31:
                    QuestionThatPushesTheQuest = " Вас выносит в открытое море. На лодчонке вы будете долго добираться до цели. Что предпримете? ";
                    TextButtonVariant1 = "Налечь на вёсла, чтобы ускориться";
                    TextButtonVariant2 = "Возвращаться с целью поиска другого маршрута";
                    TextButtonVariant3 = "Ждать проплывающих кораблей";
                    TextButtonVariant4 = "Лечь спать";
                    break;
                case 32:
                    //бой с сиренами 
                    break;
                case 33:
                    //смерть от сирен
                    break;
                case 34:
                    QuestionThatPushesTheQuest = " Вас подбирает корабль, идущий мимо нужного острова. Вас высадят на нём. Вы должны отработать своё право нахождения на корабле. Что будете делать? ";
                    TextButtonVariant1 = "Мыть палубу";
                    TextButtonVariant2 = "Чистить пушки";
                    TextButtonVariant3 = "Помогать вести учёт вещей";
                    TextButtonVariant4 = "Подготавливать запасные паруса";
                    break;
                case 35:
                    QuestionThatPushesTheQuest = "Вы покупаете себе право плыть на корабле, он высадит вас на нужном острове. Как будете проводить время? ";
                    TextButtonVariant1 = "Проверите пушки";
                    TextButtonVariant2 = "Проверите паруса";
                    TextButtonVariant3 = "Проверите маршрут";
                    TextButtonVariant4 = "Уйдёте спать на своё место";
                    break;
                case 36:
                    //Нападает чудовище
                    break;
                case 37:
                    //смерть от чудовища
                    break;
                case 38:
                    //попал на остров
                    break;
                case 39:
                    QuestionThatPushesTheQuest = "Спустя некоторое время, как вы идёте, углубляясь в пустыню, вы чувствуете как ваш рассудок мутнеет. Вы видите какое-то строение на горизонте. Пойдёте ли вы к нему?";
                    TextButtonVariant1 = "Да";
                    TextButtonVariant2 = "Нет";
                    break;
                case 40:
                    //На вас нападает гигансткий скорпион
                    break;
                case 41:
                //смерть от скорпиона
                case 42:
                    //перед боем с вождём орков
                    TextButtonVariant1 = "Выпить воды";
                    TextButtonVariant2 = "Поесть";
                    TextButtonVariant3 = "Медитировать";
                    TextButtonVariant4 = "Выспаться";
                    break;
                case 43:
                    DeathMessage = "Ваши атаки только злят вождя орков. Он подбегает, хватает вас, и ломаёт рёбра мощными ударами. Затем, ударом топора он срубает вашу голову. Вы мертвы.";
                    break;
                case 44:
                    DeathMessage = "Ваши атаки только злят вождя орков. Он подбегает, хватает вас, и ломаёт рёбра мощными ударами. Затем, ударом топора он срубает вашу голову. Вы мертвы.";
                    break;
                case 45:
                    DeathMessage = "Ваши атаки только злят вождя орков. Он подбегает, хватает вас, и ломаёт рёбра мощными ударами. Затем, ударом топора он срубает вашу голову. Вы мертвы.";
                    break;
                case 46:
                    DeathMessage = "Ваши атаки только злят вождя орков. Он подбегает, хватает вас, и ломаёт рёбра мощными ударами. Затем, ударом топора он срубает вашу голову. Вы мертвы.";
                    break;
                case 47:
                    DeathMessage = "Ваши атаки только злят вождя орков. Он подбегает, хватает вас, и ломаёт рёбра мощными ударами. Затем, ударом топора он срубает вашу голову. Вы мертвы.";
                    break;
                case 48:
                    SuccessMessage = "Проведя успешную серию атак, вам удаётся победить вождя орков.";
                    break;
                case 49:
                    QuestionThatPushesTheQuest = "Вам предстояло долгое путешествие.Большая часть информации о перчатках была давно утеряна, немногое из того, что удалось узнать, это то, что они были спрятаны далеко на севере, в тайге, и находятся под охраной какой-то неизвестной силы.Перед тем как отправиться в путь вы решили прихватить с собой монет. Сколько вы возьмете?";
                    TextButtonVariant1 = "500";
                    TextButtonVariant2 = "1000";
                    TextButtonVariant3 = "2000";
                    TextButtonVariant4 = "5000";
                    break;

                //Третий квест - композитный эльфийский зачарованный лук

                //case 69:
                //    ScreenNumber = 69;
                //    QuestionThatPushesTheQuest = "Облачившись в привычную экипировку и прихватив отцовскую карту, вы отправились попытать удачу в поисках древнего эльфийского артефакта – композитного лука искусной работы, наделенного магическим потенциалом. Охота за таким трофеем, разумеется, обещала быть крайне сложным и бросающим вызов предприятием, но ваш энтузиазм и жажда приключений с лихвой покрывали недостаток опыта и качественного снаряжения. Путь предстоял неблизкий – согласно сведениям карты, легендам и пьяным разговорам в тавернах, лук был затерян в разрушенном городе эльфов, история падения которого уходит глубоко во тьму далеких, давно забытых веков, и потому никому до конца неизвестна. Вам нужна лошадь. Какую выберете? ";
                //    TextButtonVariant1 = " Вихрь";
                //    TextButtonVariant2 = " Верный";
                //    TextButtonVariant3 = " Дымка ";
                //    TextButtonVariant4 = " Рыжий";
                //    break;
                //case 70:
                //    ScreenNumber = 70;
                //    QuestionThatPushesTheQuest = "Вы выбрали лошадь. Расположен тот город в долине меж острых горных хребтов и заснеженных перевалов. Долине, которую местные считают проклятой и обходят стороной. Но у вас такого выбора нет, так что, добравшись до ближайшей к вашей цели деревни, вы сразу же направились в корчму искать авантюристов, готовых бросить вызов судьбе и сопроводить вас во мрак эльфийских руин. К счастью, вы находите выпивоху-завсегдатая, согласного за бутылку крепкого вина и совместное возлияние пары пинт эля отправиться с вами хоть к черту на рога. Его вы и нанимаете, и рано утром выезжаете навстречу тайнам древности. Куда поедете? ";
                //    TextButtonVariant1 = " На север";
                //    TextButtonVariant2 = " На восток";
                //    TextButtonVariant3 = " На запад ";
                //    TextButtonVariant4 = " На юг";
                //    break;

            }
        }

        public static bool IsDead1 = false;
        public static bool IsDead2 = false;
        public static void DiedGoToDefault()
        {
            if (IsDead1 == true)
            {
                IsDead1 = false;
            }
            IsDead2 = true;
            TextButtonVariant1 = " ";
            TextButtonVariant2 = " ";
            TextButtonVariant3 = " ";
            TextButtonVariant4 = " ";
            QuestionThatPushesTheQuest = " ";
            TextDeathMessage = " ";
            SuccessMessage = " ";
            CharNameBySlot1 = "Slot1";
            Health = 0;
            Endurance = 0;
            Mana = 0 ;
            Prana = 0;
            Gold = 0;
            Horse = " ";
            Squad = 0;
            WeaponUpgrade = 0;
            HaveCharacteristicRecovery = false;
            CharacterClass =" ";
            CharSkill1 = " ";
            CharSkill2 = " ";
            CharSkill3 = " ";
            CharSkill4 = " ";
            ScreenNumber = 1;
        }
        
    }
}