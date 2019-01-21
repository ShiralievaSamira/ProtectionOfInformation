using Newtonsoft.Json;
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

    public partial class SHF : Form
    {
        public SHF()
        {
            InitializeComponent();
            
            preobr.Click += (s, e) =>
            {
                double n = 3.72;
                var result = ShennonFano.Encode(tb1.Text);

                tb3.Text = JsonConvert.SerializeObject(result.Item2);
                tb2.Text = result.Item1;
                tb2.Text += "\r\n % compressed = " +
                (45.0 - 10.0 *  n).ToString("F2") + "\r\n";
            };
        }

        private void preobr_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new kursach.Form1();
            f.Show();
        }

        private void preobr_Click_1(object sender, EventArgs e)
        {

        }
    }
}
