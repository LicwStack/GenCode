namespace TestMotionStudio
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.lab_card = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.txt_SetDo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Di = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_ResetDo = new System.Windows.Forms.TextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.txt_Pos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_Position = new System.Windows.Forms.Label();
            this.lab_Pos1 = new System.Windows.Forms.Label();
            this.lab_Axis = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button15 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "打开控制器";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // show
            // 
            this.show.AllowDrop = true;
            this.show.BackColor = System.Drawing.Color.White;
            this.show.Font = new System.Drawing.Font("Tahoma", 16F);
            this.show.ItemHeight = 25;
            this.show.Location = new System.Drawing.Point(812, 12);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(398, 579);
            this.show.TabIndex = 317;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 318;
            this.button2.Text = "打开使能";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(127, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 28);
            this.button3.TabIndex = 319;
            this.button3.Text = "关闭使能";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(127, 60);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 320;
            this.button4.Text = "关闭控制器";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 101);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 28);
            this.button5.TabIndex = 321;
            this.button5.Text = "建立通讯";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(127, 101);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 28);
            this.button6.TabIndex = 322;
            this.button6.Text = "关闭通讯";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // lab_card
            // 
            this.lab_card.AutoSize = true;
            this.lab_card.Location = new System.Drawing.Point(22, 25);
            this.lab_card.Name = "lab_card";
            this.lab_card.Size = new System.Drawing.Size(53, 12);
            this.lab_card.TabIndex = 323;
            this.lab_card.Text = "Card OFF";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 208);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(102, 28);
            this.button7.TabIndex = 324;
            this.button7.Text = "获取轴Home信号";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(209, 208);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 28);
            this.button8.TabIndex = 325;
            this.button8.Text = "平滑停止";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(290, 208);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 28);
            this.button9.TabIndex = 326;
            this.button9.Text = "急停";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(78, 20);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 28);
            this.button10.TabIndex = 327;
            this.button10.Text = "Get Di";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(68, 17);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 28);
            this.button11.TabIndex = 328;
            this.button11.Text = "Set Do";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // txt_SetDo
            // 
            this.txt_SetDo.Location = new System.Drawing.Point(6, 20);
            this.txt_SetDo.Name = "txt_SetDo";
            this.txt_SetDo.Size = new System.Drawing.Size(44, 21);
            this.txt_SetDo.TabIndex = 329;
            this.txt_SetDo.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_SetDo);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Location = new System.Drawing.Point(203, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 56);
            this.groupBox1.TabIndex = 330;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SetDo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Di);
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Location = new System.Drawing.Point(24, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 56);
            this.groupBox2.TabIndex = 331;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Di";
            // 
            // txt_Di
            // 
            this.txt_Di.Location = new System.Drawing.Point(19, 25);
            this.txt_Di.Name = "txt_Di";
            this.txt_Di.Size = new System.Drawing.Size(44, 21);
            this.txt_Di.TabIndex = 330;
            this.txt_Di.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_ResetDo);
            this.groupBox3.Controls.Add(this.button12);
            this.groupBox3.Location = new System.Drawing.Point(203, 318);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(157, 64);
            this.groupBox3.TabIndex = 332;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ResetDo";
            // 
            // txt_ResetDo
            // 
            this.txt_ResetDo.Location = new System.Drawing.Point(10, 30);
            this.txt_ResetDo.Name = "txt_ResetDo";
            this.txt_ResetDo.Size = new System.Drawing.Size(44, 21);
            this.txt_ResetDo.TabIndex = 330;
            this.txt_ResetDo.Text = "0";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(74, 25);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 28);
            this.button12.TabIndex = 329;
            this.button12.Text = "Reset Do";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(75, 428);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(153, 28);
            this.button13.TabIndex = 333;
            this.button13.Text = "Get_Current_PDO_Data";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(684, 96);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(101, 28);
            this.button14.TabIndex = 334;
            this.button14.Text = "绝对运动(点位)";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // txt_Pos
            // 
            this.txt_Pos.Location = new System.Drawing.Point(591, 101);
            this.txt_Pos.Name = "txt_Pos";
            this.txt_Pos.Size = new System.Drawing.Size(87, 21);
            this.txt_Pos.TabIndex = 335;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 336;
            this.label1.Text = "Position：";
            // 
            // lab_Position
            // 
            this.lab_Position.AutoSize = true;
            this.lab_Position.Location = new System.Drawing.Point(469, 25);
            this.lab_Position.Name = "lab_Position";
            this.lab_Position.Size = new System.Drawing.Size(11, 12);
            this.lab_Position.TabIndex = 338;
            this.lab_Position.Text = "0";
            // 
            // lab_Pos1
            // 
            this.lab_Pos1.AutoSize = true;
            this.lab_Pos1.Location = new System.Drawing.Point(469, 51);
            this.lab_Pos1.Name = "lab_Pos1";
            this.lab_Pos1.Size = new System.Drawing.Size(11, 12);
            this.lab_Pos1.TabIndex = 340;
            this.lab_Pos1.Text = "0";
            // 
            // lab_Axis
            // 
            this.lab_Axis.AutoSize = true;
            this.lab_Axis.Location = new System.Drawing.Point(137, 25);
            this.lab_Axis.Name = "lab_Axis";
            this.lab_Axis.Size = new System.Drawing.Size(53, 12);
            this.lab_Axis.TabIndex = 341;
            this.lab_Axis.Text = "Axis OFF";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(127, 208);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 28);
            this.button17.TabIndex = 342;
            this.button17.Text = "位置置零";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(399, 96);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(106, 28);
            this.button18.TabIndex = 343;
            this.button18.Text = "AxisGoHome";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 344;
            this.label2.Text = "规划位置：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 345;
            this.label3.Text = "实际位置：";
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(471, 208);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 28);
            this.button15.TabIndex = 346;
            this.button15.Text = "Thread";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 624);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.lab_Axis);
            this.Controls.Add(this.lab_Pos1);
            this.Controls.Add(this.lab_Position);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Pos);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.lab_card);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.show);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListBox show;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lab_card;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox txt_SetDo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Di;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_ResetDo;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TextBox txt_Pos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_Position;
        private System.Windows.Forms.Label lab_Pos1;
        private System.Windows.Forms.Label lab_Axis;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button15;
    }
}

