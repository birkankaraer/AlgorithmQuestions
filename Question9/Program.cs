namespace Question9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Solution1();

            //Solution();

            //Write an application that finds multiplication of positive numbers using addition, recursive.

            //Solution3();

            Console.WriteLine("lütfen birinci sayıyı giriniz");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("lütfen ikinci sayıyı giriniz");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Toplama(sayi1, sayi2));

        }

        private static void Solution3()
        {
            Console.WriteLine("lütfen birinci sayıyı giriniz");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("lütfen ikinci sayıyı giriniz");
            int sayi2 = int.Parse(Console.ReadLine());
            int sonuc = 0;
            int sayac = sayi2;
            do
            {
                sonuc += sayi1;  //3,6,9,12,15
                sayac--;         //4,3,2,1,0
            } while (sayac > 0);
            Console.WriteLine($"{sayi1} X {sayi2} = {sonuc}");
        }

        private static void Solution()
        {
            Console.WriteLine("bir sayı giriniz");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("bir sayı daha giriniz");
            int sayi2 = int.Parse(Console.ReadLine());
            int sonuc = 0;
            int sayac = sayi2;
            while (sayac > 0)
            {
                sonuc += sayi1;
                sayac--;
            }
            Console.WriteLine($"{sayi1} X  {sayi2} = {sonuc}");
        }

        private static void Solution1()
        {
            Console.WriteLine("lütfen birinci sayıyı giriniz");
            int s1 = int.Parse(Console.ReadLine());
            Console.WriteLine("lütfen ikinci sayıyı giriniz");
            int s2 = int.Parse(Console.ReadLine());
            int sonuc = 0;
            while (0 < s2)
            {
                sonuc += s1;
                s2--;
            }
            Console.WriteLine(sonuc);
        }

        static int Toplama(int sayi1, int sayi2)
        {
            if (sayi2 > 1)
                return sayi1 + Toplama(sayi1, --sayi2);
            return sayi1;
        }
    }
}
