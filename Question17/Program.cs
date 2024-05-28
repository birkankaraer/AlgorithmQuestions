using System;
using System.Linq;

class Program
{
    // İki sayının EBOB'unu hesaplayan metod
    static int FindGCD(int num1, int num2)
    {
        while (num2 != 0)
        {
            int temp = num2;
            num2 = num1 % num2;
            num1 = temp;
        }
        return num1; // EBOB
    }

    // Bir dizi sayının EBOB'unu hesaplayan metod
    static int FindGCDForArray(int[] numbers)
    {
        if (numbers.Length == 0) return 0;
        int gcd = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            gcd = FindGCD(gcd, numbers[i]);
            if (gcd == 1) break; // EBOB 1 olursa, daha küçük bir değer olmayacağı için döngüyü sonlandırabiliriz.
        }
        return gcd;
    }

    static void Main()
    {
        // Kullanıcıdan sayıları girmesini isteyelim
        Console.WriteLine("Sayıları aralarında boşluk bırakarak girin:");
        string input = Console.ReadLine();

        // Kullanıcıdan gelen dizeyi sayılara çevirelim
        int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

        // Dizinin EBOB'unu bulalım
        int gcd = FindGCDForArray(numbers);

        // Sonucu ekrana yazdıralım
        Console.WriteLine("En Büyük Ortak Bölen (EBOB): " + gcd);
    }
}
