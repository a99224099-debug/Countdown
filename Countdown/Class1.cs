using System;
using System.Timers;

namespace Countdown;
    public static class Countdown
    {
        public static void Start(int initial_time)
        {
            int Remaining_Time = initial_time;
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
        if (int.TryParse(Console.ReadLine(), out int initial_time))
        {
            Countdown.Start(initial_time);
        }
        else
        {
            Console.WriteLine("숫자를 입력해 주세요.");
        }
        }
    }

