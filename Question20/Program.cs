namespace Question20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 1, 2, 3, 4, 5, 6 };
            int sonuc = 0;
            foreach (var item in sayilar)
            {
                if (item % 2 == 0)
                {
                    sonuc += item;
                }
            }
            Console.WriteLine(sonuc);
        }
    }
}
