using System;

namespace Lab_14_AbstractClass_
{
    class Program
    {
        static void Main(string[] args)
        {
            var realHoliday = new ActuallyGo();
            realHoliday.BookHotel();
            realHoliday.GetMoney();
            realHoliday.GetThere();
            realHoliday.VisitNamibia();
        }
    }

    // cannot instantiate this class (IE cannot create instances of new holiday yet
    abstract class Holiday
    {
        public abstract void GetThere();

        public abstract void BookHotel();

        public virtual void VirtualMethod()
        {

        }

        public void VisitNamibia()
        {
            Console.WriteLine("We know where we are going"); }

        public void GetMoney()
        {
            Console.WriteLine("We have the funds!");
        }
    }

    class ActuallyGo : Holiday
    {
        public override void GetThere()
        {
            Console.WriteLine("Fly then drive!");
        }

        public override void BookHotel()
        {
            Console.WriteLine("In Lion Village");
        }
    }
}
