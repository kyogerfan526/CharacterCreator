using App1.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.IO;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Collections.ObjectModel;
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
        public enum Complexity { Simple, ModeratlyComplex, Complex, ModeratlyComplexTableTop };

        //Bool for male/female lock
        bool genderLock = false;
        //Gender for male/female lock
        String lockedGender = null;

        //Race lock
        String raceLock = null;
        //Genre lock
        Genre genreLock = Genre.FANTASY;
        // Complexity lock
        Complexity complock = Complexity.Simple;
        // 
        bool tableTop = false;


        public MainPage()
        {
            this.InitializeComponent();
            pagePerson = new FullComplexPerson();
            CharacterNameBlock.DataContext = pagePerson;
            CharacterTraitsArea.ItemsSource = traitsList;
        }

        private void GeneratePerson()
        {
            // Clears the traitsList so that all previous values are discarded and new values can take their place.
            traitsList.Clear();
            pagePerson.Randomize(tableTop:tableTop);

            // Adds the basic traits; use this format wherever you randomize a value on the pagePerson and then remove these
            traitsList.Add(new CharacterTrait("Age", pagePerson.Age));
            traitsList.Add(new CharacterTrait("Profession", pagePerson.Profession));
            traitsList.Add(new CharacterTrait("Race", pagePerson.Race));
            traitsList.Add(new CharacterTrait("Gender", pagePerson.Gender));

            if (complock == Complexity.ModeratlyComplex || complock == Complexity.Complex) {
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
            } else
            {
                TTSArea.ItemsSource = null;
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

                    await Windows.Storage.FileIO.WriteTextAsync(file, pagePerson.ToString());

                    Windows.Storage.Provider.FileUpdateStatus status =
                    await Windows.Storage.CachedFileManager.CompleteUpdatesAsync(file);
                }
        }

        private async void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            // LoadButton

        }

        private void Custom_Randomization_Click(object sender, RoutedEventArgs e)
        {
            // ???

        }

        private void complex_table_top_Click(object sender, RoutedEventArgs e)
        {
            complock = Complexity.Complex;
            tableTop = true;

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
            tableTop = false;
        }

        private void Moderatly_complex_Click(object sender, RoutedEventArgs e)
        {
            complock = Complexity.ModeratlyComplex;
            tableTop = false;
        }

        private void Moderatly_complex_table_top_Click(object sender, RoutedEventArgs e)
        {
            complock = Complexity.ModeratlyComplex;
            tableTop = true;
        }

        private void Complex_Click(object sender, RoutedEventArgs e)
        {
            complock = Complexity.Complex;
            tableTop = false;
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
