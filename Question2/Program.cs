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

            #region
            Console.WriteLine("sayi3 değerini giriniz");
            int sayi3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sayi4 değerini giriniz");
            int sayi4 = Convert.ToInt32(Console.ReadLine());
            double sonuc2 = Math.Pow(sayi3, 2) + Math.Pow(sayi4, 2);
            Console.WriteLine(sonuc2);
            #endregion
        }
    }
}
