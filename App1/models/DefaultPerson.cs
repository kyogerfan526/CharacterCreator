using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.models
{
    class DefaultPerson
    {
        private String Fname;
        private String Lname;
        private int age;
        private String profession;
        private String race;
        private String gender;

        public String FName
        {
            get { return Fname; }
            set { Fname = value; }
        }

        public String LName
        {
            get { return Lname; }
            set { Lname = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public String Profession
        {
            get { return profession; }
            set { profession = value; }
        }

        public String Race
        {
            get { return race; }
            set { race = value; }
        }

        public String Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public override string ToString()
        {
            return FName + " " + LName + "\n " + Age + "\n " + Race + "\n " + Profession + "\n " + Gender;
        }

    }
}
