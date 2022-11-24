using System;

namespace Project
{
    class Project
    {
        int funkcja = 0;
        int arytmetyczne = 0;

        /*
        public static String convertToBinary(int n)
        {
            String result = "";
 
            if (n == 0)
            return "0";
 
            //process until n > 0
            while (n>0)
        {
            result = pattern[n % 2] + result;
            n /= newBase;
        }*/

         public static void Dodawanie(int a, int b)
            {
                Console.WriteLine(a+b);
            }

         public static void Odejmowanie(int a, int b)
            {
                Console.WriteLine(a-b);;
            }

        static void Main() //ALU
        {
            Console.WriteLine("Emulator microprocesora INTEL-8086");
            Console.WriteLine("Wybierz funkcję: \n 1. Artmetyczne \n 2. Logiczne ");

                switch (funkcja)
                    {
                    case 1
                        {
                        Console.WriteLine("Podaj pierwszą zmienną: ");
                        int a = Console.ReadLine();
                        Console.WriteLine("Podaj drugą zmienną: ");
                        int b = Console.ReadLine();
                        Console.WriteLine("Wybierz funkcję: \n 1. Dodawanie \n 2. Odejmowanie ");
                        switch (arytmetyczne)
	                    {
                            case 1
                            {
                                    Dodawanie(a, b);
                                    break;
                                }
                            case 2
                            {
                                    Odejmowanie(a, b);
                                    break;
                                }

		                    default: Console.WriteLine("Wybirz liczbę z zakresu od 1 do 2");
	                    }
                    break;
                    }
                   // case 2
                   //     {
                        
                  //  break;
                  //  }
                    default: Console.WriteLine("Wybirz liczbę z zakresu od 1 do 2");
                }

        }
    }
}
