namespace CS_07_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создать базовый класс «Устройство» и 
            // производные классы «Чайник», «Микроволновка»,
            // «Автомобиль», «Пароход». С помощью конструктора
            // установить имя каждого устройства и его характеристики.
            // Реализуйте для каждого из классов методы:
            // Sound — издает звук устройства(пишем текстом в консоль);
            // Show — отображает название устройства;
            // Desc — отображает описание устройства.

            Kettle kettle = new Kettle("Kettle", 1.5, "gray");
            kettle.Sound();
            Console.WriteLine("---------------------------------");
            kettle.Show();
            Console.WriteLine("---------------------------------");
            kettle.Desc();
            Console.WriteLine("---------------------------------");


            Microwave microwave = new Microwave("Microwave", 25, "white");
            microwave.Sound();
            Console.WriteLine("---------------------------------");
            microwave.Show();
            Console.WriteLine("---------------------------------");
            microwave.Desc();
            Console.WriteLine("---------------------------------");


            Car car = new Car("Car", 1850, "red");
            car.Sound();
            Console.WriteLine("---------------------------------"); 
            car.Show();
            Console.WriteLine("---------------------------------"); 
            car.Desc();
            Console.WriteLine("---------------------------------");


            Ship ship = new Ship("Ship", 200000, "blue");
            ship.Sound();
            Console.WriteLine("---------------------------------"); 
            ship.Show();
            Console.WriteLine("---------------------------------"); 
            ship.Desc();
        }
    }
}