using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_dz
{
    abstract class Masha : Female
    {
        public override void DriveCar(string years)
        {
            Console.WriteLine("Masha drives a car throughout" + years);
        }
        public override void CooksOnWeek(string day)
        {
            Console.WriteLine("Masha cooks for weeks" + day);
        }
        public override void Run(string time)
        {
            Console.WriteLine("Masha loves to run around in the" + time + "morning");
        }
        public override void Read(string page)
        {
            Console.WriteLine("Masha reads about a" + page + "minute");
        }
        public static void BeautyDay(string day)
        {
            Console.WriteLine("Masha arranges a beauty day in" + day);
        }
    }
}