using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Felton___Virtual_Pet
{
    class VirtualPet  //instantiate the VirtualPet class
    {
        public string breed;
        public string name;
        private int hunger;
        private int thirst;
        private int waste;
        private bool playfull;


        public string Breed
        {
            get { return this.breed; }
            set { this.breed = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }

        public int Thirst
        {
            get { return this.thirst; }
            set { this.thirst = value; }
        }

        public int Waste
        {
            get { return this.waste; }
            set { this.waste = value; }
        }

        public bool Playfull
        {
            get { return this.playfull; }
            set { this.playfull = value; }
        }

        //public string VirtualPet { get; internal set; }

        public VirtualPet() //default constructor
        {

        }

        public VirtualPet(string breed, string name, int hunger, int thirst, int waste, bool playfull) //loaded constructor
        {
            this.Breed = breed;
            this.Name = name;
            this.Hunger = hunger;
            this.Thirst = thirst;
            this.Waste = waste;
            this.Playfull = playfull;
        }

        public void Tick()
        {
            Random hunger = new Random();
            //int hungry = hunger.Next(0, 10);


            if (Hunger >= 5)
            {
                Hunger--;
            }
            else
            {
                Hunger++;
            }

            

            Thirst++;
            Random thirsty = new Random();
            int drink = thirsty.Next(0,10);

            Waste++;
            if (waste >= 5 || drink >= 6)
            {
                int poop = waste--;
            }
            else
            {
                int poop = waste++;
            }




        }

    }//class
}//namespace
