﻿using System;

namespace TemperatureTrackerApplication
{
    class TemperatureTracker
    {
        private double[] weeklyTemperatures;

        public TemperatureTracker()
        {

            weeklyTemperatures = new double[7];
        }

        public void InputTemperatures()
        {
            Console.WriteLine("Enter the temperatures for the week:");

            for (int i = 0; i < weeklyTemperatures.Length; i++)
            {
                Console.Write($"Day {i + 1}: ");
                string input = Console.ReadLine();
                if (double.TryParse(input, out double temperature))
                {
                    weeklyTemperatures[i] = temperature;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid temperature.");
                    i--;
                }
            }
        }

        public void DisplayWeeklyTemperatureReport()
        {
            Console.WriteLine("Weekly Temperature Report:");
            for (int i = 0; i < weeklyTemperatures.Length; i++)
            {
                Console.WriteLine($"Day {i + 1}: {weeklyTemperatures[i]}°C");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            TemperatureTracker tracker = new TemperatureTracker();


            tracker.InputTemperatures();


            tracker.DisplayWeeklyTemperatureReport();


            Console.ReadLine();
        }
    }
}
