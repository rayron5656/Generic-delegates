using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Delegates_HW
{

    public delegate string FirstDelegate<T1,T2,T3>(T1 t1,T2 t2,T3 t3);

    public delegate void FirstDelegateVoid<T1, T2, T3>(T1 t1, T2 t2, T3 t3);

    public delegate string D_OneTReturnString<T1>(T1 t1);

    public delegate int D_oneTreturnInt<T1>(T1 t1);

    public delegate void D_Simple<T1>(T1 t1);

    public delegate void D_SimplePlus<T1, T2>(T1 t1, T2 t2);

    public delegate void Simple();




    class Program
    {
        static void Main(string[] args)
        {
            FirstDelegate<int, int, int> smallestInt = (a, b, c) =>
              {
                  if (a < b)
                  {
                      if (a < c)
                      {
                          return $"The smallest value is {a}";
                      }
                      else
                      {
                          return $"The smallest value is {c}";
                      }
                  }
                  else if (b < c)
                  {
                      return $"The smallest value is {b}";
                  }
                  else
                  {
                      return $"The smallest value is {c}";
                  }
              };

            Console.WriteLine(smallestInt(25, 35, 29));

            FirstDelegate<int, int, int> AverageDlgt = (a, b, c) =>
              {
                  int x = a;
                  x += b;
                  x += c;

                  return $"The average value is {x / 3}";
              };

            Console.WriteLine(AverageDlgt(25, 45, 65));

            D_OneTReturnString<string> MiddleChar = (S) =>
            {
                if (S.Length > 0)
                {
                    if (S.Length % 2 == 0)
                    {
                        string x = S[(S.Length / 2) - 1].ToString();
                        x += S[(S.Length / 2)].ToString();
                        return x;
                    }
                    else
                    {

                        return S[(S.Length / 2)].ToString();

                    }
                }
                else
                {
                    return " ";
                }
            };

            Console.WriteLine(MiddleChar("350"));
            Console.WriteLine(MiddleChar("middlton"));

            D_oneTreturnInt<string> GetVowels = (S) =>

            {
                int x = 0;
                string s = S.ToLower();
                foreach (char Ch in s)
                {
                    if (Ch == 'i' || Ch == 'o' || Ch == 'u' || Ch == 'e' || Ch == 'a')
                    {
                        x++;
                    }
                }
                return x;
            };

            Console.WriteLine($"Number of  Vowels in the string: {GetVowels("w3resource")} ");

            D_oneTreturnInt<string> GetNumOfWords = (S) =>
            {
                int x = 1;
                foreach (char Ch in S)
                {
                    if (Ch != ' ')
                    {

                    }
                    else
                    {
                        x++;
                    }
                }

                return x;


            };

            Console.WriteLine($"Number of words in the string: {GetNumOfWords("The quick brown fox jumps over the lazy dog.")}");

            Console.WriteLine($"Number of words in the string: {GetNumOfWords("Ron")}");

            D_oneTreturnInt<int> SumOfDidgits = (I) =>
            {
                string s = I.ToString();
                int x = 0;
                foreach (char Ch in s)
                {
                    x += int.Parse(Ch.ToString());
                }

                return x;
            };

            Console.WriteLine(SumOfDidgits(25));

            Console.WriteLine(SumOfDidgits(572985715));

            D_Simple<int> Pentagonal_number = (I) =>
            {
                int x = 0;

                for (int i = 1; i <= I; i++)
                {
                    string s = ((3 * (Math.Pow(i, 2)) - i) / 2).ToString();
                    if (s.Length < 2)
                    {
                        Console.Write(s.ToString() + "   ");
                    }
                    else if (s.ToString().Length < 3)
                    {
                        Console.Write(s.ToString() + "  ");
                    }
                    else if (s.ToString().Length < 4)
                    {
                        Console.Write(s.ToString() + " ");

                    }
                    else
                    {
                        Console.Write(s.ToString());
                    }

                    Console.Write(" ");
                    x++;
                    if (x % 10 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            };

            Pentagonal_number(50);

            FirstDelegateVoid<double, double, double> Invest = (amount, rate, years) =>
              {

              }; // need to finish

            Invest(1000, 10, 5);

            D_SimplePlus<char, char> PrintInbetweenCh = (a, b) =>
             {
                 for (int i = a, j = b, k = 1; i < j + 1; i++, k++)
                 {
                     Console.Write(((char)(a + k - 1)) + " ");
                     if (k % 20 == 0 && k != 0)
                     {
                         Console.WriteLine();
                     }
                 }
             };

            PrintInbetweenCh('(', 'z');

            Console.WriteLine();

            D_Simple<int> LeapYear = (I) =>
            {
                Console.WriteLine($"Input Year : {I}");
                if (I % 4 == 0)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("False");
                }

            };


            LeapYear(2017);

            D_Simple<int> NbyNMetrix = (I) =>
            {
                Random R = new Random();

                for (int i = 0; i < I; i++)
                {
                    for (int j = 0; j < I; j++)
                    {
                        Console.Write((R.Next(0,2).ToString() + " "));
                    }
                    Console.WriteLine();
                }


            };

            NbyNMetrix(10);

            FirstDelegateVoid<double, double, double> TriangleArea = (side1, side2, side3) =>
              {
                  double s = (side1 + side2 + side3) / 2;
                  double S = Math.Sqrt((s * (s - side1)*(s - side2)*(s - side3)));
                  Console.WriteLine($"the area of the triangle is: {S}");
              };

            TriangleArea(10, 15, 20);

            D_SimplePlus<int, double> PentagonAndMore = (NumOfSides,sideLength) =>
             {
                 double T = sideLength;
                 double N = NumOfSides;
                 
                 double S = 0.25 * N * Math.Pow(T,2) * (1/(Math.Tan((Math.PI/N))));

                 Console.WriteLine($"The area is: {S}");
                 

             }; // I made this function to be able to cal all regular polygons

            PentagonAndMore(5,6);

            Simple TodayDatetime = () =>
            {
                Console.WriteLine(DateTime.Now);
            }; // didnt even need generics

            TodayDatetime();

            
        }
    }
}
