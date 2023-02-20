namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BadPupil badPupil  = new BadPupil();
            
            ExcelentPupil excelentPupil = new ExcelentPupil();
            GoodPupil goodPupil = new GoodPupil();
            GoodPupil goodPupil1 = new GoodPupil();

            //Pupil pupil = (Pupil)badPupil;
            ClassRoom classRoom = new ClassRoom(badPupil, excelentPupil, goodPupil, goodPupil1);
            classRoom.Show();
            Console.ReadLine();
        }
    }
}