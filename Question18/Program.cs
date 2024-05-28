int[] numbers = { 1, 2, 3, 4, 5 };
int sonuc = 0;
foreach (var item in numbers)
{
    if (item % 2 == 0)
    {
        sonuc += item;
    }
}
Console.WriteLine(sonuc);
