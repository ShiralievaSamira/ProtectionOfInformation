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
    public partial class LZ : Form
    {
        private Dictionary<int, string> dictionary;
        private List<int> indices;
        public LZ()
        {
            InitializeComponent();
        }

        private void preobr_Click(object sender, EventArgs e)
        {
            string text = tb1.Text;
            int n = text.Length;
            LZCompressor comp = new LZCompressor();

            indices = new List<int>();
            dictionary = comp.Compressor(text, ref indices);
            dg.Text += "Dictionary\r\n";

            foreach (KeyValuePair<int, string> kvp in dictionary)
            {
                if (kvp.Key >= 256)
                {
                    dg.Text += kvp.Key.ToString("D3") + "\t";
                    dg.Text += kvp.Value + "\r\n";
                }
            }

            dg.Text += "\r\nIndices\r\n";

            foreach (int index in indices)
                dg.Text += index.ToString() + "\r\n";

            dg.Text += "\r\n";
            dg.Text += "% compressed = " +
                (20.0 - 100.0 / n).ToString("F2") + "\r\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new kursach.Form1();
            f.Show();
        }
    }
}
