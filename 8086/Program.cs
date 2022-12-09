using System;
using System.Xml.Linq;

namespace Emulator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Emulator Intel procesor 8086!");
            Console.WriteLine("Enter number to select a function");
            Console.WriteLine("1. Add 2. Sub 3. XCHG 4. MOV 5. CLEAR 6. DEC 7. INC");
            int choice = Int32.Parse(Console.ReadLine());

            Choice(choice);
        }

        public static void Choice(int choice)
        {
         int AH;
         int BH;
         int CH;
         int DH;

         int AL;
         int BL;
         int CL;
         int DL;

            switch (choice)
            {

                case 1:
                    Console.WriteLine("select the first register!");
                    Console.WriteLine("1. AH 2. BH 3. CH 4. DH");
                    int a = Int32.Parse(Console.ReadLine());
                    Console.Write("Enter a value: ");
                    int value = Int32.Parse(Console.ReadLine());
                    switch (a)
                    {
                        case 1:
                            AH = value;
                            Console.WriteLine("AH: decimal: " + value + " hexadecimal: " + (value.ToString("X")));
                            break;
                        case 2:
                            BH = value;
                            Console.WriteLine("BH: decimal: " + value + " hexadecimal: " + (value.ToString("X")));
                            break;
                        case 3:
                            CH = value;
                            Console.WriteLine("CH: decimal: " + value + " hexadecimal: " + (value.ToString("X")));
                            break;
                        case 4:
                            DH = value;
                            Console.WriteLine("DH: decimal: " + value + " hexadecimal: " + (value.ToString("X")));
                            break;

                        default:
                            Console.WriteLine("Wrong choice");
                            break;
                    }
                    Console.WriteLine("select the second register!");
                    Console.WriteLine("1. AL 2. BL 3. CL 4. DL");
                    int b = Int32.Parse(Console.ReadLine());
                    Console.Write("Enter a value: ");
                    int value2 = Int32.Parse(Console.ReadLine());
                    switch (b)
                    {
                        case 1:
                            AL = value2;
                            Console.WriteLine("AL: decimal: " + value2 + " hexadecimal: " + (value2.ToString("X")));
                            break;
                        case 2:
                            BL = value2;
                            Console.WriteLine("BL: decimal: " + value2 + " hexadecimal: " + (value2.ToString("X")));
                            break;
                        case 3:
                            CL = value2;
                            Console.WriteLine("CL: decimal: " + value2 + " hexadecimal: " + (value2.ToString("X")));
                            break;
                        case 4:
                            DL = value2;
                            Console.WriteLine("DL: decimal: " + value2 + " hexadecimal: " + (value2.ToString("X")));
                            break;

                        default:
                            Console.WriteLine("Wrong choice");
                            break;
                    }
                    Add(value, value2);
                    break;

                case 2:
                    Console.WriteLine("select the first register!");
                    Console.WriteLine("1. AH 2. BH 3. CH 4. DH");
                    int c = Int32.Parse(Console.ReadLine());
                    Console.Write("Enter a value: ");
                    int value3 = Int32.Parse(Console.ReadLine());
                    switch (c)
                    {
                        case 1:
                            AH = value3;
                            Console.WriteLine("AH: decimal: " + value3 + " hexadecimal: " + (value3.ToString("X")));
                            break;
                        case 2:
                            BH = value3;
                            Console.WriteLine("BH: decimal: " + value3 + " hexadecimal: " + (value3.ToString("X")));
                            break;
                        case 3:
                            CH = value3;
                            Console.WriteLine("CH: decimal: " + value3 + " hexadecimal: " + (value3.ToString("X")));
                            break;
                        case 4:
                            DH = value3;
                            Console.WriteLine("DH: decimal: " + value3 + " hexadecimal: " + (value3.ToString("X")));
                            break;

                        default:
                            Console.WriteLine("Wrong choice");
                            break;
                    }
                    Console.WriteLine("select the second register!");
                    Console.WriteLine("1. AL 2. BL 3. CL 4. DL");
                    int d = Int32.Parse(Console.ReadLine());
                    Console.Write("Enter a value: ");
                    int value4 = Int32.Parse(Console.ReadLine());
                    switch (d)
                    {
                        case 1:
                            AL = value4;
                            Console.WriteLine("AL: decimal: " + value4 + " hexadecimal: " + (value4.ToString("X")));
                            break;
                        case 2:
                            BL = value4;
                            Console.WriteLine("BL: decimal: " + value4 + " hexadecimal: " + (value4.ToString("X")));
                            break;
                        case 3:
                            CL = value4;
                            Console.WriteLine("CL: decimal: " + value4 + " hexadecimal: " + (value4.ToString("X")));
                            break;
                        case 4:
                            DL = value4;
                            Console.WriteLine("DL: decimal: " + value4 + " hexadecimal: " + (value4.ToString("X")));
                            break;

                        default:
                            Console.WriteLine("Wrong choice");
                            break;
                    }
                    Sub(value3, value4);
                    break;
                case 3:
                    Console.WriteLine("select the first register!");
                    Console.WriteLine("1. AH 2. BH 3. CH 4. DH");
                    int e = Int32.Parse(Console.ReadLine());
                    Console.Write("Enter a value: ");
                    int value5 = Int32.Parse(Console.ReadLine());
                    string rej1 = "null";
                    switch (e)
                    {
                        case 1:
                            AH = value5;
                            rej1 = "AH";
                            Console.WriteLine("AH: decimal: " + value5 + " hexadecimal: " + (value5.ToString("X")));
                            break;
                        case 2:
                            BH = value5;
                            rej1 = "BH";
                            Console.WriteLine("BH: decimal: " + value5 + " hexadecimal: " + (value5.ToString("X")));
                            break;
                        case 3:
                            CH = value5;
                            rej1 = "CH";
                            Console.WriteLine("CH: decimal: " + value5 + " hexadecimal: " + (value5.ToString("X")));
                            break;
                        case 4:
                            DH = value5;
                            rej1 = "DH";
                            Console.WriteLine("DH: decimal: " + value5 + " hexadecimal: " + (value5.ToString("X")));
                            break;

                        default: Console.WriteLine("Wrong choice");
                            break;
                    }
                    Console.WriteLine("select the second register!");
                    Console.WriteLine("1. AL 2. BL 3. CL 4. DL");
                    int f = Int32.Parse(Console.ReadLine());
                    Console.Write("Enter a value: ");
                    int value6 = Int32.Parse(Console.ReadLine());
                    string rej2= "null";
                    switch (f)
                    {
                        case 1:
                            AL = value6;
                            Console.WriteLine("AL: decimal: " + value6 + " hexadecimal: " + (value6.ToString("X")));
                            rej2 = "AL";
                            break;
                        case 2:
                            BL = value6;
                            Console.WriteLine("BL: decimal: " + value6 + " hexadecimal: " + (value6.ToString("X")));
                            rej2 = "BL";
                            break;
                        case 3:
                            CL = value6;
                            Console.WriteLine("CL: decimal: " + value6 + " hexadecimal: " + (value6.ToString("X")));
                            rej2 = "CL";
                            break;
                        case 4:
                            DL = value6;
                            Console.WriteLine("DL: decimal: " + value6 + " hexadecimal: " + (value6.ToString("X")));
                            rej2 = "DL";
                            break;

                        default:
                            Console.WriteLine("Wrong choice");
                            break;
                    }
                    Xchg(value5, value6, rej1, rej2);
                    break;

                case 4:
                    Console.WriteLine("select register to send!");
                    Console.WriteLine("1. AH 2. BH 3. CH 4. DH");
                    int i = Int32.Parse(Console.ReadLine());
                    Console.Write("Enter a value: ");
                    int value9 = Int32.Parse(Console.ReadLine());
                    string rej11 = "null";
                    switch (i)
                    {
                        case 1:
                            AH = value9;
                            rej11 = "AH";
                            Console.WriteLine("AH: decimal: " + value9 + " hexadecimal: " + (value9.ToString("X")));
                            break;
                        case 2:
                            BH = value9;
                            rej11 = "BH";
                            Console.WriteLine("BH: decimal: " + value9 + " hexadecimal: " + (value9.ToString("X")));
                            break;
                        case 3:
                            CH = value9;
                            rej11 = "CH";
                            Console.WriteLine("CH: decimal: " + value9 + " hexadecimal: " + (value9.ToString("X")));
                            break;
                        case 4:
                            DH = value9;
                            rej11 = "DH";
                            Console.WriteLine("DH: decimal: " + value9 + " hexadecimal: " + (value9.ToString("X")));
                            break;

                        default:
                            Console.WriteLine("Wrong choice");
                            break;
                    }
                    Console.WriteLine("select the register to send to!");
                    Console.WriteLine("1. AL 2. BL 3. CL 4. DL");
                    int j = Int32.Parse(Console.ReadLine());
                    string rej12 = "null";
                    switch (j)
                    {
                        case 1:
                            AL = value9;
                            rej12 = "AL";
                            break;
                        case 2:
                            BL = value9;                           
                            rej12 = "BL";
                            break;
                        case 3:
                            CL = value9;                     
                            rej12 = "CL";
                            break;
                        case 4:
                            DL = value9;
                            rej12 = "DL";
                            break;

                        default:
                            Console.WriteLine("Wrong choice");
                            break;
                    }

                    Mov( value9, rej12);

                    break;

                case 5:
                     AH=0;
                     BH=0;
                     CH=0;
                     DH=0;

                     AL=0;
                     BL=0;
                     CL=0;
                     DL=0;

                    Console.Write(" AH: " + AH);
                    Console.WriteLine(" AL: " + AL);
                    Console.Write(" BH: " + BH);
                    Console.WriteLine(" BL: " + BL);
                    Console.Write(" CH: " + CH);
                    Console.WriteLine(" CL: " + CL);
                    Console.Write(" DH: " + DH);
                    Console.Write(" DL: " + DL);

                    break;

                case 6:
                    Console.WriteLine("select register!");
                    Console.WriteLine("1. AH 2. BH 3. CH 4. DH");
                    int g = Int32.Parse(Console.ReadLine());
                    Console.Write("Enter a value: ");
                    int value7 = Int32.Parse(Console.ReadLine());
                    switch (g)
                    {
                        case 1:
                            AH = value7-1;
                            Console.WriteLine("AH: decimal: " + AH + " hexadecimal: " + (AH.ToString("X")));
                            break;
                        case 2:
                            BH = value7 - 1;
                            Console.WriteLine("BH: decimal: " + BH + " hexadecimal: " + (BH.ToString("X")));
                            break;
                        case 3:
                            CH = value7 - 1;
                            Console.WriteLine("CH: decimal: " + CH + " hexadecimal: " + (CH.ToString("X")));
                            break;
                        case 4:
                            DH = value7 - 1;
                            Console.WriteLine("DH: decimal: " + DH + " hexadecimal: " + (DH.ToString("X")));
                            break;

                        default:
                            Console.WriteLine("Wrong choice");
                            break;
                    }
                    break;

                case 7:
                    Console.WriteLine("select register!");
                    Console.WriteLine("1. AL 2. BL 3. CL 4. DL");
                    int h = Int32.Parse(Console.ReadLine());
                    Console.Write("Enter a value: ");
                    int value8 = Int32.Parse(Console.ReadLine());
                    switch (h)
                    {
                        case 1:
                            AL = value8 + 1;
                            Console.WriteLine("AL: decimal: " + AL + " hexadecimal: " + (AL.ToString("X")));
                            break;
                        case 2:
                            BL = value8 + 1;
                            Console.WriteLine("BL: decimal: " + BL + " hexadecimal: " + (BL.ToString("X")));
                            break;
                        case 3:
                            CL = value8 + 1;
                            Console.WriteLine("CL: decimal: " + CL + " hexadecimal: " + (CL.ToString("X")));
                            break;
                        case 4:
                            DL = value8 + 1;
                            Console.WriteLine("DL: decimal: " + DL + " hexadecimal: " + (DL.ToString("X")));
                            break;

                        default:
                            Console.WriteLine("Wrong choice");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("Wrong choice");
                    break;
            }
        }        
    
            public static void Add(int a, int b)
            {
            int sum = a + b;
            string hexValue = sum.ToString("X");
            Console.WriteLine($"Result: decimal: {a + b} hexadecimal: {hexValue}");
            }

            public static void Sub(int a, int b)
            {
            int difference = a - b;
            string hexValue1 = difference.ToString("X");
            Console.WriteLine($"Result: decimal: {a - b} hexadecimal: {hexValue1}");


            }

            public static void Xchg(int H, int L, string rej1, string rej2)
            {
            Console.WriteLine("Result: ");
            Console.WriteLine($"{rej1}: decimal: {L} hexadecimal: {(L.ToString("X"))}");
            Console.WriteLine($"{rej2}: decimal: {H} hexadecimal: {(H.ToString("X"))}");
            }

            public static void Mov(int H, string rej1)
            {
            Console.WriteLine("Result: ");
            Console.WriteLine($"{rej1}: decimal: {H} hexadecimal: {(H.ToString("X"))}");




        }





    }
}
