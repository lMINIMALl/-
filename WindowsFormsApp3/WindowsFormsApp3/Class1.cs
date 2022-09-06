using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public class Arr
    {
        private Int32[,] a = new Int32[10, 10];
        private Int32[,] prover = new Int32[10, 10];
        private string[] sss = new string[10];
        private string[] sss2 = new string[10];
        private int hhh;
        private int live = 3;
        private Random rnd = new Random();
        public void zagruz()
        {
            int iii = Convert.ToInt32(new DirectoryInfo(@"shtuki\").GetFiles("*.txt").Length.ToString());
            int rrr = rnd.Next(1, iii + 1);
            string[] lines = File.ReadAllLines(@"shtuki\" + rrr + ".txt");
            double[,] num = new double[lines.Length, lines[0].Split(' ').Length];
            for (int i = 0; i < lines.Length; i++)
            {
                string[] Temp = lines[i].Split(' ');
                for (int j = 0; j < Temp.Length; j++)
                    a[i, j] = int.Parse(Temp[j]);
            }
        }
        public void zifri()
        {
            int с;
            int v;
            for (int i = 0; i < 10; i++)
            {
                с = 0;
                v = 0;
                for (int j = 0; j < 10; j++)
                {
                    if (a[i, j] == 1)
                    {
                        с++;
                    }
                    else
                    {
                        if (с != 0)
                        {
                            sss[i] += " " + Convert.ToString(с);
                            с = 0;
                        }
                    }
                    if (a[j, i] == 1)
                    {
                        v++;
                    }
                    else
                    {
                        if (v != 0)
                        {
                            sss2[i] += "\n" + Convert.ToString(v);
                            v = 0;
                        }
                    }
                }
                if (с != 0)
                {
                    sss[i] += " " + Convert.ToString(с);
                }
                if (v != 0)
                {
                    sss2[i] += "\n" + Convert.ToString(v);
                }
            }
        }
        public void zagolov(DataGridView dg)
        {
            for (int i = 1; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    dg.Rows[i].Cells[0].Value = sss[i - 1];
                }
            }
            for (int i = 0; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    dg.Rows[0].Cells[j].Value = sss2[j - 1];
                }
            }
        }
        public void raz(DataGridView dg)
        {
            int xxx = 3, xxx1 = 3;
            for (int i = 0; i < 11; i++)
            {
                xxx += dg.Columns[i].Width;
                xxx1 += dg.Rows[i].Height;
            }
            if (xxx <= 351)
            {
                for (int i = 0; i < 11; i++)
                {
                    dg.Width = xxx;
                    dg.Height = xxx1;
                }
            }
            else
            {
                dg.Width = 351;
                dg.Height = 351;
            }
        }
        public void raz1(DataGridView dg)
        {
            int xxx = 3, xxx1 = 3;
            for (int i = 0; i < 10; i++)
            {
                xxx += dg.Columns[i].Width;
                xxx1 += dg.Rows[i].Height;
            }
            if (xxx <= 351)
            {
                for (int i = 0; i < 10; i++)
                {
                    dg.Width = xxx;
                    dg.Height = xxx1;
                }
            }
            else
            {
                dg.Width = 351;
                dg.Height = 351;
            }
        }
        public void nul()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    prover[i, j] = 0;
                }
            }
        }
        public void nul1()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    a[i, j] = 0;
                }
            }
        }
        public void tttimer(int sec, Label label3)
        {
            hhh = 0;
            int min = 0;
            if (sec == 600)
            {
                sec = 0;
                min++;
            }
            if (min == 60)
            {
                min = 0;
                hhh++;
            }
            if (hhh < 10)
            {
                if (min < 10)
                {
                    if (sec < 100)
                    {
                        label3.Text = "0" + hhh + ":0" + min + ":0" + (sec / 10);
                    }
                    else
                    {
                        label3.Text = "0" + hhh + ":0" + min + ":" + (sec / 10);
                    }
                }
                else
                {
                    if (sec < 100)
                    {
                        label3.Text = "0" + hhh + min + ":0" + (sec / 10);
                    }
                    else
                    {
                        label3.Text = "0" + hhh + min + ":" + (sec / 10);
                    }
                }
            }
            if (hhh >= 10)
            {
                if (min < 10)
                {
                    if (sec < 100)
                    {
                        label3.Text = hhh + ":0" + min + ":0" + (sec / 10);
                    }
                    else
                    {
                        label3.Text = hhh + ":0" + min + ":" + (sec / 10);
                    }
                }
                else
                {
                    if (sec < 100)
                    {
                        label3.Text = hhh + min + ":0" + (sec / 10);
                    }
                    else
                    {
                        label3.Text = hhh + min + ":" + (sec / 10);
                    }
                }
            }
        }
        public int hour
        {
            get
            {
                return hhh;
            }
        }
        public int ppprover()
        {
            int Index = 0;
            int ccc = 0;
            int all = 10 * 10;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (a[i, j] == prover[i, j])
                    {
                        ccc++;
                    }
                }
            }
            if (ccc == all)
            {
                Index = 1;
            }
            return Index;
        }
        public int ppppprover(object sender, DataGridViewCellEventArgs e, int col)
        {
            prover[e.RowIndex - 1, e.ColumnIndex - 1] = col;
            if (a[e.RowIndex - 1, e.ColumnIndex - 1] != prover[e.RowIndex - 1, e.ColumnIndex - 1])
            {
                live--;
                return 2;
            }
            else
            {
                if (col == 1)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
        public int rez(int i, int j)
        {
            if (a[i - 1, j - 1] == 1)
            {
                return 1;
            }
            else 
            {
                return 0;
            }
        }
        public void ris(object sender, DataGridViewCellEventArgs e, int col)
        {
            a[e.RowIndex, e.ColumnIndex] = col;
        }
        public void vvod()
        {
            int iii = Convert.ToInt32(new DirectoryInfo(@"shtuki\").GetFiles("*.txt").Length.ToString()) + 1;
            FileStream fs = File.Create(@"shtuki\" + iii + ".txt");
            fs.Close();
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                if (i != 9)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (j != 9)
                        {
                            output.Append($"{a[i, j]} ");
                        }
                        if (j == 9)
                        {
                            output.Append($"{a[i, j]}");
                        }
                    }
                    output.Append(Environment.NewLine);
                }
                if (i == 9)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (j != 9)
                        {
                            output.Append($"{a[i, j]} ");
                        }
                        if (j == 9)
                        {
                            output.Append($"{a[i, j]}");
                        }
                    }
                }
            }

            try
            {
                System.IO.File.WriteAllText(@"shtuki\" + iii + ".txt", output.ToString());
            }
            catch
            {
                throw new Exception("Ошибка доступа к файлу");
            }
        }
        public int zizn(Label label1)
        {
            if (live == 3)
            {
                label1.Text = "❤❤❤";
                return 1;
            }
            if (live == 2)
            {
                label1.Text = "❤❤";
                return 1;
            }
            if (live == 1)
            {
                label1.Text = "❤";
                return 1;
            }
            else
            {
                label1.Text = "";
                return 0;
            }
        }
    }
}
