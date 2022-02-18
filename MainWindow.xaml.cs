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
        List<string> ChosenSecondarySkills = new List<string>();
        List<string> ArmorType = new List<string>();

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
            AddRaceBias();
        }
        private void AddRaceBias()
        {
            if (RaceTextBox.Text == "Race: Argonian")
            {
                MainSkillList.Add("Restoration");
                SecondarySkillList.Add("Alteration");
                SecondarySkillList.Add("Lockpick");
                SecondarySkillList.Add("Lockpick");
                SecondarySkillList.Add("Sneak");
                SecondarySkillList.Add("Pickpocket");
                ArmorType.Add("Light Armor");
                MainSkillList.Add("Restoration");
                SecondarySkillList.Add("Alteration");
                SecondarySkillList.Add("Lockpick");
                SecondarySkillList.Add("Lockpick");
                SecondarySkillList.Add("Sneak");
                SecondarySkillList.Add("Pickpocket");
                ArmorType.Add("Light Armor");
            }
            else if (RaceTextBox.Text == "Race: Breton")
            {
                MainSkillList.Add("Conjuration");
                MainSkillList.Add("Conjuration");
                MainSkillList.Add("Illusion");
                MainSkillList.Add("Restoration");
                SecondarySkillList.Add("Alteration");
                SecondarySkillList.Add("Speech");
                SecondarySkillList.Add("Alchemy");
                MainSkillList.Add("Conjuration");
                MainSkillList.Add("Conjuration");
                MainSkillList.Add("Illusion");
                MainSkillList.Add("Restoration");
                SecondarySkillList.Add("Alteration");
                SecondarySkillList.Add("Speech");
                SecondarySkillList.Add("Alchemy");
                MainSkillList.Add("Conjuration");
                MainSkillList.Add("Conjuration");
                MainSkillList.Add("Illusion");
                MainSkillList.Add("Restoration");
                SecondarySkillList.Add("Alteration");
                SecondarySkillList.Add("Speech");
                SecondarySkillList.Add("Alchemy");
                MainSkillList.Add("Conjuration");
                MainSkillList.Add("Conjuration");
                MainSkillList.Add("Illusion");
                MainSkillList.Add("Restoration");
                SecondarySkillList.Add("Alteration");
                SecondarySkillList.Add("Speech");
                SecondarySkillList.Add("Alchemy");
            }
            else if (RaceTextBox.Text == "Race: Dark Elf")
            {
                MainSkillList.Add("Illusion");
                MainSkillList.Add("Destruction");
                MainSkillList.Add("Destruction");
                SecondarySkillList.Add("Alteration");
                ArmorType.Add("Light Armor");
                SecondarySkillList.Add("Sneak");
                SecondarySkillList.Add("Alchemy");
                MainSkillList.Add("Illusion");
                MainSkillList.Add("Destruction");
                MainSkillList.Add("Destruction");
                SecondarySkillList.Add("Alteration");
                ArmorType.Add("Light Armor");
                SecondarySkillList.Add("Sneak");
                SecondarySkillList.Add("Alchemy");
                MainSkillList.Add("Illusion");
                MainSkillList.Add("Destruction");
                MainSkillList.Add("Destruction");
                SecondarySkillList.Add("Alteration");
                ArmorType.Add("Light Armor");
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
                SecondarySkillList.Add("Alteration");
                SecondarySkillList.Add("Enchanting");
                MainSkillList.Add("Illusion");
                MainSkillList.Add("Illusion");
                MainSkillList.Add("Conjuration");
                MainSkillList.Add("Destruction");
                MainSkillList.Add("Restoration");
                SecondarySkillList.Add("Alteration");
                SecondarySkillList.Add("Enchanting");
                MainSkillList.Add("Illusion");
                MainSkillList.Add("Illusion");
                MainSkillList.Add("Conjuration");
                MainSkillList.Add("Destruction");
                MainSkillList.Add("Restoration");
                SecondarySkillList.Add("Alteration");
                SecondarySkillList.Add("Enchanting");
                MainSkillList.Add("Illusion");
                MainSkillList.Add("Illusion");
                MainSkillList.Add("Conjuration");
                MainSkillList.Add("Destruction");
                MainSkillList.Add("Restoration");
                SecondarySkillList.Add("Alteration");
                SecondarySkillList.Add("Enchanting");
            }
            else if (RaceTextBox.Text == "Race: Imperial")
            {
                MainSkillList.Add("One Handed");
                MainSkillList.Add("Restoration");
                MainSkillList.Add("Restoration");
                MainSkillList.Add("Destruction");
                SecondarySkillList.Add("Block");
                ArmorType.Add("Heavy Armor");
                SecondarySkillList.Add("Enchanting");
                MainSkillList.Add("One Handed");
                MainSkillList.Add("Restoration");
                MainSkillList.Add("Restoration");
                MainSkillList.Add("Destruction");
                SecondarySkillList.Add("Block");
                ArmorType.Add("Heavy Armor");
                SecondarySkillList.Add("Enchanting");
            }
            else if (RaceTextBox.Text == "Race: Khajiit")
            {
                MainSkillList.Add("One Handed");
                MainSkillList.Add("Archery");
                SecondarySkillList.Add("Sneak");
                SecondarySkillList.Add("Sneak");
                SecondarySkillList.Add("Lockpick");
                SecondarySkillList.Add("Pickpocket");
                SecondarySkillList.Add("Alchemy");
                MainSkillList.Add("One Handed");
                MainSkillList.Add("Archery");
                SecondarySkillList.Add("Sneak");
                SecondarySkillList.Add("Sneak");
                SecondarySkillList.Add("Lockpick");
                SecondarySkillList.Add("Pickpocket");
                SecondarySkillList.Add("Alchemy");
                MainSkillList.Add("One Handed");
                MainSkillList.Add("Archery");
                SecondarySkillList.Add("Sneak");
                SecondarySkillList.Add("Sneak");
                SecondarySkillList.Add("Lockpick");
                SecondarySkillList.Add("Pickpocket");
                SecondarySkillList.Add("Alchemy");
                MainSkillList.Add("One Handed");
                MainSkillList.Add("Archery");
                SecondarySkillList.Add("Sneak");
                SecondarySkillList.Add("Sneak");
                SecondarySkillList.Add("Lockpick");
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
                ArmorType.Add("Light Armor");
                SecondarySkillList.Add("Speech");
                MainSkillList.Add("Two Handed");
                MainSkillList.Add("Two Handed");
                MainSkillList.Add("One Handed");
                SecondarySkillList.Add("Smithing");
                SecondarySkillList.Add("Block");
                ArmorType.Add("Light Armor");
                SecondarySkillList.Add("Speech");
                MainSkillList.Add("Two Handed");
                MainSkillList.Add("Two Handed");
                MainSkillList.Add("One Handed");
                SecondarySkillList.Add("Smithing");
                SecondarySkillList.Add("Block");
                ArmorType.Add("Light Armor");
                SecondarySkillList.Add("Speech");
                MainSkillList.Add("Two Handed");
                MainSkillList.Add("Two Handed");
                MainSkillList.Add("One Handed");
                SecondarySkillList.Add("Smithing");
                SecondarySkillList.Add("Block");
                ArmorType.Add("Light Armor");
                SecondarySkillList.Add("Speech");
            }
            else if (RaceTextBox.Text == "Race: Orc")
            {
                MainSkillList.Add("Two Handed");
                MainSkillList.Add("One Handed");
                SecondarySkillList.Add("Smithing");
                ArmorType.Add("Heavy Armor");
                ArmorType.Add("Heavy Armor");
                SecondarySkillList.Add("Block");
                SecondarySkillList.Add("Enchanting");
                MainSkillList.Add("Two Handed");
                MainSkillList.Add("One Handed");
                SecondarySkillList.Add("Smithing");
                ArmorType.Add("Heavy Armor");
                ArmorType.Add("Heavy Armor");
                SecondarySkillList.Add("Block");
                SecondarySkillList.Add("Enchanting");
                MainSkillList.Add("Two Handed");
                MainSkillList.Add("One Handed");
                SecondarySkillList.Add("Smithing");
                ArmorType.Add("Heavy Armor");
                ArmorType.Add("Heavy Armor");
                SecondarySkillList.Add("Block");
                SecondarySkillList.Add("Enchanting");
                MainSkillList.Add("Two Handed");
                MainSkillList.Add("One Handed");
                SecondarySkillList.Add("Smithing");
                ArmorType.Add("Heavy Armor");
                ArmorType.Add("Heavy Armor");
                SecondarySkillList.Add("Block");
                SecondarySkillList.Add("Enchanting");
                MainSkillList.Add("Two Handed");
                MainSkillList.Add("One Handed");
                SecondarySkillList.Add("Smithing");
                ArmorType.Add("Heavy Armor");
                ArmorType.Add("Heavy Armor");
                SecondarySkillList.Add("Block");
                SecondarySkillList.Add("Enchanting");
                MainSkillList.Add("Two Handed");
                MainSkillList.Add("One Handed");
                SecondarySkillList.Add("Smithing");
                ArmorType.Add("Heavy Armor");
                ArmorType.Add("Heavy Armor");
                SecondarySkillList.Add("Block");
                SecondarySkillList.Add("Enchanting");
            }
            else if (RaceTextBox.Text == "Race: Redguard")
            {
                MainSkillList.Add("One Handed");
                MainSkillList.Add("One Handed");
                MainSkillList.Add("Archery");
                MainSkillList.Add("Destruction");
                SecondarySkillList.Add("Alteration");
                SecondarySkillList.Add("Block");
                SecondarySkillList.Add("Smithing");
                MainSkillList.Add("One Handed");
                MainSkillList.Add("One Handed");
                MainSkillList.Add("Archery");
                MainSkillList.Add("Destruction");
                SecondarySkillList.Add("Alteration");
                SecondarySkillList.Add("Block");
                SecondarySkillList.Add("Smithing");
                MainSkillList.Add("One Handed");
                MainSkillList.Add("One Handed");
                MainSkillList.Add("Archery");
                MainSkillList.Add("Destruction");
                SecondarySkillList.Add("Alteration");
                SecondarySkillList.Add("Block");
                SecondarySkillList.Add("Smithing");

            }
            else if (RaceTextBox.Text == "Race: Wood Elf")
            {
                MainSkillList.Add("Archery");
                MainSkillList.Add("Archery");
                ArmorType.Add("Light Armor");
                SecondarySkillList.Add("Sneak");
                SecondarySkillList.Add("Lockpick");
                SecondarySkillList.Add("Pickpocket");
                SecondarySkillList.Add("Alchemy");
                MainSkillList.Add("Archery");
                MainSkillList.Add("Archery");
                ArmorType.Add("Light Armor");
                SecondarySkillList.Add("Sneak");
                SecondarySkillList.Add("Lockpick");
                SecondarySkillList.Add("Pickpocket");
                SecondarySkillList.Add("Alchemy");
                MainSkillList.Add("Archery");
                MainSkillList.Add("Archery");
                ArmorType.Add("Light Armor");
                SecondarySkillList.Add("Sneak");
                SecondarySkillList.Add("Lockpick");
                SecondarySkillList.Add("Pickpocket");
                SecondarySkillList.Add("Alchemy");
                MainSkillList.Add("Archery");
                MainSkillList.Add("Archery");
                ArmorType.Add("Light Armor");
                SecondarySkillList.Add("Sneak");
                SecondarySkillList.Add("Lockpick");
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
                ArmorType.Add("Light Armor");
                ArmorType.Add("Heavy Armor");
                mainSkill = RollOneHanded();
            }
            else if (mainSkillRoll == "Two Handed")
            {
                roller = RollRandom(1, 4);
                ChosenSecondarySkills.Add("Block");
                ArmorType.Add("Light Armor");
                ArmorType.Add("Heavy Armor");
                if (roller == 1)
                    mainSkill = "Two Handed - Greatsword";
                if (roller == 2)
                    mainSkill = "Two Handed - BattleAxe";
                if (roller == 3)
                    mainSkill = "Two Handed - WarHammer";
            }
            else if (mainSkillRoll == "Archery")
            {
                ArmorType.Clear();
                ArmorType.Add("Light Armor");
                ChosenSecondarySkills.Add("Sneak");
                ChosenSecondarySkills.Add("One Handed - Dagger");
                roller = RollRandom(1, 3);
                if (roller == 1)
                    mainSkill = "Archery - Bow and Arrow";
                if (roller == 2)
                    mainSkill = "Archery - Crossbow";
            }
            else if (mainSkillRoll == "Conjuration")
            {
                ArmorType.Clear();
                ArmorType.Add("Light Armor");
                ArmorType.Add("Heavy Armor");
                ChosenSecondarySkills.Add("Enchanting");
                ChosenSecondarySkills.Add("Alteration");
                mainSkill = RollConjuration();
            }
            else if (mainSkillRoll == "Illusion")
            {
                ArmorType.Clear();
                ArmorType.Add("Robes");
                ChosenSecondarySkills.Add("Alteration");
                mainSkill = "Illusion";
                ChosenSecondarySkills.Add("Sneak");
                ChosenSecondarySkills.Add("Speech");
            }
            else if (mainSkillRoll == "Destruction")
            {
                ArmorType.Clear();
                ArmorType.Add("Robes");
                ChosenSecondarySkills.Add("Alteration");
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
                ArmorType.Clear();
                ArmorType.Add("Robes");
                ChosenSecondarySkills.Add("Alchemy");
                ChosenSecondarySkills.Add("Alteration");
                roller = RollRandom(1, 4);
                if (roller == 1)
                    mainSkill = "Restoration - Warder";
                if (roller == 2)
                    mainSkill = "Restoration - Cleanser";
                if (roller == 3)
                    mainSkill = "Restoration - Blighter";
            }
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
            int roller = RollRandom(1, 4);
            if (roller == 1)
            {
                ArmorType.Add("Light Armor");
                weaponType = RollOneHandedWeaponTypeDual();
                roller = RollRandom(1, 3);
                if (roller == 1)
                    ohType = "Dual " + weaponType + "s";
                else
                {
                    string weaponType2 = RollOneHandedWeaponTypeDual();
                    ohType = "Dual " + weaponType + " and " + weaponType2;
                }
            }
            else if (roller == 2)
            {
                ArmorType.Add("Heavy Armor");
                weaponType = RollOneHandedWeaponType();
                ohType = weaponType + " and Shield";
                ChosenSecondarySkills.Add("Block");
            }
            else
            {
                ArmorType.Add("Light Armor");
                weaponType = RollOneHandedWeaponType();
                MainSkillList.Clear();
                PopulateMainSkills();
                while (MainSkillList.Contains("One Handed"))
                    MainSkillList.Remove("One Handed");
                while (MainSkillList.Contains("Two Handed"))
                    MainSkillList.Remove("Two Handed");
                while (MainSkillList.Contains("Archery"))
                    MainSkillList.Remove("Archery");
                roller = RollRandom(0, MainSkillList.Count());
                ChosenSecondarySkills.Add(MainSkillList[roller]);
                ChosenSecondarySkills.Add("Alteration");
                ohType = MainSkillList[roller] + " " + weaponType + " Spellsword";
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
        private string RollOneHandedWeaponTypeDual()
        {
            string weapon;
            int roller = RollRandom(1, 5);
            if (roller == 1)
                weapon = "Sword";
            else if (roller == 2)
                weapon = "Axe";
            else if (roller == 3)
                weapon = "Mace";
            else
                weapon = "Dagger";
            return weapon;
        }
        private string RollConjuration()
        {
            string spiritWeapon;
            string magicType;
            int roller = RollRandom(1, 4);
            if (roller == 1)
            {
                spiritWeapon = "Sword";
                string weaponType;
                if (RollRandom(1, 3) == 1)
                    weaponType = "Dual Swords";
                else
                    weaponType = "Sword";
                ChosenSecondarySkills.Add("One Handed - " + weaponType);
            }
            else if (roller == 2)
            {
                spiritWeapon = "BattleAxe";
                ChosenSecondarySkills.Add("Two Handed - BattleAxe");
            }
            else
            {
                spiritWeapon = "Bow";
                ChosenSecondarySkills.Add("Archery - Bow and Arrow");
            }
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

        private void PopulateSecondarySkills()
        {
            SecondarySkillList.Add("Enchanting");
            SecondarySkillList.Add("Smithing");
            SecondarySkillList.Add("Sneak");
            SecondarySkillList.Add("Lockpick");
            SecondarySkillList.Add("Pickpocket");
            SecondarySkillList.Add("Speech");
            SecondarySkillList.Add("Alchemy");
        }
        private void GenerateSecondarySkills()
        {
            int roller;
            string chosenSkill;
            for (int i = 0; i < ChosenSecondarySkills.Count; i++)
            {
                chosenSkill = ChosenSecondarySkills[i];
                if (SecondarySkillList.Contains(chosenSkill))
                {
                    while (SecondarySkillList.Contains(chosenSkill))
                        SecondarySkillList.Remove(chosenSkill);
                }
            }

            while (ChosenSecondarySkills.Count() < 5)
            {
                roller = RollRandom(0, SecondarySkillList.Count());
                chosenSkill = SecondarySkillList[roller];
                ChosenSecondarySkills.Add(chosenSkill);
                while (SecondarySkillList.Contains(chosenSkill))
                    SecondarySkillList.Remove(chosenSkill);
            }
            SecondarySkillLabel.Text = "Secondary Skills: ";
            SecondarySkillBox1.Content = ChosenSecondarySkills[0];
            SecondarySkillBox2.Content = ChosenSecondarySkills[1];
            SecondarySkillBox3.Content = ChosenSecondarySkills[2];
            SecondarySkillBox4.Content = ChosenSecondarySkills[3];
            SecondarySkillBox5.Content = ChosenSecondarySkills[4];
        }

        private void GenerateArmorType()
        {
            int roller = RollRandom(0, ArmorType.Count());
            string armorType = ArmorType[roller];
            ArmorTextBox.Text = "Armor: " + armorType;
        }

        private void GenerateStandingStone() 
        {
            List<string> standingStoneList = new List<string>();
            standingStoneList = AddStoneBias(standingStoneList);
            StandingStoneTextBox.Text = "Standing Stone: " + RollStandingStone(standingStoneList);
            standingStoneList.Clear();
        }

        private List<string> AddStoneBias(List<string> standingStoneList) 
        {
            string mainSkill = MainSkillTextBox.Text;
            if (mainSkill.Contains("Destruction") || mainSkill.Contains("Conjuration") || mainSkill.Contains("Illusion") || mainSkill.Contains("Restoration"))
            {
                standingStoneList.Add("Apprentice");
                standingStoneList.Add("Atronach");
                standingStoneList.Add("Lady");
                standingStoneList.Add("Lord");
                standingStoneList.Add("Lover");
                standingStoneList.Add("Mage");
                standingStoneList.Add("Mage");
                standingStoneList.Add("Mage");
                standingStoneList.Add("Steed");
                standingStoneList.Add("Tower");
            }
            else 
            {
                standingStoneList.Add("Lady");
                standingStoneList.Add("Lord");
                standingStoneList.Add("Lover");
                standingStoneList.Add("Serpent");
                standingStoneList.Add("Shadow");
                standingStoneList.Add("Steed");
                standingStoneList.Add("Tower");
                standingStoneList.Add("Warrior");
                standingStoneList.Add("Warrior");
                standingStoneList.Add("Warrior");
            }
            if (mainSkill.Contains("Conjuration"))
            {
                standingStoneList.Add("Ritual");
                standingStoneList.Add("Ritual");
                standingStoneList.Add("Ritual");
            }
            if (ChosenSecondarySkills.Contains("Sneak"))
            {
                standingStoneList.Add("Thief");
                standingStoneList.Add("Thief");
                standingStoneList.Add("Thief");
                standingStoneList.Add("Tower");
                standingStoneList.Add("Tower");
                standingStoneList.Add("Tower");
                standingStoneList.Add("Shadow");
                standingStoneList.Add("Shadow");
                standingStoneList.Add("Shadow");
            }
            return standingStoneList;
        }

        private string RollStandingStone(List<string> standingStoneList)
        {
            string standingStone;
            standingStone = standingStoneList[RollRandom(0, standingStoneList.Count())];
            return standingStone;
        }

        private void GenerateCharacter(object sender, RoutedEventArgs e)
        {
            MainSkillList.Clear();
            SecondarySkillList.Clear();
            ChosenSecondarySkills.Clear();
            ArmorType.Clear();
            SpiritWeaponTextBox.Text = "";
            GenerateRace();
            GenerateGender();
            GenerateAlignment();
            GeneratePersonality();
            PopulateMainSkills();
            GenerateMainSkill();
            PopulateSecondarySkills();
            GenerateSecondarySkills();
            GenerateArmorType();
            GenerateStandingStone();
            
        }
    }
}