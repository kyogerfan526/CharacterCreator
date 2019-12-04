using CharacterMaker;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml.Serialization;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CustomComplexityScreen : Page
    {
        List<bool> fields = new List<bool>();
        bool Cfname = false;
        bool Clname = false;
        bool Cage = false;
        bool Crace = false;
        bool Cprofession = false;
        bool Cgender = false;
        bool Cnationality = false;
        bool Cheight = false;
        bool Cweight = false;
        bool Chair_color = false;
        bool Ceye_color = false;
        bool Cpersonality = false;
        bool Clikes = false;
        bool Cdislikes = false;
        bool Chit_points = false;
        bool Cspecial_points = false;
        bool Clevel = false;
        bool Cstrength = false;
        bool Cdexterity = false;
        bool Cinteligence = false;
        bool Cwisdom = false;
        bool Cconstitution = false;
        bool Cwill = false;
        bool Ccharisma = false;
        bool Caccent = false;
        bool Cstyle_of_dress = false;
        bool Cfriends = false;
        bool Cenimes = false;
        bool Csignificant_other = false;
        bool Cfighting_style = false;
        bool Cpreferred_weapon = false;
        bool Cfavorite_food = false;
        bool Carmor_class = false;
        bool Cprofeciency_bonus = false;
        bool Cinspiration = false;
        bool Cperception = false;
        bool Cspell_casting_ability = false;
        bool Cspell_save_DC = false;
        bool Cspell_attack_bonus = false;
        bool Cexp = false;
        bool Cgroups = false;

        public CustomComplexityScreen()
        {
            this.InitializeComponent();
            fields.Add(Cfname);
            fields.Add(Clname);
            fields.Add(Cage);
            fields.Add(Crace);
            fields.Add(Cprofession);
            fields.Add(Cgender);
            fields.Add(Cnationality);
            fields.Add(Cheight);
            fields.Add(Cweight);
            fields.Add(Chair_color);
            fields.Add(Ceye_color);
            fields.Add(Cpersonality);
            fields.Add(Clikes);
            fields.Add(Cdislikes);
            fields.Add(Chit_points);
            fields.Add(Cspecial_points);
            fields.Add(Clevel);
            fields.Add(Cstrength);
            fields.Add(Cdexterity);
            fields.Add(Cinteligence);
            fields.Add(Cwisdom);
            fields.Add(Cconstitution);
            fields.Add(Cwill);
            fields.Add(Ccharisma);
            fields.Add(Caccent);
            fields.Add(Cstyle_of_dress);
            fields.Add(Cfriends);
            fields.Add(Cenimes);
            fields.Add(Csignificant_other);
            fields.Add(Cfighting_style);
            fields.Add(Cpreferred_weapon);
            fields.Add(Cfavorite_food);
            fields.Add(Carmor_class);
            fields.Add(Cprofeciency_bonus);
            fields.Add(Cinspiration);
            fields.Add(Cperception);
            fields.Add(Cspell_casting_ability);
            fields.Add(Cspell_save_DC);
            fields.Add(Cspell_attack_bonus);
            fields.Add(Cexp);
            fields.Add(Cgroups);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private async void Save_Click(object sender, RoutedEventArgs e)
        {
            FileSavePicker picker = new FileSavePicker();

            picker.SuggestedStartLocation = PickerLocationId.Desktop;
            picker.FileTypeChoices.Add("XML", new List<string>() { ".xml" });
            picker.FileTypeChoices.Add("RNDC", new List<string>() { ".rndc" });
            picker.SuggestedFileName = "New set";

            StorageFile file = await picker.PickSaveFileAsync();
            Write(file);
        }

        private async void Write(StorageFile file)
        {
            if (file == null)
            {
                return;
            }

            Stream stream = await file.OpenStreamForWriteAsync();
            XmlSerializer serializer = new XmlSerializer(typeof(List<bool>));
            StreamWriter writer = new StreamWriter(stream);
            serializer.Serialize(writer, fields);
            writer.Close();

        }

        private void Fname_Click(object sender, RoutedEventArgs e)
        {
            if(fields[0] == false)
            {
                fields[0] = true;
            }
            else
            {
                fields[0] = false;
            }
            
        }

        private void Lname_Click(object sender, RoutedEventArgs e)
        {
            if (fields[1] == false)
            {
                fields[1] = true;
            }
            else
            {
                fields[1] = false;
            }
        }

        private void Age_Click(object sender, RoutedEventArgs e)
        {
            if (fields[2] == false)
            {
                fields[2] = true;
            }
            else
            {
                fields[2] = false;
            }
        }

        private void Race_Click(object sender, RoutedEventArgs e)
        {
            if (fields[3] == false)
            {
                fields[3] = true;
            }
            else
            {
                fields[3] = false;
            }
        }

        private void Profession_Click(object sender, RoutedEventArgs e)
        {
            if (fields[4] == false)
            {
                fields[4] = true;
            }
            else
            {
                fields[4] = false;
            }
        }

        private void Gender_Click(object sender, RoutedEventArgs e)
        {
            if (fields[5] == false)
            {
                fields[5] = true;
            }
            else
            {
                fields[5] = false;
            }
        }

        private void Nationality_Click(object sender, RoutedEventArgs e)
        {
            if (fields[6] == false)
            {
                fields[6] = true;
            }
            else
            {
                fields[6] = false;
            }
        }

        private void Height_Click(object sender, RoutedEventArgs e)
        {
            if (fields[7] == false)
            {
                fields[7] = true;
            }
            else
            {
                fields[7] = false;
            }
        }

        private void Weight_Click(object sender, RoutedEventArgs e)
        {
            if (fields[8] == false)
            {
                fields[8] = true;
            }
            else
            {
                fields[8] = false;
            }
        }

        private void Hair_color_Click(object sender, RoutedEventArgs e)
        {
            if (fields[9] == false)
            {
                fields[9] = true;
            }
            else
            {
                fields[9] = false;
            }
        }

        private void Eye_color_Click(object sender, RoutedEventArgs e)
        {
            if (fields[10] == false)
            {
                fields[10] = true;
            }
            else
            {
                fields[10] = false;
            }
        }

        private void Personality_Click(object sender, RoutedEventArgs e)
        {
            if (fields[11] == false)
            {
                fields[11] = true;
            }
            else
            {
                fields[11] = false;
            }
        }

        private void Likes_Click_1(object sender, RoutedEventArgs e)
        {
            if (fields[12] == false)
            {
                fields[12] = true;
            }
            else
            {
                fields[12] = false;
            }
        }

        private void Dislikes_Click_1(object sender, RoutedEventArgs e)
        {
            if (fields[13] == false)
            {
                fields[13] = true;
            }
            else
            {
                fields[13] = false;
            }
        }

        private void Hit_Points_Click(object sender, RoutedEventArgs e)
        {
            if (fields[14] == false)
            {
                fields[14] = true;
            }
            else
            {
                fields[14] = false;
            }
        }

        private void Special_Points_Click(object sender, RoutedEventArgs e)
        {
            if (fields[15] == false)
            {
                fields[15] = true;
            }
            else
            {
                fields[15] = false;
            }
        }

        private void Level_Click(object sender, RoutedEventArgs e)
        {
            if (fields[16] == false)
            {
                fields[16] = true;
            }
            else
            {
                fields[16] = false;
            }
        }

        private void Strength_Click(object sender, RoutedEventArgs e)
        {
            if (fields[17] == false)
            {
                fields[17] = true;
            }
            else
            {
                fields[17] = false;
            }
        }

        private void Dexterity_Click(object sender, RoutedEventArgs e)
        {
            if (fields[18] == false)
            {
                fields[18] = true;
            }
            else
            {
                fields[18] = false;
            }
        }

        private void Inteligence_Click(object sender, RoutedEventArgs e)
        {
            if (fields[19] == false)
            {
                fields[19] = true;
            }
            else
            {
                fields[19] = false;
            }
        }

        private void Wisdom_Click(object sender, RoutedEventArgs e)
        {
            if (fields[20] == false)
            {
                fields[20] = true;
            }
            else
            {
                fields[20] = false;
            }
        }

        private void Constitution_Click(object sender, RoutedEventArgs e)
        {
            if (fields[21] == false)
            {
                fields[21] = true;
            }
            else
            {
                fields[21] = false;
            }
        }

        private void Will_Click_1(object sender, RoutedEventArgs e)
        {
            if (fields[22] == false)
            {
                fields[22] = true;
            }
            else
            {
                fields[22] = false;
            }
        }

        private void Charisma_Click(object sender, RoutedEventArgs e)
        {
            if (fields[23] == false)
            {
                fields[23] = true;
            }
            else
            {
                fields[23] = false;
            }
        }

        private void Accent_Click(object sender, RoutedEventArgs e)
        {
            if (fields[24] == false)
            {
                fields[24] = true;
            }
            else
            {
                fields[24] = false;
            }
        }

        private void Style_Of_Dress_Click(object sender, RoutedEventArgs e)
        {
            if (fields[25] == false)
            {
                fields[25] = true;
            }
            else
            {
                fields[25] = false;
            }
        }

        private void Friends_Click(object sender, RoutedEventArgs e)
        {
            if (fields[26] == false)
            {
                fields[26] = true;
            }
            else
            {
                fields[26] = false;
            }
        }

        private void Enimies_Click(object sender, RoutedEventArgs e)
        {
            if (fields[27] == false)
            {
                fields[27] = true;
            }
            else
            {
                fields[27] = false;
            }
        }

        private void Significant_Other_Click(object sender, RoutedEventArgs e)
        {
            if (fields[28] == false)
            {
                fields[28] = true;
            }
            else
            {
                fields[28] = false;
            }
        }

        private void Fighting_Style_Click(object sender, RoutedEventArgs e)
        {
            if (fields[29] == false)
            {
                fields[29] = true;
            }
            else
            {
                fields[29] = false;
            }
        }

        private void Preferred_Weapon_Click(object sender, RoutedEventArgs e)
        {
            if (fields[30] == false)
            {
                fields[30] = true;
            }
            else
            {
                fields[30] = false;
            }
        }

        private void Favorite_food_Click(object sender, RoutedEventArgs e)
        {
            if (fields[31] == false)
            {
                fields[31] = true;
            }
            else
            {
                fields[31] = false;
            }
        }

        private void Armor_Class_Click(object sender, RoutedEventArgs e)
        {
            if (fields[32] == false)
            {
                fields[32] = true;
            }
            else
            {
                fields[32] = false;
            }
        }

        private void Proficiency_Bonus_Click(object sender, RoutedEventArgs e)
        {
            if (fields[33] == false)
            {
                fields[33] = true;
            }
            else
            {
                fields[33] = false;
            }
        }

        private void insperation_Click(object sender, RoutedEventArgs e)
        {
            if (fields[34] == false)
            {
                fields[34] = true;
            }
            else
            {
                fields[34] = false;
            }
        }

        private void perception_Click(object sender, RoutedEventArgs e)
        {
            if (fields[35] == false)
            {
                fields[35] = true;
            }
            else
            {
                fields[35] = false;
            }
        }

        private void Spellcasting_Ability_Click(object sender, RoutedEventArgs e)
        {
            if (fields[36] == false)
            {
                fields[36] = true;
            }
            else
            {
                fields[36] = false;
            }
        }

        private void Spell_Save_DC_Click(object sender, RoutedEventArgs e)
        {
            if (fields[37] == false)
            {
                fields[37] = true;
            }
            else
            {
                fields[37] = false;
            }
        }

        private void Spell_Attack_Bonus_Click(object sender, RoutedEventArgs e)
        {
            if (fields[38] == false)
            {
                fields[38] = true;
            }
            else
            {
                fields[38] = false;
            }
        }

        private void EXP_Click(object sender, RoutedEventArgs e)
        {
            if (fields[39] == false)
            {
                fields[39] = true;
            }
            else
            {
                fields[39] = false;
            }
        }

        private void Groups_Click(object sender, RoutedEventArgs e)
        {
            if (fields[40] == false)
            {
                fields[40] = true;
            }
            else
            {
                fields[40] = false;
            }
        }
    }
}

//Make the list a bool list
//Hard code each click event to a specific index
//save that list of yes and no
//when load, run a special randomize that checks each index and if yes then randomize and if no then dont.
