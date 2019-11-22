using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace App1.models
{
    class ModeratelyComplexPerson_Tabletop : INotifyPropertyChanged
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



        public String FName
        {
            get { return Fname; }
            set { Fname = value;
                FullName = "";
                FieldChanged();
            }
        }

        public String LName
        {
            get { return Lname; }
            set { Lname = value;
                FullName = "";
                FieldChanged();
            }
        }

        public int Age
        {
            get { return age; }
            set { age = value; 
                FieldChanged();
            }
        }

        public String Profession
        {
            get { return profession; }
            set { profession = value;
                FieldChanged();
            }
        }

        public String Race
        {
            get { return race; }
            set { race = value;
                FieldChanged();
            }
        }

        public String Gender
        {
            get { return gender; }
            set { gender = value;
                FieldChanged();
            }
        }
        public string FullName
        {
            get { return fullName; }
            set { fullName = $"{FName} {Lname}";
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

        public int Heightfeet
        {
            get { return heightFeet; }
            set { heightFeet = value;
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

        public int Constitution
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


            return FName + LName + "\n" + Age + "\n" + Race + "\n" + Profession + "\n" + Gender + "\n" + "HP: " + hitPoints + "\n" + "SP: " + specialPoints + "\n" + "LV: " + level +
                "\n" + "STR: " + strength + "\n" + "DEX: " + dexterity + "\n" + "INT: " + intelligence + "\n" + "WIS: " + wisdom + "\n" + "CON: " + constitution + "WIL: " + will +
                "\n" + "CHR: " + charisma +
                "\n" + hairColor + "\n" + eyeColor + "\n" + heightFeet + "." + heightInches +
                "\n" + weight + "\n" + nationality + "\n" + personality + "\n" + compiledLikes + "\n" + compiledDislikes;
        }

    }
}
