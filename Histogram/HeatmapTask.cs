using System;

namespace Names
{
    internal static class HeatmapTask
    {
        public static HeatmapData GetBirthsPerDateHeatmap(NameData[] names)
        {
            string[] days = new string[30];
            for(int i = 0; i < days.Length; i++)
                days[i] = (i + 2).ToString();

            string[] months = new string[12];
            for(int i = 0; i < months.Length;  i++)
                months[i] = (i + 1).ToString();

            double[,] date = new double[days.Length, months.Length];
            foreach(var item in names)
            {
                if(item.BirthDate.Day != 1)
                    date[item.BirthDate.Day - 2, item.BirthDate.Month - 1]++;
            }
                

            return new HeatmapData("Тепловая карта рождаемости в зависимости от дня и месяца", 
                date, days, months);

        }
    }
}