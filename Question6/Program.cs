namespace Question6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //an application that calculates the age of the person whose date of birth is entered

            //Solution1();

            //I calculate the age of the users and if it is their birthday, I celebrate their birthday

            //Solution2();

        }

        private static void Solution2()
        {
            Console.WriteLine("lütfen doğum tarihinizi yy,aa,gg şeklinde giriniz");
            DateTime birthday = Convert.ToDateTime(Console.ReadLine());
            DateTime datenow = new DateTime(2024, 04, 30);
            TimeSpan youage = datenow - birthday;
            int age = youage.Days / 365;

            Console.WriteLine("yasiniz :" + age);
            if (birthday.Day == 30 && birthday.Month == 04)
            {
                Console.WriteLine("iyi ki doğdun kral");
            }
        }

        private static void Solution1()
        {
            Console.WriteLine("Doğum yılınızı giriniz");
            int ky = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("yasiniz" + $"{2024 - ky}");
        }
    }
}
