namespace PracticeQuestions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write the application that finds the sum of the cubes of the numbers from 1 to 10.

            //Solution1();

            //Solution2();

            //Solution3();

            Solution4();
        }

        private static void Solution4()
        {
            int sayac = 1;
            double toplamSonuc = 0;
            string sonuc = "";
            while (sayac <= 10)
            {
                toplamSonuc += Math.Pow(sayac, 3);

                if (sayac != 10)
                {
                    sonuc += $"{sayac}³ + ";
                }
                else
                {
                    sonuc += $"{sayac}³ = {toplamSonuc} ";
                }
                sayac++;

            }
            Console.WriteLine(sonuc);
        }

        private static void Solution3()
        {
            int sayi1 = 1;
            double sonuc = 0;
            do
            {
                sonuc += Math.Pow(sayi1, 3);
                Console.WriteLine($"{sayi1} : {sonuc}");
                sayi1++;
            } while (sayi1 <= 10);
            Console.WriteLine(sonuc);
        }

        private static void Solution2()
        {
            int sayi1 = 0;
            double sonuc = 0;

            while (sayi1 < 10)
            {
                sonuc += Math.Pow(sayi1, 3);
                sayi1++;
            }
            Console.WriteLine(sonuc);
        }

        private static void Solution1()
        {
            double sonuc = 0;
            for (int i = 1; i <= 10; i++)
            {
                sonuc += Math.Pow(i, 3);

            }
            Console.WriteLine(sonuc);
        }
    }
}
