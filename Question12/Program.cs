using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Question12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write the application that finds whether the sum of the cubes of the digits of the entered 3-digit number is equal to the number itself.

            Console.WriteLine("Please give me a number, but no more than three digits.");
            int num = int.Parse(Console.ReadLine());
            int num1 = num / 100;
            int num2 = (num / 10) % 10;
            int num3 = num % 10;
            int sonuc = (num1 * num1 * num1) + (num2 * num2 * num2) + (num3 * num3 * num3);

            Console.WriteLine($"{num} sayısının basamaklarının küpleri toplamı {sonuc}.");
        }
    }
}
