using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(this);
            newForm.Show();
        }

        private void btnRGR_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3(this);
            newForm.Show();
        }

        private void btnLAB_Click(object sender, EventArgs e)
        {
            Form4 nForm = new Form4(this);
            nForm.Show();
        }
    }
}
