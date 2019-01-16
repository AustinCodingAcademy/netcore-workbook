using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller c = new Controller();
            c.CreateModel(3,8);

        }
    }

    public class Controller
    {
        public void CreateModel(int n, int r)
        {
            int i;
            int j;

            System.Console.WriteLine("pick a number");
            if (Int32.TryParse(Console.ReadLine(), out i))
            {
                System.Console.WriteLine("you chose" + i);
            }

            System.Console.WriteLine("pick another number");
            if (Int32.TryParse(Console.ReadLine(), out j))
            {
                System.Console.WriteLine("you chose" + j);
            }

            Model aModel = new Model(i, j);
        }
        public Controller(){}
        

    }

    public class Model
    {
        public int number {get;set;}
        public int repeats {get;set;}
        public Model(int number, int repeats)
        {
            this.number = number;
            this.repeats = repeats;
        }
    }
        

    public class View
    {

    }

}
