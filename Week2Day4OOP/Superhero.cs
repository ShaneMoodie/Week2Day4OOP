using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day4OOP
{
    class Superhero
    {
        //Fields
        private string name;
        private int powerLevel;
        private string hasCape;
        private string wearsMask;
        private string goodEvil;

        //Properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int PowerLevel
        {
            get { return this.powerLevel; }
            set { this.powerLevel = value; }
        }
        public string HasCape
        {
            get { return this.hasCape; }
            set { this.hasCape = value; }
        }
        public string WearsMask
        {
            get { return this.wearsMask; }
            set { this.wearsMask = value; }
        }
        public string GoodEvil
        {
            get { return this.goodEvil; }
            set { this.goodEvil = value; }
        }

        //Constructors
        public Superhero()
        {

        }

        public Superhero(string name)
        {
            this.name = name;
        }

        public Superhero(string hasCape, string wearsMask)
        {
            this.hasCape = hasCape;
            this.wearsMask = wearsMask;
        }

        public Superhero(int powerLevel, string goodEvil)
        {
            this.powerLevel = powerLevel;
            this.goodEvil = goodEvil;
        }

        //Methods
        public void PowerDown()
        {
            powerLevel = 9000;
            powerLevel = powerLevel - 8000;
        }

        public void PowerUp()
        {
            powerLevel = 9000;
            powerLevel = powerLevel + 1000;
        }
    }
}
