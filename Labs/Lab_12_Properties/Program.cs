using System;

namespace Lab_12_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var user01 = new User("NT353JR194", "AB");
            Console.WriteLine(user01.NINO);

            user01.NINO = null; // reset    null means 'no data present in field' null is not ""
        }
    }

    class User
    {
        // Fields (PRIVATE)
        private string _NINO;
        private string _bloodType;
        private int _Age;

        
        // CONSTRUCTOR
        public User(string nino, string bloodType)
        {
            this._NINO = nino;
            this._bloodType = bloodType;
        }

        // Public properties
        public string NINO 
        {
            get { return this._NINO; }
            set { this._NINO = value; } 
        }

        public int Age 
        { 
            get => this._Age; 
            set => this._Age = value; 
        }
    }
}
