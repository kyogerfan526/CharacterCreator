using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace App1.models
{
    class DefaultPerson : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    
        private String Fname;
        private String Lname;
        private int age;
        private String profession;
        private String race;
        private String gender;

        public String FName
        {
            get { return Fname; }
            set { Fname = value;
                FieldChanged();
            }
        }

        public String LName
        {
            get { return Lname; }
            set { Lname = value;
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

        protected void FieldChanged([CallerMemberName] string field = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(field));
            }
        }


        public override string ToString()
        {
            return FName + LName + "\n" + Age + "\n" + Race + "\n" + Profession + "\n" + Gender;
        }

    }
}
