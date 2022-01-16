using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_dz
{
    abstract class Vasya : Male
    {
        public override void GoToGym(string day)
        {
            Console.WriteLine("Vasya hates going to the gym in" + day);
        }
        public override void Salary(string number)
        {
            Console.WriteLine("Vasya have a very big salary" + number);
        }
        public static void Jumping(string hobby)
        {
            Console.WriteLine("Vasya loves his" + hobby);
        }
        public static void Fly(string contry)
        {
            Console.WriteLine("Vasya loves to fly " + contry);
        }
        public override void Run(string time)
        {
            Console.WriteLine("Vasya never runs " + time);
        }
        public override void Read(string page)
        {
            Console.WriteLine("Vasya does not read any" + page + "instructions");
        }
    }
}    