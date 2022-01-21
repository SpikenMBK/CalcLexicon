using System;
using System.Collections.Generic;

namespace CalcLexicon
{
    public class Program
    {
        public static double Result { get; set; }
        public int Val { get; set; }
        //public static double[] arrayList { get; set; }

        static void Main(string[] args)
        {

            int Val = 0;
            double firstNumber = 0;
            double secondNumber = 0;
            List<double> testList = new List<double>();
            double[] arrayList = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            
            while (Val != 8)
            {


                Val = Menu();
                if (Val == 8)
                {
                    return;
                }
                if (Val > 0 && Val < 5)
                {
                    Console.WriteLine("Slå in ditt första tal");
                    firstNumber = getNumber();
                    Console.WriteLine("Slå in ditt andra tal");
                    secondNumber = getNumber();
                }
                if (Val == 5 || Val == 6)
                {
                    for (int i = 0; i < arrayList.Length; i++)
                    {
                        arrayList[i] = 0;
                    }
                    string rad;
                    while (true)
                    {
                     
                        Console.WriteLine("Ange talen, MAX antal tal är 10 st............(tryck q för att avbryta");
                        rad = Console.ReadLine();
                        if (rad[0] == 'Q' || rad[0] == 'q') break;
                        testList.Add(Convert.ToDouble(rad));
                        for (int i = 0; i < testList.Count; i++)
                        {
                            arrayList[i] = testList[i];
                        }


                    }
                    testList.Clear();
                    Console.WriteLine("testa arrayList");
                    for (int y = 0; y < arrayList.Length; y++)
                    {
                        Console.WriteLine(arrayList[y]);
                    }                 

                }

                switch (Val)
                {
                    case 1:
                        {

                            VisaResultat(Add(firstNumber, secondNumber));


                            break;
                        }
                    case 2:
                        {
                            VisaResultat(Sub(firstNumber, secondNumber));
                            break;
                        }
                    case 3:
                        {
                            VisaResultat(Mult(firstNumber, secondNumber));
                            break;
                        }
                    case 4:
                        {

                            VisaResultat(Div(firstNumber, secondNumber));
                           
                            break;
                        }
                    case 5:
                        {
                            VisaResultat(Add(arrayList));
                            break;
                        }
                    case 6:
                        {
                            VisaResultat(Sub(arrayList));
                            break;
                        }
                    case 8:
                        {
                            Val = 8;
                            break;
                        }

                }

            }
        }
        public static double Add(double[] arrayList)
        {

            Result = 0;
            for (int i = 0; i < arrayList.Length; i++)
            {
                Console.WriteLine(" Element " + i + " = " + arrayList[i]);
            }

            // summera talen och skriv ut summan 
            int y = 0;
            for (int i = 0; i < arrayList.Length; i++)
            {
                Result = Result + arrayList[i];
                y = y + i;
            }
            for (int i = 0; i < arrayList.Length; i++)
            {
                arrayList[i] = 0;
                Console.WriteLine(arrayList[i]);
            }

          
            return Result;


        }
        public static double Sub(double[] arrayList)
        {
            Result = 0;
            for (int i = 0; i < arrayList.Length; i++)
            {
                Console.WriteLine(" Element " + i + " = " + arrayList[i]);
            }

            // summera talen och skriv ut summan 
            Result = arrayList[0];
            for (int i = 1; i < arrayList.Length; i++)
            {

                Result = Result - arrayList[i];

            }
            for (int i = 0; i < arrayList.Length; i++)
            {
                arrayList[i] = 0;
                Console.WriteLine(arrayList[i]);
            }

            //Console.WriteLine(" Summan av de " + testList.Count + " talen = " + Result);
            return Result;


        }



        public static void VisaResultat(double Resultat)
        {
            Console.WriteLine("Resultatet är " + Result);
        }

        public static double Add(double firstNumber, double secondNumber)
        {
            Result = firstNumber + secondNumber;
            return Result;

        }
        public static double Sub(double firstNumber, double secondNumber)
        {
            Result = firstNumber - secondNumber;
            return Result;

        }
        public static double Mult(double firstNumber, double secondNumber)
        {
            Result = firstNumber * secondNumber;
            return Result;

        }
        public static double Div(double firstNumber, double secondNumber)
        {
            
            if ( secondNumber == 0)
            {
                
                while ( secondNumber == 0)
                {
                   
                    Console.WriteLine("Du försöker dela med 0 som är ogiltligt, välj ett annat tal");
                   
                    secondNumber = getNumber();
                }
            }
            if( secondNumber!= 0)
            {
                Result = firstNumber / secondNumber;
            }
            
            return Result;
                       
            
            //Result = firstNumber / secondNumber;
            //return Result;
        }


            public static int Menu()
            {
                Console.WriteLine(" Gör ditt val i menu");
                Console.WriteLine("1: Add");
                Console.WriteLine("2: Sub");
                Console.WriteLine("3: Mult");
                Console.WriteLine("4: Div");
                Console.WriteLine("5: AddMulti");
                Console.WriteLine("6: SubMulti");
                Console.WriteLine("8: Exit");

                //int val;
                try
                {
                    int Val = int.Parse(Console.ReadLine());
                    return Val;
                }
                catch
                {
                    int Val = 0;
                    return Val;
                }


            }

            public static double getNumber()
            {
                try
                {
                    double number = double.Parse(Console.ReadLine());
                    return number;
                }
                catch
                {
                    Console.WriteLine("Error!! Ogiltlig inmatning");
                    return 0;
                }
            }
        }
    }



