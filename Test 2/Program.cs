using System; 
namespace Test._2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilken av följande alternativ vill du omvandla? Skriv 1 elle 2:");
            Console.WriteLine("1. Omvandla från Celsius till Fahrenheit");
            Console.WriteLine("2. Omvandla från Fahrenheit till Celsius");
            string användarensval = Console.ReadLine();


            switch (användarensval)
            {
                case "1":
                    Celsius();
                    Console.WriteLine();
                    break;

                case "2":
                    Fahrenheit();
                    Console.WriteLine();
                    break;
            }

        }

        static void Celsius()
        {
            int tal1 = 32;
            double tal2 = 1.8;
            Console.WriteLine("Skriv in tal för att omvandla Celsius till Fahrenheit: ");
            int tal = int.Parse(Console.ReadLine());
            Console.WriteLine($"Svaret till tal 1 är:{tal1 + (tal * tal2)}");
            
        }

        static void Fahrenheit()
        {
            int tal3 = 32;
            double tal4 = 1.8;
            Console.WriteLine("Skriv in tal för att omvandla Fahrenheit till Celsius: ");
            int tal = int.Parse(Console.ReadLine());
            Console.WriteLine($"Svaret till tal 2 är:{(tal3 - tal) / tal4}");
        }
    }
}