namespace Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //application that returns the sum of the squares of two numbers entered by the user 
            #region çözüm1
            //Console.WriteLine("sayi1 değerini giriniz");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("sayi2 değerini giriniz");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //int sonuc = (sayi1 *= sayi1) + (sayi2 *= sayi2);
            //Console.WriteLine(sonuc);
            #endregion

            //#region çözüm2
            //Console.WriteLine("sayi3 değerini giriniz");
            //int sayi3 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("sayi4 değerini giriniz");
            //int sayi4 = Convert.ToInt32(Console.ReadLine());
            //double sonuc2 = Math.Pow(sayi3, 2) + Math.Pow(sayi4, 2);
            //Console.WriteLine(sonuc2);
            //#endregion

            //iki sayının karelerinin toplamını alacaksın ve sonucu 500 bulana kadar bu işlemi devam ettireceksin, sayıları kullanıcıdan alacaksın.

            //#region
            //double sonuc = 0;
            //while (sonuc == 500)
            //{
            //    Console.WriteLine("lütfen birinci ve ikinci sayıyı giriniz");
            //    sonuc = ((Math.Pow(int.Parse(Console.ReadLine()), 2) + Math.Pow(int.Parse(Console.ReadLine()), 2)));
            //    Console.WriteLine(sonuc);
            //}
            //#endregion


            //while (true)
            //{
            //    Console.WriteLine("lütfen birinci sayıyı giriniz");
            //    int s1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("lütfen ikinci sayıyı giriniz");
            //    int s2 = int.Parse(Console.ReadLine());
            //    double sonuc2 = Math.Pow(s1, 2) + Math.Pow(s2, 2);
            //    Console.WriteLine(sonuc2);
            //    if (sonuc2 == 500)
            //    {
            //        break;
            //    }
            //}

            //int sayi1, sayi2;
            //int toplam = 0;

            //do
            //{
            //    Console.Write("Birinci sayıyı girin: ");
            //    sayi1 = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("İkinci sayıyı girin: ");
            //    sayi2 = Convert.ToInt32(Console.ReadLine());

            //    int kareToplami = sayi1 * sayi1 + sayi2 * sayi2;
            //    toplam += kareToplami;

            //    Console.WriteLine($"Sayıların karelerinin toplamı: {kareToplami}");
            //    Console.WriteLine($"Toplam: {toplam}");
            //} while (toplam < 500);

            //Console.WriteLine("Toplam 500'ü geçti!");

            while (true)
            {
                Console.WriteLine("lütfen birinci sayıyı giriniz");
                int s1 = int.Parse(Console.ReadLine());
                Console.WriteLine("lütfen ikinci sayıyı giriniz");
                int s2 = int.Parse(Console.ReadLine());
                double sonuc2 = Math.Pow(s1, 2) + Math.Pow(s2, 2);
                Console.WriteLine(sonuc2);
                double toplam =+ sonuc2;
                if (toplam == 500)
                {
                    break;
                }
            }


        }
    }
}
