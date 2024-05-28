//Bir C# programı yazmanız isteniyor.
//Bu program, kullanıcıdan bir başlangıç sayısı ve bir bitiş sayısı alacak ve bu aralıktaki tüm çift sayıları toplayacak.
//Sonuç olarak toplamı ekrana yazdıracak.

Console.WriteLine("bir başlangıç sayısı giriniz");
int baslangicSayisi = int.Parse(Console.ReadLine());
Console.WriteLine("bir bitiş sayısı giriniz");
int bitisSayisi = int.Parse(Console.ReadLine());
int sonuc = 0;
while (bitisSayisi > baslangicSayisi)
{
    baslangicSayisi++;
    bitisSayisi--;
    if (baslangicSayisi % 2 == 0)
    {
        sonuc += baslangicSayisi;
    }

}
Console.WriteLine(sonuc);
