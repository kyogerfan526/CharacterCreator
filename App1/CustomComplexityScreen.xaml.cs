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
        List<CheckBox> fields = new List<CheckBox>();
        public CustomComplexityScreen()
        {
            this.InitializeComponent();
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
            XmlSerializer serializer = new XmlSerializer(typeof(List<CheckBox>));
            StreamWriter writer = new StreamWriter(stream);
            serializer.Serialize(writer, fields);
            writer.Close();

        }

    }
}
