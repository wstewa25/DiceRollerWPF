using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SkyrimRandomCharacterGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private int RollRandom(int start, int end)
        {
            Random rnd = new Random();
            return rnd.Next(start, end);
        }

        private String RollMainSkillType()
        {
            int typeNum = RollRandom(1, 3);
            String skillType;

            if (typeNum == 1)
                skillType = "physical";
            else
                skillType = "magical";

            return skillType;
        }

        private int RollSkillNum(String skillType)
        {
            int skillNum;
            if (skillType == "physical")
            {
                skillNum = RollRandom(1, 5);
            }
            else
            {
                skillNum = RollRandom(5, 10);
            }
            return skillNum;
        }


        //Logic for Selecting Between different skill specializations in main skill
        private String RollOneHanded(int weaponType, bool dual)
        {
            String mainSkill;
            switch (weaponType)
            {
                case 1:
                    if (dual == true)
                        mainSkill = "One Handed - Dual Swords";
                    else
                        mainSkill = "One Handed - Sword And Shield";
                    return mainSkill;
                case 2:
                    if (dual == true)
                        mainSkill = "One Handed - Dual Axes";
                    else
                        mainSkill = "One Handed - Axe And Shield";
                    return mainSkill;
                case 3:
                    if (dual == true)
                        mainSkill = "One Handed - Dual Maces";
                    else
                        mainSkill = "One Handed - Mace And Shield";
                    return mainSkill;
                case 4:
                    mainSkill = "One Handed - Daggers";
                    return mainSkill;
                default:
                    Console.WriteLine("Error, rolled more than 4 weapon types One handed");
                    break;
            }
            return "Error, One handed case not handled";
        }
        private String RollTwoHanded(int weaponType)
        {
            String mainSkill;
            switch (weaponType)
            {
                case 1:
                    mainSkill = "Two Handed - Greatsword";
                    return mainSkill;
                case 2:
                    mainSkill = "Two Handed - Battleaxe";
                    return mainSkill;
                case 3:
                    mainSkill = "Two Handed - Warhammer";
                    return mainSkill;
                default:
                    Console.WriteLine("Error, rolled more than 3 weapon types on Two Handed");
                    break;
            }
            return "Error, Two handed case not handled";
        }

        //Select the main skill
        private String SelectSkill(int skillNum)
        {
            String mainSkill;
            int weaponType;
            switch (skillNum)
            {
                case 1: //One Handed
                    bool dual = false;
                    int dualWield = RollRandom(1, 3);
                    if (dualWield == 1)
                        dual = true;
                    if (dual == true) //If dual weild is true, daggers are an option so roll up to 4 instead of 3
                        weaponType = RollRandom(1, 5);
                    else
                        weaponType = RollRandom(1, 4);
                    mainSkill = RollOneHanded(weaponType, dual);
                    return mainSkill;

                case 2: //Two handed
                    weaponType = RollRandom(1, 4);
                    mainSkill = RollTwoHanded(weaponType);
                    return mainSkill;

                case 3: //Sneak
                    break;
                case 4: //Archery
                    break;
                case 5: //Illusion
                    break;
                case 6: //Conjuration
                    break;
                case 7: //Destruction
                    break;
                case 8: //Restoration
                    break;
                case 9: //Alteration
                    break;
                default:
                    Console.WriteLine("Error, rolled more than a 9");
                    break;
            }
            return "Error, main skill not handled";
        }

        private String RollMainSkill()
        {
            String skillType = RollMainSkillType();
            int skillNum = RollSkillNum(skillType);
            String result = SelectSkill(skillNum);

            return result;
        }

        private void GenerateCharacter(object sender, RoutedEventArgs e)
        {
            String mainSkill = RollMainSkill();
            MainSkillTextBox.Text = "Main Skill: " + mainSkill;


        }
    }
}
