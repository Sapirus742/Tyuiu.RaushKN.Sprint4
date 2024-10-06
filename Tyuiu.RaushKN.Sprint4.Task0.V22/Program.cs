using Tyuiu.RaushKN.Sprint4.Task0.V22.Lib;

namespace Tyuiu.RaushKN.Sprint4.Task0.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Рауш К. Н. | АСОиУб-24-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# Спринт #4                                                               #");
            Console.WriteLine("# Тема: Одномерные массивы (статический ввод)                             #");
            Console.WriteLine("# Задание #0                                                              #");
            Console.WriteLine("# Вариант #22                                                             #");
            Console.WriteLine("# Выполнил Рауш Кирилл Николавевич | АСОиУб-24-1                          #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# УСЛОВИЕ:                                                                #");
            Console.WriteLine("# Дан одномерный целочисленный массив на 10 элементов заполненный         #");
            Console.WriteLine("# статическими значениями в диапазоне от 0 до 9 подсчитать сумму нечетных #");
            Console.WriteLine("# элементов массива. {9, 5, 7, 4, 5, 3, 7, 8, 9, 1}                       #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# ИСХОДНЫЕ ДАННЫЕ:                                                        #");
            Console.WriteLine("###########################################################################");

            int[] array = new int[] { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();


            Console.WriteLine("###########################################################################");
            Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
            Console.WriteLine("###########################################################################");
            
            int res = ds.GetSumOddArrEl(array);
            Console.WriteLine("Сумма нечетных элементов массива: "+ res);
            
        }
    }
}
