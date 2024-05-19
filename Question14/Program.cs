
//Kullanıcıdan bir dizi uzunluğu ve dizi elemanlarını girmesini isteyin. Bu dizideki en büyük sayıyı bulun ve ekrana yazdırın.

Console.WriteLine("lütfen bir dizi uzunluğu giriniz");
int du = int.Parse(Console.ReadLine());
int[] nums = new int[du];
Console.WriteLine($"lütfen dizinin {du} elemanını giriniz");
for (int i = 0; i < nums.Length; i++)
{
    int number = int.Parse(Console.ReadLine());
    nums[i] = number;
}

int enBuyuk = nums[0];

for (int i = 1; i < du; i++)
{
    if (nums[i] > enBuyuk)
    {
        enBuyuk = nums[i];
    }
}

Console.WriteLine($"Dizideki en büyük sayı: {enBuyuk}");

