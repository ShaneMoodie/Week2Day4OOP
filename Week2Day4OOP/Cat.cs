using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day4OOP
{
    class Cat
    {
        //STATES
        //FIELDS - usually private state, characteristics of class that WE build
        private string name;
        private int age;
        private string furColor;
        private bool IsHungry = true;
         
        //PROPERTIES - usually public state, characteristics fo class that allow us to interact 
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
          
        }

        //BEHAVIORS




        //CONSTRUCTORS - create new instances
        public Cat()
        {
            //default constructor b/c it takes no parameters in parenthesis
            //new constructor w/ same name but diff. parameters (see below) = overloaded constructor

        }

        //overloaded constructor, allows to define parameters right away
        public Cat(string name, int age, string furColor)
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
        }

        //Methods
        public void Eat()
        {
            if(IsHungry == true)
            {
                IsHungry = false;
            }
            Console.WriteLine("Is the cat hungry? " + IsHungry);
        }

        public void WorkOut()
        {
            if(IsHungry == false)
            {
                IsHungry = true;
            }

            Console.WriteLine("The cat has worked out, hungry now? " + IsHungry);
        }
            


    }
}
