using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3.Vehicle
{
    internal class Ship : Vehicle
    {
        int  numberOfPassengers;
        string homePort;
        public Ship(int YearOfAdmission, string Coordinat, int Price , int Speed, int NumberOfPassengers,string HomePort)  
        {
            yearOfAdmission = YearOfAdmission;
            coordinat = Coordinat;
            price = Price;
            speed = Speed;
            numberOfPassengers = NumberOfPassengers;
            homePort = HomePort;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"{numberOfPassengers} - Number Of Passengers");
            Console.WriteLine($"{homePort} - Home Port" );
        }
    }
}
