using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3.Vehicle
{
    internal class Car : Vehicle
    {
        public Car(int YearOfAdmission, string Coordinat, int Price, int Speed) 
        {
            yearOfAdmission = YearOfAdmission;
            coordinat = Coordinat;
            price = Price;
            speed = Speed;
        }
        public override void Show()
        {
            base.Show();

        }
    }
}
