using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_07_08
{
    public class Microwave : Device
    {
        public Microwave(string name, double weight, string color) : base(name, weight, color)
        {
        }

        public override void Sound()
        {
            Console.Write("Enter sound of Microwave: ");
            string sound = Console.ReadLine();
            Console.WriteLine("Sound of Microwave: " + sound);
        }
    }
}
