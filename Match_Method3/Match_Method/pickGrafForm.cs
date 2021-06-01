using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Match_Method
{
    public partial class pickGrafForm : Form
    {
        List<Answers> answers = new List<Answers>();
        List<VariableClass> variables = new List<VariableClass>();

        /// <summary>
        /// Конструктор формы
        /// </summary>
        /// <param name="an">Массив данных с ответами</param>
        /// <param name="opiration">Операция которая происходила</param>
        public pickGrafForm(List<Answers> an,string opiration,List<VariableClass> list,int interval)
        {
            InitializeComponent();
            answers = an;
            variables = list;

            Graf.Series[1].Points.Clear();
            for(int i=0;i<variables.Count;i++)
            {
                int j = i;
                Graf.Series[1].Points.AddXY(++j, variables[i].Values);
            }
            Graf.Series[1].LegendText = "Первоначальный линия";

            Graf.Series[0].Points.Clear();
            
            for(int i=0;i<answers.Count;i++)
            {
                Graf.Series[0].Points.AddXY(interval, answers[i].values);
                interval++;
            }
            Graf.Series[0].LegendText = opiration;
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
