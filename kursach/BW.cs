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
    public partial class BW : Form
    {
        public string Word;
        public BW()
        {
            InitializeComponent();
        }

        private void preobr_Click(object sender, EventArgs e)
        {
            string s = tb1.Text;
            int n = s.Length;
            Word = tb1.Text;
            dg1.ColumnCount = Word.Length;
            dg1.RowCount = Word.Length;
            dg2.ColumnCount = Word.Length;
            dg2.RowCount = Word.Length;

            string newWord = Word;
            char[] mWord = newWord.ToCharArray();

            List<string> listyWords = new List<string> { };
            for (int row = 0; row < Word.Length; row++)
            {
                newWord = Word.Substring(row);
                newWord += Word.Substring(0, row);
                listyWords.Add(newWord);
                mWord = newWord.ToCharArray();
                for (int column = 0; column < Word.Length; column++)
                {
                    dg1[column, row].Value = mWord[column];
                }
                newWord = null;
            }
            List<string> sortedListWords = new List<string> { };
            sortedListWords = listyWords;
            sortedListWords.Sort();

            string YandN = null;
            for (int row = 0; row < Word.Length; row++)
            {
                mWord = sortedListWords[row].ToCharArray();
                for (int column = 0; column < Word.Length; column++)
                {
                    dg2[column, row].Value = mWord[column];
                    if (column == Word.Length - 1)
                    {
                        YandN += mWord[column];
                    }
                }
            }
            tb2.Text = YandN + listyWords.IndexOf(Word).ToString() + "\r\n";
            tb2.Text += "\r\n % compressed = " +
                (35.0 - 100.0  / n).ToString("F2") + "\r\n";

            mWord = null;
            List<string> resultAdd = new List<string> { };
            mWord = YandN.Substring(0, Word.Length).ToCharArray();
            for (int index = 0; index < mWord.Length; index++)
            {
                resultAdd.Insert(index, mWord[index].ToString());
            }
            List<string> resultSort = new List<string> { };
            resultSort.AddRange(resultAdd);
            resultSort.Sort();
            for (int row = 0; row < Word.Length; row++)
            {
                mWord = resultAdd[row].ToCharArray();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new kursach.Form1();
            f.Show();
        }
    }
}
