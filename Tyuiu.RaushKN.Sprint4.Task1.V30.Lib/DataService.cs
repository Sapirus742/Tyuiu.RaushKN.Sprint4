﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.RaushKN.Sprint4.Task1.V30.Lib
{
    public class DataService : ISprint4Task1V30
    {
        public int Calculate(int[] array)
        {
            int calc = 1;

            for (int i = 0;i < array.Length;i++)
            {
                if (array[i] % 2 == 0) calc *= array[i];
            }

            return calc;
        }
    }
}
