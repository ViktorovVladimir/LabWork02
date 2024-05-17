using System;


namespace ConsoleAppStructDistance
{
    public struct Distance
    {
        public uint foot;               //отрицательным быть не может
        public uint inch;               //отрицательным быть не может
    }

    public class Program
    {
        public static void Main()
        {
            Distance d1;
            
            //--.
            d1.foot = 15;
            d1.inch = 8;

            //--.            
            Console.WriteLine($"Итого получилось: {d1.foot}'- {d1.inch}\" ") ;
        }
    }
}