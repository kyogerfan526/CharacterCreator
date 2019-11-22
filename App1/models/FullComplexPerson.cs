using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.models
{
    public class FullComplexPerson : ModComplexPerson
    {
        private string accent;
        private string styleOfDress;
        private string[] friends;
        private string[] enemies;
        private string significantOther;
        private string fightingStyle;
        private string preferredWeapon;
        private string favoriteFood;

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

        public string FightingStyle
        {
            get { return fightingStyle; }
            set
            {
                fightingStyle = value;
                FieldChanged();
            }
        }

        public string PreferredWeapon
        {
            get { return preferredWeapon; }
            set
            {
                preferredWeapon = value;
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
    }
}
