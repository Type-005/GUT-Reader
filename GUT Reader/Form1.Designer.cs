
namespace GUT_Reader
{
    partial class GUTReader
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUTReader));
            this.button1 = new System.Windows.Forms.Button();
            this.solve = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.后缀名 = new System.Windows.Forms.ComboBox();
            this.Path = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tips = new System.Windows.Forms.ToolStripStatusLabel();
            this.文件名 = new System.Windows.Forms.TextBox();
            this.FileName = new System.Windows.Forms.Label();
            this.彩蛋 = new System.Windows.Forms.LinkLabel();
            this.UseQRCode = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.INDNA = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(49, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "氧化";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // solve
            // 
            this.solve.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.solve.Location = new System.Drawing.Point(222, 106);
            this.solve.Name = "solve";
            this.solve.Size = new System.Drawing.Size(75, 23);
            this.solve.TabIndex = 1;
            this.solve.Text = "还原";
            this.solve.UseVisualStyleBackColor = true;
            this.solve.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(82, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 21);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = " ";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
            this.textBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
            this.textBox1.MouseEnter += new System.EventHandler(this.textBox1_MouseEnter);
            this.textBox1.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
            // 
            // 后缀名
            // 
            this.后缀名.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.后缀名.FormattingEnabled = true;
            this.后缀名.Items.AddRange(new object[] {
            ".exe",
            ".xls",
            ".png",
            ".rar",
            ".7z",
            ".xml",
            ".htm",
            ".html",
            ".md",
            ".txt",
            ".doc",
            ".ppt",
            ".docx",
            ".pptx",
            ".apk"});
            this.后缀名.Location = new System.Drawing.Point(236, 43);
            this.后缀名.Name = "后缀名";
            this.后缀名.Size = new System.Drawing.Size(61, 20);
            this.后缀名.TabIndex = 3;
            this.后缀名.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.后缀名.MouseEnter += new System.EventHandler(this.后缀名_MouseEnter);
            this.后缀名.MouseLeave += new System.EventHandler(this.后缀名_MouseLeave);
            // 
            // Path
            // 
            this.Path.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Path.AutoSize = true;
            this.Path.Location = new System.Drawing.Point(47, 19);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(35, 12);
            this.Path.TabIndex = 4;
            this.Path.Text = "路径:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "解析类型:";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(49, 85);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(36, 16);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "是";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "不重复氧化？";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tips});
            this.statusStrip1.Location = new System.Drawing.Point(0, 149);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(346, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // tips
            // 
            this.tips.Font = new System.Drawing.Font("仿宋", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tips.LinkColor = System.Drawing.Color.Black;
            this.tips.Name = "tips";
            this.tips.Size = new System.Drawing.Size(257, 17);
            this.tips.Text = "                                    ";
            // 
            // 文件名
            // 
            this.文件名.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.文件名.Location = new System.Drawing.Point(99, 43);
            this.文件名.Name = "文件名";
            this.文件名.Size = new System.Drawing.Size(59, 21);
            this.文件名.TabIndex = 11;
            this.文件名.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.文件名.MouseEnter += new System.EventHandler(this.文件名_MouseEnter);
            this.文件名.MouseLeave += new System.EventHandler(this.文件名_MouseLeave);
            // 
            // FileName
            // 
            this.FileName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FileName.AutoSize = true;
            this.FileName.Location = new System.Drawing.Point(40, 47);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(53, 12);
            this.FileName.TabIndex = 12;
            this.FileName.Text = "文件名：";
            this.FileName.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // 彩蛋
            // 
            this.彩蛋.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.彩蛋.AutoSize = true;
            this.彩蛋.DisabledLinkColor = System.Drawing.Color.LightGray;
            this.彩蛋.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.彩蛋.LinkColor = System.Drawing.Color.Silver;
            this.彩蛋.Location = new System.Drawing.Point(130, 111);
            this.彩蛋.Name = "彩蛋";
            this.彩蛋.Size = new System.Drawing.Size(71, 12);
            this.彩蛋.TabIndex = 13;
            this.彩蛋.TabStop = true;
            this.彩蛋.Text = "           ";
            this.彩蛋.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.彩蛋_LinkClicked);
            this.彩蛋.MouseEnter += new System.EventHandler(this.彩蛋_MouseEnter);
            this.彩蛋.MouseLeave += new System.EventHandler(this.彩蛋_MouseLeave);
            // 
            // UseQRCode
            // 
            this.UseQRCode.AutoSize = true;
            this.UseQRCode.Location = new System.Drawing.Point(123, 85);
            this.UseQRCode.Name = "UseQRCode";
            this.UseQRCode.Size = new System.Drawing.Size(36, 16);
            this.UseQRCode.TabIndex = 14;
            this.UseQRCode.Text = "是";
            this.UseQRCode.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "使用QRCode?";
            // 
            // INDNA
            // 
            this.INDNA.AutoSize = true;
            this.INDNA.Location = new System.Drawing.Point(201, 70);
            this.INDNA.Name = "INDNA";
            this.INDNA.Size = new System.Drawing.Size(90, 16);
            this.INDNA.TabIndex = 16;
            this.INDNA.Text = "刻进DNA里？";
            this.INDNA.UseVisualStyleBackColor = true;
            this.INDNA.Click += new System.EventHandler(this.INDNA_Click);
            // 
            // GUTReader
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(346, 171);
            this.Controls.Add(this.INDNA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UseQRCode);
            this.Controls.Add(this.彩蛋);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.文件名);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Path);
            this.Controls.Add(this.后缀名);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.solve);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GUTReader";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "GUT Reader (v1.1)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button solve;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox 后缀名;
        private System.Windows.Forms.Label Path;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tips;
        private System.Windows.Forms.TextBox 文件名;
        private System.Windows.Forms.Label FileName;
        private System.Windows.Forms.LinkLabel 彩蛋;
        private System.Windows.Forms.CheckBox UseQRCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox INDNA;
    }
}

