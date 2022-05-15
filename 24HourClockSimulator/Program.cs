using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _24HourClockSimulator
{
    public class Program
    {
        private static int clockInt;
        private static string clockString;

        /// <summary>
        /// The Main purpose of this program is to Simulator code running only in a timeframe of 24H.
        /// In this case i made this program to test out hibernate method on a Raspberry pi which will save power at night.
        /// 
        /// The program will start from midnight (00:00) and continue to plus its value with 1 each second,
        /// and reset if the value is bigger than 24. 
        /// </summary>
        /// <param name="args">string[]</param>
        static void Main(string[] args)
        {
            while (true)
            {
                Thread.Sleep(1000);
                count();

                doTask();
            }
        }

        /// <summary>
        /// This method will count up and also make sure the value isn't over 24.
        /// </summary>
        private static void count()
        {
            clockString = String.Format("{00:00}", clockInt);

            clockInt++;

            if (clockInt > 24)
                clockInt = 0;
        }

        /// <summary>
        /// This is where your code would go as this will be ran every clock change.
        /// </summary>
        public static void doTask()
        {

            Console.WriteLine(clockString);

        }
    }
}
