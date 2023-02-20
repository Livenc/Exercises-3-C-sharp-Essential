using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3.Vehicle
{
      class Vehicle
    {
        public string coordinat;
        public int price, speed, yearOfAdmission;

        public virtual void Show()
        {
            Console.WriteLine($"{coordinat} - coordinat");
            Console.WriteLine($"{price} - price");

            Console.WriteLine($"{speed} - speed"); 

            Console.WriteLine($"{yearOfAdmission} - year Of Admission"); 
        }
    }
}
