/****************************************************************************************************
 * Author's Name : Saemi Lee
 * 
 * Date last modified : 02/06/2015
 * 
 * Program description : This program generates randomly the hero's three of super power existing in SuperPower Array without dupulicateion, 
 * and estimates hit damage by the hero.
 * 
 *  Revision History  :
 *  Date        Author  Ref Revision (Date in MMDDYYYY format)
 *   
 *****************************************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the hero's name: ");
            string name = Console.ReadLine();


            //Implement SupoerHero object
            SuperHero aSuperHero = new SuperHero(name);
            aSuperHero.showPowers();

            //Implemnet Hero object
            Hero aHero = new Hero(name);
            aHero.fight();

            Console.WriteLine();
            Console.WriteLine("Enter the any key to exit");
            Console.ReadKey();

        }
    }
}
