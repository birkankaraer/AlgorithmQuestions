namespace Question10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pozitif sayılarda bölme işlemini çıkarma kullanarak yapan uygulamayı yazınız. 
            Console.WriteLine("bölünecek sayıyı giriniz");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("bölen sayıyı giriniz");
            int y = int.Parse(Console.ReadLine());
            int sonuc = x;
            int sayac = 0;
            while (sonuc > 0)
            {
                sonuc -= y;  
                sayac++;
            }
            Console.WriteLine(sayac);

        }
    }
}
