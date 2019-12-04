using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using App1.Constant_Data;

namespace App1.models
{
    // This is the base Person class; Moderately and Complex Person inherit from this class.
    public class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Person()
        {
            Stats = null;
        }

        private String Fname;
        private String Lname;
        private int age;
        private String profession;
        private String race;
        private String gender;
        private TableTopStats stats;
        private string fullName;

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


        public TableTopStats Stats
        {
            get { return stats; }
            set { stats = value;
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

        protected void FieldChanged([CallerMemberName] string field = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(field));
            }
        }

        /// <summary>
        /// Randomizes all applicable Person stats; all values have defaults, so it can be called with no parameters.
        /// </summary>
        /// <param name="genderLock">Whether or not gender should be locked to a specific gender.</param>
        /// <param name="genreLock">Whether or not the genre of fields should be locked to a specific genre.</param>
        /// <param name="raceLock">Whether or not the race should be locked to a specific race.</param>
        /// <param name="gender">The gender to lock the Person to.</param>
        /// <param name="genre">The genre to lock the Person to.</param>
        /// <param name="race">The race to lock the Person to.</param>
        /// <param name="tableTop">Whether or not table top stats shoul be used.</param>
        public void Randomize(bool genderLock = false, bool genreLock = false, bool raceLock = false,
            Gender gender = Constant_Data.Gender.NoLock, Genre genre = Constant_Data.Genre.NoLock, string race = "",
            bool tableTop = false)
        {
            Random rng = new Random();

            // Randomizes First Name as well as gender if applicable.
            if (genderLock)
            {
                FName = gender == Constant_Data.Gender.Female ? Data.FFNames[rng.Next(Data.FFNames.Count() - 1)] : Data.MFNames[rng.Next(Data.MFNames.Count() - 1)];
                Gender = gender == Constant_Data.Gender.Female ? "Female" : "Male";
            }
            else
            {
                FName = Data.FNames[rng.Next(Data.FNames.Count() - 1)];
                Gender = rng.Next(2) == 0 ? "Female" : "Male";
            }

            // Randomizes Last Name and Age
            LName = Data.LNames[rng.Next(Data.LNames.Count() - 1)];
            Age = rng.Next(100) + 1;

            // Randomizes Profession based on age followed by genre if applicable
            if (Age < 14)
            {
                Profession = "Unemployed";
            }
            else if (Age < 18)
            {
                Profession = Data.MinorProfessions[rng.Next(Data.MinorProfessions.Count() - 1)];
            }
            else
            {
                if (genre == Genre.Scifi)
                {
                    Profession = Data.SciFiProfessions[rng.Next(Data.SciFiProfessions.Count() - 1)];
                }
                else if (genre == Genre.Fantasy)
                {
                    Profession = Data.FantasyProfessions[rng.Next(Data.FantasyProfessions.Count() - 1)];
                }
                else // Contemporary | Default
                {
                    Profession = Data.Professions[rng.Next(Data.Professions.Count() - 1)];
                }
            }

            if (raceLock)
            {
                Race = race;
            } else
            {
                if (genre == Genre.Scifi)
                {
                    Race = Data.SciFiRaces[rng.Next(Data.SciFiRaces.Count() - 1)];
                } else if (genre == Genre.Fantasy)
                {
                    Race = Data.FantasyRaces[rng.Next(Data.FantasyRaces.Count() - 1)];
                } else // Contemporary | Default
                {
                    Race = Data.Races[rng.Next(Data.Races.Count() - 1)];
                }
            }

            if (tableTop) 
            {
                stats = new TableTopStats();
                stats.Randomize();
            }
        }

        public override string ToString()
        {
            return FName + " " + LName + "\n " + Age + "\n " + Race + "\n " + Profession + "\n " + Gender;
        }
    }
}
