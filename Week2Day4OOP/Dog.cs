using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day4OOP
{
    class Dog
    {
        //Fields
        private string furLength;
        private float height;
        private string speed;
        private double weight;

        //Properties
        public string FurLength
        {
            get { return this.furLength; }
            set { this.furLength = value; }
        }
        public float Height
        {
            get { return this.height; }
            set { this.height = value; }
        }
        public string Speed
        {
            get { return this.speed; }
            set { this.speed = value; }
        }
        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        //Constructors
        public Dog()
        {

        }

        //Overlaoded Constructor //Totally random but ctrl+K+D oraganizes shit yo
        public Dog(string furLength, float height)
        {
            this.furLength = furLength;
            this.height = height;
        }

        //Methods
        public void Run()
        {
            speed = "Damn! You fast, dog!";
            weight--; //weight goes down by 1 everytime dog runs because exersize and simple logic when explaining. just go w/ it.
        }

        public void Bark()
        {
            Console.WriteLine("\a"); //Again...simplified logic. Just go with it.
        }

        public void Potty()
        {
            weight = weight - 0.1; //Poopy time
        }

        public void Groom()
        {
            furLength = "All cleaned up, pupper!";
        }




    }
}
