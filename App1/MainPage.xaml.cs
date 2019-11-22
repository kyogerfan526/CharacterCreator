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
        "Mixer Sellout Streamer", "MLG Pro", "Indie Film Director", "Dog Breeder", "Supermarket Employee", "Supermarket Manager", "Circus Clown"};

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

        List<String> Nationalities = new List<String> { "USA", "China", "Russia", "UK", "Canada", "Mexico", "Japan", "Saudi Arabia", "South Africa", "Sudan" };

        List<String> fantasyNationalities = new List<String>();

        List<String> scifiNationalities = new List<String>();

        List<String> hairColors = new List<String> { "Blonde", "Gray", "Brown", "Red", "Ginger", "Brunette", "Black", "Dark Brown", "White", "Platinum Blonde", "Dirty Blonde", "Reddish Brown"};

        List<String> eyeColors = new List<String> { "Blue", "Brown", "Dark Brown", "Hazel", "Green" };

        List<String> personalities = new List<String> { "Reserved", "Snobby", "Sporty", "Kindhearted", "Merrymaker", "Jokester", "Angry", "Bitter", "Depressed", "Bubbly", "Quiet", "Timid" };

        List<String> likes = new List<String> { "Cats", "Dogs", "Memes", "Sportsball", "Poker", "Gambling", "Movies", "Adventures", "Swimming", "Fishing", "Cartoons", "Cooking", "Cars", "Sleeping" };

        List<String> accents = new List<String> { "Southern", "Yooper", "New Orleans", "Valley", "New York", "Boston", "Jersey", "Chicago", "Manitowoc", "non-native", "Cockney", "London", "Hindi", "Slavic", "Irish", "Scottish" };

        List<String> dressStyles = new List<String> { "Basic", "Urban", "Nerdy", "Formal", "Trendy", "Business", "Business Casual", "Casual", "Extreme Casual", "punk", "athletic" };

        List<String> fightingStyles = new List<String> { "Scrappy", "Wimpy", "Western Martial Arts", "Eastern Martial Arts", "MMA", "Wrestling", "Dirty", "Police/Military" };

        List<String> foods = new List<String> { "Lasgna", "Pizza", "Bacon and Eggs", "Cake", "Candy", "Fried Chicken", "Pasta", "Steak", "Burger and Fries", "Milkshake", "Donuts", "Ice Cream" };

        List<String> groups = new List<String> { "PTA", "Volunteer Firefighters", "Book Club", "Local Boxing Gym", "Local Cult", "Worker's Union" };

        List<String> fantasyGroups = new List<String> { "Monster Hunters Guild", "Mages Guild", "Order of The Holy Knights", "Necromancies Congregation", "Church of Dagon", "Church of The Holy Goddess", "Royal Inquisitors" };

        List<String> scifiGroups = new List<String> { "Megacorp Union", "Hacker Gang", "Space Mafia", "Cyborg Advocates" };

        List<String> ArmorClasses = new List<string> { "Heavy", "Light", "Cloke", "Shroud", "Wizard robes", "Leaves", "Wood", "Chainmail" };

        Random rand = new Random();

        ObservableCollection<CharacterTrait> traitsList = new ObservableCollection<CharacterTrait>();
        private DefaultPerson pagePerson;
        private ModeratelyComplexPerson ModeratlyComplexPagePerson;
        private ComplexPerson ComplexPagePerson;
        private ModeratelyComplexPerson_Tabletop ModeratelyComplexPerson_Tabletop_PagePerson;
        private ComplexPerson_Tabletop ComplexPerson_Tabletop_PagePerson;
        public enum Genre { CONTEMPORARY, FANTASY, SCIFI };
        public enum Complexity { Simple, ModeratlyComplex, Complex, ModeratlyComplexTableTop, ComplexTableTop };

        //Bool for male/female lock
        //Gender for male/female lock
        bool genderLock = false;
        String lockedGender = null;

        //Race lock
        //Genre lock
        String raceLock = null;

        Genre genreLock = Genre.FANTASY;
        Complexity complock = Complexity.Simple;

        public MainPage()
        {
            this.InitializeComponent();
            
            pagePerson = new DefaultPerson();

            CharacterNameBlock.DataContext = pagePerson;
            CharacterTraitsArea.ItemsSource = traitsList;
        }

        private void GeneratePerson()
        {
            // Clears the traitsList so that all previous values are discarded and new values can take their place.
            traitsList.Clear();


            if (complock == Complexity.Simple)
            {
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
                        if (pagePerson.Age < 14)
                        {
                            pagePerson.Profession = "Unemployed";
                        }
                        else
                        {
                            pagePerson.Profession = MinorProfessions[rand.Next(MinorProfessions.Count)];
                        }
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
            else if (complock == Complexity.ModeratlyComplex) //complexity
            {
                if (genderLock)
                {
                    if (lockedGender == "Male")
                    {
                        ModeratlyComplexPagePerson.FName = MFNames[rand.Next(MFNames.Count)];
                        traitsList.Add(new CharacterTrait("First Name", ModeratlyComplexPagePerson.FName));
                    }
                    else if (lockedGender == "Female")
                    {
                        ModeratlyComplexPagePerson.FName = FFNames[rand.Next(FFNames.Count)];
                    }
                }
                else
                {
                    ModeratlyComplexPagePerson.FName = FNames[rand.Next(FNames.Count)];
                }
                ModeratlyComplexPagePerson.LName = LNames[rand.Next(LNames.Count)];

                ModeratlyComplexPagePerson.Age = rand.Next(101);
                if (genreLock == Genre.CONTEMPORARY)
                {
                    if (ModeratlyComplexPagePerson.Age < 18)
                    {
                        if (ModeratlyComplexPagePerson.Age < 14)
                        {
                            ModeratlyComplexPagePerson.Profession = "Unemployed";
                        }
                        else
                        {
                            ModeratlyComplexPagePerson.Profession = MinorProfessions[rand.Next(MinorProfessions.Count)];
                        }
                    }
                    else
                    {
                        ModeratlyComplexPagePerson.Profession = Professions[rand.Next(Professions.Count)];
                    }
                }
                else if (genreLock == Genre.FANTASY)
                {
                    ModeratlyComplexPagePerson.Profession = FantasyProfessions[rand.Next(FantasyProfessions.Count)];
                }
                else if (genreLock == Genre.SCIFI)
                {
                    ModeratlyComplexPagePerson.Profession = FantasyProfessions[rand.Next(FantasyProfessions.Count)];
                }
                traitsList.Add(new CharacterTrait("Profession", pagePerson.Profession));

                if (genderLock)
                {
                    ModeratlyComplexPagePerson.Gender = lockedGender;
                }
                else
                {
                    ModeratlyComplexPagePerson.Gender = Genders[rand.Next(Genders.Count)];
                }

                if (raceLock != null)
                {
                    ModeratlyComplexPagePerson.Race = raceLock;
                }
                else
                {
                    ModeratlyComplexPagePerson.Race = Races[rand.Next(Races.Count)];
                }

                ModeratlyComplexPagePerson.Nationality = Nationalities[rand.Next(Nationalities.Count)];

                ModeratlyComplexPagePerson.HairColor = hairColors[rand.Next(hairColors.Count)];

                ModeratlyComplexPagePerson.EyeColor = eyeColors[rand.Next(eyeColors.Count)];

                ModeratlyComplexPagePerson.Personality = personalities[rand.Next(personalities.Count)];

            }
            else if (complock == Complexity.Complex) // complexity
            {
                if (genderLock)
                {
                    if (lockedGender == "Male")
                    {
                        ComplexPagePerson.FName = MFNames[rand.Next(MFNames.Count)];
                    }
                    else if (lockedGender == "Female")
                    {
                        ComplexPagePerson.FName = FFNames[rand.Next(FFNames.Count)];
                    }
                }
                else
                {
                    ComplexPagePerson.FName = FNames[rand.Next(FNames.Count)];
                }
                ComplexPagePerson.LName = LNames[rand.Next(LNames.Count)];

                ComplexPagePerson.Age = rand.Next(101);
                if (genreLock == Genre.CONTEMPORARY)
                {
                    if (ComplexPagePerson.Age < 18)
                    {
                        if (ComplexPagePerson.Age < 14)
                        {
                            ComplexPagePerson.Profession = "Unemployed";
                        }
                        else
                        {
                            ComplexPagePerson.Profession = MinorProfessions[rand.Next(MinorProfessions.Count)];
                        }
                    }
                    else
                    {
                        ComplexPagePerson.Profession = Professions[rand.Next(Professions.Count)];
                    }
                }
                else if (genreLock == Genre.FANTASY)
                {
                    ComplexPagePerson.Profession = FantasyProfessions[rand.Next(FantasyProfessions.Count)];
                }
                else if (genreLock == Genre.SCIFI)
                {
                    ComplexPagePerson.Profession = FantasyProfessions[rand.Next(FantasyProfessions.Count)];
                }

                if (genderLock)
                {
                    ComplexPagePerson.Gender = lockedGender;
                }
                else
                {
                    ComplexPagePerson.Gender = Genders[rand.Next(Genders.Count)];
                }

                if (raceLock != null)
                {
                    ComplexPagePerson.Race = raceLock;
                }
                else
                {
                    ComplexPagePerson.Race = Races[rand.Next(Races.Count)];
                }

                ComplexPagePerson.Nationality = Nationalities[rand.Next(Nationalities.Count)];

                ComplexPagePerson.HairColor = hairColors[rand.Next(hairColors.Count)];

                ComplexPagePerson.EyeColor = eyeColors[rand.Next(eyeColors.Count)];

                ComplexPagePerson.Personality = personalities[rand.Next(personalities.Count)];

            }
            else if (complock == Complexity.ModeratlyComplexTableTop) //complexity
            {
                if (genderLock)
                {
                    if (lockedGender == "Male")
                    {
                        ModeratelyComplexPerson_Tabletop_PagePerson.FName = MFNames[rand.Next(MFNames.Count)];
                    }
                    else if (lockedGender == "Female")
                    {
                        ModeratelyComplexPerson_Tabletop_PagePerson.FName = FFNames[rand.Next(FFNames.Count)];
                    }
                }
                else
                {
                    ModeratelyComplexPerson_Tabletop_PagePerson.FName = FNames[rand.Next(FNames.Count)];
                }
                ModeratelyComplexPerson_Tabletop_PagePerson.LName = LNames[rand.Next(LNames.Count)];

                ModeratelyComplexPerson_Tabletop_PagePerson.Age = rand.Next(101);
                if (genreLock == Genre.CONTEMPORARY)
                {
                    if (ModeratelyComplexPerson_Tabletop_PagePerson.Age < 18)
                    {
                        if (ModeratelyComplexPerson_Tabletop_PagePerson.Age < 14)
                        {
                            ModeratelyComplexPerson_Tabletop_PagePerson.Profession = "Unemployed";
                        }
                        else
                        {
                            ModeratelyComplexPerson_Tabletop_PagePerson.Profession = MinorProfessions[rand.Next(MinorProfessions.Count)];
                        }
                    }
                    else
                    {
                        ModeratelyComplexPerson_Tabletop_PagePerson.Profession = Professions[rand.Next(Professions.Count)];
                    }
                }
                else if (genreLock == Genre.FANTASY)
                {
                    ModeratelyComplexPerson_Tabletop_PagePerson.Profession = FantasyProfessions[rand.Next(FantasyProfessions.Count)];
                }
                else if (genreLock == Genre.SCIFI)
                {
                    ModeratelyComplexPerson_Tabletop_PagePerson.Profession = FantasyProfessions[rand.Next(FantasyProfessions.Count)];
                }

                if (genderLock)
                {
                    ModeratelyComplexPerson_Tabletop_PagePerson.Gender = lockedGender;
                }
                else
                {
                    ModeratelyComplexPerson_Tabletop_PagePerson.Gender = Genders[rand.Next(Genders.Count)];
                }

                if (raceLock != null)
                {
                    ModeratelyComplexPerson_Tabletop_PagePerson.Race = raceLock;
                }
                else
                {
                    ModeratelyComplexPerson_Tabletop_PagePerson.Race = Races[rand.Next(Races.Count)];
                }

                ModeratelyComplexPerson_Tabletop_PagePerson.Nationality = Nationalities[rand.Next(Nationalities.Count)];

                ModeratelyComplexPerson_Tabletop_PagePerson.HairColor = hairColors[rand.Next(hairColors.Count)];

                ModeratelyComplexPerson_Tabletop_PagePerson.EyeColor = eyeColors[rand.Next(eyeColors.Count)];

                ModeratelyComplexPerson_Tabletop_PagePerson.Personality = personalities[rand.Next(personalities.Count)];

                ModeratelyComplexPerson_Tabletop_PagePerson.HitPoints = rand.Next(301);

                ModeratelyComplexPerson_Tabletop_PagePerson.SpecialPoints = rand.Next(126);

                ModeratelyComplexPerson_Tabletop_PagePerson.Level = rand.Next(101);

                ModeratelyComplexPerson_Tabletop_PagePerson.Strength = rand.Next(36);

                ModeratelyComplexPerson_Tabletop_PagePerson.Dexterity = rand.Next(36);

                ModeratelyComplexPerson_Tabletop_PagePerson.Intelligence = rand.Next(36);

                ModeratelyComplexPerson_Tabletop_PagePerson.Wisdom = rand.Next(36);

                ModeratelyComplexPerson_Tabletop_PagePerson.Constitution = rand.Next(36);

                ModeratelyComplexPerson_Tabletop_PagePerson.Will = rand.Next(36);

                ModeratelyComplexPerson_Tabletop_PagePerson.Charisma = rand.Next(36);


            }
            else if (complock == Complexity.ComplexTableTop)
            {
                if (genderLock)
                {
                    if (lockedGender == "Male")
                    {
                        ComplexPerson_Tabletop_PagePerson.FName = MFNames[rand.Next(MFNames.Count)];
                    }
                    else if (lockedGender == "Female")
                    {
                        ComplexPerson_Tabletop_PagePerson.FName = FFNames[rand.Next(FFNames.Count)];
                    }
                }
                else
                {
                    ComplexPerson_Tabletop_PagePerson.FName = FNames[rand.Next(FNames.Count)];
                }
                ComplexPerson_Tabletop_PagePerson.LName = LNames[rand.Next(LNames.Count)];

                ComplexPerson_Tabletop_PagePerson.Age = rand.Next(101);
                if (genreLock == Genre.CONTEMPORARY)
                {
                    if (ComplexPerson_Tabletop_PagePerson.Age < 18)
                    {
                        if (ComplexPerson_Tabletop_PagePerson.Age < 14)
                        {
                            ComplexPerson_Tabletop_PagePerson.Profession = "Unemployed";
                        }
                        else
                        {
                            ComplexPerson_Tabletop_PagePerson.Profession = MinorProfessions[rand.Next(MinorProfessions.Count)];
                        }
                    }
                    else
                    {
                        ComplexPerson_Tabletop_PagePerson.Profession = Professions[rand.Next(Professions.Count)];
                    }
                }
                else if (genreLock == Genre.FANTASY)
                {
                    ComplexPerson_Tabletop_PagePerson.Profession = FantasyProfessions[rand.Next(FantasyProfessions.Count)];
                }
                else if (genreLock == Genre.SCIFI)
                {
                    ComplexPerson_Tabletop_PagePerson.Profession = FantasyProfessions[rand.Next(FantasyProfessions.Count)];
                }

                if (genderLock)
                {
                    ComplexPerson_Tabletop_PagePerson.Gender = lockedGender;
                }
                else
                {
                    ComplexPerson_Tabletop_PagePerson.Gender = Genders[rand.Next(Genders.Count)];
                }

                if (raceLock != null)
                {
                    ComplexPerson_Tabletop_PagePerson.Race = raceLock;
                }
                else
                {
                    ComplexPerson_Tabletop_PagePerson.Race = Races[rand.Next(Races.Count)];
                }

                ComplexPerson_Tabletop_PagePerson.Nationality = Nationalities[rand.Next(Nationalities.Count)];

                ComplexPerson_Tabletop_PagePerson.HairColor = hairColors[rand.Next(hairColors.Count)];

                ComplexPerson_Tabletop_PagePerson.EyeColor = eyeColors[rand.Next(eyeColors.Count)];

                ComplexPerson_Tabletop_PagePerson.Personality = personalities[rand.Next(personalities.Count)];

                ComplexPerson_Tabletop_PagePerson.HitPoints = rand.Next(301);

                ComplexPerson_Tabletop_PagePerson.SpecialPoints = rand.Next(126);

                ComplexPerson_Tabletop_PagePerson.Level = rand.Next(101);

                ComplexPerson_Tabletop_PagePerson.Strength = rand.Next(36);

                ComplexPerson_Tabletop_PagePerson.Dexterity = rand.Next(36);

                ComplexPerson_Tabletop_PagePerson.Intelligence = rand.Next(36);

                ComplexPerson_Tabletop_PagePerson.Wisdom = rand.Next(36);

                ComplexPerson_Tabletop_PagePerson.Constiution = rand.Next(36);

                ComplexPerson_Tabletop_PagePerson.Will = rand.Next(36);

                ComplexPerson_Tabletop_PagePerson.Charisma = rand.Next(36);

                ComplexPerson_Tabletop_PagePerson.Armor_Class = ArmorClasses[rand.Next(ArmorClasses.Count)];

                ComplexPerson_Tabletop_PagePerson.Proficiency_bonus = rand.Next(51);

                ComplexPerson_Tabletop_PagePerson.Inspiration = rand.Next(36);

                ComplexPerson_Tabletop_PagePerson.Perception = rand.Next(36);

                ComplexPerson_Tabletop_PagePerson.Spellcasting_ability = rand.Next(101);

                ComplexPerson_Tabletop_PagePerson.Spell_save_DC = rand.Next(11);

                ComplexPerson_Tabletop_PagePerson.Spell_attack_bonus = rand.Next(16);

                ComplexPerson_Tabletop_PagePerson.EXP = rand.Next(10001);

            }

            // Adds the basic traits; use this format wherever you randomize a value on the pagePerson and then remove these
            if (complock == Complexity.Simple)
            {
                traitsList.Add(new CharacterTrait("Age", pagePerson.Age));
                traitsList.Add(new CharacterTrait("Profession", pagePerson.Profession));
                traitsList.Add(new CharacterTrait("Race", pagePerson.Race));
                traitsList.Add(new CharacterTrait("Gender", pagePerson.Gender));

            }
            else if (complock == Complexity.ModeratlyComplex)
            {

                traitsList.Add(new CharacterTrait("Age", ModeratlyComplexPagePerson.Age));
                traitsList.Add(new CharacterTrait("Profession", ModeratlyComplexPagePerson.Profession));
                traitsList.Add(new CharacterTrait("Race", ModeratlyComplexPagePerson.Race));
                traitsList.Add(new CharacterTrait("Gender", ModeratlyComplexPagePerson.Gender));
                traitsList.Add(new CharacterTrait("FullName", ModeratlyComplexPagePerson.FullName));
                traitsList.Add(new CharacterTrait("Nationality", ModeratlyComplexPagePerson.Nationality));
                traitsList.Add(new CharacterTrait("", ModeratlyComplexPagePerson.Age));
                traitsList.Add(new CharacterTrait("HeightFeet", ModeratlyComplexPagePerson.Heightfeet));
                traitsList.Add(new CharacterTrait("HeightInches", ModeratlyComplexPagePerson.HeightInches));
                traitsList.Add(new CharacterTrait("Weight", ModeratlyComplexPagePerson.Weight));
                traitsList.Add(new CharacterTrait("HairColor", ModeratlyComplexPagePerson.HairColor));
                traitsList.Add(new CharacterTrait("EyeColor", ModeratlyComplexPagePerson.EyeColor));
                traitsList.Add(new CharacterTrait("Personality", ModeratlyComplexPagePerson.Personality));
                traitsList.Add(new CharacterTrait("Likes", ModeratlyComplexPagePerson.Likes));
                traitsList.Add(new CharacterTrait("Dislikes", ModeratlyComplexPagePerson.Dislikes));


            }
            else if (complock == Complexity.ModeratlyComplexTableTop)
            {

                traitsList.Add(new CharacterTrait("Age", ModeratelyComplexPerson_Tabletop_PagePerson.Age));
                traitsList.Add(new CharacterTrait("Profession", ModeratelyComplexPerson_Tabletop_PagePerson.Profession));
                traitsList.Add(new CharacterTrait("Race", ModeratelyComplexPerson_Tabletop_PagePerson.Race));
                traitsList.Add(new CharacterTrait("Gender", ModeratelyComplexPerson_Tabletop_PagePerson.Gender));
                traitsList.Add(new CharacterTrait("FullName", ModeratelyComplexPerson_Tabletop_PagePerson.FullName));
                traitsList.Add(new CharacterTrait("Nationality", ModeratelyComplexPerson_Tabletop_PagePerson.Nationality));
                traitsList.Add(new CharacterTrait("HeightFeet", ModeratelyComplexPerson_Tabletop_PagePerson.Heightfeet));
                traitsList.Add(new CharacterTrait("HeightInches", ModeratelyComplexPerson_Tabletop_PagePerson.HeightInches));
                traitsList.Add(new CharacterTrait("Weight", ModeratelyComplexPerson_Tabletop_PagePerson.Weight));
                traitsList.Add(new CharacterTrait("HairColor", ModeratelyComplexPerson_Tabletop_PagePerson.HairColor));
                traitsList.Add(new CharacterTrait("EyeColor", ModeratelyComplexPerson_Tabletop_PagePerson.EyeColor));
                traitsList.Add(new CharacterTrait("Personality", ModeratelyComplexPerson_Tabletop_PagePerson.Personality));
                traitsList.Add(new CharacterTrait("Likes", ModeratelyComplexPerson_Tabletop_PagePerson.Likes));
                traitsList.Add(new CharacterTrait("Dislikes", ModeratelyComplexPerson_Tabletop_PagePerson.Dislikes));
                traitsList.Add(new CharacterTrait("HitPoints", ModeratelyComplexPerson_Tabletop_PagePerson.HitPoints));
                traitsList.Add(new CharacterTrait("SpecialPoints", ModeratelyComplexPerson_Tabletop_PagePerson.SpecialPoints));
                traitsList.Add(new CharacterTrait("Level", ModeratelyComplexPerson_Tabletop_PagePerson.Level));
                traitsList.Add(new CharacterTrait("Strength", ModeratelyComplexPerson_Tabletop_PagePerson.Strength));
                traitsList.Add(new CharacterTrait("Dexterity", ModeratelyComplexPerson_Tabletop_PagePerson.Dexterity));
                traitsList.Add(new CharacterTrait("Intelligence", ModeratelyComplexPerson_Tabletop_PagePerson.Intelligence));
                traitsList.Add(new CharacterTrait("Wisdom", ModeratelyComplexPerson_Tabletop_PagePerson.Wisdom));
                traitsList.Add(new CharacterTrait("Constitution", ModeratelyComplexPerson_Tabletop_PagePerson.Constitution));
                traitsList.Add(new CharacterTrait("Will", ModeratelyComplexPerson_Tabletop_PagePerson.Will));
                traitsList.Add(new CharacterTrait("Charisma", ModeratelyComplexPerson_Tabletop_PagePerson.Charisma));

            }
            else if (complock == Complexity.Complex)
            {
                traitsList.Add(new CharacterTrait("Age", ComplexPagePerson.Age));
                traitsList.Add(new CharacterTrait("Profession", ComplexPagePerson.Profession));
                traitsList.Add(new CharacterTrait("Race", ComplexPagePerson.Race));
                traitsList.Add(new CharacterTrait("Gender", ComplexPagePerson.Gender));
                traitsList.Add(new CharacterTrait("FullName", ComplexPagePerson.FullName));
                traitsList.Add(new CharacterTrait("Nationality", ComplexPagePerson.Nationality));
                traitsList.Add(new CharacterTrait("HeightFeet", ComplexPagePerson.Heightfeet));
                traitsList.Add(new CharacterTrait("HeightInches", ComplexPagePerson.HeightInches));
                traitsList.Add(new CharacterTrait("Weight", ComplexPagePerson.Weight));
                traitsList.Add(new CharacterTrait("HairColor", ComplexPagePerson.HairColor));
                traitsList.Add(new CharacterTrait("EyeColor", ComplexPagePerson.EyeColor));
                traitsList.Add(new CharacterTrait("Personality", ComplexPagePerson.Personality));
                traitsList.Add(new CharacterTrait("Likes", ComplexPagePerson.Likes));
                traitsList.Add(new CharacterTrait("Dislikes", ComplexPagePerson.Dislikes));
                traitsList.Add(new CharacterTrait("Accent", ComplexPagePerson.Accent));
                traitsList.Add(new CharacterTrait("StyleOfDress", ComplexPagePerson.StyleOfDress));
                traitsList.Add(new CharacterTrait("Friends", ComplexPagePerson.Friends));
                traitsList.Add(new CharacterTrait("Enemies", ComplexPagePerson.Enemies));
                traitsList.Add(new CharacterTrait("SignificantOther", ComplexPagePerson.SignificantOther));
                traitsList.Add(new CharacterTrait("FavoriteFood", ComplexPagePerson.FavoriteFood));
                traitsList.Add(new CharacterTrait("Groups", ComplexPagePerson.Groups));



            }
            else if (complock == Complexity.ComplexTableTop)
            {
                traitsList.Add(new CharacterTrait("Age", ComplexPagePerson.Age));
                traitsList.Add(new CharacterTrait("Profession", ComplexPagePerson.Profession));
                traitsList.Add(new CharacterTrait("Race", ComplexPagePerson.Race));
                traitsList.Add(new CharacterTrait("Gender", ComplexPagePerson.Gender));
                traitsList.Add(new CharacterTrait("FullName", ComplexPagePerson.FullName));
                traitsList.Add(new CharacterTrait("Nationality", ComplexPagePerson.Nationality));
                traitsList.Add(new CharacterTrait("", ComplexPagePerson.Age));
                traitsList.Add(new CharacterTrait("HeightFeet", ComplexPagePerson.HeightFeet));
                traitsList.Add(new CharacterTrait("HeightInches", ComplexPagePerson.HeightInches));
                traitsList.Add(new CharacterTrait("Weight", ComplexPagePerson.Weight));
                traitsList.Add(new CharacterTrait("HairColor", ComplexPagePerson.HairColor));
                traitsList.Add(new CharacterTrait("EyeColor", ComplexPagePerson.EyeColor));
                traitsList.Add(new CharacterTrait("Personality", ComplexPagePerson.Personality));
                traitsList.Add(new CharacterTrait("Likes", ComplexPagePerson.Likes));
                traitsList.Add(new CharacterTrait("Dislikes", ComplexPagePerson.Dislikes));
                traitsList.Add(new CharacterTrait("HitPoints", ComplexPagePerson.HitPoints));
                traitsList.Add(new CharacterTrait("SpecialPoints", ComplexPagePerson.SpecialPoints));
                traitsList.Add(new CharacterTrait("Level", ComplexPagePerson.Level));
                traitsList.Add(new CharacterTrait("Strength", ComplexPagePerson.Strength));
                traitsList.Add(new CharacterTrait("Dexterity", ComplexPagePerson.Dexterity));
                traitsList.Add(new CharacterTrait("Intelligence", ComplexPagePerson.Intelligence));
                traitsList.Add(new CharacterTrait("Wisdom", ComplexPagePerson.Wisdom));
                traitsList.Add(new CharacterTrait("Constitution", ComplexPagePerson.Constitution));
                traitsList.Add(new CharacterTrait("Will", ComplexPagePerson.Will));
                traitsList.Add(new CharacterTrait("Charisma", ComplexPagePerson.Charisma));
                traitsList.Add(new CharacterTrait("Accent", ComplexPagePerson.Accent));
                traitsList.Add(new CharacterTrait("StyleOfDress", ComplexPagePerson.StyleOfDress));
                traitsList.Add(new CharacterTrait("Friends", ComplexPagePerson.Friends));
                traitsList.Add(new CharacterTrait("Enemies", ComplexPagePerson.Enemies));
                traitsList.Add(new CharacterTrait("SignificantOther", ComplexPagePerson.SignificantOther));
                traitsList.Add(new CharacterTrait("FightingStyle", ComplexPagePerson.FightingStyle));
                traitsList.Add(new CharacterTrait("PreferredWeapon", ComplexPagePerson.PreferredWeapon));
                traitsList.Add(new CharacterTrait("FavoriteFood", ComplexPagePerson.FavoriteFood));
                traitsList.Add(new CharacterTrait("ArmorClass", ComplexPagePerson.ArmorClass));
                traitsList.Add(new CharacterTrait("ProficiencyBonus", ComplexPagePerson.ProficiencyBonus));
                traitsList.Add(new CharacterTrait("Inspiration", ComplexPagePerson.Inspiration));
                traitsList.Add(new CharacterTrait("Perception", ComplexPagePerson.perception));
                traitsList.Add(new CharacterTrait("SpellCastingAbility", ComplexPagePerson.SpellCastingAbility));
                traitsList.Add(new CharacterTrait("SpellSaveDC", ComplexPagePerson.SpellSaveDC));
                traitsList.Add(new CharacterTrait("SpellAttackBonus", ComplexPagePerson.SpellAttackBonus));
                traitsList.Add(new CharacterTrait("Exp", ComplexPagePerson.Exp));
                traitsList.Add(new CharacterTrait("Groups", ComplexPagePerson.Groups));


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

        private void Moderatly_complex_table_top_Click(object sender, RoutedEventArgs e)
        {
            complock = Complexity.ModeratlyComplexTableTop;
        }

        private void Complex_Click(object sender, RoutedEventArgs e)
        {
            complock = Complexity.Complex;
        }

        private void complex_table_top_Click(object sender, RoutedEventArgs e)
        {
            complock = Complexity.ComplexTableTop;
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
