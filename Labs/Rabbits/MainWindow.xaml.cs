using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Rabbits
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Random variable
        private Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn100Rabbits_Click(object sender, RoutedEventArgs e)
        {
            List<Rabbit> RabbitList = new List<Rabbit>();
            
            for (int i = 0; i < 100; i++)
            {
                var rab = new Rabbit();
                RabbitList.Add(rab);
            }

            foreach (var rabbit in RabbitList)
            {
                ListBox100Rabbits.Items.Add(rabbit);
            }

            // USE LIST VIEW
        }

        private void btnAge100Times_Click(object sender, RoutedEventArgs e)
        {
            List<Rabbit> RabbitList = new List<Rabbit>();

            // Generate 100 Rabbits
            for (int i = 0; i < 100; i++)
            {
                var rab = new Rabbit();
                rab.FirstName = "Rabbit" + i;
                RabbitList.Add(rab);
            }

            // Age rabbits 100 times
            foreach (var item in RabbitList)
            {
                item.Age++;
            }

            // Add to listbox
            foreach (var item in RabbitList)
            {
                ListBoxAgeRabbits100Times.Items.Add(item);
            }
        }
        // List for breeding rabbits
        List<Rabbit> RabbitList = new List<Rabbit>();
        private void btnBreedRabbits_Click(object sender, RoutedEventArgs e)
        {
            // Populate list with a male and female rabbit
            // CONSIDER DO WHILE LOOP
            while (RabbitList.Count < 2)
            {
                RabbitList.Add(new Rabbit(RabbitList, random));
            }
            // POSSIBLY BREED 10 GENERATIONS OF RABBITS HERE
            if (RabbitList.Count >= 2)
            {
                foreach (var item in RabbitList)
                {
                    ListViewBredRabbits.Items.Add(item);
                }
            }

            // Breed all Rabbits that are produced 10 times


            // Add List to listview
            //ListViewBredRabbits.ItemsSource = RabbitList;

            // Update Listview every click
            // Bonus: Breed depending on cuteness.
        }
    }

    // Gender enumerator
    enum Gender
    {
        Male,
        Female
    }

    class Rabbit
    {
        
        // rabbit properties
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int RabbitID { get; set; }
        public int Age { get; set; }
        //public float CuteFactor 
        //{ 
        //    get
        //    {
        //        return cuteFactor;
        //    }
        //    set
        //    {
        //        if((value > 0) && (value <= 10))
        //        {
        //            CuteFactor = value;
        //        }
        //    } 
        //}
        public bool CanBreed { get; set; }
        public bool Original { get; set; }
        public Rabbit Mother { get; set; }
        public Rabbit Father { get; set; }
        public Gender Gender { get; set; }

        // private fields
        private Array genders = Enum.GetValues(typeof(Gender));
        private IEnumerable<Rabbit> males;
        private IEnumerable<Rabbit> females;
            // private float cuteFactor;
        private string[] maleFirstNames = { "Stephen", "James", "Asher", "Hassan", "Ahmed", "Jaime", "Tim", "Karim", "Jordan", "Phillip" };
        private string[] femaleFirstNames = { "Colette", "Luisa", "Sue", "Mary", "Jane", "Amy", "Alice", "Julie", "Cathy", "Emily" };
        private string[] lastNames = { "Smith", "Baker", "Carpenter", "Cook", "Dyer", "Thatcher", "Slater", "Miller", "Fisher", "Shepherd" };


        // Default constructor
        public Rabbit()
        {
            
        }

        // For newborn rabbits
        public Rabbit(List<Rabbit> rabbitList, Random random)
        {
            // Set age to zero
            Age = 0;

            // Set so it is not yet able to breed
            CanBreed = false;

            // Give Rabbit a random id
            RabbitID = random.Next(100, 999);

            // Set rabbit gender
            SetGender(rabbitList, random);

            // Depending on gender, set name
            SetRabbitName(random);

            // Randomise first 10 CuteFactor ratings. Set Cutefactor depending on mother and father ratings.
            
        }

        //  Set gender for first two rabbits to male and female, randomise the rest of genders.
        private void SetGender(List<Rabbit> rabbitList, Random random)
        { 
            // If population is less than 2 make one male and one female.
            if (rabbitList.Count < 2 && !rabbitList.Exists(rabbit => rabbit.Gender == Gender.Male))
            {
                Gender = Gender.Male;
            }
            else if (rabbitList.Count < 2 && rabbitList.Exists(rabbit => rabbit.Gender == Gender.Male))
            {
                Gender = Gender.Female;
            }
            // else, 50% chance to be male or female.
            else
            {
                Gender = (Gender)genders.GetValue(random.Next(genders.Length));
            }
        }

        // Sets the name of the newborn rabbit
        private void SetRabbitName(/*Rabbit motherRabbit, Rabbit fatherRabbit,*/ Random random)
        {
            // Check this objects gender and look at corresponding array of name
            if (Gender == Gender.Male)
            {
                FirstName = maleFirstNames[random.Next(0, maleFirstNames.Length - 1)];
            }
            else if (Gender == Gender.Female)
            {
                FirstName = femaleFirstNames[random.Next(0, femaleFirstNames.Length - 1)];
            }
            // Pick a lastName from either parent

            // If rabbit has mother and father, take last name from either parent randomly

        }

        // Increments the age of a rabbit
        public void IncrementAge()
        {
            Age++;
            if (Age == 3)
            {
                CanBreed = true;
            }
        }

        // sort genders into two separate IEnumerable Lists
        public void SortGenders(List<Rabbit> rabbitList)
        {
            males = from rabbit in rabbitList
                        where rabbit.Gender == Gender.Male
                        select rabbit;


            females = from rabbit in rabbitList
                            where rabbit.Gender == Gender.Female
                            select rabbit;
        }

    }

    class RabbitBreeder
    {

        public RabbitBreeder(Rabbit mother, Rabbit father)
        {

        }
    }
}
