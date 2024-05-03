namespace Question9
{
    internal class Program
    {
        static void Main(string[] args)
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
    }
}
