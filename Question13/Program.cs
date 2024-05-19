namespace Question13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bilgisayar 1 ile 100 arasında rastgele bir sayı seçer. Kullanıcı bu sayıyı tahmin etmeye çalışır. Kullanıcı her tahminde bulunduğunda,
            //bilgisayar kullanıcının tahmininin doğru olup olmadığını veya seçilen sayıdan daha büyük ya da daha küçük olduğunu söyler.

            Random rnumber = new Random();
            int sayi = rnumber.Next(10);
            while (true)
            {
                Console.WriteLine("lütfen tahminde bulunduğunuz sayıyı giriniz");
                int tsayi = int.Parse(Console.ReadLine());
                if (sayi == tsayi)
                {
                    Console.WriteLine("sayıyı buldunuz");
                    Console.WriteLine($"random sayı : {sayi}");
                    break;
                }
                else if (sayi > tsayi)
                {
                    Console.WriteLine("sayı daha büyük");
                }
                else if (sayi < tsayi)
                {
                    Console.WriteLine("sayı daha küçük");
                }
                else
                {
                    Console.WriteLine("lütfen geçerli bir değer giriniz");
                }
            }
            
        }
    }
}
