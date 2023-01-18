using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Resources;
using System.Reflection;
using System.Net;
using System.Threading;
using System.Diagnostics;
using UHF;
using System.IO;
using System.Net.Sockets;
using System.Runtime.InteropServices;
namespace UHFReader288Demo
{
    public partial class Form1 : Form
    {
        [DllImport("User32.dll", EntryPoint = "PostMessage")]
        private static extern int PostMessage(
        IntPtr hWnd, // handle to destination window 
        uint Msg, // message 
        uint wParam, // first message parameter 
        uint lParam // second message parameter 
        );

        [DllImport("User32.dll", EntryPoint = "SendMessage")]
        private static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, string lParam);

        [DllImport("User32.dll", EntryPoint = "FindWindow")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        public const int USER = 0x0400;
        public const int WM_SENDTAG = USER + 101;
        public const int WM_SENDTAGSTAT = USER + 102;
        public const int WM_SENDSTATU = USER + 103;
        public const int WM_SENDBUFF = USER + 104;

        private byte fComAdr = 0xff; //当前操作的ComAdr
        private int ferrorcode;
        private byte fBaud;
        private double fdminfre;
        private double fdmaxfre;
        private int fCmdRet = 30; //所有执行指令的返回值
        private bool fisinventoryscan_6B;
        private byte[] fOperEPC = new byte[100];
        private byte[] fPassWord = new byte[4];
        private byte[] fOperID_6B = new byte[10];
        ArrayList list = new ArrayList();
        private int CardNum1 = 0;
        private string fInventory_EPC_List; //存贮询查列表（如果读取的数据没有变化，则不进行刷新）
        private int frmcomportindex;
        private bool SeriaATflag = false;
        private byte Target = 0;
        private byte InAnt = 0;
        private byte Scantime = 0;
        private byte FastFlag = 0;
        private byte Qvalue = 0;
        private byte Session = 0;
        private int total_turns = 0;//轮数
        private int total_tagnum = 0;//标签数量
        private int total_time = 0;//总时间
        private int targettimes = 0;
        private byte TIDFlag = 0;
        public static byte antinfo = 0;
        private int AA_times = 0;
        private int CommunicationTime = 0;
        public DeviceClass SelectedDevice;
        private static List<DeviceClass> DevList;
        private static SearchCallBack searchCallBack = new SearchCallBack(searchCB);
        private string ReadTypes = "";
        /// <summary>
        /// Device Search的回调函数;
        /// </summary>
        private static void searchCB(IntPtr dev, IntPtr data)
        {
            uint ipAddr = 0;
            StringBuilder devname = new StringBuilder(100);
            StringBuilder macAdd = new StringBuilder(100);
            //获取搜索到的设备信息；
            DevControl.tagErrorCode eCode = DevControl.DM_GetDeviceInfo(dev, ref ipAddr, macAdd, devname);
            if (eCode == DevControl.tagErrorCode.DM_ERR_OK)
            {
                //将搜索到的设备加入设备列表；
                DeviceClass device = new DeviceClass(dev, ipAddr, macAdd.ToString(), devname.ToString());
                DevList.Add(device);
            }
            else
            {
                //异常处理；
                string errMsg = ErrorHandling.GetErrorMsg(eCode);
                Log.WriteError(errMsg);
            }

        }
        private static IPAddress getIPAddress(uint interIP)
        {
            return new IPAddress((uint)IPAddress.HostToNetworkOrder((int)interIP));
        }
        public Form1()
        {
            InitializeComponent();
            //初始化设备列表；
            DevList = new List<DeviceClass>();

            //初始化设备控制模块；
            DevControl.tagErrorCode eCode = DevControl.DM_Init(searchCallBack, IntPtr.Zero);
            if (eCode != DevControl.tagErrorCode.DM_ERR_OK)
            {
                //如果初始化失败则关闭程序，并进行异常处理；
                string errMsg = ErrorHandling.HandleError(eCode);
                throw new Exception(errMsg);
            }
        }
        protected override void DefWndProc(ref Message m)
        {
            if (m.Msg == WM_SENDTAG)
            {
                string tagInfo = Marshal.PtrToStringAnsi(m.LParam);
                string sEPC;
                int index = tagInfo.IndexOf(',');
                sEPC = tagInfo.Substring(0, index);
                index++;
                string RSSI = tagInfo.Substring(index);

                DataTable dt = dataGridView1.DataSource as DataTable;

                if (dt == null)
                {
                    dt = new DataTable();
                    dt.Columns.Add("Column1", Type.GetType("System.String"));
                    dt.Columns.Add("Column2", Type.GetType("System.String"));
                    dt.Columns.Add("Column3", Type.GetType("System.String"));
                    dt.Columns.Add("Column4", Type.GetType("System.String"));
                    DataRow dr = dt.NewRow();
                    dr["Column1"] = (dt.Rows.Count + 1).ToString();
                    dr["Column2"] = sEPC;
                    dr["Column3"] = "1";
                    dr["Column4"] = RSSI;
                    dt.Rows.Add(dr);
                    lxLedControl1.Text = dt.Rows.Count.ToString();
                    lxLedControl5.Text = dt.Rows.Count.ToString();
                    comboBox_EPC.Items.Add(sEPC);
                }
                else
                {
                    DataRow[] dr;
                    dr = dt.Select("Column2='" + sEPC + "'");
                    if (dr.Length == 0)     // epc号不存在
                    {
                        DataRow dr2 = dt.NewRow();
                        dr2["Column1"] = (dt.Rows.Count + 1).ToString();
                        dr2["Column2"] = sEPC;
                        dr2["Column3"] = "1";
                        dr2["Column4"] = RSSI;
                        dt.Rows.Add(dr2);
                        lxLedControl1.Text = dt.Rows.Count.ToString();
                        lxLedControl5.Text = (System.Environment.TickCount - total_time).ToString();
                        comboBox_EPC.Items.Add(sEPC);
                    }
                    else     // epc号已存在
                    {
                        int cnt = int.Parse(dr[0]["Column3"].ToString());
                        cnt++;
                        dt.Rows[dt.Rows.IndexOf(dr[0])]["Column3"] = cnt.ToString();
                    }
                }
                bool flagset = false;
                flagset = (dataGridView1.DataSource == null) ? true : false;
                dataGridView1.DataSource = dt;

                if (flagset)
                {
                    dataGridView1.Columns["Column1"].HeaderText = "No.";
                    dataGridView1.Columns["Column1"].Width = 80;
                    dataGridView1.Columns["Column2"].HeaderText = "EPC";
                    dataGridView1.Columns["Column2"].Width = 380;
                    dataGridView1.Columns["Column3"].HeaderText = "Times";
                    dataGridView1.Columns["Column3"].Width = 100;
                    dataGridView1.Columns["Column4"].HeaderText = "RSSI";
                    dataGridView1.Columns["Column4"].Width = 100;
                }
            }
            else if (m.Msg == WM_SENDTAGSTAT)
            {
                string tagInfo = Marshal.PtrToStringAnsi(m.LParam);
                int index = tagInfo.IndexOf(',');
                string tagRate = tagInfo.Substring(0, index);
                index++;
                string str = tagInfo.Substring(index);
                index = str.IndexOf(',');
                string tagNum = str.Substring(0, index);
                index++;
                string cmdTime = str.Substring(index);

                lxLedControl2.Text = tagRate;
                lxLedControl3.Text = cmdTime;
                lxLedControl4.Text = tagNum;
                string strLog = "Inventory success ";
                WriteLog(lrtxtLog, strLog, 1);
            }
            else if (m.Msg == WM_SENDSTATU)
            {
                string Info = Marshal.PtrToStringAnsi(m.LParam);
                fCmdRet = Convert.ToInt32(Info);
                string strLog = "Inventory: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else if (m.Msg == WM_SENDBUFF)
            {
                string tagInfo = Marshal.PtrToStringAnsi(m.LParam);
                int index = tagInfo.IndexOf(',');
                string tagNum = tagInfo.Substring(0, index);
                index++;

                string str = tagInfo.Substring(index);
                index = str.IndexOf(',');
                string cmdTime = str.Substring(0, index);
                index++;

                str = str.Substring(index);
                index = str.IndexOf(',');
                string tagRate = str.Substring(0, index);
                index++;

                str = str.Substring(index);
                string total_tagnum = str;

                lxLed_BNum.Text = tagNum;
                lxLed_Bcmdsud.Text = tagRate;
                lxLed_cmdTime.Text = cmdTime;
                lxLed_Btoltag.Text = total_tagnum;
                WriteLog(lrtxtLog, "Buffer-Inventiry:Operation success", 1);
            }
            else
                base.DefWndProc(ref m);
        }

        private delegate void WriteLogUnSafe(CustomControl.LogRichTextBox logRichTxt, string strLog, int nType);
        private void WriteLog(CustomControl.LogRichTextBox logRichTxt, string strLog, int nType)
        {
            if (this.InvokeRequired)
            {
                WriteLogUnSafe InvokeWriteLog = new WriteLogUnSafe(WriteLog);
                this.Invoke(InvokeWriteLog, new object[] { logRichTxt, strLog, nType });
            }
            else
            {
                if ((nType == 0) || (nType == 0x26) || (nType == 0x01) || (nType == 0x02) || (nType == 0xFB))
                {
                    logRichTxt.AppendTextEx(strLog, Color.Indigo);
                }
                else
                {
                    logRichTxt.AppendTextEx(strLog, Color.Red);
                }

                logRichTxt.Select(logRichTxt.TextLength, 0);
                logRichTxt.ScrollToCaret();
            }
        }
        /// <summary>
        /// 16进制数组字符串转换
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>

        #region 
        public static byte[] HexStringToByteArray(string s)
        {
            s = s.Replace(" ", "");
            byte[] buffer = new byte[s.Length / 2];
            for (int i = 0; i < s.Length; i += 2)
                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
            return buffer;
        }

        public static string ByteArrayToHexString(byte[] data)
        {
            StringBuilder sb = new StringBuilder(data.Length * 3);
            foreach (byte b in data)
                sb.Append(Convert.ToString(b, 16).PadLeft(2, '0'));
            return sb.ToString().ToUpper();

        }
        #endregion
        /// <summary>
        /// 错误代码
        /// </summary>
        /// <param name="cmdRet"></param>
        /// <returns></returns>
        #region 
        private string GetReturnCodeDesc(int cmdRet)
        {
            switch (cmdRet)
            {
                case 0x00:
                case 0x26:
                    return "successfully";
                case 0x01:
                    return "Return before Inventory finished";
                case 0x02:
                    return "the Inventory-scan-time overflow";
                case 0x03:
                    return "More Data";
                case 0x04:
                    return "Reader module MCU is Full";
                case 0x05:
                    return "Access Password Error";
                case 0x09:
                    return "Destroy Password Error";
                case 0x0a:
                    return "Destroy Password Error Cannot be Zero";
                case 0x0b:
                    return "Tag Not Support the command";
                case 0x0c:
                    return "Use the commmand,Access Password Cannot be Zero";
                case 0x0d:
                    return "Tag is protected,cannot set it again";
                case 0x0e:
                    return "Tag is unprotected,no need to reset it";
                case 0x10:
                    return "There is some locked bytes,write fail";
                case 0x11:
                    return "can not lock it";
                case 0x12:
                    return "is locked,cannot lock it again";
                case 0x13:
                    return "Parameter Save Fail,Can Use Before Power";
                case 0x14:
                    return "Cannot adjust";
                case 0x15:
                    return "Return before Inventory finished";
                case 0x16:
                    return "Inventory-Scan-Time overflow";
                case 0x17:
                    return "More Data";
                case 0x18:
                    return "Reader module MCU is full";
                case 0x19:
                    return "'Not Support Command Or AccessPassword Cannot be Zero";
                case 0x1A:
                    return "Tag custom function error";
                case 0xF8:
                    return "Check antenna error";
                case 0xF9:
                    return "Command execute error";
                case 0xFA:
                    return "Get Tag,Poor Communication,Inoperable";
                case 0xFB:
                    return "No Tag Operable";
                case 0xFC:
                    return "Tag Return ErrorCode";
                case 0xFD:
                    return "Command length wrong";
                case 0xFE:
                    return "Illegal command";
                case 0xFF:
                    return "Parameter Error";
                case 0x30:
                    return "Communication error";
                case 0x31:
                    return "CRC checksummat error";
                case 0x32:
                    return "Return data length error";
                case 0x33:
                    return "Communication busy";
                case 0x34:
                    return "Busy,command is being executed";
                case 0x35:
                    return "ComPort Opened";
                case 0x36:
                    return "ComPort Closed";
                case 0x37:
                    return "Invalid Handle";
                case 0x38:
                    return "Invalid Port";
                case 0xEE:
                    return "Return Command Error";
                default:
                    return "";
            }
        }
        private string GetErrorCodeDesc(int cmdRet)
        {
            switch (cmdRet)
            {
                case 0x00:
                    return "Other error";
                case 0x03:
                    return "Memory out or pc not support";
                case 0x04:
                    return "Memory Locked and unwritable";
                case 0x0b:
                    return "No Power,memory write operation cannot be executed";
                case 0x0f:
                    return "Not Special Error,tag not support special errorcode";
                default:
                    return "";
            }
        }
        #endregion
        private void DisabledForm()
        {
            ////应答模式下
            lxLedControl1.Text = "0";
            lxLedControl2.Text = "0";
            lxLedControl3.Text = "0";
            lxLedControl4.Text = "0";
            lxLedControl5.Text = "0";
            dataGridView1.DataSource = null;
            dataGridView2.Rows.Clear();
            comboBox_EPC.Items.Clear();
            text_RDVersion.Text = "";
            text_MDVersion.Text = "";
            text_Serial.Text = "";
            timer_answer.Enabled = false;
            btIventoryG2.Text = "Start";
            panel1.Enabled = false;
            panel2.Enabled = false;
            panel3.Enabled = false;
            panel4.Enabled = false;
            panel5.Enabled = false;
            panel6.Enabled = false;
            panel8.Enabled = false;
            panel9.Enabled = false;
            panel10.Enabled = false;
            gpb_address.Enabled = false;
            gpb_antconfig.Enabled = false;
            gpb_baud.Enabled = false;
            gpb_GPIO.Enabled = false;
            gpb_beep.Enabled = false;
            gpb_MDVersion.Enabled = false;
            gpb_RDVersion.Enabled = false;
            gpb_checkant.Enabled = false;
            gpb_DBM.Enabled = false;
            gpb_clock.Enabled = false;
            gpb_Serial.Enabled = false;
            gpb_Relay.Enabled = false;
            gpb_OutputRep.Enabled = false;
            gpb_Freq.Enabled = false;
            gbp_buff.Enabled = false;
            btDefault.Enabled = false;
            btGetInformation.Enabled = false;
            btFlashROM.Enabled = false;
            group_maxtime.Enabled = false;
        }
        private void EnabledForm()
        {
            panel1.Enabled = true;
            panel2.Enabled = true;
            panel3.Enabled = true;
            panel4.Enabled = true;
            panel5.Enabled = true;
            panel6.Enabled = true;
            panel8.Enabled = true;
            panel9.Enabled = true;
            panel10.Enabled = true;
            gpb_address.Enabled = true;
            gpb_antconfig.Enabled = true;
            gpb_baud.Enabled = true;
            gpb_GPIO.Enabled = true;
            gpb_beep.Enabled = true;
            gpb_MDVersion.Enabled = true;
            gpb_RDVersion.Enabled = true;
            gpb_checkant.Enabled = true;
            gpb_DBM.Enabled = true;
            gpb_clock.Enabled = true;
            gpb_Serial.Enabled = true;
            gpb_Relay.Enabled = true;
            gpb_OutputRep.Enabled = true;
            gpb_Freq.Enabled = true;
            gbp_buff.Enabled = true;
            btDefault.Enabled = true;
            btGetInformation.Enabled = true;
            btFlashROM.Enabled = true;
            group_maxtime.Enabled = true;

        }
        private void rb_rs232_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_rs232.Checked)
            {
                if (frmcomportindex > 1024)
                    btDisConnectTcp_Click(null, null);
                gpb_rs232.Enabled = true;
                btDisConnect232.Enabled = false;
                //设置按钮字体颜色
                btConnect232.ForeColor = Color.Indigo;
                SetButtonBold(btConnect232);
                if (btConnectTcp.Font.Bold)
                {
                    SetButtonBold(btConnectTcp);
                }
                gpb_tcp.Enabled = false;
            }
        }

