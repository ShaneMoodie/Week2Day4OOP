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
            //KTTY STUFF
            //    Cat mittens = new Cat();
            //    mittens.Name = "Mittens";

            //    Console.WriteLine(mittens.Name); //Prints out "Mittens"

            //    Cat mumbo = new Cat("Mumbo", 3, "grey and white");

            //    Console.WriteLine(mumbo.Name); //Prints out Mumbo.

            //    mittens.Eat();

            //    mittens.WorkOut();


            //DOG STUFF
            //Dog firstDoge = new Dog();

            //firstDoge.Weight = 60.00;
            //firstDoge.Height = 3.2f;
            //firstDoge.FurLength = "flowing mane";
            //firstDoge.Speed = "Fast AF.";

            //firstDoge.Groom();
            //Console.WriteLine(firstDoge.FurLength);

            //firstDoge.Run();
            //Console.WriteLine("The dog now weighs " + firstDoge.Weight);
            //Console.WriteLine(firstDoge.Speed);

            //firstDoge.Bark(); 

            //MORE DOG STUFF
            //Dog tikiDoge = new Dog("Tiki", 2.5f);

            //Console.WriteLine(tikiDoge.FurLength);

            //tikiDoge.Groom();

            //Console.WriteLine(tikiDoge.FurLength);

            //tikiDoge.Speed = "Ludacris speed!!!"; //set newly set speed to ludacris

            //Console.WriteLine(tikiDoge.Speed); //prints ludacris

            //tikiDoge.Run();

            //Console.WriteLine(tikiDoge.Speed); //pulls from predifined "Speed" in Dog.cs (Damn! You fast, dog!)

            //tikiDoge.Weight = 40.00;

            //Console.WriteLine(tikiDoge.Weight);

            //tikiDoge.Potty();

            //Console.WriteLine(tikiDoge.Weight);

            //tikiDoge.Bark();

            //Superhero practice problem
            Superhero superHeroMan = new Superhero("Super Hero-Man");

            Console.WriteLine(superHeroMan.Name + ":");

            superHeroMan.HasCape = "Super Hero-Man has a cape!";

            Console.WriteLine(superHeroMan.HasCape);

            superHeroMan.WearsMask = "Super Hero-Man wears a mask!";

            Console.WriteLine(superHeroMan.WearsMask);

            superHeroMan.PowerLevel = 9000;

            Console.WriteLine("Super Hero-Man's current power level is :" + superHeroMan.PowerLevel);

            superHeroMan.PowerUp();

            Console.WriteLine("Super Hero-Man is knocking evil-doers left and right!\nHis power level has risen to: " + superHeroMan.PowerLevel);
        }
    }
}
