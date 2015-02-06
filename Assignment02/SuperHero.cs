using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    //SUPERHERO SUBCLASS OR HERO SUPER CLASS
    class SuperHero : Hero
    {

        //PRIVATE PROPERTIES +++++++++++++++++++++++++++++++
        private string[] superPowers = { "Super Speed", "Super Strength", "Body Armour", "Flight", "Fire Generation", "Weather Control" };

        //Array for new list chosen ramdomly from superPowers array
        string[] superPowerMakeList = new string[3];
        string name;


        //CONSTRUCTOR ++++++++++++++++++++++++++++++++++++++
        public SuperHero(string name)
            : base(name)
        {
            this.name = name;
            generateRandomPowers();

        }


        //PRIVATE METHOD ++++++++++++++++++++++++++++++++++++++
        //Generate random super power without dupulication
        private void generateRandomPowers()
        {
            for (int index = 0; index < 3; index++)
            {
                Random ran = new Random();
                int ranNum = ran.Next(6);

                if (superPowers[ranNum] != "Chosen")
                {
                    superPowerMakeList[index] = superPowers[ranNum];
                    superPowers[ranNum] = "Chosen";
                }
                else
                {
                    index--;
                }
            }

        }


        //PUBLIC METHOD ++++++++++++++++++++++++++++++++++++++
        //Method to display the hero's properties
        public void showPowers()
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Console.WriteLine("{0} get", this.name);

            for (int index = 0; index < superPowerMakeList.Length; index++)
            {
                Console.WriteLine("{0} Power", superPowerMakeList[index]);
            }
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
        }

    }
}
