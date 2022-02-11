using System;
using static System.Console;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nails, hits;
            bool nails_bool, hits_bool;
            WriteLine("Welcome to the nailing workshop!");
            Input:
            do
            {
                WriteLine("Please, enter the number of nails: ");
                nails_bool = Int32.TryParse(ReadLine(), out nails);
                WriteLine("Please, enter the number of hits: ");
                hits_bool = Int32.TryParse(ReadLine(), out hits);
                if (!(nails_bool && hits_bool))
                    WriteLine("I'm sorry, but you must enter a NUMBER !");
            }
            while (!(nails_bool && hits_bool));

            try
            {
                if ((!Enumerable.Range(1, 10).Contains(nails)) || (!Enumerable.Range(1, 5).Contains(hits)))
                        throw new ArgumentException("The number of nails should be from 1 to 10, and the number of hits from 1 to 5!");

                for (int i = 1; i <= nails; i++)
                {
                    NailCount(i);
                    for (int j = 1; j <= hits; j++)
                    {
                        HitCount(j);
                    }
                    WriteLine("We hammered this nail!");
                    
                }
                WriteLine("We've hammered in all the nails! Great job!");

                WriteLine();

                WriteLine("If you want to continue, please enter \"yes\"");
                string answer = ReadLine();
                if (answer.ToLower() == "yes" & answer != null)
                    goto Input;
                else 
                    WriteLine("See you soon!");
            }
            catch (ArgumentException e)
            {
                WriteLine(e.Message);
                goto Input;
            }
            void NailCount(int x)
            {
                switch (x)
                {
                    case 1:
                        WriteLine($"We took the {x}st nail!");
                        break;
                    case 2:
                        WriteLine($"We took the {x}nd nail!");
                        break;
                    case 3:
                        WriteLine($"We took the {x}rd nail!");
                        break;
                    default:
                        WriteLine($"We took the {x}th nail!");
                        break;
                }
            }
            void HitCount(int x)
            {
                switch (x)
                {
                    case 1:
                        WriteLine($"We take the {x}st hit!");
                        break;
                    case 2:
                        WriteLine($"We take the {x}nd hit!");
                        break;
                    case 3:
                        WriteLine($"We take the {x}rd hit!");
                        break;
                    default:
                        WriteLine($"We take the {x}th hit!");
                        break;
                }
            }
        }
    }
}