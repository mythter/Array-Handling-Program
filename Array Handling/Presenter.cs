/*
Файл: Presenter.cs
Лабораторная робота № 3
Автор: Положий А. С.
Тема: Розробка та дослідження програми обробки масивів
Дата створення: 09.03.2023
*/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ArrayHandling
{
    internal class Presenter
    {
        private readonly IView form;
        public Presenter(IView form)
        {
            this.form = form;
            this.form.GenerateAttempted += GenerateArray;
            this.form.WriteF1Attempted += WriteF1;
            this.form.WriteF2Attempted += WriteF2;
            this.form.ReadF1Attempted += ReadF1;
            this.form.RadioCheckChanged += Radio_CheckChanged;
        }

        private void WriteF1(object? sender, EventArgs e)
        {
            if (this.form.Array == null)
                throw new NullReferenceException();

            string userFileName;
            this.form.Save.InitialDirectory = @"C:\";
            this.form.Save.FileName = "array.txt";
            this.form.Save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.form.Save.Title = "Save file as...";

            if (this.form.Save.ShowDialog() == DialogResult.OK)
            {
                userFileName = this.form.Save.FileName;
                string json = JsonSerializer.Serialize(this.form.Array);
                File.WriteAllText(userFileName, json);
            }
        }

        private void WriteF2(object? sender, EventArgs e)
        {
            if (this.form.Array == null)
                throw new NullReferenceException();

            string userFileName;
            this.form.Save.InitialDirectory = @"C:\";
            this.form.Save.FileName = "array_info.txt";
            this.form.Save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.form.Save.Title = "Save file as...";

            if (this.form.Save.ShowDialog() == DialogResult.OK)
            {
                userFileName = this.form.Save.FileName;
                File.WriteAllText(userFileName, this.form.Result);
            }
        }

        private void ReadF1(object? sender, EventArgs e)
        {
            this.form.Open.InitialDirectory = @"С:\";
            this.form.Open.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.form.Open.Title = "Open file";

            if (this.form.Open.ShowDialog() == DialogResult.OK)
            {
                string fileName = this.form.Open.FileName;
                string json = File.ReadAllText(fileName);
                this.form.Array = JsonSerializer.Deserialize<int[]>(json);
            }

            if (this.form.Array != null)
                Output(this.form.Array);
        }

        private void GenerateArray(object? sender, EventArgs e)
        {
            this.form.Array = new int[this.form.N];
            Random rand = new Random();
            this.form.InitialArr = "";
            for (int i = 0; i < this.form.N; i++)
            {
                this.form.Array[i] = rand.Next(this.form.A, this.form.B);
                this.form.InitialArr += this.form.Array[i] + " ";
            }

            Output(this.form.Array);
        }

        private void Output(int[] arr)
        {
            this.form.N = arr.Length;
            this.form.InitialArr = "";
            this.form.Result = "";
            this.form.DataGrid.Rows.Clear();
            for (int i = 0; i < this.form.Array?.Length; i++)
            {
                this.form.InitialArr += this.form.Array[i] + " ";
                this.form.DataGrid.Rows.Add(new string[] { i.ToString(), this.form.Array[i].ToString() });
            }

            Radio_Check();
        }

        private string Calculate(int[] arr, Radio op)
        {
            string result = "";
            int count;
            int[] temp;

            switch (op)
            {
                case Radio.Op1:
                    if (this.form.Result.Contains("descending"))
                        return result;

                    result += new string('-', 37) + " Operation 1 " + new string('-', 37) + "\n";
                    result += "Sorted array in descending order:";

                    temp = new int[arr.Length];
                    arr.CopyTo(temp, 0);
                    Array.Sort(temp, (a, b) => b - a);
                    foreach (var item in temp)
                    {
                        result += " " + item;
                    }
                    result += "\n";
                    break;

                case Radio.Op2:
                    if (this.form.Result.Contains("composed")) return result;

                    result += new string('-', 37) + " Operation 2 " + new string('-', 37) + "\n";
                    result += "Elements for which the number composed of the last and third " +
                              "from the end of the digits of the number is even:";
                    count = 0;
                    int sum = 0;
                    foreach (var item in arr)
                    {
                        if (item > 100)
                        {
                            if (int.TryParse(new string(new char[] { item.ToString()[^1], item.ToString()[^3] }), out int number))
                                if (number % 2 == 0)
                                {
                                    count++;
                                    sum += item;
                                    result += " " + item;
                                }
                        }
                    }
                    result += "\nSum of these elements: " + sum;
                    result += "\nCount of these elements: " + count + "\n";
                    break;
                case Radio.Op3:
                    if (this.form.Result.Contains("primes")) return result;

                    result += new string('-', 37) + " Operation 3 " + new string('-', 37) + "\n";
                    result += "Prime numbers:";
                    count = 0;
                    bool prime;

                    for (int i = 0; i < arr.Length; i++)
                    {
                        prime = true;
                        for (int j = 2; j <= Math.Sqrt(arr[i]); j++)
                        {
                            if (arr[i] % j == 0)
                            {
                                prime = false;
                                break;
                            }
                        }
                        if (prime)
                        {
                            result += " " + arr[i];
                            count++;
                        }
                    }
                    result += "\nCount of primes: " + count + "\n";
                    break;
                case Radio.Op4:
                    if (this.form.Result.Contains("expectation")) return result;

                    result += new string('-', 37) + " Operation 4 " + new string('-', 37) + "\n";
                    result += "Mathematical expectation of squares of numbers: ";

                    double prb = (1f / arr.Length);
                    double exp = 0;
                    double disp = 0;
                    temp = new int[arr.Length];
                    arr.CopyTo(temp, 0);
                    for (int i = 0; i < temp.Length; i++)
                    {
                        temp[i] = (int)Math.Pow(temp[i], 2);
                        exp += Math.Round(prb * temp[i], 1);
                        disp += Math.Round(prb * Math.Pow(temp[i], 2), 1);
                    }
                    result += Math.Round(exp, 1);
                    result += "\nDispersion of squares of numbers: ";
                    disp -= Math.Round((double)Math.Pow(exp, 2), 1);
                    result += Math.Round(disp, 1) + "\n";
                    break;
                default:
                    break;
            }

            return result;
        }

        private void Radio_CheckChanged(object? sender, EventArgs e)
        {
            Radio_Check();
        }

        private void Radio_Check()
        {
            if (this.form.Array != null)
                if (this.form.Op1) this.form.Result += Calculate(this.form.Array, Radio.Op1);
                else if (this.form.Op2) this.form.Result += Calculate(this.form.Array, Radio.Op2);
                else if (this.form.Op3) this.form.Result += Calculate(this.form.Array, Radio.Op3);
                else this.form.Result += Calculate(this.form.Array, Radio.Op4);
        }
        enum Radio
        {
            None = 0,
            Op1 = 1,
            Op2 = 2,
            Op3 = 3,
            Op4 = 4
        };
    }
}
