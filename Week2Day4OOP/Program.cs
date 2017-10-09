using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day4OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Cat mittens = new Cat();
            //    mittens.Name = "Mittens";

            //    Console.WriteLine(mittens.Name); //Prints out "Mittens"

            //    Cat mumbo = new Cat("Mumbo", 3, "grey and white");

            //    Console.WriteLine(mumbo.Name); //Prints out Mumbo.

            //    mittens.Eat();

            //    mittens.WorkOut();

            Dog firstDoge = new Dog();

            firstDoge.Weight = 60.00;
            firstDoge.Height = 3.2f;
            firstDoge.FurLength = "flowing mane";
            firstDoge.Speed = "Fast AF.";

            firstDoge.Groom();
            Console.WriteLine(firstDoge.FurLength);

            firstDoge.Run();
            Console.WriteLine("The dog now weighs " + firstDoge.Weight);
            Console.WriteLine(firstDoge.Speed);

            firstDoge.Bark();
        }
    }
}
