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

        List<string> MainSkillList = new List<string>();
        List<string> SecondarySkillList = new List<string>();
        string[] SecondarySkills = new string[5];



        private int RollRandom(int start, int end)
        {
            Random rnd = new Random();
            return rnd.Next(start, end);
        }

        private void GenerateRace()
        {
            string[] races = new string[] { "Argonian", "Breton", "Dark Elf", "High Elf", "Imperial", "Khajiit", "Nord", "Orc", "Redguard", "Wood Elf" };
            int raceNum = RollRandom(0, races.Length);
            RaceTextBox.Text = "Race: " + races[raceNum];
        }
        private void GenerateGender()
        {
            int gender = RollRandom(1, 3);
            if (gender == 1)
                GenderTextBox.Text = "Gender: Male";
            else
                GenderTextBox.Text = "Gender: Female";
        }
        private void GenerateAlignment()
        {
            string[] alignments = new string[] { "Lawful Good", "Lawful Neutral", "Lawful Evil", "Neutral Good", "True Neutral", "Neutral Evil", "Chaotic Good", "Chaotic Neutral", "Chaotic Evil" };
            int alignmentNum = RollRandom(0, alignments.Length);
            AlignmentTextBox.Text = "Alignment: " + alignments[alignmentNum];
        }
        private void GeneratePersonality()
        {
            string[] personalities = new string[] { "INTJ", "INTP", "ENTJ", "ENTP", "INFJ", "ENFJ", "INFP", "ENFP", "ISTJ", "ISFJ", "ESTJ", "ESFJ", "ISTP", "ESTP", "ISFP", "ESFP" };
            int personalityNum = RollRandom(0, personalities.Length);
            PeronalityTextBox.Text = "Peronality Type: " + personalities[personalityNum];
        }

        private void PopulateMainSkills()
        {
            MainSkillList.Add("One Handed");
            MainSkillList.Add("Two Handed");
            MainSkillList.Add("Archery");
            MainSkillList.Add("Illusion");
            MainSkillList.Add("Conjuration");
            MainSkillList.Add("Destruction");
            MainSkillList.Add("Restoration");
            MainSkillList.Add("Alteration");
            AddRaceBias();
        }
        private void AddRaceBias()
        {
            if (RaceTextBox.Text == "Race: Argonian")
            {
                MainSkillList.Add("Restoration");
                MainSkillList.Add("Alteration");
                SecondarySkillList.Add("Lockpicking");
                SecondarySkillList.Add("Lockpicking");
                SecondarySkillList.Add("Sneak");
                SecondarySkillList.Add("Pickpocket");
                SecondarySkillList.Add("Light Armor");
                MainSkillList.Add("Restoration");
                MainSkillList.Add("Alteration");
                SecondarySkillList.Add("Lockpicking");
                SecondarySkillList.Add("Lockpicking");
                SecondarySkillList.Add("Sneak");
                SecondarySkillList.Add("Pickpocket");
                SecondarySkillList.Add("Light Armor");
            }
            else if (RaceTextBox.Text == "Race: Breton")
            {
                MainSkillList.Add("Conjuration");
                MainSkillList.Add("Conjuration");
                MainSkillList.Add("Illusion");
                MainSkillList.Add("Restoration");
                MainSkillList.Add("Alteration");
                SecondarySkillList.Add("Speech");
                SecondarySkillList.Add("Alchemy");
                MainSkillList.Add("Conjuration");
                MainSkillList.Add("Conjuration");
                MainSkillList.Add("Illusion");
                MainSkillList.Add("Restoration");
                MainSkillList.Add("Alteration");
                SecondarySkillList.Add("Speech");
                SecondarySkillList.Add("Alchemy");
                MainSkillList.Add("Conjuration");
                MainSkillList.Add("Conjuration");
                MainSkillList.Add("Illusion");
                MainSkillList.Add("Restoration");
                MainSkillList.Add("Alteration");
                SecondarySkillList.Add("Speech");
                SecondarySkillList.Add("Alchemy");
                MainSkillList.Add("Conjuration");
                MainSkillList.Add("Conjuration");
                MainSkillList.Add("Illusion");
                MainSkillList.Add("Restoration");
                MainSkillList.Add("Alteration");
                SecondarySkillList.Add("Speech");
                SecondarySkillList.Add("Alchemy");
            }
            else if (RaceTextBox.Text == "Race: Dark Elf")
            {
                MainSkillList.Add("Illusion");
                MainSkillList.Add("Destruction");
                MainSkillList.Add("Destruction");
                MainSkillList.Add("Alteration");
                SecondarySkillList.Add("Light Armor");
                SecondarySkillList.Add("Sneak");
                SecondarySkillList.Add("Alchemy");
                MainSkillList.Add("Illusion");
                MainSkillList.Add("Destruction");
                MainSkillList.Add("Destruction");
                MainSkillList.Add("Alteration");
                SecondarySkillList.Add("Light Armor");
                SecondarySkillList.Add("Sneak");
                SecondarySkillList.Add("Alchemy");
                MainSkillList.Add("Illusion");
                MainSkillList.Add("Destruction");
                MainSkillList.Add("Destruction");
                MainSkillList.Add("Alteration");
                SecondarySkillList.Add("Light Armor");
                SecondarySkillList.Add("Sneak");
                SecondarySkillList.Add("Alchemy");

            }
            else if (RaceTextBox.Text == "Race: High Elf")
            {
                MainSkillList.Add("Illusion");
                MainSkillList.Add("Illusion");
                MainSkillList.Add("Conjuration");
                MainSkillList.Add("Destruction");
                MainSkillList.Add("Restoration");
                MainSkillList.Add("Alteration");
                SecondarySkillList.Add("Enchanting");
                MainSkillList.Add("Illusion");
                MainSkillList.Add("Illusion");
                MainSkillList.Add("Conjuration");
                MainSkillList.Add("Destruction");
                MainSkillList.Add("Restoration");
                MainSkillList.Add("Alteration");
                SecondarySkillList.Add("Enchanting");
                MainSkillList.Add("Illusion");
                MainSkillList.Add("Illusion");
                MainSkillList.Add("Conjuration");
                MainSkillList.Add("Destruction");
                MainSkillList.Add("Restoration");
                MainSkillList.Add("Alteration");
                SecondarySkillList.Add("Enchanting");
                MainSkillList.Add("Illusion");
                MainSkillList.Add("Illusion");
                MainSkillList.Add("Conjuration");
                MainSkillList.Add("Destruction");
                MainSkillList.Add("Restoration");
                MainSkillList.Add("Alteration");
                SecondarySkillList.Add("Enchanting");
            }
            else if (RaceTextBox.Text == "Race: Imperial")
            {
                MainSkillList.Add("One Handed");
                MainSkillList.Add("Restoration");
                MainSkillList.Add("Restoration");
                MainSkillList.Add("Destruction");
                SecondarySkillList.Add("Block");
                SecondarySkillList.Add("Heavy Armor");
                SecondarySkillList.Add("Enchanting");
                MainSkillList.Add("One Handed");
                MainSkillList.Add("Restoration");
                MainSkillList.Add("Restoration");
                MainSkillList.Add("Destruction");
                SecondarySkillList.Add("Block");
                SecondarySkillList.Add("Heavy Armor");
                SecondarySkillList.Add("Enchanting");
            }
            else if (RaceTextBox.Text == "Race: Khajiit")
            {
                MainSkillList.Add("One Handed");
                MainSkillList.Add("Archery");
                SecondarySkillList.Add("Sneak");
                SecondarySkillList.Add("Sneak");
                SecondarySkillList.Add("Lockpicking");
                SecondarySkillList.Add("Pickpocket");
                SecondarySkillList.Add("Alchemy");
                MainSkillList.Add("One Handed");
                MainSkillList.Add("Archery");
                SecondarySkillList.Add("Sneak");
                SecondarySkillList.Add("Sneak");
                SecondarySkillList.Add("Lockpicking");
                SecondarySkillList.Add("Pickpocket");
                SecondarySkillList.Add("Alchemy");
                MainSkillList.Add("One Handed");
                MainSkillList.Add("Archery");
                SecondarySkillList.Add("Sneak");
                SecondarySkillList.Add("Sneak");
                SecondarySkillList.Add("Lockpicking");
                SecondarySkillList.Add("Pickpocket");
                SecondarySkillList.Add("Alchemy");
                MainSkillList.Add("One Handed");
                MainSkillList.Add("Archery");
                SecondarySkillList.Add("Sneak");
                SecondarySkillList.Add("Sneak");
                SecondarySkillList.Add("Lockpicking");
                SecondarySkillList.Add("Pickpocket");
                SecondarySkillList.Add("Alchemy");
            }
            else if (RaceTextBox.Text == "Race: Nord")
            {
                MainSkillList.Add("Two Handed");
                MainSkillList.Add("Two Handed");
                MainSkillList.Add("One Handed");
                SecondarySkillList.Add("Smithing");
                SecondarySkillList.Add("Block");
                SecondarySkillList.Add("Light Armor");
                SecondarySkillList.Add("Speech");
                MainSkillList.Add("Two Handed");
                MainSkillList.Add("Two Handed");
                MainSkillList.Add("One Handed");
                SecondarySkillList.Add("Smithing");
                SecondarySkillList.Add("Block");
                SecondarySkillList.Add("Light Armor");
                SecondarySkillList.Add("Speech");
                MainSkillList.Add("Two Handed");
                MainSkillList.Add("Two Handed");
                MainSkillList.Add("One Handed");
                SecondarySkillList.Add("Smithing");
                SecondarySkillList.Add("Block");
                SecondarySkillList.Add("Light Armor");
                SecondarySkillList.Add("Speech");
                MainSkillList.Add("Two Handed");
                MainSkillList.Add("Two Handed");
                MainSkillList.Add("One Handed");
                SecondarySkillList.Add("Smithing");
                SecondarySkillList.Add("Block");
                SecondarySkillList.Add("Light Armor");
                SecondarySkillList.Add("Speech");
            }
            else if (RaceTextBox.Text == "Race: Orc")
            {
                MainSkillList.Add("Two Handed");
                MainSkillList.Add("One Handed");
                SecondarySkillList.Add("Smithing");
                SecondarySkillList.Add("Heavy Armor");
                SecondarySkillList.Add("Heavy Armor");
                SecondarySkillList.Add("Block");
                SecondarySkillList.Add("Enchanting");
                MainSkillList.Add("Two Handed");
                MainSkillList.Add("One Handed");
                SecondarySkillList.Add("Smithing");
                SecondarySkillList.Add("Heavy Armor");
                SecondarySkillList.Add("Heavy Armor");
                SecondarySkillList.Add("Block");
                SecondarySkillList.Add("Enchanting");
                MainSkillList.Add("Two Handed");
                MainSkillList.Add("One Handed");
                SecondarySkillList.Add("Smithing");
                SecondarySkillList.Add("Heavy Armor");
                SecondarySkillList.Add("Heavy Armor");
                SecondarySkillList.Add("Block");
                SecondarySkillList.Add("Enchanting");
                MainSkillList.Add("Two Handed");
                MainSkillList.Add("One Handed");
                SecondarySkillList.Add("Smithing");
                SecondarySkillList.Add("Heavy Armor");
                SecondarySkillList.Add("Heavy Armor");
                SecondarySkillList.Add("Block");
                SecondarySkillList.Add("Enchanting");
                MainSkillList.Add("Two Handed");
                MainSkillList.Add("One Handed");
                SecondarySkillList.Add("Smithing");
                SecondarySkillList.Add("Heavy Armor");
                SecondarySkillList.Add("Heavy Armor");
                SecondarySkillList.Add("Block");
                SecondarySkillList.Add("Enchanting");
                MainSkillList.Add("Two Handed");
                MainSkillList.Add("One Handed");
                SecondarySkillList.Add("Smithing");
                SecondarySkillList.Add("Heavy Armor");
                SecondarySkillList.Add("Heavy Armor");
                SecondarySkillList.Add("Block");
                SecondarySkillList.Add("Enchanting");
            }
            else if (RaceTextBox.Text == "Race: Redguard")
            {
                MainSkillList.Add("One Handed");
                MainSkillList.Add("One Handed");
                MainSkillList.Add("Archery");
                MainSkillList.Add("Destruction");
                MainSkillList.Add("Alteration");
                SecondarySkillList.Add("Block");
                SecondarySkillList.Add("Smithing");
                MainSkillList.Add("One Handed");
                MainSkillList.Add("One Handed");
                MainSkillList.Add("Archery");
                MainSkillList.Add("Destruction");
                MainSkillList.Add("Alteration");
                SecondarySkillList.Add("Block");
                SecondarySkillList.Add("Smithing");
                MainSkillList.Add("One Handed");
                MainSkillList.Add("One Handed");
                MainSkillList.Add("Archery");
                MainSkillList.Add("Destruction");
                MainSkillList.Add("Alteration");
                SecondarySkillList.Add("Block");
                SecondarySkillList.Add("Smithing");

            }
            else if (RaceTextBox.Text == "Race: Wood Elf")
            {
                MainSkillList.Add("Archery");
                MainSkillList.Add("Archery");
                SecondarySkillList.Add("Light Armor");
                SecondarySkillList.Add("Sneak");
                SecondarySkillList.Add("LockPicking");
                SecondarySkillList.Add("Pickpocket");
                SecondarySkillList.Add("Alchemy");
                MainSkillList.Add("Archery");
                MainSkillList.Add("Archery");
                SecondarySkillList.Add("Light Armor");
                SecondarySkillList.Add("Sneak");
                SecondarySkillList.Add("LockPicking");
                SecondarySkillList.Add("Pickpocket");
                SecondarySkillList.Add("Alchemy");
                MainSkillList.Add("Archery");
                MainSkillList.Add("Archery");
                SecondarySkillList.Add("Light Armor");
                SecondarySkillList.Add("Sneak");
                SecondarySkillList.Add("LockPicking");
                SecondarySkillList.Add("Pickpocket");
                SecondarySkillList.Add("Alchemy");
                MainSkillList.Add("Archery");
                MainSkillList.Add("Archery");
                SecondarySkillList.Add("Light Armor");
                SecondarySkillList.Add("Sneak");
                SecondarySkillList.Add("LockPicking");
                SecondarySkillList.Add("Pickpocket");
                SecondarySkillList.Add("Alchemy");
            }
            else
            {
                Console.WriteLine("ERROR, Racial Bias not added!");
            }
        }
        private void GenerateMainSkill()
        {
            int mainSkillNum = RollRandom(0, MainSkillList.Count);
            string mainSkillRoll = MainSkillList[mainSkillNum];
            AddMainSkill(mainSkillRoll);
        }
        private void AddMainSkill(string mainSkillRoll)
        {
            string mainSkill = "";
            int roller;
            if (mainSkillRoll == "One Handed")
            {
                mainSkill = RollOneHanded();
            }
            else if (mainSkillRoll == "Two Handed")
            {
                roller = RollRandom(1, 4);
                if (roller == 1)
                    mainSkill = "Two Handed - Greatsword";
                if (roller == 2)
                    mainSkill = "Two Handed - BattleAxe";
                if (roller == 3)
                    mainSkill = "Two Handed - WarHammer";
            }
            else if (mainSkillRoll == "Archery")
            {
                roller = RollRandom(1, 3);
                if (roller == 1)
                    mainSkill = "Archery - Bow and Arrow";
                if (roller == 2)
                    mainSkill = "Archery - Crossbow";
            }
            else if (mainSkillRoll == "Conjuration")
            {
                mainSkill = RollConjuration();
            }
            else if (mainSkillRoll == "Illusion")
                mainSkill = "Illusion";
            else if (mainSkillRoll == "Destruction")
            {
                roller = RollRandom(1, 4);
                if (roller == 1)
                    mainSkill = "Destruction - Pyromancer";
                if (roller == 2)
                    mainSkill = "Destruction - Cryomancer";
                if (roller == 3)
                    mainSkill = "Destruction - Electromancer";
            }
            else if (mainSkillRoll == "Restoration")
            {
                roller = RollRandom(1, 4);
                if (roller == 1)
                    mainSkill = "Restoration - Warder";
                if (roller == 2)
                    mainSkill = "Restoration - Cleanser";
                if (roller == 3)
                    mainSkill = "Restoration - Blighter";
            }
            else if (mainSkillRoll == "Alteration")
                mainSkill = "Alteration";
            else
            {
                Console.WriteLine("Error, Main Skill Not Added!");
                mainSkill = "Error";
            }
            MainSkillTextBox.Text = "Main Skill: " + mainSkill;
        }

        private string RollOneHanded()
        {
            string weaponType;
            string ohType;
            MainSkillList.Clear();
            PopulateMainSkills();
            int roller = RollRandom(1, 4);
            if (roller == 1)
            {
                weaponType = RollOneHandedWeaponType();
                roller = RollRandom(1, 2);
                if (roller == 1)
                    ohType = "Dual " + weaponType + "s"; 
                else 
                {
                    string weaponType2 = RollOneHandedWeaponType();
                    ohType = "Dual " + weaponType + " and " + weaponType2;
                }
            }
            else 
            {
                roller = RollRandom(1, 3);
                if (roller == 1) 
                {
                    weaponType = RollOneHandedWeaponType();
                    ohType = weaponType + " and Shield";
                }
                else 
                {
                    while (MainSkillList.Contains("One Handed"))
                        MainSkillList.Remove("One Handed");
                    while (MainSkillList.Contains("Two Handed"))
                        MainSkillList.Remove("Two Handed");
                    while (MainSkillList.Contains("Archery"))
                        MainSkillList.Remove("Archery");
                    roller = RollRandom(0, MainSkillList.Count());
                    ohType = MainSkillList[roller] + " Spellsword";
                }
            }
            return "One Handed - " + ohType;
        }
        private string RollOneHandedWeaponType()
        {
            string weapon;
            int roller = RollRandom(1, 4);
            if (roller == 1)
                weapon = "Sword";
            else if (roller == 2)
                weapon = "Axe";
            else
                weapon = "Mace";
            return weapon;
        }

        private string RollConjuration()
        {
            string spiritWeapon;
            string magicType;
            int roller = RollRandom(1, 4);
            if (roller == 1)
                spiritWeapon = "Sword";
            else if (roller == 2)
                spiritWeapon = "BattleAxe";
            else
                spiritWeapon = "Bow";
            roller = RollRandom(1, 4);
            if (roller == 1)
                magicType = "Atronach Conjuration";
            else if (roller == 2)
                magicType = "Daedra Conjuration";
            else
                magicType = "Necro Conjuration";
            SpiritWeaponTextBox.Text = "Spirit Weapon: " + spiritWeapon;
            return "Conjuration - " + magicType;
        }

        private void GenerateCharacter(object sender, RoutedEventArgs e)
        {
            MainSkillList.Clear();
            SecondarySkillList.Clear();
            SpiritWeaponTextBox.Text = "";
            GenerateRace();
            GenerateGender();
            GenerateAlignment();
            GeneratePersonality();
            PopulateMainSkills();
            GenerateMainSkill();
        }
    }
}
