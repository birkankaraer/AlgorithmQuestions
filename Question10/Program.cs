namespace Question10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write the application that performs division of positive numbers using subtraction. 

            //int sayac = Solution1();

            //sayac = Solution2(sayac2);

            Console.WriteLine("lütfen bölünecek sayıyı giriniz");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("lütfen bölen sayıyı giriniz");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Sonuc(sayi1, sayi2));

            int bolmeSonucu = Sonuc(sayi1, sayi2);
            int kalan = Kalan(sayi1, sayi2);
            Console.WriteLine($"{sayi1} / {sayi2} = {bolmeSonucu} | Kalan = {kalan}");
        }

        static int Sonuc(int sayi1, int sayi2)
        {
            sayi1 -= sayi2;
            if (sayi1 >= sayi2)
                return 1 + Sonuc(sayi1, sayi2);
            return 1;
        }

        static int Kalan(int sayi1, int sayi2)
        {
            sayi1 -= sayi2;
            if(sayi1 >= sayi2)
                return Kalan(sayi1, sayi2);
            return sayi1;
        }

        private static int Solution2(int sayac)
        {
            Console.WriteLine("bölünecek sayıyı giriniz");
            int s1 = int.Parse(Console.ReadLine());
            Console.WriteLine("bölen sayıyı giriniz");
            int s2 = int.Parse(Console.ReadLine());
            int sayac2 = 0;
            int _s1 = s1;
            while (true)
            {
                s1 -= s2;
                sayac2++;
                if (s2 > s1)
                {
                    break;
                }
            }
            Console.WriteLine($"{_s1} / {s2} = {sayac2} | Kalan = {s1}");
            return sayac2;
        }

        private static int Solution1()
        {
            Console.WriteLine("bölünecek sayıyı giriniz");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("bölen sayıyı giriniz");
            int y = int.Parse(Console.ReadLine());
            int sonuc = x;
            int sayac = 0, kalan = 0;
            while (sonuc > 1)
            {
                sonuc -= y;
                sayac++;
                kalan = x;
            }
            Console.WriteLine($"{sayac}, {sonuc}");
            return sayac;
        }
    }
}
