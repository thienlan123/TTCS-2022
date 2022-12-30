using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucTapCoSo_62139022
{
    public partial class InterchangeSort : Form
    {
        public InterchangeSort()
        {
            InitializeComponent();
        }

        Random random = new Random();
        private int[] Arr, Temp;
        private int n;
        private Button[] BtnArr;
        private const int GAP = 50;
        private const int SIZE = 50;

        public void button_NhapN_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            Arr = new int[n];
            Temp = new int[n];
            BtnArr = new Button[n];
        }

        private void button_NhapSo_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox2.Text);
            Temp[n++] = x;
            ShowArr();
            textBox2.Clear();
        }

        private void ShowArr()
        {
            string s = "";
            for (int i = 0; i < n; i++)
            {
                s += Temp[i] + " ";
            }
            textBox_Mang.Text = s;
        }

        private void button_VeMang_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            for (int i = 0; i < n; i++)
            {
                Button btn = new Button();
                int val = Temp[i];
                btn.Text = val.ToString();
                btn.Width = btn.Height = SIZE;
                btn.Location = new Point(panel1.Controls.Count * (btn.Width + GAP), panel1.Height / 2 - btn.Height);
                Arr[i] = val;
                BtnArr[i] = btn;
                panel1.Controls.Add(btn);
            }
        }
        private void button_NgauNhien_Click(object sender, EventArgs e)
        {
            textBox_Mang.Clear();
            int n = int.Parse(textBox1.Text);
            Arr = new int[n];
            BtnArr = new Button[n];
            panel1.Controls.Clear();
            for (int i = 0; i < n; i++)
            {
                Button btn = new Button();
                int val = random.Next(100);
                btn.Text = val.ToString();
                btn.Width = btn.Height = SIZE;
                btn.Location = new Point(panel1.Controls.Count * (btn.Width + GAP), panel1.Height / 2 - btn.Height);
                Arr[i] = val;
                BtnArr[i] = btn;
                panel1.Controls.Add(btn);
                textBox_Mang.Text += val.ToString() + " ";
            }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox_Mang.Clear();
            panel1.Controls.Clear();
            n = 0;
        }

        //BackgroundWoker1

        private void InterchangeS(int[] arr)
        {
            int i, j, temp;
            for (i = 0; i < n - 1; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                        System.Threading.Thread.Sleep(10);
                        MoveButton(j, i);
                    }
                }
            }
        }
        private void MoveButton(int i, int j)
        {
            Status st = new Status();
            st.Pos1 = i;
            st.Pos2 = j;
            st.type = MoveType.MOVE_TOP_DOWN;
            for (int x = 0; x < SIZE; x++)
            {
                backgroundWorker1.ReportProgress(0, st);
                System.Threading.Thread.Sleep(10);
            }
            st.type = MoveType.MOVE_LEFT_RiGHT;
            int Distance = Math.Abs(i - j) * (SIZE + GAP);
            for (int x = 0; x < Distance; x++)
            {
                backgroundWorker1.ReportProgress(0, st);
                System.Threading.Thread.Sleep(10);
            }
            st.type = MoveType.MOVE_IN_LINE;
            for (int x = 0; x < SIZE; x++)
            {
                backgroundWorker1.ReportProgress(0, st);
                System.Threading.Thread.Sleep(10);
            }
            st.type = MoveType.MOVED;
            backgroundWorker1.ReportProgress(0, st);
            System.Threading.Thread.Sleep(10);
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Status st = e.UserState as Status;
            if (st == null) return;
            if (st.type == MoveType.MOVED)
            {
                Button tmp = BtnArr[st.Pos1];
                BtnArr[st.Pos1] = BtnArr[st.Pos2];
                BtnArr[st.Pos2] = tmp;
                return;
            }
            Button btn1 = BtnArr[st.Pos1];
            Button btn2 = BtnArr[st.Pos2];
            if (st.type == MoveType.MOVE_TOP_DOWN)
            {
                btn1.Top++;
                btn2.Top--;
            }
            else if (st.type == MoveType.MOVE_LEFT_RiGHT)
            {
                btn1.Left--;
                btn2.Left++;
            }
            else if (st.type == MoveType.MOVE_IN_LINE)
            {
                btn1.Top--;
                btn2.Top++;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            InterchangeS(Arr);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (Button btn in panel1.Controls)
            {
                btn.BackColor = Color.DeepPink;
                btn.ForeColor = Color.White;
            }
        }


        private void button_SapXep_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        //BackgroundWoker2
        private void InterchangeS2(int[] arr)
        {
            int i, j, temp;
            for (i = 0; i < n - 1; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                        System.Threading.Thread.Sleep(10);
                        MoveButton2(j, i);
                    }
                }
            }
        }
        private void MoveButton2(int i, int j)
        {
            Status st = new Status();
            st.Pos1 = i;
            st.Pos2 = j;
            st.type = MoveType.MOVE_TOP_DOWN;
            for (int x = 0; x < SIZE; x++)
            {
                backgroundWorker2.ReportProgress(0, st);
                System.Threading.Thread.Sleep(10);
            }
            st.type = MoveType.MOVE_LEFT_RiGHT;
            int Distance = Math.Abs(i - j) * (SIZE + GAP);
            for (int x = 0; x < Distance; x++)
            {
                backgroundWorker2.ReportProgress(0, st);
                System.Threading.Thread.Sleep(10);
            }
            st.type = MoveType.MOVE_IN_LINE;
            for (int x = 0; x < SIZE; x++)
            {
                backgroundWorker2.ReportProgress(0, st);
                System.Threading.Thread.Sleep(10);
            }
            st.type = MoveType.MOVED;
            backgroundWorker2.ReportProgress(0, st);
            System.Threading.Thread.Sleep(10);
        }
        
        private void button_SapXepGiam_Click(object sender, EventArgs e)
        {
            backgroundWorker2.RunWorkerAsync();
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Status st = e.UserState as Status;
            if (st == null) return;
            if (st.type == MoveType.MOVED)
            {
                Button tmp = BtnArr[st.Pos1];
                BtnArr[st.Pos1] = BtnArr[st.Pos2];
                BtnArr[st.Pos2] = tmp;
                return;
            }
            Button btn1 = BtnArr[st.Pos1];
            Button btn2 = BtnArr[st.Pos2];
            if (st.type == MoveType.MOVE_TOP_DOWN)
            {
                btn1.Top++;
                btn2.Top--;
            }
            else if (st.type == MoveType.MOVE_LEFT_RiGHT)
            {
                btn1.Left--;
                btn2.Left++;
            }
            else if (st.type == MoveType.MOVE_IN_LINE)
            {
                btn1.Top--;
                btn2.Top++;
            }
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (Button btn in panel1.Controls)
            {
                btn.BackColor = Color.DeepPink;
                btn.ForeColor = Color.White;
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            InterchangeS2(Arr);
        }
    }
}

