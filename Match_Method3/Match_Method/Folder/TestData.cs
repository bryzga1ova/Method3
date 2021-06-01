using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Match_Method.Folder
{
    class TestData
    {
        List<Answers> answers = new List<Answers>();

        /// <summary>
        /// Линеная без шумов
        /// </summary>
        /// <param name="variable">Массив данных</param>
        /// <returns></returns>
        public List<Answers> Linear_Without_Noise(List<VariableClass> variable)
        {
            answers.Clear();
            
            double a = 0.33, b = 15;
            for(int i=0;i< variable.Count();i++)
            {
                Answers ans = new Answers();
                ans.ID = i;
                ans.values = a * variable[i].Values + b;
                answers.Add(ans);
            }

            return answers;
        }

        /// <summary>
        /// Линеная с малыми шумами
        /// </summary>
        /// <param name="variable">Массив данных</param>
        /// <returns></returns>
        public List<Answers> Linear_With_Low_Noise(List<VariableClass> variable)
        {
            answers.Clear();

            Random rnd = new Random();
            double a = 0.33, b = 15;
            for(int i=0;i< variable.Count();i++)
            {
                double rand;
                do
                {
                    rand = rnd.NextDouble();
                    int j = rnd.Next(0, 1);
                    if(j==1)
                    {
                        rand *= -1;
                    }
                } while (rand > 0.5 || rand < -0.5);

                Answers ans = new Answers();
                ans.ID = i;
                ans.values = a * variable[i].Values + b + rand;
            }

            return answers;
        }

        /// <summary>
        /// Линеная с большими шумами
        /// </summary>
        /// <param name="variable">Массив данных</param>
        /// <returns></returns>
        public List<Answers> Linear_With_Big_Noise(List<VariableClass> variable)
        {
            answers.Clear();

            Random rnd = new Random();
            double a = 0.33, b = 15;
            for (int i = 0; i < variable.Count(); i++)
            {
                double rand = rnd.Next(-5, 5);

                Answers ans = new Answers();
                ans.ID = i;
                ans.values = a * variable[i].Values + b + rand;
            }

            return answers;
        }

        /// <summary>
        /// Гармоничная без шумов
        /// </summary>
        /// <param name="variable">Массив данных</param>
        /// <returns></returns>
        public List<Answers> Harmonious_Without_Noise(List<VariableClass> variable)
        {
            answers.Clear();

            double a = 5;
            for(int i=0;i< variable.Count();i++)
            {
                Answers ans = new Answers();
                ans.ID = i;
                ans.values = a * Math.Sin(variable[i].Values / 30);
                answers.Add(ans);
            }

            return answers;
        }

        /// <summary>
        /// Гармоничная с малыми шумами
        /// </summary>
        /// <param name="variable">Массив данных</param>
        /// <returns></returns>
        public List<Answers> Harmonious_With_Low_Noise(List<VariableClass> variable)
        {
            answers.Clear();

            double a = 5;
            Random rnd = new Random();
            for (int i = 0; i < variable.Count(); i++)
            {
                double rand;
                do
                {
                    rand = rnd.NextDouble();
                    int j = rnd.Next(0, 1);
                    if (j == 1)
                    {
                        rand *= -1;
                    }
                } while (rand > 0.5 || rand < -0.5);

                Answers ans = new Answers();
                ans.ID = i;
                ans.values = a * Math.Sin(variable[i].Values / 30) + rand; ;
                answers.Add(ans);
            }

            return answers;
        }

        /// <summary>
        /// Гармоничная с большими шумами
        /// </summary>
        /// <param name="variable">Массив данных</param>
        /// <returns></returns>
        public List<Answers> Harmonious_With_Big_Noise(List<VariableClass> variable)
        {
            answers.Clear();

            double a = 5;
            Random rnd = new Random();
            for (int i = 0; i < variable.Count(); i++)
            {
                double rand = rnd.Next(-5,5);

                Answers ans = new Answers();
                ans.ID = i;
                ans.values = a * Math.Sin(variable[i].Values / 30) + rand; ;
                answers.Add(ans);
            }

            return answers;
        }

        /// <summary>
        /// Импульсная без шумов
        /// </summary>
        /// <param name="variable">Массив данных</param>
        /// <param name="interval">Интервал</param>
        /// <returns></returns>
        public List<Answers> Pulse_Without_Noise(List<VariableClass> variable, int interval)
        {
            answers.Clear();

            int k = 0;
            double sum=0;

            int countVar = variable.Count();

            bool Exit=false;
            do
            {
                countVar = countVar - (interval+1);
                if (countVar == 0) Exit = true;
                if (countVar - (interval+1) < 0) Exit = true;
            } while (!Exit);

            for (int i=0;i<variable.Count();i++)
            {
                if(k<interval)
                {
                    k++;
                    sum += variable[i].Values;
                }
                else
                {
                    sum = sum / interval;
                    for(int j=0;j<=interval;j++)
                    {
                        variable[i - j].Values = sum;
                    }
                    k = 0;
                    sum = 0;
                    sum += variable[i].Values;
                }
            }

            if(countVar!=0)
            {
                sum = sum / countVar;
                for (int i = 1; i <= countVar; i++)
                {
                    variable[variable.Count - i].Values = sum;
                }
            }

            for(int i=0;i<variable.Count();i++)
            {
                Answers ans = new Answers();
                ans.ID = i;
                ans.values = variable[i].Values;
                answers.Add(ans);
            }

            return answers;
        }

        /// <summary>
        /// Импульсная с малыми шумами
        /// </summary>
        /// <param name="variable">Массив данных</param>
        /// <param name="interval">Интервал</param>
        /// <returns></returns>
        public List<Answers> Pulse_With_Low_Noise(List<VariableClass> variable, int interval)
        {
            answers.Clear();

            int k = 0;
            double sum = 0;

            int countVar = variable.Count();

            bool Exit = false;
            do
            {
                countVar = countVar - (interval + 1);
                if (countVar == 0) Exit = true;
                if (countVar - (interval + 1) < 0) Exit = true;
            } while (!Exit);

            Random rnd = new Random();
            double rand;

            for (int i = 0; i < variable.Count(); i++)
            {
                if (k < interval)
                {
                    k++;
                    sum += variable[i].Values;
                }
                else
                {
                    sum = sum / interval;

                    
                    do
                    {
                        rand = rnd.NextDouble();
                        int j = rnd.Next(0, 1);
                        if (j == 1)
                        {
                            rand *= -1;
                        }
                    } while (rand > 0.5 || rand < -0.5);

                    for (int j = 0; j <= interval; j++)
                    {
                        variable[i - j].Values = sum+rand;
                    }
                    k = 0;
                    sum = 0;
                    sum += variable[i].Values;
                }
            }

            if (countVar != 0)
            {
                sum = sum / countVar;
                do
                {
                    rand = rnd.NextDouble();
                    int j = rnd.Next(0, 1);
                    if (j == 1)
                    {
                        rand *= -1;
                    }
                } while (rand > 0.5 || rand < -0.5);

                for (int i = 1; i <= countVar; i++)
                {
                    variable[variable.Count - i].Values = sum+rand;
                }
            }

            for (int i = 0; i < variable.Count(); i++)
            {
                Answers ans = new Answers();
                ans.ID = i;
                ans.values = variable[i].Values;
                answers.Add(ans);
            }

            return answers;
        }

        /// <summary>
        /// Импульсная с большими шумами
        /// </summary>
        /// <param name="variable">Массив данных</param>
        /// <param name="interval">Интервал</param>
        /// <returns></returns>
        public List<Answers> Pulse_With_Big_Noise(List<VariableClass> variable, int interval)
        {
            answers.Clear();

            int k = 0;
            double sum = 0;

            int countVar = variable.Count();

            bool Exit = false;
            do
            {
                countVar = countVar - (interval + 1);
                if (countVar == 0) Exit = true;
                if (countVar - (interval + 1) < 0) Exit = true;
            } while (!Exit);

            Random rnd = new Random();

            for (int i = 0; i < variable.Count(); i++)
            {
                if (k < interval)
                {
                    k++;
                    sum += variable[i].Values;
                }
                else
                {
                    sum = sum / interval;
                    double rand = rnd.Next(-5, 5);
                    for (int j = 0; j <= interval; j++)
                    {
                        variable[i - j].Values = sum + rand; ;
                    }
                    k = 0;
                    sum = 0;
                    sum += variable[i].Values;
                }
            }

            if (countVar != 0)
            {
                sum = sum / countVar;
                double rand = rnd.Next(-5, 5);
                for (int i = 1; i <= countVar; i++)
                {
                    variable[variable.Count - i].Values = sum+rand;
                }
            }

            for (int i = 0; i < variable.Count(); i++)
            {
                Answers ans = new Answers();
                ans.ID = i;
                ans.values = variable[i].Values;
                answers.Add(ans);
            }

            return answers;
        }
    }
}
