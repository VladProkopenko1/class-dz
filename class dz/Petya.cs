using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_dz
{
    abstract class Petya : Male
    {
      public override void GoToGym(string day)
        {
            Console.WriteLine("Petya usually goes to the gym at" + day);
        }
        public override void Salary(string number)
        {
            Console.WriteLine("Petya receives such a salary" + number);
        }
        public static void Knife(string name)
        {
            Console.WriteLine("Petya loves to collect knives of various" + name);
        }
        public static void ByBike(string number)
        {
            Console.WriteLine("Petya wants to buy a bike for" + number);
        }
        public override void Run(string time)
        {
            Console.WriteLine("Petya don't like run in " + time );
        }
        public override void Read(string page)
        {
            Console.WriteLine("Petya reads about in day" + page);
        }
    }
}