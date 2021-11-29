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
    public partial class Form2 : Form
    {
        public Form2(Form1 form1)
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
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

        private bool checkIsHave(int x, int y){
            float sq;
            for (int i=0; i<now; i++) {
                sq = (arr[i].x-x) * (arr[i].x-x) + (arr[i].y - y) * (arr[i].y - y);
                if (sq <= size*size) {
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
                for (int i=0; i<100; i++) {
                    for (int j=0; j<100; j++) {
                        matrix[i, j] = -1;
                    }
                }
                first = false;
            }
            if (now>=101){
                return;
            }
            if (checkIsHave(MousePosition.X-size/2, MousePosition.Y-size/2)) {
                arr[now] = new CircleButton(now + 1, MousePosition.X-size/2, MousePosition.Y-size/2, new Pen(Color.Black, 8), size);
                k.DrawEllipse(arr[now].pen, new Rectangle((int)arr[now].x, (int)arr[now].y, size, size));
                Controls.Add(arr[now].num);
                arr[now].num.Click += new EventHandler(drawLines);
                now++;
                changeMatrix();
            }
        }

        Button[] table = new Button[10000];
        int s = 0;

        private void changeMatrix(){
            for (int i = 0; i < s; i++) Controls.Remove(table[i]);
            for (int i = 0; i < s; i++) table[i] = null;
            s = (now+2)*(now+2);
            for (int i=0; i<s; i++) {
                table[i] = new Button();
            }
            int index = 0;
            int sw = 920, sh = 20;
            int nw = sw, nh = 20;
            for (int i=0; i<now+1; i++) {
                if (i==0) {
                    DoBut(table[0], "N", nw, nh);
                    index++;nw +=45;
                    for (int j=1; j<now+1; j++) {
                        DoBut(table[index], j.ToString(), nw, nh);
                        index++; nw += 45;
                    }
                }
                if(i!=0)
                for (int j=0; j<now+1; j++) {
                    if (j == 0) {
                        DoBut(table[index], i.ToString(), nw, nh);
                        index++; nw += 45;
                    }else{
                        DoBut(table[index], (matrix[i-1, j-1]).ToString(), nw, nh);
                        index++; nw += 45;
                     }
                }
                nh += 30;
                nw = sw;
            }
        }

        bool haveOne = false;
        int _x, _y, _code;

        private void drawLines(object sender, EventArgs e) {
            Console.WriteLine(this);
            if (haveOne) {
                k.DrawLine(new Pen(Color.Black, 8), _x, _y, this.Location.X, this.Location.Y);
                matrix[0, 1] = 1;
                changeMatrix();
            }
            else{
                _x = this.Location.X;
                _y = this.Location.Y;
                haveOne = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("In next i will show answer.");
            int nowPos = 0;
            try
            {
                 nowPos = Int32.Parse(tBxStartVerticle.Text);
            }
            catch (Exception ep) {
                tbAnsQue.Text = "Write here pls text";
                return;
            }

            dfs(nowPos-1);
        }

        String ans = "";

        private void dfs(int start) {
            int[] haveStay = new int[100];
            ans = "";
            for (int i = 0; i < now; i++) haveStay[i] = 0;
            Stack<int> verticle = new Stack<int>();
            verticle.Push(start);
            while (verticle.Count()!=0) {
                int noW = verticle.Pop();
                if (haveStay[noW] != 0) {
                    continue;
                }
                if (noW != start) ans = ans + ", ";
                ans = ans + (noW + 1).ToString();
                for (int i=now-1; i>-1; i--) {
                    if (matrix[noW, i]!=-1 && haveStay[i]==0){
                        verticle.Push(i);  
                    }
                }
                haveStay[noW] = 1;
            }
            tbAnsQue.Text = ans;
        }

        private void RGR(int start) { }

        private void Form2_Click_1(object sender, EventArgs e)
        {
            if (!checkIsHave(Cursor.Position.X, Cursor.Position.Y)) {
                Console.WriteLine("POINT IS CHOOSE");
                if (haveFP){
                    haveFP = false;
                    Console.WriteLine();
                    if (last.code == obJ.code) {
                        tbAnsQue.Text = "Please repeat";
                        return;
                    }
                    matrix[last.code-1, obJ.code-1] = 1;
                    matrix[obJ.code-1, last.code-1] = 1;
                    k.DrawLine(new Pen(Color.Black, 8), last.x+size/2, last.y+size/2, obJ.x+size/2, obJ.y+size/2);
                    changeMatrix();
                }
                else {
                    obJ = last;
                    haveFP = true;
                    tbAnsQue.Text = "verticle chosen";
                }
            }
        }

        private void DoBut(Button btn, string text, int x, int y) {
            btn.Text = text;
            btn.Location = new Point(x, y);
            btn.Width = 45;
            btn.Height = 30;
            btn.Enabled = true;
            Controls.Add(btn);
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            k = CreateGraphics();
        }

    }
}
