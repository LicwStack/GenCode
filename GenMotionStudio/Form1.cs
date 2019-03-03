using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace TestMotionStudio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        short Axis = 1;
        short CORE = 1;
        short sEcatSts;

        short sRtn;

        bool cardOpenSts; // 运动控制卡启用状态

        private void button1_Click(object sender, EventArgs e)
        {
            sRtn = GTN.mc.GTN_Open(5, 1);

            if (sRtn != 0)
            {
                MessageBox.Show("Failure to access card!");
                return;
            }
            cardOpenSts = true;
            lab_card.Text = "Card ON";

            //sRtn = GTN.mc.GTN_Reset(core);
            show.Items.Add(string.Format("打开控制器成功{0: T}", DateTime.Now.ToString()));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cardOpenSts)
            {
                // 打开伺服使能
                short shineng = GTN.mc.GTN_AxisOn(CORE, Axis);
                lab_Axis.Text = "Axis ON";
            }
            else { MessageBox.Show("未开启运动控制卡"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cardOpenSts)
            {
                short shineng = GTN.mc.GTN_AxisOff(CORE, Axis);
                lab_Axis.Text = "Axis OFF";
            }
            else { MessageBox.Show("未开启运动控制卡"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            short shineng = GTN.mc.GTN_Close();
            cardOpenSts = false;
            lab_card.Text = "Card OFF";
            show.Items.Add(string.Format("关闭控制器成功{0: T}", DateTime.Now.ToString()));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int doCounts = 0;
            if (cardOpenSts)
            {
                lab_Axis.Text = "Axis OFF";
                // 终止现有可能存在的连接
                sRtn = GTN.mc.GT_TerminateEcatComm();

                Invoke(new EventHandler(delegate { show.Items.Add(string.Format("新建连接:{0}   {1: T}", sRtn, DateTime.Now.ToString())); }));

                // 初始化EtherCAT总线
                sRtn = GTN.mc.GTN_InitEcatComm(CORE);
                if (sRtn != 0)
                {
                    MessageBox.Show("初始化失败:请检查Gecat.eni配置文件以及网线连接情况");
                    return;
                }

                // 查询EtherCAT通讯状态，等待EtherCAT通讯完全建立
                do
                {
                    doCounts++;
                    sRtn = GTN.mc.GTN_IsEcatReady(CORE, out sEcatSts);  // 读取EtherCAT总线状态
                    if (sEcatSts != 1 && doCounts == 3000000)
                    {
                        doCounts = 0;
                        sRtn = GTN.mc.GT_TerminateEcatComm();
                        sRtn = GTN.mc.GTN_InitEcatComm(CORE);
                    }
                } while (sEcatSts != 1);

                // 启动EtherCAT通讯
                sRtn = GTN.mc.GTN_StartEcatComm(CORE);
            }
            else { MessageBox.Show("未开启运动控制卡"); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (cardOpenSts)
            {
                sRtn = GTN.mc.GT_TerminateEcatComm();
                show.Items.Add(string.Format("关闭连接:{0}   {1: T}", sRtn, DateTime.Now.ToString()));
                lab_Axis.Text = "Axis OFF";
            }
            else { MessageBox.Show("未开启运动控制卡"); }
        }


        public bool AxisGoHome(short Axis)
        {
            // 运动控制模式
            short mode1 = 6;
            short mode2 = 8;

            short method = 3;  // 回零方式
            double speed1 = 500;  // 搜索开关速度
            double speed2 = 300;  // 搜索index标识速度
            double acc = 1;  // 搜索加速度
            Int32 offset = 0;  // 原点偏移量
            ushort probeFunction = 0; // 探针功能

            // 切换到回零模式
            sRtn = GTN.mc.GTN_SetHomingMode(CORE, Axis, mode1);
            // 设置回零参数
            sRtn = GTN.mc.GTN_SetEcatHomingPrm(CORE, Axis, method, speed1, speed2, acc, offset, probeFunction);
            // 启动回零
            sRtn = GTN.mc.GTN_StartEcatHoming(CORE, Axis);

            // 等待搜索原点完成
            //ushort sHomeSts = 0;
            //do
            //{
            //    if (GetDi_1(15)) break;
            //    sRtn = GTN.mc.GTN_GetEcatHomingStatus(CORE, Axis, out sHomeSts);

            //} while (sHomeSts != 3);

            //// 切换到位置控制模式
            //sRtn = GTN.mc.GTN_SetHomingMode(CORE, Axis, mode2);

            return true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AxisGoHome(1);

            ushort sHomeSts = 0;
            
            sRtn = GTN.mc.GTN_GetEcatHomingStatus(CORE, Axis, out sHomeSts);

            if (sHomeSts == 3)
            {
                MessageBox.Show("回原点成功");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sRtn = GTN.mc.GTN_Stop(CORE, 1 << (Axis - 1), 0);   // 平滑停止
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sRtn = GTN.mc.GTN_Stop(CORE, 1 << (Axis - 1), 1);   // 急停
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ushort Di_N = System.Convert.ToUInt16(txt_Di.Text.ToString().Trim());

            GetDi(Di_N);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ushort Do_N = System.Convert.ToUInt16(txt_SetDo.Text.ToString().Trim());

            SetDo(Do_N);
        }

        public void GetDi(ushort Di_N)
        {
            ushort slave = 1;
            ushort offset = 2;
            ushort nSize = 2;

            byte[] pValue = new byte[2];

            sRtn = GTN.mc.GTN_EcatIOReadInput(CORE, slave, offset, nSize, out pValue[0]);


            string strResultDi = string.Empty;
            string strTempDo;
            for (int i = 0; i < pValue.Length; i++)
            {
                strTempDo = System.Convert.ToString(pValue[pValue.Length - i -1], 2);
                strTempDo = strTempDo.Insert(0, new string('0', 8 - strTempDo.Length));

                strResultDi += strTempDo;
            }

            int Di = System.Convert.ToInt32(strResultDi, 2);

            if ((Di & (1 << Di_N)) > 0)
            {
                MessageBox.Show("Get Di_" + Di_N);
                //return true;
            }
            else 
            {
                MessageBox.Show("Di_" + Di_N + "没有输入");
                //return false;
            }
        }

        public bool GetDi_1(ushort Di_N)
        {
            ushort slave = 1;
            ushort offset = 2;
            ushort nSize = 2;

            byte[] pValue = new byte[2];

            sRtn = GTN.mc.GTN_EcatIOReadInput(CORE, slave, offset, nSize, out pValue[0]);


            string strResultDi = string.Empty;
            string strTempDo;
            for (int i = 0; i < pValue.Length; i++)
            {
                strTempDo = System.Convert.ToString(pValue[pValue.Length - i - 1], 2);
                strTempDo = strTempDo.Insert(0, new string('0', 8 - strTempDo.Length));

                strResultDi += strTempDo;
            }

            int Di = System.Convert.ToInt32(strResultDi, 2);

            if ((Di & (1 << Di_N)) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void SetDo(ushort Do_N)
        {
            ushort slave = 1;

            ushort offset = 0;
            ushort nSize = 2;
            byte[] pDo = new byte[2];

            sRtn = GTN.mc.GTN_GetEcatRawData(CORE, 12, 2, out pDo[0]);

            if (Do_N > 7)
            {
                pDo[1] = (byte)((pDo[1]) | (1 << (Do_N - 8)));
            }
            else
            {
                pDo[0] = (byte)((pDo[0]) | (1 << Do_N));
            }

            sRtn = GTN.mc.GTN_EcatIOWriteOutput(CORE, slave, offset, nSize, ref pDo[0]);
        }

        public void ResetDo(ushort Do_N)
        {
            ushort slave = 1;
            ushort offset = 0;
            ushort nSize = 2;
            byte[] pDo = new byte[2];

            sRtn = GTN.mc.GTN_GetEcatRawData(CORE, 12, 2, out pDo[0]);

            if (Do_N > 7)
            {
                pDo[1] = (byte)((pDo[1]) & ~(1 << (Do_N - 8)));
            }
            else
            {
                pDo[0] = (byte)((pDo[0]) & ~(1 << Do_N));
            }

            sRtn = GTN.mc.GTN_EcatIOWriteOutput(CORE, slave, offset, nSize, ref pDo[0]);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ushort Do_N = System.Convert.ToUInt16(txt_ResetDo.Text.ToString().Trim());

            ResetDo(Do_N);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            byte[] pDo = new byte[2];
            byte[] pDi = new byte[2];

            // Do
            sRtn = GTN.mc.GTN_GetEcatRawData(CORE, 12, 2, out pDo[0]);

            string strResultDo = string.Empty;
            string strTempDo;
            for (int i = 0; i < pDo.Length; i++)
            {
                strTempDo = System.Convert.ToString(pDo[pDo.Length - i - 1], 2);
                strTempDo = strTempDo.Insert(0, new string('0', 8 - strTempDo.Length));

                strResultDo += strTempDo;
            }

            MessageBox.Show("Do15_Do0: " + strResultDo);

            // Di
            sRtn = GTN.mc.GTN_GetEcatRawData(CORE, 14, 2, out pDi[0]);

            string strResultDi = string.Empty;
            string strTempDi;
            for (int i = 0; i < pDi.Length; i++)
            {
                strTempDi = System.Convert.ToString(pDi[pDi.Length - i - 1], 2);
                strTempDi = strTempDi.Insert(0, new string('0', 8 - strTempDi.Length));

                strResultDi += strTempDi;
            }

            MessageBox.Show("Di15_Di0: " + strResultDi);
        }

        //  点位运动
        public void Trap(int Pos)
        {
            GTN.mc.TTrapPrm trap;

            trap.acc = 1;
            trap.dec = 1;
            trap.smoothTime = 1;
            trap.velStart = 0;

            double Vel = 500;  // 速度

            // 设置为点位运动模式
            sRtn = GTN.mc.GTN_PrfTrap(CORE, Axis);
            // 设置点位运动参数
            sRtn = GTN.mc.GTN_SetTrapPrm(CORE, Axis, ref trap);
            // 设置 AXIS 轴的目标位置
            sRtn = GTN.mc.GTN_SetPos(CORE, Axis, Pos);
            // 设置AXIS轴的目标速度
            sRtn = GTN.mc.GTN_SetVel(CORE, Axis, Vel);
            // 启动AXIS轴的运动
            sRtn = GTN.mc.GTN_Update(CORE, 1 << (Axis - 1));
        }


        // Jog运动
        public void Jog()
        {
            GTN.mc.TJogPrm jog;

            jog.acc = 0.0625;
            jog.dec = 0.0625;
            jog.smooth = 0;

            double Vel = 500;  // 速度

            // 将 AXIS 轴设为 Jog 模式
            sRtn = GTN.mc.GTN_PrfJog(1, Axis);
            // 设置 Jog 运动参数
            sRtn = GTN.mc.GTN_SetJogPrm(1, Axis, ref jog);
            // 设置 AXIS 轴的目标速度
            sRtn = GTN.mc.GTN_SetVel(1, Axis, Vel);
            // 启动AXIS轴的运动
            sRtn = GTN.mc.GTN_Update(CORE, 1 << (Axis - 1));
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int Position = System.Convert.ToInt32(txt_Pos.Text.ToString().Trim());
            Trap(Position);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double prfpos;
            uint clk;
            sRtn = GTN.mc.GTN_GetPrfPos(CORE, Axis, out prfpos, 1, out clk);
            lab_Position.Text = prfpos.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double encpos;
            uint clk;
            sRtn = GTN.mc.GTN_GetEncPos(CORE, Axis, out encpos, 1, out clk);
            lab_Pos1.Text = encpos.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double prfpos;
            uint clk;
            sRtn = GTN.mc.GTN_GetPrfPos(CORE, Axis, out prfpos, 1, out clk);
            lab_Position.Text = prfpos.ToString();

            double encpos;
            sRtn = GTN.mc.GTN_GetEncPos(CORE, Axis, out encpos, 1, out clk);
            lab_Pos1.Text = encpos.ToString();

        }

        private void button17_Click(object sender, EventArgs e)
        {
            // 清零规划位置和实际位置
            sRtn = GTN.mc.GTN_ZeroPos(CORE, Axis, 1);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (AxisGoHome(1))
            {
                // 清零规划位置和实际位置
                sRtn = GTN.mc.GTN_ZeroPos(CORE, Axis, 1);
            }
        }

        private Thread thread;

        bool ThreadStart = false;
        private void button15_Click_1(object sender, EventArgs e)
        {
            if (!ThreadStart)
            {
                StartWork();
                ThreadStart = true;
            }
        }

        private void StartWork()
        {
            thread = new Thread(DoWork);
            thread.Start();
        }

        private void DoWork()
        {
            while (true)
            {
                if (GetDi_1(1)) // 获取信号
                {
                    AxisGoHome(1);
                }
                if (GetDi_1(15)) 
                {
                    sRtn = GTN.mc.GTN_Stop(CORE, 1 << (Axis - 1), 1);   // 急停
                }

            }
        }

    }
}
