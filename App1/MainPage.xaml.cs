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
        "Brock", "Peter", "Pan", "Patrick", "Patricia", "Chrone", "Charlie", "Kevin", "Abigail", "Cynthia", "Alfred", "Alan", "Burt", "Pan", "Mel", "Johnathan", "Yosuke", "Daisuke",
        "Suda", "Hideki", "Hideakki", "Eduardo", "Juan", "Enrique", "Pedro", "Hermano", "Gustav", "Melissa", "Elizabeth", "Agatha", "Margaret", "Amanda", "Ramona", "Julie", "Julia",
        "Zoe", "Patti", "Alice", "Allison", "Miranda", "Charlise", "Charlene", "LeShauna", "Lily", "May", "August", "Summer", "Morgan", "Bailey", "Justine" };

        List<String> MFNames = new List<String> { "Kevin", "Mark", "James", "Josh", "Leon", "Tim", "Carl", "Arthur", "Ben", "Greg", "Craig", "Jessie",
        "Alex", "Paul", "Anthony", "Tyler", "Cheeki", "Gopnik", "Joseph", "Broseph", "Adolf", "Rudolf", "Hans", "Xiang", "Po", "Wei", "Sun", "Cho", "Sho", "Mizuki", "Tsubaraya",
        "Jacque", "Edmon", "Lee", "Troy", "Randall", "Michaeal", "Jacob", "Tyrone", "Tyson", "Kyle", "Adam", "Leonidas", "Brock", "Peter", "Pan", "Patrick", "Chrone", "Charlie",
        "Kevin", "Alfred", "Alan", "Burt", "Pan", "Mel", "Johnathan", "Yosuke", "Daisuke", "Suda", "Hideki", "Hideakki", "Eduardo", "Juan", "Enrique", "Pedro", "Hermano", "Gustav", "Aaron"};

        List<String> FFNames = new List<String> { "Linda", "Carly", "Bridget", "Laura", "Jessie", "Alex", "Tyler", "Po", "Wei", "Sun", "Mizuki", "Kanada", "Amy", "Lee", "Sandra", "Monique", 
        "Shawna", "Monica", "Lilith", "Eve", "Eva", "Patricia", "Charlie", "Abigail", "Cynthia", "Pan", "Mel", "Melissa", "Elizabeth", "Agatha", "Margaret", "Amanda", "Ramona", "Julie", "Julia",
        "Zoe", "Patti", "Alice", "Allison", "Miranda", "Charlise", "Charlene", "LeShauna", "Lily", "May", "August", "Summer", "Morgan", "Bailey", "Justine", "Caroline", "Kathleen",
        "Coco", "Chelsie", "Ami", "Lucy", "Luci", "Zoey", "Mila", "Yoko", "Ikumi", "Jane", "Erin"};

        List<String> LNames = new List<String> { "Him", "Quent", "Hue", "O'Malley", "O'Hannon", "McKinley", "Nelly", "Brannon", "Siegward", "Von Lichtenstein", "Brauswitz", "Gregory", "Petrikov",
        "Breeki", "McBylat", "Stalin", "Krieger", "Waffen", "Woods", "Stone", "Smith", "Feldspar", "McSwagger", "McLovin", "McDonald", "Feng", "Minoru", "Arisato", "Dojima", "Elric",
        "Gruber", "Jameson", "Daniels", "Foreman", "Freeman", "Jackson", "Goldberg", "Calden", "Ridgewell", "Davis", "Herrington", "Bouregard", "Moore", "Murphy", "Miyamoto", "Miyazaki",
        "Sakuya", "Kane", "Kang", "Khan", "Parker", "Lemoine", "Schultz", "Lamarche", "Capone", "Kaiser", "Tsukuyama", "Ishiwatari", "Kamiya", "Lopez", "Hernendez", "Ilios", "Sanchez"};

        List<String> Professions = new List<String> { "Athlete", "Actor", "Physicist", "Teacher", "Translator", "Manager", "CEO", "Janitor", "Coach", "Personal trainer", "Musician",
        "Computer Scientist", "Sales person", "Groundskeeper", "Stunt double", "Youtuber", "Twitch streamer", "Artist", "Chef", "Military", "Judge", "police officer", "Executioner", "Taxi Driver",
        "Stock Broker", "Real Estate Agent", "Unemployed", "Nursing assistant", "Nurse", "Doctor", "Psychologist", "Dairy Farmer", "Rancher", "Monocultural Farmer", "Fisherman", "Zoologist", "Marine Biologist",
        "Comedian", "Tech Support", "Rockstar", "Panhandler", "Porn Star", "Mayor", "Secretary", "Governor", "Vice President", "President", "CFO", "COO", "Small Business Owner", "Drug Dealer",
        "Pharmacist", "Construction Worker", "MMA Fighter", "Wrestler", "Performance Wrestler", "Olympic Athlete", "Model", "Stunt Driver", "Race Car Driver", "Historian", "Librarian", "Professional Protester",
        "Federal Officer", "Mixer Sellout Streamer", "Troglodyte", "Attack Helicopter Operator", "News Helicopter Operator", "News Van Operator", "Test Subject",
        "Fraud", "Petty Thief", "Bank Robber", "MLG Pro", "Indie Film Director", "Train Conductor", "Private Security Officer", "Bodyguard", "Dog Breeder", "Undertaker", "Factory Worker",
        "Mechanic", "Retired", "Video Game Developer", "Music Composer", "Supermarket Employee", "Supermarket Manager", "Circus Clown", "Zookeeper", "Paleontologist", "Cartel Kingpin"};

        List<String> MinorProfessions = new List<String> { "Actor", "Manager", "Janitor", "Musician", "Groundskeeper", "Youtuber", "Twitch streamer", "Artist", "Fry Cook",
        "Unemployed", "Dairy Farmer", "Rancher", "Monocultural Farmer", "Comedian", "Rockstar", "Panhandler", "Small Business Owner",
        "Mixer Sellout Streamer", "MLG Pro", "Indie Film Director", "Dog Breeder", "Undertaker", "Supermarket Employee", "Supermarket Manager", "Circus Clown"};

        List<String> FantasyProfessions = new List<String> { "Wheat Farmer", "Lord", "Quartermaster", "Guild Head", "Necromancer", "Wizard", "Warlock", "Witch", "Monk", "Priest", "Cleric"
        , "Doctor", "Plague Doctor", "Knight", "Personal Guard", "Town Guard", "Militia", "Bandit", "Thief", "Smuggler", "Barkeeper", "Barmaid", "Tavern Wench", "Barbarian", "Town Fool",
        "Bard", "Jester", "Dark knight", "Cultist", "Assassin", "Mercenary", "Paladin", "Bounty Hunter", "Monster Hunter", "Monster Tamer", "Animal Tamer", "Dragon Breeder", "Village Chief",
        "Monarch", "Emperor", "Pirate", "Pirate Captain", "Helmsman", "Blacksmith", "Traveling Merchant", "Hunter", "Archer", "Footsoldier", "Platoon Commandant", "Scholar", "Military General", "Alchemist",
        "Pugulist", "Ward", "Lich", "Possessed Thrawl", "Potato Farmer", "Horse Rancher", "Dragoon", "Warrior", "Royal Guard", "Rebel", "Rebellion Leader"};

        List<String> SciFiProfessions = new List<String> { "Smuggler", "Space Pirate", "Starship Pilot", "Researcher", "Starship Captain", "Mad Scientist", "Gene Therapist",
        "Hacker", "Starship Mechanic", "Demolitions Expert", "Corporate Overlord", "Scavenger", "Galactic Patrol Officer", "Asteroid Miner", "Scholar", "Galactic Ambassador", "Scientist",
        "Military Scientist", "Planetary Leader", "Trasnhumanist", "Planet Colonizer", "Remote Android Operator", "Super-Drug dealer", "Blackmarket Arms Dealer",
        "Blackmarket Arms Manufacturer", "Blackmarket Organ Seller", "Doctor", "Spy", "Federal Agent", "Diplomat", "Military Commandant", "Junk Trader"};

        List<String> FantasyRaces = new List<String> { "Dwarf", "High Elf", "Wood Elf", "Dark Elf", "Half-Giant", "Gnome", "Human", "Lizard-Man", "Beast-Man", "Bird-Man", "Orc", "Goblin",
        "Skeleton", "Mermaid/man", "Spectre", "Halfling"};
        
        List<String> SciFiRaces = new List<String> { "Human", "Martian", "Slug-Man", "Grey Alien", "Symbiote", "Kaiju", "Cyborg", "Android", "Humanoid E.T.", "Cronenberg", "Genetic Hybrid" };

        List<String> Races = new List<String> { "Anglo", "Saxon", "Anglo-Saxon", "Gaelic", "Nordic", "Scandinavian", "African", "Turkish", "Armenian", "Albanian", "Granadan",
        "Jamaican", "Latinx", "East-Asian", "Central-Asian", "Southeast-Asian", "Arab", "Indian", "Egyptian", "South American", "Aborigine", "Native American" };

        List<String> Genders = new List<String> { "Male", "Female" };

        Random rand = new Random();

        private DefaultPerson pagePerson;
        public enum Genre { CONTEMPORARY, FANTASY, SCIFI };

        //Bool for male/female lock
        //Gender for male/female lock
        bool genderLock = false;
        String lockedGender = null;

        //Race lock
        //Genre lock
        String raceLock = null;
        Genre genreLock = Genre.FANTASY;


        public MainPage()
        {
            this.InitializeComponent();
            
            pagePerson = new DefaultPerson();

            MainGrid.DataContext = pagePerson;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Hm
        }

        private void RandomizeButton_Click(object sender, RoutedEventArgs e)
        {
            // Randomize Button
            if (genderLock)
            {
                if (lockedGender == "Male")
                {
                    pagePerson.FName = MFNames[rand.Next(MFNames.Count)];
                }
                else if (lockedGender == "Female")
                {
                    pagePerson.FName = FFNames[rand.Next(FFNames.Count)];
                }
            }
            else 
            {
                pagePerson.FName = FNames[rand.Next(FNames.Count)];
            }
            pagePerson.LName = LNames[rand.Next(LNames.Count)];

            pagePerson.Age = rand.Next(101);
            if (genreLock == Genre.CONTEMPORARY)
            {
                if (pagePerson.Age < 18)
                {
                        pagePerson.Profession = MinorProfessions[rand.Next(MinorProfessions.Count)];
                }
                else
                {
                        pagePerson.Profession = Professions[rand.Next(Professions.Count)];
                }
            }
            else if (genreLock == Genre.FANTASY)
            {
                    pagePerson.Profession = FantasyProfessions[rand.Next(FantasyProfessions.Count)];
            }
            else if (genreLock == Genre.SCIFI)
            {
                    pagePerson.Profession = FantasyProfessions[rand.Next(FantasyProfessions.Count)];
            }

            if (genderLock)
            {
                pagePerson.Gender = lockedGender;
            }
            else
            {
                pagePerson.Gender = Genders[rand.Next(Genders.Count)];
            }

            if (raceLock != null)
            {
                pagePerson.Race = raceLock;
            }
            else 
            {
                pagePerson.Race = Races[rand.Next(Races.Count)];
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            // Edit Button
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            // Back Button
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
