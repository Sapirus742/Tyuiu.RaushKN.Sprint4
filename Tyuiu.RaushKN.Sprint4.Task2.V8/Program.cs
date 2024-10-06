using Tyuiu.RaushKN.Sprint4.Task2.V8.Lib;

namespace Tyuiu.RaushKN.Sprint4.Task2.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();

            Console.Title = "Спринт #4 | Выполнил: Рауш К. Н. | АСОиУб-24-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# Спринт #4                                                               #");
            Console.WriteLine("# Тема: Одномерные массивы. (генератор случайных чисел)                   #");
            Console.WriteLine("# Задание #2                                                              #");
            Console.WriteLine("# Вариант #8                                                              #");
            Console.WriteLine("# Выполнил Рауш Кирилл Николавевич | АСОиУб-24-1                          #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# УСЛОВИЕ:                                                                #");
            Console.WriteLine("# Дан одномерный целочисленный массив на 11 элементов заполненный         #");
            Console.WriteLine("# случайными в диапазоне от 2 до 7 подсчитать сумму нечетных элементов    #");
            Console.WriteLine("# массива.                                                                #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# ИСХОДНЫЕ ДАННЫЕ:                                                        #");
            Console.WriteLine("###########################################################################");

            int[] array = new int[11];
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(2,8);
                Console.Write(array[i]);
            }
            Console.WriteLine();
            int res = ds.Calculate(array);

            Console.WriteLine("###########################################################################");
            Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
            Console.WriteLine("###########################################################################");
        
            Console.WriteLine("Сумма нечетных элементов массива = " + res);
            Console.ReadKey();
        }
    }
}
