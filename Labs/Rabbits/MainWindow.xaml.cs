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

        private void btnBreedRabbits_Click(object sender, RoutedEventArgs e)
        {
            // Populate list with a male and female rabbit
            // Breed all Rabbits that are produced 10 times
        }
    }

    class Rabbit
    {
        enum Gender
        {
            Male,
            Female
        }
        // rabbit properties
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int RabbitID { get; set; }
        public int Age { get; set; }
        public float CuteRating { get; set; }
        public bool CanBreed { get; set; }
        public Rabbit Mother { get; set; }
        public Rabbit Father { get; set; }

        // private fields
        private Gender gender;
        private Random rand = new Random();
        private string[] firstMaleNames = { "Stephen", "James", "Asher", "Hassan", "Ahmed", "Jaime", "Tim", "Karim", "Jordan", "Phillip" };
        private string[] firstFemaleNames = { "Colette", "Luisa", "Sue", "Mary", "Jane", "Amy", "Alice", "Julie", "Cathy", "Emily" };
        private string[] secondNames = { "Smith", "Baker", "Carpenter", "Cook", "Dyer", "Thatcher", "Slater", "Miller", "Fisher", "Shepherd" };

        List<Rabbit> _rabbitList = new List<Rabbit>();

        // Default constructor
        public Rabbit()
        {
            
        }
        public Rabbit(List<Rabbit> rabbitList)
        {
            Age = 0;
            CanBreed = false;
            RabbitID = rand.Next(0, 1000);
            SetGender(_rabbitList);
            // Depending on gender, set name
            SetRabbitName();
            
        }

        //  Set gender for first two rabbits to male and female, randomise the rest of genders.
        private void SetGender(List<Rabbit> rabbitList)
        {
            // If population is less than 2 make one male and one female.
            if (rabbitList.Count < 2 && !rabbitList.Exists(rabbit => rabbit.gender == 0))
            {
                Console.WriteLine("There are no rabbits in the world, make a male");
            }
            // else, 50% chance to be male or female.

        }

        private void SetRabbitName()
        {
            // Check this objects gender and look at corresponding array of name
            // If first two rabbits, randomise names
            // If rabbit has mother and father, take last name from either parent randomly
        }

        public void IncrementAge()
        {
            this.Age++;
        }

    }

    class RabbitBreeder
    {

        public RabbitBreeder(Rabbit mother, Rabbit father)
        {

        }
    }
}
