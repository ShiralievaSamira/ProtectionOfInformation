using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach
{
    public partial class RLE : Form
    {
        public RLE()
        {
            InitializeComponent();
        }

        private void preobr_Click(object sender, EventArgs e)
        {
            string str1 = tb1.Text, str = "", ch = "";
            int i, k, j;
            int n = Text.Length;
            for (i = 0; i < str1.Length;)
            {
                ch = str1.Substring(i, 1);
                k = 0;
                if (i == str1.Length - 1)
                {
                    str += Convert.ToString(ch);
                    break;
                }
                if (str1.Substring(i + 1, 1) == ch)
                {
                    for (j = i; j < str1.Length; j++)
                    {
                        if (str1.Substring(j, 1) == ch)
                        {
                            k++;
                        }
                        else
                            break;
                    }
                    i = j;
                }
                else
                    i++;
                if (k != 0)
                    str += Convert.ToString(k) + Convert.ToString(ch);
                else
                    str += Convert.ToString(ch);

            }
            tb2.Text = str + "\r\n"; 
            tb2.Text += "% compressed =  " +
                               (33.0 - 99.0 / n).ToString("F2") + "\r\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new kursach.Form1();
            f.Show();
        }
    }
}
