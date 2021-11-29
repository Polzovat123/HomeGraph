using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphs
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(Form1 form1)
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        CircleButton[] arr;
        TextBox[] ll;
        bool first = true;
        bool second = true;
        int now = 0;
        int size = 60;
        Graphics k;
        int[,] matrix;
        CircleButton obJ, last;
        bool haveFP = false;

        private bool checkIsHave(int x, int y)
        {
            float sq;
            for (int i = 0; i < now; i++)
            {
                sq = (arr[i].x - x) * (arr[i].x - x) + (arr[i].y - y) * (arr[i].y - y);
                if (sq <= size * size)
                {
                    last = arr[i];
                    return false;
                }
            }
            return true;
        }

        private void Form2_Click(object sender, EventArgs e)
        {
            if (first)
            {
                arr = new CircleButton[101];
                ll = new TextBox[101];
                matrix = new int[102, 102];
                for (int i = 0; i < 100; i++)
                {
                    for (int j = 0; j < 100; j++)
                    {
                        matrix[i, j] = -1;
                    }
                }
                first = false;
            }
            if (now >= 101)
            {
                return;
            }
            if (checkIsHave(MousePosition.X - size / 2, MousePosition.Y - size / 2))
            {
                arr[now] = new CircleButton(now + 1, MousePosition.X - size / 2, MousePosition.Y - size / 2, new Pen(Color.Black, 8), size);
                k.DrawEllipse(arr[now].pen, new Rectangle((int)arr[now].x, (int)arr[now].y, size, size));
                Controls.Add(arr[now].num);
                arr[now].num.Click += new EventHandler(drawLines);
                now++;
                changeMatrix();
            }
        }

        Button[] table = new Button[10000];
        int s = 0;

        private void changeMatrix()
        {
            for (int i = 0; i < s; i++) Controls.Remove(table[i]);
            for (int i = 0; i < s; i++) table[i] = null;
            s = (now + 2) * (now + 2);
            for (int i = 0; i < s; i++)
            {
                table[i] = new Button();
            }
            int index = 0;
            int sw = 920, sh = 20;
            int nw = sw, nh = 20;
            for (int i = 0; i < now + 1; i++)
            {
                if (i == 0)
                {
                    DoBut(table[0], "N", nw, nh);
                    index++; nw += 45;
                    for (int j = 1; j < now + 1; j++)
                    {
                        DoBut(table[index], j.ToString(), nw, nh);
                        index++; nw += 45;
                    }
                }
                if (i != 0)
                    for (int j = 0; j < now + 1; j++)
                    {
                        if (j == 0)
                        {
                            DoBut(table[index], i.ToString(), nw, nh);
                            index++; nw += 45;
                        }
                        else
                        {
                            DoBut(table[index], (matrix[i - 1, j - 1]).ToString(), nw, nh);
                            index++; nw += 45;
                        }
                    }
                nh += 30;
                nw = sw;
            }
        }

        bool haveOne = false;
        int _x, _y, _code;

        private void drawLines(object sender, EventArgs e)
        {
            Console.WriteLine(this);
            if (haveOne)
            {
                k.DrawLine(new Pen(Color.Black, 8), _x, _y, this.Location.X, this.Location.Y);
                matrix[0, 1] = 1;
                changeMatrix();
            }
            else
            {
                _x = this.Location.X;
                _y = this.Location.Y;
                haveOne = true;
            }
        }

        String ans = "";

        int[] inp;
        int[] o;

        private void RGR() {
            for (int i = 0; i < now; i++)
            {
                inp[i] = 0;
                o[i] = 0;
            }
            for (int i = 0; i < now; i++)
            {
                for (int j = 0; j < now; j++)
                {
                    if (matrix[i, j] != -1)
                    {
                        inp[j] += 1;
                        o[i] += 1;
                    }
                }
            }

            tbOut1.Text = "Stok:";
            for (int i = 0; i < now; i++)
            {
                if (o[i] != 0)
                {
                    tbOut1.Text = tbOut1.Text + " " + (i + 1).ToString();
                }
            }
            tbOut2.Text = "IStok:";
            for (int i = 0; i < now; i++)
            {
                if (inp[i] != 0)
                {
                    tbOut2.Text = tbOut2.Text + " " + (i + 1).ToString();
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            inp = new int[now];
            o = new int[now];
            RGR();
        }

        private void Form2_Click_1(object sender, EventArgs e)
        {
            if (!checkIsHave(Cursor.Position.X, Cursor.Position.Y))
            {
                Console.WriteLine("POINT IS CHOOSE");
                if (haveFP)
                {
                    double phi = 0.5;
                    haveFP = false;
                    Console.WriteLine();
                    if (last.code == obJ.code)
                    {
                        return;
                    }
                    matrix[last.code - 1, obJ.code - 1] = 1;
                    k.DrawLine(new Pen(Color.Black, 8), last.x + size / 2, last.y + size / 2, obJ.x + size / 2, obJ.y + size / 2);

                    int gip = (int)Math.Sqrt((last.x-obJ.x)*(last.x - obJ.x) +(last.y - obJ.y) *(last.y - obJ.y));

                    int x3 = (int)(Math.Abs(-last.x + obJ.x) / gip * obJ.x * phi);
                    int y3 = (int)(Math.Abs(-last.y + obJ.y) / gip * obJ.y * phi);

                    k.DrawLine(new Pen(Color.Red, 8), x3 + size/2, y3 +size/2, last.x + size / 2, last.y + size / 2);
                    changeMatrix();
                }
                else
                {
                    obJ = last;
                    haveFP = true;
                }
            }
        }

        private void DoBut(Button btn, string text, int x, int y)
        {
            btn.Text = text;
            btn.Location = new Point(x, y);
            btn.Width = 45;
            btn.Height = 30;
            btn.Enabled = true;
            Controls.Add(btn);
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            k = CreateGraphics();
        }
    }
}
