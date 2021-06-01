using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Match_Method.Folder;

namespace Match_Method
{
    public partial class Form1 : Form
    {
        public List<VariableClass> variablesClass = new List<VariableClass>();
        public List<VariableClass> variab= new List<VariableClass>();
        public List<Answers> answers = new List<Answers>();
        public List<Answers> ansCharact = new List<Answers>();
        string opiration;
        int coise = 0;
        public Form1()
        {
            InitializeComponent();
            userChoice.SelectedIndex = 0;
            LinesNoice.SelectedIndex = 0;
            HarmNoice.SelectedIndex = 0;
            PasleNoice.SelectedIndex = 0;
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void goingQuest_Click(object sender, EventArgs e)
        {
            if (countNum.Value == 0 || intervalNum.Value==0)
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            AnswerQuest.Items.Clear();
            answers.Clear();
            Input_Data((int)countNum.Value);
            if(coise!=0)
            {
                variab = variablesClass;
                for (int i=0;i<variablesClass.Count;i++)
                {
                    variablesClass[i].Values = ansCharact[i].values;
                }
            }
            switch (userChoice.SelectedIndex)
            {
                case 0: Simple_Moving_Average sma = new Simple_Moving_Average();
                    answers = sma.OutPut_Answer((int)countNum.Value, (int)intervalNum.Value, variablesClass);
                    opiration = "SMA";
                    TextInBox();
                    break;
                case 1: Weighted_Moving_Average WMA = new Weighted_Moving_Average();
                    answers = WMA.OutPut_Answer((int)countNum.Value, (int)intervalNum.Value, variablesClass);
                    opiration = "WMA";
                    TextInBox();
                    break;
                case 2: Exponential_Moving_Average EMA = new Exponential_Moving_Average();
                    answers = EMA.OutPut_Answer((int)countNum.Value, (int)intervalNum.Value, variablesClass);
                    opiration = "EMA";
                    TextInBox();
                    break;
                case 3: Linear_Weighted_Moving_Average LWMA = new Linear_Weighted_Moving_Average();
                    answers = LWMA.OutPut_Answer((int)countNum.Value, (int)intervalNum.Value, variablesClass);
                    opiration = "LWMA";
                    TextInBox();
                    break;
                case 4: Smoothed_Moving_Average SMMA = new Smoothed_Moving_Average();
                    answers = SMMA.OutPut_Answer((int)countNum.Value, (int)intervalNum.Value, variablesClass);
                    opiration = "SMMA";
                    TextInBox();
                    break;
            }
        }

        /// <summary>
        /// Вывод данных в ListBox
        /// </summary>
        private void TextInBox()
        {
            for (int i = 0; i < answers.Count; i++)
            {
                AnswerQuest.Items.Add(opiration+"-" + answers[i].ID + "=" + Math.Round(answers[i].values, 1));
            }
        }
        /// <summary>
        /// Ввод данных в List
        /// </summary>
        /// <param name="countVariable">Кол-во переменных</param>
        private void Input_Data(int countVariable)
        {
            if(variablesClass.Count>0)
            {
                return;
            }
            for (int i = 0; i < countVariable; i++)
            {
                Variable vr = new Variable();
                vr.label1.Text = "Введите переменную №" + (i + 1);
                if (vr.ShowDialog() == DialogResult.OK)
                {
                    VariableClass vc = new VariableClass();
                    vc.ID = i;
                    vc.Values = (double)vr.variableUser.Value;
                    variablesClass.Add(vc);
                }
                else
                {
                    return;
                }
            }
        }

        /// <summary>
        /// Сохранение данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(variablesClass.Count==0)
            {
                MessageBox.Show("Добавьте данные!!!");
                return;
            }

            if (variablesClass.Count == 0) { MessageBox.Show("Вы не добавили данные"); return; }
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
                string fileName = saveFileDialog1.FileName;
                using (StreamWriter wr = new StreamWriter(fileName))
                {
                    string str=variablesClass.Count.ToString()+";";
                    for(int i=0;i<(int)countNum.Value;i++)
                    {
                        str += variablesClass[i].Values.ToString()+";";
                    }

                    wr.WriteLine(str);
                    MessageBox.Show("Сохраненно");
                }
            }
        }
        
