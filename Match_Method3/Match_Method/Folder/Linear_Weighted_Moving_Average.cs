using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Match_Method.Folder
{
    class Linear_Weighted_Moving_Average
    {
        public List<Answers> answers = new List<Answers>();

        /// <summary>
        /// Линейно-взвешенное скользяще среднее
        /// </summary>
        /// <param name="countVariable">Кол-во переменных</param>
        /// <param name="interval">интервал</param>
        /// <param name="variable">массив переменных</param>
        /// <returns>Ответы</returns>
        public List<Answers> OutPut_Answer(int countVariable, int interval, List<VariableClass> variable)
        {
            double LWMA;

            for (int i = interval - 1; i < countVariable; i++)
            {
                double Sum1 = 0;
                double Sum2 = 0;
                for (int j = i - (interval - 1); j < countVariable; j++)
                {
                    Sum1 = Sum1 + (variable[j].Values * (j + 1));
                    Sum2 += (j + 1);
                }
                LWMA = Sum1 / Sum2;
                Answers an = new Answers();
                an.ID = i + 1;
                an.values = LWMA;
                answers.Add(an);
            }
            return answers;
        }
    }
}
