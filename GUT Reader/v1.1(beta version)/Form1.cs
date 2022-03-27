using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using QRCoder;
namespace GUT_Reader
{
    public partial class GUTReader : Form
    {
        public Thread broadcast;

        public string[] AllLines;

        public void 宣传()
        {
            if (File.Exists("C:\\broadcast.txt"))
            {
                AllLines = File.ReadAllText("C:\\broadcast.txt", Encoding.GetEncoding("gb2312"))
                    .Split(new string[] { Environment.NewLine }
                    , StringSplitOptions.RemoveEmptyEntries);
                int A = 0;
                while (true)
                {
                    if (A > AllLines.Length)
                    {
                        A = 0;
                    }
                    try
                    {
                        tips.Text = AllLines[A];
                    }
                    catch
                    {

                    }
                    Thread.Sleep(10000);
                    A++;
                }
            }
            else
            {
                MessageBox.Show("请在C:\\创建“broadcast.txt”", "缺少关键文件", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                string path ="C:\\broadcast.txt";
                string NEW = "";
                File.WriteAllText(path,NEW);
                System.Diagnostics.Process.Start(path);
                

            }
        }


        public GUTReader()
        {
            InitializeComponent();
            // MessageBox.Show(colToInt( Color.FromArgb( colToInt(Color.Red))) + " ");
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            textBox1.Text = path; //将获取到的完整路径赋值到textBox1
        }

        public byte Clampb(int ib)
        {
            while (ib > 255)
            {
                ib -= 256;
            }
            while (ib < 0)
            {
                ib += 256;
            }
            return (byte)ib;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 1, y = 1;
            if (textBox1.Text==" ")
            {
                MessageBox.Show("不要闲的没事不输入文件路径！！！！", "请输入文件路径！",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                goto HERE;
            }//判断是否输入了路径

            byte[] A=null;
            try { A = File.ReadAllBytes(textBox1.Text); }
            catch(DirectoryNotFoundException )
            {
                MessageBox.Show(
                    @"哪怕你再闲的没事也不要乱给不存在的路径！！！
你是不是吃饱了撑着！！！"
                    ,"不存在的路径",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                goto HERE;
            }//
            catch(Exception EX)
            {
                MessageBox.Show(EX.Message);
                goto HERE;
            }
            //this.WindowState = FormWindowState.Minimized;(是废稿！因为这样会丢失一些控件，而且我我也不知道为什么会这样)
            //也许是anchor的黑锅
            this.Visible = false;
            /*前面是什么？
             * 就是更新了一下
             * 做一些判断防止sb用户闲的没事乱搞（）
             * 不过问题在于
             * 我想到的问题不够多（笑）
             */
            int B = A.Length;
            int C = (int)Math.Sqrt(B / 114f) + 1;
            int w = 16 * C, h = 9 * C;
            Bitmap E = new Bitmap(w, h);
            foreach (byte ebyte in A)
            {
                byte random = (byte)(new Random(ebyte).Next(ebyte));
                int Result = ebyte - random;
               
                E.SetPixel(x, y, Color.FromArgb((byte)Result, 255, 0, random));
                x++;
                if (x >= w)
                {
                    x = 1;
                    y++;
                }
            }
            //
            E.Save(System.IO.Path.Combine(System.IO.Path.GetDirectoryName(textBox1.Text), "Result.png"), System.Drawing.Imaging.ImageFormat.Png);
            //
            if (checkBox1.Checked)
            {
                textBox1.Text = " ";
            }
            
            Thread.Sleep(1000);
            tips.Text = "           ";
            //this.WindowState = FormWindowState.Normal;
            this.Visible = true;
            HERE:;
        }

        private void solve_Click(object sender, EventArgs e)
        {
            List<byte> bytes = new List<byte>();
            string path;
            try
            {
                path = textBox1.Text;
            }
            catch (DirectoryNotFoundException )
            {
                MessageBox.Show(
                    @"哪怕你再闲的没事也不要乱给不存在的路径！！！
你是不是吃饱了撑着！！！"
                    , "不存在的路径", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                goto HERE;
            }
            Bitmap decode = (Bitmap)Bitmap.FromFile(path);
            for (int y = 1; y < decode.Height; y++)
            {
                for (int x = 1; x < decode.Width; x++)
                {
                    byte Result = ((byte)decode.GetPixel(x, y).A);
                    byte random = ((byte)decode.GetPixel(x, y).B);
                    int ebyte = Result+random;
                    
                    bytes.Add((byte)ebyte);
                }
            }
            File.WriteAllBytes(System.IO.Path.Combine(System.IO.Path.GetDirectoryName(textBox1.Text) , 文件名.Text + 后缀名.Text), bytes.ToArray());
            HERE:;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            broadcast = new Thread(new ThreadStart(this.宣传));
            broadcast.IsBackground = true;
            broadcast.Start();
            //MessageBox.Show((null=="").ToString());
        }

        private void comboBox1_MouseHover(object sender, EventArgs e)
        {
            tips.Text = "选择或输入文件后缀名";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            broadcast.Resume();
            tips.Text = " ";
        }

        private void 后缀名_MouseLeave(object sender, EventArgs e)
        {
            broadcast.Resume();
            tips.Text = " ";
        }

        [Obsolete]
        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            broadcast.Suspend();
            tips.Text = "请通过拖拽获取文件路径";
        }

        private void 后缀名_MouseEnter(object sender, EventArgs e)
        {
            broadcast.Suspend();
            tips.Text = "选择或输入文件后缀名";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void 文件名_MouseEnter(object sender, EventArgs e)
        {
            broadcast.Suspend();
            tips.Text = "输入氧化后的文件后缀名";
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            tips.Text = " ";
        }

        private void 文件名_MouseLeave(object sender, EventArgs e)
        {
           
            tips.Text = " ";
            broadcast.Resume();
        }

        private void 彩蛋_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            System.Diagnostics.Process.Start("http://182.254.162.234");
        }

        private void 彩蛋_MouseEnter(object sender, EventArgs e)
        {
            broadcast.Suspend();
            tips.Text = "你找到了一个彩蛋！";
        }

        private void 彩蛋_MouseLeave(object sender, EventArgs e)
        {
            tips.Text = " ";
        }

        private void INDNA_Click(object sender, EventArgs e)
        {
            if (INDNA.Checked == true)
            {
                UseQRCode.Checked = false;

            }
        }
    }
}
