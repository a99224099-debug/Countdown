using System;

namespace Countdown;
    public static class Countdown
    {
        public static int Remaining_Time = 10;
        public static void Start()
        {
            while (Remaining_Time > 0)
            {
                Console.Clear();
                Console.WriteLine(Remaining_Time + "s left");
                Remaining_Time--;
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("END");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Countdown.Start();
        }
    }

