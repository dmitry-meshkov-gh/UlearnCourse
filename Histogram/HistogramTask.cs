﻿using System;
using System.Linq;

namespace Names
{
    internal static class HistogramTask
    {
        public static HistogramData GetBirthsPerDayHistogram(NameData[] names, string name)
        {
            string[] days = new string[31];
            for(int i = 0; i < days.Length; i++)
                days[i] = (i + 1).ToString();                

            double[] birthCounts = new double[days.Length];
            foreach(var item in names)
            {
                if(item.Name.Equals(name) && item.BirthDate.Day != 1)
                    birthCounts[item.BirthDate.Day - 1]++;
            }

            return new HistogramData(
                string.Format("Рождаемость людей с именем '{0}'", name), 
                days, 
                birthCounts);
        }
    }
}