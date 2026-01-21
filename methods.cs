using System;
using System.Collections.Generic;
using System.Text;



namespace lab1
{


    //В ЭТОМ КЛАССЕ РЕАЛИЗОВАНЫ ВСЕ МЕТОДЫ ПОД ЧЁТНОЙ НУМЕРАЦИЕЙ


    class Tasks
    {
        //СУММА 2 ПОСЛЕДНИХ РАЗРЯДОВ ЧИСЛА
        public static int sumLastNums(int x)
        {
            int last = x % 10;
            int prev = (x / 10) % 10;
            return last + prev;
        }


        //ЯВЛЯЕТСЯ ЛИ ЧИСЛО ПОЛОЖИТЕЛЬНЫМ 

        public static bool isPositive(int x)
        {
            return x > 0;
        }

        //СИМВОЛ - ЗАГЛАВНАЯ БУКВА ОТ A ДО Z

        public bool isUpperCase(char x)
        {
            return x >= 'A' && x <= 'Z';
        }


        //ЧИСЛО ДЕЛИТ ДРУГОЕ НАЦЕЛО

        public bool isDivisor(int a, int b)
        {
            if (a == 0 || b == 0) return false;
            return (b % a == 0) || (a % b == 0);
        }


        //СУММА ПОСЛЕДНИХ РАЗРЯДОВ ДВУХ ЧИСЕЛ 

        public int lastNumSum(int a, int b)
        {
            return (a % 10) + (b % 10);
        }






        //БЛОК 2 if switch

        //БЕЗОПАСНОЕ ДЕЛЕНИЕ,ЕСЛИ ЗНАМЕНАТЕЛЬ 0

        public double safeDiv(int x, int y)
        {
            if (y == 0)
                return 0;

            return (double)x / y;
        }


        //СРАВНЕНИЕ 

        public string makeDecision(int x, int y)
        {
            if (x > y)
                return x + ">" + y;
            else if (x == y)
                return x + "==" + y;
            else
                return x + "<" + y;
        }


        //СУММА 2 ЧИСЕЛ РАВНА ХОТЯ БЫ  ОДНОМУ


        public bool suma(int x, int y, int z)
        {
            if (x + y == z) return true;
            if (x + z == y) return true;
            if (y + z == x) return true;
            return false;

        }



        //возраст годы

        public string age(int x)
        {
            int last = x % 10;
            if (last < 0)
                last = -last;

            int last2 = x % 100;
            if (last2 < 0)
                last2 = -last2;

            if (last == 1 && last2 != 11)
                return x + "ГОД";

            if ((last == 2 || last == 3 || last == 4) && !(last2 == 12 || last2 == 13 || last2 == 14))
                return x + " ГОДА";

            return x + " ЛЕТ";

        }


        //ДНИ НЕДЕЛИ

        public void printDays(string x)
        {
            switch (x)
            {
                case "понедельник":
                    Console.WriteLine("понедельник");
                    goto case "вторник";

                case "вторник":
                    Console.WriteLine("вторник");
                    goto case "среда";

                case "среда":
                    Console.WriteLine("среда");
                    goto case "четверг";

                case "четверг":
                    Console.WriteLine("четверг");
                    goto case "пятница";

                case "пятница":
                    Console.WriteLine("пятница");
                    goto case "суббота";

                case "суббота":
                    Console.WriteLine("суббота");
                    goto case "воскресенье";

                case "воскресенье":
                    Console.WriteLine("воскресенье");
                    break;

                default:
                    Console.WriteLine("ввели не день недели");
                    break;

            }
        }


        //БЛОК 3 ЦИКЛЫ

        //ЧИСЛА ОТ X ДО 0 ОБРАТНЫЙ ВЫВОД

        public string reverseListNums(int x)
        {
            string result = "";

            for (int i = x; i >= 0; i--)
            {
                result += i;
                if (i != 0)
                    result += " ";
            }
            return result;
        }


        //x в степень Y 

        public int pow(int x, int y)
        {
            int result = 1;

            for (int i = 0; i < y; i++)
            {
                result *= x;
            }
            return result;
        }

        //ОДИНАКОВЫЕ ЦИФРЫ

        public bool equalNum(int x)
        {
            x = x < 0 ? -x : x;

            int last = x % 10;
            while (x > 0)
            {
                if (x % 10 != last)
                    return false;
                x /= 10;
            }

            return true;
        }

        //треугольник из *

        public void leftTriangle(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }


        //УГАДАЙКА

        //БЛОК 4 ПОИСК ПОСЛЕДНЕГО ВХОЖДЕНИЯ

        public int findLast(int[] arr, int x)
        {
            int index = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                    index = i;
            }

            return index;
        }


        //ВСТАВКА ЭЛЕМЕНТА В МАССИВ

        public int[] add(int[] arr, int x, int pos)
        {
            int[] result = new int[arr.Length + 1];

            for (int i = 0; i < pos; i++)
                result[i] = arr[i];
            result[pos] = x;

            for (int i = pos; i < arr.Length; i++)
                result[i + 1] = arr[i];
            return result;
        }

        //ПЕРЕВЕРНУТЬ МАССИВ

        public void reverse(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
            }
        }

        //объединить 2 массива

        public int[] concat(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];

            for (int i = 0; i < arr1.Length; i++)
                result[i] = arr1[i];

            for (int i = 0; i < arr2.Length; i++)
                result[arr1.Length + i] = arr2[i];
            return result;
        }

        //удалить отрицательные элементы

        public int[] deleteNegative(int[] arr)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                    count++;
            }

            int[] result = new int[count];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    result[index] = arr[i];
                    index++;
                }
            }
            return result;
        }


    }
}








