using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 

        private void SUN_Click(object sender, EventArgs e)
        {
            if (Helper.GetPidByProcessName(processName) == 0)
            {
                MessageBox.Show("运行辅助前请先运行游戏！");
                return;
            }
            //获取无限阳光
            int address = ReadMemoryValue(baseAddress);            
            address = address + 0x768;                              
            address = ReadMemoryValue(address);
            address = address + 0x5560;                            
            WriteMemory(address, 0x270F);                      
            
        }
        private void getmoney_Click(object sender, EventArgs e)
        {
            if (Helper.GetPidByProcessName(processName) == 0)
            {
                MessageBox.Show("运行辅助前请先运行游戏！");
                return;
            }
            //获取无限金币
            int address = ReadMemoryValue(baseAddress);
            address = address + 0x82C;
            address = ReadMemoryValue(address);
            address = address + 0x28;
            WriteMemory(address, 0x270F);

        }
        private void Autosunn_Click(object sender, EventArgs e)
        {
            if (Helper.GetPidByProcessName(processName) == 0)
            {
                MessageBox.Show("运行辅助前请先运行游戏！");
                return;
            }
            //自动拾取阳光
            byte[] data = { 0xEB };
            Helper.WritetoMemoryValue(0x43158f, processName, data);
        }

        private void freePalnt_Click(object sender, EventArgs e)
        {
            if (Helper.GetPidByProcessName(processName) == 0)
            {
                MessageBox.Show("运行辅助前请先运行游戏！");
                return;
            }
            // 免费种植物
            byte[] data = { 0x90, 0x90 };
            Helper.WritetoMemoryValue(0x41BA74, processName, data);
        }

        private void Kill_Click(object sender, EventArgs e)
        {
            if (Helper.GetPidByProcessName(processName) == 0)
            {
                MessageBox.Show("运行辅助前请先运行游戏！");
                return;
            }
            // 秒杀普通僵尸
            //53130F 2B7C2420   sub edi,dword ptr ss:[esp+20]--->33FF 9090 xor edi,edi nop nop
            byte[] data1 = { 0x33, 0xFF, 0x90, 0x90 };
            Helper.WritetoMemoryValue(0x53130F, processName, data1);
            byte[] data2 = { 0x90, 0x90 };
            //秒杀不普通僵尸
            //0x53186D  7E 08-->0x90 0x90
            //0x531858 7E  1D--->0x90 0x90
            Helper.WritetoMemoryValue(0x53186D, processName, data2); 
            Helper.WritetoMemoryValue(0x531858, processName, data2);


        }
        private void plantnocd_Click(object sender, EventArgs e)
        {
            if (Helper.GetPidByProcessName(processName) == 0)
            {
                MessageBox.Show("运行辅助前请先运行游戏！");
                return;
            }
            //植物无冷却
            byte[] data = { 0x75, 0x20 };
            //0x48728A 74 20 je --->75 20 jne
            Helper.WritetoMemoryValue(0x48728A, processName, data);

        }
        private void shorttime_Click(object sender, EventArgs e)
        {
            if (Helper.GetPidByProcessName(processName) == 0)
            {
                MessageBox.Show("运行辅助前请先运行游戏！");
                return;
            }
            //缩短植物冷却时间
            byte[] data = { 0x83, 0x47, 0x24, 0x50 };
            //0x48728c 8347 24 01 add dword ptr ds:[edi+24],1 --->834724  50 add dword ptr ds:[edi+24],0x50
            Helper.WritetoMemoryValue(0x48728c, processName, data);

        }
        private void select_Click(object sender, EventArgs e)
        {
            if (Helper.GetPidByProcessName(processName) == 0)
            {
                MessageBox.Show("运行辅助前请先运行游戏！");
                return;
            }
            int address = ReadMemoryValue(baseAddress);          
            address = address + 0x82C;                             
            address = ReadMemoryValue(address);
            address = address + 0x24;
            int lev = 1;
            try
            {
                lev = int.Parse(textBox1.Text.Trim());
                Console.WriteLine(lev);
            }
            catch
            {
                MessageBox.Show("输入格式不正确！");
            }

            WriteMemory(address, lev);

        }
        private void recover_Click(object sender, EventArgs e)
        {
            //植物冷却时间

            byte[] data1 = { 0x83, 0x47, 0x24, 0x01 };
            Helper.WritetoMemoryValue(0x48728c, processName, data1);
            //植物无冷却
            byte[] data2 = { 0x74, 0x20 };
            //0x48728A 74 20 je --->75 20 jne
            Helper.WritetoMemoryValue(0x48728A, processName, data2);
            // 秒杀普通僵尸
            //53130F 2B7C2420   sub edi,dword ptr ss:[esp+20]--->33FF 9090 xor edi,edi nop nop
            byte[] data3 = { 0x2B, 0x7C, 0x24, 0x20 };
            Helper.WritetoMemoryValue(0x53130F, processName, data3);
            byte[] data4 = { 0x7E, 0x08 };
            byte[] data5 = { 0x7E, 0x1D };
            //秒杀不普通僵尸
            //0x53186D  7E 08-->0x90 0x90
            //0x531858 7E  1D--->0x90 0x90
            Helper.WritetoMemoryValue(0x53186D, processName, data4);
            Helper.WritetoMemoryValue(0x531858, processName, data5);
            // 免费种植物
            byte[] data6 = { 0x2B, 0xF3 };
            Helper.WritetoMemoryValue(0x41BA74, processName, data6);
            //自动拾取阳光
            byte[] data7 = { 0x75 };
            Helper.WritetoMemoryValue(0x43158f, processName, data7);



        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("[1]在主菜单页面，开始关卡之前设置，进入关卡后点击重玩游戏\n[2]在游戏中途想改关卡，可以在游戏进行中设置目标关卡,点击重玩游戏，或者回退到主菜单\n[3]关卡默认值为1\n");

        }


        public int ReadMemoryValue(int baseAdd)
        {
            return Helper.ReadMemoryValue(baseAdd, processName);
        }

        
        public void WriteMemory(int baseAdd, int value)
        {
            Helper.WriteMemoryValue(baseAdd, processName, value);
        }

        private int baseAddress = 0x006A9EC0;           //游戏内存基址
        private string processName = "PlantsVsZombies"; //游戏进程名字

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            // 创建the ToolTip 
            ToolTip toolTip1 = new ToolTip();

            // 设置显示样式
            toolTip1.AutoPopDelay = 5000;//提示信息的可见时间
            toolTip1.InitialDelay = 500;//事件触发多久后出现提示
            toolTip1.ReshowDelay = 500;//指针从一个控件移向另一个控件时，经过多久才会显示下一个提示框
            toolTip1.ShowAlways = true;//是否显示提示框

            //  设置伴随的对象.
            
            toolTip1.SetToolTip(this.select, "设置关卡之后点击");
            toolTip1.SetToolTip(this.plantnocd, "在刚进入游戏，所有卡片第一次冷却时间都过了之后点击");
        }

       
    }
}
