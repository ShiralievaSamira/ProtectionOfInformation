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
    public partial class Chart : Form
    {
        public Chart()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.chart1.Series["% compressed"].Points.AddXY("BW", 27);
            this.chart1.Series["% compressed"].Points.AddXY("LZ", 12);
            this.chart1.Series["% compressed"].Points.AddXY("H", 33);
            this.chart1.Series["% compressed"].Points.AddXY("ShF", 8);
            this.chart1.Series["% compressed"].Points.AddXY("RLE", 0);
            this.chart1.Series["% compressed"].Points.AddXY("Arithm", 60);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new kursach.Form1();
            f.Show();
        }
    }
}
