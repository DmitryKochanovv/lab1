/* 
 
 using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Tasks t = new Tasks();

            while (true)
            {
                Console.WriteLine("\nВЫБЕРИТЕ МЕТОД:");
                Console.WriteLine("1. sumLastNums");
                Console.WriteLine("2. isPositive");
                Console.WriteLine("3. isUpperCase");
                Console.WriteLine("4. isDivisor");
                Console.WriteLine("5. lastNumSum chain");
                Console.WriteLine("6. safeDiv");
                Console.WriteLine("7. makeDecision");
                Console.WriteLine("8. suma");
                Console.WriteLine("9. age");
                Console.WriteLine("10. printDays");
                Console.WriteLine("11. reverseListNums");
                Console.WriteLine("12. pow");
                Console.WriteLine("13. equalNum");
                Console.WriteLine("14. leftTriangle");
                Console.WriteLine("15. findLast");
                Console.WriteLine("16. add");
                Console.WriteLine("17. reverse");
                Console.WriteLine("18. concat");
                Console.WriteLine("19. deleteNegative");
                Console.WriteLine("0. Выход");

                Console.Write("Ваш выбор: ");
                string c = Console.ReadLine();

                switch (c)
                {
                    case "1": t.RunSumLastNums(); break;
                    case "2": t.RunIsPositive(); break;
                    case "3": t.RunIsUpperCase(); break;
                    case "4": t.RunIsDivisor(); break;
                    case "5": t.RunLastNumSumChain(); break;
                    case "6": t.RunSafeDiv(); break;
                    case "7": t.RunMakeDecision(); break;
                    case "8": t.RunSuma(); break;
                    case "9": t.RunAge(); break;
                    case "10": t.RunPrintDays(); break;
                    case "11": t.RunReverseListNums(); break;
                    case "12": t.RunPow(); break;
                    case "13": t.RunEqualNum(); break;
                    case "14": t.RunLeftTriangle(); break;
                    case "15": t.RunFindLast(); break;
                    case "16": t.RunAdd(); break;
                    case "17": t.RunReverse(); break;
                    case "18": t.RunConcat(); break;
                    case "19": t.RunDeleteNegative(); break;
                    case "0": return;
                    default: Console.WriteLine("Нет такого пункта"); break;
                }
            }
        }
    }
}

 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 */