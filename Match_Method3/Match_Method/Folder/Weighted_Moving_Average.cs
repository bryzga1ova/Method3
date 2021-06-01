using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Match_Method.Folder
{
    class Weighted_Moving_Average
    {
        public List<Answers> answers = new List<Answers>();

        /// <summary>
        /// Скользящее взвешенное среднее
        /// </summary>
        /// <param name="countVariable"></param>
        /// <param name="interval"></param>
        /// <param name="variable"></param>
        /// <returns></returns>
        public List<Answers> OutPut_Answer(int countVariable, int interval, List<VariableClass> variable)
        {
            int n = 0;
            for (int i = interval - 1; i < countVariable; i++)
            {
                double Sum = 0;
                int k = interval;
                for (int j = i; j >= (i - (interval - 1)); j--)
                {
                    Sum += k * variable[j].Values;
                    k--;
                }
                double WMA = (2 * Sum) / (interval * (interval - 1));
                Answers an = new Answers();
                an.ID = i + 1;
                an.values = Math.Round(WMA, 1);
                answers.Add(an);
                
            }
            return answers;
        }
    }
}
