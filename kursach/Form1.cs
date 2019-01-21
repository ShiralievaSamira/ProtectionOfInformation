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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void BW_Click(object sender, EventArgs e)
        {
            BW barw = new kursach.BW();
            barw.Show();
        }

        private void LZ_Click(object sender, EventArgs e)
        {
            LZ lempz = new kursach.LZ();
            lempz.Show();
        }

        private void H_Click(object sender, EventArgs e)
        {
            Huffman huff = new kursach.Huffman();
            huff.Show();
        }

        private void SHF_Click(object sender, EventArgs e)
        {
            SHF shenn = new kursach.SHF();
            shenn.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Chart chr = new kursach.Chart();
            chr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RLE rle = new kursach.RLE();
            rle.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Arithmetic arth = new kursach.Arithmetic();
            arth.Show();
        }
    }
}
