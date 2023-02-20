using Exercise_3.Vehicle;

namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(1997,"32NE43LE",2500,140);
            Ship ship = new Ship(2004, "12NE23LE", 10000, 78, 1400, "Los Angel Port");
            Plane plane = new Plane(2001, "38NE23LE", 2500, 450, 400, 1444);
            car.Show();
            Console.WriteLine();
            ship.Show();
            Console.WriteLine();
            plane.Show();
            Console.ReadKey();
        }
    }
}