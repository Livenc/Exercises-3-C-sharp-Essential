using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    internal class ClassRoom
    {
        Pupil[] pupils; 
       public ClassRoom (params Pupil[] pupils)
        {
            this.pupils = pupils;
        }
        //public  ClassRoom(Pupil pupil, Pupil pupil2 )
        // {

        // }
        // public ClassRoom(Pupil pupil, Pupil pupil2, Pupil pupil3) 
        // { 

        // }
        public void Show()
        {
            int i = 1;
            foreach (var p in pupils) 
            {
                Console.WriteLine($"{i} - pupil:");
                p.Study();
                p.Read();
                p.Write();
                p.Relax();
                i++;
                Console.WriteLine();
            }
        }
    }
}
