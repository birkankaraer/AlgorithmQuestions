namespace Question5
{
	internal class Program
	{
		static void Main(string[] args)
		{
            //Write the program that implements the following suggestions according to the value of the string variable that holds the weather.
            //yağmurlu => "şemsiye almalısın"
            //günesli => "bol bol d vitamini alman dileğiyle..."
            //kapali => "yağmur yağabilir"
            Console.WriteLine("hava durumunu giriniz: " + "\n1- yağmurlu" + "\n2- güneşli" + "\n3- kapali");
            string havaDurumu = Console.ReadLine();
			string mesaj = "";
			mesaj = havaDurumu == "yağmurlu" ? "şemsiye almalısın" : (havaDurumu == "günesli" ? "bol bol d vitamini alman dileğiyle..." : "yağmur yağabilir");
            Console.WriteLine(mesaj);

        }
	}
}
