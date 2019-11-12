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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CharacterMaker
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    
    public sealed partial class MainPage : Page
    {

        List<String> FNames = new List<String> { "Kevin", "Mark", "Linda", "James", "Josh", "Leon", "Carly", "Bridget", "Tim", "Carl", "Arthur", "Ben", "Greg", "Craig", "Laura", "Jessie", 
        "Alex", "Paul", "Anthony", "Tyler", "Cheeki", "Gopnik", "Joseph", "Broseph", "Adolf", "Rudolf", "Hans", "Xiang", "Po", "Wei", "Sun", "Cho", "Sho", "Mizuki", "Kanada", "Tsubaraya",
        "Jacque", "Edmon", "Amy", "Lee", "Sandra", "Monique", "Shawna", "Monica", "Troy", "Randall", "Michaeal", "Jacob", "Tyrone", "Tyson", "Kyle", "Adam", "Lilith", "Eve", "Eva", "Leonidas",
        "Brock", "Peter", "Pan", "Patrick", "Patricia"};

        List<String> LNames =  new List<String> { "Him", "Quent", "Hue", "O'Malley", "O'Hannon", "McKinley", "Nelly", "Brannon", "Siegward", "Von Lichtenstein", "Brauswitz", "Gregory", "Petrikov",
        "Breeki", "McBylat", "Stalin", "Krieger", "Waffen", "Woods", "Stone", "Smith", "Feldspar", "McSwagger", "McLovin", "McDonald", "Feng", "Minoru", "Arisato", "Dojima", "Elric",
        "Gruber", "Jameson", "Daniels", "Foreman", "Freeman", "Jackson", "Goldberg", "Calden"};

        List<String> Professions = new List<String> { "Athlete", "Actor", "Physicasist", "Teacher", "Translator", "Manager", "CEO", "Janitor", "Coach", "Personal trainer", "Musician",
        "Computer Scientist", "Sales person", "Groundskeeper", "Stunt double", "Youtuber", "Twitch streamer", "Artist", "Chef", "Military", "Judge", "police officer", "Executioner", "Taxi Driver",
        "Stock Broker", "Real Estate Agent", "Unemployed", "Nursing assistant", "Nurse", "Doctor", "Psychologist", "Dairy Farmer", "Rancher", "Monocultural Farmer", "Fisherman", "Zoologist", "Marine Biologist",
        "Comedian", "Tech Support", "Rockstar", "Panhandler", "Porn Star", "Mayor", "Secretary", "Governor", "Vice President", "President", "CFO", "COO", "Small Business Owner", "Drug Dealer", 
        "Pharmacist", "Construction Worker", "MMA Fighter", "Wrestler", "Performance Wrestler", "Olympic Athlete", "Model", "Stunt Driver", "Race Car Driver", "Historian", "Librarian", "Professional Protester",
        "Federal Officer", "Mixer Sellout Streamer", "Troglodyte", "Attack Helicopter Operator", "News Helicopter Operator", "News Van Operator", "Test Subject",
        "Fraud", "Petty Thief", "Bank Robber", "MLG Pro", "Indie Film Director", "Train Conductor", "Private Security Officer", "Bodyguard", "Dog Breeder", "Undertaker", "Factory Worker",
        "Mechanic", "Retired", "Video Game Developer", "Music Composer", "Supermarket Employee", "Supermarket Manager"};

        List<String> Races = new List<String> { "Caucasian", "African", "Latinx", "East-Asian", "Arab", "Indian" };

        List<String> Genders = new List<String> { "Male", "Female" };

        String Name = "";
        int age;
        String Profession = "";
        String Race = "";
        String Gender = "";

        Random rand = new Random();

        private DefaultPerson pagePerson;

        public MainPage()
        {
            this.InitializeComponent();
            pagePerson = new DefaultPerson();


            //pagePerson.FName = "Test Name";
            //pagePerson.Age = 12;
            //pagePerson.Race = "Test Race";
            //pagePerson.Profession = "Test Profession";
            //pagePerson.Gender = "Test Gender";

            pagePerson.FName = FNames[rand.Next(6)];
            pagePerson.LName = LNames[rand.Next(6)];
            pagePerson.Age = rand.Next(101);
            pagePerson.Profession = Professions[rand.Next(20)];
            pagePerson.Gender = Genders[rand.Next(2)];
            pagePerson.Race = Races[rand.Next(7)];

            MainGrid.DataContext = pagePerson;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Hm
        }

        private void RandomizeButton_Click(object sender, RoutedEventArgs e)
        {
            // Randomize Button
            //DefaultPerson p = new DefaultPerson();
            pagePerson.FName = FNames[rand.Next(6)];
            pagePerson.LName = LNames[rand.Next(6)];
            pagePerson.Age = rand.Next(101);
            pagePerson.Profession = Professions[rand.Next(20)];
            pagePerson.Gender = Genders[rand.Next(2)];
            pagePerson.Race = Races[rand.Next(7)];
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            // Edit Button
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            // Back Button
        }
    }
}
