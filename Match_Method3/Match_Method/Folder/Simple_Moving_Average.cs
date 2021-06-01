using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Match_Method.Folder
{
    class Simple_Moving_Average
    {
        public List<Answers> answers = new List<Answers>();

        /// <summary>
        /// Скользящая средняя
        /// </summary>
        /// <param name="countVariable">Кол-во переменных</param>
        /// <param name="interval">интервал</param>
        /// <param name="variable">массив переменных</param>
        /// <returns>Ответы</returns>
        public List<Answers> OutPut_Answer(int countVariable, int interval, List<VariableClass> variable)
        {
            int n = 0;
            for (int i = interval - 1; i < countVariable; i++)
            {
                double Sum = 0;
                for (int j = interval - 1; j >= 0; j--)
                {
                    Sum += variable[i - j].Values;
                }
                Sum /= interval;
                int k = i + 1;
                Answers an = new Answers();
                an.ID = i+1;
                an.values = Math.Round(Sum, 1);
                answers.Add(an);
                n++;
            }
            return answers;
        }
    }
}
