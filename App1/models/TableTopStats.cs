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

        int HitPoints { get; set; }
        int SpecialPoints { get; set; }
        int Level { get; set; }
        int Strength { get; set; }
        int Dexterity { get; set; }
        int Intelligence { get; set; }
        int Wisdom { get; set; }
        int Constitution { get; set; }
        int Will { get; set; }
        int Charisma { get; set; }
        int ArmorClass { get; set; }
        int ProficiencyBonus { get; set; }
        int Inspiration { get; set; }
        int Perception { get; set; }
        int SpellcastingAbility { get; set; }
        int SpellsaveDC { get; set; }
        int SpellAttackBonus { get; set; }
        int exp { get; set; }

        string[] Groups { get; set; }

        protected void FieldChanged([CallerMemberName] string field = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(field));
            }
        }
    }
}
