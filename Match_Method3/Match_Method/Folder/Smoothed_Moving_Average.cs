using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Match_Method.Folder
{
    class Smoothed_Moving_Average
    {
        public List<Answers> answers = new List<Answers>();

        /// <summary>
        /// Сглaжeннaя cкoльзящaя cpeдняя
        /// </summary>
        /// <param name="countVariable">Кол-во переменных</param>
        /// <param name="interval">интервал</param>
        /// <param name="variable">массив переменных</param>
        /// <returns>Ответы</returns>
        public List<Answers> OutPut_Answer(int countVariable, int interval, List<VariableClass> variable)
        {
            double SMA = 0;
            for (int i = interval - 1; i >= 0; i--)
            {
                SMA += variable[i].Values;
            }
            SMA = SMA / interval;

            double SMMA = 0;
            for (int i = interval; i < countVariable; i++)
            {
                if (i == interval)
                {
                    SMMA = (SMA * (interval - 1) + variable[i].Values) / interval;
                }
                else
                {
                    SMMA = (SMMA * (interval - 1) + variable[i].Values) / interval;
                }
                Answers an = new Answers();
                an.ID = i + 1;
                an.values = Math.Round(SMMA, 1);
                answers.Add(an);
            }
            return answers;
        }
    }
}
