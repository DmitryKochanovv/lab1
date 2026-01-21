using lab1;
using System;

namespace lab2
{
    class Program
    {
        //ПРОВЕРКИ ВВОДА ПОЛЬЗОВАТЕЛЯ

        //ЯВЛЯЕТСЯ ЛИ ЧИСЛОМ
        static int ReadInt(string message)
        {
            Console.Write(message);
            int value;

            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("ОШИБКА: введите целое число!");
                Console.Write(message);
            }

            return value;
        }

        //ЯВЛЯЕТСЯ ЛИ СИМВОЛОМ
        static char ReadChar(string message)
        {
            Console.Write(message);
            string s = Console.ReadLine();

            while (string.IsNullOrEmpty(s))
            {
                Console.WriteLine("ОШИБКА: введите хотя бы один символ!");
                Console.Write(message);
                s = Console.ReadLine();
            }

            return s[0];
        }

        //ПУСТАЯ СТРОКА
        static string ReadString(string message)
        {
            Console.Write(message);
            string s = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(s))
            {
                Console.WriteLine("ОШИБКА: строка не может быть пустой!");
                Console.Write(message);
                s = Console.ReadLine();
            }

            return s;
        }

        //ЭЛЕМЕНТЫ МАССИВА ЦЕЛЫЕ ЧИСЛА
        static int[] ReadIntArray(string message)
        {
            Console.Write(message);

            while (true)
            {
                string input = Console.ReadLine();
                string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                int[] arr = new int[parts.Length];
                bool ok = true;

                for (int i = 0; i < parts.Length; i++)
                {
                    if (!int.TryParse(parts[i], out arr[i]))
                    {
                        ok = false;
                        break;
                    }
                }

                if (ok)
                    return arr;

                Console.WriteLine("ОШИБКА: вводите только целые числа через пробел!");
                Console.Write(message);
            }
        }

        static void Main(string[] args)
        {
            Tasks t = new Tasks();

            while (true)
            {
                Console.WriteLine("\nВЫБЕРИТЕ МЕТОД ДЛЯ ПРОВЕРКИ:");
                Console.WriteLine("1. СУММА ДВУХ ПОСЛЕДНИХ РАЗРЯДОВ ЧИСЛА");
                Console.WriteLine("2. ЯВЛЯЕТСЯ ЛИ ЧИСЛО ПОЛОЖИТЕЛЬНЫМ");
                Console.WriteLine("3. ПРОВЕРКА НА ЗАГЛАВНУЮ ЛАТИНСУЮ БУКВУ:");
                Console.WriteLine("4. ДЕЛЕНИЕ НАЦЕЛО A/B");
                Console.WriteLine("5. СУММА ПОСЛЕДНИХ РАЗРЯДОВ 5 ЧИСЕЛ (цепочка)");
                Console.WriteLine("6. БЕЗОПАСНОЕ ДЕЛЕНИЕ");
                Console.WriteLine("7. СРАВНЕНИ > < =:");
                Console.WriteLine("8. suma (СУММА ДВУХ РАВНА ХОТЯ БЫ ОДНОМУ ЧИСЛУ ИЗ 3-ЁХ)");
                Console.WriteLine("9. ВОЗРАСТ:");
                Console.WriteLine("10. ЦЕПОЧКА ДНЕЙ В НЕДЕЛЕ, строчными буквами");
                Console.WriteLine("11. ВЫВЕСТИ ЦЕПОЧКУ ОТ X ДО 0:");
                Console.WriteLine("12. ВОЗВЕСТИ В СТЕПЕНЬ");
                Console.WriteLine("13. ВСЕ ЦИФРЫ ОДИНАКОВЫЕ");
                Console.WriteLine("14. ТРЕУГОЛЬНИК ЗВЁЗДОЧКИ");
                Console.WriteLine("15. ИНДЕКС ПОСЛЕДНЕГО ВХОЖДЕНИЯ ЧИСЛА");
                Console.WriteLine("16. ДОБАВИТЬ В МАССИВ:");
                Console.WriteLine("17. reverse МАССИВ");
                Console.WriteLine("18. СВЯЗАТЬ 2 МАССИВА");
                Console.WriteLine("19. УДАЛИТЬ ОТРИЦАТЕЛЬНЫЕ");
                Console.WriteLine("0. Выход");
                Console.Write("Выберите пункт: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        int s1 = ReadInt("ВВЕДИТЕ ЧИСЛО: ");
                        Console.WriteLine("РЕЗУЛЬТАТ МЕТОДА: " + Tasks.sumLastNums(s1));
                        break;

                    case "2":
                        int s2 = ReadInt("ВВЕДИТЕ ЧИСЛО: ");
                        Console.WriteLine("РЕЗУЛЬТАТ МЕТОДА: " + Tasks.isPositive(s2));
                        break;

                    case "3":
                        char c = ReadChar("ВВЕДИТЕ СИМВОЛ: ");
                        Console.WriteLine("РЕЗУЛЬТАТ МЕТОДА: " + t.isUpperCase(c));
                        break;

                    case "4":
                        int a = ReadInt("ВВЕДИТЕ a: ");
                        int b = ReadInt("ВВЕДИТЕ b: ");
                        Console.WriteLine("Результат: " + t.isDivisor(a, b));
                        break;

                    case "5":
                        Console.WriteLine("ВВЕДИТЕ 5 ЧИСЕЛ ПОСТРОЧНО:");
                        int r = ReadInt("");
                        for (int i = 0; i < 4; i++)
                        {
                            int next = ReadInt("");
                            r = t.lastNumSum(r, next);
                        }
                        Console.WriteLine("РЕЗУЛЬТАТ: " + r);
                        break;

                    case "6":
                        int d1 = ReadInt("ВВЕДИТЕ x: ");
                        int d2 = ReadInt("ВВЕДИТЕ y: ");
                        Console.WriteLine("РЕЗУЛЬТАТ: " + t.safeDiv(d1, d2));
                        break;

                    case "7":
                        int md1 = ReadInt("Введите x: ");
                        int md2 = ReadInt("Введите y: ");
                        Console.WriteLine("Результат: " + t.makeDecision(md1, md2));
                        break;

                    case "8":
                        int x1 = ReadInt("Введите x: ");
                        int y1 = ReadInt("Введите y: ");
                        int z1 = ReadInt("Введите z: ");
                        Console.WriteLine("Результат: " + t.suma(x1, y1, z1));
                        break;

                    case "9":
                        int age = ReadInt("Введите возраст: ");
                        Console.WriteLine("Результат: " + t.age(age));
                        break;

                    case "10":
                        string day = ReadString("Введите день недели: ");
                        t.printDays(day);
                        break;

                    case "11":
                        int rl = ReadInt("Введите число: ");
                        Console.WriteLine("Результат: " + t.reverseListNums(rl));
                        break;

                    case "12":
                        int px = ReadInt("Введите x: ");
                        int py = ReadInt("Введите y: ");
                        Console.WriteLine("Результат: " + t.pow(px, py));
                        break;

                    case "13":
                        int eq = ReadInt("Введите число: ");
                        Console.WriteLine("Результат: " + t.equalNum(eq));
                        break;

                    case "14":
                        int h = ReadInt("Введите высоту: ");
                        t.leftTriangle(h);
                        break;

                    case "15":
                        int[] arr1 = ReadIntArray("Введите массив: ");
                        int fx = ReadInt("Введите x: ");
                        Console.WriteLine("Результат: " + t.findLast(arr1, fx));
                        break;

                    case "16":
                        int[] arr2 = ReadIntArray("Введите массив: ");
                        int ax = ReadInt("Введите x: ");
                        int pos = ReadInt("Введите позицию: ");
                        int[] added = t.add(arr2, ax, pos);
                        Console.WriteLine("Результат: " + string.Join(" ", added));
                        break;

                    case "17":
                        int[] arr3 = ReadIntArray("Введите массив: ");
                        t.reverse(arr3);
                        Console.WriteLine("Результат: " + string.Join(" ", arr3));
                        break;

                    case "18":
                        int[] c1 = ReadIntArray("Введите массив 1: ");
                        int[] c2 = ReadIntArray("Введите массив 2: ");
                        int[] cc = t.concat(c1, c2);
                        Console.WriteLine("Результат: " + string.Join(" ", cc));
                        break;

                    case "19":
                        int[] dn = ReadIntArray("Введите массив: ");
                        int[] dn2 = t.deleteNegative(dn);
                        Console.WriteLine("Результат: " + string.Join(" ", dn2));
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Нет такого пункта");
                        break;
                }
            }
        }
    }
}
