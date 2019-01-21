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
    public partial class Huffman : Form
    {
        private int leafNodes;
        public Huffman()
        {
            InitializeComponent();
        }
        private void InorderTraversal(BinaryTreeNode<CharFreq> node)
        {
            if (node != null)
            {
                InorderTraversal(node.Left);

                CharFreq cf = node.Value;
                int ord = (int)cf.ch;

                if (node.Left == null && node.Right == null)
                {
                    leafNodes++;
                    tb2.Text += "'" + new string(cf.ch, 1) + "' ";
                    tb2.Text += node.Value.freq.ToString() + "\r\n";
                }

                InorderTraversal(node.Right);
            }
        }
        private void preobr_Click(object sender, EventArgs e)
        {
            string s = tb1.Text;
            int n = s.Length;
            List<CharFreq> list = new List<CharFreq>();

            tb2.Text = string.Empty;

            for (int i = 0; i < n; i++)
            {
                bool found = false;
                char c = s[i];
                CharFreq cf = new CharFreq();

                for (int j = 0; !found && j < list.Count; j++)
                {
                    if (c == list[j].ch)
                    {
                        found = true;
                        cf.ch = c;
                        cf.freq = 1 + list[j].freq;
                        list.RemoveAt(j);
                        list.Add(cf);
                    }
                }

                if (!found)
                {
                    cf.ch = c;
                    cf.freq = 1;
                    list.Add(cf);
                }
            }

            HuffmanTree ht = new HuffmanTree();
            BinaryTreeNode<CharFreq> root = ht.Build(list, list.Count);

            InorderTraversal(root);
            tb2.Text += "\r\n characters = " + n.ToString() + "\r\n";
            tb2.Text += " leaf nodes = " + leafNodes.ToString() + "\r\n";
            tb2.Text += "\r\n % compressed = " +
                (100.0 - 100.0 * ((double)leafNodes) / n).ToString("F2") + "\r\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new kursach.Form1();
            f.Show();
        }
    }
}
