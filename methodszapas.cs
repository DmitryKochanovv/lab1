/*  
 
 using System;

namespace lab2
{
    class Tasks
    {
        // ====== ВСЕ МЕТОДЫ ЗАДАЧ ======

        public static int sumLastNums(int x)
        {
            int last = x % 10;
            int prev = (x / 10) % 10;
            return last + prev;
        }

        public static bool isPositive(int x)
        {
            return x > 0;
        }

        public bool isUpperCase(char x)
        {
            return x >= 'A' && x <= 'Z';
        }

        public bool isDivisor(int a, int b)
        {
            if (a == 0 || b == 0) return false;
            return (b % a == 0) || (a % b == 0);
        }

        public int lastNumSum(int a, int b)
        {
            return (a % 10) + (b % 10);
        }

        public double safeDiv(int x, int y)
        {
            if (y == 0) return 0;
            return (double)x / y;
        }

        public string makeDecision(int x, int y)
        {
            if (x > y) return x + ">" + y;
            if (x == y) return x + "==" + y;
            return x + "<" + y;
        }

        public bool suma(int x, int y, int z)
        {
            return (x + y == z) || (x + z == y) || (y + z == x);
        }

        public string age(int x)
        {
            int last = Math.Abs(x % 10);
            int last2 = Math.Abs(x % 100);

            if (last == 1 && last2 != 11) return x + " ГОД";
            if ((last == 2 || last == 3 || last == 4) && !(last2 == 12 || last2 == 13 || last2 == 14))
                return x + " ГОДА";
            return x + " ЛЕТ";
        }

        public void printDays(string x)
        {
            switch (x)
            {
                case "понедельник": Console.WriteLine("понедельник"); goto case "вторник";
                case "вторник": Console.WriteLine("вторник"); goto case "среда";
                case "среда": Console.WriteLine("среда"); goto case "четверг";
                case "четверг": Console.WriteLine("четверг"); goto case "пятница";
                case "пятница": Console.WriteLine("пятница"); goto case "суббота";
                case "суббота": Console.WriteLine("суббота"); goto case "воскресенье";
                case "воскресенье": Console.WriteLine("воскресенье"); break;
                default: Console.WriteLine("ввели не день недели"); break;
            }
        }

        public string reverseListNums(int x)
        {
            string result = "";
            for (int i = x; i >= 0; i--)
            {
                result += i;
                if (i != 0) result += " ";
            }
            return result;
        }

        public int pow(int x, int y)
        {
            int result = 1;
            for (int i = 0; i < y; i++) result *= x;
            return result;
        }

        public bool equalNum(int x)
        {
            x = Math.Abs(x);
            int last = x % 10;
            while (x > 0)
            {
                if (x % 10 != last) return false;
                x /= 10;
            }
            return true;
        }

        public void leftTriangle(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                for (int j = 0; j < i; j++) Console.Write("*");
                Console.WriteLine();
            }
        }

        public int findLast(int[] arr, int x)
        {
            int index = -1;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == x) index = i;
            return index;
        }

        public int[] add(int[] arr, int x, int pos)
        {
            int[] result = new int[arr.Length + 1];
            for (int i = 0; i < pos; i++) result[i] = arr[i];
            result[pos] = x;
            for (int i = pos; i < arr.Length; i++) result[i + 1] = arr[i];
            return result;
        }

        public void reverse(int[] arr)
        {
            int left = 0, right = arr.Length - 1;
            while (left < right)
            {
                int tmp = arr[left];
                arr[left] = arr[right];
                arr[right] = tmp;
                left++; right--;
            }
        }

        public int[] concat(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];
            for (int i = 0; i < arr1.Length; i++) result[i] = arr1[i];
            for (int i = 0; i < arr2.Length; i++) result[arr1.Length + i] = arr2[i];
            return result;
        }

        public int[] deleteNegative(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] >= 0) count++;

            int[] result = new int[count];
            int idx = 0;

            for (int i = 0; i < arr.Length; i++)
                if (arr[i] >= 0) result[idx++] = arr[i];

            return result;
        }

        // ====== PRIVATE ПРОВЕРКИ ВВОДА ======

        private int ReadInt(string msg)
        {
            Console.Write(msg);
            int v;
            while (!int.TryParse(Console.ReadLine(), out v))
            {
                Console.WriteLine("Ошибка! Введите целое число.");
                Console.Write(msg);
            }
            return v;
        }

        private char ReadChar(string msg)
        {
            Console.Write(msg);
            string s = Console.ReadLine();
            while (string.IsNullOrEmpty(s))
            {
                Console.WriteLine("Ошибка! Введите символ.");
                Console.Write(msg);
                s = Console.ReadLine();
            }
            return s[0];
        }

        private string ReadString(string msg)
        {
            Console.Write(msg);
            string s = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(s))
            {
                Console.WriteLine("Ошибка! Введите строку.");
                Console.Write(msg);
                s = Console.ReadLine();
            }
            return s;
        }

        private int[] ReadIntArray(string msg)
        {
            Console.Write(msg);
            while (true)
            {
                string input = Console.ReadLine();
                string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                int[] arr = new int[parts.Length];
                bool ok = true;

                for (int i = 0; i < parts.Length; i++)
                    if (!int.TryParse(parts[i], out arr[i])) ok = false;

                if (ok) return arr;

                Console.WriteLine("Ошибка! Введите числа через пробел.");
                Console.Write(msg);
            }
        }

        // ====== PUBLIC RUN-МЕТОДЫ ======

        public void RunSumLastNums()
        {
            int x = ReadInt("Введите число: ");
            Console.WriteLine(sumLastNums(x));
        }

        public void RunIsPositive()
        {
            int x = ReadInt("Введите число: ");
            Console.WriteLine(isPositive(x));
        }

        public void RunIsUpperCase()
        {
            char c = ReadChar("Введите символ: ");
            Console.WriteLine(isUpperCase(c));
        }

        public void RunIsDivisor()
        {
            int a = ReadInt("Введите a: ");
            int b = ReadInt("Введите b: ");
            Console.WriteLine(isDivisor(a, b));
        }

        public void RunLastNumSumChain()
        {
            Console.WriteLine("Введите 5 чисел:");
            int r = ReadInt("");
            for (int i = 0; i < 4; i++)
                r = lastNumSum(r, ReadInt(""));
            Console.WriteLine(r);
        }

        public void RunSafeDiv()
        {
            int x = ReadInt("Введите x: ");
            int y = ReadInt("Введите y: ");
            Console.WriteLine(safeDiv(x, y));
        }

        public void RunMakeDecision()
        {
            int x = ReadInt("Введите x: ");
            int y = ReadInt("Введите y: ");
            Console.WriteLine(makeDecision(x, y));
        }

        public void RunSuma()
        {
            int x = ReadInt("Введите x: ");
            int y = ReadInt("Введите y: ");
            int z = ReadInt("Введите z: ");
            Console.WriteLine(suma(x, y, z));
        }

        public void RunAge()
        {
            int x = ReadInt("Введите возраст: ");
            Console.WriteLine(age(x));
        }

        public void RunPrintDays()
        {
            string s = ReadString("Введите день недели: ");
            printDays(s);
        }

        public void RunReverseListNums()
        {
            int x = ReadInt("Введите число: ");
            Console.WriteLine(reverseListNums(x));
        }

        public void RunPow()
        {
            int x = ReadInt("Введите x: ");
            int y = ReadInt("Введите y: ");
            Console.WriteLine(pow(x, y));
        }

        public void RunEqualNum()
        {
            int x = ReadInt("Введите число: ");
            Console.WriteLine(equalNum(x));
        }

        public void RunLeftTriangle()
        {
            int x = ReadInt("Введите высоту: ");
            leftTriangle(x);
        }

        public void RunFindLast()
        {
            int[] arr = ReadIntArray("Введите массив: ");
            int x = ReadInt("Введите x: ");
            Console.WriteLine(findLast(arr, x));
        }

        public void RunAdd()
        {
            int[] arr = ReadIntArray("Введите массив: ");
            int x = ReadInt("Введите x: ");
            int pos = ReadInt("Введите позицию: ");
            Console.WriteLine(string.Join(" ", add(arr, x, pos)));
        }

        public void RunReverse()
        {
            int[] arr = ReadIntArray("Введите массив: ");
            reverse(arr);
            Console.WriteLine(string.Join(" ", arr));
        }

        public void RunConcat()
        {
            int[] a1 = ReadIntArray("Введите массив 1: ");
            int[] a2 = ReadIntArray("Введите массив 2: ");
            Console.WriteLine(string.Join(" ", concat(a1, a2)));
        }

        public void RunDeleteNegative()
        {
            int[] arr = ReadIntArray("Введите массив: ");
            Console.WriteLine(string.Join(" ", deleteNegative(arr)));
        }
    }
}

 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 */