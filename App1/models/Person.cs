using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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

        public override string ToString()
        {
            return FName + " " + LName + "\n " + Age + "\n " + Race + "\n " + Profession + "\n " + Gender;
        }
    }
}
