using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Match_Method.Folder
{
    class Exponential_Moving_Average
    {
        public List<Answers> answers = new List<Answers>();

        /// <summary>
        /// Экспоненциальное скользящее среднее 
        /// </summary>
        /// <param name="countVariable">Кол-во переменных</param>
        /// <param name="interval">интервал</param>
        /// <param name="variable">массив переменных</param>
        /// <returns>Ответы</returns>
        public List<Answers> OutPut_Answer(int countVariable, int interval, List<VariableClass> variable)
        {
            double k = interval + 1;
            double a = (2 / k);

            double SMA = 0;
            for (int i = interval - 1; i >= 0; i--)
            {
                SMA += variable[i].Values;
            }
            SMA = SMA / interval;

            double EMA = 0;
            for (int i = interval; i < countVariable; i++)
            {
                double EMA_One = a * variable[i].Values;
                if (i == interval)
                {
                    EMA = EMA_One + ((1 - a) * SMA);
                }
                else
                {
                    EMA = EMA_One + ((1 - a) * EMA);
                }
                Answers an = new Answers();
                an.ID = i+1;
                an.values = Math.Round(EMA,1);
                answers.Add(an);
            }
            return answers;
        }
    }
}
