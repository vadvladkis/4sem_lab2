using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        int ColIndex = -1;
        public Form1()
        {
            InitializeComponent();
            dgv.Rows.Add();
            button1_Click(null, null);
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int value;

            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                value = rnd.Next(-50, 50);
                dgv[i, 0].Value = value.ToString();
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = 0, val = 0;
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                val = Int32.Parse(dgv[i, 0].Value.ToString());
                if ((val > 0)&&(val < 10)) 
                {
                    sum = sum + val;
                }              
            }
            MessageBox.Show(sum.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = "";
            int val = 0;
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                val = Int32.Parse(dgv[i, 0].Value.ToString());
                if ((val % 3 == 0) && (val % 5 == 0))
                {
                    s = s + i.ToString()+", ";
                }
            }
            MessageBox.Show(s);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string s = "";
            int val = 0;
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                val = Int32.Parse(dgv[i, 0].Value.ToString());
                if ((val % 3 == 0) || (val % 5 == 0))
                {
                    s = s + i.ToString() + ", ";
                }
            }
            MessageBox.Show(s);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string s = "";
            int a = 0, b = 0, d = 0, c = Int32.Parse(tbC.Text);
            for (int i = 1; i < dgv.ColumnCount; i++)
            {
                d = i - 1;
                a = Int32.Parse(dgv[i, 0].Value.ToString());
                b = Int32.Parse(dgv[d, 0].Value.ToString());
                if ((a+b) == c)
                {
                    
                    s = s + d.ToString() + ", " + i.ToString() + "; ";
                }
            }
            MessageBox.Show("Пара соседних элементов с суммой, равной заданному числу.\n" + s);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgv_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                int val = Int32.Parse(e.FormattedValue.ToString());
            }
            catch
            {
                e.Cancel = true;
            }
        }

        private void tbC_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int val = Int32.Parse(tbC.Text);
            }
            catch
            {
                e.Cancel = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tmr.Enabled = !tmr.Enabled;
            if (tmr.Enabled){
                ColIndex = 0;
            }
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int value= rnd.Next(-50, 50);
            dgv[ColIndex, 0].Value = value.ToString();
            ColIndex++;
            if (ColIndex > 14)
            {
                ColIndex = -1;
                tmr.Enabled = false;
            }
        }

        private void tbT_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int val = Int32.Parse(tbT.Text);
                if (val < 1)
                {
                    val = 0;
                    tbT.Text = "0";
                    tmr.Enabled = false;
                }
                tmr.Interval = val;
            }
            catch
            {
                e.Cancel = true;
            }
        }
    }
}
