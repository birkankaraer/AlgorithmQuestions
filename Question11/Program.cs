namespace Question11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write the application that tells how many digits the entered positive number has.

            //Solution1();

            Console.WriteLine("give me number");
            float s1 = float.Parse(Console.ReadLine());
            int i;
            for (i = 0; i < 100000; i++)
            {
                s1 = s1 / 10;
                if (s1 < 1)
                {
                    i++;
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
    }
}
