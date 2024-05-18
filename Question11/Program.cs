namespace Question11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write the application that tells how many digits the entered positive number has.

            //Solution1();

            //Solution2();

            Console.WriteLine("lütfen bir sayı giriniz");
            int s1 = int.Parse(Console.ReadLine());
            int sonuc = BasamakHesapla(s1);
            Console.WriteLine(++sonuc);


        }

        private static void Solution2()
        {
            Console.WriteLine("give me number");
            float s1 = float.Parse(Console.ReadLine());
            int i = 0;
            for (; ; )
            {
                s1 = s1 / 10;
                i++;
                if (s1 < 1)
                {

                    break;
                }
            }
            Console.WriteLine(i);
        }

        private static void Solution1()
        {
            Console.WriteLine("lütfen bir sayı giriniz");
            int s1 = int.Parse(Console.ReadLine());
            int s2 = 10;
            int sayac = 0;
            while (true)
            {
                s1 /= s2;
                sayac++;
                if (s1 < 1)
                {
                    break;
                }
            }
            Console.WriteLine(sayac);
        }

        static public int BasamakHesapla(int s1)
        {
            s1 /=  10;
            if (s1 >= 10)
                return 1 + BasamakHesapla(s1);
            return 1;
        }
    }
}
