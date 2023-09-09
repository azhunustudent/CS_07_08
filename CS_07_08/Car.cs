﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_07_08
{
    public class Car : Device
    {
        public Car(string name, double weight, string color) : base(name, weight, color)
        {
        }

        public override void Sound()
        {
            Console.Write("Enter sound of Car: ");
            string sound = Console.ReadLine();
            Console.WriteLine("Sound of Car: " + sound);
        }
    }
}
