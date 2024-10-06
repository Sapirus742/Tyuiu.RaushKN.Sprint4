using Tyuiu.RaushKN.Sprint4.Task1.V30.Lib;

namespace Tyuiu.RaushKN.Sprint4.Task1.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Рауш К. Н. | АСОиУб-24-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# Спринт #4                                                               #");
            Console.WriteLine("# Тема: Одномерные массивы. (ввод с клавиатуры)                           #");
            Console.WriteLine("# Задание #1                                                              #");
            Console.WriteLine("# Вариант #30                                                             #");
            Console.WriteLine("# Выполнил Рауш Кирилл Николавевич | АСОиУб-24-1                          #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# УСЛОВИЕ:                                                                #");
            Console.WriteLine("# Дан одномерный целочисленный массив на 15 элементов заполненный         #");
            Console.WriteLine("# значениями с клавиатуры в диапазоне от 5 до 9 подсчитать произведение   #");
            Console.WriteLine("# четных элементов массива. С клавиатуры: 6, 7, 8, 7, 6, 5, 6, 9, 9, 5,   #");
            Console.WriteLine("# 7, 9, 7, 8, 7                                                           #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# ИСХОДНЫЕ ДАННЫЕ:                                                        #");
            Console.WriteLine("###########################################################################");

            int[] array = new int[15];

            Console.WriteLine("Введеите элементы (15) массива через Enter: ");
            for (int i = 0; i < array.Length; i++)
            { 
                int x = Convert.ToInt32(Console.ReadLine());
                array [i] = x;
            }
            int res = ds.Calculate(array);

            Console.WriteLine("###########################################################################");
            Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
            Console.WriteLine("###########################################################################");
        
            Console.WriteLine("Призведение четных элементов массива = "+ res);
            Console.ReadKey();
        }
    }
}
