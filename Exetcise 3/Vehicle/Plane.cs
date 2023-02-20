using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3.Vehicle
{
    internal class Plane :Vehicle
    {
        int numberOfPassengers, height;
        
        public Plane   (int YearOfAdmission, string Coordinat, int Price, int Speed, int NumberOfPassengers,  int Height) 
        {
            yearOfAdmission = YearOfAdmission;
            coordinat = Coordinat;
            price = Price;
            speed = Speed;
            numberOfPassengers = NumberOfPassengers;
            height = Height;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"{numberOfPassengers} -Number Of Passengers");
            Console.WriteLine($"{height} - height" );
        }
    }
}