        /// <summary>
        /// Загрузка данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) { return; }
            string fileName = openFileDialog1.FileName;
            using (StreamReader rd = new StreamReader(fileName))
            {
                variablesClass.Clear();
                string str;
                string[] buf;

                str = rd.ReadLine();
                buf = str.Split(';');
                for(int i=1;i<=Int32.Parse(buf[0]);i++)
                {
                    VariableClass vc = new VariableClass();
                    vc.ID = i;
                    vc.Values =  Convert.ToDouble(buf[i]);
                    variablesClass.Add(vc);
                }
                countNum.Value = variablesClass.Count;
                MessageBox.Show("Данные считанны");
            }
        }

        /// <summary>
        /// Добавление данных в массив
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBtn_Click(object sender, EventArgs e)
        {
            coise = 0;
            if (countNum.Value == 0 || intervalNum.Value == 0)
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            Input_Data((int)countNum.Value);
        }

        /// <summary>
        /// Очистка массива данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            countNum.Value = 0;
            intervalNum.Value = 0;
            AnswerQuest.Items.Clear();
            if(MessageBox.Show("Вы действительно хотете очистить массив?", "Сообщение", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly).ToString()=="Yes")
            {
                variablesClass.Clear();
                MessageBox.Show("Массив очищен");
            }
        }

        /// <summary>
        /// Выход
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Прорисовка графика
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PickGraf_Click(object sender, EventArgs e)
        {
            if(coise!=0)
            {
                opiration = opiration + "(С шумами)";
            }
            pickGrafForm pickGraf = new pickGrafForm(answers,opiration,variablesClass,(int)intervalNum.Value);
            pickGraf.Show();
        }

        /// <summary>
        /// Линейная характеристика с 3 вариантами
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>%
        private void ShowGraficLines_Click(object sender, EventArgs e)
        {
            coise = 1;
            if (countNum.Value == 0)
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            AnswerQuest.Items.Clear();
            answers.Clear();
            Input_Data((int)countNum.Value);
            switch (LinesNoice.SelectedIndex)
            {
                case 0:
                    TestData td1 = new TestData();
                    ansCharact = td1.Linear_Without_Noise(variablesClass);
                    MessageBox.Show("Данные переведены без шумов");
                    break;
                case 1:
                    TestData td2 = new TestData();
                    ansCharact = td2.Linear_With_Low_Noise(variablesClass);
                    MessageBox.Show("Данные переведены с шумом");
                    break;
                case 2:
                    TestData td3 = new TestData();
                    ansCharact = td3.Linear_With_Big_Noise(variablesClass);
                    MessageBox.Show("Данные переведены с шумом");
                    break;
            }
        }

        /// <summary>
        /// Гармоничная характеристика с 3 вариантами
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowGraficHarm_Click(object sender, EventArgs e)
        {
            coise = 1;
            if (countNum.Value == 0)
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            AnswerQuest.Items.Clear();
            answers.Clear();
            Input_Data((int)countNum.Value);
            switch (HarmNoice.SelectedIndex)
            {
                case 0:
                    TestData td1 = new TestData();
                    ansCharact = td1.Harmonious_Without_Noise(variablesClass);
                    MessageBox.Show("Данные переведены без шумов");
                    break;
                case 1:
                    TestData td2 = new TestData();
                    ansCharact = td2.Harmonious_With_Low_Noise(variablesClass);
                    MessageBox.Show("Данные переведены с шумом");
                    break;
                case 2:
                    TestData td3 = new TestData();
                    ansCharact = td3.Harmonious_With_Big_Noise(variablesClass);
                    MessageBox.Show("Данные переведены с шумом");
                    break;
            }
        }

        /// <summary>
        /// Импульсная характеристика с 3 вариантами
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowGraficPulse_Click(object sender, EventArgs e)
        {
            coise = 1;
            if (countNum.Value == 0)
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            AnswerQuest.Items.Clear();
            answers.Clear();
            Input_Data((int)countNum.Value);
            switch (PasleNoice.SelectedIndex)
            {
                case 0:
                    TestData td1 = new TestData();
                    ansCharact = td1.Pulse_Without_Noise(variablesClass,3);
                    MessageBox.Show("Данные переведены без шумов");
                    break;
                case 1:
                    TestData td2 = new TestData();
                    ansCharact = td2.Pulse_With_Low_Noise(variablesClass, 3);
                    MessageBox.Show("Данные переведены с шумом");
                    break;
                case 2:
                    TestData td3 = new TestData();
                    ansCharact = td3.Pulse_With_Big_Noise(variablesClass, 3);
                    MessageBox.Show("Данные переведены с шумом");
                    break;
            }
        }

        /// <summary>
        /// Метод размножения оценок
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dupl_rat_Click(object sender, EventArgs e)
        {

        }
    }
}
