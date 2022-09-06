using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int col = 1;
        Arr M1 = new Arr();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 11;
            dataGridView1.ColumnCount = 11;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            M1.zagruz();
            M1.zifri();
            M1.zagolov(dataGridView1);
            M1.raz(dataGridView1);
            M1.nul();
        }
        int sec = 0;
        int hhh;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            M1.tttimer(sec, label3);
            hhh = M1.hour;
            if (hhh == 60)
            {
                timer1.Stop();
                DialogResult d = MessageBox.Show("Превышено время ожидания", "Warning!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (d == DialogResult.Retry)
                {
                    Application.Restart();
                }
                if (d == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                col = 1;
            if (radioButton2.Checked == true)
                col = 0;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell != (dataGridView1.Rows[0].Cells[0]) && (dataGridView1.CurrentCell != (dataGridView1.Rows[0].Cells[1])) && (dataGridView1.CurrentCell != (dataGridView1.Rows[0].Cells[2])) && (dataGridView1.CurrentCell != (dataGridView1.Rows[0].Cells[3])) && (dataGridView1.CurrentCell != (dataGridView1.Rows[0].Cells[4])) && (dataGridView1.CurrentCell != (dataGridView1.Rows[0].Cells[5])) && (dataGridView1.CurrentCell != (dataGridView1.Rows[0].Cells[6])) && (dataGridView1.CurrentCell != (dataGridView1.Rows[0].Cells[7])) && (dataGridView1.CurrentCell != (dataGridView1.Rows[0].Cells[8])) && (dataGridView1.CurrentCell != (dataGridView1.Rows[0].Cells[9])) && (dataGridView1.CurrentCell != (dataGridView1.Rows[0].Cells[10])) && (dataGridView1.CurrentCell != (dataGridView1.Rows[1].Cells[0])) && (dataGridView1.CurrentCell != (dataGridView1.Rows[2].Cells[0])) && (dataGridView1.CurrentCell != (dataGridView1.Rows[3].Cells[0])) && (dataGridView1.CurrentCell != (dataGridView1.Rows[4].Cells[0])) && (dataGridView1.CurrentCell != (dataGridView1.Rows[5].Cells[0])) && (dataGridView1.CurrentCell != (dataGridView1.Rows[6].Cells[0])) && (dataGridView1.CurrentCell != (dataGridView1.Rows[7].Cells[0])) && (dataGridView1.CurrentCell != (dataGridView1.Rows[8].Cells[0])) && (dataGridView1.CurrentCell != (dataGridView1.Rows[9].Cells[0])) && (dataGridView1.CurrentCell != (dataGridView1.Rows[10].Cells[0])))
            {
                int Index1 = M1.ppppprover(sender, e, col);
                if (Index1 == 2)
                {
                    dataGridView1.CurrentCell.Style.BackColor = Color.Red;
                }
                if (Index1 == 1)
                {
                    dataGridView1.CurrentCell.Style.BackColor = Color.FromArgb(0, 0, 192);
                }
                if (Index1 == 0)
                {
                    dataGridView1.CurrentCell.Style.BackColor = Color.FromArgb(192, 192, 255);
                }
            }
            if (this.Visible == true)
            {
                timer1.Start();
            }
            int live = M1.zizn(label1);
            if (live == 0)
            {
                timer1.Stop();
                DialogResult d = MessageBox.Show(("Time: " + label3.Text), "You lose", MessageBoxButtons.RetryCancel, MessageBoxIcon.None);
                if (d == DialogResult.Retry)
                {
                    Application.Restart();
                }
                if (d == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
            int Index = M1.ppprover();
            if (Index == 1)
            {
                for (int i = 1; i < 11; i++)
                {
                    for (int j = 1; j < 11; j++)
                    {
                        if (M1.rez(i, j) == 1)
                        {
                            dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(0, 0, 192);
                        }
                        if (M1.rez(i, j) == 0)
                        {
                            dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(192, 192, 255);
                        }
                        DataGridViewRow row = dataGridView1.Rows[j];
                        row.Height = 15;
                    }
                    DataGridViewColumn column = dataGridView1.Columns[i];
                    column.Width = 15;
                }
                timer1.Stop();
                DialogResult d = MessageBox.Show(("Time: " + label3.Text), "Result", MessageBoxButtons.RetryCancel, MessageBoxIcon.None);
                if (d == DialogResult.Retry)
                {
                    Application.Restart();
                }
                if (d == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Owner = this;
            form2.Show();
            Hide();
            if (this.Visible==false)
            {
                timer1.Stop();
            }
        }
    }
}       