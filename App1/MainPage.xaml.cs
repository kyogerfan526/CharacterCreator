using App1.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using App1;

using System.Collections.ObjectModel;
using System.Xml.Serialization;
using Windows.Storage;
using Windows.Storage.Pickers;

using System.Text;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CharacterMaker
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Random rand = new Random();

        ObservableCollection<CharacterTrait> traitsList = new ObservableCollection<CharacterTrait>();
        private FullComplexPerson pagePerson;

        public enum Genre { CONTEMPORARY, FANTASY, SCIFI };
        public enum Complexity { Simple, ModeratlyComplex, Complex, ModeratlyComplexTableTop, ComplexTableTop };

        //Bool for male/female lock
        //Gender for male/female lock
        bool genderLock = false;
        bool tableTop = false;
        String lockedGender = null;

        List<bool> Cparameters = new List<bool>();

        //Race lock
        //Genre lock
        String raceLock = null;

        Genre genreLock = Genre.FANTASY;
        Complexity complock = Complexity.Simple;

        public MainPage()
        {
            this.InitializeComponent();


            pagePerson = new FullComplexPerson();
            CharacterTraitsArea.ItemsSource = traitsList;
        }

        private void GeneratePerson()
        {
            // Clears the traitsList so that all previous values are discarded and new values can take their place.
            traitsList.Clear();
            pagePerson.Randomize(tableTop: tableTop);

            CharacterNameBlock.Text = pagePerson.FullName;

            // Adds the basic traits; use this format wherever you randomize a value on the pagePerson and then remove these
            traitsList.Add(new CharacterTrait("Age", pagePerson.Age));
            traitsList.Add(new CharacterTrait("Profession", pagePerson.Profession));
            traitsList.Add(new CharacterTrait("Race", pagePerson.Race));
            traitsList.Add(new CharacterTrait("Gender", pagePerson.Gender));

            if (complock == Complexity.ModeratlyComplex || complock == Complexity.Complex)
            {
                traitsList.Add(new CharacterTrait("Nationality", pagePerson.Nationality));
                traitsList.Add(new CharacterTrait("Height Ft", pagePerson.Heightfeet));
                traitsList.Add(new CharacterTrait("Height In", pagePerson.HeightInches));
                traitsList.Add(new CharacterTrait("Weight", pagePerson.Weight));
                traitsList.Add(new CharacterTrait("Hair Color", pagePerson.HairColor));
                traitsList.Add(new CharacterTrait("Eye Color", pagePerson.EyeColor));
                traitsList.Add(new CharacterTrait("Likes", Stringify(pagePerson.Likes)));
                traitsList.Add(new CharacterTrait("Dislikes", Stringify(pagePerson.Dislikes)));
            }
            if (complock == Complexity.Complex)
            {
                traitsList.Add(new CharacterTrait("Accent", pagePerson.Accent));
                traitsList.Add(new CharacterTrait("Style of Dress", pagePerson.StyleOfDress));
                //traitsList.Add(new CharacterTrait("Friends", pagePerson.Friends));
                //traitsList.Add(new CharacterTrait("Enemies", pagePerson.Enemies));
                //traitsList.Add(new CharacterTrait("Significant Other", pagePerson.SignificantOther));
                traitsList.Add(new CharacterTrait("Fighting Style", pagePerson.FightingStyle));
                //traitsList.Add(new CharacterTrait("Preferred Weapon", pagePerson.PreferredWeapon));
                traitsList.Add(new CharacterTrait("Favorite Food", pagePerson.FavoriteFood));
            }

            if (tableTop)
            {
                ObservableCollection<TableTopStats> stats = new ObservableCollection<TableTopStats>();
                stats.Add(pagePerson.Stats);
                TTSArea.ItemsSource = stats;
            }
        }


        private void GenerateCustomPerson(List<bool> CustomParameters)
        {
            // Clears the traitsList so that all previous values are discarded and new values can take their place.
            int index = 0;
            traitsList.Clear();
            pagePerson.Randomize(tableTop: tableTop);

            // Adds the basic traits; use this format wherever you randomize a value on the pagePerson and then remove these
            traitsList.Add(new CharacterTrait("Age", pagePerson.Age));
            traitsList.Add(new CharacterTrait("Profession", pagePerson.Profession));
            traitsList.Add(new CharacterTrait("Race", pagePerson.Race));
            traitsList.Add(new CharacterTrait("Gender", pagePerson.Gender));

            if (complock == Complexity.ModeratlyComplex || complock == Complexity.Complex)
            {
                traitsList.Add(new CharacterTrait("Nationality", pagePerson.Nationality));
                traitsList.Add(new CharacterTrait("Height Ft", pagePerson.Heightfeet));
                traitsList.Add(new CharacterTrait("Height In", pagePerson.HeightInches));
                traitsList.Add(new CharacterTrait("Weight", pagePerson.Weight));
                traitsList.Add(new CharacterTrait("Hair Color", pagePerson.HairColor));
                traitsList.Add(new CharacterTrait("Eye Color", pagePerson.EyeColor));
                traitsList.Add(new CharacterTrait("Likes", Stringify(pagePerson.Likes)));
                traitsList.Add(new CharacterTrait("Dislikes", Stringify(pagePerson.Dislikes)));
            }
            if (complock == Complexity.Complex)
            {
                traitsList.Add(new CharacterTrait("Accent", pagePerson.Accent));
                traitsList.Add(new CharacterTrait("Style of Dress", pagePerson.StyleOfDress));
                //traitsList.Add(new CharacterTrait("Friends", pagePerson.Friends));
                //traitsList.Add(new CharacterTrait("Enemies", pagePerson.Enemies));
                //traitsList.Add(new CharacterTrait("Significant Other", pagePerson.SignificantOther));
                traitsList.Add(new CharacterTrait("Fighting Style", pagePerson.FightingStyle));
                //traitsList.Add(new CharacterTrait("Preferred Weapon", pagePerson.PreferredWeapon));
                //traitsList.Add(new CharacterTrait("Favorite Food", pagePerson.FavoriteFood));
            }

            if (tableTop)
            {
                ObservableCollection<TableTopStats> stats = new ObservableCollection<TableTopStats>();
                stats.Add(pagePerson.Stats);
                TTSArea.ItemsSource = stats;
            }
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Hm
        }

        private void RandomizeButton_Click(object sender, RoutedEventArgs e)
        {
            // Randomize Button
            GeneratePerson();

        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            // Edit Button
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            // Back Button
        }

        private async void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var savePicker = new Windows.Storage.Pickers.FileSavePicker();
            savePicker.SuggestedStartLocation =
            Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;
            // Dropdown of file types the user can save the file as
            savePicker.FileTypeChoices.Add("Plain Text", new List<string>() { ".txt" });
            // Default file name if the user does not type one in or select a file to replace
            savePicker.SuggestedFileName = "New Document";
            Windows.Storage.StorageFile file = await savePicker.PickSaveFileAsync();
            if (file != null)
            {
                Windows.Storage.CachedFileManager.DeferUpdates(file);
                await Windows.Storage.FileIO.WriteTextAsync(file, file.Name);
                if (complock == Complexity.Simple && pagePerson != null)
                {
                    await Windows.Storage.FileIO.WriteTextAsync(file, pagePerson.ToString());
                }
                else if (complock == Complexity.ModeratlyComplex && pagePerson != null)
                {
                    await Windows.Storage.FileIO.WriteTextAsync(file, pagePerson.ToString());
                }
                else if (complock == Complexity.ModeratlyComplexTableTop && pagePerson != null)
                {
                    await Windows.Storage.FileIO.WriteTextAsync(file, pagePerson.ToString());
                }
                else if (complock == Complexity.Complex && pagePerson != null)
                {
                    await Windows.Storage.FileIO.WriteTextAsync(file, pagePerson.ToString());
                }
                else if (complock == Complexity.ComplexTableTop && pagePerson != null)
                {
                    await Windows.Storage.FileIO.WriteTextAsync(file, pagePerson.ToString());
                }

                Windows.Storage.Provider.FileUpdateStatus status =
                await Windows.Storage.CachedFileManager.CompleteUpdatesAsync(file);
            }

        }

        private async void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            FileOpenPicker picker = new FileOpenPicker();
            picker.ViewMode = PickerViewMode.Thumbnail;
            picker.SuggestedStartLocation = PickerLocationId.Desktop;
            picker.FileTypeFilter.Add(".rndc");
            picker.FileTypeFilter.Add(".xml");

            StorageFile file = await picker.PickSingleFileAsync();
            Read(file);

        }

        private async void Read(StorageFile file)
        {
            if (file == null)
            {
                return;
            }

            Stream stream = await file.OpenStreamForReadAsync();
            XmlSerializer serializer = new XmlSerializer(typeof(List<bool>));
            Cparameters = (List<bool>)serializer.Deserialize(stream);

            complock = Complexity.ComplexTableTop;
            traitsList.Clear();
            GenerateCustomPerson(Cparameters);

            int index = 0;

            foreach (bool b in Cparameters)
            {
                if (b == true)
                {
                    //    if (index == 0)
                    //    {
                    //        traitsList.Add(new CharacterTrait("First Name", ComplexPerson_Tabletop_PagePerson.FName));
                    //    }
                    //    else if (index == 1)
                    //    {
                    //        traitsList.Add(new CharacterTrait("Last Name", ComplexPerson_Tabletop_PagePerson.LName));
                    //    }
                    //    else if (index == 2)
                    //    {
                    //        traitsList.Add(new CharacterTrait("Age", ComplexPerson_Tabletop_PagePerson.Age));
                    //    }
                    //    else if (index == 3)
                    //    {
                    //        traitsList.Add(new CharacterTrait("Race", ComplexPerson_Tabletop_PagePerson.Race));
                    //    }
                    //    else if (index == 4)
                    //    {
                    //        traitsList.Add(new CharacterTrait("Profession", ComplexPerson_Tabletop_PagePerson.Profession));
                    //    }
                    //    else if (index == 5)
                    //    {
                    //        traitsList.Add(new CharacterTrait("Gender", ComplexPerson_Tabletop_PagePerson.Gender));
                    //    }
                    //    else if (index == 6)
                    //    {
                    //        traitsList.Add(new CharacterTrait("Nationality", ComplexPerson_Tabletop_PagePerson.Nationality));
                    //    }
                    //    else if (index == 7)
                    //    {
                    //        traitsList.Add(new CharacterTrait("Height", ComplexPerson_Tabletop_PagePerson.Heightfeet));
                    //    }
                    //    else if (index == 8)
                    //    {
                    //        traitsList.Add(new CharacterTrait("Weight", ComplexPerson_Tabletop_PagePerson.Weight));
                    //    }
                    //    else if (index == 9)
                    //    {
                    //        traitsList.Add(new CharacterTrait("Hair color", ComplexPerson_Tabletop_PagePerson.HairColor));
                    //    }
                    //    else if (index == 10)
                    //    {
                    //        traitsList.Add(new CharacterTrait("Eye color", ComplexPerson_Tabletop_PagePerson.EyeColor));
                    //    }
                    //    else if (index == 11)
                    //    {
                    //        traitsList.Add(new CharacterTrait("Personality", ComplexPerson_Tabletop_PagePerson.Personality));
                    //    }
                    //    else if (index == 12)
                    //    {
                    //        traitsList.Add(new CharacterTrait("Likes", ComplexPerson_Tabletop_PagePerson.Likes));
                    //    }
                    //    else if (index == 13)
                    //    {
                    //        traitsList.Add(new CharacterTrait("Dislikes", ComplexPerson_Tabletop_PagePerson.Dislikes));
                    //    }
                    //    else if (index == 14)
                    //    {
                    //        traitsList.Add(new CharacterTrait("Hit points", ComplexPerson_Tabletop_PagePerson.HitPoints));
                    //    }
                    //    else if (index == 15)
                    //    {
                    //        traitsList.Add(new CharacterTrait("Special points", ComplexPerson_Tabletop_PagePerson.SpecialPoints));
                    //    }
                    //    else if (index == 16)
                    //    {
                    //        traitsList.Add(new CharacterTrait("Level", ComplexPerson_Tabletop_PagePerson.Level));
                    //    }
                    //    else if (index == 17)
                    //    {
                    //        traitsList.Add(new CharacterTrait("Strength", ComplexPerson_Tabletop_PagePerson.Strength));
                    //    }
                    //    else if (index == 18)
                    //    {
                    //        traitsList.Add(new CharacterTrait("Dexterity", ComplexPerson_Tabletop_PagePerson.Dexterity));
                    //    }
                    //    else if (index == 19)
                    //    {
                    //        traitsList.Add(new CharacterTrait("Inteligence", ComplexPerson_Tabletop_PagePerson.Intelligence));
                    //    }
                    //    else if (index == 20)
                    //    {
                    //        traitsList.Add(new CharacterTrait("Wisdom", ComplexPerson_Tabletop_PagePerson.Wisdom));
                    //    }
                    //    else if (index == 21)
                    //    {
                    //        traitsList.Add(new CharacterTrait("Constitution", ComplexPerson_Tabletop_PagePerson.Constitution));
                    //    }
                    //    else if (index == 22)
                    //    {
                    //        traitsList.Add(new CharacterTrait("Will", ComplexPerson_Tabletop_PagePerson.Will));
                    //    }
                    //    else if (index == 23)
                    //    {
                    //        traitsList.Add(new CharacterTrait("Charisma", ComplexPerson_Tabletop_PagePerson.Charisma));
                    //    }
                    //    else if (index == 24)
                    //    {
                    //        traitsList.Add(new CharacterTrait("Accent", ComplexPerson_Tabletop_PagePerson.Accent));
                    //    }
                    //    else if (index == 25)
                    //    {
                    //        traitsList.Add(new CharacterTrait("Style of dress", ComplexPerson_Tabletop_PagePerson.StyleOfDress));
                    //    }
                    //    else if (index == 26)
                    //    {
                    //        traitsList.Add(new CharacterTrait("Friends", ComplexPerson_Tabletop_PagePerson.Friends));
                    //    }
                    //    else if (index == 27)
                    //    {
                    //        traitsList.Add(new CharacterTrait("Enimes", ComplexPerson_Tabletop_PagePerson.Enemies));
                    //    }
                    //    else if (index == 28)
                    //    {
                    //        traitsList.Add(new CharacterTrait("Significant other", ComplexPerson_Tabletop_PagePerson.SignificantOther));
                    //    }
                    //    else if (index == 29)
                    //    {
                    //        traitsList.Add(new CharacterTrait("Fighting style", ComplexPerson_Tabletop_PagePerson.FightingStyle));
                    //    }
                    //    else if (index == 30)
                    //    {
                    //        traitsList.Add(new CharacterTrait("preferred weapon", ComplexPerson_Tabletop_PagePerson.PreferredWeapon));
                    //    }
                    //    else if (index == 31)
                    //    {
                    //        traitsList.Add(new CharacterTrait("Favorite food", ComplexPerson_Tabletop_PagePerson.FavoriteFood));
                    //    }
                    //    else if (index == 32)
                    //    {
                    //        traitsList.Add(new CharacterTrait("Armor class", ComplexPerson_Tabletop_PagePerson.Armor_Class));
                    //    }
                    //    else if (index == 33)
                    //    {
                    //        traitsList.Add(new CharacterTrait("Proficiency bonus", ComplexPerson_Tabletop_PagePerson.Proficiency_bonus));
                    //    }
                    //    else if (index == 34)
                    //    {
                    //        traitsList.Add(new CharacterTrait("Insperation", ComplexPerson_Tabletop_PagePerson.Inspiration));
                    //    }
                    //    else if (index == 35)
                    //    {
                    //        traitsList.Add(new CharacterTrait("Perception", ComplexPerson_Tabletop_PagePerson.Perception));
                    //    }
                    //    else if (index == 36)
                    //    {
                    //        traitsList.Add(new CharacterTrait("Spell casting ability", ComplexPerson_Tabletop_PagePerson.Spellcasting_ability));
                    //    }
                    //    else if (index == 37)
                    //    {
                    //        traitsList.Add(new CharacterTrait("Spell save DC", ComplexPerson_Tabletop_PagePerson.Spell_save_DC));
                    //    }
                    //    else if (index == 38)
                    //    {
                    //        traitsList.Add(new CharacterTrait("Spell attack bonus", ComplexPerson_Tabletop_PagePerson.Spell_attack_bonus));
                    //    }
                    //    else if (index == 39)
                    //    {
                    //        traitsList.Add(new CharacterTrait("EXP", ComplexPerson_Tabletop_PagePerson.EXP));
                    //    }
                    //    else if (index == 40)
                    //    {
                    //        traitsList.Add(new CharacterTrait("Groups", ComplexPerson_Tabletop_PagePerson.Groups));
                    //    }
                    //    index++;
                    //}
                    //else
                    //{
                    //    index++;
                    //}
                }

            }

        }
        private void Real_Life_Click(object sender, RoutedEventArgs e)
        {
            genreLock = Genre.CONTEMPORARY;
        }

        private void Fantasy_Click(object sender, RoutedEventArgs e)
        {
            genreLock = Genre.FANTASY;
        }

        private void Sci_Fi_Click(object sender, RoutedEventArgs e)
        {
            genreLock = Genre.SCIFI;
        }

        private void Simple_Click(object sender, RoutedEventArgs e)
        {
            complock = Complexity.Simple;
        }

        private void Moderatly_complex_Click(object sender, RoutedEventArgs e)
        {
            complock = Complexity.ModeratlyComplex;
        }

        private void Complex_Click(object sender, RoutedEventArgs e)
        {
            complock = Complexity.Complex;
        }

        private void Custom_Randomization_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CustomComplexityScreen));
        }

        private void Table_top_fields_Click(object sender, RoutedEventArgs e)

        {
            if (tableTop)
            {
                tableTop = false;
                MenuFlyoutItem MFI = (MenuFlyoutItem)sender;
                MFI.Text = "Table top fields: Off";
            }
            else
            {
                tableTop = true;
                MenuFlyoutItem MFI = (MenuFlyoutItem)sender;
                MFI.Text = "Table top fields: On";
            }
        }

        private string Stringify(string[] aaa)
        {
            StringBuilder sb = new StringBuilder();

            foreach (string a in aaa)
            {
                sb.Append(a).Append(", ");
            }
            sb.Remove((sb.Length - 2), 2);

            return sb.ToString();
        }
    }

public struct CharacterTrait
    {
        public CharacterTrait(string traitName, object traitValue)
        {
            TraitName = traitName;
            TraitValue = traitValue;
        }
        public string TraitName { get; set; }
        public object TraitValue { get; set; }
    }

}
