using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace App1.models
{
    public class TableTopStats : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int HitPoints { get; set; }
        public int SpecialPoints { get; set; }
        public int Level { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Constitution { get; set; }
        public int Will { get; set; }
        public int Charisma { get; set; }
        public int ArmorClass { get; set; }
        public int ProficiencyBonus { get; set; }
        public int Inspiration { get; set; }
        public int Perception { get; set; }
        public int SpellcastingAbility { get; set; }
        public int SpellsaveDC { get; set; }
        public int SpellAttackBonus { get; set; }
        public int Exp { get; set; }
        
        public string[] Groups { get; set; }

        protected void FieldChanged([CallerMemberName] string field = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(field));
            }
        }

        public void Randomize()
        {
            Random rng = new Random();

            Level = rng.Next(20) + 1;
            Exp = rng.Next(1000 * Level);

            Strength = ((rng.Next(6) + 1) + (rng.Next(6) + 1) + (rng.Next(6) + 1));
            Dexterity = ((rng.Next(6) + 1) + (rng.Next(6) + 1) + (rng.Next(6) + 1));
            Intelligence = ((rng.Next(6) + 1) + (rng.Next(6) + 1) + (rng.Next(6) + 1));
            Wisdom = ((rng.Next(6) + 1) + (rng.Next(6) + 1) + (rng.Next(6) + 1));
            Constitution = ((rng.Next(6) + 1) + (rng.Next(6) + 1) + (rng.Next(6) + 1));
            Will = ((rng.Next(6) + 1) + (rng.Next(6) + 1) + (rng.Next(6) + 1));
            Charisma = ((rng.Next(6) + 1) + (rng.Next(6) + 1) + (rng.Next(6) + 1));
            Perception = ((rng.Next(6) + 1) + (rng.Next(6) + 1) + (rng.Next(6) + 1));

            HitPoints = GetHP();
            SpecialPoints = rng.Next(12) + 1;

        }
        private int GetHP()
        {
            int result = 0;

            int j = Constitution / 6 > 0 ? Constitution / 6: 1;

            for (int i = 0; i < j; i++)
            {
                result += new Random().Next(6) + 1;
            }

            return result;
        }

    }

}
