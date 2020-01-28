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

namespace Lab_33_RabbitsAdvanced
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        private Random random = new Random();
        static List<RabbitTable> RabbitList = new List<RabbitTable>();
        public MainWindow()
        {
            InitializeComponent();
        }

        void Initialize()
        {
            using(var db = new RabbitDatabaseEntities())
            {
                rabbits = db.RabbitTables.ToList();
            }
        }

        private void AddOriginalRabbits_Click(object sender, RoutedEventArgs e)
        {
            // Populate list with a male and female rabbit
            while (RabbitList.Count < 2)
            {
                RabbitList.Add(new Rabbit(RabbitList, random, true));
            }
            
        }

        private void RabbitView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

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
        public string LastName { get; set; }
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
        public Rabbit(List<Rabbit> rabbitList, Random random, bool original)
        {
            // Set age to zero
            Age = 0;

            // Set whether rabbit is one of thew two original rabbits
            Original = original;

            // Set so it is not yet able to breed
            CanBreed = false;

            // Give Rabbit a random id
            RabbitID = random.Next(100, 999);

            // Set rabbit gender
            SetGender(rabbitList, random);

            // Depending on gender, set name
            SetRabbitName(random);

            // BONUS: Randomise first 10 CuteFactor ratings. Set Cutefactor depending on mother and father ratings.
        }

        // Set attributes for newborn rabbit
        public void InitialiseRabbit(List<Rabbit> rabbitList, Random random, bool original)
        {
            // Set age to zero
            Age = 0;

            // Set whether rabbit is one of thew two original rabbits
            Original = original;

            // Set so it is not yet able to breed
            CanBreed = false;

            // Give Rabbit a random id
            RabbitID = random.Next(100, 999);

            // Set rabbit gender
            SetGender(rabbitList, random);

            // Depending on gender, set name
            SetRabbitName(random);
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
                Gender = random.NextDouble() < 0.5 ? Gender.Female : Gender.Male;
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
            if (Gender == Gender.Female)
            {
                FirstName = femaleFirstNames[random.Next(0, femaleFirstNames.Length - 1)];
            }
            // Pick a lastName from either parent
            // If rabbit is an original, randomise name
            if (Original == true)
            {
                LastName = lastNames[random.Next(0, lastNames.Length - 1)];
            }
            // If rabbit has mother and father, take last name from either parent randomly
            if (Mother != null && Father != null)
            {
                LastName = random.NextDouble() < 0.5 ? Mother.LastName : Father.LastName;
            }
        }

        // Increments the age of a rabbit
        public void IncrementAge(List<Rabbit> rabbitList)
        {
            foreach (var item in rabbitList)
            {
                Age++;
                if (Age == 3)
                {
                    CanBreed = true;
                }
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

        public void BreedRabbits(List<Rabbit> rabbitList, Random random)
        {
            // create list for new rabbit children
            List<Rabbit> childRabbits = new List<Rabbit>();
            // sort existing rabbits list into male and female
            SortGenders(rabbitList);
            // breed every male rabbit with every female rabbit
            foreach (var mRabbit in males)
            {
                foreach (var fRabbit in females)
                {
                    if (mRabbit.CanBreed == true && fRabbit.CanBreed == true)
                    {
                        var childRabbit = new Rabbit();
                        InitialiseRabbit(rabbitList, random, false);
                        childRabbit.Mother = fRabbit;
                        childRabbit.Father = mRabbit;

                        childRabbits.Add(childRabbit);
                    }
                }
            }
            rabbitList.AddRange(childRabbits);
        }

    }
}
