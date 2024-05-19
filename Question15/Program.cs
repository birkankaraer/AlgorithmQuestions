//Kullanıcıdan bir kelime alın ve bu kelimenin palindrom olup olmadığını kontrol edin. Palindrom, tersten okunduğunda da aynı olan kelimedir.

Console.WriteLine("Lütfen bir kelime giriniz");
bool palindromMu = true;
string word = Console.ReadLine();
for (int i = word.Length - 1; i >= 0; i--)
{
    if (word[i] != word[word.Length - 1 -i])
    {
        palindromMu = false;
        break;
    }
}
if (palindromMu)
{
    Console.WriteLine($"{word} bir palindromdur.");
}
else
{
    Console.WriteLine($"{word} bir palindrom değildir.");
}

