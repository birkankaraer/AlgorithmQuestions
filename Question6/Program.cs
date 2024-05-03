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

            //Solution3();

            Console.WriteLine("Lütfen doğum tarihinizi giriniz");
            DateTime dogumTarihi = DateTime.Parse(Console.ReadLine());
            DateTime now = DateTime.Now;
            int yas = (now - dogumTarihi).Days;
            int sonuc = yas / 365;
            Console.WriteLine($"{sonuc} yaşındasınız");

            int kacGunKaldi = ((dogumTarihi.Month - now.Month) * 30) + (dogumTarihi.Day - now.Day);
            Console.WriteLine($"Doğum gününüze {kacGunKaldi} gün kaldı");


        }

        private static void Solution3()
        {
            Console.WriteLine("lütfen doğum tarihinizi giriniz");
            DateTime dogumTarihi = DateTime.Parse(Console.ReadLine());
            DateTime bugun = DateTime.Now;

            int yas = bugun.Year - dogumTarihi.Year;

            if (dogumTarihi > bugun.AddYears(-yas)) { yas--; }

            Console.WriteLine(yas);
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
