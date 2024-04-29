namespace Question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write the application that gives the sum of two numbers.

            #region Çözüm 1
            //int sayi1 = 10, sayi2 = 20;
            //Console.WriteLine(sayi1 + sayi2);
            #endregion

            #region Çözüm 2
            //Console.WriteLine("sayi3 değerini giriniz");
            //int sayi3 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("sayi4 değerini giriniz");
            //int sayi4 = int.Parse(Console.ReadLine());
            //Console.WriteLine(sayi3 + sayi4);
            #endregion

            #region Çözüm 3
            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("sayi5 değerini giriniz");
            //        int sayi5 = Convert.ToInt32(Console.ReadLine());

            //        Console.WriteLine("sayi6 değerini giriniz");
            //        int sayi6 = int.Parse(Console.ReadLine());

            //        Console.WriteLine(sayi5 + sayi6);

            //        // eğer buraya kadar gelindi ise, doğru değerler girilmiştir, döngüden çıkabiliriz.
            //        break;
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("lütfen doğru bir sayı değeri giriniz.");
            //    }
            //}
            #endregion

            #region Çözüm 4
            while (true)
            {
                int sayi7;
                int sayi8;
                try
                {
                    Console.WriteLine("sayi7 değerinin giriniz");
                    sayi7 = Convert.ToInt32(Console.ReadLine());
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("sayi8 değerini giriniz");
                            sayi8 = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("lütfen sayi8 değerini doğru giriniz");
                        }
                    }
                    Console.WriteLine(sayi7 + sayi8);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Lütfen sayi7 değerini doğru giriniz");
                }
            }
            #endregion
        }
    }
}
