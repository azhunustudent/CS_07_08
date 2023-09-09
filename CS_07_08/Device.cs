using System;

namespace CS_07_08
{
    public class Device
    {
        protected string name;
        protected double weight;
        protected string color;

        public string Name   { get { return name; } set { name = value; } }
        public double Weight { get { return weight; } set { weight = value; } }
        public string Color  { get { return color; } set { color = value; } }


        public Device(string name, double weight,  string color)
        {
            Name = name;
            Weight = weight;
            Color = color;
        }

        // Sound — издает звук устройства(пишем текстом в консоль);
        public virtual void Sound()
        {
            Console.Write("Enter sound of Device: ");
            string sound = Console.ReadLine();
            Console.WriteLine("Sound of Device: " + sound);
        }

        // Show — отображает название устройства;
        public void Show()
        {
            Console.WriteLine($"Name: {Name}");
        }

        // Desc — отображает описание устройства.
        public void Desc()
        {
            Console.WriteLine($"Description:");
            Console.WriteLine($"Weight: {Weight}\nColor: {Color}");
        }
    }
}
