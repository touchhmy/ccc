using System;
using three;

namespace three
{
   public class DA
    {
        double[] arr;
        public DA(int size)
        {
            arr = new double[size];
        }

        public double this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }
    }
}

class Program

{

    static void Main(string[] args)
    {
        DA doubleArray = new DA(10);

        for (int i = 0; i < 10; i++)
        {
            doubleArray[i] = i * 1.5;
        }
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Элемент массива {i}: {doubleArray[i]}");
        }

    }

    
}

