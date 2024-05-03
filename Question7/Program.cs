namespace Question7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcın girdiği sayının faktöriyelini hesaplayan uygulamayı yazınız.

            //Solution1();

            //Console.WriteLine("lütfen bir sayı giriniz");
            //int s1 = int.Parse(Console.ReadLine());   
            //int sayac = 1;
            //int sonuc = 1;
            //while (sayac <= s1)
            //{
            //    sonuc = sayac * sonuc;
            //    sayac++;
            //}
            //Console.WriteLine(sonuc);

            //Console.WriteLine("lütfen bir sayı giriniz");
            //int s1 = int.Parse(Console.ReadLine());
            //int sayac = 0;
            //int sonuc = 1;
            //do
            //{
            //    sonuc = sayac * sonuc;
            //    sayac++;
            //} while (sayac <= s1);
            //Console.WriteLine(sonuc);

            //Console.WriteLine("lütfen bir sayı giriniz");
            //int sayi = int.Parse(Console.ReadLine());
            //int sonuc = 1;
            //while (sayi > 0)
            //{
            //    sonuc *= sayi;
            //    sayi--;
            //}
            //Console.WriteLine(sonuc);

            //Console.WriteLine("Lütfen bir sayı giriniz:");
            //int sayi = int.Parse(Console.ReadLine());
            //int sonuc = 1;
            //string result = "";

            //while (sayi > 1)
            //{
            //    sonuc = sayi * sonuc;
            //    if (sayi != 1)
            //    {
            //        result += $"{sayi}X";
            //    }
            //    else
            //    {
            //        result += $"{sayi} = {sonuc}";
            //    }
            //    sayi--;
            //}
            //Console.WriteLine(result);


            Console.WriteLine("lütfen bir sayı giriniz");
            int sayi = int.Parse(Console.ReadLine());
            Console.WriteLine(Faktoriyel(sayi));

        }

        private static void Solution1()
        {
            Console.WriteLine("lütfen bir sayı giriniz");
            int s1 = int.Parse(Console.ReadLine());
            int sonuc = 1;
            for (int i = 1; i <= s1; i++)
            {
                sonuc *= i;
            }
            Console.WriteLine(sonuc);
        }

        static int Faktoriyel(int sayi)
        {
            if (sayi > 1)
                return sayi * Faktoriyel(--sayi);
            return sayi;
        }
    }
}
