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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int col = 1;
        Arr M2 = new Arr();
        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 10;
            dataGridView1.ColumnCount = 10;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            M2.nul1();
            M2.raz1(dataGridView1);
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
            M2.ris(sender, e, col);
            if (col == 1)
            {
                dataGridView1.CurrentCell.Style.BackColor = Color.FromArgb(0, 0, 192);
            }
            else
            {
                dataGridView1.CurrentCell.Style.BackColor = Color.FromArgb(192, 192, 255);
            }
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Visible = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Owner.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            M2.vvod();
        }
    }
}