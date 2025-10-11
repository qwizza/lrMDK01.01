using System.Collections.Generic;
using System.Security;

namespace LAB2Variant6
{
    public class AnalysisDataModule
    {
        // сортируем блюда по популярности 
        static public void SortDishs(List<string> dishs, List<int> counts)
        {
            for (int i = 0; i < counts.Count; ++i)
            {
                for (int j = 0; j < counts.Count - 1; ++j)
                {
                    bool condition = counts[j + 1] > counts[j];
                    if (condition)
                    {
                        int temp_counts = counts[j];
                        counts[j] = counts[j + 1];
                        counts[j + 1] = temp_counts;

                        string temp_books = dishs[j];
                        dishs[j] = dishs[j + 1];
                        dishs[j + 1] = temp_books;
                    }
                }
            }
        }

        //расчитываем среднее значение 
        static public double CalculateAverage(List<int> counts)
        {
            int sum = 0;
            foreach (int count in counts)
            {
                sum += count;
            }

            return sum / counts.Count;
        }
    }
}