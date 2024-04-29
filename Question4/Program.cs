namespace Question4
{
	internal class Program
	{

		static void Main(string[] args)
		{
            //Develop the code that calculates the number entered by the user according to the following proposals.
            // sayı < 3                    => sayı * 5
            // sayı > 3 && sayı < 9        => sayı * 3
            // sayı >= 9 && sayı % 2 == 0  => sayı * 10
            // sayı % 2 == 1               => sayı
            // hiçbiri değilse             => -1

            int _sayi;
			int sonuc = 0;
			while (sonuc != -1)
			{

				Console.WriteLine("bir sayı giriniz");
				 _sayi = int.Parse(Console.ReadLine());
				sonuc = _sayi < 3 && _sayi > 1 ? _sayi * 5 
					: (_sayi > 3 && _sayi < 9 ? _sayi * 3 
					: (_sayi >= 9 && _sayi % 2 == 0 ? _sayi * 10 
					: (_sayi % 2 == 1 ? _sayi : -1)));
				Console.WriteLine(sonuc);
				
			}
		}
	}
}