        private void rb_tcp_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_tcp.Checked)
            {
                if ((frmcomportindex > 0) && (frmcomportindex < 256))
                    btDisConnect232_Click(null, null);
                gpb_tcp.Enabled = true;
                btDisConnectTcp.Enabled = false;
                //设置按钮字体颜色
                btConnectTcp.ForeColor = Color.Indigo;
                if (btConnect232.Font.Bold)
                {
                    SetButtonBold(btConnect232);
                }
                SetButtonBold(btConnectTcp);

                gpb_rs232.Enabled = false;
            }
        }
        private void SetButtonBold(Button btnBold)
        {
            Font oldFont = btnBold.Font;
            Font newFont = new Font(oldFont, oldFont.Style ^ FontStyle.Bold);
            btnBold.Font = newFont;
        }

        private void SetRadioButtonBold(CheckBox ckBold)
        {
            Font oldFont = ckBold.Font;
            Font newFont = new Font(oldFont, oldFont.Style ^ FontStyle.Bold);
            ckBold.Font = newFont;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gpb_rs232.Enabled = false;
            gpb_tcp.Enabled = false;
            rb_rs232.Checked = true;
            ComboBox_COM.SelectedIndex = 0;
            ComboBox_baud2.SelectedIndex = 3;
            com_Q.SelectedIndex = 4;
            com_Target.SelectedIndex = 0;
            int i = 0;
            for (i = 0x03; i <= 0xff; i++)
            {
                com_scantime.Items.Add(Convert.ToString(i) + "*100ms");
                comboBox_maxtime.Items.Add(Convert.ToString(i) + "*100ms");
            }
            com_scantime.SelectedIndex = 17;
            comboBox_maxtime.SelectedIndex = 17;
            com_S.SelectedIndex = 4;
            DisabledForm();
            radioButton_band2.Checked = true;
            ComboBox_baud.SelectedIndex = 3;
            ComboBox_PowerDbm.SelectedIndex = 30;
            com_acQ.SelectedIndex = 6;
            com_acS.SelectedIndex = 0;
            ComboBox_Accuracy.SelectedIndex = 8;
            comboBox_intervalT.SelectedIndex = 0;
            for (i = 0; i < 256; i++)
            {
                comboBox_trigger.Items.Add(Convert.ToString(i));
                comboBox_RespTime.Items.Add(Convert.ToString(i));
                com_MFliterTime.Items.Add(i.ToString() + "*1s");
            }
            for (i = 1; i < 256; i++)
            {
                ComboBox_RelayTime.Items.Add(Convert.ToString(i));
            }
            ComboBox_RelayTime.SelectedIndex = 0;
            comboBox_trigger.SelectedIndex = 0;
            comboBox_Resp.SelectedIndex = 1;
            comboBox_RespTime.SelectedIndex = 0;
            comboBox_mode.SelectedIndex = 0;
            com_MFliterTime.SelectedIndex = 0;
            COM_MRPTime.SelectedIndex = 0;
            com_MQ.SelectedIndex = 4;
            com_MS.SelectedIndex = 4;
            com_Mmode.SelectedIndex = 0;
        }

        private void btConnect232_Click(object sender, EventArgs e)
        {
            int portNum = ComboBox_COM.SelectedIndex + 1;
            int FrmPortIndex = 0;
            string strException = string.Empty;
            fBaud = Convert.ToByte(ComboBox_baud2.SelectedIndex);
            if (fBaud > 2)
                fBaud = Convert.ToByte(fBaud + 2);
            fComAdr = 255;//广播地址打开设备
            fCmdRet = RWDev.OpenComPort(portNum, ref fComAdr, fBaud, ref FrmPortIndex);
            if (fCmdRet != 0)
            {
                string strLog = "Connect reader failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
                return;
            }
            else
            {
                frmcomportindex = FrmPortIndex;
                string strLog = "Connect: " + ComboBox_COM.Text + "@" + ComboBox_baud2.Text;
                WriteLog(lrtxtLog, strLog, 0);
            }

            //处理界面元素是否有效
            EnabledForm();
            btConnect232.Enabled = false;
            btDisConnect232.Enabled = true;
            //设置按钮字体颜色
            btConnect232.ForeColor = Color.Black;
            btDisConnect232.ForeColor = Color.Indigo;
            SetButtonBold(btConnect232);
            SetButtonBold(btDisConnect232);
            btGetInformation_Click(null, null);//获取读写器信息
        }

        private void btDisConnect232_Click(object sender, EventArgs e)
        {
            if (frmcomportindex > 0)
                fCmdRet = RWDev.CloseSpecComPort(frmcomportindex);
            if (fCmdRet == 0) frmcomportindex = -1;
            DisabledForm();
            btConnect232.Enabled = true;
            btDisConnect232.Enabled = false;

            btConnect232.ForeColor = Color.Indigo;
            btDisConnect232.ForeColor = Color.Black;
            SetButtonBold(btConnect232);
            SetButtonBold(btDisConnect232);

        }

        private void btDisConnectTcp_Click(object sender, EventArgs e)
        {
            if (frmcomportindex > 1023)
                fCmdRet = RWDev.CloseNetPort(frmcomportindex);
            if (fCmdRet == 0) frmcomportindex = -1;
            btConnectTcp.Enabled = true;
            btDisConnectTcp.Enabled = false;
            DisabledForm();
            btConnectTcp.ForeColor = Color.Indigo;
            btDisConnectTcp.ForeColor = Color.Black;
            SetButtonBold(btConnectTcp);
            SetButtonBold(btDisConnectTcp);
        }

        private void btConnectTcp_Click(object sender, EventArgs e)
        {
            try
            {
                string strException = string.Empty;
                string ipAddress = ipServerIP.IpAddressStr;
                int nPort = Convert.ToInt32(tb_Port.Text);
                fComAdr = 255;
                int FrmPortIndex = 0;
                fCmdRet = RWDev.OpenNetPort(nPort, ipAddress, ref fComAdr, ref FrmPortIndex);
                if (fCmdRet != 0)
                {
                    string strLog = "Connect reader failed: " + GetReturnCodeDesc(fCmdRet);
                    WriteLog(lrtxtLog, strLog, 1);
                    return;
                }
                else
                {
                    frmcomportindex = FrmPortIndex;
                    string strLog = "Connect: " + ipAddress + "@" + nPort.ToString();
                    WriteLog(lrtxtLog, strLog, 0);
                }

                EnabledForm();
                btConnectTcp.Enabled = false;
                btDisConnectTcp.Enabled = true;

                //设置按钮字体颜色
                btConnectTcp.ForeColor = Color.Black;
                btDisConnectTcp.ForeColor = Color.Indigo;
                SetButtonBold(btConnectTcp);
                SetButtonBold(btDisConnectTcp);
                btGetInformation_Click(null, null);//获取读写器信息
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btFlashCl_Click(object sender, EventArgs e)
        {
            ////应答模式下刷屏
            if (tabControl2.SelectedTab == tabPage_answer)
            {
                lxLedControl1.Text = "0";
                lxLedControl2.Text = "0";
                lxLedControl3.Text = "0";
                lxLedControl4.Text = "0";
                lxLedControl5.Text = "0";
                dataGridView1.DataSource = null;
            }
            ////主动模式下刷屏
            if (tabControl2.SelectedTab == tabPage_active)
            {
                lxLed_Num.Text = "0";
                lxLed_cmdsud.Text = "0";
                lxLed_toltag.Text = "0";
                lxLed_toltime.Text = "0";
                total_time = System.Environment.TickCount;
                dataGridView2.Rows.Clear();
            }
            ////缓存模式下刷屏
            if (tabControl2.SelectedTab == tabPage_Buff)
            {
                lxLed_BNum.Text = "0";
                lxLed_Bcmdsud.Text = "0";
                lxLed_Btoltag.Text = "0";
                lxLed_Btoltime.Text = "0";
                lxLed_cmdTime.Text = "0";
                dataGridView3.Rows.Clear();
            }
            ////实时查询刷屏
            if (tabControl2.SelectedTab == tabPage_Realtime)
            {
                lxLed_Mtag.Text = "0";
                lxLed_Mtime.Text = "0";
                total_time = System.Environment.TickCount;
                dataGridView4.Rows.Clear();

            }
            ////6B标签刷屏
            if (Maintab.SelectedTab == Main_Page3)
            {
                text_R6B.Text = "";
                text_6BUID.Text = "";
                text_Statu6B.Text = "";
            }
            if (tabControl3.SelectedTab == tabPage8)//TCP 服务器
            {
                stcprecv.Clear();
            }
            if (tabControl3.SelectedTab == tabPage9)//TCP 客户端
            {
                ctctrecv.Clear();
                ctctsend.Text = "";
            }
            total_tagnum = 0;
            total_time = System.Environment.TickCount;
            comboBox_EPC.Items.Clear();
            lrtxtLog.Clear();

        }
        byte[] antlist = new byte[4];
        private volatile bool fIsInventoryScan = false;
        private volatile bool toStopThread = false;
        private Thread mythread = null;
        private void btIventoryG2_Click(object sender, EventArgs e)
        {
            if (btIventoryG2.Text == "Start")
            {
                lxLedControl1.Text = "0";
                lxLedControl2.Text = "0";
                lxLedControl3.Text = "0";
                lxLedControl4.Text = "0";
                lxLedControl5.Text = "0";
                dataGridView1.DataSource = null;
                comboBox_EPC.Items.Clear();
                text_epc.Text = "";
                AA_times = 0;
                Scantime = Convert.ToByte(com_scantime.SelectedIndex + 3);
                if (checkBox_rate.Checked)
                    Qvalue = Convert.ToByte(com_Q.SelectedIndex | 0x80);
                else
                    Qvalue = Convert.ToByte(com_Q.SelectedIndex);
                Session = Convert.ToByte(com_S.SelectedIndex);
                if (Session == 4)
                    Session = 255;
                if (rb_epc.Checked)
                    TIDFlag = 0;
                else
                    TIDFlag = 1;
                total_turns = 0;
                total_tagnum = 0;
                targettimes = Convert.ToInt32(text_target.Text);
                total_time = System.Environment.TickCount;
                fIsInventoryScan = false;
                btIventoryG2.BackColor = Color.Indigo;
                btIventoryG2.Text = "Stop";
                Array.Clear(antlist, 0, 4);
                if (check_ant1.Checked)
                {
                    antlist[0] = 1;
                    InAnt = 0x80;
                }
                if (check_ant2.Checked)
                {
                    antlist[1] = 1;
                    InAnt = 0x81;
                }
                if (check_ant3.Checked)
                {
                    antlist[2] = 1;
                    InAnt = 0x82;
                }
                if (check_ant4.Checked)
                {
                    antlist[3] = 1;
                    InAnt = 0x83;
                }
                Target = (byte)com_Target.SelectedIndex;
                toStopThread = false;
                if (fIsInventoryScan == false)
                {
                    mythread = new Thread(new ThreadStart(inventory));
                    mythread.Start();
                    timer_answer.Enabled = true;
                }
            }
            else
            {
                btIventoryG2.BackColor = Color.Transparent;
                btIventoryG2.Text = "Start";
                if (fIsInventoryScan)
                {
                    toStopThread = true;//标志，接收数据线程判断stop为true，正常情况下会自动退出线程                            
                    if (mythread.Join(3000))
                    {
                        try
                        {
                            mythread.Abort();//若线程无法退出，强制结束
                            timer_answer.Enabled = false;
                        }
                        catch (Exception exp)
                        {
                            MessageBox.Show(exp.Message, "Thread error");
                        }
                    }
                    fIsInventoryScan = false;
                }
                timer_answer.Enabled = false;
            }
        }
        private void flash_G2()
        {
            byte Ant = 0;
            int CardNum = 0;
            int Totallen = 0;
            int EPClen, m;
            byte[] EPC = new byte[50000];
            int CardIndex;
            string temps, temp;
            temp = "";
            string sEPC;
            byte MaskMem = 0;
            byte[] MaskAdr = new byte[2];
            byte MaskLen = 0;
            byte[] MaskData = new byte[100];
            byte MaskFlag = 0;
            byte AdrTID = 0;
            byte LenTID = 0;
            AdrTID = 0;
            LenTID = 6;
            MaskFlag = 0;
            int cbtime = System.Environment.TickCount;
            CardNum = 0;
            fCmdRet = RWDev.Inventory_G2(ref fComAdr, Qvalue, Session, MaskMem, MaskAdr, MaskLen, MaskData, MaskFlag, AdrTID, LenTID, TIDFlag, Target, InAnt, Scantime, FastFlag, EPC, ref Ant, ref Totallen, ref CardNum, frmcomportindex);
            int cmdTime = System.Environment.TickCount - cbtime;//命令时间
            if ((fCmdRet == 0x30) || (fCmdRet == 0x37))
            {
                if (rb_tcp.Checked)
                {
                    if (frmcomportindex > 1023)
                    {
                        fCmdRet = RWDev.CloseNetPort(frmcomportindex);
                        if (fCmdRet == 0) frmcomportindex = -1;
                        Thread.Sleep(1000);
                    }
                    fComAdr = 255;
                    string ipAddress = ipServerIP.IpAddressStr;
                    int nPort = Convert.ToInt32(tb_Port.Text);
                    fCmdRet = RWDev.OpenNetPort(nPort, ipAddress, ref fComAdr, ref frmcomportindex);
                }
            }
            if (CardNum == 0)
            {
                if (Session > 1)
                    AA_times = AA_times + 1;//没有得到标签只更新状态栏
                IntPtr ptrWnd = IntPtr.Zero;
                ptrWnd = FindWindow(null, "UHFReader288 Demo V1.0");
                if (ptrWnd != IntPtr.Zero)         // 检查当前统计窗口是否打开
                {
                    string para = fCmdRet.ToString();
                    SendMessage(ptrWnd, WM_SENDSTATU, IntPtr.Zero, para);
                }
                return;
            }
            AA_times = 0;

            if ((fCmdRet == 1) || (fCmdRet == 2) || (fCmdRet == 0x26))//代表已查找结束，
            {
                byte[] daw = new byte[Totallen];
                Array.Copy(EPC, daw, Totallen);
                temps = ByteArrayToHexString(daw);
                if (fCmdRet == 0x26)
                {
                    string SDCMD = temps.Substring(0, 12);
                    temps = temps.Substring(12);
                    daw = HexStringToByteArray(temps);
                    byte[] datas = new byte[6];
                    datas = HexStringToByteArray(SDCMD);
                    int tagrate = datas[0] * 256 + datas[1];
                    int tagnum = datas[2] * 256 * 256 * 256 + datas[3] * 256 * 256 + datas[4] * 256 + datas[5];
                    total_tagnum = total_tagnum + tagnum;
                    IntPtr ptrWnd = IntPtr.Zero;
                    ptrWnd = FindWindow(null, "UHFReader288 Demo V1.0");
                    if (ptrWnd != IntPtr.Zero)         // 检查当前统计窗口是否打开
                    {
                        string para = tagrate.ToString() + "," + total_tagnum.ToString() + "," + cmdTime.ToString();
                        SendMessage(ptrWnd, WM_SENDTAGSTAT, IntPtr.Zero, para);
                    }
                }
                m = 0;
                for (CardIndex = 0; CardIndex < CardNum; CardIndex++)
                {
                    EPClen = daw[m] + 1;
                    temp = temps.Substring(m * 2 + 2, EPClen * 2);
                    sEPC = temp.Substring(0, temp.Length - 2);
                    string RSSI = Convert.ToInt32(temp.Substring(temp.Length - 2, 2), 16).ToString();
                    m = m + EPClen + 1;
                    if (sEPC.Length != (EPClen - 1) * 2)
                    {
                        return;
                    }
                    IntPtr ptrWnd = IntPtr.Zero;
                    ptrWnd = FindWindow(null, "UHFReader288 Demo V1.0");
                    if (ptrWnd != IntPtr.Zero)         // 检查当前统计窗口是否打开
                    {
                        string para = sEPC + "," + RSSI.ToString() + " ";
                        SendMessage(ptrWnd, WM_SENDTAG, IntPtr.Zero, para);
                    }
                }
            }
            if ((fCmdRet == 1) || (fCmdRet == 2) || (fCmdRet == 0xFB))
            {
                if (cmdTime > CommunicationTime)
                    cmdTime = cmdTime - CommunicationTime;//减去通讯时间等于标签的实际时间
                int tagrate = (CardNum * 1000) / cmdTime;//速度等于张数/时间
                total_tagnum = total_tagnum + CardNum;
                IntPtr ptrWnd = IntPtr.Zero;
                ptrWnd = FindWindow(null, "UHFReader288 Demo V1.0");
                if (ptrWnd != IntPtr.Zero)         // 检查当前统计窗口是否打开
                {
                    string para = tagrate.ToString() + "," + total_tagnum.ToString() + "," + cmdTime.ToString();
                    SendMessage(ptrWnd, WM_SENDTAGSTAT, IntPtr.Zero, para);
                }
            }
            else if (fCmdRet != 0x26)
            {
                IntPtr ptrWnd1 = IntPtr.Zero;
                ptrWnd1 = FindWindow(null, "UHFReader288 Demo V1.0");
                if (ptrWnd1 != IntPtr.Zero)         // 检查当前统计窗口是否打开
                {
                    string para = fCmdRet.ToString();
                    SendMessage(ptrWnd1, WM_SENDSTATU, IntPtr.Zero, para);
                }
            }
        }
        private void inventory()
        {
            fIsInventoryScan = true;
            while (!toStopThread)
            {
                if (Session == 255)
                {
                    flash_G2();
                }
                else
                {
                    for (int m = 0; m < 4; m++)
                    {
                        switch (m)
                        {
                            case 0:
                                InAnt = 0x80;
                                break;
                            case 1:
                                InAnt = 0x81;
                                break;
                            case 2:
                                InAnt = 0x82;
                                break;
                            case 3:
                                InAnt = 0x83;
                                break;
                        }
                        FastFlag = 1;
                        if (antlist[m] == 1)
                        {
                            if (Session > 1)
                            {
                                if ((check_num.Checked) && (AA_times + 1 > targettimes))
                                {
                                    Target = Convert.ToByte(1 - Target);  //如果连续2次未读到卡片，A/B状态切换。
                                }
                                else if (!check_num.Checked)
                                {
                                    Target = (byte)com_Target.SelectedIndex;
                                }
                            }
                            flash_G2();
                        }
                    }
                }
                Thread.Sleep(5);
            }
            fIsInventoryScan = false;
        }
        private void timer_answer_Tick(object sender, EventArgs e)
        {
            lxLedControl5.Text = (System.Environment.TickCount - total_time).ToString();
        }

        private void radioButton_band1_CheckedChanged(object sender, EventArgs e)
        {
            int i;
            ComboBox_dmaxfre.Items.Clear();
            ComboBox_dminfre.Items.Clear();
            for (i = 0; i < 20; i++)
            {
                ComboBox_dminfre.Items.Add(Convert.ToString(920.125 + i * 0.25) + " MHz");
                ComboBox_dmaxfre.Items.Add(Convert.ToString(920.125 + i * 0.25) + " MHz");
            }
            ComboBox_dmaxfre.SelectedIndex = 19;
            ComboBox_dminfre.SelectedIndex = 0;
        }

        private void radioButton_band2_CheckedChanged(object sender, EventArgs e)
        {
            int i;
            ComboBox_dmaxfre.Items.Clear();
            ComboBox_dminfre.Items.Clear();
            for (i = 0; i < 50; i++)
            {
                ComboBox_dminfre.Items.Add(Convert.ToString(902.75 + i * 0.5) + " MHz");
                ComboBox_dmaxfre.Items.Add(Convert.ToString(902.75 + i * 0.5) + " MHz");
            }
            ComboBox_dmaxfre.SelectedIndex = 49;
            ComboBox_dminfre.SelectedIndex = 0;
        }

        private void radioButton_band3_CheckedChanged(object sender, EventArgs e)
        {
            int i;
            ComboBox_dmaxfre.Items.Clear();
            ComboBox_dminfre.Items.Clear();
            for (i = 0; i < 32; i++)
            {
                ComboBox_dminfre.Items.Add(Convert.ToString(917.1 + i * 0.2) + " MHz");
                ComboBox_dmaxfre.Items.Add(Convert.ToString(917.1 + i * 0.2) + " MHz");
            }
            ComboBox_dmaxfre.SelectedIndex = 31;
            ComboBox_dminfre.SelectedIndex = 0;
        }

        private void radioButton_band4_CheckedChanged(object sender, EventArgs e)
        {
            int i;
            ComboBox_dminfre.Items.Clear();
            ComboBox_dmaxfre.Items.Clear();
            for (i = 0; i < 15; i++)
            {
                ComboBox_dminfre.Items.Add(Convert.ToString(865.1 + i * 0.2) + " MHz");
                ComboBox_dmaxfre.Items.Add(Convert.ToString(865.1 + i * 0.2) + " MHz");
            }
            ComboBox_dmaxfre.SelectedIndex = 14;
            ComboBox_dminfre.SelectedIndex = 0;
        }

        private void CheckBox_SameFre_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_SameFre.Checked)
                ComboBox_dmaxfre.SelectedIndex = ComboBox_dminfre.SelectedIndex;
        }

        private void btworkmode_Click(object sender, EventArgs e)
        {
            byte Read_mode = 0;
            Read_mode = Convert.ToByte(comboBox_mode.SelectedIndex);
            fCmdRet = RWDev.SetWorkMode(ref fComAdr, Read_mode, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "Set Work Mode failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "Set Work Mode success: " + comboBox_mode.Text;
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void btResponse_Click(object sender, EventArgs e)
        {
            byte RepCondition = 0;
            byte RepPauseTime = 0;
            RepCondition = Convert.ToByte(comboBox_Resp.SelectedIndex);
            RepPauseTime = Convert.ToByte(comboBox_RespTime.SelectedIndex);
            fCmdRet = RWDev.SetResponsePamametersofAuto_runningMode(ref fComAdr, RepCondition, RepPauseTime, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "Set Response Pamameter failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "Set Response Pamameter success: " + comboBox_Resp.Text;
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void btGetWorkmodepara_Click(object sender, EventArgs e)
        {
            byte Read_mode = 0;
            byte Accuracy = 0;
            byte RepCondition = 0;
            byte RepPauseTime = 0;
            byte ReadPauseTim = 0;
            byte TagProtocol = 0;
            byte MaskMem = 0;
            byte[] MaskAdr = new byte[2];
            byte[] MaskData = new byte[100];
            byte MaskLen = 0;
            byte TriggerTime = 0;
            byte AdrTID = 0;
            byte LenTID = 0;
            int i, m_byte;
            string temp;
            temp = "";
            text_madds.Text = "";
            text_mlen.Text = "";
            text_mdata.Text = "";
            text_tidaddr.Text = "";
            text_tidlen.Text = "";
            fCmdRet = RWDev.GetSystemParameter(ref fComAdr, ref Read_mode, ref Accuracy, ref RepCondition, ref RepPauseTime, ref ReadPauseTim, ref TagProtocol, ref MaskMem, MaskAdr, ref MaskLen, MaskData, ref TriggerTime, ref AdrTID, ref LenTID, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "Get System Parameter failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                comboBox_mode.SelectedIndex = Convert.ToInt32(Read_mode);
                if ((Accuracy & 0x80) == 0x80)
                    rbEASAcc.Checked = true;
                else
                    rbNone.Checked = true;
                ComboBox_Accuracy.SelectedIndex = Convert.ToInt32(Accuracy & 0x3F);
                comboBox_Resp.SelectedIndex = RepCondition;
                comboBox_RespTime.SelectedIndex = RepPauseTime;
                if (comboBox_Resp.SelectedIndex == 1)
                    comboBox_RespTime.Enabled = true;
                else
                    comboBox_RespTime.Enabled = false;
                comboBox_intervalT.SelectedIndex = Convert.ToInt32(ReadPauseTim);
                switch (TagProtocol)
                {
                    case 0:
                        rb_180006c.Checked = true;
                        rb_G2.Checked = true;
                        break;
                    case 2:
                        rb_180006c.Checked = true;
                        rb_EAS.Checked = true;
                        break;
                    case 0x10:
                        rb_180006c.Checked = true;
                        rb_G2TID.Checked = true;
                        break;
                    case 0x80:
                        rb_180006B.Checked = true;
                        break;
                }
                switch (MaskMem)
                {
                    case 1:
                        rb_MaskEPC.Checked = true;
                        break;
                    case 2:
                        rb_MaskTID.Checked = true;
                        break;
                    case 3:
                        rb_MaskUser.Checked = true;
                        break;
                }
                for (i = 0; i < 2; i++)
                    temp = temp + Convert.ToString(MaskAdr[i], 16).PadLeft(2, '0');
                text_madds.Text = temp;
                text_mlen.Text = Convert.ToString(MaskLen, 16).PadLeft(2, '0');
                temp = "";
                if ((MaskLen % 8) == 0)
                    m_byte = MaskLen / 8;
                else
                    m_byte = MaskLen / 8 + 1;
                for (i = 0; i < m_byte; i++)
                    temp = temp + Convert.ToString(MaskData[i], 16).PadLeft(2, '0');
                text_mdata.Text = temp;
                comboBox_trigger.SelectedIndex = TriggerTime;
                text_tidaddr.Text = Convert.ToString(AdrTID, 16).PadLeft(2, '0');
                text_tidlen.Text = Convert.ToString(LenTID, 16).PadLeft(2, '0');
                string strLog = "Get System Parameter success ";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void comboBox_Resp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Resp.SelectedIndex == 1)
                comboBox_RespTime.Enabled = true;
            else
                comboBox_RespTime.Enabled = false;
        }

        private bool CheckCRC(string s)
        {
            int i, j;
            int current_crc_value;
            byte crcL, crcH;
            byte[] data = HexStringToByteArray(s);
            current_crc_value = 0xFFFF;
            for (i = 0; i <= (data.Length - 1); i++)
            {
                current_crc_value = current_crc_value ^ (data[i]);
                for (j = 0; j < 8; j++)
                {
                    if ((current_crc_value & 0x01) != 0)
                        current_crc_value = (current_crc_value >> 1) ^ 0x8408;
                    else
                        current_crc_value = (current_crc_value >> 1);
                }
            }
            crcL = Convert.ToByte(current_crc_value & 0xFF);
            crcH = Convert.ToByte((current_crc_value >> 8) & 0xFF);
            if (crcH == 0 && crcL == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void GetData()
        {
            byte[] ScanModeData = new byte[40960];
            int nLen, NumLen;
            string temp1 = "";
            string syear = "";
            string smonth = "";
            string sday = "";
            string shour = "";
            string smin = "";
            string ssec = "";
            string Lyear = "";
            string Lmonth = "";
            string Lday = "";
            string Lhour = "";
            string Lmin = "";
            string Lsec = "";
            string binarystr1 = "";
            string binarystr2 = "";
            string CountStr = "";
            string AntStr = "";
            string EPCStr = "";
            int ValidDatalength;
            string temp;
            ValidDatalength = 0;
            DataGridViewRow rows = new DataGridViewRow();
            int xtime = System.Environment.TickCount;
            fCmdRet = RWDev.ReadActiveModeData(ScanModeData, ref ValidDatalength, frmcomportindex);
            if (fCmdRet == 0)
            {
                try
                {
                    byte[] daw = new byte[ValidDatalength];
                    Array.Copy(ScanModeData, 0, daw, 0, ValidDatalength);
                    temp = ByteArrayToHexString(daw);
                    fInventory_EPC_List = fInventory_EPC_List + temp;//把字符串存进列表
                    nLen = fInventory_EPC_List.Length;
                    while (fInventory_EPC_List.Length > 34)
                    {
                        string FlagStr = Convert.ToString(fComAdr, 16).PadLeft(2, '0') + "EE00";//查找头位置标志字符串
                        int nindex = fInventory_EPC_List.IndexOf(FlagStr);
                        if (nindex > 1)
                            fInventory_EPC_List = fInventory_EPC_List.Substring(nindex - 2);
                        else
                        {
                            fInventory_EPC_List = fInventory_EPC_List.Substring(2);
                            continue;
                        }
                        NumLen = Convert.ToInt32(fInventory_EPC_List.Substring(0, 2), 16) * 2 + 2;//取第一个帧的长度
                        if (fInventory_EPC_List.Length < NumLen)
                        {
                            break;
                        }
                        temp1 = fInventory_EPC_List.Substring(0, NumLen);
                        fInventory_EPC_List = fInventory_EPC_List.Substring(NumLen);
                        if (!CheckCRC(temp1)) continue;
                        binarystr1 = Convert.ToString(Convert.ToInt32(temp1.Substring(8, 8), 16), 2).PadLeft(32, '0');
                        syear = Convert.ToString(Convert.ToInt32(binarystr1.Substring(0, 6), 2)).PadLeft(2, '0');
                        smonth = Convert.ToString(Convert.ToInt32(binarystr1.Substring(6, 4), 2)).PadLeft(2, '0');
                        sday = Convert.ToString(Convert.ToInt32(binarystr1.Substring(10, 5), 2)).PadLeft(2, '0');
                        shour = Convert.ToString(Convert.ToInt32(binarystr1.Substring(15, 5), 2)).PadLeft(2, '0');
                        smin = Convert.ToString(Convert.ToInt32(binarystr1.Substring(20, 6), 2)).PadLeft(2, '0');
                        ssec = Convert.ToString(Convert.ToInt32(binarystr1.Substring(26, 6), 2)).PadLeft(2, '0');

                        binarystr2 = Convert.ToString(Convert.ToInt32(temp1.Substring(16, 8), 16), 2).PadLeft(32, '0');
                        Lyear = Convert.ToString(Convert.ToInt32(binarystr2.Substring(0, 6), 2)).PadLeft(2, '0');
                        Lmonth = Convert.ToString(Convert.ToInt32(binarystr2.Substring(6, 4), 2)).PadLeft(2, '0');
                        Lday = Convert.ToString(Convert.ToInt32(binarystr2.Substring(10, 5), 2)).PadLeft(2, '0');
                        Lhour = Convert.ToString(Convert.ToInt32(binarystr2.Substring(15, 5), 2)).PadLeft(2, '0');
                        Lmin = Convert.ToString(Convert.ToInt32(binarystr2.Substring(20, 6), 2)).PadLeft(2, '0');
                        Lsec = Convert.ToString(Convert.ToInt32(binarystr2.Substring(26, 6), 2)).PadLeft(2, '0');

                        CountStr = Convert.ToString(Convert.ToInt32(temp1.Substring(24, 4), 16), 10);
                        AntStr = Convert.ToString(Convert.ToInt32(temp1.Substring(28, 2), 16), 2).PadLeft(4, '0');
                        EPCStr = temp1.Substring(30, temp1.Length - 34);
                        bool isonlistview = false;
                        for (int i = 0; i < dataGridView2.RowCount; i++)
                        {
                            if ((dataGridView2.Rows[i].Cells[1].Value != null) && (EPCStr == dataGridView2.Rows[i].Cells[1].Value.ToString()))
                            {
                                rows = dataGridView2.Rows[i];
                                rows.Cells[3].Value = "20" + Lyear + "-" + Lmonth + "-" + Lday + " " + Lhour + ":" + Lmin + ":" + Lsec; ;
                                rows.Cells[4].Value = AntStr;
                                rows.Cells[5].Value = CountStr;
                                isonlistview = true;
                                break;
                            }
                        }
                        if (!isonlistview)
                        {
                            string[] arr = new string[6];
                            arr[0] = (dataGridView2.RowCount + 1).ToString();
                            arr[1] = EPCStr;
                            arr[2] = "20" + syear + "-" + smonth + "-" + sday + " " + shour + ":" + smin + ":" + ssec;
                            arr[3] = "20" + Lyear + "-" + Lmonth + "-" + Lday + " " + Lhour + ":" + Lmin + ":" + Lsec;
                            arr[4] = AntStr;
                            arr[5] = CountStr;
                            dataGridView2.Rows.Insert(dataGridView2.RowCount, arr);
                        }
                        total_tagnum = total_tagnum + 1;////每解析一条记录加一
                        lxLed_toltag.Text = total_tagnum.ToString();
                        lxLed_toltime.Text = (System.Environment.TickCount - total_time).ToString();
                    }
                }
                catch (System.Exception ex)
                {
                    ex.ToString();
                }
            }
            xtime = System.Environment.TickCount - xtime;
            lxLed_Num.Text = dataGridView2.RowCount.ToString();
            if ((System.Environment.TickCount - total_time) > 0)
                lxLed_cmdsud.Text = (total_tagnum * 1000 / (System.Environment.TickCount - total_time)).ToString();
        }
        private void timer_runmode_Tick(object sender, EventArgs e)
        {
            if (fIsInventoryScan)
                return;
            fIsInventoryScan = true;
            GetData();
            fIsInventoryScan = false;
        }


        private void Maintab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fIsInventoryScan)
            {
                toStopThread = true;//标志，接收数据线程判断stop为true，正常情况下会自动退出线程                                
                if (mythread.Join(3000))
                {
                    try
                    {
                        mythread.Abort();//若线程无法退出，强制结束
                        timer_answer.Enabled = false;
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message, "Thread error");
                    }
                }
                fIsInventoryScan = false;
            }
            if (fIsBuffScan)
            {
                toStopThread = true;//标志，接收数据线程判断stop为true，正常情况下会自动退出线程                                
                if (ReadThread.Join(3000))
                {
                    try
                    {
                        ReadThread.Abort();//若线程无法退出，强制结束
                        timer_Buff.Enabled = false;
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message, "Thread error");
                    }
                }
                fIsInventoryScan = false;
            }
            timer_runmode.Enabled = false;
            timer_answer.Enabled = false;
            timer_EAS.Enabled = false;
            Timer_Test_6B.Enabled = false;
            timer_Buff.Enabled = false;
            timer_RealTime.Enabled = false;
            btIventoryG2.Text = "Start";
            btGetrunmodedata.Text = "Start";
            btCheckEASAlarm.Text = "Detect";
            btStartBuff.Text = "Start";
            btStartMactive.Text = "Start";
            pictureBox2.Visible = false;
            btIventoryG2.BackColor = Color.Transparent;
            btGetrunmodedata.BackColor = Color.Transparent;
            btStartBuff.BackColor = Color.Transparent;
            btStartMactive.BackColor = Color.Transparent;
            btInventory6B.Text = "Start";
            btInventory6B.BackColor = Color.Transparent;


            if (comboBox_EPC.Text == "" && comboBox_EPC.Items.Count > 0)
            {
                comboBox_EPC.SelectedIndex = 0;
            }
            if (ReadTypes == "16")//单口
            {
                group_ant1.Enabled = false;
                group_ant2.Enabled = false;
                check_ant1.Checked = true;
                check_ant2.Checked = false;
                check_ant3.Checked = false;
                check_ant4.Checked = false;
                BAnt1.Checked = true;
                BAnt2.Checked = false;
                BAnt3.Checked = false;
                BAnt4.Checked = false;
            }
            else
            {
                if (com_S.SelectedIndex < 4)
                    group_ant1.Enabled = true;
                else
                    group_ant1.Enabled = false;
                group_ant2.Enabled = true;
            }

        }

        private void btClearBuffer_Click(object sender, EventArgs e)
        {
            fCmdRet = RWDev.ClearTagBuffer(ref fComAdr, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "Clear data failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "Clear datda success ";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void btGettagbuffer_Click(object sender, EventArgs e)
        {
            byte[] Data = new byte[8000];
            int dataLength = 0;
            int nLen, NumLen;
            string temp = "";
            string temp1 = "";
            string syear = "";
            string smonth = "";
            string sday = "";
            string shour = "";
            string smin = "";
            string ssec = "";
            string Lyear = "";
            string Lmonth = "";
            string Lday = "";
            string Lhour = "";
            string Lmin = "";
            string Lsec = "";
            string binarystr1 = "";
            string binarystr2 = "";
            string CountStr = "";
            string AntStr = "";
            string EPCStr = "";
            dataGridView2.Rows.Clear();
            lxLed_Num.Text = "0";
            lxLed_cmdsud.Text = "0";
            lxLed_toltag.Text = "0";
            lxLed_toltime.Text = "0";
            total_time = System.Environment.TickCount;
            fCmdRet = RWDev.GetTagBufferInfo(ref fComAdr, Data, ref dataLength, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "Read Command notify data failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                nLen = dataLength * 2;
                temp = ByteArrayToHexString(Data);
                while (nLen > 0)
                {
                    NumLen = 24 + Convert.ToInt32(temp.Substring(22, 2), 16) * 2;
                    temp1 = temp.Substring(0, NumLen);
                    binarystr1 = Convert.ToString(Convert.ToInt32(temp1.Substring(0, 8), 16), 2).PadLeft(32, '0');
                    syear = Convert.ToString(Convert.ToInt32(binarystr1.Substring(0, 6), 2)).PadLeft(2, '0');
                    smonth = Convert.ToString(Convert.ToInt32(binarystr1.Substring(6, 4), 2)).PadLeft(2, '0');
                    sday = Convert.ToString(Convert.ToInt32(binarystr1.Substring(10, 5), 2)).PadLeft(2, '0');
                    shour = Convert.ToString(Convert.ToInt32(binarystr1.Substring(15, 5), 2)).PadLeft(2, '0');
                    smin = Convert.ToString(Convert.ToInt32(binarystr1.Substring(20, 6), 2)).PadLeft(2, '0');
                    ssec = Convert.ToString(Convert.ToInt32(binarystr1.Substring(26, 6), 2)).PadLeft(2, '0');

                    binarystr2 = Convert.ToString(Convert.ToInt32(temp1.Substring(8, 8), 16), 2).PadLeft(32, '0');
                    Lyear = Convert.ToString(Convert.ToInt32(binarystr2.Substring(0, 6), 2)).PadLeft(2, '0');
                    Lmonth = Convert.ToString(Convert.ToInt32(binarystr2.Substring(6, 4), 2)).PadLeft(2, '0');
                    Lday = Convert.ToString(Convert.ToInt32(binarystr2.Substring(10, 5), 2)).PadLeft(2, '0');
                    Lhour = Convert.ToString(Convert.ToInt32(binarystr2.Substring(15, 5), 2)).PadLeft(2, '0');
                    Lmin = Convert.ToString(Convert.ToInt32(binarystr2.Substring(20, 6), 2)).PadLeft(2, '0');
                    Lsec = Convert.ToString(Convert.ToInt32(binarystr2.Substring(26, 6), 2)).PadLeft(2, '0');

                    CountStr = Convert.ToString(Convert.ToInt32(temp1.Substring(16, 4), 16), 10);

                    AntStr = Convert.ToString(Convert.ToInt32(temp1.Substring(20, 2), 16), 2).PadLeft(4, '0');
                    EPCStr = temp1.Substring(24, temp1.Length - 24);

                    string[] arr = new string[6];
                    arr[0] = (dataGridView2.RowCount + 1).ToString();
                    arr[1] = EPCStr;
                    arr[2] = "20" + syear + "-" + smonth + "-" + sday + " " + shour + ":" + smin + ":" + ssec;
                    arr[3] = "20" + Lyear + "-" + Lmonth + "-" + Lday + " " + Lhour + ":" + Lmin + ":" + Lsec;
                    arr[4] = AntStr;
                    arr[5] = CountStr;
                    dataGridView2.Rows.Insert(dataGridView2.RowCount, arr);
                    if ((temp.Length - NumLen) > 0)
                        temp = temp.Substring(NumLen, temp.Length - NumLen);
                    nLen = nLen - NumLen;
                }
                string strLog = "Read Command notify data success ";
                WriteLog(lrtxtLog, strLog, 0);
                int xtime = System.Environment.TickCount - total_time;
                lxLed_Num.Text = dataGridView2.RowCount.ToString();
                lxLed_cmdsud.Text = (dataGridView2.RowCount * 1000 / xtime).ToString();
                lxLed_toltag.Text = dataGridView2.RowCount.ToString();
                lxLed_toltime.Text = xtime.ToString();
            }
        }

        private void btGetrunmodedata_Click(object sender, EventArgs e)
        {
            timer_runmode.Enabled = !timer_runmode.Enabled;
            if (!timer_runmode.Enabled)
            {
                btGetrunmodedata.Text = "Start";
                btGetrunmodedata.BackColor = Color.Transparent;
            }
            else
            {
                fInventory_EPC_List = "";
                lxLed_Num.Text = "0";
                lxLed_cmdsud.Text = "0";
                lxLed_toltag.Text = "0";
                lxLed_toltime.Text = "0";
                total_time = System.Environment.TickCount;
                total_tagnum = 0;
                dataGridView2.Rows.Clear();
                btGetrunmodedata.BackColor = Color.Indigo;
                fIsInventoryScan = false;
                btGetrunmodedata.Text = "Stop";
            }
        }

        private void tb_Port_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ("0123456789".IndexOf(Char.ToUpper(e.KeyChar)) < 0);
        }

        private void text_address_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ("0123456789ABCDEF".IndexOf(Char.ToUpper(e.KeyChar)) < 0);
        }

        private void btGetInformation_Click(object sender, EventArgs e)
        {
            byte TrType = 0;
            byte[] VersionInfo = new byte[2];
            byte ReaderType = 0;
            byte ScanTime = 0;
            byte dmaxfre = 0;
            byte dminfre = 0;
            byte powerdBm = 0;
            byte FreBand = 0;
            byte Ant = 0;
            byte BeepEn = 0;
            byte OutputRep = 0;
            byte CheckAnt = 0;
            text_RDVersion.Text = "";
            int ctime = System.Environment.TickCount;
            fCmdRet = RWDev.GetReaderInformation(ref fComAdr, VersionInfo, ref ReaderType, ref TrType, ref dmaxfre, ref dminfre, ref powerdBm, ref ScanTime, ref Ant, ref BeepEn, ref OutputRep, ref CheckAnt, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "Get Reader Information failed:" + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                CommunicationTime = System.Environment.TickCount - ctime;
                switch (ReaderType)
                {
                    case 0x8A://2881
                        {
                            ReadTypes = "8A";
                            //模块版本号显示
                            gpb_MDVersion.Visible = true;
                            btFlashROM.Visible = true;
                            //时钟可设置
                            gpb_clock.Enabled = true;
                            //GPIO显示
                            check_out3.Visible = true;
                            check_out4.Visible = true;
                            check_int2.Visible = true;
                            check_int3.Visible = true;
                            check_int4.Visible = true;
                            //天线显示
                            gpb_checkant.Enabled = true;
                            gpb_antconfig.Enabled = true;
                            //主动模式显示
                            if (tabControl1.TabPages.IndexOf(tabPage_Mx) == -1)
                                tabControl1.TabPages.Add(tabPage_Mx);
                            if (tabControl1.TabPages.IndexOf(tabPage_Module) == -1)
                                tabControl1.TabPages.Add(tabPage_Module);
                            //主动询查显示
                            if (tabControl2.TabPages.IndexOf(tabPage_active) == -1)
                                tabControl2.TabPages.Add(tabPage_active);
                            if (tabControl2.TabPages.IndexOf(tabPage_Realtime) == -1)
                                tabControl2.TabPages.Add(tabPage_Realtime);
                            //缓存显示
                            gbp_buff.Enabled = true;
                            if (tabControl2.TabPages.IndexOf(tabPage_Buff) == -1)
                                tabControl2.TabPages.Add(tabPage_Buff);
                            // tabControl2.TabPages.Remove(tabPage_Realtime);
                            text_RDVersion.Text = "UHFReader288--" + Convert.ToString(VersionInfo[0], 10).PadLeft(2, '0') + "." + Convert.ToString(VersionInfo[1], 10).PadLeft(2, '0');
                        }
                        break;
                    case 0x8B://2881
                        {
                            ReadTypes = "8B";
                            //模块版本号显示
                            gpb_MDVersion.Visible = true;
                            btFlashROM.Visible = true;
                            //时钟可设置
                            gpb_clock.Enabled = true;
                            //GPIO显示
                            check_out3.Visible = true;
                            check_out4.Visible = true;
                            check_int2.Visible = true;
                            check_int3.Visible = true;
                            check_int4.Visible = true;
                            //天线显示
                            gpb_checkant.Enabled = true;
                            gpb_antconfig.Enabled = true;
                            //主动模式显示
                            if (tabControl1.TabPages.IndexOf(tabPage_Mx) == -1)
                                tabControl1.TabPages.Add(tabPage_Mx);
                            if (tabControl1.TabPages.IndexOf(tabPage_Module) == -1)
                                tabControl1.TabPages.Add(tabPage_Module);
                            //主动询查显示
                            if (tabControl2.TabPages.IndexOf(tabPage_active) == -1)
                                tabControl2.TabPages.Add(tabPage_active);
                            if (tabControl2.TabPages.IndexOf(tabPage_Realtime) == -1)
                                tabControl2.TabPages.Add(tabPage_Realtime);
                            //缓存显示
                            gbp_buff.Enabled = true;
                            if (tabControl2.TabPages.IndexOf(tabPage_Buff) == -1)
                                tabControl2.TabPages.Add(tabPage_Buff);
                            text_RDVersion.Text = "UHFReader288ADV--" + Convert.ToString(VersionInfo[0], 10).PadLeft(2, '0') + "." + Convert.ToString(VersionInfo[1], 10).PadLeft(2, '0');
                        }
                        break;
                    case 0x0C://2881lite
                        {
                            ReadTypes = "0C";
                            //模块版本号显示
                            gpb_MDVersion.Visible = false;
                            btFlashROM.Visible = false;
                            //时钟可设置
                            gpb_clock.Enabled = false;
                            //GPIO显示
                            check_out3.Visible = false;
                            check_out4.Visible = false;
                            check_int2.Visible = false;
                            check_int3.Visible = false;
                            check_int4.Visible = false;
                            //天线显示
                            gpb_checkant.Enabled = true;
                            gpb_antconfig.Enabled = true;
                            //主动模式显示
                            if (tabControl1.TabPages.IndexOf(tabPage_Module) == -1)
                                tabControl1.TabPages.Add(tabPage_Module);
                            int m = tabControl1.TabPages.IndexOf(tabPage_Mx);
                            if (tabControl1.TabPages.IndexOf(tabPage_Mx) > 0)
                                tabControl1.TabPages.Remove(tabPage_Mx);
                            //主动询查显示
                            if (tabControl2.TabPages.IndexOf(tabPage_Realtime) == -1)
                                tabControl2.TabPages.Add(tabPage_Realtime);
                            if (tabControl2.TabPages.IndexOf(tabPage_active) > 0)
                                tabControl2.TabPages.Remove(tabPage_active);
                            //缓存显示
                            gbp_buff.Enabled = true;
                            if (tabControl2.TabPages.IndexOf(tabPage_Buff) == -1)
                                tabControl2.TabPages.Add(tabPage_Buff);
                            text_RDVersion.Text = "UHFReader288M--" + Convert.ToString(VersionInfo[0], 10).PadLeft(2, '0') + "." + Convert.ToString(VersionInfo[1], 10).PadLeft(2, '0');
                        }
                        break;
                    case 0x16://9883M
                        {
                            ReadTypes = "16";
                            //模块版本号显示
                            gpb_MDVersion.Visible = false;
                            btFlashROM.Visible = false;
                            //时钟可设置
                            gpb_clock.Enabled = false;
                            //GPIO显示
                            check_out3.Visible = false;
                            check_out4.Visible = false;
                            check_int2.Visible = false;
                            check_int3.Visible = false;
                            check_int4.Visible = false;
                            //天线显示
                            gpb_checkant.Enabled = false;
                            gpb_antconfig.Enabled = false;
                            //主动模式显示
                            tabControl1.TabPages.Remove(tabPage_Mx);
                            tabControl1.TabPages.Remove(tabPage_Module);
                            //主动询查显示
                            tabControl2.TabPages.Remove(tabPage_active);
                            tabControl2.TabPages.Remove(tabPage_Realtime);
                            //缓存显示
                            gbp_buff.Enabled = false;
                            tabControl2.TabPages.Remove(tabPage_Buff);
                            text_RDVersion.Text = "UHFReader98--" + Convert.ToString(VersionInfo[0], 10).PadLeft(2, '0') + "." + Convert.ToString(VersionInfo[1], 10).PadLeft(2, '0');
                        }
                        break;
                }
                ComboBox_PowerDbm.SelectedIndex = Convert.ToInt32(powerdBm);
                text_address.Text = Convert.ToString(fComAdr, 16).PadLeft(2, '0');
                FreBand = Convert.ToByte(((dmaxfre & 0xc0) >> 4) | (dminfre >> 6));
                switch (FreBand)
                {
                    case 1:
                        {
                            radioButton_band1.Checked = true;
                            fdminfre = 920.125 + (dminfre & 0x3F) * 0.25;
                            fdmaxfre = 920.125 + (dmaxfre & 0x3F) * 0.25;
                        }
                        break;
                    case 2:
                        {
                            radioButton_band2.Checked = true;
                            fdminfre = 902.75 + (dminfre & 0x3F) * 0.5;
                            fdmaxfre = 902.75 + (dmaxfre & 0x3F) * 0.5;
                        }
                        break;
                    case 3:
                        {
                            radioButton_band3.Checked = true;
                            fdminfre = 917.1 + (dminfre & 0x3F) * 0.2;
                            fdmaxfre = 917.1 + (dmaxfre & 0x3F) * 0.2;
                        }
                        break;
                    case 4:
                        {
                            radioButton_band4.Checked = true;
                            fdminfre = 865.1 + (dminfre & 0x3F) * 0.2;
                            fdmaxfre = 865.1 + (dmaxfre & 0x3F) * 0.2;
                        }
                        break;
                    case 8:
                        {
                            radioButton_band8.Checked = true;
                            fdminfre = 840.125 + (dminfre & 0x3F) * 0.25;
                            fdmaxfre = 840.125 + (dmaxfre & 0x3F) * 0.25;
                        }
                        break;
                }
                if (fdmaxfre != fdminfre)
                    CheckBox_SameFre.Checked = false;
                ComboBox_dminfre.SelectedIndex = dminfre & 0x3F;
                ComboBox_dmaxfre.SelectedIndex = dmaxfre & 0x3F;
                switch (BeepEn)
                {
                    case 1:
                        Radio_beepEn.Checked = true;
                        break;
                    case 0:
                        Radio_beepDis.Checked = true;
                        break;
                }

                if ((Ant & 0x01) == 1)
                {
                    check_ant1.Checked = true;
                    checkant1.Checked = true;
                    BAnt1.Checked = true;
                }
                else
                {
                    check_ant1.Checked = false;
                    checkant1.Checked = false;
                    BAnt1.Checked = false;
                }

                if ((Ant & 0x02) == 2)
                {
                    check_ant2.Checked = true;
                    checkant2.Checked = true;
                    BAnt2.Checked = true;
                }
                else
                {
                    check_ant2.Checked = false;
                    checkant2.Checked = false;
                    BAnt2.Checked = false;
                }

                if ((Ant & 0x04) == 4)
                {
                    check_ant3.Checked = true;
                    checkant3.Checked = true;
                    BAnt3.Checked = true;
                }
                else
                {
                    check_ant3.Checked = false;
                    checkant3.Checked = false;
                    BAnt3.Checked = false;
                }

                if ((Ant & 0x08) == 8)
                {
                    check_ant4.Checked = true;
                    checkant4.Checked = true;
                    BAnt4.Checked = true;
                }
                else
                {
                    check_ant4.Checked = false;
                    checkant4.Checked = false; ;
                    BAnt3.Checked = false;
                }

                if ((OutputRep & 0x01) == 1)
                    check_OutputRep1.Checked = true;
                else
                    check_OutputRep1.Checked = false;

                if ((OutputRep & 0x02) == 2)
                    check_OutputRep2.Checked = true;
                else
                    check_OutputRep2.Checked = false;

                if ((OutputRep & 0x04) == 4)
                    check_OutputRep3.Checked = true;
                else
                    check_OutputRep3.Checked = false;

                if ((OutputRep & 0x08) == 8)
                    check_OutputRep4.Checked = true;
                else
                    check_OutputRep4.Checked = false;

                if (CheckAnt == 0)
                {
                    rb_Closecheckant.Checked = true;
                }
                else
                {
                    rb_Opencheckant.Checked = true;
                }
                string strLog = "Get Reader Information success ";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void btDefault_Click(object sender, EventArgs e)
        {
            byte aNewComAdr, powerDbm, dminfre, dmaxfre, scantime;
            dminfre = 128;
            dmaxfre = 49;
            aNewComAdr = 0x00;
            powerDbm = 30;
            fBaud = 5;
            scantime = 20;
            ComboBox_baud.SelectedIndex = 3;
            fCmdRet = RWDev.SetAddress(ref fComAdr, aNewComAdr, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "Set Reader address failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "Set Reader address success ";
                WriteLog(lrtxtLog, strLog, 0);
            }

            fCmdRet = RWDev.SetRfPower(ref fComAdr, powerDbm, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "Set Power failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "Set power success ";
                WriteLog(lrtxtLog, strLog, 0);
            }

            fCmdRet = RWDev.SetRegion(ref fComAdr, dmaxfre, dminfre, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "Set Region failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "Set Region success";
                WriteLog(lrtxtLog, strLog, 0);
            }

            fCmdRet = RWDev.SetBaudRate(ref fComAdr, fBaud, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "Set baud rate failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "Set baud rate success ";
                WriteLog(lrtxtLog, strLog, 0);
            }

            fCmdRet = RWDev.SetInventoryScanTime(ref fComAdr, scantime, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "Set inventory scan time failed:： " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "Set inventory scan time success ";
                WriteLog(lrtxtLog, strLog, 0);
            }
            btGetInformation_Click(null, null);
        }

        private void btaddress_Click(object sender, EventArgs e)
        {
            byte aNewComAdr = Convert.ToByte(text_address.Text, 16);
            fCmdRet = RWDev.SetAddress(ref fComAdr, aNewComAdr, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "Set reader address failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "Set reader address success ";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void btFreq_Click(object sender, EventArgs e)
        {
            byte dminfre, dmaxfre;
            int band = 2;
            if (radioButton_band1.Checked)
                band = 1;
            if (radioButton_band2.Checked)
                band = 2;
            if (radioButton_band3.Checked)
                band = 3;
            if (radioButton_band4.Checked)
                band = 4;
            if (radioButton_band8.Checked)
                band = 8;
            dminfre = Convert.ToByte(((band & 3) << 6) | (ComboBox_dminfre.SelectedIndex & 0x3F));
            dmaxfre = Convert.ToByte(((band & 0x0c) << 4) | (ComboBox_dmaxfre.SelectedIndex & 0x3F));
            fCmdRet = RWDev.SetRegion(ref fComAdr, dmaxfre, dminfre, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "Set region failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "Set region success ";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void BT_DBM_Click(object sender, EventArgs e)
        {
            byte powerDbm = (byte)ComboBox_PowerDbm.SelectedIndex;
            fCmdRet = RWDev.SetRfPower(ref fComAdr, powerDbm, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "Set power failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "Set power success ";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void btBaudRate_Click(object sender, EventArgs e)
        {
            byte fBaud = (byte)ComboBox_baud.SelectedIndex;
            if (fBaud > 2)
                fBaud = (byte)(fBaud + 2);
            fCmdRet = RWDev.SetBaudRate(ref fComAdr, fBaud, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "Set baud rate failed " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "Set baud rate success ";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void btSerial_Click(object sender, EventArgs e)
        {
            byte[] SeriaNo = new byte[4];
            text_Serial.Text = "";
            fCmdRet = RWDev.GetSeriaNo(ref fComAdr, SeriaNo, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "Get serial number failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                text_Serial.Text = ByteArrayToHexString(SeriaNo);
                string strLog = "Get serial number success ";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void btMDVersion_Click(object sender, EventArgs e)
        {
            byte[] Version = new byte[2];
            text_MDVersion.Text = "";
            fCmdRet = RWDev.GetModuleVersion(ref fComAdr, Version, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "Get module version failed:" + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                text_MDVersion.Text = Convert.ToString(Version[0], 10).PadLeft(2, '0') + "." + Convert.ToString(Version[1], 10).PadLeft(2, '0');
                string strLog = "Get module version success ";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void Button_Beep_Click(object sender, EventArgs e)
        {
            byte BeepEn = 0;
            if (Radio_beepEn.Checked)
                BeepEn = 1;
            else
                BeepEn = 0;
            fCmdRet = RWDev.SetBeepNotification(ref fComAdr, BeepEn, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "Set beep failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "Set beep success ";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void btRelay_Click(object sender, EventArgs e)
        {
            byte RelayTime = 0;
            RelayTime = Convert.ToByte(ComboBox_RelayTime.SelectedIndex + 1);
            fCmdRet = RWDev.SetRelay(ref fComAdr, RelayTime, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "Set relay failed:" + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "Set relay success ";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void btOutputRep_Click(object sender, EventArgs e)
        {
            byte OutputRep = 0;
            if (check_OutputRep1.Checked)
                OutputRep = Convert.ToByte(OutputRep | 0x01);
            if (check_OutputRep2.Checked)
                OutputRep = Convert.ToByte(OutputRep | 0x02);
            if (check_OutputRep3.Checked)
                OutputRep = Convert.ToByte(OutputRep | 0x04);
            if (check_OutputRep3.Checked)
                OutputRep = Convert.ToByte(OutputRep | 0x08);
            fCmdRet = RWDev.SetNotificationPulseOutput(ref fComAdr, OutputRep, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "Set notification pulse output failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "Set notification pulse output success ";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void Button_SetGPIO_Click(object sender, EventArgs e)
        {
            byte OutputPin = 0;
            if (check_out1.Checked)
                OutputPin = Convert.ToByte(OutputPin | 0x01);
            if (check_out2.Checked)
                OutputPin = Convert.ToByte(OutputPin | 0x02);
            if (check_out3.Checked)
                OutputPin = Convert.ToByte(OutputPin | 0x04);
            if (check_out4.Checked)
                OutputPin = Convert.ToByte(OutputPin | 0x08);
            fCmdRet = RWDev.SetGPIO(ref fComAdr, OutputPin, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "Set GPIO failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "Set GPIO success";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void Button_GetGPIO_Click(object sender, EventArgs e)
        {
            byte OutputPin = 0;
            fCmdRet = RWDev.GetGPIOStatus(ref fComAdr, ref OutputPin, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "Get GPIO failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                if ((OutputPin & 0x10) == 0x10)
                    check_out1.Checked = true;
                else
                    check_out1.Checked = false;

                if ((OutputPin & 0x20) == 0x20)
                    check_out2.Checked = true;
                else
                    check_out2.Checked = false;

                if ((OutputPin & 0x40) == 0x40)
                    check_out3.Checked = true;
                else
                    check_out3.Checked = false;

                if ((OutputPin & 0x80) == 0x80)
                    check_out4.Checked = true;
                else
                    check_out4.Checked = false;

                if ((OutputPin & 0x01) == 1)
                    check_int1.Checked = true;
                else
                    check_int1.Checked = false;

                if ((OutputPin & 0x02) == 2)
                    check_int2.Checked = true;
                else
                    check_int2.Checked = false;

                if ((OutputPin & 0x04) == 4)
                    check_int3.Checked = true;
                else
                    check_int3.Checked = false;

                if ((OutputPin & 0x08) == 8)
                    check_int4.Checked = true;
                else
                    check_int4.Checked = false;
                string strLog = "Get GPIO success ";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void btSetcheckant_Click(object sender, EventArgs e)
        {
            byte CheckAnt = 0;
            if (rb_Opencheckant.Checked)
                CheckAnt = 1;
            else
                CheckAnt = 0;
            fCmdRet = RWDev.SetCheckAnt(ref fComAdr, CheckAnt, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "Set antenna check failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "Set antenna check success ";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void Button_Ant_Click(object sender, EventArgs e)
        {
            byte ANT = 0;
            byte ANT1 = 0;
            if (checkant1.Checked) ANT = Convert.ToByte(ANT | 1);
            if (checkant2.Checked) ANT = Convert.ToByte(ANT | 2);
            if (checkant3.Checked) ANT = Convert.ToByte(ANT | 4);
            if (checkant4.Checked) ANT = Convert.ToByte(ANT | 8);
            ANT1 = ANT;
            fCmdRet = RWDev.SetAntennaMultiplexing(ref fComAdr, ANT, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "Antenna config failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                if ((ANT1 & 0x01) == 1)
                {
                    check_ant1.Checked = true;
                    BAnt1.Checked = true;
                }
                else
                {
                    check_ant1.Checked = false;
                    BAnt1.Checked = false;
                }

                if ((ANT1 & 0x02) == 2)
                {
                    check_ant2.Checked = true;
                    BAnt2.Checked = true;
                }
                else
                {
                    check_ant2.Checked = false;
                    BAnt2.Checked = false;
                }

                if ((ANT1 & 0x04) == 4)
                {
                    check_ant3.Checked = true;
                    BAnt3.Checked = true;
                }
                else
                {
                    check_ant3.Checked = false;
                    BAnt3.Checked = false;
                }

                if ((ANT1 & 0x08) == 8)
                {
                    check_ant4.Checked = true;
                    BAnt4.Checked = true;
                }
                else
                {
                    check_ant4.Checked = false;
                    BAnt4.Checked = false;
                }
                string strLog = "Antenna config success ";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void ClockCMD_Click(object sender, EventArgs e)
        {
            byte[] SetTime = new byte[6];
            byte[] CurrentTime = new byte[6];
            if (SetClock.Checked)
            {
                if ((Text_year.Text == "") || (Text_month.Text == "") || (Text_day.Text == "") || (Text_hour.Text == "") || (Text_min.Text == "") || (Text_sec.Text == ""))
                {
                    MessageBox.Show("Please input right data", "information");
                    return;
                }
                SetTime[0] = Convert.ToByte(Text_year.Text);       //需要设置的时间
                SetTime[1] = Convert.ToByte(Text_month.Text);
                SetTime[2] = Convert.ToByte(Text_day.Text);
                SetTime[3] = Convert.ToByte(Text_hour.Text);
                SetTime[4] = Convert.ToByte(Text_min.Text);
                SetTime[5] = Convert.ToByte(Text_sec.Text);

                if ((Convert.ToByte(Text_year.Text) < 0) || (Convert.ToByte(Text_year.Text) > 0x63))
                {
                    MessageBox.Show("Please input data from 00-99", "information");
                    return;
                }
                fCmdRet = RWDev.SetReal_timeClock(ref fComAdr, SetTime, frmcomportindex);
                if (fCmdRet != 0)
                {
                    string strLog = "Set real-time clock failed: " + GetReturnCodeDesc(fCmdRet);
                    WriteLog(lrtxtLog, strLog, 1);
                }
                else
                {
                    string strLog = "Set real-time clock success ";
                    WriteLog(lrtxtLog, strLog, 0);
                }
            }
            else
            {
                fCmdRet = RWDev.GetTime(ref fComAdr, CurrentTime, frmcomportindex);
                if (fCmdRet != 0)
                {
                    string strLog = "Get real-time clock failed: " + GetReturnCodeDesc(fCmdRet);
                    WriteLog(lrtxtLog, strLog, 1);
                }
                else
                {
                    Text_year.Text = Convert.ToString(CurrentTime[0]).PadLeft(2, '0');
                    Text_month.Text = Convert.ToString(CurrentTime[1]).PadLeft(2, '0');
                    Text_day.Text = Convert.ToString(CurrentTime[2]).PadLeft(2, '0');
                    Text_hour.Text = Convert.ToString(CurrentTime[3]).PadLeft(2, '0');
                    Text_min.Text = Convert.ToString(CurrentTime[4]).PadLeft(2, '0');
                    Text_sec.Text = Convert.ToString(CurrentTime[5]).PadLeft(2, '0');
                    string strLog = "Get real-time clock success ";
                    WriteLog(lrtxtLog, strLog, 0);
                }
            }
        }

        private void btAccuracy_Click(object sender, EventArgs e)
        {
            byte Accuracy = Convert.ToByte(ComboBox_Accuracy.SelectedIndex);
            if (rbEASAcc.Checked)
                Accuracy = Convert.ToByte(Accuracy | 0x80);
            fCmdRet = RWDev.SetEASSensitivity(ref fComAdr, Accuracy, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "Set EAS sensitivity failed:" + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "Set EAS sensitivity success ";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void btMaskSet_Click(object sender, EventArgs e)
        {
            byte MaskMem = 0;
            byte[] MaskAdr = new byte[2];
            byte MaskLen = 0;
            byte[] MaskData = new byte[100];
            if ((text_madds.Text.Length != 4) || (text_mlen.Text.Length != 2) || (text_mdata.Text.Length % 2 != 0))
            {
                MessageBox.Show("Please input right data", "information");
                return;
            }
            if (rb_MaskEPC.Checked) MaskMem = 1;
            if (rb_MaskTID.Checked) MaskMem = 2;
            if (rb_MaskUser.Checked) MaskMem = 3;
            MaskAdr = HexStringToByteArray(text_madds.Text.Trim());
            MaskLen = Convert.ToByte(text_mlen.Text, 16);
            MaskData = HexStringToByteArray(text_mdata.Text.Trim());
            fCmdRet = RWDev.SetMask(ref fComAdr, MaskMem, MaskAdr, MaskLen, MaskData, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "Set mask failed:" + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "Set mask success ";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void bt_typeTag_Click(object sender, EventArgs e)
        {
            byte Protocol = 0;
            if (rb_180006c.Checked)
            {
                if (rb_G2.Checked) Protocol = 0;
                if (rb_EAS.Checked) Protocol = 2;
                if (rb_G2TID.Checked) Protocol = 0x10;
            }
            else
            {
                Protocol = 0x80;
            }
            fCmdRet = RWDev.SelectTagType(ref fComAdr, Protocol, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "Set tag type failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "Set tag type success";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void bttrigger_Click(object sender, EventArgs e)
        {
            byte TriggerTime = 0;
            TriggerTime = Convert.ToByte(comboBox_trigger.SelectedIndex);
            fCmdRet = RWDev.SetTriggerTime(ref fComAdr, TriggerTime, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "Set trigger time failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "Set trigger time success ";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void btTIDpara_Click(object sender, EventArgs e)
        {
            byte LenTID = 0;
            byte AdrTID = 0;
            if ((text_tidaddr.Text.Length != 2) || (text_tidlen.Text.Length != 2))
            {
                MessageBox.Show("TID parameter error", "Information");
                return;
            }
            AdrTID = Convert.ToByte(text_tidaddr.Text, 16);
            LenTID = Convert.ToByte(text_tidlen.Text, 16);
            fCmdRet = RWDev.SetTIDParameter(ref fComAdr, AdrTID, LenTID, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "Set TID parameter failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "Set TID parameter success ";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void btSetQS_Click(object sender, EventArgs e)
        {
            byte QValue, Session;
            QValue = Convert.ToByte(com_acQ.SelectedIndex);
            Session = Convert.ToByte(com_acS.SelectedIndex);
            fCmdRet = RWDev.SetQS(ref fComAdr, QValue, Session, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "Set Q/Session failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "Set Q/Session success  ";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void btGetQS_Click(object sender, EventArgs e)
        {
            byte QValue, Session;
            QValue = 0;
            Session = 0;
            fCmdRet = RWDev.GetQS(ref fComAdr, ref QValue, ref Session, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "Get Q/Session failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                com_acQ.SelectedIndex = QValue;
                com_acS.SelectedIndex = Session;
                string strLog = "Get Q/Session success ";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void btInterval_Click(object sender, EventArgs e)
        {
            byte ReadPauseTim = 0;
            ReadPauseTim = Convert.ToByte(comboBox_intervalT.SelectedIndex);
            fCmdRet = RWDev.SetInventoryInterval(ref fComAdr, ReadPauseTim, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "Set inventory interval failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "Set inventory interval success ";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void btSelectTag_Click(object sender, EventArgs e)
        {
            text_epc.Text = comboBox_EPC.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                maskadr_textbox.Enabled = true;
                maskLen_textBox.Enabled = true;
                maskData_textBox.Enabled = true;
                R_EPC.Enabled = true;
                R_TID.Enabled = true;
                R_User.Enabled = true;
            }
            else
            {
                maskadr_textbox.Enabled = false;
                maskLen_textBox.Enabled = false;
                maskData_textBox.Enabled = false;
                R_EPC.Enabled = false;
                R_TID.Enabled = false;
                R_User.Enabled = false;
            }
        }
        //E200 F351 4818 3C90 07C2 5000 10BC 9D00
        private void btRead_Click(object sender, EventArgs e)
        {
            byte WordPtr, ENum;
            byte Num = 0;
            byte Mem = 0;
            string str = ""; ;
            byte[] CardData = new byte[320];
            byte MaskMem = 0;
            byte[] MaskAdr = new byte[2];
            byte MaskLen = 0;
            byte[] MaskData = new byte[100];
            text_WriteData.Text = "";
            if (checkBox1.Checked)
            {
                if ((maskadr_textbox.Text == "") || (maskLen_textBox.Text == "") || (maskData_textBox.Text == ""))
                {
                    return;
                }
                ENum = 255;
                if (R_EPC.Checked) MaskMem = 1;
                if (R_TID.Checked) MaskMem = 2;
                if (R_User.Checked) MaskMem = 3;
                MaskAdr = HexStringToByteArray(maskadr_textbox.Text);
                MaskLen = Convert.ToByte(maskLen_textBox.Text, 16);
                MaskData = HexStringToByteArray(maskData_textBox.Text);
            }
            else
            {
                if (check_selecttag.Checked)
                    str = text_epc.Text;
                else
                    str = "";
                ENum = Convert.ToByte(str.Length / 4);
            }
            byte[] EPC = new byte[ENum * 2];
            EPC = HexStringToByteArray(str);
            if (C_Reserve.Checked)
                Mem = 0;
            if (C_EPC.Checked)
                Mem = 1;
            if (C_TID.Checked)
                Mem = 2;
            if (C_User.Checked)
                Mem = 3;
            if (text_WordPtr.Text == "" || text_RWlen.Text == "" || text_AccessCode2.Text.Length != 8)
            {
                return;
            }
            WordPtr = (byte)Convert.ToInt32(text_WordPtr.Text, 16);
            Num = Convert.ToByte(text_RWlen.Text);
            fPassWord = HexStringToByteArray(text_AccessCode2.Text);
            for (int p = 0; p < 10; p++)
            {
                fCmdRet = RWDev.ReadData_G2(ref fComAdr, EPC, ENum, Mem, WordPtr, Num, fPassWord, MaskMem, MaskAdr, MaskLen, MaskData, CardData, ref ferrorcode, frmcomportindex);
                if (fCmdRet == 0) break;
            }
            if (fCmdRet != 0)
            {

                string strLog = "";
                if (fCmdRet == 0xFC)
                    strLog = "Read failed " + "Return = 0x" + Convert.ToString(ferrorcode, 16) + "(" + GetErrorCodeDesc(ferrorcode) + ")";
                else
                    strLog = "Read failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                byte[] daw = new byte[Num * 2];
                Array.Copy(CardData, daw, Num * 2);
                text_WriteData.Text = ByteArrayToHexString(daw);
                string strLog = "Read success ";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void btWrite_Click(object sender, EventArgs e)
        {
            byte WordPtr, ENum;
            byte WNum = 0;
            byte Mem = 0;
            string str = ""; ;
            byte[] CardData = new byte[320];
            byte MaskMem = 0;
            byte[] MaskAdr = new byte[2];
            byte MaskLen = 0;
            byte[] MaskData = new byte[100];
            if (checkBox1.Checked)
            {
                if ((maskadr_textbox.Text == "") || (maskLen_textBox.Text == "") || (maskData_textBox.Text == ""))
                {
                    return;
                }
                ENum = 255;
                if (R_EPC.Checked) MaskMem = 1;
                if (R_TID.Checked) MaskMem = 2;
                if (R_User.Checked) MaskMem = 3;
                MaskAdr = HexStringToByteArray(maskadr_textbox.Text);
                MaskLen = Convert.ToByte(maskLen_textBox.Text, 16);
                MaskData = HexStringToByteArray(maskData_textBox.Text);
            }
            else
            {
                if (check_selecttag.Checked)
                    str = text_epc.Text;
                else
                    str = "";
                ENum = Convert.ToByte(str.Length / 4);
            }
            byte[] EPC = new byte[ENum * 2];
            EPC = HexStringToByteArray(str);
            if (C_Reserve.Checked)
                Mem = 0;
            if (C_EPC.Checked)
                Mem = 1;
            if (C_TID.Checked)
                Mem = 2;
            if (C_User.Checked)
                Mem = 3;
            if (text_WordPtr.Text == "" || text_AccessCode2.Text.Length != 8)
            {
                return;
            }
            string epcstr = text_WriteData.Text;
            if (epcstr.Length % 4 != 0 || epcstr.Length == 0)
            {
                MessageBox.Show("Input data by word.", "Write");
                return;
            }
            WNum = Convert.ToByte(epcstr.Length / 4);
            byte[] Writedata = new byte[WNum * 2 + 1];
            Writedata = HexStringToByteArray(epcstr);
            WordPtr = (byte)Convert.ToInt32(text_WordPtr.Text, 16);
            fPassWord = HexStringToByteArray(text_AccessCode2.Text);
            if ((checkBox_pc.Checked) && (C_EPC.Checked))
            {
                WordPtr = 1;
                WNum = Convert.ToByte(epcstr.Length / 4 + 1);
                Writedata = HexStringToByteArray(textBox_pc.Text + epcstr);
            }
            for (int p = 0; p < 10; p++)
            {
                fCmdRet = RWDev.WriteData_G2(ref fComAdr, EPC, WNum, ENum, Mem, WordPtr, Writedata, fPassWord, MaskMem, MaskAdr, MaskLen, MaskData, ref ferrorcode, frmcomportindex);
                if (fCmdRet == 0) break;
            }
            if (fCmdRet != 0)
            {
                string strLog = "";
                if (fCmdRet == 0xFC)
                    strLog = "Write failed: " + "Return = 0x" + Convert.ToString(ferrorcode, 16) + "(" + GetErrorCodeDesc(ferrorcode) + ")";
                else
                    strLog = "Write failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "Write success ";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void checkBox_pc_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_pc.Checked && C_EPC.Checked)
            {
                text_WordPtr.Text = "0002";
                text_WordPtr.ReadOnly = true;
                int m, n;
                n = text_WriteData.Text.Length;
                if (n % 4 == 0)
                {
                    m = n / 4;
                    m = (m & 0x3F) << 3;
                    textBox_pc.Text = Convert.ToString(m, 16).PadLeft(2, '0') + "00";
                }
            }
            else
            {
                text_WordPtr.ReadOnly = false;
            }
        }

        private void text_WriteData_TextChanged(object sender, EventArgs e)
        {
            int m, n;
            n = text_WriteData.Text.Length;
            if ((checkBox_pc.Checked) && (n % 4 == 0) && (C_EPC.Checked))
            {
                m = n / 4;
                m = (m & 0x3F) << 3;
                textBox_pc.Text = Convert.ToString(m, 16).PadLeft(2, '0') + "00";
            }
        }

        private void C_EPC_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_pc.Checked)
            {
                text_WordPtr.Text = "0002";
                text_WordPtr.ReadOnly = true;
            }
            else
            {
                text_WordPtr.ReadOnly = false;
            }
        }

        private void btBlockWrite_Click(object sender, EventArgs e)
        {
            byte WordPtr, ENum;
            byte WNum = 0;
            byte Mem = 0;
            string str = ""; ;
            byte[] CardData = new byte[320];
            byte MaskMem = 0;
            byte[] MaskAdr = new byte[2];
            byte MaskLen = 0;
            byte[] MaskData = new byte[100];
            if (checkBox1.Checked)
            {
                if ((maskadr_textbox.Text == "") || (maskLen_textBox.Text == "") || (maskData_textBox.Text == ""))
                {
                    return;
                }
                ENum = 255;
                if (R_EPC.Checked) MaskMem = 1;
                if (R_TID.Checked) MaskMem = 2;
                if (R_User.Checked) MaskMem = 3;
                MaskAdr = HexStringToByteArray(maskadr_textbox.Text);
                MaskLen = Convert.ToByte(maskLen_textBox.Text, 16);
                MaskData = HexStringToByteArray(maskData_textBox.Text);
            }
            else
            {
                if (check_selecttag.Checked)
                    str = text_epc.Text;
                else
                    str = "";
                ENum = Convert.ToByte(str.Length / 4);
            }
            byte[] EPC = new byte[ENum * 2];
            EPC = HexStringToByteArray(str);
            if (C_Reserve.Checked)
                Mem = 0;
            if (C_EPC.Checked)
                Mem = 1;
            if (C_TID.Checked)
                Mem = 2;
            if (C_User.Checked)
                Mem = 3;
            if (text_WordPtr.Text == "" || text_AccessCode2.Text.Length != 8)
            {
                return;
            }
            string epcstr = text_WriteData.Text;
            if (epcstr.Length % 4 != 0 || epcstr.Length == 0)
            {
                MessageBox.Show("Input data by word.", "Write");
                return;
            }
            WNum = Convert.ToByte(epcstr.Length / 4);
            byte[] Writedata = new byte[WNum * 2 + 1];
            Writedata = HexStringToByteArray(epcstr);
            WordPtr = (byte)Convert.ToInt32(text_WordPtr.Text, 16);
            fPassWord = HexStringToByteArray(text_AccessCode2.Text);
            if ((checkBox_pc.Checked) && (C_EPC.Checked))
            {
                WordPtr = 1;
                WNum = Convert.ToByte(epcstr.Length / 4 + 1);
                Writedata = HexStringToByteArray(textBox_pc.Text + epcstr);
            }
            for (int p = 0; p < 10; p++)
            {
                fCmdRet = RWDev.BlockWrite_G2(ref fComAdr, EPC, WNum, ENum, Mem, WordPtr, Writedata, fPassWord, MaskMem, MaskAdr, MaskLen, MaskData, ref ferrorcode, frmcomportindex);
                if (fCmdRet == 0) break;
            }
            if (fCmdRet != 0)
            {
                string strLog = "";
                if (fCmdRet == 0xFC)
                    strLog = "Block write failed: " + "Return = 0x" + Convert.ToString(ferrorcode, 16) + "(" + GetErrorCodeDesc(ferrorcode) + ")";
                else
                    strLog = "Block write failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "Block write success";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void btBlockErase_Click(object sender, EventArgs e)
        {
            byte WordPtr, ENum;
            byte Num = 0;
            byte Mem = 0;
            string str = ""; ;
            byte MaskMem = 0;
            byte[] MaskAdr = new byte[2];
            byte MaskLen = 0;
            byte[] MaskData = new byte[100];
            text_WriteData.Text = "";
            if (checkBox1.Checked)
            {
                if ((maskadr_textbox.Text == "") || (maskLen_textBox.Text == "") || (maskData_textBox.Text == ""))
                {
                    return;
                }
                ENum = 255;
                if (R_EPC.Checked) MaskMem = 1;
                if (R_TID.Checked) MaskMem = 2;
                if (R_User.Checked) MaskMem = 3;
                MaskAdr = HexStringToByteArray(maskadr_textbox.Text);
                MaskLen = Convert.ToByte(maskLen_textBox.Text, 16);
                MaskData = HexStringToByteArray(maskData_textBox.Text);
            }
            else
            {
                if (check_selecttag.Checked)
                    str = text_epc.Text;
                else
                    str = "";
                ENum = Convert.ToByte(str.Length / 4);
            }
            byte[] EPC = new byte[ENum * 2];
            EPC = HexStringToByteArray(str);
            if (C_Reserve.Checked)
                Mem = 0;
            if (C_EPC.Checked)
                Mem = 1;
            if (C_TID.Checked)
                Mem = 2;
            if (C_User.Checked)
                Mem = 3;
            if (text_WordPtr.Text == "" || text_RWlen.Text == "" || text_AccessCode2.Text.Length != 8)
            {
                return;
            }
            WordPtr = (byte)Convert.ToInt32(text_WordPtr.Text, 16);
            Num = Convert.ToByte(text_RWlen.Text);
            fPassWord = HexStringToByteArray(text_AccessCode2.Text);
            fCmdRet = RWDev.BlockErase_G2(ref fComAdr, EPC, ENum, Mem, WordPtr, Num, fPassWord, MaskMem, MaskAdr, MaskLen, MaskData, ref ferrorcode, frmcomportindex);
            if (fCmdRet != 0)
            {

                string strLog = "";
                if (fCmdRet == 0xFC)
                    strLog = "Block erase failed: " + "Return = 0x" + Convert.ToString(ferrorcode, 16) + "(" + GetErrorCodeDesc(ferrorcode) + ")";
                else
                    strLog = "Block erase failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "Block erase success";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void btSetProtectState_Click(object sender, EventArgs e)
        {
            byte select = 0;
            byte setprotect = 0;
            string str = "";
            byte ENum;
            byte[] CardData = new byte[320];
            byte MaskMem = 0;
            byte[] MaskAdr = new byte[2];
            byte MaskLen = 0;
            byte[] MaskData = new byte[100];
            if (checkBox1.Checked)
            {
                if ((maskadr_textbox.Text.Length != 4) || (maskLen_textBox.Text.Length != 2) || (maskData_textBox.Text.Length % 2 != 0) && (maskData_textBox.Text.Length == 0))
                {
                    MessageBox.Show("Mask data error", "Information");
                    return;
                }
                ENum = 255;
                if (R_EPC.Checked) MaskMem = 1;
                if (R_TID.Checked) MaskMem = 2;
                if (R_User.Checked) MaskMem = 3;
                MaskAdr = HexStringToByteArray(maskadr_textbox.Text);
                MaskLen = Convert.ToByte(maskLen_textBox.Text, 16);
                MaskData = HexStringToByteArray(maskData_textBox.Text);
            }
            else
            {
                if (check_selecttag.Checked)
                    str = text_epc.Text;
                else
                    str = "";
                ENum = Convert.ToByte(str.Length / 4);
            }
            byte[] EPC = new byte[ENum * 2];
            EPC = HexStringToByteArray(str);
            if (Edit_AccessCode6.Text.Length != 8)
            {
                MessageBox.Show("Access Password Less Than 8 digit!", "Information");
                return;
            }
            fPassWord = HexStringToByteArray(Edit_AccessCode6.Text);
            if (P_kill.Checked)
                select = 0x00;
            else if (p_pass.Checked)
                select = 0x01;
            else if (P_EPC.Checked)
                select = 0x02;
            else if (P_TID.Checked)
                select = 0x03;
            else if (P_User.Checked)
                select = 0x04;

            if (NoProect2.Checked)
                setprotect = 0x00;
            else if (Proect2.Checked)
                setprotect = 0x02;
            else if (Always2.Checked)
            {
                setprotect = 0x01;
                if (MessageBox.Show(this, "Set unlock forever?", "Information", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    return;
            }
            else if (AlwaysNot2.Checked)
            {
                setprotect = 0x03;
                if (MessageBox.Show(this, "Set lock forever?", "Information", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    return;
            }
            fCmdRet = RWDev.Lock_G2(ref fComAdr, EPC, ENum, select, setprotect, fPassWord, MaskMem, MaskAdr, MaskLen, MaskData, ref ferrorcode, frmcomportindex);
            if (fCmdRet != 0)
            {

                string strLog = "";
                if (fCmdRet == 0xFC)
                    strLog = "Lock failed: " + "Return = 0x" + Convert.ToString(ferrorcode, 16) + "(" + GetErrorCodeDesc(ferrorcode) + ")";
                else
                    strLog = "Lock failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "Lock success ";
                WriteLog(lrtxtLog, strLog, 0);
            }

        }

        private void btDestroyCard_Click(object sender, EventArgs e)
        {
            string str = "";
            byte ENum;
            byte[] CardData = new byte[320];
            byte MaskMem = 0;
            byte[] MaskAdr = new byte[2];
            byte MaskLen = 0;
            byte[] MaskData = new byte[100];

            if (checkBox1.Checked)
            {
                if ((maskadr_textbox.Text.Length != 4) || (maskLen_textBox.Text.Length != 2) || (maskData_textBox.Text.Length % 2 != 0) && (maskData_textBox.Text.Length == 0))
                {
                    MessageBox.Show("Mask data error!", "Information");
                    return;
                }
                ENum = 255;
                if (R_EPC.Checked) MaskMem = 1;
                if (R_TID.Checked) MaskMem = 2;
                if (R_User.Checked) MaskMem = 3;
                MaskAdr = HexStringToByteArray(maskadr_textbox.Text);
                MaskLen = Convert.ToByte(maskLen_textBox.Text, 16);
                MaskData = HexStringToByteArray(maskData_textBox.Text);
            }
            else
            {
                if (check_selecttag.Checked)
                    str = text_epc.Text;
                else
                    str = "";
                ENum = Convert.ToByte(str.Length / 4);
            }
            byte[] EPC = new byte[ENum * 2];
            EPC = HexStringToByteArray(str);
            if (text_DestroyCode.Text.Length != 8)
            {
                MessageBox.Show("Access Password Less Than 8 digit!", "Information");
                return;
            }
            fPassWord = HexStringToByteArray(text_DestroyCode.Text);
            fCmdRet = RWDev.KillTag_G2(ref fComAdr, EPC, ENum, fPassWord, MaskMem, MaskAdr, MaskLen, MaskData, ref ferrorcode, frmcomportindex);
            if (fCmdRet != 0)
            {

                string strLog = "";
                if (fCmdRet == 0xFC)
                    strLog = "Kill tag failed: " + "Return = 0x" + Convert.ToString(ferrorcode, 16) + "(" + GetErrorCodeDesc(ferrorcode) + ")";
                else
                    strLog = "Kill tag failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "Kill tag success ";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void btWriteEPC_G2_Click(object sender, EventArgs e)
        {
            byte[] WriteEPC = new byte[200];
            byte WriteEPClen;
            byte ENum;
            if (text_AccessCode3.Text.Length < 8)
            {
                MessageBox.Show("Access Password Less Than 8 digit!", "Information");
                return;
            }
            if ((text_WriteEPC.Text.Length % 4) != 0 || text_WriteEPC.Text.Length == 0)
            {
                MessageBox.Show("Please input Data by words in hexadecimal form!'+#13+#10+'For example: 1234、12345678", "information");
                return;
            }
            WriteEPClen = Convert.ToByte(text_WriteEPC.Text.Length / 2);
            ENum = Convert.ToByte(text_WriteEPC.Text.Length / 4);
            byte[] EPC = new byte[ENum];
            EPC = HexStringToByteArray(text_WriteEPC.Text);
            fPassWord = HexStringToByteArray(text_AccessCode3.Text);
            fCmdRet = RWDev.WriteEPC_G2(ref fComAdr, fPassWord, EPC, ENum, ref ferrorcode, frmcomportindex);
            if (fCmdRet != 0)
            {

                string strLog = "";
                if (fCmdRet == 0xFC)
                    strLog = "Write EPC failed: " + "Return = 0x" + Convert.ToString(ferrorcode, 16) + "(" + GetErrorCodeDesc(ferrorcode) + ")";
                else
                    strLog = "Write EPC failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                if (comboBox_EPC.Items.IndexOf(text_WriteEPC.Text) == -1)
                    comboBox_EPC.Items.Add(text_WriteEPC.Text);
                string strLog = "Write EPC success ";
                WriteLog(lrtxtLog, strLog, 0);
            }

        }

        private void btSetReadProtect_G2_Click(object sender, EventArgs e)
        {
            string str = "";
            byte ENum;
            byte MaskMem = 0;
            byte[] MaskAdr = new byte[2];
            byte MaskLen = 0;
            byte[] MaskData = new byte[100];
            if (checkBox1.Checked)
            {
                if ((maskadr_textbox.Text.Length != 4) || (maskLen_textBox.Text.Length != 2) || (maskData_textBox.Text.Length % 2 != 0) && (maskData_textBox.Text.Length == 0))
                {
                    MessageBox.Show("Mask data error", "Information");
                    return;
                }
                ENum = 255;
                if (R_EPC.Checked) MaskMem = 1;
                if (R_TID.Checked) MaskMem = 2;
                if (R_User.Checked) MaskMem = 3;
                MaskAdr = HexStringToByteArray(maskadr_textbox.Text);
                MaskLen = Convert.ToByte(maskLen_textBox.Text, 16);
                MaskData = HexStringToByteArray(maskData_textBox.Text);
            }
            else
            {
                if (check_selecttag.Checked)
                    str = text_epc.Text;
                else
                    str = "";
                ENum = Convert.ToByte(str.Length / 4);
            }
            byte[] EPC = new byte[ENum * 2];
            EPC = HexStringToByteArray(str);
            if (text_AccessCode4.Text.Length != 8)
            {
                MessageBox.Show("Access Password Less Than 8 digit!Please input again!!", "information");
                return;
            }
            fPassWord = HexStringToByteArray(text_AccessCode4.Text);
            fCmdRet = RWDev.SetPrivacyByEPC_G2(ref fComAdr, EPC, ENum, fPassWord, MaskMem, MaskAdr, MaskLen, MaskData, ref ferrorcode, frmcomportindex);
            if (fCmdRet != 0)
            {

                string strLog = "";
                if (fCmdRet == 0xFC)
                    strLog = "Set privacy by EPC failed: " + "Return = 0x" + Convert.ToString(ferrorcode, 16) + "(" + GetErrorCodeDesc(ferrorcode) + ")";
                else
                    strLog = "Set privacy by EPC failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "Set privacy by EPC success";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void btSetMultiReadProtect_G2_Click(object sender, EventArgs e)
        {
            if (text_AccessCode4.Text.Length != 8)
            {
                MessageBox.Show("Access Password Less Than 8 digit!Please input again!!", "information");
                return;
            }
            fPassWord = HexStringToByteArray(text_AccessCode4.Text);
            fCmdRet = RWDev.SetPrivacyWithoutEPC_G2(ref fComAdr, fPassWord, ref ferrorcode, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "";
                if (fCmdRet == 0xFC)
                    strLog = "Set privacy without EPC failed: " + "Return = 0x" + Convert.ToString(ferrorcode, 16) + "(" + GetErrorCodeDesc(ferrorcode) + ")";
                else
                    strLog = "Set privacy without EPC failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "Set privacy without EPC success: ";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void btRemoveReadProtect_G2_Click(object sender, EventArgs e)
        {
            if (text_AccessCode4.Text.Length != 8)
            {
                MessageBox.Show("Access Password Less Than 8 digit!Please input again!!", "information");
                return;
            }
            fPassWord = HexStringToByteArray(text_AccessCode4.Text);
            fCmdRet = RWDev.ResetPrivacy_G2(ref fComAdr, fPassWord, ref ferrorcode, frmcomportindex);
            if (fCmdRet != 0)
            {

                string strLog = "";
                if (fCmdRet == 0xFC)
                    strLog = "Reset privacy failed: " + "Return = 0x" + Convert.ToString(ferrorcode, 16) + "(" + GetErrorCodeDesc(ferrorcode) + ")";
                else
                    strLog = "Reset privacy failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "Reset privacy success ";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void btCheckReadProtected_G2_Click(object sender, EventArgs e)
        {
            byte readpro = 2;
            fCmdRet = RWDev.CheckPrivacy_G2(ref fComAdr, ref readpro, ref ferrorcode, frmcomportindex);
            if (fCmdRet != 0)
            {

                string strLog = "";
                if (fCmdRet == 0xFC)
                    strLog = "Check privacy faile: " + "Return = 0x" + Convert.ToString(ferrorcode, 16) + "(" + GetErrorCodeDesc(ferrorcode) + ")";
                else
                    strLog = "Check privacy faile: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "";
                if (readpro == 0)
                    strLog = " 'Check privacy success'command return=0x00" + "(Single Tag is unprotected)";
                if (readpro == 1)
                    strLog = " 'Check privacy success'command return=0x01" + "(Single Tag is protected)";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void btSetEASAlarm_G2_Click(object sender, EventArgs e)
        {
            byte EAS = 0;
            byte ENum;
            string str = "";
            byte MaskMem = 0;
            byte[] MaskAdr = new byte[2];
            byte MaskLen = 0;
            byte[] MaskData = new byte[100];
            text_WriteData.Text = "";
            if (checkBox1.Checked)
            {
                if ((maskadr_textbox.Text == "") || (maskLen_textBox.Text == "") || (maskData_textBox.Text == ""))
                {
                    return;
                }
                ENum = 255;
                if (R_EPC.Checked) MaskMem = 1;
                if (R_TID.Checked) MaskMem = 2;
                if (R_User.Checked) MaskMem = 3;
                MaskAdr = HexStringToByteArray(maskadr_textbox.Text);
                MaskLen = Convert.ToByte(maskLen_textBox.Text, 16);
                MaskData = HexStringToByteArray(maskData_textBox.Text);
            }
            else
            {
                if (check_selecttag.Checked)
                    str = text_epc.Text;
                else
                    str = "";
                ENum = Convert.ToByte(str.Length / 4);
            }
            byte[] EPC = new byte[ENum * 2];
            EPC = HexStringToByteArray(str);
            if (text_AccessCode5.Text.Length != 8)
            {
                MessageBox.Show("Access Password Less Than 8 digit!Please input again!!", "information");
                return;
            }
            fPassWord = HexStringToByteArray(text_AccessCode5.Text);
            if (Alarm_G2.Checked)
                EAS = 1;
            else
                EAS = 0;
            fCmdRet = RWDev.EASConfigure_G2(ref fComAdr, EPC, ENum, fPassWord, EAS, MaskMem, MaskAdr, MaskLen, MaskData, ref ferrorcode, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "EAS Configure failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "";
                if (Alarm_G2.Checked)
                    strLog = " 'EAS Configure' command return=0x00" + "(Set EAS Alarm successfully)";
                else
                    strLog = " 'EAS Configure' command return=0x00" + "(Clear EAS Alarm successfully)";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void btCheckEASAlarm_Click(object sender, EventArgs e)
        {
            timer_EAS.Enabled = !timer_EAS.Enabled;
            if (!timer_EAS.Enabled)
            {
                pictureBox2.Visible = false;
                btCheckEASAlarm.Text = "Detect";
                btCheckEASAlarm.BackColor = Color.Transparent;
            }
            else
            {
                fIsInventoryScan = false;
                btCheckEASAlarm.Text = "Stop";
                btCheckEASAlarm.BackColor = Color.Indigo;
            }
        }

        private void timer_EAS_Tick(object sender, EventArgs e)
        {
            if (fIsInventoryScan)
                return;
            fIsInventoryScan = true;
            fCmdRet = RWDev.EASAlarm_G2(ref fComAdr, ref ferrorcode, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "No EAS Alarm";
                WriteLog(lrtxtLog, strLog, 1);
                pictureBox2.Visible = false;
            }
            else
            {
                pictureBox2.Visible = true;
                string strLog = "EAS Alarm";
                WriteLog(lrtxtLog, strLog, 0);
            }
            fIsInventoryScan = false;
        }

        private void btInventory6B_Click(object sender, EventArgs e)
        {
            Timer_Test_6B.Enabled = !Timer_Test_6B.Enabled;
            if (!Timer_Test_6B.Enabled)
            {
                btInventory6B.Text = "Start";
                btInventory6B.BackColor = Color.Transparent;
            }
            else
            {
                fisinventoryscan_6B = false;
                ListView_ID_6B.Items.Clear();
                btInventory6B.BackColor = Color.Indigo;
                btInventory6B.Text = "Stop";
            }
        }
        public void ChangeSubItem1(ListViewItem ListItem, int subItemIndex, string ItemText, string ant, string RSSI)
        {
            if (subItemIndex == 1)
            {
                if (ListItem.SubItems[subItemIndex].Text != ItemText)
                {
                    ListItem.SubItems[subItemIndex].Text = ItemText;
                    ListItem.SubItems[subItemIndex + 2].Text = "1";
                    ListItem.SubItems[subItemIndex + 1].Text = ant;
                }
                else
                {
                    ListItem.SubItems[subItemIndex + 2].Text = Convert.ToString(Convert.ToUInt32(ListItem.SubItems[subItemIndex + 2].Text) + 1);
                    if ((Convert.ToUInt32(ListItem.SubItems[subItemIndex + 2].Text) > 9999))
                        ListItem.SubItems[subItemIndex + 2].Text = "1";
                    ListItem.SubItems[subItemIndex + 1].Text = Convert.ToString(Convert.ToInt32(ListItem.SubItems[subItemIndex + 1].Text, 2) | Convert.ToInt32(ant, 2), 2).PadLeft(4, '0');

                }
                ListItem.SubItems[subItemIndex + 3].Text = RSSI;
            }
        }
        private void Inventory_6B()
        {
            int CardNum = 0;
            byte[] ID_6B = new byte[2000];
            byte[] ID2_6B = new byte[5000];
            bool isonlistview;
            string temps;
            string s, ss, sID;
            ListViewItem aListItem = new ListViewItem();
            int i, j;
            byte Condition = 0;
            byte StartAddress;
            byte mask = 0;
            byte[] ConditionContent = new byte[300];
            byte ant = 0;
            if (rb_single.Checked)
            {
                fCmdRet = RWDev.InventorySingle_6B(ref fComAdr, ref ant, ID_6B, frmcomportindex);
                if (fCmdRet == 0)
                {
                    byte[] daw = new byte[10];
                    Array.Copy(ID_6B, daw, 10);
                    temps = ByteArrayToHexString(daw);
                    string RSSI = daw[9].ToString();
                    temps = temps.Substring(2, 16);

                    if (!list.Contains(temps))
                    {
                        CardNum1 = CardNum1 + 1;
                        list.Add(temps);
                    }
                    string sant = Convert.ToString(ant, 2).PadLeft(4, '0');
                    isonlistview = false;
                    for (i = 0; i < ListView_ID_6B.Items.Count; i++)     //判断是否在ListView列表内
                    {
                        if (temps == ListView_ID_6B.Items[i].SubItems[1].Text)
                        {
                            aListItem = ListView_ID_6B.Items[i];
                            ChangeSubItem1(aListItem, 1, temps, sant, RSSI);
                            isonlistview = true;
                            break;
                        }
                    }
                    if (!isonlistview)
                    {
                        aListItem = ListView_ID_6B.Items.Add((ListView_ID_6B.Items.Count + 1).ToString());
                        aListItem.SubItems.Add("");
                        aListItem.SubItems.Add("");
                        aListItem.SubItems.Add("");
                        aListItem.SubItems.Add("");
                        aListItem.SubItems.Add("");
                        s = temps;
                        ChangeSubItem1(aListItem, 1, s, sant, RSSI);
                    }
                }
            }
            if (rb_mutiple.Checked)
            {
                Condition = 1;
                ss = "0000000000000000";//4种条件这里选择的是非全0的标签
                byte[] daw = HexStringToByteArray(ss);
                mask = 0xFF;
                StartAddress = 0;
                CardNum = 0;
                fCmdRet = RWDev.InventoryMultiple_6B(ref fComAdr, Condition, StartAddress, mask, daw, ref ant, ID2_6B, ref CardNum, frmcomportindex);
                if ((fCmdRet == 0x15) | (fCmdRet == 0x16) | (fCmdRet == 0x17) | (fCmdRet == 0x18) | (fCmdRet == 0xFB))
                {
                    byte[] daw1 = new byte[CardNum * 10];
                    Array.Copy(ID2_6B, daw1, CardNum * 10);
                    temps = ByteArrayToHexString(daw1);
                    string sant = Convert.ToString(ant, 2).PadLeft(4, '0');
                    for (i = 0; i < CardNum; i++)
                    {
                        sID = temps.Substring(20 * i + 2, 16);
                        string RSSI = temps.Substring(20 * i + 18, 2);
                        RSSI = Convert.ToByte(RSSI, 16).ToString();
                        if ((sID.Length) != 16)
                            return;
                        if (CardNum == 0)
                            return;
                        isonlistview = false;
                        for (j = 0; j < ListView_ID_6B.Items.Count; j++)     //判断是否在Listview列表内
                        {
                            if (sID == ListView_ID_6B.Items[j].SubItems[1].Text)
                            {
                                aListItem = ListView_ID_6B.Items[j];
                                ChangeSubItem1(aListItem, 1, sID, sant, RSSI);
                                isonlistview = true;
                                break;
                            }
                        }
                        if (!isonlistview)
                        {
                            aListItem = ListView_ID_6B.Items.Add((ListView_ID_6B.Items.Count + 1).ToString());
                            aListItem.SubItems.Add("");
                            aListItem.SubItems.Add("");
                            aListItem.SubItems.Add("");
                            aListItem.SubItems.Add("");
                            aListItem.SubItems.Add("");
                            s = sID;
                            ChangeSubItem1(aListItem, 1, s, sant, RSSI);
                        }
                    }
                }
            }
            WriteLog(lrtxtLog, "18000-6B Query", 0);
        }
        private void Timer_Test_6B_Tick(object sender, EventArgs e)
        {
            if (fisinventoryscan_6B)
                return;
            fisinventoryscan_6B = true;
            Inventory_6B();
            fisinventoryscan_6B = false;
        }

        private void ListView_ID_6B_DoubleClick(object sender, EventArgs e)
        {
            if (this.ListView_ID_6B.SelectedIndices.Count > 0 && this.ListView_ID_6B.SelectedIndices[0] != -1)
            {
                text_6BUID.Text = ListView_ID_6B.SelectedItems[0].SubItems[1].Text;
            }
        }
        //E004000085D94502
        private void btRead6B_Click(object sender, EventArgs e)
        {
            string temp, temps;
            byte[] CardData = new byte[320];
            byte[] ID_6B = new byte[8];
            byte Num, StartAddress;
            if (text_6BUID.Text == "")
            {
                MessageBox.Show("Select one tag in the list");
                return;
            }
            temp = text_6BUID.Text;
            ID_6B = HexStringToByteArray(temp);
            if (text_R6BAddr.Text == "")
                return;
            StartAddress = Convert.ToByte(text_R6BAddr.Text, 16);
            if (text_R6BLen.Text == "")
                return;
            Num = Convert.ToByte(text_R6BLen.Text, 16);
            fCmdRet = RWDev.ReadData_6B(ref fComAdr, ID_6B, StartAddress, Num, CardData, ref ferrorcode, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "";
                if (fCmdRet == 0xFC)
                    strLog = "Read data failed: " + "tag return error=0x" + Convert.ToString(ferrorcode, 16) + "(" + GetErrorCodeDesc(ferrorcode) + ")";
                else
                    strLog = "Read data failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                byte[] data = new byte[Num];
                Array.Copy(CardData, data, Num);
                temps = ByteArrayToHexString(data);
                text_R6B.Text = temps;
                string strLog = "Read data success ";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void btWrite6B_Click(object sender, EventArgs e)
        {
            string temp;
            byte[] CardData = new byte[320];
            byte[] ID_6B = new byte[8];
            byte StartAddress;
            byte Writedatalen;
            int writtenbyte = 0;
            if (text_6BUID.Text == "")
            {
                MessageBox.Show("Select one tag in the list");
                return;
            }
            // text_6BUID.Text = "E004000085D94502";
            temp = text_6BUID.Text;
            ID_6B = HexStringToByteArray(temp);
            if (text_W6BAddr.Text == "")
                return;
            StartAddress = Convert.ToByte(text_W6BAddr.Text, 16);
            if (text_W6BLen.Text == "")
                return;
            Writedatalen = Convert.ToByte(text_W6BLen.Text, 16);

            if ((text_W6B.Text == "") | ((text_W6B.Text.Length / 2) != Writedatalen) | ((text_W6B.Text.Length % 2) != 0))
                return;
            byte[] Writedata = new byte[Writedatalen];
            Writedata = HexStringToByteArray(text_W6B.Text);
            fCmdRet = RWDev.WriteData_6B(ref fComAdr, ID_6B, StartAddress, Writedata, Writedatalen, ref writtenbyte, ref ferrorcode, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "";
                if (fCmdRet == 0xFC)
                    strLog = "Write data failed: " + "tag return error=0x" + Convert.ToString(ferrorcode, 16) + "(" + GetErrorCodeDesc(ferrorcode) + ")";
                else
                    strLog = "Write data failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "Write data success ";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void text_W6BLen_TextChanged(object sender, EventArgs e)
        {
            text_W6B.MaxLength = Convert.ToInt32(text_W6BLen.Text, 16) * 2;
        }

        private void btLock6B_Click(object sender, EventArgs e)
        {
            byte Address;
            string temps;
            byte[] ID_6B = new byte[8];
            if (text_6BUID.Text == "")
            {
                MessageBox.Show("Select one tag in the list");
                return;
            }
            temps = text_6BUID.Text;
            ID_6B = HexStringToByteArray(temps);
            if (text_lock6b.Text == "")
                return;
            Address = Convert.ToByte(text_lock6b.Text, 16);
            if (MessageBox.Show(this, "Lock forever?", "information", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;
            fCmdRet = RWDev.Lock_6B(ref fComAdr, ID_6B, Address, ref ferrorcode, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "";
                if (fCmdRet == 0xFC)
                    strLog = "Lock failed: " + "tag return error=0x" + Convert.ToString(ferrorcode, 16) + "(" + GetErrorCodeDesc(ferrorcode) + ")";
                else
                    strLog = "Lock failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "Lock success ";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void btCheckLock6B_Click(object sender, EventArgs e)
        {
            byte Address, ReLockState = 2;
            string temps;
            byte[] ID_6B = new byte[8];
            if (text_6BUID.Text == "")
            {
                MessageBox.Show("Select one tag in the list");
                return;
            }
            temps = text_6BUID.Text;
            ID_6B = HexStringToByteArray(temps);
            if (text_checkaddr.Text == "")
                return;
            Address = Convert.ToByte(text_checkaddr.Text, 16);
            fCmdRet = RWDev.CheckLock_6B(ref fComAdr, ID_6B, Address, ref ReLockState, ref ferrorcode, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "";
                if (fCmdRet == 0xFC)
                    strLog = "Detect lock failed: " + "tag return error=0x" + Convert.ToString(ferrorcode, 16) + "(" + GetErrorCodeDesc(ferrorcode) + ")";
                else
                    strLog = "Detect lock failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "";
                if (ReLockState == 0)
                    text_Statu6B.Text = "Unlocked";
                if (ReLockState == 1)
                    text_Statu6B.Text = "Locked";
                strLog = "Detect lock success ";
                WriteLog(lrtxtLog, strLog, 0);
            }

        }

        private void btGetSeriaPort_Click(object sender, EventArgs e)
        {
            try
            {
                SeriaATflag = false;
                byte timeout = 0;
                byte cmdlen = 0;
                byte[] data = new byte[100];
                byte[] cmddata = new byte[100];
                byte recvLen = 0;
                byte[] recvdata = new byte[1000];
                string cmd = "AT!SP?";
                data = Encoding.ASCII.GetBytes(cmd);
                cmdlen = Convert.ToByte(cmd.Length);
                Array.Copy(data, cmddata, cmdlen);
                timeout = 30;
                cmddata[cmdlen] = 0x0d;
                cmddata[cmdlen + 1] = 0x0a;
                cmdlen = Convert.ToByte(cmdlen + 2);
                fCmdRet = RWDev.TransparentCMD(ref fComAdr, timeout, cmdlen, cmddata, ref recvLen, recvdata, frmcomportindex);
                if (fCmdRet != 0)
                {
                    string strLog = "AT CMD failed: " + GetReturnCodeDesc(fCmdRet);
                    WriteLog(lrtxtLog, strLog, 1);
                }
                else
                {
                    string recvs = Encoding.ASCII.GetString(recvdata);
                    if ((recvs.IndexOf("ERROR") > 0) || (recvLen == 0))
                    {
                        MessageBox.Show("Get failed!", "Information");
                        SeriaATflag = true;
                        return;
                    }
                    int m = 0;
                    int n = 0;
                    protocolCB.SelectedIndex = 0;
                    string code = "";
                    m = recvs.IndexOf(":");
                    recvs = recvs.Substring(m + 2);
                    n = recvs.IndexOf(",");
                    code = recvs.Substring(0, n);
                    recvs = recvs.Substring(n + 1);

                    n = recvs.IndexOf(",");
                    code = recvs.Substring(0, n);
                    recvs = recvs.Substring(n + 1);

                    n = recvs.IndexOf(",");
                    code = recvs.Substring(0, n);
                    recvs = recvs.Substring(n + 1);
                    baudrateCB.SelectedIndex = Convert.ToInt32(code);

                    n = recvs.IndexOf(",");
                    code = recvs.Substring(0, n);
                    recvs = recvs.Substring(n + 1);
                    databitCB.SelectedIndex = Convert.ToInt32(code);

                    n = recvs.IndexOf(",");
                    code = recvs.Substring(0, n);
                    recvs = recvs.Substring(n + 1);
                    stopbitCB.SelectedIndex = Convert.ToInt32(code);

                    n = recvs.IndexOf(",");
                    code = recvs.Substring(0, n);
                    recvs = recvs.Substring(n + 1);
                    parityCB.SelectedIndex = Convert.ToInt32(code);

                    n = recvs.IndexOf(",");
                    code = recvs.Substring(0, n);
                    recvs = recvs.Substring(n + 1);
                    flowCB.SelectedIndex = Convert.ToInt32(code);

                    n = recvs.IndexOf("\r\n");
                    code = recvs.Substring(0, n);
                    fifoCB.SelectedIndex = Convert.ToInt32(code);
                    string strLog = "AT CMD success ";
                    WriteLog(lrtxtLog, strLog, 0);
                }
            }
            catch (System.Exception ex)
            {
                ex.ToString();
            }
        }

        private void btSetSerialPort_Click(object sender, EventArgs e)
        {
            try
            {
                byte timeout = 0;
                byte cmdlen = 0;
                byte[] data = new byte[100];
                byte[] cmddata = new byte[100];
                byte recvLen = 0;
                byte[] recvdata = new byte[1000];
                string cmd = "AT!SP=0,1,";
                cmd = cmd + baudrateCB.SelectedIndex.ToString() + "," + databitCB.SelectedIndex.ToString()
                    + "," + stopbitCB.SelectedIndex.ToString() + "," + parityCB.SelectedIndex.ToString()
                    + "," + flowCB.SelectedIndex.ToString() + "," + fifoCB.SelectedIndex.ToString();
                data = Encoding.ASCII.GetBytes(cmd);
                cmdlen = Convert.ToByte(cmd.Length);
                Array.Copy(data, cmddata, cmdlen);
                timeout = 30;
                cmddata[cmdlen] = 0x0d;
                cmddata[cmdlen + 1] = 0x0a;
                cmdlen = Convert.ToByte(cmdlen + 2);
                fCmdRet = RWDev.TransparentCMD(ref fComAdr, timeout, cmdlen, cmddata, ref recvLen, recvdata, frmcomportindex);
                if (fCmdRet != 0)
                {
                    string strLog = "AT CMD failed: " + GetReturnCodeDesc(fCmdRet);
                    WriteLog(lrtxtLog, strLog, 1);
                }
                else
                {
                    string recvs = Encoding.ASCII.GetString(recvdata);
                    if ((recvs.IndexOf("ERROR") > 0) || (recvLen == 0))
                    {
                        MessageBox.Show("Set failed!", "Information");
                    }
                    string strLog = "AT CMD success ";
                    WriteLog(lrtxtLog, strLog, 0);
                }
            }
            catch (System.Exception ex)
            {
                ex.ToString();
            }
        }

        private void btGetCnt_Click(object sender, EventArgs e)
        {
            try
            {
                SeriaATflag = false;
                byte timeout = 0;
                byte cmdlen = 0;
                byte[] data = new byte[100];
                byte[] cmddata = new byte[100];
                byte recvLen = 0;
                byte[] recvdata = new byte[1000];
                string cmd = "AT!TC?";
                data = Encoding.ASCII.GetBytes(cmd);
                cmdlen = Convert.ToByte(cmd.Length);
                Array.Copy(data, cmddata, cmdlen);
                timeout = 30;
                cmddata[cmdlen] = 0x0d;
                cmddata[cmdlen + 1] = 0x0a;
                cmdlen = Convert.ToByte(cmdlen + 2);
                fCmdRet = RWDev.TransparentCMD(ref fComAdr, timeout, cmdlen, cmddata, ref recvLen, recvdata, frmcomportindex);
                if (fCmdRet != 0)
                {
                    string strLog = "AT CMD failed:  " + GetReturnCodeDesc(fCmdRet);
                    WriteLog(lrtxtLog, strLog, 1);
                }
                else
                {
                    string recvs = Encoding.ASCII.GetString(recvdata);
                    if ((recvs.IndexOf("ERROR") > 0) || (recvLen == 0))
                    {
                        MessageBox.Show("Get failed!", "information");
                        SeriaATflag = true;
                        return;
                    }
                    int m = 0;
                    int n = 0;
                    string code = "";
                    m = recvs.IndexOf(",");
                    recvs = recvs.Substring(m + 1);
                    n = recvs.IndexOf(",");
                    code = recvs.Substring(0, n);
                    recvs = recvs.Substring(n + 1);
                    workasCB.SelectedIndex = Convert.ToInt32(code);

                    n = recvs.IndexOf(",");
                    code = recvs.Substring(0, n);
                    recvs = recvs.Substring(n + 1);
                    tcpActiveCB.SelectedIndex = Convert.ToInt32(code) - 1;

                    n = recvs.IndexOf(",");
                    code = recvs.Substring(0, n);
                    recvs = recvs.Substring(n + 1);
                    tcpLocalPortNUD.Text = code;

                    if (recvs.IndexOf("1800") > 0)
                    {
                        recvs = recvs.Substring(1);
                        n = recvs.IndexOf("\"");
                        code = recvs.Substring(0, n);
                        recvs = recvs.Substring(n + 2);
                        tcpRomteHostTB.Text = code;

                        n = recvs.IndexOf(",");
                        code = recvs.Substring(0, n);
                        tcpRemotePortNUD.Text = code;
                    }
                    else
                    {
                        n = recvs.IndexOf("\"");
                        code = recvs.Substring(0, n - 1);
                        recvs = recvs.Substring(n + 1);
                        tcpRemotePortNUD.Text = code;

                        n = recvs.IndexOf(",");
                        code = recvs.Substring(0, n - 1);
                        recvs = recvs.Substring(n + 1);
                        tcpRomteHostTB.Text = code;
                    }
                    string strLog = "AT CMD success ";
                    WriteLog(lrtxtLog, strLog, 0);
                }
            }
            catch (System.Exception ex)
            {
                ex.ToString();
            }
        }

        private void btSetCnt_Click(object sender, EventArgs e)
        {
            try
            {
                byte timeout = 0;
                byte cmdlen = 0;
                byte[] data = new byte[100];
                byte[] cmddata = new byte[100];
                byte recvLen = 0;
                byte[] recvdata = new byte[1000];
                string cmd = "AT!TC=0,";
                cmd = cmd + workasCB.SelectedIndex.ToString() + "," + Convert.ToString(tcpActiveCB.SelectedIndex + 1)
                    + "," + tcpLocalPortNUD.Text + ",\"" + tcpRomteHostTB.Text
                    + "\"," + tcpRemotePortNUD.Text + "," + ",";
                data = Encoding.ASCII.GetBytes(cmd);
                cmdlen = Convert.ToByte(cmd.Length);
                Array.Copy(data, cmddata, cmdlen);
                timeout = 30;
                cmddata[cmdlen] = 0x0d;
                cmddata[cmdlen + 1] = 0x0a;
                cmdlen = Convert.ToByte(cmdlen + 2);
                fCmdRet = RWDev.TransparentCMD(ref fComAdr, timeout, cmdlen, cmddata, ref recvLen, recvdata, frmcomportindex);
                if (fCmdRet != 0)
                {
                    string strLog = "AT CMD failed: " + GetReturnCodeDesc(fCmdRet);
                    WriteLog(lrtxtLog, strLog, 1);
                }
                else
                {
                    string recvs = Encoding.ASCII.GetString(recvdata);
                    if ((recvs.IndexOf("ERROR") > 0) || (recvLen == 0))
                    {
                        Thread.Sleep(500);
                        cmd = "AT!TC=0,";
                        cmd = cmd + workasCB.SelectedIndex.ToString() + "," + Convert.ToString(tcpActiveCB.SelectedIndex + 1)
                            + "," + tcpLocalPortNUD.Text + ",\"" + tcpRemotePortNUD.Text
                            + "\"," + tcpRomteHostTB.Text + "," + ",";
                        data = Encoding.ASCII.GetBytes(cmd);
                        cmdlen = Convert.ToByte(cmd.Length);
                        Array.Copy(data, cmddata, cmdlen);
                        timeout = 30;
                        cmddata[cmdlen] = 0x0d;
                        cmddata[cmdlen + 1] = 0x0a;
                        cmdlen = Convert.ToByte(cmdlen + 2);
                        fCmdRet = RWDev.TransparentCMD(ref fComAdr, timeout, cmdlen, cmddata, ref recvLen, recvdata, frmcomportindex);
                        if (fCmdRet == 0)
                        {
                            recvs = Encoding.ASCII.GetString(recvdata);
                            if ((recvs.IndexOf("ERROR") > 0) || (recvLen == 0))
                            {
                                MessageBox.Show("Set failed!", "information");
                                return;
                            }
                            string strLog = "AT CMD success ";
                            WriteLog(lrtxtLog, strLog, 0);
                        }
                    }

                }
            }
            catch (System.Exception ex)
            {
                ex.ToString();
            }
        }

        private void btGetNet_Click(object sender, EventArgs e)
        {
            try
            {
                SeriaATflag = false;
                byte timeout = 0;
                byte cmdlen = 0;
                byte[] data = new byte[100];
                byte[] cmddata = new byte[100];
                byte recvLen = 0;
                byte[] recvdata = new byte[1000];
                string cmd = "AT!IC?";
                data = Encoding.ASCII.GetBytes(cmd);
                cmdlen = Convert.ToByte(cmd.Length);
                Array.Copy(data, cmddata, cmdlen);
                timeout = 30;
                cmddata[cmdlen] = 0x0d;
                cmddata[cmdlen + 1] = 0x0a;
                cmdlen = Convert.ToByte(cmdlen + 2);
                fCmdRet = RWDev.TransparentCMD(ref fComAdr, timeout, cmdlen, cmddata, ref recvLen, recvdata, frmcomportindex);
                if (fCmdRet != 0)
                {
                    string strLog = "AT CMD failed: " + GetReturnCodeDesc(fCmdRet);
                    WriteLog(lrtxtLog, strLog, 1);
                }
                else
                {
                    string recvs = Encoding.ASCII.GetString(recvdata);
                    if ((recvs.IndexOf("ERROR") > 0) || (recvLen == 0))
                    {
                        MessageBox.Show("Get failed!", "information");
                        SeriaATflag = true;
                        return;
                    }
                    int m = 0;
                    int n = 0;
                    string code = "";
                    m = recvs.IndexOf("\"");
                    recvs = recvs.Substring(m + 1);
                    n = recvs.IndexOf("\"");
                    code = recvs.Substring(0, n);
                    recvs = recvs.Substring(n + 3);
                    ipTB.Text = code;

                    n = recvs.IndexOf("\"");
                    code = recvs.Substring(0, n);
                    recvs = recvs.Substring(n + 3);
                    subnetTB.Text = code;

                    n = recvs.IndexOf("\"");
                    code = recvs.Substring(0, n);
                    recvs = recvs.Substring(n + 3);
                    gatewayTB.Text = code;

                    n = recvs.IndexOf("\"");
                    code = recvs.Substring(0, n);
                    recvs = recvs.Substring(n + 3);
                    pDNSTB.Text = code;

                    n = recvs.IndexOf("\"");
                    code = recvs.Substring(0, n);
                    recvs = recvs.Substring(n + 1);
                    altDNSTB.Text = code;
                }

                Thread.Sleep(500);
                cmd = "AT!EC?";
                data = Encoding.ASCII.GetBytes(cmd);
                cmdlen = Convert.ToByte(cmd.Length);
                Array.Copy(data, cmddata, cmdlen);
                timeout = 30;
                cmddata[cmdlen] = 0x0d;
                cmddata[cmdlen + 1] = 0x0a;
                cmdlen = Convert.ToByte(cmdlen + 2);
                fCmdRet = RWDev.TransparentCMD(ref fComAdr, timeout, cmdlen, cmddata, ref recvLen, recvdata, frmcomportindex);
                if (fCmdRet != 0)
                {
                    string strLog = "AT CMD failed: " + GetReturnCodeDesc(fCmdRet);
                    WriteLog(lrtxtLog, strLog, 1);
                }
                else
                {
                    string recvs = Encoding.ASCII.GetString(recvdata);
                    if ((recvs.IndexOf("ERROR") > 0) || (recvLen == 0))
                    {
                        MessageBox.Show("Get failed!", "information");
                        SeriaATflag = true;
                        return;
                    }
                    int m = 0;
                    int n = 0;
                    string code = "";
                    m = recvs.IndexOf("\"");
                    recvs = recvs.Substring(m + 1);
                    n = recvs.IndexOf("\"");
                    code = recvs.Substring(0, n);
                    macTB.Text = code;
                    string strLog = "AT CMD success ";
                    WriteLog(lrtxtLog, strLog, 0);
                }
            }
            catch (System.Exception ex)
            {
                ex.ToString();
            }
        }

        private void btSetNet_Click(object sender, EventArgs e)
        {
            try
            {
                byte timeout = 0;
                byte cmdlen = 0;
                byte[] data = new byte[100];
                byte[] cmddata = new byte[100];
                byte recvLen = 0;
                byte[] recvdata = new byte[1000];
                string cmd = "AT!IC=0,\"";
                cmd = cmd + ipTB.Text + "\",\"" + subnetTB.Text
                    + "\",\"" + gatewayTB.Text + "\",\"" + pDNSTB.Text
                    + "\",\"" + altDNSTB.Text + "\"";
                data = Encoding.ASCII.GetBytes(cmd);
                cmdlen = Convert.ToByte(cmd.Length);
                Array.Copy(data, cmddata, cmdlen);
                timeout = 30;
                cmddata[cmdlen] = 0x0d;
                cmddata[cmdlen + 1] = 0x0a;
                cmdlen = Convert.ToByte(cmdlen + 2);
                fCmdRet = RWDev.TransparentCMD(ref fComAdr, timeout, cmdlen, cmddata, ref recvLen, recvdata, frmcomportindex);
                if (fCmdRet != 0)
                {
                    string strLog = "AT CMD failed: " + GetReturnCodeDesc(fCmdRet);
                    WriteLog(lrtxtLog, strLog, 1);
                }
                else
                {
                    string recvs = Encoding.ASCII.GetString(recvdata);
                    if ((recvs.IndexOf("ERROR") > 0) || (recvLen == 0))
                    {
                        Thread.Sleep(500);
                        cmd = "AT!IC=0,\"";
                        cmd = cmd + ipTB.Text + "\","
                            + ",\"" + gatewayTB.Text + "\",\"" + pDNSTB.Text
                            + "\",\"" + altDNSTB.Text + "\"";
                        data = Encoding.ASCII.GetBytes(cmd);
                        cmdlen = Convert.ToByte(cmd.Length);
                        Array.Copy(data, cmddata, cmdlen);
                        timeout = 60;
                        cmddata[cmdlen] = 0x0d;
                        cmddata[cmdlen + 1] = 0x0a;
                        cmdlen = Convert.ToByte(cmdlen + 2);
                        fCmdRet = RWDev.TransparentCMD(ref fComAdr, timeout, cmdlen, cmddata, ref recvLen, recvdata, frmcomportindex);
                        if (fCmdRet == 0)
                        {
                            recvs = Encoding.ASCII.GetString(recvdata);
                            if ((recvs.IndexOf("ERROR") > 0) || (recvLen == 0))
                            {
                                MessageBox.Show("Set failed!", "information");
                                return;
                            }
                        }
                    }
                    string strLog = "AT CMD success";
                    WriteLog(lrtxtLog, strLog, 0);
                }
            }
            catch (System.Exception ex)
            {
                ex.ToString();
            }
        }

        private void btLoadDefault_Click(object sender, EventArgs e)
        {
            try
            {
                byte timeout = 0;
                byte cmdlen = 0;
                byte[] data = new byte[100];
                byte[] cmddata = new byte[100];
                byte recvLen = 0;
                byte[] recvdata = new byte[1000];
                string cmd = "AT!LD";
                data = Encoding.ASCII.GetBytes(cmd);
                cmdlen = Convert.ToByte(cmd.Length);
                Array.Copy(data, cmddata, cmdlen);
                timeout = 30;
                cmddata[cmdlen] = 0x0d;
                cmddata[cmdlen + 1] = 0x0a;
                cmdlen = Convert.ToByte(cmdlen + 2);
                fCmdRet = RWDev.TransparentCMD(ref fComAdr, timeout, cmdlen, cmddata, ref recvLen, recvdata, frmcomportindex);
                if (fCmdRet != 0)
                {
                    string strLog = "AT CMD failed: " + GetReturnCodeDesc(fCmdRet);
                    WriteLog(lrtxtLog, strLog, 1);
                }
                else
                {
                    string recvs = Encoding.ASCII.GetString(recvdata);
                    if ((recvs.IndexOf("ERROR") > 0) || (recvLen == 0))
                    {
                        MessageBox.Show("Set failed!", "information");
                        return;
                    }
                    string strLog = "AT CMD success";
                    WriteLog(lrtxtLog, strLog, 0);
                }
            }
            catch (System.Exception ex)
            {
                ex.ToString();
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                byte timeout = 0;
                byte cmdlen = 0;
                byte[] data = new byte[100];
                byte[] cmddata = new byte[100];
                byte recvLen = 0;
                byte[] recvdata = new byte[1000];
                string cmd = "AT!S";
                data = Encoding.ASCII.GetBytes(cmd);
                cmdlen = Convert.ToByte(cmd.Length);
                Array.Copy(data, cmddata, cmdlen);
                timeout = 30;
                cmddata[cmdlen] = 0x0d;
                cmddata[cmdlen + 1] = 0x0a;
                cmdlen = Convert.ToByte(cmdlen + 2);
                fCmdRet = RWDev.TransparentCMD(ref fComAdr, timeout, cmdlen, cmddata, ref recvLen, recvdata, frmcomportindex);
                if (fCmdRet != 0)
                {
                    string strLog = "AT CMD failed: " + GetReturnCodeDesc(fCmdRet);
                    WriteLog(lrtxtLog, strLog, 1);
                }
                else
                {
                    Thread.Sleep(500);
                    cmd = "AT!R";
                    data = Encoding.ASCII.GetBytes(cmd);
                    cmdlen = Convert.ToByte(cmd.Length);
                    Array.Copy(data, cmddata, cmdlen);
                    timeout = 30;
                    cmddata[cmdlen] = 0x0d;
                    cmddata[cmdlen + 1] = 0x0a;
                    cmdlen = Convert.ToByte(cmdlen + 2);
                    fCmdRet = RWDev.TransparentCMD(ref fComAdr, timeout, cmdlen, cmddata, ref recvLen, recvdata, frmcomportindex);
                    string strLog = "AT CMD success ";
                    WriteLog(lrtxtLog, strLog, 0);
                }
            }
            catch (System.Exception ex)
            {
                ex.ToString();
            }
        }

        private void btGotoAT_Click(object sender, EventArgs e)
        {
            byte ATMode = 1;
            SeriaATflag = false;
            fCmdRet = RWDev.ChangeATMode(ref fComAdr, ATMode, frmcomportindex);
            if (fCmdRet != 0)
            {
                SeriaATflag = true;
                string strLog = "Goto AT mode failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "Goto AT mode success ";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void btExitAT_Click(object sender, EventArgs e)
        {
            byte ATMode = 0;
            fCmdRet = RWDev.ChangeATMode(ref fComAdr, ATMode, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "Exit AT mode failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "Exit AT mode success ";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }
        /// <summary>
        /// 将Device List中所记录设备显示至DeviceListView控件;
        /// </summary>
        private void ReflashDeviceListView(List<DeviceClass> deviceList)
        {
            this.DeviceListView.Items.Clear();
            foreach (DeviceClass device in deviceList)
            {
                IPAddress ipAddr = getIPAddress(device.DeviceIP);
                ListViewItem deviceListViewItem = new ListViewItem(new string[] { device.DeviceName, ipAddr.ToString(), device.DeviceMac });
                deviceListViewItem.ImageIndex = 0;
                this.DeviceListView.Items.Add(deviceListViewItem);
            }
        }

        /// <summary>
        /// 将Device List中所记录设备显示至DeviceListView控件;
        /// </summary>
        private void ClearDeviceListView()
        {
            DevControl.tagErrorCode eCode;
            List<DeviceClass> deviceList = DevList;

            foreach (DeviceClass device in deviceList)
            {
                eCode = DevControl.DM_FreeDevice(device.DevHandle);
                Debug.Assert(eCode == DevControl.tagErrorCode.DM_ERR_OK);
            }
            //清空设备列表，并清空对应显示控件；
            DevList.Clear();
            ReflashDeviceListView(DevList);
        }

        /// <summary>
        /// 搜索设备，然后将记录搜索结果的DevList显示至DeviceListView控件;
        /// </summary>
        private bool SearchDevice(uint targetIP)
        {
            ClearDeviceListView();
            DevControl.tagErrorCode eCode = DevControl.DM_SearchDevice(targetIP, 1500);
            if (eCode == DevControl.tagErrorCode.DM_ERR_OK)
            {
                ReflashDeviceListView(DevList);
                return true;
            }
            else
            {
                //异常处理；
                string errMsg = ErrorHandling.HandleError(eCode);
                System.Windows.Forms.MessageBox.Show(errMsg);
                return false;
            }
        }

        /// <summary>
        /// 配置选定设备，开启对应配置窗体;
        /// </summary>
        private void ConfigSelectedDevice()
        {
            if (this.DeviceListView.SelectedIndices.Count > 0
                && this.DeviceListView.SelectedIndices[0] != -1)
            {
                //通过用户在显示控件中选择的索引值，在查找其所对应的设备对象；
                DeviceClass currentDevice = DevList[DeviceListView.SelectedIndices[0]];

                LoginForm loginform = new LoginForm();
                DialogResult result = loginform.ShowDialog();
                if (result == DialogResult.OK)
                {
                    DevControl.tagErrorCode eCode = currentDevice.Login(loginform.UserName, loginform.Password);
                    if (eCode == DevControl.tagErrorCode.DM_ERR_OK)
                    {
                        //记录当前选择设备对象，作为父窗体属性传递至新开启的子配置窗体；
                        this.SelectedDevice = currentDevice;
                        ConfigForm deviceConfigForm = new ConfigForm(this.SelectedDevice);
                        deviceConfigForm.ShowDialog(this);
                        deviceConfigForm.Dispose();
                    }
                    else
                    {
                        //异常处理；
                        string errMsg = ErrorHandling.HandleError(eCode);
                        System.Windows.Forms.MessageBox.Show(errMsg);
                    }
                }

                loginform.Dispose();
            }
        }
        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //使用广播搜索设备；
            SearchDevice(DeviceClass.Broadcast);
        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigSelectedDevice();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearDeviceListView();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //关闭主窗体并退出程序；
            this.Close();
        }

        private void iEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //开启IE访问目标设备；
            try
            {
                if (DeviceListView.SelectedIndices.Count > 0
                    && DeviceListView.SelectedIndices[0] != -1)
                {
                    DeviceClass currentDevice = DevList[DeviceListView.SelectedIndices[0]];
                    System.Diagnostics.Process.Start("iexplore.exe", "HTTP://" + getIPAddress(currentDevice.DeviceIP).ToString());
                }
            }
            catch (Exception ex)
            {
                Log.WriteException(ex);
            }
        }

        private void telnetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //开启TELNET客户端访问目标设备；
            try
            {
                if (DeviceListView.SelectedIndices.Count > 0
                    && DeviceListView.SelectedIndices[0] != -1)
                {
                    DeviceClass currentDevice = DevList[DeviceListView.SelectedIndices[0]];
                    System.Diagnostics.Process.Start("telnet.exe", getIPAddress(currentDevice.DeviceIP).ToString());
                }
            }
            catch (Exception ex)
            {
                Log.WriteException(ex);
            }
        }

        private void pingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (DeviceListView.SelectedIndices.Count > 0
                    && DeviceListView.SelectedIndices[0] != -1)
                {
                    DeviceClass currentDevice = DevList[DeviceListView.SelectedIndices[0]];
                    System.Diagnostics.Process.Start("ping.exe", getIPAddress(currentDevice.DeviceIP).ToString() + " -t");
                }
            }
            catch (Exception ex)
            {
                Log.WriteException(ex);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            DevControl.tagErrorCode eCode = DevControl.DM_DeInit();
            if (eCode != DevControl.tagErrorCode.DM_ERR_OK)
            {
                ErrorHandling.HandleError(eCode);
            }
        }

        private void DeviceListView_DoubleClick(object sender, EventArgs e)
        {
            ConfigSelectedDevice();
        }

        private void btFlashROM_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, " if change to flush mode,need restart power to restore.are you sure do this?", "Information", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;
            fCmdRet = RWDev.SetFlashRom(ref fComAdr, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "Change to flush mode failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "Change to flush mode success ";
                WriteLog(lrtxtLog, strLog, 0);
                if (frmcomportindex > 0 && frmcomportindex < 256)
                {
                    btDisConnect232_Click(null, null);
                }
            }
        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        public class ctcplist//存储100客户端信息.
        {
            public Socket[] tempSocket = new Socket[100];
            public string[] ip = new string[100];
            public int[] port = new int[100];
        }
        ctcplist tcplist = new ctcplist();
        Thread listenThread = null;//监听进程
        Socket newsock = null;
        private void StartListening() //main listening thread
        {
            int port = Convert.ToInt32(stcpport.Text);
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, port);//绑定端口
            newsock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);//tcp协议
            newsock.Bind(ipep);
            newsock.Listen(10);
            while (true)
            {
                try
                {
                    Socket client = newsock.Accept();//等待TCP客户端的链接请求
                                                     //查找空缺，插入信息
                    int m = 0;
                    for (m = 0; m < 100; m++)
                    {
                        if (tcplist.ip[m] == null)
                        {
                            int nport = ((System.Net.IPEndPoint)client.RemoteEndPoint).Port;
                            IPAddress ip = ((System.Net.IPEndPoint)client.RemoteEndPoint).Address;
                            tcplist.tempSocket[m] = client;
                            tcplist.ip[m] = ip.ToString();
                            tcplist.port[m] = nport;
                            this.Invoke((EventHandler)delegate
                            {
                                listtcp.Items.Add(ip.ToString() + ":" + nport.ToString());
                            });

                            break;
                        }
                    }
                    ParameterizedThreadStart ParStart = new ParameterizedThreadStart(ServiceClient);
                    Thread clientService = new Thread(ParStart);
                    clientService.IsBackground = true;
                    object o = client;
                    clientService.Start(o);
                }
                catch (System.Exception ex)
                {
                    break;
                }
            }
        }

        private void btListen_Click(object sender, EventArgs e)
        {
            //创建监听进程
            stcpport.Enabled = false;
            btListen.Enabled = false;
            listenThread = new Thread(new ThreadStart(StartListening));
            listenThread.IsBackground = true;
            listenThread.Start();
        }
        public static string ByteArrayToHexString2(byte[] data)
        {
            StringBuilder sb = new StringBuilder(data.Length * 3);
            foreach (byte b in data)
                sb.Append(Convert.ToString(b, 16).PadLeft(2, '0').PadLeft(3, ' '));
            return sb.ToString().ToUpper();

        }
        public void ServiceClient(object ParObject)
        {
            Socket tempSocket = (Socket)ParObject;
            IPEndPoint newclient = (IPEndPoint)tempSocket.RemoteEndPoint;

            //  NetworkStream ns = new NetworkStream(tempSocket);
            //  StreamReader sr = new StreamReader(ns);
            byte[] myReadBuffer = new byte[1024];
            IPAddress ip = (newclient).Address;
            int nport = (newclient).Port;
            int count = 0;
            string temp = "";
            while (true)
            {
                try
                {
                    count = tempSocket.Receive(myReadBuffer);
                    if (count > 0)
                    {
                        byte[] data = new byte[count];
                        Array.Copy(myReadBuffer, data, count);
                        temp = ByteArrayToHexString2(data);
                        this.Invoke((EventHandler)delegate
                        {
                            stcprecv.AppendText(Environment.NewLine + ip.ToString() + ":" + nport.ToString() + " " + temp);
                            stcprecv.Select(stcprecv.TextLength, 0);
                            stcprecv.ScrollToCaret();
                        });
                    }
                    else
                    {
                        this.Invoke((EventHandler)delegate
                        {
                            int m = 0;
                            for (m = 0; m < 100; m++)
                            {
                                if (tcplist.ip[m] == ip.ToString() && (tcplist.port[m] == nport))//找到
                                {
                                    int n = listtcp.Items.IndexOf(ip.ToString() + ":" + nport.ToString());
                                    listtcp.Items.RemoveAt(n);
                                    tcplist.tempSocket[m].Close();
                                    tcplist.ip[m] = null;
                                    tcplist.port[m] = 0;
                                    tcplist.tempSocket[m] = null;
                                    break;
                                }
                            }
                        });
                        break;
                    }
                }
                catch
                {
                    //查找断开连接的设备IP
                    this.Invoke((EventHandler)delegate
                    {
                        int m = 0;
                        for (m = 0; m < 100; m++)
                        {
                            if (tcplist.ip[m] == ip.ToString() && (tcplist.port[m] == nport))//找到
                            {
                                int n = listtcp.Items.IndexOf(ip.ToString() + ":" + nport.ToString());
                                listtcp.Items.RemoveAt(n);
                                tcplist.tempSocket[m].Close();
                                tcplist.ip[m] = null;
                                tcplist.port[m] = 0;
                                tcplist.tempSocket[m] = null;
                                break;
                            }
                        }
                    });
                    break;
                }
            }
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            int m = 0;
            for (m = 0; m < 100; m++)
            {
                if (tcplist.tempSocket[m] != null)//找到
                {

                    int n = listtcp.Items.IndexOf(tcplist.ip[m] + ":" + tcplist.port[m].ToString());
                    listtcp.Items.RemoveAt(n);
                    tcplist.tempSocket[m].Close();
                    tcplist.ip[m] = null;
                    tcplist.port[m] = 0;
                    tcplist.tempSocket[m] = null;
                }
            }

            if (newsock != null)
                newsock.Close();
            if (listenThread != null)
                listenThread.Abort();

            stcpport.Enabled = true;
            btListen.Enabled = true;
        }

        Socket m_client;
        Thread clientThread = null;//接收数据线程
        private void bttcpconnect_Click(object sender, EventArgs e)
        {
            try
            {
                string ip = tcpremoteIp.IpAddressStr;
                int nipport = Convert.ToInt32(remotePort.Text);
                m_client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ie = new IPEndPoint(IPAddress.Parse(ip), nipport);
                m_client.Connect(ie);
                if (m_client.Connected)
                {
                    tcpremoteIp.Enabled = false;
                    remotePort.Enabled = false;
                    bttcpconnect.Enabled = false;//连接成功创建接收数据线程
                    bttcpsend.Enabled = true;
                    clientThread = new Thread(new ThreadStart(StartRead));
                    clientThread.IsBackground = true;
                    clientThread.Start();
                }
                else
                {
                    tcpremoteIp.Enabled = true;
                    remotePort.Enabled = true;
                    bttcpconnect.Enabled = true;
                    bttcpsend.Enabled = false;
                }

            }
            catch (SocketException ex)
            {
                tcpremoteIp.Enabled = true;
                remotePort.Enabled = true;
                bttcpconnect.Enabled = true;
                bttcpsend.Enabled = false;
            }
        }
        private void StartRead()
        {
            byte[] buffs = new byte[2048];
            IPEndPoint newclient = (IPEndPoint)m_client.RemoteEndPoint;
            IPAddress ip = (newclient).Address;
            int nport = (newclient).Port;
            while (true)
            {
                try
                {
                    int count = m_client.Receive(buffs);
                    if (count > 0)
                    {
                        byte[] data = new byte[count];
                        Array.Copy(buffs, data, count);
                        string temp = ByteArrayToHexString2(data);
                        this.Invoke((EventHandler)delegate
                        {
                            ctctrecv.AppendText(Environment.NewLine + ip.ToString() + ":" + nport.ToString() + " " + temp);
                            ctctrecv.Select(stcprecv.TextLength, 0);
                            ctctrecv.ScrollToCaret();
                        });
                    }
                }
                catch (System.Exception ex)
                {
                    if (m_client.Connected)
                    {
                        m_client.Shutdown(SocketShutdown.Both);
                        m_client.Close();
                    }
                    this.Invoke((EventHandler)delegate
                    {
                        tcpremoteIp.Enabled = true;
                        remotePort.Enabled = true;
                        bttcpconnect.Enabled = true;
                    });
                    break;
                }
            }
        }

        private void bttcpsend_Click(object sender, EventArgs e)
        {
            if (m_client.Connected)
            {
                string temp = ctctsend.Text.Replace(" ", "");
                if (temp == "") return;
                if (temp.Length % 2 != 0)
                    temp = temp + "0";
                byte[] buff = new byte[1024];
                buff = HexStringToByteArray(temp);
                int m = m_client.Send(buff);
            }
        }

        private void bttcpdisconnect_Click(object sender, EventArgs e)
        {
            if (m_client.Connected)
            {
                m_client.Shutdown(SocketShutdown.Both);
                m_client.Close();
                clientThread.Abort();
                tcpremoteIp.Enabled = true;
                remotePort.Enabled = true;
                bttcpconnect.Enabled = true;
                bttcpsend.Enabled = false;
            }
        }

        private void com_S_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (com_S.SelectedIndex > 1)
            {
                check_num.Enabled = true;
            }
            else
            {
                check_num.Enabled = false;
            }
            if (com_S.SelectedIndex == 4)
            {
                group_ant1.Enabled = false;
            }
            else
            {
                group_ant1.Enabled = true;
            }
        }

        private void btSetEPCandTIDLen_Click(object sender, EventArgs e)
        {
            byte SaveLen = 0;
            if (rb128.Checked)
            {
                SaveLen = 0;
            }
            else
            {
                SaveLen = 1;
            }
            fCmdRet = RWDev.SetSaveLen(ref fComAdr, SaveLen, frmcomportindex);
            if (fCmdRet == 0)
            {
                string strLog = "Set save length success ";
                WriteLog(lrtxtLog, strLog, 0);
            }
            else
            {
                string strLog = "Set save length failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void btGetEPCandTIDLen_Click(object sender, EventArgs e)
        {
            byte SaveLen = 0;
            fCmdRet = RWDev.GetSaveLen(ref fComAdr, ref SaveLen, frmcomportindex);
            if (fCmdRet == 0)
            {
                if (SaveLen == 0)
                    rb128.Checked = true;
                else
                    rb496.Checked = true;
                string strLog = "Get save length success ";
                WriteLog(lrtxtLog, strLog, 0);
            }
            else
            {
                string strLog = "Get save length failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void btReadBuff_Click(object sender, EventArgs e)
        {
            int Totallen = 0;
            int CardNum = 0;
            byte[] pEPCList = new byte[30000];
            //lxLed_BNum.Text = "0";
            //lxLed_Bcmdsud.Text = "0";
            //lxLed_Btoltag.Text = "0";
            //lxLed_Btoltime.Text = "0";
            //lxLed_cmdTime.Text = "0";
            dataGridView3.Rows.Clear();
            string temp = "";
            fCmdRet = RWDev.ReadBuffer_G2(ref fComAdr, ref Totallen, ref CardNum, pEPCList, frmcomportindex);
            if (fCmdRet == 1)
            {
                int m = 0;
                byte[] daw = new byte[Totallen];
                Array.Copy(pEPCList, daw, Totallen);
                for (int i = 0; i < CardNum; i++)
                {
                    string ant = Convert.ToString(daw[m], 2).PadLeft(4, '0');
                    int len = daw[m + 1];
                    byte[] EPC = new byte[len];
                    Array.Copy(daw, m + 2, EPC, 0, len);
                    string sEPC = ByteArrayToHexString(EPC);
                    string RSSI = daw[m + 2 + len].ToString();
                    string sCount = daw[m + 3 + len].ToString();
                    m = m + 4 + len;
                    string[] arr = new string[6];
                    arr[0] = (dataGridView3.RowCount + 1).ToString();
                    arr[1] = sEPC;
                    arr[2] = len.ToString();
                    arr[3] = ant;
                    arr[4] = RSSI;
                    arr[5] = sCount;
                    dataGridView3.Rows.Insert(dataGridView3.RowCount, arr);
                }
                lxLed_BNum.Text = dataGridView3.RowCount.ToString();
                string strLog = "Read buffer success ";
                WriteLog(lrtxtLog, strLog, 0);
            }
            else
            {
                lxLed_BNum.Text = "0";
                string strLog = "Read buffer failed! ";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void btClearBuff_Click(object sender, EventArgs e)
        {
            fCmdRet = RWDev.ClearBuffer_G2(ref fComAdr, frmcomportindex);
            if (fCmdRet == 0)
            {
                string strLog = "Clear buffer success ";
                WriteLog(lrtxtLog, strLog, 0);
            }
            else
            {
                string strLog = "Clear buffer failed";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void btRandCbuff_Click(object sender, EventArgs e)
        {
            btReadBuff_Click(null, null);
            btClearBuff_Click(null, null);
        }

        private void btQueryBuffNum_Click(object sender, EventArgs e)
        {
            int Count = 0;
            //lxLed_Bcmdsud.Text = "0";
            //lxLed_cmdTime.Text = "0";
            lxLed_BNum.Text = "0";
            //lxLed_Btoltag.Text = "0";
            //lxLed_Btoltime.Text = "0";
            fCmdRet = RWDev.GetBufferCnt_G2(ref fComAdr, ref Count, frmcomportindex);
            if (fCmdRet == 0)
            {
                lxLed_BNum.Text = Count.ToString();
                string strLog = "Get buffer tag number success ";
                WriteLog(lrtxtLog, strLog, 0);
            }
            else
            {
                string strLog = "Get buffer tag number failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 0);
            }
        }
        private Thread ReadThread = null;
        private volatile bool fIsBuffScan = false;
        private void btStartBuff_Click(object sender, EventArgs e)
        {
            if (btStartBuff.Text == "Start")
            {
                if (rb_bepc.Checked)
                    TIDFlag = 0;
                else
                    TIDFlag = 1;
                total_time = System.Environment.TickCount;
                total_tagnum = 0;
                btStartBuff.BackColor = Color.Indigo;
                btStartBuff.Text = "Stop";
                toStopThread = false;
                if (fIsBuffScan == false)
                {
                    ReadThread = new Thread(new ThreadStart(ReadProcess));
                    ReadThread.Start();
                }
                timer_Buff.Enabled = true;
            }
            else
            {
                btStartBuff.BackColor = Color.Transparent;
                btStartBuff.Text = "Start";
                if (fIsBuffScan)
                {
                    toStopThread = true;//标志，接收数据线程判断stop为true，正常情况下会自动退出线程                                
                    if (ReadThread.Join(3000))
                    {
                        try
                        {
                            ReadThread.Abort();//若线程无法退出，强制结束
                        }
                        catch (Exception exp)
                        {
                            MessageBox.Show(exp.Message, "Thread error");
                        }
                    }
                    fIsBuffScan = false;
                }
                timer_Buff.Enabled = false;
            }
        }
        private void GetBuffData()
        {
            int TagNum = 0;
            int BufferCount = 0;
            byte MaskMem = 0;
            byte[] MaskAdr = new byte[2];
            byte MaskLen = 0;
            byte[] MaskData = new byte[100];
            byte MaskFlag = 0;
            byte AdrTID = 0;
            byte LenTID = 0;
            AdrTID = 0;
            LenTID = 6;
            MaskFlag = 0;
            int cbtime = System.Environment.TickCount;
            TagNum = 0;
            BufferCount = 0;
            Target = 0;
            Scantime = 0x14;
            Qvalue = 6;
            if (TIDFlag == 0)
                Session = 255;
            else
                Session = 0;
            FastFlag = 1;
            fCmdRet = RWDev.InventoryBuffer_G2(ref fComAdr, Qvalue, Session, MaskMem, MaskAdr, MaskLen, MaskData, MaskFlag, AdrTID, LenTID, TIDFlag, Target, InAnt, Scantime, FastFlag, ref BufferCount, ref TagNum, frmcomportindex);
            int x_time = System.Environment.TickCount - cbtime;//命令时间
            //string strLog = "带缓存查询： " + GetReturnCodeDesc(fCmdRet);
            //WriteLog(lrtxtLog, strLog, 0);
            ///////////设置网络断线重连
            if (fCmdRet == 0)//代表已查找结束，
            {
                IntPtr ptrWnd = IntPtr.Zero;
                ptrWnd = FindWindow(null, "UHFReader288 Demo V1.0");
                if (ptrWnd != IntPtr.Zero)         // 检查当前统计窗口是否打开
                {
                    total_tagnum = total_tagnum + TagNum;
                    int tagrate = (TagNum * 1000) / x_time;//速度等于张数/时间
                    string para = BufferCount.ToString() + "," + x_time.ToString() + "," + tagrate.ToString() + "," + total_tagnum.ToString();
                    SendMessage(ptrWnd, WM_SENDBUFF, IntPtr.Zero, para);
                }
            }
        }
        private void ReadProcess()
        {
            fIsBuffScan = true;
            while (!toStopThread)
            {
                if (BAnt1.Checked)
                {
                    InAnt = 0x80;
                    GetBuffData();
                }
                if (BAnt2.Checked)
                {
                    InAnt = 0x81;
                    GetBuffData();
                }
                if (BAnt3.Checked)
                {
                    InAnt = 0x82;
                    GetBuffData();
                }
                if (BAnt4.Checked)
                {
                    InAnt = 0x83;
                    GetBuffData();
                }
            }
            fIsBuffScan = false;
        }
        private void timer_Buff_Tick(object sender, EventArgs e)
        {
            lxLed_Btoltime.Text = (System.Environment.TickCount - total_time).ToString();
        }


        private void btExtRead_Click(object sender, EventArgs e)
        {
            byte ENum;
            byte Num = 0;
            byte Mem = 0;
            byte[] WordPtr = new byte[2];
            string str = ""; ;
            byte[] CardData = new byte[320];
            byte MaskMem = 0;
            byte[] MaskAdr = new byte[2];
            byte MaskLen = 0;
            byte[] MaskData = new byte[100];
            text_WriteData.Text = "";
            if (checkBox1.Checked)
            {
                if ((maskadr_textbox.Text == "") || (maskLen_textBox.Text == "") || (maskData_textBox.Text == ""))
                {
                    return;
                }
                ENum = 255;
                if (R_EPC.Checked) MaskMem = 1;
                if (R_TID.Checked) MaskMem = 2;
                if (R_User.Checked) MaskMem = 3;
                MaskAdr = HexStringToByteArray(maskadr_textbox.Text);
                MaskLen = Convert.ToByte(maskLen_textBox.Text, 16);
                MaskData = HexStringToByteArray(maskData_textBox.Text);
            }
            else
            {
                if (check_selecttag.Checked)
                    str = text_epc.Text;
                else
                    str = "";
                ENum = Convert.ToByte(str.Length / 4);
            }
            byte[] EPC = new byte[ENum * 2];
            EPC = HexStringToByteArray(str);
            if (C_Reserve.Checked)
                Mem = 0;
            if (C_EPC.Checked)
                Mem = 1;
            if (C_TID.Checked)
                Mem = 2;
            if (C_User.Checked)
                Mem = 3;
            if (text_WordPtr.Text == "" || text_RWlen.Text == "" || text_AccessCode2.Text.Length != 8)
            {
                return;
            }
            WordPtr = HexStringToByteArray(text_WordPtr.Text);
            Num = Convert.ToByte(text_RWlen.Text);
            fPassWord = HexStringToByteArray(text_AccessCode2.Text);
            for (int p = 0; p < 10; p++)
            {
                fCmdRet = RWDev.ExtReadData_G2(ref fComAdr, EPC, ENum, Mem, WordPtr, Num, fPassWord, MaskMem, MaskAdr, MaskLen, MaskData, CardData, ref ferrorcode, frmcomportindex);
                if (fCmdRet == 0) break;
            }
            if (fCmdRet != 0)
            {

                string strLog = "";
                if (fCmdRet == 0xFC)
                    strLog = "Extense read failed: " + "Return = 0x" + Convert.ToString(ferrorcode, 16) + "(" + GetErrorCodeDesc(ferrorcode) + ")";
                else
                    strLog = "Extense read failed:  " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                byte[] daw = new byte[Num * 2];
                Array.Copy(CardData, daw, Num * 2);
                text_WriteData.Text = ByteArrayToHexString(daw);
                string strLog = "Extense read success ";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void btExtWrite_Click(object sender, EventArgs e)
        {
            byte ENum;
            byte WNum = 0;
            byte Mem = 0;
            string str = "";
            byte[] WordPtr = new byte[2];
            byte[] CardData = new byte[320];
            byte MaskMem = 0;
            byte[] MaskAdr = new byte[2];
            byte MaskLen = 0;
            byte[] MaskData = new byte[100];
            if (checkBox1.Checked)
            {
                if ((maskadr_textbox.Text == "") || (maskLen_textBox.Text == "") || (maskData_textBox.Text == ""))
                {
                    return;
                }
                ENum = 255;
                if (R_EPC.Checked) MaskMem = 1;
                if (R_TID.Checked) MaskMem = 2;
                if (R_User.Checked) MaskMem = 3;
                MaskAdr = HexStringToByteArray(maskadr_textbox.Text);
                MaskLen = Convert.ToByte(maskLen_textBox.Text, 16);
                MaskData = HexStringToByteArray(maskData_textBox.Text);
            }
            else
            {
                if (check_selecttag.Checked)
                    str = text_epc.Text;
                else
                    str = "";
                ENum = Convert.ToByte(str.Length / 4);
            }
            byte[] EPC = new byte[ENum * 2];
            EPC = HexStringToByteArray(str);
            if (C_Reserve.Checked)
                Mem = 0;
            if (C_EPC.Checked)
                Mem = 1;
            if (C_TID.Checked)
                Mem = 2;
            if (C_User.Checked)
                Mem = 3;
            if (text_WordPtr.Text == "" || text_AccessCode2.Text.Length != 8)
            {
                return;
            }
            string epcstr = text_WriteData.Text;
            if (epcstr.Length % 4 != 0 || epcstr.Length == 0)
            {
                MessageBox.Show("Input data by word", "Write");
                return;
            }
            WNum = Convert.ToByte(epcstr.Length / 4);
            byte[] Writedata = new byte[WNum * 2 + 1];
            Writedata = HexStringToByteArray(epcstr);
            WordPtr = HexStringToByteArray(text_WordPtr.Text);
            fPassWord = HexStringToByteArray(text_AccessCode2.Text);
            if ((checkBox_pc.Checked) && (C_EPC.Checked))
            {
                WordPtr = HexStringToByteArray("0001");
                WNum = Convert.ToByte(epcstr.Length / 4 + 1);
                Writedata = HexStringToByteArray(textBox_pc.Text + epcstr);
            }
            for (int p = 0; p < 10; p++)
            {
                fCmdRet = RWDev.ExtWriteData_G2(ref fComAdr, EPC, WNum, ENum, Mem, WordPtr, Writedata, fPassWord, MaskMem, MaskAdr, MaskLen, MaskData, ref ferrorcode, frmcomportindex);
                if (fCmdRet == 0) break;
            }
            if (fCmdRet != 0)
            {
                string strLog = "";
                if (fCmdRet == 0xFC)
                    strLog = "Extense write failed: " + "Return = 0x" + Convert.ToString(ferrorcode, 16) + "(" + GetErrorCodeDesc(ferrorcode) + ")";
                else
                    strLog = "Extense write failed:  " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "Extense write success ";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void btSetMaxtime_Click(object sender, EventArgs e)
        {
            byte Scantime = 0;
            Scantime = Convert.ToByte(comboBox_maxtime.SelectedIndex + 3);
            fCmdRet = RWDev.SetInventoryScanTime(ref fComAdr, Scantime, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "Set inventory scan time failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "Set inventory scan time success ";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btSetMmode_Click(object sender, EventArgs e)
        {
            byte ReadMode = 0;
            string temp = text_RDVersion.Text;
            if (temp.IndexOf("UHFReader288M") == -1)//没找到
            {
                if (com_Mmode.SelectedIndex == 0)
                {
                    ReadMode = 0;
                }
                else
                {
                    ReadMode = 6;
                }
                fCmdRet = RWDev.SetWorkMode(ref fComAdr, ReadMode, frmcomportindex);
            }
            else
            {
                ReadMode = (byte)com_Mmode.SelectedIndex;
                fCmdRet = RWDev.SetReadMode(ref fComAdr, ReadMode, frmcomportindex);
            }
            if (fCmdRet != 0)
            {
                string strLog = "Set read mode failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "Set read mode success ";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void btMSetParameter_Click(object sender, EventArgs e)
        {
            byte[] Parameter = new byte[200];
            byte MaskMem = 0;
            byte[] MaskAdr = new byte[2];
            byte MaskLen = 0;
            byte[] MaskData = new byte[200];
            byte MaskFlag = 0;
            byte AdrTID = 0;
            byte LenTID = 0;
            byte TIDFlag = 0;
            if (MRB_G2.Checked)
            {
                Parameter[0] = 0;
            }
            else
            {
                Parameter[0] = 1;
            }

            Parameter[1] = (byte)COM_MRPTime.SelectedIndex;
            Parameter[2] = (byte)com_MFliterTime.SelectedIndex;
            Parameter[3] = (byte)com_MQ.SelectedIndex;
            Parameter[4] = (byte)com_MS.SelectedIndex;
            if (Parameter[4] > 3) Parameter[4] = 255;
            if (checkBox_mask.Checked)
            {
                if (RBM_EPC.Checked)
                {
                    MaskMem = 1;
                }
                else if (RBM_TID.Checked)
                {
                    MaskMem = 2;
                }
                else if (RBM_USER.Checked)
                {
                    MaskMem = 3;
                }
                if ((txt_Maddr.Text.Length != 4) || (txt_Mlen.Text.Length != 2) || (txt_Mdata.Text.Length % 2 != 0))
                {
                    MessageBox.Show("Mask error!", "information");
                    return;
                }
                MaskAdr = HexStringToByteArray(txt_Maddr.Text);
                int len = Convert.ToInt32(txt_Mlen.Text, 16);
                MaskLen = (byte)len;
                MaskData = HexStringToByteArray(txt_Mdata.Text);
                MaskFlag = 1;
            }
            if (checkBox_tid.Checked)
            {
                AdrTID = Convert.ToByte(txt_mtidaddr.Text, 16);
                LenTID = Convert.ToByte(txt_Mtidlen.Text, 16);
                TIDFlag = 1;
            }
            fCmdRet = RWDev.SetReadParameter(ref fComAdr, Parameter, MaskMem, MaskAdr, MaskLen, MaskData, MaskFlag, AdrTID, LenTID, TIDFlag, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "Set read parameter failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                string strLog = "Set read parameter success ";
                WriteLog(lrtxtLog, strLog, 0);
            }

        }

        private void btMGetParameter_Click(object sender, EventArgs e)
        {
            byte[] Parameter = new byte[200];
            fCmdRet = RWDev.GetReadParameter(ref fComAdr, Parameter, frmcomportindex);
            if (fCmdRet != 0)
            {
                string strLog = "Get read parameter failed: " + GetReturnCodeDesc(fCmdRet);
                WriteLog(lrtxtLog, strLog, 1);
            }
            else
            {
                com_Mmode.SelectedIndex = Parameter[0];
                if (Parameter[1] == 0)
                {
                    MRB_G2.Checked = true;
                }
                else
                {
                    MRB_6B.Checked = true;
                }
                COM_MRPTime.SelectedIndex = Parameter[2];
                com_MFliterTime.SelectedIndex = Parameter[3];
                com_MQ.SelectedIndex = Parameter[4];
                if (Parameter[5] == 255)
                    com_MS.SelectedIndex = 4;
                else
                    com_MS.SelectedIndex = Parameter[5];
                if (Parameter[6] == 1)
                {
                    RBM_EPC.Checked = true;
                }
                else if (Parameter[6] == 2)
                {
                    RBM_TID.Checked = true;
                }
                else if (Parameter[6] == 3)
                {
                    RBM_USER.Checked = true;
                }
                byte[] maskaddr = new byte[2];
                Array.Copy(Parameter, 7, maskaddr, 0, 2);
                txt_Maddr.Text = ByteArrayToHexString(maskaddr);
                txt_Mlen.Text = Convert.ToString(Parameter[9], 16).PadLeft(2, '0');
                byte[] data = new byte[32];
                Array.Copy(Parameter, 10, data, 0, 32);
                string temp = ByteArrayToHexString(data);
                int len = Parameter[9];
                if ((len % 8) == 0)
                {
                    len = len / 8;
                }
                else
                {
                    len = len / 8 + 1;
                }
                if (len <= 32)
                {
                    temp = temp.Substring(0, len * 2);
                }
                txt_Mdata.Text = temp;
                txt_mtidaddr.Text = Convert.ToString(Parameter[42], 16).PadLeft(2, '0');
                txt_Mtidlen.Text = Convert.ToString(Parameter[43], 16).PadLeft(2, '0');
                string strLog = "Get read parameter success ";
                WriteLog(lrtxtLog, strLog, 0);
            }
        }

        private void btStartMactive_Click(object sender, EventArgs e)
        {
            //total_time = System.Environment.TickCount;
            //lxLed_Mtag.Text = "0";
            //lxLed_Mtime.Text = "0";

            timer_RealTime.Enabled = !timer_RealTime.Enabled;
            if (!timer_RealTime.Enabled)
            {
                btStartMactive.Text = "Start";
                btStartMactive.BackColor = Color.Transparent;
            }
            else
            {
                fInventory_EPC_List = "";
                total_time = System.Environment.TickCount;
                lxLed_Mtag.Text = "0";
                lxLed_Mtime.Text = "0";
                dataGridView4.Rows.Clear();
                btStartMactive.BackColor = Color.Indigo;
                fIsInventoryScan = false;
                btStartMactive.Text = "Stop";
            }
        }

        private void GetRealtiemeData()
        {
            byte[] ScanModeData = new byte[40960];
            int nLen, NumLen;
            string temp1 = "";
            string binarystr1 = "";
            string binarystr2 = "";
            string RSSI = "";
            string AntStr = "";
            string lenstr = "";
            string EPCStr = "";
            int ValidDatalength;
            string temp;
            ValidDatalength = 0;
            DataGridViewRow rows = new DataGridViewRow();
            int xtime = System.Environment.TickCount;
            fCmdRet = RWDev.ReadActiveModeData(ScanModeData, ref ValidDatalength, frmcomportindex);
            if (fCmdRet == 0)
            {
                try
                {
                    byte[] daw = new byte[ValidDatalength];
                    Array.Copy(ScanModeData, 0, daw, 0, ValidDatalength);
                    temp = ByteArrayToHexString(daw);
                    fInventory_EPC_List = fInventory_EPC_List + temp;//把字符串存进列表
                    nLen = fInventory_EPC_List.Length;
                    while (fInventory_EPC_List.Length > 18)
                    {
                        string FlagStr = Convert.ToString(fComAdr, 16).PadLeft(2, '0') + "EE00";//查找头位置标志字符串
                        int nindex = fInventory_EPC_List.IndexOf(FlagStr);
                        if (nindex > 1)
                            fInventory_EPC_List = fInventory_EPC_List.Substring(nindex - 2);
                        else
                        {
                            fInventory_EPC_List = fInventory_EPC_List.Substring(2);
                            continue;
                        }
                        NumLen = Convert.ToInt32(fInventory_EPC_List.Substring(0, 2), 16) * 2 + 2;//取第一个帧的长度
                        if (fInventory_EPC_List.Length < NumLen)
                        {
                            break;
                        }
                        temp1 = fInventory_EPC_List.Substring(0, NumLen);
                        fInventory_EPC_List = fInventory_EPC_List.Substring(NumLen);
                        if (!CheckCRC(temp1)) continue;
                        AntStr = Convert.ToString(Convert.ToInt32(temp1.Substring(8, 2), 16), 2).PadLeft(4, '0');
                        lenstr = Convert.ToString(Convert.ToInt32(temp1.Substring(10, 2), 16), 10);
                        EPCStr = temp1.Substring(12, temp1.Length - 18);
                        RSSI = temp1.Substring(temp1.Length - 6, 2);
                        bool isonlistview = false;
                        for (int i = 0; i < dataGridView4.RowCount; i++)
                        {
                            if ((dataGridView4.Rows[i].Cells[1].Value != null) && (EPCStr == dataGridView4.Rows[i].Cells[1].Value.ToString()))
                            {
                                rows = dataGridView4.Rows[i];
                                rows.Cells[3].Value = AntStr;
                                rows.Cells[4].Value = RSSI;
                                isonlistview = true;
                                break;
                            }
                        }
                        if (!isonlistview)
                        {
                            string[] arr = new string[6];
                            arr[0] = (dataGridView4.RowCount + 1).ToString();
                            arr[1] = EPCStr;
                            arr[2] = lenstr;
                            arr[3] = AntStr;
                            arr[4] = RSSI;
                            dataGridView4.Rows.Insert(dataGridView4.RowCount, arr);
                        }
                        lxLed_Mtime.Text = (System.Environment.TickCount - total_time).ToString();
                    }
                }
                catch (System.Exception ex)
                {
                    ex.ToString();
                }
            }
            lxLed_Mtag.Text = dataGridView4.RowCount.ToString();
        }
        private void timer_RealTime_Tick(object sender, EventArgs e)
        {
            if (fIsInventoryScan) return;
            fIsInventoryScan = true;
            GetRealtiemeData();
            fIsInventoryScan = false;
        }

        private void radioButton_band8_CheckedChanged(object sender, EventArgs e)
        {
            int i;
            ComboBox_dmaxfre.Items.Clear();
            ComboBox_dminfre.Items.Clear();
            for (i = 0; i < 20; i++)
            {
                ComboBox_dminfre.Items.Add(Convert.ToString(840.125 + i * 0.25) + " MHz");
                ComboBox_dmaxfre.Items.Add(Convert.ToString(840.125 + i * 0.25) + " MHz");
            }
            ComboBox_dmaxfre.SelectedIndex = 19;
            ComboBox_dminfre.SelectedIndex = 0;
        }

        private void ListView_ID_6B_SelectedIndexChanged(object sender, EventArgs e)//
        {

        }

        private void lxLedControl1_Click(object sender, EventArgs e)
        {

        }

        private void ipServerIP_Load(object sender, EventArgs e)
        {

        }
    }
}
