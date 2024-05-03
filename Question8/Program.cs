namespace Question8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The application that calculates the factorial of the entered number was done with a recursive function.

            Console.WriteLine("please give me number");
            int sayi = int.Parse(Console.ReadLine());
            Console.WriteLine(Faktoriyel(sayi));
        }

        static int Faktoriyel(int sayi)
        {
            if (sayi > 1)
                return sayi * Faktoriyel(--sayi);
            return sayi;
        }
    }
}
