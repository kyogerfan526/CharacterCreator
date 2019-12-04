using App1.Constant_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.models
{
    public class ModComplexPerson : Person
    {
        private string nationality;
        private int heightFeet;
        private int heightInches;
        private float weight;
        private string hairColor;
        private string eyeColor;
        private string personality;
        private string[] likes;
        private string[] dislikes;

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

        public new void Randomize(bool genderLock = false, bool genreLock = false, bool raceLock = false,
            Gender gender = Constant_Data.Gender.NoLock, Genre genre = Constant_Data.Genre.NoLock, string race = "",
            bool tableTop = false)
        {
            base.Randomize(genderLock, genreLock, raceLock, gender, genre, race, tableTop);

            Random rng = new Random();
            
            if (genre == Genre.Fantasy)
            {
                Nationality = Data.fantasyNationalities[rng.Next(Data.fantasyNationalities.Count() - 1)];
            } else if (genre == Genre.Scifi)
            {
                Nationality = Data.scifiNationalities[rng.Next(Data.scifiNationalities.Count() - 1)];
            } else
            {
                Nationality = Data.Nationalities[rng.Next(Data.Nationalities.Count() - 1)];
            }

            HairColor = Data.hairColors[rng.Next(Data.hairColors.Count() - 1)];
            EyeColor = Data.hairColors[rng.Next(Data.eyeColors.Count() - 1)];
            Personality = Data.personalities[rng.Next(Data.personalities.Count() - 1)];

            Likes = MakePreferences();
            Dislikes = MakePreferences();

            Heightfeet = rng.Next(3) + 4;
            HeightInches = rng.Next(12);
            Weight = rng.Next(110) + 90;
        }

        private string[] MakePreferences()
        {
            Random rng = new Random();
            string[] tempPref = new string[rng.Next(3) + 3];

            for (int i = 0; i < tempPref.Length; i++)
            {
                tempPref[i] = Data.likes[rng.Next(Data.likes.Count() - 1)];
            }

            return tempPref;
        }
    }
}
