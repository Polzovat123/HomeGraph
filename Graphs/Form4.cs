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
    public partial class Form4 : Form{
        public Form4(Form form){
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e){

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
        Button[] table = new Button[10000];
        int s = 0;

        private void Form4_Click(object sender, EventArgs e)
        {
            if (!checkIsHave(Cursor.Position.X, Cursor.Position.Y))
            {
                Console.WriteLine("POINT IS CHOOSE");
                if (haveFP)
                {
                    haveFP = false;
                    Console.WriteLine();
                    if (last.code == obJ.code)
                    {
                        return;
                    }
                    matrix[last.code - 1, obJ.code - 1] = 1;
                    matrix[obJ.code - 1, last.code - 1] = 1;
                    k.DrawLine(new Pen(Color.Black, 8), last.x + size / 2, last.y + size / 2, obJ.x + size / 2, obJ.y + size / 2);
                    changeMatrix();
                }
                else
                {
                    obJ = last;
                    haveFP = true;
                }
            }
        }
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

        private bool checkIsEmpty(int i, int[,] m) {
            for (int j = 0; j < now; j++)
                if (m[i, j] != -1)
                    return false;
            return true;
        }

        private void Form4_Paint(object sender, PaintEventArgs e)
        {
            k = CreateGraphics();
        }
        String ans = "";
        private void dfs(int start){
            int[] haveStay = new int[100];
            int[] kr = new int[100];
            int mini = 100000000;
            int[,] m = (int[,])matrix.Clone();
            int vs = -1;
            ans = "";
            for (int i = 0; i < now; i++) haveStay[i] = 0;
            for (int i = 0; i < now; i++) kr[i] = 0;
            Stack<int> verticle = new Stack<int>();
            verticle.Push(start);
            while (verticle.Count() != 0)
            {
                int noW = verticle.Pop();
                if (haveStay[noW] != 0){
                    continue;
                }
                for (int i = now - 1; i > -1; i--){
                    if (matrix[noW, i] != -1 && haveStay[i] == 0){
                        verticle.Push(i);
                    }
                }
                haveStay[noW] = 1;
            }
            for(int i=0; i<now; i++){
                if (haveStay[i]==0) {
                    tbAnsQue.Text = "NO.";
                    return;
                }
            }
            int f = 0;
            for (int i=0; i<now; i++) {
                for (int j=0; j<now; j++){
                    if (matrix[i, j] != -1) {
                        kr[i]++;
                    }
                }
                if (kr[i] % 2 != 0){
                    f++;
                    if (kr[i] < mini) {
                        mini = kr[i];
                        vs = i;
                    }
                }
            }
            if (vs == -1) vs = 0;
            Console.WriteLine(f);
            if (f == 0) {
                tbAnsQue.Text = "Yes we can.";
                verticle.Clear();
                ans = "";
                int father = -1;
                Stack<int> parent = new Stack<int>();
                Stack<int> toConvertAns = new Stack<int>();
                Stack<int> a = new Stack<int>();
                Stack<int> c = new Stack<int>();
                for (int i = 0; i < now; i++) { haveStay[i] = 0;}
                verticle.Push(vs);
                c.Push(vs);
                while (verticle.Count()>0){
                    int noW = verticle.Pop();
                    if (noW == vs && verticle.Count() != 0) break;
                    a.Push((noW + 1));
                    if (c.Count() == 0) break;
                    if (checkIsEmpty(noW, m)) {
                        int v = c.Pop();
                        Console.WriteLine(v);
                        toConvertAns.Push(v);
                        while (c.Count() > 0) {
                            v = c.Pop();
                            if (checkIsEmpty(v, m)){
                                toConvertAns.Push(v);
                            }else {
                                noW = v;
                                c.Push(v);
                                break;
                            }
                        }
                    }
                    if (parent.Count() > 0)
                        father = parent.Pop();
                    if (father>-1){
                        m[noW, father] = -1;
                        m[father, noW] = -1;
                    }
                    for (int i = 0; i < now; i++){
                        if (m[noW, i] != -1){
                            verticle.Push(i);
                            parent.Push(noW);
                            c.Push(i);
                            //break;
                        }
                    }
                }
                a.Push(vs+1);
                while (a.Count() > 0) {
                    if(a.Count()>1)ans = ans + a.Pop() + " ->";
                    else ans = ans + a.Pop();
                }
                tbAnsQue.Text = ans;
            }
            else{
                tbAnsQue.Text = "No we cant.";
            }

        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            dfs(0);
        }

        private void Form4_DoubleClick(object sender, EventArgs e){
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

        private bool checkIsHave(int x, int y){
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


        private void DoBut(Button btn, string text, int x, int y){
            btn.Text = text;
            btn.Location = new Point(x, y);
            btn.Width = 45;
            btn.Height = 30;
            btn.Enabled = true;
            Controls.Add(btn);
        }
    }
}
