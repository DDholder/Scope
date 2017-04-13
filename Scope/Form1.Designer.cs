namespace Scope
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.button1 = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.自动跟随ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开启ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkLine_0 = new System.Windows.Forms.CheckBox();
            this.checkLine_1 = new System.Windows.Forms.CheckBox();
            this.checkLine_2 = new System.Windows.Forms.CheckBox();
            this.checkLine_3 = new System.Windows.Forms.CheckBox();
            this.combo_line0 = new System.Windows.Forms.ComboBox();
            this.combo_line1 = new System.Windows.Forms.ComboBox();
            this.combo_line2 = new System.Windows.Forms.ComboBox();
            this.combo_line3 = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hScrollBar1.Location = new System.Drawing.Point(9, 506);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(1180, 21);
            this.hScrollBar1.TabIndex = 0;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollBar1_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1002, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "开始/停止";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vScrollBar1.Location = new System.Drawing.Point(1168, 9);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 497);
            this.vScrollBar1.TabIndex = 2;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VScrollBar1_Scroll);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.自动跟随ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 28);
            // 
            // 自动跟随ToolStripMenuItem
            // 
            this.自动跟随ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开启ToolStripMenuItem,
            this.关闭ToolStripMenuItem});
            this.自动跟随ToolStripMenuItem.Name = "自动跟随ToolStripMenuItem";
            this.自动跟随ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.自动跟随ToolStripMenuItem.Text = "自动跟随";
            // 
            // 开启ToolStripMenuItem
            // 
            this.开启ToolStripMenuItem.Name = "开启ToolStripMenuItem";
            this.开启ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.开启ToolStripMenuItem.Text = "开启";
            this.开启ToolStripMenuItem.Click += new System.EventHandler(this.开启ToolStripMenuItem_Click);
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.关闭ToolStripMenuItem.Text = "关闭";
            this.关闭ToolStripMenuItem.Click += new System.EventHandler(this.关闭ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // checkLine_0
            // 
            this.checkLine_0.AutoSize = true;
            this.checkLine_0.ForeColor = System.Drawing.Color.Red;
            this.checkLine_0.Location = new System.Drawing.Point(166, 12);
            this.checkLine_0.Name = "checkLine_0";
            this.checkLine_0.Size = new System.Drawing.Size(67, 19);
            this.checkLine_0.TabIndex = 5;
            this.checkLine_0.Text = "波形1";
            this.checkLine_0.UseVisualStyleBackColor = true;
            // 
            // checkLine_1
            // 
            this.checkLine_1.AutoSize = true;
            this.checkLine_1.ForeColor = System.Drawing.Color.Green;
            this.checkLine_1.Location = new System.Drawing.Point(366, 12);
            this.checkLine_1.Name = "checkLine_1";
            this.checkLine_1.Size = new System.Drawing.Size(67, 19);
            this.checkLine_1.TabIndex = 6;
            this.checkLine_1.Text = "波形2";
            this.checkLine_1.UseVisualStyleBackColor = true;
            // 
            // checkLine_2
            // 
            this.checkLine_2.AutoSize = true;
            this.checkLine_2.ForeColor = System.Drawing.Color.Blue;
            this.checkLine_2.Location = new System.Drawing.Point(573, 13);
            this.checkLine_2.Name = "checkLine_2";
            this.checkLine_2.Size = new System.Drawing.Size(67, 19);
            this.checkLine_2.TabIndex = 8;
            this.checkLine_2.Text = "波形3";
            this.checkLine_2.UseVisualStyleBackColor = true;
            // 
            // checkLine_3
            // 
            this.checkLine_3.AutoSize = true;
            this.checkLine_3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkLine_3.Location = new System.Drawing.Point(777, 12);
            this.checkLine_3.Name = "checkLine_3";
            this.checkLine_3.Size = new System.Drawing.Size(67, 19);
            this.checkLine_3.TabIndex = 7;
            this.checkLine_3.Text = "波形4";
            this.checkLine_3.UseVisualStyleBackColor = true;
            // 
            // combo_line0
            // 
            this.combo_line0.FormattingEnabled = true;
            this.combo_line0.Location = new System.Drawing.Point(239, 10);
            this.combo_line0.Name = "combo_line0";
            this.combo_line0.Size = new System.Drawing.Size(121, 23);
            this.combo_line0.TabIndex = 9;
            this.combo_line0.SelectedIndexChanged += new System.EventHandler(this.combo_line0_SelectedIndexChanged);
            // 
            // combo_line1
            // 
            this.combo_line1.FormattingEnabled = true;
            this.combo_line1.Location = new System.Drawing.Point(439, 10);
            this.combo_line1.Name = "combo_line1";
            this.combo_line1.Size = new System.Drawing.Size(121, 23);
            this.combo_line1.TabIndex = 10;
            this.combo_line1.SelectedIndexChanged += new System.EventHandler(this.combo_line1_SelectedIndexChanged);
            // 
            // combo_line2
            // 
            this.combo_line2.FormattingEnabled = true;
            this.combo_line2.Location = new System.Drawing.Point(646, 10);
            this.combo_line2.Name = "combo_line2";
            this.combo_line2.Size = new System.Drawing.Size(121, 23);
            this.combo_line2.TabIndex = 11;
            this.combo_line2.SelectedIndexChanged += new System.EventHandler(this.combo_line2_SelectedIndexChanged);
            // 
            // combo_line3
            // 
            this.combo_line3.FormattingEnabled = true;
            this.combo_line3.Location = new System.Drawing.Point(850, 10);
            this.combo_line3.Name = "combo_line3";
            this.combo_line3.Size = new System.Drawing.Size(121, 23);
            this.combo_line3.TabIndex = 12;
            this.combo_line3.SelectedIndexChanged += new System.EventHandler(this.combo_line3_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 536);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.combo_line3);
            this.Controls.Add(this.combo_line2);
            this.Controls.Add(this.combo_line1);
            this.Controls.Add(this.combo_line0);
            this.Controls.Add(this.checkLine_2);
            this.Controls.Add(this.checkLine_3);
            this.Controls.Add(this.checkLine_1);
            this.Controls.Add(this.checkLine_0);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hScrollBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "中国民航大学智能车队(beta)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 自动跟随ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开启ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkLine_0;
        private System.Windows.Forms.CheckBox checkLine_1;
        private System.Windows.Forms.CheckBox checkLine_2;
        private System.Windows.Forms.CheckBox checkLine_3;
        private System.Windows.Forms.ComboBox combo_line0;
        private System.Windows.Forms.ComboBox combo_line1;
        private System.Windows.Forms.ComboBox combo_line2;
        private System.Windows.Forms.ComboBox combo_line3;
    }
}

