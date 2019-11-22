using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace App1.models
{
    class ComplexPerson_Tabletop
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private String Fname;
        private String Lname;
        private int age;
        private String profession;
        private String race;
        private String gender;
        private string fullName;
        private string nationality;
        private int heightFeet;
        private int heightInches;
        private float weight;
        private string hairColor;
        private string eyeColor;
        private string personality;
        private string[] likes;
        private string[] dislikes;
        private string accent;
        private string styleOfDress;
        private string[] friends;
        private string[] enemies;
        private string significantOther;
        private string favoriteFood;
        private string[] groups;

        private string armor_class;

        //tabletop parameters
        int hitPoints;
        int specialPoints;
        int level;
        int strength;
        int dexterity;
        int intelligence;
        int wisdom;
        int constitution;
        int will;
        int charisma;

        int proficiency_bonus;
        int inspiration;
        int perception;
        int spellcasting_ability;
        int spell_save_DC;
        int spell_attack_bonus;
        int Exp;



        public String FName
        {
            get { return Fname; }
            set
            {
                Fname = value;
                FullName = "";
                FieldChanged();
            }
        }

        public String LName
        {
            get { return Lname; }
            set
            {
                Lname = value;
                FullName = "";
                FieldChanged();
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                FieldChanged();
            }
        }

        public String Profession
        {
            get { return profession; }
            set
            {
                profession = value;
                FieldChanged();
            }
        }

        public String Race
        {
            get { return race; }
            set
            {
                race = value;
                FieldChanged();
            }
        }

        public String Gender
        {
            get { return gender; }
            set
            {
                gender = value;
                FieldChanged();
            }
        }
        public string FullName
        {
            get { return fullName; }
            set
            {
                fullName = $"{FName} {Lname}";
                FieldChanged();
            }
        }

        public string Nationality
        {
            get { return nationality; }
            set
            {
                nationality = value;
                FieldChanged();
            }
        }
        public string HairColor
        {
            get { return hairColor; }
            set
            {
                hairColor = value;
                FieldChanged();
            }
        }
        public string EyeColor
        {
            get { return eyeColor; }
            set
            {
                eyeColor = value;
                FieldChanged();
            }
        }
        public string Personality
        {
            get { return personality; }
            set
            {
                personality = value;
                FieldChanged();
            }
        }
        public String Armor_Class
        {
            get { return armor_class; }
            set
            {
                armor_class = value;
                FieldChanged();
            }
        }

        public int Heightfeet
        {
            get { return heightFeet; }
            set
            {
                heightFeet = value;
                FieldChanged();
            }
        }

        public int HeightInches
        {
            get { return heightInches; }
            set
            {
                heightInches = value;
                FieldChanged();
            }
        }

        public float Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                FieldChanged();
            }
        }

        public string[] Likes
        {
            get { return likes; }
            set
            {
                likes = value;
                FieldChanged();
            }
        }

        public string[] Dislikes
        {
            get { return dislikes; }
            set
            {
                dislikes = value;
                FieldChanged();
            }
        }

        public int HitPoints
        {
            get { return hitPoints; }
            set
            {
                hitPoints = value;
                FieldChanged();
            }
        }

        public int SpecialPoints
        {
            get { return specialPoints; }
            set
            {
                specialPoints = value;
                FieldChanged();
            }
        }

        public int Level
        {
            get { return level; }
            set
            {
                level = value;
                FieldChanged();
            }
        }

        public int Strength
        {
            get { return strength; }
            set
            {
                strength = value;
                FieldChanged();
            }
        }

        public int Dexterity
        {
            get { return dexterity; }
            set
            {
                dexterity = value;
                FieldChanged();
            }
        }

        public int Intelligence
        {
            get { return intelligence; }
            set
            {
                intelligence = value;
                FieldChanged();
            }
        }

        public int Wisdom
        {
            get { return wisdom; }
            set
            {
                wisdom = value;
                FieldChanged();
            }
        }

        public int Constiution
        {
            get { return constitution; }
            set
            {
                constitution = value;
                FieldChanged();
            }
        }

        public int Will
        {
            get { return will; }
            set
            {
                will = value;
                FieldChanged();
            }
        }

        public int Charisma
        {
            get { return charisma; }
            set
            {
                charisma = value;
                FieldChanged();
            }
        }

        public int Proficiency_bonus
        {
            get { return proficiency_bonus; }
            set
            {
                proficiency_bonus = value;
                FieldChanged();
            }
        }

        public int Inspiration
        {
            get { return inspiration; }
            set
            {
                inspiration = value;
                FieldChanged();
            }
        }

        public int Perception
        {
            get { return perception; }
            set
            {
                perception = value;
                FieldChanged();
            }
        }

        public int Spellcasting_ability
        {
            get { return spellcasting_ability; }
            set
            {
                spellcasting_ability = value;
                FieldChanged();
            }
        }

        public int Spell_save_DC
        {
            get { return spell_save_DC; }
            set
            {
                spell_save_DC = value;
                FieldChanged();
            }
        }

        public int Spell_attack_bonus
        {
            get { return spell_attack_bonus; }
            set
            {
                Spell_attack_bonus = value;
                FieldChanged();
            }
        }
        
        public int EXP
        {
            get { return Exp; }
            set
            {
                Exp = value;
                FieldChanged();
            }
        }

        public string Accent
        {
            get { return accent; }
            set
            {
                accent = value;
                FieldChanged();
            }
        }

        public string StyleOfDress
        {
            get { return styleOfDress; }
            set
            {
                styleOfDress = value;
                FieldChanged();
            }
        }

        public string[] Friends
        {
            get { return friends; }
            set
            {
                friends = value;
                FieldChanged();
            }
        }

        public string[] Enemies
        {
            get { return enemies; }
            set
            {
                enemies = value;
                FieldChanged();
            }
        }

        public string SignificantOther
        {
            get { return significantOther; }
            set
            {
                significantOther = value;
                FieldChanged();
            }
        }


        public string FavoriteFood
        {
            get { return favoriteFood; }
            set
            {
                favoriteFood = value;
                FieldChanged();
            }
        }

        public string[] Groups
        {
            get { return groups; }
            set
            {
                groups = value;
                FieldChanged();
            }
        }

        protected void FieldChanged([CallerMemberName] string field = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(field));
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (string like in likes)
            {
                sb.Append(like + ", ");
            }

            string compiledLikes = "Likes: " + sb.ToString();

            sb.Clear();

            foreach (string dislike in dislikes)
            {
                sb.Append(dislike + ", ");
            }

            string compiledDislikes = "dislikes: " + sb.ToString();

            sb.Clear();

            foreach (string friend in friends)
            {
                sb.Append(friend + ", ");
            }

            string compiledFriends = "friends: " + sb.ToString();

            sb.Clear();

            foreach (string enemy in enemies)
            {
                sb.Append(enemy + ", ");
            }

            string compiledEnemies = "enemies: " + sb.ToString();

            sb.Clear();

            foreach (string group in groups)
            {
                sb.Append(group + ", ");
            }

            string compiledGroups = "groups: " + sb.ToString();

            sb.Clear();

            return FName + LName + "\n" + Age + "\n" + Race + "\n" + Profession + "\n" + Gender + "\n" + armor_class + "\n" + "HP: " + hitPoints + "\n" + "SP: " + specialPoints + "\n" + "LV: " + level +
                "\n" + "STR: " + strength + "\n" + "DEX: " + dexterity + "\n" + "INT: " + intelligence + "\n" + "WIS: " + wisdom + "\n" + "CON: " + constitution + "WIL: " + will +
                "\n" + "CHR: " + charisma + "\n" + inspiration + "\n" + perception + "\n" + proficiency_bonus + "\n" + spellcasting_ability + "\n" + spell_save_DC + "\n" + Spell_attack_bonus +
                "\n" + Exp + "\n" +
                "\n" + hairColor + "\n" + eyeColor + "\n" + heightFeet + "." + heightInches +
                "\n" + weight + "\n" + nationality + "\n" + personality + "\n" + compiledLikes + "\n" + compiledDislikes + "\n" + "Significant Other:" + significantOther + "\n" + "\n" + favoriteFood
                + "\n" + accent + styleOfDress + "\n" + compiledFriends + "\n" + compiledEnemies + "\n" + compiledGroups + "\n";
        }

    }
}
