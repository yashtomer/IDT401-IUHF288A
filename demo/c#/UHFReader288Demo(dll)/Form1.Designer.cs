namespace UHFReader288Demo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lrtxtLog = new CustomControl.LogRichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Maintab = new System.Windows.Forms.TabControl();
            this.Main_Page1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Basic = new System.Windows.Forms.TabPage();
            this.group_maxtime = new System.Windows.Forms.GroupBox();
            this.comboBox_maxtime = new System.Windows.Forms.ComboBox();
            this.btSetMaxtime = new System.Windows.Forms.Button();
            this.gbp_buff = new System.Windows.Forms.GroupBox();
            this.rb496 = new System.Windows.Forms.RadioButton();
            this.rb128 = new System.Windows.Forms.RadioButton();
            this.btGetEPCandTIDLen = new System.Windows.Forms.Button();
            this.btSetEPCandTIDLen = new System.Windows.Forms.Button();
            this.btGetInformation = new System.Windows.Forms.Button();
            this.btDefault = new System.Windows.Forms.Button();
            this.btFlashROM = new System.Windows.Forms.Button();
            this.gpb_clock = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Text_sec = new System.Windows.Forms.TextBox();
            this.Text_min = new System.Windows.Forms.TextBox();
            this.Text_hour = new System.Windows.Forms.TextBox();
            this.Text_day = new System.Windows.Forms.TextBox();
            this.Text_month = new System.Windows.Forms.TextBox();
            this.Text_year = new System.Windows.Forms.TextBox();
            this.ClockCMD = new System.Windows.Forms.Button();
            this.GetClock = new System.Windows.Forms.RadioButton();
            this.SetClock = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.gpb_antconfig = new System.Windows.Forms.GroupBox();
            this.Button_Ant = new System.Windows.Forms.Button();
            this.checkant4 = new System.Windows.Forms.CheckBox();
            this.checkant3 = new System.Windows.Forms.CheckBox();
            this.checkant2 = new System.Windows.Forms.CheckBox();
            this.checkant1 = new System.Windows.Forms.CheckBox();
            this.gpb_checkant = new System.Windows.Forms.GroupBox();
            this.btSetcheckant = new System.Windows.Forms.Button();
            this.rb_Closecheckant = new System.Windows.Forms.RadioButton();
            this.rb_Opencheckant = new System.Windows.Forms.RadioButton();
            this.gpb_GPIO = new System.Windows.Forms.GroupBox();
            this.Button_GetGPIO = new System.Windows.Forms.Button();
            this.Button_SetGPIO = new System.Windows.Forms.Button();
            this.check_int4 = new System.Windows.Forms.CheckBox();
            this.check_int3 = new System.Windows.Forms.CheckBox();
            this.check_int2 = new System.Windows.Forms.CheckBox();
            this.check_int1 = new System.Windows.Forms.CheckBox();
            this.check_out4 = new System.Windows.Forms.CheckBox();
            this.check_out3 = new System.Windows.Forms.CheckBox();
            this.check_out2 = new System.Windows.Forms.CheckBox();
            this.check_out1 = new System.Windows.Forms.CheckBox();
            this.gpb_OutputRep = new System.Windows.Forms.GroupBox();
            this.btOutputRep = new System.Windows.Forms.Button();
            this.check_OutputRep4 = new System.Windows.Forms.CheckBox();
            this.check_OutputRep3 = new System.Windows.Forms.CheckBox();
            this.check_OutputRep2 = new System.Windows.Forms.CheckBox();
            this.check_OutputRep1 = new System.Windows.Forms.CheckBox();
            this.gpb_Relay = new System.Windows.Forms.GroupBox();
            this.label38 = new System.Windows.Forms.Label();
            this.ComboBox_RelayTime = new System.Windows.Forms.ComboBox();
            this.label37 = new System.Windows.Forms.Label();
            this.btRelay = new System.Windows.Forms.Button();
            this.gpb_baud = new System.Windows.Forms.GroupBox();
            this.ComboBox_baud = new System.Windows.Forms.ComboBox();
            this.btBaudRate = new System.Windows.Forms.Button();
            this.gpb_DBM = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ComboBox_PowerDbm = new System.Windows.Forms.ComboBox();
            this.BT_DBM = new System.Windows.Forms.Button();
            this.gpb_Freq = new System.Windows.Forms.GroupBox();
            this.radioButton_band8 = new System.Windows.Forms.RadioButton();
            this.CheckBox_SameFre = new System.Windows.Forms.CheckBox();
            this.radioButton_band4 = new System.Windows.Forms.RadioButton();
            this.radioButton_band3 = new System.Windows.Forms.RadioButton();
            this.radioButton_band2 = new System.Windows.Forms.RadioButton();
            this.radioButton_band1 = new System.Windows.Forms.RadioButton();
            this.btFreq = new System.Windows.Forms.Button();
            this.ComboBox_dmaxfre = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ComboBox_dminfre = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.gpb_beep = new System.Windows.Forms.GroupBox();
            this.Radio_beepDis = new System.Windows.Forms.RadioButton();
            this.Radio_beepEn = new System.Windows.Forms.RadioButton();
            this.Button_Beep = new System.Windows.Forms.Button();
            this.gpb_RDVersion = new System.Windows.Forms.GroupBox();
            this.text_RDVersion = new System.Windows.Forms.TextBox();
            this.gpb_MDVersion = new System.Windows.Forms.GroupBox();
            this.text_MDVersion = new System.Windows.Forms.TextBox();
            this.btMDVersion = new System.Windows.Forms.Button();
            this.gpb_Serial = new System.Windows.Forms.GroupBox();
            this.text_Serial = new System.Windows.Forms.TextBox();
            this.btSerial = new System.Windows.Forms.Button();
            this.gpb_address = new System.Windows.Forms.GroupBox();
            this.text_address = new System.Windows.Forms.TextBox();
            this.btaddress = new System.Windows.Forms.Button();
            this.gpb_tcp = new System.Windows.Forms.GroupBox();
            this.tb_Port = new System.Windows.Forms.TextBox();
            this.ipServerIP = new CustomControl.IpAddressTextBox();
            this.btDisConnectTcp = new System.Windows.Forms.Button();
            this.btConnectTcp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gpb_rs232 = new System.Windows.Forms.GroupBox();
            this.btDisConnect232 = new System.Windows.Forms.Button();
            this.btConnect232 = new System.Windows.Forms.Button();
            this.ComboBox_baud2 = new System.Windows.Forms.ComboBox();
            this.label47 = new System.Windows.Forms.Label();
            this.ComboBox_COM = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_tcp = new System.Windows.Forms.RadioButton();
            this.rb_rs232 = new System.Windows.Forms.RadioButton();
            this.tabPage_Mx = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbp_trigger = new System.Windows.Forms.GroupBox();
            this.label84 = new System.Windows.Forms.Label();
            this.bttrigger = new System.Windows.Forms.Button();
            this.comboBox_trigger = new System.Windows.Forms.ComboBox();
            this.label85 = new System.Windows.Forms.Label();
            this.groupBox43 = new System.Windows.Forms.GroupBox();
            this.btGetQS = new System.Windows.Forms.Button();
            this.btSetQS = new System.Windows.Forms.Button();
            this.com_acS = new System.Windows.Forms.ComboBox();
            this.label65 = new System.Windows.Forms.Label();
            this.com_acQ = new System.Windows.Forms.ComboBox();
            this.label64 = new System.Windows.Forms.Label();
            this.groupBox44 = new System.Windows.Forms.GroupBox();
            this.text_tidlen = new System.Windows.Forms.TextBox();
            this.label67 = new System.Windows.Forms.Label();
            this.text_tidaddr = new System.Windows.Forms.TextBox();
            this.btTIDpara = new System.Windows.Forms.Button();
            this.label66 = new System.Windows.Forms.Label();
            this.btGetWorkmodepara = new System.Windows.Forms.Button();
            this.groupBox37 = new System.Windows.Forms.GroupBox();
            this.btworkmode = new System.Windows.Forms.Button();
            this.comboBox_mode = new System.Windows.Forms.ComboBox();
            this.label59 = new System.Windows.Forms.Label();
            this.groupBox36 = new System.Windows.Forms.GroupBox();
            this.btInterval = new System.Windows.Forms.Button();
            this.comboBox_intervalT = new System.Windows.Forms.ComboBox();
            this.label58 = new System.Windows.Forms.Label();
            this.gbp_tagType = new System.Windows.Forms.GroupBox();
            this.rb_G2TID = new System.Windows.Forms.RadioButton();
            this.bt_typeTag = new System.Windows.Forms.Button();
            this.rb_EAS = new System.Windows.Forms.RadioButton();
            this.rb_G2 = new System.Windows.Forms.RadioButton();
            this.groupBox35 = new System.Windows.Forms.GroupBox();
            this.rb_180006B = new System.Windows.Forms.RadioButton();
            this.rb_180006c = new System.Windows.Forms.RadioButton();
            this.gbp_Response = new System.Windows.Forms.GroupBox();
            this.btResponse = new System.Windows.Forms.Button();
            this.label57 = new System.Windows.Forms.Label();
            this.comboBox_RespTime = new System.Windows.Forms.ComboBox();
            this.label56 = new System.Windows.Forms.Label();
            this.comboBox_Resp = new System.Windows.Forms.ComboBox();
            this.label55 = new System.Windows.Forms.Label();
            this.gbp_mask = new System.Windows.Forms.GroupBox();
            this.btMaskSet = new System.Windows.Forms.Button();
            this.text_mdata = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.text_mlen = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.text_madds = new System.Windows.Forms.TextBox();
            this.label81 = new System.Windows.Forms.Label();
            this.rb_MaskUser = new System.Windows.Forms.RadioButton();
            this.rb_MaskTID = new System.Windows.Forms.RadioButton();
            this.rb_MaskEPC = new System.Windows.Forms.RadioButton();
            this.gbp_EASAcc = new System.Windows.Forms.GroupBox();
            this.btAccuracy = new System.Windows.Forms.Button();
            this.ComboBox_Accuracy = new System.Windows.Forms.ComboBox();
            this.label82 = new System.Windows.Forms.Label();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.rbEASAcc = new System.Windows.Forms.RadioButton();
            this.tabPage_Module = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btMSetParameter = new System.Windows.Forms.Button();
            this.btMGetParameter = new System.Windows.Forms.Button();
            this.groupBox39 = new System.Windows.Forms.GroupBox();
            this.btSetMmode = new System.Windows.Forms.Button();
            this.com_Mmode = new System.Windows.Forms.ComboBox();
            this.label111 = new System.Windows.Forms.Label();
            this.groupBox38 = new System.Windows.Forms.GroupBox();
            this.checkBox_tid = new System.Windows.Forms.CheckBox();
            this.txt_Mtidlen = new System.Windows.Forms.TextBox();
            this.label103 = new System.Windows.Forms.Label();
            this.txt_mtidaddr = new System.Windows.Forms.TextBox();
            this.label104 = new System.Windows.Forms.Label();
            this.groupBox34 = new System.Windows.Forms.GroupBox();
            this.checkBox_mask = new System.Windows.Forms.CheckBox();
            this.txt_Mdata = new System.Windows.Forms.TextBox();
            this.label100 = new System.Windows.Forms.Label();
            this.txt_Mlen = new System.Windows.Forms.TextBox();
            this.label101 = new System.Windows.Forms.Label();
            this.txt_Maddr = new System.Windows.Forms.TextBox();
            this.label102 = new System.Windows.Forms.Label();
            this.RBM_USER = new System.Windows.Forms.RadioButton();
            this.RBM_TID = new System.Windows.Forms.RadioButton();
            this.RBM_EPC = new System.Windows.Forms.RadioButton();
            this.groupBox33 = new System.Windows.Forms.GroupBox();
            this.com_MS = new System.Windows.Forms.ComboBox();
            this.label99 = new System.Windows.Forms.Label();
            this.com_MQ = new System.Windows.Forms.ComboBox();
            this.label98 = new System.Windows.Forms.Label();
            this.groupBox32 = new System.Windows.Forms.GroupBox();
            this.com_MFliterTime = new System.Windows.Forms.ComboBox();
            this.label97 = new System.Windows.Forms.Label();
            this.groupBox28 = new System.Windows.Forms.GroupBox();
            this.COM_MRPTime = new System.Windows.Forms.ComboBox();
            this.label96 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MRB_6B = new System.Windows.Forms.RadioButton();
            this.MRB_G2 = new System.Windows.Forms.RadioButton();
            this.Main_Page2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage_answer = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lxLedControl5 = new LxControl.LxLedControl();
            this.label9 = new System.Windows.Forms.Label();
            this.lxLedControl4 = new LxControl.LxLedControl();
            this.label8 = new System.Windows.Forms.Label();
            this.lxLedControl3 = new LxControl.LxLedControl();
            this.label7 = new System.Windows.Forms.Label();
            this.lxLedControl2 = new LxControl.LxLedControl();
            this.label6 = new System.Windows.Forms.Label();
            this.lxLedControl1 = new LxControl.LxLedControl();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox_rate = new System.Windows.Forms.CheckBox();
            this.label80 = new System.Windows.Forms.Label();
            this.text_target = new System.Windows.Forms.TextBox();
            this.check_num = new System.Windows.Forms.CheckBox();
            this.com_Target = new System.Windows.Forms.ComboBox();
            this.label79 = new System.Windows.Forms.Label();
            this.com_scantime = new System.Windows.Forms.ComboBox();
            this.label39 = new System.Windows.Forms.Label();
            this.com_S = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.com_Q = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.group_ant1 = new System.Windows.Forms.GroupBox();
            this.check_ant4 = new System.Windows.Forms.CheckBox();
            this.check_ant3 = new System.Windows.Forms.CheckBox();
            this.check_ant2 = new System.Windows.Forms.CheckBox();
            this.check_ant1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_tid = new System.Windows.Forms.RadioButton();
            this.rb_epc = new System.Windows.Forms.RadioButton();
            this.btIventoryG2 = new System.Windows.Forms.Button();
            this.tabPage_active = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.lxLed_toltime = new LxControl.LxLedControl();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label19 = new System.Windows.Forms.Label();
            this.lxLed_toltag = new LxControl.LxLedControl();
            this.label18 = new System.Windows.Forms.Label();
            this.lxLed_cmdsud = new LxControl.LxLedControl();
            this.label17 = new System.Windows.Forms.Label();
            this.lxLed_Num = new LxControl.LxLedControl();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btClearBuffer = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btGettagbuffer = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btGetrunmodedata = new System.Windows.Forms.Button();
            this.tabPage_Realtime = new System.Windows.Forms.TabPage();
            this.panel10 = new System.Windows.Forms.Panel();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox41 = new System.Windows.Forms.GroupBox();
            this.lxLed_Mtime = new LxControl.LxLedControl();
            this.label113 = new System.Windows.Forms.Label();
            this.lxLed_Mtag = new LxControl.LxLedControl();
            this.label116 = new System.Windows.Forms.Label();
            this.groupBox42 = new System.Windows.Forms.GroupBox();
            this.btStartMactive = new System.Windows.Forms.Button();
            this.tabPage_Buff = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.groupBox27 = new System.Windows.Forms.GroupBox();
            this.btQueryBuffNum = new System.Windows.Forms.Button();
            this.btRandCbuff = new System.Windows.Forms.Button();
            this.btClearBuff = new System.Windows.Forms.Button();
            this.btReadBuff = new System.Windows.Forms.Button();
            this.group_ant2 = new System.Windows.Forms.GroupBox();
            this.BAnt4 = new System.Windows.Forms.CheckBox();
            this.BAnt3 = new System.Windows.Forms.CheckBox();
            this.BAnt2 = new System.Windows.Forms.CheckBox();
            this.BAnt1 = new System.Windows.Forms.CheckBox();
            this.groupBox29 = new System.Windows.Forms.GroupBox();
            this.rb_btid = new System.Windows.Forms.RadioButton();
            this.rb_bepc = new System.Windows.Forms.RadioButton();
            this.btStartBuff = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox30 = new System.Windows.Forms.GroupBox();
            this.lxLed_cmdTime = new LxControl.LxLedControl();
            this.label86 = new System.Windows.Forms.Label();
            this.lxLed_Btoltime = new LxControl.LxLedControl();
            this.label83 = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.lxLed_Btoltag = new LxControl.LxLedControl();
            this.label92 = new System.Windows.Forms.Label();
            this.lxLed_Bcmdsud = new LxControl.LxLedControl();
            this.label94 = new System.Windows.Forms.Label();
            this.lxLed_BNum = new LxControl.LxLedControl();
            this.label95 = new System.Windows.Forms.Label();
            this.tabPage_RW = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.btCheckReadProtected_G2 = new System.Windows.Forms.Button();
            this.btRemoveReadProtect_G2 = new System.Windows.Forms.Button();
            this.btSetMultiReadProtect_G2 = new System.Windows.Forms.Button();
            this.btSetReadProtect_G2 = new System.Windows.Forms.Button();
            this.text_AccessCode4 = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.btWriteEPC_G2 = new System.Windows.Forms.Button();
            this.text_AccessCode3 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.text_WriteEPC = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.btDestroyCard = new System.Windows.Forms.Button();
            this.text_DestroyCode = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btCheckEASAlarm = new System.Windows.Forms.Button();
            this.btSetEASAlarm_G2 = new System.Windows.Forms.Button();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.NoAlarm_G2 = new System.Windows.Forms.RadioButton();
            this.Alarm_G2 = new System.Windows.Forms.RadioButton();
            this.text_AccessCode5 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.btSetProtectState = new System.Windows.Forms.Button();
            this.Edit_AccessCode6 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.AlwaysNot2 = new System.Windows.Forms.RadioButton();
            this.Always2 = new System.Windows.Forms.RadioButton();
            this.Proect2 = new System.Windows.Forms.RadioButton();
            this.NoProect2 = new System.Windows.Forms.RadioButton();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.p_pass = new System.Windows.Forms.RadioButton();
            this.P_User = new System.Windows.Forms.RadioButton();
            this.P_TID = new System.Windows.Forms.RadioButton();
            this.P_EPC = new System.Windows.Forms.RadioButton();
            this.P_kill = new System.Windows.Forms.RadioButton();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.btExtWrite = new System.Windows.Forms.Button();
            this.btExtRead = new System.Windows.Forms.Button();
            this.textBox_pc = new System.Windows.Forms.TextBox();
            this.checkBox_pc = new System.Windows.Forms.CheckBox();
            this.btBlockWrite = new System.Windows.Forms.Button();
            this.btBlockErase = new System.Windows.Forms.Button();
            this.btWrite = new System.Windows.Forms.Button();
            this.btRead = new System.Windows.Forms.Button();
            this.text_WriteData = new System.Windows.Forms.TextBox();
            this.text_AccessCode2 = new System.Windows.Forms.TextBox();
            this.text_RWlen = new System.Windows.Forms.TextBox();
            this.text_WordPtr = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.C_User = new System.Windows.Forms.RadioButton();
            this.C_TID = new System.Windows.Forms.RadioButton();
            this.C_EPC = new System.Windows.Forms.RadioButton();
            this.C_Reserve = new System.Windows.Forms.RadioButton();
            this.groupBox31 = new System.Windows.Forms.GroupBox();
            this.maskData_textBox = new System.Windows.Forms.TextBox();
            this.label60 = new System.Windows.Forms.Label();
            this.groupBox40 = new System.Windows.Forms.GroupBox();
            this.R_User = new System.Windows.Forms.RadioButton();
            this.R_TID = new System.Windows.Forms.RadioButton();
            this.R_EPC = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.maskLen_textBox = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.maskadr_textbox = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.btSelectTag = new System.Windows.Forms.Button();
            this.comboBox_EPC = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.text_epc = new System.Windows.Forms.TextBox();
            this.check_selecttag = new System.Windows.Forms.CheckBox();
            this.Main_Page3 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.text_Statu6B = new System.Windows.Forms.TextBox();
            this.btCheckLock6B = new System.Windows.Forms.Button();
            this.btLock6B = new System.Windows.Forms.Button();
            this.text_checkaddr = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.text_lock6b = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.text_W6B = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.btWrite6B = new System.Windows.Forms.Button();
            this.text_W6BLen = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.text_W6BAddr = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.text_R6B = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.btRead6B = new System.Windows.Forms.Button();
            this.text_R6BLen = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.text_R6BAddr = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.text_6BUID = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.ListView_ID_6B = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.rb_mutiple = new System.Windows.Forms.RadioButton();
            this.rb_single = new System.Windows.Forms.RadioButton();
            this.btInventory6B = new System.Windows.Forms.Button();
            this.Main_Page4 = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.DeviceListView = new System.Windows.Forms.ListView();
            this.deviceName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deviceIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deviceMac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.iEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telnetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btSave = new System.Windows.Forms.Button();
            this.btLoadDefault = new System.Windows.Forms.Button();
            this.groupBox51 = new System.Windows.Forms.GroupBox();
            this.btGetNet = new System.Windows.Forms.Button();
            this.btSetNet = new System.Windows.Forms.Button();
            this.label110 = new System.Windows.Forms.Label();
            this.macTB = new System.Windows.Forms.TextBox();
            this.panel_StaticIp = new System.Windows.Forms.Panel();
            this.label109 = new System.Windows.Forms.Label();
            this.label108 = new System.Windows.Forms.Label();
            this.label107 = new System.Windows.Forms.Label();
            this.label106 = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.altDNSTB = new System.Windows.Forms.TextBox();
            this.pDNSTB = new System.Windows.Forms.TextBox();
            this.gatewayTB = new System.Windows.Forms.TextBox();
            this.subnetTB = new System.Windows.Forms.TextBox();
            this.ipTB = new System.Windows.Forms.TextBox();
            this.groupBox50 = new System.Windows.Forms.GroupBox();
            this.btGetCnt = new System.Windows.Forms.Button();
            this.btSetCnt = new System.Windows.Forms.Button();
            this.panel_TCP = new System.Windows.Forms.Panel();
            this.label87 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.workasCB = new System.Windows.Forms.ComboBox();
            this.tcpRomteHostTB = new System.Windows.Forms.TextBox();
            this.tcpRemotePortNUD = new System.Windows.Forms.NumericUpDown();
            this.tcpLocalPortNUD = new System.Windows.Forms.NumericUpDown();
            this.tcpActiveCB = new System.Windows.Forms.ComboBox();
            this.groupBox49 = new System.Windows.Forms.GroupBox();
            this.btGetSeriaPort = new System.Windows.Forms.Button();
            this.btSetSerialPort = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label72 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.protocolCB = new System.Windows.Forms.ComboBox();
            this.stopbitCB = new System.Windows.Forms.ComboBox();
            this.parityCB = new System.Windows.Forms.ComboBox();
            this.databitCB = new System.Windows.Forms.ComboBox();
            this.baudrateCB = new System.Windows.Forms.ComboBox();
            this.flowCB = new System.Windows.Forms.ComboBox();
            this.fifoCB = new System.Windows.Forms.ComboBox();
            this.groupBox47 = new System.Windows.Forms.GroupBox();
            this.btExitAT = new System.Windows.Forms.Button();
            this.btGotoAT = new System.Windows.Forms.Button();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.label63 = new System.Windows.Forms.Label();
            this.stcprecv = new CustomControl.LogRichTextBox();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.listtcp = new System.Windows.Forms.ListBox();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.btStop = new System.Windows.Forms.Button();
            this.btListen = new System.Windows.Forms.Button();
            this.stcpport = new System.Windows.Forms.TextBox();
            this.label62 = new System.Windows.Forms.Label();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.groupBox26 = new System.Windows.Forms.GroupBox();
            this.bttcpdisconnect = new System.Windows.Forms.Button();
            this.bttcpconnect = new System.Windows.Forms.Button();
            this.remotePort = new System.Windows.Forms.TextBox();
            this.label71 = new System.Windows.Forms.Label();
            this.tcpremoteIp = new CustomControl.IpAddressTextBox();
            this.label70 = new System.Windows.Forms.Label();
            this.bttcpsend = new System.Windows.Forms.Button();
            this.label69 = new System.Windows.Forms.Label();
            this.ctctsend = new System.Windows.Forms.TextBox();
            this.label68 = new System.Windows.Forms.Label();
            this.ctctrecv = new CustomControl.LogRichTextBox();
            this.btFlashCl = new System.Windows.Forms.Button();
            this.timer_answer = new System.Windows.Forms.Timer(this.components);
            this.timer_runmode = new System.Windows.Forms.Timer(this.components);
            this.timer_EAS = new System.Windows.Forms.Timer(this.components);
            this.Timer_Test_6B = new System.Windows.Forms.Timer(this.components);
            this.timer_Buff = new System.Windows.Forms.Timer(this.components);
            this.timer_RealTime = new System.Windows.Forms.Timer(this.components);
            this.Maintab.SuspendLayout();
            this.Main_Page1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_Basic.SuspendLayout();
            this.group_maxtime.SuspendLayout();
            this.gbp_buff.SuspendLayout();
            this.gpb_clock.SuspendLayout();
            this.gpb_antconfig.SuspendLayout();
            this.gpb_checkant.SuspendLayout();
            this.gpb_GPIO.SuspendLayout();
            this.gpb_OutputRep.SuspendLayout();
            this.gpb_Relay.SuspendLayout();
            this.gpb_baud.SuspendLayout();
            this.gpb_DBM.SuspendLayout();
            this.gpb_Freq.SuspendLayout();
            this.gpb_beep.SuspendLayout();
            this.gpb_RDVersion.SuspendLayout();
            this.gpb_MDVersion.SuspendLayout();
            this.gpb_Serial.SuspendLayout();
            this.gpb_address.SuspendLayout();
            this.gpb_tcp.SuspendLayout();
            this.gpb_rs232.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage_Mx.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbp_trigger.SuspendLayout();
            this.groupBox43.SuspendLayout();
            this.groupBox44.SuspendLayout();
            this.groupBox37.SuspendLayout();
            this.groupBox36.SuspendLayout();
            this.gbp_tagType.SuspendLayout();
            this.groupBox35.SuspendLayout();
            this.gbp_Response.SuspendLayout();
            this.gbp_mask.SuspendLayout();
            this.gbp_EASAcc.SuspendLayout();
            this.tabPage_Module.SuspendLayout();
            this.panel9.SuspendLayout();
            this.groupBox39.SuspendLayout();
            this.groupBox38.SuspendLayout();
            this.groupBox34.SuspendLayout();
            this.groupBox33.SuspendLayout();
            this.groupBox32.SuspendLayout();
            this.groupBox28.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Main_Page2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage_answer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.group_ant1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage_active.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_toltime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_toltag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_cmdsud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_Num)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage_Realtime.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.groupBox41.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_Mtime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_Mtag)).BeginInit();
            this.groupBox42.SuspendLayout();
            this.tabPage_Buff.SuspendLayout();
            this.panel8.SuspendLayout();
            this.groupBox27.SuspendLayout();
            this.group_ant2.SuspendLayout();
            this.groupBox29.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox30.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_cmdTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_Btoltime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_Btoltag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_Bcmdsud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_BNum)).BeginInit();
            this.tabPage_RW.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox17.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox31.SuspendLayout();
            this.groupBox40.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.Main_Page3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox23.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.Main_Page4.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox51.SuspendLayout();
            this.panel_StaticIp.SuspendLayout();
            this.groupBox50.SuspendLayout();
            this.panel_TCP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcpRemotePortNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcpLocalPortNUD)).BeginInit();
            this.groupBox49.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox47.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.groupBox25.SuspendLayout();
            this.groupBox24.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.groupBox26.SuspendLayout();
            this.SuspendLayout();
            // 
            // lrtxtLog
            // 
            this.lrtxtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lrtxtLog.EnableAutoDragDrop = true;
            this.lrtxtLog.Location = new System.Drawing.Point(-2, 1003);
            this.lrtxtLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lrtxtLog.Name = "lrtxtLog";
            this.lrtxtLog.Size = new System.Drawing.Size(1618, 116);
            this.lrtxtLog.TabIndex = 0;
            this.lrtxtLog.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 970);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Operation records:";
            // 
            // Maintab
            // 
            this.Maintab.Controls.Add(this.Main_Page1);
            this.Maintab.Controls.Add(this.Main_Page2);
            this.Maintab.Controls.Add(this.Main_Page3);
            this.Maintab.Controls.Add(this.Main_Page4);
            this.Maintab.Dock = System.Windows.Forms.DockStyle.Top;
            this.Maintab.ItemSize = new System.Drawing.Size(72, 23);
            this.Maintab.Location = new System.Drawing.Point(0, 0);
            this.Maintab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Maintab.Multiline = true;
            this.Maintab.Name = "Maintab";
            this.Maintab.SelectedIndex = 0;
            this.Maintab.Size = new System.Drawing.Size(1618, 962);
            this.Maintab.TabIndex = 3;
            this.Maintab.SelectedIndexChanged += new System.EventHandler(this.Maintab_SelectedIndexChanged);
            // 
            // Main_Page1
            // 
            this.Main_Page1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Main_Page1.Controls.Add(this.tabControl1);
            this.Main_Page1.Location = new System.Drawing.Point(4, 27);
            this.Main_Page1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Main_Page1.Name = "Main_Page1";
            this.Main_Page1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Main_Page1.Size = new System.Drawing.Size(1610, 931);
            this.Main_Page1.TabIndex = 0;
            this.Main_Page1.Text = "   Command   ";
            this.Main_Page1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage_Basic);
            this.tabControl1.Controls.Add(this.tabPage_Mx);
            this.tabControl1.Controls.Add(this.tabPage_Module);
            this.tabControl1.HotTrack = true;
            this.tabControl1.ItemSize = new System.Drawing.Size(84, 23);
            this.tabControl1.Location = new System.Drawing.Point(2, 7);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1598, 897);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.Maintab_SelectedIndexChanged);
            // 
            // tabPage_Basic
            // 
            this.tabPage_Basic.Controls.Add(this.group_maxtime);
            this.tabPage_Basic.Controls.Add(this.gbp_buff);
            this.tabPage_Basic.Controls.Add(this.btGetInformation);
            this.tabPage_Basic.Controls.Add(this.btDefault);
            this.tabPage_Basic.Controls.Add(this.btFlashROM);
            this.tabPage_Basic.Controls.Add(this.gpb_clock);
            this.tabPage_Basic.Controls.Add(this.gpb_antconfig);
            this.tabPage_Basic.Controls.Add(this.gpb_checkant);
            this.tabPage_Basic.Controls.Add(this.gpb_GPIO);
            this.tabPage_Basic.Controls.Add(this.gpb_OutputRep);
            this.tabPage_Basic.Controls.Add(this.gpb_Relay);
            this.tabPage_Basic.Controls.Add(this.gpb_baud);
            this.tabPage_Basic.Controls.Add(this.gpb_DBM);
            this.tabPage_Basic.Controls.Add(this.gpb_Freq);
            this.tabPage_Basic.Controls.Add(this.gpb_beep);
            this.tabPage_Basic.Controls.Add(this.gpb_RDVersion);
            this.tabPage_Basic.Controls.Add(this.gpb_MDVersion);
            this.tabPage_Basic.Controls.Add(this.gpb_Serial);
            this.tabPage_Basic.Controls.Add(this.gpb_address);
            this.tabPage_Basic.Controls.Add(this.gpb_tcp);
            this.tabPage_Basic.Controls.Add(this.gpb_rs232);
            this.tabPage_Basic.Controls.Add(this.groupBox1);
            this.tabPage_Basic.Location = new System.Drawing.Point(4, 4);
            this.tabPage_Basic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage_Basic.Name = "tabPage_Basic";
            this.tabPage_Basic.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage_Basic.Size = new System.Drawing.Size(1590, 866);
            this.tabPage_Basic.TabIndex = 0;
            this.tabPage_Basic.Text = "  Basic  ";
            this.tabPage_Basic.UseVisualStyleBackColor = true;
            // 
            // group_maxtime
            // 
            this.group_maxtime.Controls.Add(this.comboBox_maxtime);
            this.group_maxtime.Controls.Add(this.btSetMaxtime);
            this.group_maxtime.Location = new System.Drawing.Point(9, 483);
            this.group_maxtime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.group_maxtime.Name = "group_maxtime";
            this.group_maxtime.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.group_maxtime.Size = new System.Drawing.Size(513, 68);
            this.group_maxtime.TabIndex = 72;
            this.group_maxtime.TabStop = false;
            this.group_maxtime.Text = "Max inventory time";
            // 
            // comboBox_maxtime
            // 
            this.comboBox_maxtime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_maxtime.FormattingEnabled = true;
            this.comboBox_maxtime.Location = new System.Drawing.Point(141, 25);
            this.comboBox_maxtime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_maxtime.Name = "comboBox_maxtime";
            this.comboBox_maxtime.Size = new System.Drawing.Size(181, 28);
            this.comboBox_maxtime.TabIndex = 26;
            // 
            // btSetMaxtime
            // 
            this.btSetMaxtime.Location = new System.Drawing.Point(350, 23);
            this.btSetMaxtime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSetMaxtime.Name = "btSetMaxtime";
            this.btSetMaxtime.Size = new System.Drawing.Size(135, 38);
            this.btSetMaxtime.TabIndex = 23;
            this.btSetMaxtime.Text = "Set";
            this.btSetMaxtime.UseVisualStyleBackColor = true;
            this.btSetMaxtime.Click += new System.EventHandler(this.btSetMaxtime_Click);
            // 
            // gbp_buff
            // 
            this.gbp_buff.Controls.Add(this.rb496);
            this.gbp_buff.Controls.Add(this.rb128);
            this.gbp_buff.Controls.Add(this.btGetEPCandTIDLen);
            this.gbp_buff.Controls.Add(this.btSetEPCandTIDLen);
            this.gbp_buff.Location = new System.Drawing.Point(8, 558);
            this.gbp_buff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbp_buff.Name = "gbp_buff";
            this.gbp_buff.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbp_buff.Size = new System.Drawing.Size(514, 92);
            this.gbp_buff.TabIndex = 71;
            this.gbp_buff.TabStop = false;
            this.gbp_buff.Text = "Saved EPC/TID length";
            // 
            // rb496
            // 
            this.rb496.AutoSize = true;
            this.rb496.Location = new System.Drawing.Point(140, 42);
            this.rb496.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb496.Name = "rb496";
            this.rb496.Size = new System.Drawing.Size(78, 24);
            this.rb496.TabIndex = 11;
            this.rb496.Text = "496bit";
            this.rb496.UseVisualStyleBackColor = true;
            // 
            // rb128
            // 
            this.rb128.AutoSize = true;
            this.rb128.Checked = true;
            this.rb128.Location = new System.Drawing.Point(22, 42);
            this.rb128.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb128.Name = "rb128";
            this.rb128.Size = new System.Drawing.Size(78, 24);
            this.rb128.TabIndex = 10;
            this.rb128.TabStop = true;
            this.rb128.Text = "128bit";
            this.rb128.UseVisualStyleBackColor = true;
            // 
            // btGetEPCandTIDLen
            // 
            this.btGetEPCandTIDLen.Location = new System.Drawing.Point(370, 37);
            this.btGetEPCandTIDLen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btGetEPCandTIDLen.Name = "btGetEPCandTIDLen";
            this.btGetEPCandTIDLen.Size = new System.Drawing.Size(116, 38);
            this.btGetEPCandTIDLen.TabIndex = 9;
            this.btGetEPCandTIDLen.Text = "Get";
            this.btGetEPCandTIDLen.UseVisualStyleBackColor = true;
            this.btGetEPCandTIDLen.Click += new System.EventHandler(this.btGetEPCandTIDLen_Click);
            // 
            // btSetEPCandTIDLen
            // 
            this.btSetEPCandTIDLen.Location = new System.Drawing.Point(237, 37);
            this.btSetEPCandTIDLen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSetEPCandTIDLen.Name = "btSetEPCandTIDLen";
            this.btSetEPCandTIDLen.Size = new System.Drawing.Size(116, 38);
            this.btSetEPCandTIDLen.TabIndex = 8;
            this.btSetEPCandTIDLen.Text = "Set";
            this.btSetEPCandTIDLen.UseVisualStyleBackColor = true;
            this.btSetEPCandTIDLen.Click += new System.EventHandler(this.btSetEPCandTIDLen_Click);
            // 
            // btGetInformation
            // 
            this.btGetInformation.Location = new System.Drawing.Point(1274, 642);
            this.btGetInformation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btGetInformation.Name = "btGetInformation";
            this.btGetInformation.Size = new System.Drawing.Size(294, 72);
            this.btGetInformation.TabIndex = 58;
            this.btGetInformation.Text = "Get reader information";
            this.btGetInformation.UseVisualStyleBackColor = true;
            this.btGetInformation.Click += new System.EventHandler(this.btGetInformation_Click);
            // 
            // btDefault
            // 
            this.btDefault.Location = new System.Drawing.Point(968, 642);
            this.btDefault.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btDefault.Name = "btDefault";
            this.btDefault.Size = new System.Drawing.Size(294, 72);
            this.btDefault.TabIndex = 57;
            this.btDefault.Text = "Default setting";
            this.btDefault.UseVisualStyleBackColor = true;
            this.btDefault.Click += new System.EventHandler(this.btDefault_Click);
            // 
            // btFlashROM
            // 
            this.btFlashROM.Location = new System.Drawing.Point(658, 642);
            this.btFlashROM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btFlashROM.Name = "btFlashROM";
            this.btFlashROM.Size = new System.Drawing.Size(294, 72);
            this.btFlashROM.TabIndex = 56;
            this.btFlashROM.Text = "Change to Flush mode";
            this.btFlashROM.UseVisualStyleBackColor = true;
            this.btFlashROM.Click += new System.EventHandler(this.btFlashROM_Click);
            // 
            // gpb_clock
            // 
            this.gpb_clock.Controls.Add(this.textBox1);
            this.gpb_clock.Controls.Add(this.Text_sec);
            this.gpb_clock.Controls.Add(this.Text_min);
            this.gpb_clock.Controls.Add(this.Text_hour);
            this.gpb_clock.Controls.Add(this.Text_day);
            this.gpb_clock.Controls.Add(this.Text_month);
            this.gpb_clock.Controls.Add(this.Text_year);
            this.gpb_clock.Controls.Add(this.ClockCMD);
            this.gpb_clock.Controls.Add(this.GetClock);
            this.gpb_clock.Controls.Add(this.SetClock);
            this.gpb_clock.Controls.Add(this.label11);
            this.gpb_clock.Controls.Add(this.label40);
            this.gpb_clock.Controls.Add(this.label41);
            this.gpb_clock.Controls.Add(this.label42);
            this.gpb_clock.Controls.Add(this.label45);
            this.gpb_clock.Controls.Add(this.label46);
            this.gpb_clock.Location = new System.Drawing.Point(1059, 463);
            this.gpb_clock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpb_clock.Name = "gpb_clock";
            this.gpb_clock.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpb_clock.Size = new System.Drawing.Size(513, 157);
            this.gpb_clock.TabIndex = 55;
            this.gpb_clock.TabStop = false;
            this.gpb_clock.Text = "Real time clock setting";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(4, 45);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.MaxLength = 2;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(67, 49);
            this.textBox1.TabIndex = 38;
            this.textBox1.Text = "20";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Text_sec
            // 
            this.Text_sec.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Text_sec.ForeColor = System.Drawing.Color.Crimson;
            this.Text_sec.Location = new System.Drawing.Point(435, 47);
            this.Text_sec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Text_sec.MaxLength = 2;
            this.Text_sec.Name = "Text_sec";
            this.Text_sec.Size = new System.Drawing.Size(67, 49);
            this.Text_sec.TabIndex = 37;
            this.Text_sec.Text = "00";
            this.Text_sec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Text_sec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // Text_min
            // 
            this.Text_min.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Text_min.ForeColor = System.Drawing.Color.Crimson;
            this.Text_min.Location = new System.Drawing.Point(363, 47);
            this.Text_min.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Text_min.MaxLength = 2;
            this.Text_min.Name = "Text_min";
            this.Text_min.Size = new System.Drawing.Size(67, 49);
            this.Text_min.TabIndex = 36;
            this.Text_min.Text = "00";
            this.Text_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Text_min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // Text_hour
            // 
            this.Text_hour.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Text_hour.ForeColor = System.Drawing.Color.Crimson;
            this.Text_hour.Location = new System.Drawing.Point(291, 47);
            this.Text_hour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Text_hour.MaxLength = 2;
            this.Text_hour.Name = "Text_hour";
            this.Text_hour.Size = new System.Drawing.Size(67, 49);
            this.Text_hour.TabIndex = 35;
            this.Text_hour.Text = "00";
            this.Text_hour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Text_hour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // Text_day
            // 
            this.Text_day.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Text_day.ForeColor = System.Drawing.Color.Crimson;
            this.Text_day.Location = new System.Drawing.Point(218, 45);
            this.Text_day.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Text_day.MaxLength = 2;
            this.Text_day.Name = "Text_day";
            this.Text_day.Size = new System.Drawing.Size(67, 49);
            this.Text_day.TabIndex = 34;
            this.Text_day.Text = "00";
            this.Text_day.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Text_day.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // Text_month
            // 
            this.Text_month.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Text_month.ForeColor = System.Drawing.Color.Crimson;
            this.Text_month.Location = new System.Drawing.Point(146, 45);
            this.Text_month.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Text_month.MaxLength = 2;
            this.Text_month.Name = "Text_month";
            this.Text_month.Size = new System.Drawing.Size(67, 49);
            this.Text_month.TabIndex = 33;
            this.Text_month.Text = "00";
            this.Text_month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Text_month.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // Text_year
            // 
            this.Text_year.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Text_year.ForeColor = System.Drawing.Color.Crimson;
            this.Text_year.Location = new System.Drawing.Point(74, 45);
            this.Text_year.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Text_year.MaxLength = 2;
            this.Text_year.Name = "Text_year";
            this.Text_year.Size = new System.Drawing.Size(67, 49);
            this.Text_year.TabIndex = 32;
            this.Text_year.Text = "00";
            this.Text_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Text_year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // ClockCMD
            // 
            this.ClockCMD.Location = new System.Drawing.Point(350, 108);
            this.ClockCMD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClockCMD.Name = "ClockCMD";
            this.ClockCMD.Size = new System.Drawing.Size(135, 47);
            this.ClockCMD.TabIndex = 15;
            this.ClockCMD.Text = "Go";
            this.ClockCMD.UseVisualStyleBackColor = true;
            this.ClockCMD.Click += new System.EventHandler(this.ClockCMD_Click);
            // 
            // GetClock
            // 
            this.GetClock.AutoSize = true;
            this.GetClock.Checked = true;
            this.GetClock.Location = new System.Drawing.Point(196, 120);
            this.GetClock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GetClock.Name = "GetClock";
            this.GetClock.Size = new System.Drawing.Size(76, 24);
            this.GetClock.TabIndex = 14;
            this.GetClock.TabStop = true;
            this.GetClock.Text = "Query";
            this.GetClock.UseVisualStyleBackColor = true;
            // 
            // SetClock
            // 
            this.SetClock.AutoSize = true;
            this.SetClock.Location = new System.Drawing.Point(26, 120);
            this.SetClock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SetClock.Name = "SetClock";
            this.SetClock.Size = new System.Drawing.Size(85, 24);
            this.SetClock.TabIndex = 13;
            this.SetClock.Text = "Setting";
            this.SetClock.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(447, 22);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Sec";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(380, 22);
            this.label40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(34, 20);
            this.label40.TabIndex = 11;
            this.label40.Text = "Min";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(304, 22);
            this.label41.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(44, 20);
            this.label41.TabIndex = 10;
            this.label41.Text = "Hour";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(236, 23);
            this.label42.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(37, 20);
            this.label42.TabIndex = 9;
            this.label42.Text = "Day";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(158, 23);
            this.label45.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(54, 20);
            this.label45.TabIndex = 8;
            this.label45.Text = "Month";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(93, 23);
            this.label46.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(43, 20);
            this.label46.TabIndex = 2;
            this.label46.Text = "Year";
            // 
            // gpb_antconfig
            // 
            this.gpb_antconfig.Controls.Add(this.Button_Ant);
            this.gpb_antconfig.Controls.Add(this.checkant4);
            this.gpb_antconfig.Controls.Add(this.checkant3);
            this.gpb_antconfig.Controls.Add(this.checkant2);
            this.gpb_antconfig.Controls.Add(this.checkant1);
            this.gpb_antconfig.Location = new System.Drawing.Point(531, 552);
            this.gpb_antconfig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpb_antconfig.Name = "gpb_antconfig";
            this.gpb_antconfig.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpb_antconfig.Size = new System.Drawing.Size(513, 70);
            this.gpb_antconfig.TabIndex = 54;
            this.gpb_antconfig.TabStop = false;
            this.gpb_antconfig.Text = "Antenna config";
            // 
            // Button_Ant
            // 
            this.Button_Ant.Location = new System.Drawing.Point(350, 20);
            this.Button_Ant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_Ant.Name = "Button_Ant";
            this.Button_Ant.Size = new System.Drawing.Size(135, 38);
            this.Button_Ant.TabIndex = 5;
            this.Button_Ant.Text = "Set";
            this.Button_Ant.UseVisualStyleBackColor = true;
            this.Button_Ant.Click += new System.EventHandler(this.Button_Ant_Click);
            // 
            // checkant4
            // 
            this.checkant4.AutoSize = true;
            this.checkant4.Location = new System.Drawing.Point(266, 25);
            this.checkant4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkant4.Name = "checkant4";
            this.checkant4.Size = new System.Drawing.Size(75, 24);
            this.checkant4.TabIndex = 4;
            this.checkant4.Text = "ANT4";
            this.checkant4.UseVisualStyleBackColor = true;
            // 
            // checkant3
            // 
            this.checkant3.AutoSize = true;
            this.checkant3.Location = new System.Drawing.Point(180, 25);
            this.checkant3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkant3.Name = "checkant3";
            this.checkant3.Size = new System.Drawing.Size(75, 24);
            this.checkant3.TabIndex = 3;
            this.checkant3.Text = "ANT3";
            this.checkant3.UseVisualStyleBackColor = true;
            // 
            // checkant2
            // 
            this.checkant2.AutoSize = true;
            this.checkant2.Location = new System.Drawing.Point(93, 25);
            this.checkant2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkant2.Name = "checkant2";
            this.checkant2.Size = new System.Drawing.Size(75, 24);
            this.checkant2.TabIndex = 2;
            this.checkant2.Text = "ANT2";
            this.checkant2.UseVisualStyleBackColor = true;
            // 
            // checkant1
            // 
            this.checkant1.AutoSize = true;
            this.checkant1.Location = new System.Drawing.Point(12, 25);
            this.checkant1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkant1.Name = "checkant1";
            this.checkant1.Size = new System.Drawing.Size(75, 24);
            this.checkant1.TabIndex = 1;
            this.checkant1.Text = "ANT1";
            this.checkant1.UseVisualStyleBackColor = true;
            // 
            // gpb_checkant
            // 
            this.gpb_checkant.Controls.Add(this.btSetcheckant);
            this.gpb_checkant.Controls.Add(this.rb_Closecheckant);
            this.gpb_checkant.Controls.Add(this.rb_Opencheckant);
            this.gpb_checkant.Location = new System.Drawing.Point(531, 463);
            this.gpb_checkant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpb_checkant.Name = "gpb_checkant";
            this.gpb_checkant.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpb_checkant.Size = new System.Drawing.Size(513, 85);
            this.gpb_checkant.TabIndex = 53;
            this.gpb_checkant.TabStop = false;
            this.gpb_checkant.Text = "Antenna checked";
            // 
            // btSetcheckant
            // 
            this.btSetcheckant.Location = new System.Drawing.Point(350, 32);
            this.btSetcheckant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSetcheckant.Name = "btSetcheckant";
            this.btSetcheckant.Size = new System.Drawing.Size(135, 38);
            this.btSetcheckant.TabIndex = 2;
            this.btSetcheckant.Text = "Set";
            this.btSetcheckant.UseVisualStyleBackColor = true;
            this.btSetcheckant.Click += new System.EventHandler(this.btSetcheckant_Click);
            // 
            // rb_Closecheckant
            // 
            this.rb_Closecheckant.AutoSize = true;
            this.rb_Closecheckant.Location = new System.Drawing.Point(10, 53);
            this.rb_Closecheckant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_Closecheckant.Name = "rb_Closecheckant";
            this.rb_Closecheckant.Size = new System.Drawing.Size(220, 24);
            this.rb_Closecheckant.TabIndex = 1;
            this.rb_Closecheckant.Text = "Disable antenna detection";
            this.rb_Closecheckant.UseVisualStyleBackColor = true;
            // 
            // rb_Opencheckant
            // 
            this.rb_Opencheckant.AutoSize = true;
            this.rb_Opencheckant.Checked = true;
            this.rb_Opencheckant.Location = new System.Drawing.Point(10, 23);
            this.rb_Opencheckant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_Opencheckant.Name = "rb_Opencheckant";
            this.rb_Opencheckant.Size = new System.Drawing.Size(217, 24);
            this.rb_Opencheckant.TabIndex = 0;
            this.rb_Opencheckant.TabStop = true;
            this.rb_Opencheckant.Text = "Enable antenna detection";
            this.rb_Opencheckant.UseVisualStyleBackColor = true;
            // 
            // gpb_GPIO
            // 
            this.gpb_GPIO.Controls.Add(this.Button_GetGPIO);
            this.gpb_GPIO.Controls.Add(this.Button_SetGPIO);
            this.gpb_GPIO.Controls.Add(this.check_int4);
            this.gpb_GPIO.Controls.Add(this.check_int3);
            this.gpb_GPIO.Controls.Add(this.check_int2);
            this.gpb_GPIO.Controls.Add(this.check_int1);
            this.gpb_GPIO.Controls.Add(this.check_out4);
            this.gpb_GPIO.Controls.Add(this.check_out3);
            this.gpb_GPIO.Controls.Add(this.check_out2);
            this.gpb_GPIO.Controls.Add(this.check_out1);
            this.gpb_GPIO.Location = new System.Drawing.Point(531, 388);
            this.gpb_GPIO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpb_GPIO.Name = "gpb_GPIO";
            this.gpb_GPIO.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpb_GPIO.Size = new System.Drawing.Size(1040, 72);
            this.gpb_GPIO.TabIndex = 49;
            this.gpb_GPIO.TabStop = false;
            this.gpb_GPIO.Text = "GPIO Operation";
            // 
            // Button_GetGPIO
            // 
            this.Button_GetGPIO.Location = new System.Drawing.Point(878, 23);
            this.Button_GetGPIO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_GetGPIO.Name = "Button_GetGPIO";
            this.Button_GetGPIO.Size = new System.Drawing.Size(135, 38);
            this.Button_GetGPIO.TabIndex = 9;
            this.Button_GetGPIO.Text = "Get";
            this.Button_GetGPIO.UseVisualStyleBackColor = true;
            this.Button_GetGPIO.Click += new System.EventHandler(this.Button_GetGPIO_Click);
            // 
            // Button_SetGPIO
            // 
            this.Button_SetGPIO.Location = new System.Drawing.Point(724, 23);
            this.Button_SetGPIO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_SetGPIO.Name = "Button_SetGPIO";
            this.Button_SetGPIO.Size = new System.Drawing.Size(135, 38);
            this.Button_SetGPIO.TabIndex = 8;
            this.Button_SetGPIO.Text = "Set";
            this.Button_SetGPIO.UseVisualStyleBackColor = true;
            this.Button_SetGPIO.Click += new System.EventHandler(this.Button_SetGPIO_Click);
            // 
            // check_int4
            // 
            this.check_int4.AutoSize = true;
            this.check_int4.Enabled = false;
            this.check_int4.Location = new System.Drawing.Point(588, 30);
            this.check_int4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.check_int4.Name = "check_int4";
            this.check_int4.Size = new System.Drawing.Size(69, 24);
            this.check_int4.TabIndex = 7;
            this.check_int4.Text = "INT4";
            this.check_int4.UseVisualStyleBackColor = true;
            // 
            // check_int3
            // 
            this.check_int3.AutoSize = true;
            this.check_int3.Enabled = false;
            this.check_int3.Location = new System.Drawing.Point(507, 30);
            this.check_int3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.check_int3.Name = "check_int3";
            this.check_int3.Size = new System.Drawing.Size(69, 24);
            this.check_int3.TabIndex = 6;
            this.check_int3.Text = "INT3";
            this.check_int3.UseVisualStyleBackColor = true;
            // 
            // check_int2
            // 
            this.check_int2.AutoSize = true;
            this.check_int2.Enabled = false;
            this.check_int2.Location = new System.Drawing.Point(422, 30);
            this.check_int2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.check_int2.Name = "check_int2";
            this.check_int2.Size = new System.Drawing.Size(69, 24);
            this.check_int2.TabIndex = 5;
            this.check_int2.Text = "INT2";
            this.check_int2.UseVisualStyleBackColor = true;
            // 
            // check_int1
            // 
            this.check_int1.AutoSize = true;
            this.check_int1.Enabled = false;
            this.check_int1.Location = new System.Drawing.Point(340, 30);
            this.check_int1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.check_int1.Name = "check_int1";
            this.check_int1.Size = new System.Drawing.Size(69, 24);
            this.check_int1.TabIndex = 4;
            this.check_int1.Text = "INT1";
            this.check_int1.UseVisualStyleBackColor = true;
            // 
            // check_out4
            // 
            this.check_out4.AutoSize = true;
            this.check_out4.Location = new System.Drawing.Point(255, 30);
            this.check_out4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.check_out4.Name = "check_out4";
            this.check_out4.Size = new System.Drawing.Size(77, 24);
            this.check_out4.TabIndex = 3;
            this.check_out4.Text = "OUT4";
            this.check_out4.UseVisualStyleBackColor = true;
            // 
            // check_out3
            // 
            this.check_out3.AutoSize = true;
            this.check_out3.Location = new System.Drawing.Point(174, 30);
            this.check_out3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.check_out3.Name = "check_out3";
            this.check_out3.Size = new System.Drawing.Size(77, 24);
            this.check_out3.TabIndex = 2;
            this.check_out3.Text = "OUT3";
            this.check_out3.UseVisualStyleBackColor = true;
            // 
            // check_out2
            // 
            this.check_out2.AutoSize = true;
            this.check_out2.Location = new System.Drawing.Point(93, 30);
            this.check_out2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.check_out2.Name = "check_out2";
            this.check_out2.Size = new System.Drawing.Size(77, 24);
            this.check_out2.TabIndex = 1;
            this.check_out2.Text = "OUT2";
            this.check_out2.UseVisualStyleBackColor = true;
            // 
            // check_out1
            // 
            this.check_out1.AutoSize = true;
            this.check_out1.Location = new System.Drawing.Point(12, 30);
            this.check_out1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.check_out1.Name = "check_out1";
            this.check_out1.Size = new System.Drawing.Size(77, 24);
            this.check_out1.TabIndex = 0;
            this.check_out1.Text = "OUT1";
            this.check_out1.UseVisualStyleBackColor = true;
            // 
            // gpb_OutputRep
            // 
            this.gpb_OutputRep.Controls.Add(this.btOutputRep);
            this.gpb_OutputRep.Controls.Add(this.check_OutputRep4);
            this.gpb_OutputRep.Controls.Add(this.check_OutputRep3);
            this.gpb_OutputRep.Controls.Add(this.check_OutputRep2);
            this.gpb_OutputRep.Controls.Add(this.check_OutputRep1);
            this.gpb_OutputRep.Location = new System.Drawing.Point(1058, 315);
            this.gpb_OutputRep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpb_OutputRep.Name = "gpb_OutputRep";
            this.gpb_OutputRep.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpb_OutputRep.Size = new System.Drawing.Size(513, 70);
            this.gpb_OutputRep.TabIndex = 48;
            this.gpb_OutputRep.TabStop = false;
            this.gpb_OutputRep.Text = "Set notification pluse output";
            // 
            // btOutputRep
            // 
            this.btOutputRep.Location = new System.Drawing.Point(351, 22);
            this.btOutputRep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btOutputRep.Name = "btOutputRep";
            this.btOutputRep.Size = new System.Drawing.Size(135, 38);
            this.btOutputRep.TabIndex = 5;
            this.btOutputRep.Text = "Set";
            this.btOutputRep.UseVisualStyleBackColor = true;
            this.btOutputRep.Click += new System.EventHandler(this.btOutputRep_Click);
            // 
            // check_OutputRep4
            // 
            this.check_OutputRep4.AutoSize = true;
            this.check_OutputRep4.Location = new System.Drawing.Point(276, 27);
            this.check_OutputRep4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.check_OutputRep4.Name = "check_OutputRep4";
            this.check_OutputRep4.Size = new System.Drawing.Size(77, 24);
            this.check_OutputRep4.TabIndex = 4;
            this.check_OutputRep4.Text = "OUT4";
            this.check_OutputRep4.UseVisualStyleBackColor = true;
            // 
            // check_OutputRep3
            // 
            this.check_OutputRep3.AutoSize = true;
            this.check_OutputRep3.Location = new System.Drawing.Point(188, 27);
            this.check_OutputRep3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.check_OutputRep3.Name = "check_OutputRep3";
            this.check_OutputRep3.Size = new System.Drawing.Size(77, 24);
            this.check_OutputRep3.TabIndex = 3;
            this.check_OutputRep3.Text = "OUT3";
            this.check_OutputRep3.UseVisualStyleBackColor = true;
            // 
            // check_OutputRep2
            // 
            this.check_OutputRep2.AutoSize = true;
            this.check_OutputRep2.Location = new System.Drawing.Point(99, 27);
            this.check_OutputRep2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.check_OutputRep2.Name = "check_OutputRep2";
            this.check_OutputRep2.Size = new System.Drawing.Size(77, 24);
            this.check_OutputRep2.TabIndex = 2;
            this.check_OutputRep2.Text = "OUT2";
            this.check_OutputRep2.UseVisualStyleBackColor = true;
            // 
            // check_OutputRep1
            // 
            this.check_OutputRep1.AutoSize = true;
            this.check_OutputRep1.Location = new System.Drawing.Point(12, 27);
            this.check_OutputRep1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.check_OutputRep1.Name = "check_OutputRep1";
            this.check_OutputRep1.Size = new System.Drawing.Size(77, 24);
            this.check_OutputRep1.TabIndex = 1;
            this.check_OutputRep1.Text = "OUT1";
            this.check_OutputRep1.UseVisualStyleBackColor = true;
            // 
            // gpb_Relay
            // 
            this.gpb_Relay.Controls.Add(this.label38);
            this.gpb_Relay.Controls.Add(this.ComboBox_RelayTime);
            this.gpb_Relay.Controls.Add(this.label37);
            this.gpb_Relay.Controls.Add(this.btRelay);
            this.gpb_Relay.Location = new System.Drawing.Point(531, 315);
            this.gpb_Relay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpb_Relay.Name = "gpb_Relay";
            this.gpb_Relay.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpb_Relay.Size = new System.Drawing.Size(513, 70);
            this.gpb_Relay.TabIndex = 31;
            this.gpb_Relay.TabStop = false;
            this.gpb_Relay.Text = "Relay control";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(273, 30);
            this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(54, 20);
            this.label38.TabIndex = 26;
            this.label38.Text = "*50ms";
            // 
            // ComboBox_RelayTime
            // 
            this.ComboBox_RelayTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_RelayTime.FormattingEnabled = true;
            this.ComboBox_RelayTime.Location = new System.Drawing.Point(160, 25);
            this.ComboBox_RelayTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBox_RelayTime.Name = "ComboBox_RelayTime";
            this.ComboBox_RelayTime.Size = new System.Drawing.Size(102, 28);
            this.ComboBox_RelayTime.TabIndex = 25;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(26, 32);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(106, 20);
            this.label37.TabIndex = 24;
            this.label37.Text = "Release time:";
            // 
            // btRelay
            // 
            this.btRelay.Location = new System.Drawing.Point(350, 22);
            this.btRelay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRelay.Name = "btRelay";
            this.btRelay.Size = new System.Drawing.Size(135, 38);
            this.btRelay.TabIndex = 23;
            this.btRelay.Text = "Set";
            this.btRelay.UseVisualStyleBackColor = true;
            this.btRelay.Click += new System.EventHandler(this.btRelay_Click);
            // 
            // gpb_baud
            // 
            this.gpb_baud.Controls.Add(this.ComboBox_baud);
            this.gpb_baud.Controls.Add(this.btBaudRate);
            this.gpb_baud.Location = new System.Drawing.Point(1059, 205);
            this.gpb_baud.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpb_baud.Name = "gpb_baud";
            this.gpb_baud.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpb_baud.Size = new System.Drawing.Size(513, 100);
            this.gpb_baud.TabIndex = 30;
            this.gpb_baud.TabStop = false;
            this.gpb_baud.Text = "RS232/485 baud rate";
            // 
            // ComboBox_baud
            // 
            this.ComboBox_baud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_baud.FormattingEnabled = true;
            this.ComboBox_baud.Items.AddRange(new object[] {
            "9600bps",
            "19200bps",
            "38400bps",
            "57600bps",
            "115200bps"});
            this.ComboBox_baud.Location = new System.Drawing.Point(104, 42);
            this.ComboBox_baud.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBox_baud.Name = "ComboBox_baud";
            this.ComboBox_baud.Size = new System.Drawing.Size(180, 28);
            this.ComboBox_baud.TabIndex = 24;
            // 
            // btBaudRate
            // 
            this.btBaudRate.Location = new System.Drawing.Point(350, 37);
            this.btBaudRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btBaudRate.Name = "btBaudRate";
            this.btBaudRate.Size = new System.Drawing.Size(135, 38);
            this.btBaudRate.TabIndex = 23;
            this.btBaudRate.Text = "Set";
            this.btBaudRate.UseVisualStyleBackColor = true;
            this.btBaudRate.Click += new System.EventHandler(this.btBaudRate_Click);
            // 
            // gpb_DBM
            // 
            this.gpb_DBM.Controls.Add(this.label10);
            this.gpb_DBM.Controls.Add(this.ComboBox_PowerDbm);
            this.gpb_DBM.Controls.Add(this.BT_DBM);
            this.gpb_DBM.Location = new System.Drawing.Point(531, 205);
            this.gpb_DBM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpb_DBM.Name = "gpb_DBM";
            this.gpb_DBM.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpb_DBM.Size = new System.Drawing.Size(513, 103);
            this.gpb_DBM.TabIndex = 29;
            this.gpb_DBM.TabStop = false;
            this.gpb_DBM.Text = "Power";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(236, 43);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "dBm";
            // 
            // ComboBox_PowerDbm
            // 
            this.ComboBox_PowerDbm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_PowerDbm.FormattingEnabled = true;
            this.ComboBox_PowerDbm.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.ComboBox_PowerDbm.Location = new System.Drawing.Point(76, 38);
            this.ComboBox_PowerDbm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBox_PowerDbm.Name = "ComboBox_PowerDbm";
            this.ComboBox_PowerDbm.Size = new System.Drawing.Size(148, 28);
            this.ComboBox_PowerDbm.TabIndex = 24;
            // 
            // BT_DBM
            // 
            this.BT_DBM.Location = new System.Drawing.Point(350, 38);
            this.BT_DBM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BT_DBM.Name = "BT_DBM";
            this.BT_DBM.Size = new System.Drawing.Size(135, 38);
            this.BT_DBM.TabIndex = 23;
            this.BT_DBM.Text = "Set";
            this.BT_DBM.UseVisualStyleBackColor = true;
            this.BT_DBM.Click += new System.EventHandler(this.BT_DBM_Click);
            // 
            // gpb_Freq
            // 
            this.gpb_Freq.Controls.Add(this.radioButton_band8);
            this.gpb_Freq.Controls.Add(this.CheckBox_SameFre);
            this.gpb_Freq.Controls.Add(this.radioButton_band4);
            this.gpb_Freq.Controls.Add(this.radioButton_band3);
            this.gpb_Freq.Controls.Add(this.radioButton_band2);
            this.gpb_Freq.Controls.Add(this.radioButton_band1);
            this.gpb_Freq.Controls.Add(this.btFreq);
            this.gpb_Freq.Controls.Add(this.ComboBox_dmaxfre);
            this.gpb_Freq.Controls.Add(this.label15);
            this.gpb_Freq.Controls.Add(this.ComboBox_dminfre);
            this.gpb_Freq.Controls.Add(this.label14);
            this.gpb_Freq.Location = new System.Drawing.Point(531, 85);
            this.gpb_Freq.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpb_Freq.Name = "gpb_Freq";
            this.gpb_Freq.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpb_Freq.Size = new System.Drawing.Size(1042, 117);
            this.gpb_Freq.TabIndex = 28;
            this.gpb_Freq.TabStop = false;
            this.gpb_Freq.Text = "Region";
            // 
            // radioButton_band8
            // 
            this.radioButton_band8.AutoSize = true;
            this.radioButton_band8.Location = new System.Drawing.Point(45, 28);
            this.radioButton_band8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_band8.Name = "radioButton_band8";
            this.radioButton_band8.Size = new System.Drawing.Size(141, 24);
            this.radioButton_band8.TabIndex = 17;
            this.radioButton_band8.TabStop = true;
            this.radioButton_band8.Text = "Chinese band1";
            this.radioButton_band8.UseVisualStyleBackColor = true;
            this.radioButton_band8.CheckedChanged += new System.EventHandler(this.radioButton_band8_CheckedChanged);
            // 
            // CheckBox_SameFre
            // 
            this.CheckBox_SameFre.AutoSize = true;
            this.CheckBox_SameFre.Location = new System.Drawing.Point(878, 27);
            this.CheckBox_SameFre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CheckBox_SameFre.Name = "CheckBox_SameFre";
            this.CheckBox_SameFre.Size = new System.Drawing.Size(79, 24);
            this.CheckBox_SameFre.TabIndex = 16;
            this.CheckBox_SameFre.Text = "Single";
            this.CheckBox_SameFre.UseVisualStyleBackColor = true;
            this.CheckBox_SameFre.CheckedChanged += new System.EventHandler(this.CheckBox_SameFre_CheckedChanged);
            // 
            // radioButton_band4
            // 
            this.radioButton_band4.AutoSize = true;
            this.radioButton_band4.Location = new System.Drawing.Point(350, 73);
            this.radioButton_band4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_band4.Name = "radioButton_band4";
            this.radioButton_band4.Size = new System.Drawing.Size(97, 24);
            this.radioButton_band4.TabIndex = 15;
            this.radioButton_band4.TabStop = true;
            this.radioButton_band4.Text = "EU band";
            this.radioButton_band4.UseVisualStyleBackColor = true;
            this.radioButton_band4.CheckedChanged += new System.EventHandler(this.radioButton_band4_CheckedChanged);
            // 
            // radioButton_band3
            // 
            this.radioButton_band3.AutoSize = true;
            this.radioButton_band3.Location = new System.Drawing.Point(192, 73);
            this.radioButton_band3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_band3.Name = "radioButton_band3";
            this.radioButton_band3.Size = new System.Drawing.Size(125, 24);
            this.radioButton_band3.TabIndex = 14;
            this.radioButton_band3.TabStop = true;
            this.radioButton_band3.Text = "Korean band";
            this.radioButton_band3.UseVisualStyleBackColor = true;
            this.radioButton_band3.CheckedChanged += new System.EventHandler(this.radioButton_band3_CheckedChanged);
            // 
            // radioButton_band2
            // 
            this.radioButton_band2.AutoSize = true;
            this.radioButton_band2.Location = new System.Drawing.Point(45, 70);
            this.radioButton_band2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_band2.Name = "radioButton_band2";
            this.radioButton_band2.Size = new System.Drawing.Size(97, 24);
            this.radioButton_band2.TabIndex = 13;
            this.radioButton_band2.TabStop = true;
            this.radioButton_band2.Text = "US band";
            this.radioButton_band2.UseVisualStyleBackColor = true;
            this.radioButton_band2.CheckedChanged += new System.EventHandler(this.radioButton_band2_CheckedChanged);
            // 
            // radioButton_band1
            // 
            this.radioButton_band1.AutoSize = true;
            this.radioButton_band1.Location = new System.Drawing.Point(231, 28);
            this.radioButton_band1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_band1.Name = "radioButton_band1";
            this.radioButton_band1.Size = new System.Drawing.Size(141, 24);
            this.radioButton_band1.TabIndex = 12;
            this.radioButton_band1.TabStop = true;
            this.radioButton_band1.Text = "Chinese band2";
            this.radioButton_band1.UseVisualStyleBackColor = true;
            this.radioButton_band1.CheckedChanged += new System.EventHandler(this.radioButton_band1_CheckedChanged);
            // 
            // btFreq
            // 
            this.btFreq.Location = new System.Drawing.Point(878, 62);
            this.btFreq.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btFreq.Name = "btFreq";
            this.btFreq.Size = new System.Drawing.Size(135, 38);
            this.btFreq.TabIndex = 11;
            this.btFreq.Text = "Set";
            this.btFreq.UseVisualStyleBackColor = true;
            this.btFreq.Click += new System.EventHandler(this.btFreq_Click);
            // 
            // ComboBox_dmaxfre
            // 
            this.ComboBox_dmaxfre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_dmaxfre.FormattingEnabled = true;
            this.ComboBox_dmaxfre.Location = new System.Drawing.Point(632, 70);
            this.ComboBox_dmaxfre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBox_dmaxfre.Name = "ComboBox_dmaxfre";
            this.ComboBox_dmaxfre.Size = new System.Drawing.Size(148, 28);
            this.ComboBox_dmaxfre.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(498, 77);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 20);
            this.label15.TabIndex = 9;
            this.label15.Text = "Maxfre:";
            // 
            // ComboBox_dminfre
            // 
            this.ComboBox_dminfre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_dminfre.FormattingEnabled = true;
            this.ComboBox_dminfre.Location = new System.Drawing.Point(632, 22);
            this.ComboBox_dminfre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBox_dminfre.Name = "ComboBox_dminfre";
            this.ComboBox_dminfre.Size = new System.Drawing.Size(148, 28);
            this.ComboBox_dminfre.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(498, 28);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 20);
            this.label14.TabIndex = 7;
            this.label14.Text = "Minfre:";
            // 
            // gpb_beep
            // 
            this.gpb_beep.Controls.Add(this.Radio_beepDis);
            this.gpb_beep.Controls.Add(this.Radio_beepEn);
            this.gpb_beep.Controls.Add(this.Button_Beep);
            this.gpb_beep.Location = new System.Drawing.Point(1060, 8);
            this.gpb_beep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpb_beep.Name = "gpb_beep";
            this.gpb_beep.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpb_beep.Size = new System.Drawing.Size(513, 73);
            this.gpb_beep.TabIndex = 27;
            this.gpb_beep.TabStop = false;
            this.gpb_beep.Text = "Beep";
            // 
            // Radio_beepDis
            // 
            this.Radio_beepDis.AutoSize = true;
            this.Radio_beepDis.Checked = true;
            this.Radio_beepDis.Location = new System.Drawing.Point(184, 30);
            this.Radio_beepDis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Radio_beepDis.Name = "Radio_beepDis";
            this.Radio_beepDis.Size = new System.Drawing.Size(74, 24);
            this.Radio_beepDis.TabIndex = 10;
            this.Radio_beepDis.TabStop = true;
            this.Radio_beepDis.Text = "Close";
            this.Radio_beepDis.UseVisualStyleBackColor = true;
            // 
            // Radio_beepEn
            // 
            this.Radio_beepEn.AutoSize = true;
            this.Radio_beepEn.Location = new System.Drawing.Point(50, 30);
            this.Radio_beepEn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Radio_beepEn.Name = "Radio_beepEn";
            this.Radio_beepEn.Size = new System.Drawing.Size(73, 24);
            this.Radio_beepEn.TabIndex = 9;
            this.Radio_beepEn.Text = "Open";
            this.Radio_beepEn.UseVisualStyleBackColor = true;
            // 
            // Button_Beep
            // 
            this.Button_Beep.Location = new System.Drawing.Point(348, 23);
            this.Button_Beep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_Beep.Name = "Button_Beep";
            this.Button_Beep.Size = new System.Drawing.Size(135, 38);
            this.Button_Beep.TabIndex = 8;
            this.Button_Beep.Text = "Set";
            this.Button_Beep.UseVisualStyleBackColor = true;
            this.Button_Beep.Click += new System.EventHandler(this.Button_Beep_Click);
            // 
            // gpb_RDVersion
            // 
            this.gpb_RDVersion.Controls.Add(this.text_RDVersion);
            this.gpb_RDVersion.Location = new System.Drawing.Point(531, 8);
            this.gpb_RDVersion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpb_RDVersion.Name = "gpb_RDVersion";
            this.gpb_RDVersion.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpb_RDVersion.Size = new System.Drawing.Size(513, 73);
            this.gpb_RDVersion.TabIndex = 26;
            this.gpb_RDVersion.TabStop = false;
            this.gpb_RDVersion.Text = "Firmware version";
            // 
            // text_RDVersion
            // 
            this.text_RDVersion.Location = new System.Drawing.Point(142, 25);
            this.text_RDVersion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_RDVersion.MaxLength = 2;
            this.text_RDVersion.Name = "text_RDVersion";
            this.text_RDVersion.ReadOnly = true;
            this.text_RDVersion.Size = new System.Drawing.Size(238, 26);
            this.text_RDVersion.TabIndex = 24;
            // 
            // gpb_MDVersion
            // 
            this.gpb_MDVersion.Controls.Add(this.text_MDVersion);
            this.gpb_MDVersion.Controls.Add(this.btMDVersion);
            this.gpb_MDVersion.Location = new System.Drawing.Point(9, 657);
            this.gpb_MDVersion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpb_MDVersion.Name = "gpb_MDVersion";
            this.gpb_MDVersion.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpb_MDVersion.Size = new System.Drawing.Size(513, 68);
            this.gpb_MDVersion.TabIndex = 25;
            this.gpb_MDVersion.TabStop = false;
            this.gpb_MDVersion.Text = "Module version";
            // 
            // text_MDVersion
            // 
            this.text_MDVersion.Location = new System.Drawing.Point(142, 22);
            this.text_MDVersion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_MDVersion.MaxLength = 2;
            this.text_MDVersion.Name = "text_MDVersion";
            this.text_MDVersion.ReadOnly = true;
            this.text_MDVersion.Size = new System.Drawing.Size(180, 26);
            this.text_MDVersion.TabIndex = 24;
            // 
            // btMDVersion
            // 
            this.btMDVersion.Location = new System.Drawing.Point(350, 22);
            this.btMDVersion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btMDVersion.Name = "btMDVersion";
            this.btMDVersion.Size = new System.Drawing.Size(135, 38);
            this.btMDVersion.TabIndex = 23;
            this.btMDVersion.Text = "Get";
            this.btMDVersion.UseVisualStyleBackColor = true;
            this.btMDVersion.Click += new System.EventHandler(this.btMDVersion_Click);
            // 
            // gpb_Serial
            // 
            this.gpb_Serial.Controls.Add(this.text_Serial);
            this.gpb_Serial.Controls.Add(this.btSerial);
            this.gpb_Serial.Location = new System.Drawing.Point(9, 405);
            this.gpb_Serial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpb_Serial.Name = "gpb_Serial";
            this.gpb_Serial.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpb_Serial.Size = new System.Drawing.Size(513, 72);
            this.gpb_Serial.TabIndex = 6;
            this.gpb_Serial.TabStop = false;
            this.gpb_Serial.Text = "Reader serial number\n";
            // 
            // text_Serial
            // 
            this.text_Serial.Location = new System.Drawing.Point(142, 22);
            this.text_Serial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_Serial.MaxLength = 8;
            this.text_Serial.Name = "text_Serial";
            this.text_Serial.ReadOnly = true;
            this.text_Serial.Size = new System.Drawing.Size(180, 26);
            this.text_Serial.TabIndex = 24;
            // 
            // btSerial
            // 
            this.btSerial.Location = new System.Drawing.Point(350, 22);
            this.btSerial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSerial.Name = "btSerial";
            this.btSerial.Size = new System.Drawing.Size(135, 38);
            this.btSerial.TabIndex = 23;
            this.btSerial.Text = "Get";
            this.btSerial.UseVisualStyleBackColor = true;
            this.btSerial.Click += new System.EventHandler(this.btSerial_Click);
            // 
            // gpb_address
            // 
            this.gpb_address.Controls.Add(this.text_address);
            this.gpb_address.Controls.Add(this.btaddress);
            this.gpb_address.Location = new System.Drawing.Point(9, 327);
            this.gpb_address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpb_address.Name = "gpb_address";
            this.gpb_address.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpb_address.Size = new System.Drawing.Size(513, 75);
            this.gpb_address.TabIndex = 5;
            this.gpb_address.TabStop = false;
            this.gpb_address.Text = "Reader address";
            // 
            // text_address
            // 
            this.text_address.Location = new System.Drawing.Point(142, 23);
            this.text_address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_address.MaxLength = 2;
            this.text_address.Name = "text_address";
            this.text_address.Size = new System.Drawing.Size(180, 26);
            this.text_address.TabIndex = 24;
            this.text_address.Text = "00";
            this.text_address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // btaddress
            // 
            this.btaddress.Location = new System.Drawing.Point(350, 23);
            this.btaddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btaddress.Name = "btaddress";
            this.btaddress.Size = new System.Drawing.Size(135, 38);
            this.btaddress.TabIndex = 23;
            this.btaddress.Text = "Set";
            this.btaddress.UseVisualStyleBackColor = true;
            this.btaddress.Click += new System.EventHandler(this.btaddress_Click);
            // 
            // gpb_tcp
            // 
            this.gpb_tcp.Controls.Add(this.tb_Port);
            this.gpb_tcp.Controls.Add(this.ipServerIP);
            this.gpb_tcp.Controls.Add(this.btDisConnectTcp);
            this.gpb_tcp.Controls.Add(this.btConnectTcp);
            this.gpb_tcp.Controls.Add(this.label2);
            this.gpb_tcp.Controls.Add(this.label4);
            this.gpb_tcp.Location = new System.Drawing.Point(8, 205);
            this.gpb_tcp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpb_tcp.Name = "gpb_tcp";
            this.gpb_tcp.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpb_tcp.Size = new System.Drawing.Size(514, 118);
            this.gpb_tcp.TabIndex = 4;
            this.gpb_tcp.TabStop = false;
            this.gpb_tcp.Text = "TCP/IP";
            // 
            // tb_Port
            // 
            this.tb_Port.Location = new System.Drawing.Point(144, 67);
            this.tb_Port.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Port.Name = "tb_Port";
            this.tb_Port.Size = new System.Drawing.Size(180, 26);
            this.tb_Port.TabIndex = 22;
            this.tb_Port.Text = "27011";
            this.tb_Port.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // ipServerIP
            // 
            this.ipServerIP.IpAddressStr = "192.168.0.250";
            this.ipServerIP.Location = new System.Drawing.Point(144, 25);
            this.ipServerIP.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.ipServerIP.Name = "ipServerIP";
            this.ipServerIP.Size = new System.Drawing.Size(182, 35);
            this.ipServerIP.TabIndex = 21;
            this.ipServerIP.Tag = "";
            this.ipServerIP.Load += new System.EventHandler(this.ipServerIP_Load);
            // 
            // btDisConnectTcp
            // 
            this.btDisConnectTcp.Enabled = false;
            this.btDisConnectTcp.Location = new System.Drawing.Point(351, 67);
            this.btDisConnectTcp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btDisConnectTcp.Name = "btDisConnectTcp";
            this.btDisConnectTcp.Size = new System.Drawing.Size(135, 38);
            this.btDisConnectTcp.TabIndex = 20;
            this.btDisConnectTcp.Text = "Disconnect";
            this.btDisConnectTcp.UseVisualStyleBackColor = true;
            this.btDisConnectTcp.Click += new System.EventHandler(this.btDisConnectTcp_Click);
            // 
            // btConnectTcp
            // 
            this.btConnectTcp.Location = new System.Drawing.Point(351, 22);
            this.btConnectTcp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btConnectTcp.Name = "btConnectTcp";
            this.btConnectTcp.Size = new System.Drawing.Size(135, 38);
            this.btConnectTcp.TabIndex = 19;
            this.btConnectTcp.Text = "Connect";
            this.btConnectTcp.UseVisualStyleBackColor = true;
            this.btConnectTcp.Click += new System.EventHandler(this.btConnectTcp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Port:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "IP:";
            // 
            // gpb_rs232
            // 
            this.gpb_rs232.Controls.Add(this.btDisConnect232);
            this.gpb_rs232.Controls.Add(this.btConnect232);
            this.gpb_rs232.Controls.Add(this.ComboBox_baud2);
            this.gpb_rs232.Controls.Add(this.label47);
            this.gpb_rs232.Controls.Add(this.ComboBox_COM);
            this.gpb_rs232.Controls.Add(this.label3);
            this.gpb_rs232.Location = new System.Drawing.Point(8, 85);
            this.gpb_rs232.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpb_rs232.Name = "gpb_rs232";
            this.gpb_rs232.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpb_rs232.Size = new System.Drawing.Size(514, 117);
            this.gpb_rs232.TabIndex = 3;
            this.gpb_rs232.TabStop = false;
            this.gpb_rs232.Text = "RS232";
            // 
            // btDisConnect232
            // 
            this.btDisConnect232.Enabled = false;
            this.btDisConnect232.Location = new System.Drawing.Point(351, 68);
            this.btDisConnect232.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btDisConnect232.Name = "btDisConnect232";
            this.btDisConnect232.Size = new System.Drawing.Size(135, 38);
            this.btDisConnect232.TabIndex = 20;
            this.btDisConnect232.Text = "Disconnect";
            this.btDisConnect232.UseVisualStyleBackColor = true;
            this.btDisConnect232.Click += new System.EventHandler(this.btDisConnect232_Click);
            // 
            // btConnect232
            // 
            this.btConnect232.Location = new System.Drawing.Point(351, 22);
            this.btConnect232.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btConnect232.Name = "btConnect232";
            this.btConnect232.Size = new System.Drawing.Size(135, 38);
            this.btConnect232.TabIndex = 19;
            this.btConnect232.Text = "Connect";
            this.btConnect232.UseVisualStyleBackColor = true;
            this.btConnect232.Click += new System.EventHandler(this.btConnect232_Click);
            // 
            // ComboBox_baud2
            // 
            this.ComboBox_baud2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_baud2.FormattingEnabled = true;
            this.ComboBox_baud2.Items.AddRange(new object[] {
            "9600bps",
            "19200bps",
            "38400bps",
            "57600bps",
            "115200bps"});
            this.ComboBox_baud2.Location = new System.Drawing.Point(144, 72);
            this.ComboBox_baud2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBox_baud2.Name = "ComboBox_baud2";
            this.ComboBox_baud2.Size = new System.Drawing.Size(180, 28);
            this.ComboBox_baud2.TabIndex = 18;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(32, 80);
            this.label47.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(83, 20);
            this.label47.TabIndex = 17;
            this.label47.Text = "Baud rate:";
            // 
            // ComboBox_COM
            // 
            this.ComboBox_COM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_COM.FormattingEnabled = true;
            this.ComboBox_COM.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.ComboBox_COM.Location = new System.Drawing.Point(144, 25);
            this.ComboBox_COM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBox_COM.Name = "ComboBox_COM";
            this.ComboBox_COM.Size = new System.Drawing.Size(180, 28);
            this.ComboBox_COM.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Serial Port:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_tcp);
            this.groupBox1.Controls.Add(this.rb_rs232);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(514, 73);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect Type";
            // 
            // rb_tcp
            // 
            this.rb_tcp.AutoSize = true;
            this.rb_tcp.Location = new System.Drawing.Point(285, 30);
            this.rb_tcp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_tcp.Name = "rb_tcp";
            this.rb_tcp.Size = new System.Drawing.Size(83, 24);
            this.rb_tcp.TabIndex = 1;
            this.rb_tcp.Text = "TCP/IP";
            this.rb_tcp.UseVisualStyleBackColor = true;
            this.rb_tcp.CheckedChanged += new System.EventHandler(this.rb_tcp_CheckedChanged);
            // 
            // rb_rs232
            // 
            this.rb_rs232.AutoSize = true;
            this.rb_rs232.Location = new System.Drawing.Point(50, 30);
            this.rb_rs232.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_rs232.Name = "rb_rs232";
            this.rb_rs232.Size = new System.Drawing.Size(84, 24);
            this.rb_rs232.TabIndex = 0;
            this.rb_rs232.Text = "RS232";
            this.rb_rs232.UseVisualStyleBackColor = true;
            this.rb_rs232.CheckedChanged += new System.EventHandler(this.rb_rs232_CheckedChanged);
            // 
            // tabPage_Mx
            // 
            this.tabPage_Mx.Controls.Add(this.panel2);
            this.tabPage_Mx.Location = new System.Drawing.Point(4, 4);
            this.tabPage_Mx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage_Mx.Name = "tabPage_Mx";
            this.tabPage_Mx.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage_Mx.Size = new System.Drawing.Size(1590, 866);
            this.tabPage_Mx.TabIndex = 1;
            this.tabPage_Mx.Text = "Auto-running setting";
            this.tabPage_Mx.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gbp_trigger);
            this.panel2.Controls.Add(this.groupBox43);
            this.panel2.Controls.Add(this.groupBox44);
            this.panel2.Controls.Add(this.btGetWorkmodepara);
            this.panel2.Controls.Add(this.groupBox37);
            this.panel2.Controls.Add(this.groupBox36);
            this.panel2.Controls.Add(this.gbp_tagType);
            this.panel2.Controls.Add(this.gbp_Response);
            this.panel2.Controls.Add(this.gbp_mask);
            this.panel2.Controls.Add(this.gbp_EASAcc);
            this.panel2.Location = new System.Drawing.Point(-4, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1594, 938);
            this.panel2.TabIndex = 0;
            // 
            // gbp_trigger
            // 
            this.gbp_trigger.Controls.Add(this.label84);
            this.gbp_trigger.Controls.Add(this.bttrigger);
            this.gbp_trigger.Controls.Add(this.comboBox_trigger);
            this.gbp_trigger.Controls.Add(this.label85);
            this.gbp_trigger.Location = new System.Drawing.Point(1064, 165);
            this.gbp_trigger.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbp_trigger.Name = "gbp_trigger";
            this.gbp_trigger.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbp_trigger.Size = new System.Drawing.Size(510, 112);
            this.gbp_trigger.TabIndex = 84;
            this.gbp_trigger.TabStop = false;
            this.gbp_trigger.Text = "Set Trigger-Time";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(274, 57);
            this.label84.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(32, 20);
            this.label84.TabIndex = 5;
            this.label84.Text = "*1s";
            // 
            // bttrigger
            // 
            this.bttrigger.Location = new System.Drawing.Point(366, 48);
            this.bttrigger.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttrigger.Name = "bttrigger";
            this.bttrigger.Size = new System.Drawing.Size(135, 38);
            this.bttrigger.TabIndex = 2;
            this.bttrigger.Text = "Set";
            this.bttrigger.UseVisualStyleBackColor = true;
            this.bttrigger.Click += new System.EventHandler(this.bttrigger_Click);
            // 
            // comboBox_trigger
            // 
            this.comboBox_trigger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_trigger.FormattingEnabled = true;
            this.comboBox_trigger.Location = new System.Drawing.Point(135, 48);
            this.comboBox_trigger.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_trigger.Name = "comboBox_trigger";
            this.comboBox_trigger.Size = new System.Drawing.Size(134, 28);
            this.comboBox_trigger.TabIndex = 1;
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(12, 53);
            this.label85.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(100, 20);
            this.label85.TabIndex = 0;
            this.label85.Text = "Trigger Time:";
            // 
            // groupBox43
            // 
            this.groupBox43.Controls.Add(this.btGetQS);
            this.groupBox43.Controls.Add(this.btSetQS);
            this.groupBox43.Controls.Add(this.com_acS);
            this.groupBox43.Controls.Add(this.label65);
            this.groupBox43.Controls.Add(this.com_acQ);
            this.groupBox43.Controls.Add(this.label64);
            this.groupBox43.Location = new System.Drawing.Point(666, 287);
            this.groupBox43.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox43.Name = "groupBox43";
            this.groupBox43.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox43.Size = new System.Drawing.Size(909, 93);
            this.groupBox43.TabIndex = 83;
            this.groupBox43.TabStop = false;
            this.groupBox43.Text = "Mutiple query parameter";
            // 
            // btGetQS
            // 
            this.btGetQS.Location = new System.Drawing.Point(764, 33);
            this.btGetQS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btGetQS.Name = "btGetQS";
            this.btGetQS.Size = new System.Drawing.Size(135, 38);
            this.btGetQS.TabIndex = 7;
            this.btGetQS.Text = "Get";
            this.btGetQS.UseVisualStyleBackColor = true;
            this.btGetQS.Click += new System.EventHandler(this.btGetQS_Click);
            // 
            // btSetQS
            // 
            this.btSetQS.Location = new System.Drawing.Point(596, 33);
            this.btSetQS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSetQS.Name = "btSetQS";
            this.btSetQS.Size = new System.Drawing.Size(135, 38);
            this.btSetQS.TabIndex = 6;
            this.btSetQS.Text = "Set";
            this.btSetQS.UseVisualStyleBackColor = true;
            this.btSetQS.Click += new System.EventHandler(this.btSetQS_Click);
            // 
            // com_acS
            // 
            this.com_acS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_acS.FormattingEnabled = true;
            this.com_acS.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.com_acS.Location = new System.Drawing.Point(404, 37);
            this.com_acS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.com_acS.Name = "com_acS";
            this.com_acS.Size = new System.Drawing.Size(134, 28);
            this.com_acS.TabIndex = 5;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(297, 43);
            this.label65.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(74, 20);
            this.label65.TabIndex = 4;
            this.label65.Text = "Session：";
            // 
            // com_acQ
            // 
            this.com_acQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_acQ.FormattingEnabled = true;
            this.com_acQ.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.com_acQ.Location = new System.Drawing.Point(66, 38);
            this.com_acQ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.com_acQ.Name = "com_acQ";
            this.com_acQ.Size = new System.Drawing.Size(134, 28);
            this.com_acQ.TabIndex = 3;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(27, 43);
            this.label64.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(29, 20);
            this.label64.TabIndex = 2;
            this.label64.Text = "Q：";
            // 
            // groupBox44
            // 
            this.groupBox44.Controls.Add(this.text_tidlen);
            this.groupBox44.Controls.Add(this.label67);
            this.groupBox44.Controls.Add(this.text_tidaddr);
            this.groupBox44.Controls.Add(this.btTIDpara);
            this.groupBox44.Controls.Add(this.label66);
            this.groupBox44.Location = new System.Drawing.Point(12, 287);
            this.groupBox44.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox44.Name = "groupBox44";
            this.groupBox44.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox44.Size = new System.Drawing.Size(645, 93);
            this.groupBox44.TabIndex = 82;
            this.groupBox44.TabStop = false;
            this.groupBox44.Text = "TID Parameter Setting";
            // 
            // text_tidlen
            // 
            this.text_tidlen.Location = new System.Drawing.Point(357, 38);
            this.text_tidlen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_tidlen.MaxLength = 2;
            this.text_tidlen.Name = "text_tidlen";
            this.text_tidlen.Size = new System.Drawing.Size(102, 26);
            this.text_tidlen.TabIndex = 5;
            this.text_tidlen.Text = "04";
            this.text_tidlen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(279, 43);
            this.label67.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(63, 20);
            this.label67.TabIndex = 4;
            this.label67.Text = "Length:";
            // 
            // text_tidaddr
            // 
            this.text_tidaddr.Location = new System.Drawing.Point(146, 38);
            this.text_tidaddr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_tidaddr.MaxLength = 2;
            this.text_tidaddr.Name = "text_tidaddr";
            this.text_tidaddr.Size = new System.Drawing.Size(102, 26);
            this.text_tidaddr.TabIndex = 3;
            this.text_tidaddr.Text = "02";
            this.text_tidaddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // btTIDpara
            // 
            this.btTIDpara.Location = new System.Drawing.Point(482, 37);
            this.btTIDpara.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btTIDpara.Name = "btTIDpara";
            this.btTIDpara.Size = new System.Drawing.Size(135, 38);
            this.btTIDpara.TabIndex = 2;
            this.btTIDpara.Text = "Set";
            this.btTIDpara.UseVisualStyleBackColor = true;
            this.btTIDpara.Click += new System.EventHandler(this.btTIDpara_Click);
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(10, 43);
            this.label66.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(111, 20);
            this.label66.TabIndex = 0;
            this.label66.Text = "Start Address:";
            // 
            // btGetWorkmodepara
            // 
            this.btGetWorkmodepara.Location = new System.Drawing.Point(1098, 403);
            this.btGetWorkmodepara.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btGetWorkmodepara.Name = "btGetWorkmodepara";
            this.btGetWorkmodepara.Size = new System.Drawing.Size(480, 67);
            this.btGetWorkmodepara.TabIndex = 80;
            this.btGetWorkmodepara.Text = "Get System Parameter";
            this.btGetWorkmodepara.UseVisualStyleBackColor = true;
            this.btGetWorkmodepara.Click += new System.EventHandler(this.btGetWorkmodepara_Click);
            // 
            // groupBox37
            // 
            this.groupBox37.Controls.Add(this.btworkmode);
            this.groupBox37.Controls.Add(this.comboBox_mode);
            this.groupBox37.Controls.Add(this.label59);
            this.groupBox37.Location = new System.Drawing.Point(518, 383);
            this.groupBox37.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox37.Name = "groupBox37";
            this.groupBox37.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox37.Size = new System.Drawing.Size(570, 93);
            this.groupBox37.TabIndex = 79;
            this.groupBox37.TabStop = false;
            this.groupBox37.Text = "Work Mode";
            // 
            // btworkmode
            // 
            this.btworkmode.Location = new System.Drawing.Point(410, 33);
            this.btworkmode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btworkmode.Name = "btworkmode";
            this.btworkmode.Size = new System.Drawing.Size(135, 38);
            this.btworkmode.TabIndex = 2;
            this.btworkmode.Text = "Set";
            this.btworkmode.UseVisualStyleBackColor = true;
            this.btworkmode.Click += new System.EventHandler(this.btworkmode_Click);
            // 
            // comboBox_mode
            // 
            this.comboBox_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_mode.FormattingEnabled = true;
            this.comboBox_mode.Items.AddRange(new object[] {
            "Answer Mode",
            "Auto_running mode",
            "Trigger mode(Low)",
            "Trigger mode(High)"});
            this.comboBox_mode.Location = new System.Drawing.Point(138, 38);
            this.comboBox_mode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_mode.Name = "comboBox_mode";
            this.comboBox_mode.Size = new System.Drawing.Size(250, 28);
            this.comboBox_mode.TabIndex = 1;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(10, 43);
            this.label59.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(102, 20);
            this.label59.TabIndex = 0;
            this.label59.Text = "Mode Select:";
            // 
            // groupBox36
            // 
            this.groupBox36.Controls.Add(this.btInterval);
            this.groupBox36.Controls.Add(this.comboBox_intervalT);
            this.groupBox36.Controls.Add(this.label58);
            this.groupBox36.Location = new System.Drawing.Point(12, 383);
            this.groupBox36.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox36.Name = "groupBox36";
            this.groupBox36.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox36.Size = new System.Drawing.Size(496, 93);
            this.groupBox36.TabIndex = 78;
            this.groupBox36.TabStop = false;
            this.groupBox36.Text = "Pulse interval";
            // 
            // btInterval
            // 
            this.btInterval.Location = new System.Drawing.Point(326, 33);
            this.btInterval.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btInterval.Name = "btInterval";
            this.btInterval.Size = new System.Drawing.Size(135, 38);
            this.btInterval.TabIndex = 2;
            this.btInterval.Text = "Set";
            this.btInterval.UseVisualStyleBackColor = true;
            this.btInterval.Click += new System.EventHandler(this.btInterval_Click);
            // 
            // comboBox_intervalT
            // 
            this.comboBox_intervalT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_intervalT.FormattingEnabled = true;
            this.comboBox_intervalT.Items.AddRange(new object[] {
            "10ms",
            "20ms",
            "30ms",
            "50ms",
            "100ms"});
            this.comboBox_intervalT.Location = new System.Drawing.Point(110, 38);
            this.comboBox_intervalT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_intervalT.Name = "comboBox_intervalT";
            this.comboBox_intervalT.Size = new System.Drawing.Size(194, 28);
            this.comboBox_intervalT.TabIndex = 1;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(6, 43);
            this.label58.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(90, 20);
            this.label58.TabIndex = 0;
            this.label58.Text = "Pulse Time:";
            // 
            // gbp_tagType
            // 
            this.gbp_tagType.Controls.Add(this.rb_G2TID);
            this.gbp_tagType.Controls.Add(this.bt_typeTag);
            this.gbp_tagType.Controls.Add(this.rb_EAS);
            this.gbp_tagType.Controls.Add(this.rb_G2);
            this.gbp_tagType.Controls.Add(this.groupBox35);
            this.gbp_tagType.Location = new System.Drawing.Point(12, 162);
            this.gbp_tagType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbp_tagType.Name = "gbp_tagType";
            this.gbp_tagType.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbp_tagType.Size = new System.Drawing.Size(1042, 115);
            this.gbp_tagType.TabIndex = 77;
            this.gbp_tagType.TabStop = false;
            this.gbp_tagType.Text = "Query Tag Type";
            // 
            // rb_G2TID
            // 
            this.rb_G2TID.AutoSize = true;
            this.rb_G2TID.Location = new System.Drawing.Point(674, 52);
            this.rb_G2TID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_G2TID.Name = "rb_G2TID";
            this.rb_G2TID.Size = new System.Drawing.Size(174, 24);
            this.rb_G2TID.TabIndex = 5;
            this.rb_G2TID.Text = "Query G2 Tag‘s TID";
            this.rb_G2TID.UseVisualStyleBackColor = true;
            // 
            // bt_typeTag
            // 
            this.bt_typeTag.Location = new System.Drawing.Point(898, 47);
            this.bt_typeTag.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_typeTag.Name = "bt_typeTag";
            this.bt_typeTag.Size = new System.Drawing.Size(135, 38);
            this.bt_typeTag.TabIndex = 4;
            this.bt_typeTag.Text = "Set";
            this.bt_typeTag.UseVisualStyleBackColor = true;
            this.bt_typeTag.Click += new System.EventHandler(this.bt_typeTag_Click);
            // 
            // rb_EAS
            // 
            this.rb_EAS.AutoSize = true;
            this.rb_EAS.Location = new System.Drawing.Point(514, 52);
            this.rb_EAS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_EAS.Name = "rb_EAS";
            this.rb_EAS.Size = new System.Drawing.Size(119, 24);
            this.rb_EAS.TabIndex = 3;
            this.rb_EAS.Text = "Detect EAS";
            this.rb_EAS.UseVisualStyleBackColor = true;
            // 
            // rb_G2
            // 
            this.rb_G2.AutoSize = true;
            this.rb_G2.Checked = true;
            this.rb_G2.Location = new System.Drawing.Point(339, 52);
            this.rb_G2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_G2.Name = "rb_G2";
            this.rb_G2.Size = new System.Drawing.Size(133, 24);
            this.rb_G2.TabIndex = 1;
            this.rb_G2.TabStop = true;
            this.rb_G2.Text = "Query G2 Tag";
            this.rb_G2.UseVisualStyleBackColor = true;
            // 
            // groupBox35
            // 
            this.groupBox35.Controls.Add(this.rb_180006B);
            this.groupBox35.Controls.Add(this.rb_180006c);
            this.groupBox35.Location = new System.Drawing.Point(9, 23);
            this.groupBox35.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox35.Name = "groupBox35";
            this.groupBox35.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox35.Size = new System.Drawing.Size(300, 80);
            this.groupBox35.TabIndex = 0;
            this.groupBox35.TabStop = false;
            this.groupBox35.Text = "Protocl";
            // 
            // rb_180006B
            // 
            this.rb_180006B.AutoSize = true;
            this.rb_180006B.Location = new System.Drawing.Point(159, 33);
            this.rb_180006B.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_180006B.Name = "rb_180006B";
            this.rb_180006B.Size = new System.Drawing.Size(104, 24);
            this.rb_180006B.TabIndex = 1;
            this.rb_180006B.Text = "18000-6B";
            this.rb_180006B.UseVisualStyleBackColor = true;
            // 
            // rb_180006c
            // 
            this.rb_180006c.AutoSize = true;
            this.rb_180006c.Checked = true;
            this.rb_180006c.Location = new System.Drawing.Point(15, 33);
            this.rb_180006c.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_180006c.Name = "rb_180006c";
            this.rb_180006c.Size = new System.Drawing.Size(113, 24);
            this.rb_180006c.TabIndex = 0;
            this.rb_180006c.TabStop = true;
            this.rb_180006c.Text = "EPCC1-G2";
            this.rb_180006c.UseVisualStyleBackColor = true;
            // 
            // gbp_Response
            // 
            this.gbp_Response.Controls.Add(this.btResponse);
            this.gbp_Response.Controls.Add(this.label57);
            this.gbp_Response.Controls.Add(this.comboBox_RespTime);
            this.gbp_Response.Controls.Add(this.label56);
            this.gbp_Response.Controls.Add(this.comboBox_Resp);
            this.gbp_Response.Controls.Add(this.label55);
            this.gbp_Response.Location = new System.Drawing.Point(1119, 7);
            this.gbp_Response.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbp_Response.Name = "gbp_Response";
            this.gbp_Response.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbp_Response.Size = new System.Drawing.Size(458, 145);
            this.gbp_Response.TabIndex = 76;
            this.gbp_Response.TabStop = false;
            this.gbp_Response.Text = "Response conditions  Setting";
            // 
            // btResponse
            // 
            this.btResponse.Location = new System.Drawing.Point(310, 83);
            this.btResponse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btResponse.Name = "btResponse";
            this.btResponse.Size = new System.Drawing.Size(135, 38);
            this.btResponse.TabIndex = 5;
            this.btResponse.Text = "Set";
            this.btResponse.UseVisualStyleBackColor = true;
            this.btResponse.Click += new System.EventHandler(this.btResponse_Click);
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(260, 97);
            this.label57.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(32, 20);
            this.label57.TabIndex = 4;
            this.label57.Text = "*1s";
            // 
            // comboBox_RespTime
            // 
            this.comboBox_RespTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_RespTime.FormattingEnabled = true;
            this.comboBox_RespTime.Location = new System.Drawing.Point(142, 85);
            this.comboBox_RespTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_RespTime.Name = "comboBox_RespTime";
            this.comboBox_RespTime.Size = new System.Drawing.Size(114, 28);
            this.comboBox_RespTime.TabIndex = 3;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(12, 97);
            this.label56.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(122, 20);
            this.label56.TabIndex = 2;
            this.label56.Text = "RepPauseTime:";
            // 
            // comboBox_Resp
            // 
            this.comboBox_Resp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Resp.FormattingEnabled = true;
            this.comboBox_Resp.Items.AddRange(new object[] {
            "Command notify",
            "Timer notify",
            "Add-in notify",
            "Delete notify",
            "Change notify"});
            this.comboBox_Resp.Location = new System.Drawing.Point(142, 37);
            this.comboBox_Resp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_Resp.Name = "comboBox_Resp";
            this.comboBox_Resp.Size = new System.Drawing.Size(301, 28);
            this.comboBox_Resp.TabIndex = 1;
            this.comboBox_Resp.SelectedIndexChanged += new System.EventHandler(this.comboBox_Resp_SelectedIndexChanged);
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(9, 43);
            this.label55.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(110, 20);
            this.label55.TabIndex = 0;
            this.label55.Text = "RepCondition:";
            // 
            // gbp_mask
            // 
            this.gbp_mask.Controls.Add(this.btMaskSet);
            this.gbp_mask.Controls.Add(this.text_mdata);
            this.gbp_mask.Controls.Add(this.label54);
            this.gbp_mask.Controls.Add(this.text_mlen);
            this.gbp_mask.Controls.Add(this.label53);
            this.gbp_mask.Controls.Add(this.text_madds);
            this.gbp_mask.Controls.Add(this.label81);
            this.gbp_mask.Controls.Add(this.rb_MaskUser);
            this.gbp_mask.Controls.Add(this.rb_MaskTID);
            this.gbp_mask.Controls.Add(this.rb_MaskEPC);
            this.gbp_mask.Location = new System.Drawing.Point(519, 7);
            this.gbp_mask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbp_mask.Name = "gbp_mask";
            this.gbp_mask.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbp_mask.Size = new System.Drawing.Size(576, 145);
            this.gbp_mask.TabIndex = 75;
            this.gbp_mask.TabStop = false;
            this.gbp_mask.Text = "Mask setting";
            // 
            // btMaskSet
            // 
            this.btMaskSet.Location = new System.Drawing.Point(428, 98);
            this.btMaskSet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btMaskSet.Name = "btMaskSet";
            this.btMaskSet.Size = new System.Drawing.Size(135, 38);
            this.btMaskSet.TabIndex = 9;
            this.btMaskSet.Text = "Set";
            this.btMaskSet.UseVisualStyleBackColor = true;
            this.btMaskSet.Click += new System.EventHandler(this.btMaskSet_Click);
            // 
            // text_mdata
            // 
            this.text_mdata.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_mdata.Location = new System.Drawing.Point(154, 102);
            this.text_mdata.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_mdata.Name = "text_mdata";
            this.text_mdata.Size = new System.Drawing.Size(258, 26);
            this.text_mdata.TabIndex = 8;
            this.text_mdata.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(9, 112);
            this.label54.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(125, 20);
            this.label54.TabIndex = 7;
            this.label54.Text = "Mask data(Hex):";
            // 
            // text_mlen
            // 
            this.text_mlen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_mlen.Location = new System.Drawing.Point(470, 55);
            this.text_mlen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_mlen.MaxLength = 2;
            this.text_mlen.Name = "text_mlen";
            this.text_mlen.Size = new System.Drawing.Size(91, 26);
            this.text_mlen.TabIndex = 6;
            this.text_mlen.Text = "00";
            this.text_mlen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(318, 67);
            this.label53.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(137, 20);
            this.label53.TabIndex = 5;
            this.label53.Text = "Mask length(Hex):";
            // 
            // text_madds
            // 
            this.text_madds.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_madds.Location = new System.Drawing.Point(206, 55);
            this.text_madds.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_madds.MaxLength = 4;
            this.text_madds.Name = "text_madds";
            this.text_madds.Size = new System.Drawing.Size(80, 26);
            this.text_madds.TabIndex = 4;
            this.text_madds.Text = "0000";
            this.text_madds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(9, 67);
            this.label81.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(150, 20);
            this.label81.TabIndex = 3;
            this.label81.Text = "Mask address(Hex):";
            // 
            // rb_MaskUser
            // 
            this.rb_MaskUser.AutoSize = true;
            this.rb_MaskUser.Location = new System.Drawing.Point(321, 23);
            this.rb_MaskUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_MaskUser.Name = "rb_MaskUser";
            this.rb_MaskUser.Size = new System.Drawing.Size(68, 24);
            this.rb_MaskUser.TabIndex = 2;
            this.rb_MaskUser.Text = "User";
            this.rb_MaskUser.UseVisualStyleBackColor = true;
            // 
            // rb_MaskTID
            // 
            this.rb_MaskTID.AutoSize = true;
            this.rb_MaskTID.Location = new System.Drawing.Point(165, 23);
            this.rb_MaskTID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_MaskTID.Name = "rb_MaskTID";
            this.rb_MaskTID.Size = new System.Drawing.Size(60, 24);
            this.rb_MaskTID.TabIndex = 1;
            this.rb_MaskTID.Text = "TID";
            this.rb_MaskTID.UseVisualStyleBackColor = true;
            // 
            // rb_MaskEPC
            // 
            this.rb_MaskEPC.AutoSize = true;
            this.rb_MaskEPC.Checked = true;
            this.rb_MaskEPC.Location = new System.Drawing.Point(9, 23);
            this.rb_MaskEPC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_MaskEPC.Name = "rb_MaskEPC";
            this.rb_MaskEPC.Size = new System.Drawing.Size(66, 24);
            this.rb_MaskEPC.TabIndex = 0;
            this.rb_MaskEPC.TabStop = true;
            this.rb_MaskEPC.Text = "EPC";
            this.rb_MaskEPC.UseVisualStyleBackColor = true;
            // 
            // gbp_EASAcc
            // 
            this.gbp_EASAcc.Controls.Add(this.btAccuracy);
            this.gbp_EASAcc.Controls.Add(this.ComboBox_Accuracy);
            this.gbp_EASAcc.Controls.Add(this.label82);
            this.gbp_EASAcc.Controls.Add(this.rbNone);
            this.gbp_EASAcc.Controls.Add(this.rbEASAcc);
            this.gbp_EASAcc.Location = new System.Drawing.Point(12, 7);
            this.gbp_EASAcc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbp_EASAcc.Name = "gbp_EASAcc";
            this.gbp_EASAcc.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbp_EASAcc.Size = new System.Drawing.Size(495, 145);
            this.gbp_EASAcc.TabIndex = 74;
            this.gbp_EASAcc.TabStop = false;
            this.gbp_EASAcc.Text = "EAS Sensitivity ";
            // 
            // btAccuracy
            // 
            this.btAccuracy.Location = new System.Drawing.Point(326, 82);
            this.btAccuracy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAccuracy.Name = "btAccuracy";
            this.btAccuracy.Size = new System.Drawing.Size(135, 38);
            this.btAccuracy.TabIndex = 4;
            this.btAccuracy.Text = "Set";
            this.btAccuracy.UseVisualStyleBackColor = true;
            this.btAccuracy.Click += new System.EventHandler(this.btAccuracy_Click);
            // 
            // ComboBox_Accuracy
            // 
            this.ComboBox_Accuracy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Accuracy.FormattingEnabled = true;
            this.ComboBox_Accuracy.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.ComboBox_Accuracy.Location = new System.Drawing.Point(147, 87);
            this.ComboBox_Accuracy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBox_Accuracy.Name = "ComboBox_Accuracy";
            this.ComboBox_Accuracy.Size = new System.Drawing.Size(116, 28);
            this.ComboBox_Accuracy.TabIndex = 3;
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(18, 92);
            this.label82.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(119, 20);
            this.label82.TabIndex = 2;
            this.label82.Text = "EAS Accuracy：";
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Location = new System.Drawing.Point(372, 37);
            this.rbNone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(72, 24);
            this.rbNone.TabIndex = 1;
            this.rbNone.Text = "None";
            this.rbNone.UseVisualStyleBackColor = true;
            // 
            // rbEASAcc
            // 
            this.rbEASAcc.AutoSize = true;
            this.rbEASAcc.Checked = true;
            this.rbEASAcc.Location = new System.Drawing.Point(18, 37);
            this.rbEASAcc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbEASAcc.Name = "rbEASAcc";
            this.rbEASAcc.Size = new System.Drawing.Size(297, 24);
            this.rbEASAcc.TabIndex = 0;
            this.rbEASAcc.TabStop = true;
            this.rbEASAcc.Text = "Relay release 3s when detected EAS";
            this.rbEASAcc.UseVisualStyleBackColor = true;
            // 
            // tabPage_Module
            // 
            this.tabPage_Module.Controls.Add(this.panel9);
            this.tabPage_Module.Location = new System.Drawing.Point(4, 4);
            this.tabPage_Module.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage_Module.Name = "tabPage_Module";
            this.tabPage_Module.Size = new System.Drawing.Size(1590, 866);
            this.tabPage_Module.TabIndex = 2;
            this.tabPage_Module.Text = "Real-time-inventory setting";
            this.tabPage_Module.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btMSetParameter);
            this.panel9.Controls.Add(this.btMGetParameter);
            this.panel9.Controls.Add(this.groupBox39);
            this.panel9.Controls.Add(this.groupBox38);
            this.panel9.Controls.Add(this.groupBox34);
            this.panel9.Controls.Add(this.groupBox33);
            this.panel9.Controls.Add(this.groupBox32);
            this.panel9.Controls.Add(this.groupBox28);
            this.panel9.Controls.Add(this.groupBox3);
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1588, 843);
            this.panel9.TabIndex = 0;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // btMSetParameter
            // 
            this.btMSetParameter.Location = new System.Drawing.Point(1392, 197);
            this.btMSetParameter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btMSetParameter.Name = "btMSetParameter";
            this.btMSetParameter.Size = new System.Drawing.Size(178, 55);
            this.btMSetParameter.TabIndex = 86;
            this.btMSetParameter.Text = "Set Parameter";
            this.btMSetParameter.UseVisualStyleBackColor = true;
            this.btMSetParameter.Click += new System.EventHandler(this.btMSetParameter_Click);
            // 
            // btMGetParameter
            // 
            this.btMGetParameter.Location = new System.Drawing.Point(1392, 123);
            this.btMGetParameter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btMGetParameter.Name = "btMGetParameter";
            this.btMGetParameter.Size = new System.Drawing.Size(178, 55);
            this.btMGetParameter.TabIndex = 85;
            this.btMGetParameter.Text = "Get Parameter";
            this.btMGetParameter.UseVisualStyleBackColor = true;
            this.btMGetParameter.Click += new System.EventHandler(this.btMGetParameter_Click);
            // 
            // groupBox39
            // 
            this.groupBox39.Controls.Add(this.btSetMmode);
            this.groupBox39.Controls.Add(this.com_Mmode);
            this.groupBox39.Controls.Add(this.label111);
            this.groupBox39.Location = new System.Drawing.Point(984, 115);
            this.groupBox39.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox39.Name = "groupBox39";
            this.groupBox39.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox39.Size = new System.Drawing.Size(398, 145);
            this.groupBox39.TabIndex = 84;
            this.groupBox39.TabStop = false;
            this.groupBox39.Text = "Work Mode";
            // 
            // btSetMmode
            // 
            this.btSetMmode.Location = new System.Drawing.Point(255, 93);
            this.btSetMmode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSetMmode.Name = "btSetMmode";
            this.btSetMmode.Size = new System.Drawing.Size(135, 38);
            this.btSetMmode.TabIndex = 2;
            this.btSetMmode.Text = "Set";
            this.btSetMmode.UseVisualStyleBackColor = true;
            this.btSetMmode.Click += new System.EventHandler(this.btSetMmode_Click);
            // 
            // com_Mmode
            // 
            this.com_Mmode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_Mmode.FormattingEnabled = true;
            this.com_Mmode.Items.AddRange(new object[] {
            "Answer mode",
            "Real-time-inventory mode"});
            this.com_Mmode.Location = new System.Drawing.Point(128, 38);
            this.com_Mmode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.com_Mmode.Name = "com_Mmode";
            this.com_Mmode.Size = new System.Drawing.Size(259, 28);
            this.com_Mmode.TabIndex = 1;
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Location = new System.Drawing.Point(10, 43);
            this.label111.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(102, 20);
            this.label111.TabIndex = 0;
            this.label111.Text = "Mode Select:";
            // 
            // groupBox38
            // 
            this.groupBox38.Controls.Add(this.checkBox_tid);
            this.groupBox38.Controls.Add(this.txt_Mtidlen);
            this.groupBox38.Controls.Add(this.label103);
            this.groupBox38.Controls.Add(this.txt_mtidaddr);
            this.groupBox38.Controls.Add(this.label104);
            this.groupBox38.Location = new System.Drawing.Point(654, 115);
            this.groupBox38.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox38.Name = "groupBox38";
            this.groupBox38.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox38.Size = new System.Drawing.Size(321, 145);
            this.groupBox38.TabIndex = 83;
            this.groupBox38.TabStop = false;
            this.groupBox38.Text = "TID Parameter Setting";
            // 
            // checkBox_tid
            // 
            this.checkBox_tid.AutoSize = true;
            this.checkBox_tid.Location = new System.Drawing.Point(230, 100);
            this.checkBox_tid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_tid.Name = "checkBox_tid";
            this.checkBox_tid.Size = new System.Drawing.Size(85, 24);
            this.checkBox_tid.TabIndex = 10;
            this.checkBox_tid.Text = "Enable";
            this.checkBox_tid.UseVisualStyleBackColor = true;
            // 
            // txt_Mtidlen
            // 
            this.txt_Mtidlen.Location = new System.Drawing.Point(130, 97);
            this.txt_Mtidlen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Mtidlen.MaxLength = 2;
            this.txt_Mtidlen.Name = "txt_Mtidlen";
            this.txt_Mtidlen.Size = new System.Drawing.Size(88, 26);
            this.txt_Mtidlen.TabIndex = 5;
            this.txt_Mtidlen.Text = "04";
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Location = new System.Drawing.Point(15, 102);
            this.label103.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(101, 20);
            this.label103.TabIndex = 4;
            this.label103.Text = "Length(Hex):";
            // 
            // txt_mtidaddr
            // 
            this.txt_mtidaddr.Location = new System.Drawing.Point(198, 38);
            this.txt_mtidaddr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_mtidaddr.MaxLength = 2;
            this.txt_mtidaddr.Name = "txt_mtidaddr";
            this.txt_mtidaddr.Size = new System.Drawing.Size(106, 26);
            this.txt_mtidaddr.TabIndex = 3;
            this.txt_mtidaddr.Text = "02";
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Location = new System.Drawing.Point(16, 43);
            this.label104.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(147, 20);
            this.label104.TabIndex = 0;
            this.label104.Text = "Start address(Hex):";
            // 
            // groupBox34
            // 
            this.groupBox34.Controls.Add(this.checkBox_mask);
            this.groupBox34.Controls.Add(this.txt_Mdata);
            this.groupBox34.Controls.Add(this.label100);
            this.groupBox34.Controls.Add(this.txt_Mlen);
            this.groupBox34.Controls.Add(this.label101);
            this.groupBox34.Controls.Add(this.txt_Maddr);
            this.groupBox34.Controls.Add(this.label102);
            this.groupBox34.Controls.Add(this.RBM_USER);
            this.groupBox34.Controls.Add(this.RBM_TID);
            this.groupBox34.Controls.Add(this.RBM_EPC);
            this.groupBox34.Location = new System.Drawing.Point(12, 115);
            this.groupBox34.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox34.Name = "groupBox34";
            this.groupBox34.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox34.Size = new System.Drawing.Size(630, 145);
            this.groupBox34.TabIndex = 82;
            this.groupBox34.TabStop = false;
            this.groupBox34.Text = "Mask setting";
            // 
            // checkBox_mask
            // 
            this.checkBox_mask.AutoSize = true;
            this.checkBox_mask.Location = new System.Drawing.Point(484, 22);
            this.checkBox_mask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_mask.Name = "checkBox_mask";
            this.checkBox_mask.Size = new System.Drawing.Size(85, 24);
            this.checkBox_mask.TabIndex = 9;
            this.checkBox_mask.Text = "Enable";
            this.checkBox_mask.UseVisualStyleBackColor = true;
            // 
            // txt_Mdata
            // 
            this.txt_Mdata.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Mdata.Location = new System.Drawing.Point(112, 102);
            this.txt_Mdata.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Mdata.Name = "txt_Mdata";
            this.txt_Mdata.Size = new System.Drawing.Size(498, 26);
            this.txt_Mdata.TabIndex = 8;
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(9, 112);
            this.label100.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(86, 20);
            this.label100.TabIndex = 7;
            this.label100.Text = "Data(Hex):";
            // 
            // txt_Mlen
            // 
            this.txt_Mlen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Mlen.Location = new System.Drawing.Point(522, 55);
            this.txt_Mlen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Mlen.MaxLength = 2;
            this.txt_Mlen.Name = "txt_Mlen";
            this.txt_Mlen.Size = new System.Drawing.Size(91, 26);
            this.txt_Mlen.TabIndex = 6;
            this.txt_Mlen.Text = "00";
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Location = new System.Drawing.Point(396, 67);
            this.label101.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(101, 20);
            this.label101.TabIndex = 5;
            this.label101.Text = "Length(Hex):";
            // 
            // txt_Maddr
            // 
            this.txt_Maddr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Maddr.Location = new System.Drawing.Point(206, 55);
            this.txt_Maddr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Maddr.MaxLength = 4;
            this.txt_Maddr.Name = "txt_Maddr";
            this.txt_Maddr.Size = new System.Drawing.Size(80, 26);
            this.txt_Maddr.TabIndex = 4;
            this.txt_Maddr.Text = "0000";
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Location = new System.Drawing.Point(9, 67);
            this.label102.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(147, 20);
            this.label102.TabIndex = 3;
            this.label102.Text = "Start address(Hex):";
            // 
            // RBM_USER
            // 
            this.RBM_USER.AutoSize = true;
            this.RBM_USER.Location = new System.Drawing.Point(370, 23);
            this.RBM_USER.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RBM_USER.Name = "RBM_USER";
            this.RBM_USER.Size = new System.Drawing.Size(68, 24);
            this.RBM_USER.TabIndex = 2;
            this.RBM_USER.Text = "User";
            this.RBM_USER.UseVisualStyleBackColor = true;
            // 
            // RBM_TID
            // 
            this.RBM_TID.AutoSize = true;
            this.RBM_TID.Location = new System.Drawing.Point(204, 23);
            this.RBM_TID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RBM_TID.Name = "RBM_TID";
            this.RBM_TID.Size = new System.Drawing.Size(60, 24);
            this.RBM_TID.TabIndex = 1;
            this.RBM_TID.Text = "TID";
            this.RBM_TID.UseVisualStyleBackColor = true;
            // 
            // RBM_EPC
            // 
            this.RBM_EPC.AutoSize = true;
            this.RBM_EPC.Checked = true;
            this.RBM_EPC.Location = new System.Drawing.Point(30, 23);
            this.RBM_EPC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RBM_EPC.Name = "RBM_EPC";
            this.RBM_EPC.Size = new System.Drawing.Size(66, 24);
            this.RBM_EPC.TabIndex = 0;
            this.RBM_EPC.TabStop = true;
            this.RBM_EPC.Text = "EPC";
            this.RBM_EPC.UseVisualStyleBackColor = true;
            // 
            // groupBox33
            // 
            this.groupBox33.Controls.Add(this.com_MS);
            this.groupBox33.Controls.Add(this.label99);
            this.groupBox33.Controls.Add(this.com_MQ);
            this.groupBox33.Controls.Add(this.label98);
            this.groupBox33.Location = new System.Drawing.Point(984, 10);
            this.groupBox33.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox33.Name = "groupBox33";
            this.groupBox33.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox33.Size = new System.Drawing.Size(591, 93);
            this.groupBox33.TabIndex = 81;
            this.groupBox33.TabStop = false;
            this.groupBox33.Text = "Mutiple query parameter";
            // 
            // com_MS
            // 
            this.com_MS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_MS.FormattingEnabled = true;
            this.com_MS.Items.AddRange(new object[] {
            "S0",
            "S1",
            "S2",
            "S3",
            "AUTO"});
            this.com_MS.Location = new System.Drawing.Point(400, 38);
            this.com_MS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.com_MS.Name = "com_MS";
            this.com_MS.Size = new System.Drawing.Size(174, 28);
            this.com_MS.TabIndex = 3;
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Location = new System.Drawing.Point(303, 43);
            this.label99.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(70, 20);
            this.label99.TabIndex = 2;
            this.label99.Text = "Session:";
            // 
            // com_MQ
            // 
            this.com_MQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_MQ.FormattingEnabled = true;
            this.com_MQ.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.com_MQ.Location = new System.Drawing.Point(70, 38);
            this.com_MQ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.com_MQ.Name = "com_MQ";
            this.com_MQ.Size = new System.Drawing.Size(174, 28);
            this.com_MQ.TabIndex = 1;
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Location = new System.Drawing.Point(28, 43);
            this.label98.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(25, 20);
            this.label98.TabIndex = 0;
            this.label98.Text = "Q:";
            // 
            // groupBox32
            // 
            this.groupBox32.Controls.Add(this.com_MFliterTime);
            this.groupBox32.Controls.Add(this.label97);
            this.groupBox32.Location = new System.Drawing.Point(654, 10);
            this.groupBox32.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox32.Name = "groupBox32";
            this.groupBox32.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox32.Size = new System.Drawing.Size(321, 93);
            this.groupBox32.TabIndex = 80;
            this.groupBox32.TabStop = false;
            this.groupBox32.Text = "Tag Filter";
            // 
            // com_MFliterTime
            // 
            this.com_MFliterTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_MFliterTime.FormattingEnabled = true;
            this.com_MFliterTime.Location = new System.Drawing.Point(124, 38);
            this.com_MFliterTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.com_MFliterTime.Name = "com_MFliterTime";
            this.com_MFliterTime.Size = new System.Drawing.Size(180, 28);
            this.com_MFliterTime.TabIndex = 1;
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Location = new System.Drawing.Point(10, 43);
            this.label97.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(82, 20);
            this.label97.TabIndex = 0;
            this.label97.Text = "Filter time:";
            // 
            // groupBox28
            // 
            this.groupBox28.Controls.Add(this.COM_MRPTime);
            this.groupBox28.Controls.Add(this.label96);
            this.groupBox28.Location = new System.Drawing.Point(321, 10);
            this.groupBox28.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox28.Name = "groupBox28";
            this.groupBox28.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox28.Size = new System.Drawing.Size(321, 93);
            this.groupBox28.TabIndex = 79;
            this.groupBox28.TabStop = false;
            this.groupBox28.Text = "Pulse interval";
            // 
            // COM_MRPTime
            // 
            this.COM_MRPTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COM_MRPTime.FormattingEnabled = true;
            this.COM_MRPTime.Items.AddRange(new object[] {
            "10ms",
            "20ms",
            "30ms",
            "50ms",
            "100ms"});
            this.COM_MRPTime.Location = new System.Drawing.Point(112, 38);
            this.COM_MRPTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.COM_MRPTime.Name = "COM_MRPTime";
            this.COM_MRPTime.Size = new System.Drawing.Size(194, 28);
            this.COM_MRPTime.TabIndex = 1;
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Location = new System.Drawing.Point(10, 43);
            this.label96.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(90, 20);
            this.label96.TabIndex = 0;
            this.label96.Text = "Pulse Time:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MRB_6B);
            this.groupBox3.Controls.Add(this.MRB_G2);
            this.groupBox3.Location = new System.Drawing.Point(12, 10);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(300, 93);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Protocl";
            // 
            // MRB_6B
            // 
            this.MRB_6B.AutoSize = true;
            this.MRB_6B.Location = new System.Drawing.Point(159, 33);
            this.MRB_6B.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MRB_6B.Name = "MRB_6B";
            this.MRB_6B.Size = new System.Drawing.Size(104, 24);
            this.MRB_6B.TabIndex = 1;
            this.MRB_6B.Text = "18000-6B";
            this.MRB_6B.UseVisualStyleBackColor = true;
            // 
            // MRB_G2
            // 
            this.MRB_G2.AutoSize = true;
            this.MRB_G2.Checked = true;
            this.MRB_G2.Location = new System.Drawing.Point(15, 33);
            this.MRB_G2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MRB_G2.Name = "MRB_G2";
            this.MRB_G2.Size = new System.Drawing.Size(113, 24);
            this.MRB_G2.TabIndex = 0;
            this.MRB_G2.TabStop = true;
            this.MRB_G2.Text = "EPCC1-G2";
            this.MRB_G2.UseVisualStyleBackColor = true;
            // 
            // Main_Page2
            // 
            this.Main_Page2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Main_Page2.Controls.Add(this.tabControl2);
            this.Main_Page2.Location = new System.Drawing.Point(4, 27);
            this.Main_Page2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Main_Page2.Name = "Main_Page2";
            this.Main_Page2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Main_Page2.Size = new System.Drawing.Size(1610, 931);
            this.Main_Page2.TabIndex = 1;
            this.Main_Page2.Text = "EPCC1-G2 Test";
            this.Main_Page2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl2.Controls.Add(this.tabPage_answer);
            this.tabControl2.Controls.Add(this.tabPage_active);
            this.tabControl2.Controls.Add(this.tabPage_Realtime);
            this.tabControl2.Controls.Add(this.tabPage_Buff);
            this.tabControl2.Controls.Add(this.tabPage_RW);
            this.tabControl2.ItemSize = new System.Drawing.Size(120, 23);
            this.tabControl2.Location = new System.Drawing.Point(-2, 10);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1606, 897);
            this.tabControl2.TabIndex = 0;
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.Maintab_SelectedIndexChanged);
            // 
            // tabPage_answer
            // 
            this.tabPage_answer.Controls.Add(this.panel1);
            this.tabPage_answer.Location = new System.Drawing.Point(4, 4);
            this.tabPage_answer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage_answer.Name = "tabPage_answer";
            this.tabPage_answer.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage_answer.Size = new System.Drawing.Size(1598, 866);
            this.tabPage_answer.TabIndex = 0;
            this.tabPage_answer.Text = "Answer Mode";
            this.tabPage_answer.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lxLedControl5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lxLedControl4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lxLedControl3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lxLedControl2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lxLedControl1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.group_ant1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1599, 832);
            this.panel1.TabIndex = 0;
            // 
            // lxLedControl5
            // 
            this.lxLedControl5.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl5.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl5.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl5.BevelRate = 0.5F;
            this.lxLedControl5.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl5.BorderWidth = 3;
            this.lxLedControl5.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl5.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lxLedControl5.HighlightOpaque = ((byte)(50));
            this.lxLedControl5.Location = new System.Drawing.Point(1329, 623);
            this.lxLedControl5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lxLedControl5.Name = "lxLedControl5";
            this.lxLedControl5.RoundCorner = true;
            this.lxLedControl5.ShowHighlight = true;
            this.lxLedControl5.Size = new System.Drawing.Size(231, 67);
            this.lxLedControl5.TabIndex = 28;
            this.lxLedControl5.Text = "0";
            this.lxLedControl5.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLedControl5.TotalCharCount = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label9.Location = new System.Drawing.Point(1326, 590);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Total-cmd-time(ms):";
            // 
            // lxLedControl4
            // 
            this.lxLedControl4.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl4.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl4.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl4.BevelRate = 0.5F;
            this.lxLedControl4.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl4.BorderWidth = 3;
            this.lxLedControl4.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl4.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lxLedControl4.HighlightOpaque = ((byte)(50));
            this.lxLedControl4.Location = new System.Drawing.Point(1066, 622);
            this.lxLedControl4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lxLedControl4.Name = "lxLedControl4";
            this.lxLedControl4.RoundCorner = true;
            this.lxLedControl4.ShowHighlight = true;
            this.lxLedControl4.Size = new System.Drawing.Size(231, 68);
            this.lxLedControl4.TabIndex = 26;
            this.lxLedControl4.Text = "0";
            this.lxLedControl4.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLedControl4.TotalCharCount = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(1064, 590);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Total tag number:";
            // 
            // lxLedControl3
            // 
            this.lxLedControl3.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl3.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl3.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl3.BevelRate = 0.5F;
            this.lxLedControl3.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl3.BorderWidth = 3;
            this.lxLedControl3.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl3.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl3.ForeColor = System.Drawing.Color.Purple;
            this.lxLedControl3.HighlightOpaque = ((byte)(50));
            this.lxLedControl3.Location = new System.Drawing.Point(1329, 487);
            this.lxLedControl3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lxLedControl3.Name = "lxLedControl3";
            this.lxLedControl3.RoundCorner = true;
            this.lxLedControl3.ShowHighlight = true;
            this.lxLedControl3.Size = new System.Drawing.Size(231, 48);
            this.lxLedControl3.TabIndex = 24;
            this.lxLedControl3.Text = "0";
            this.lxLedControl3.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLedControl3.TotalCharCount = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(1326, 447);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "cmd time(ms):";
            // 
            // lxLedControl2
            // 
            this.lxLedControl2.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl2.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl2.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl2.BevelRate = 0.5F;
            this.lxLedControl2.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl2.BorderWidth = 3;
            this.lxLedControl2.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl2.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl2.ForeColor = System.Drawing.Color.Purple;
            this.lxLedControl2.HighlightOpaque = ((byte)(50));
            this.lxLedControl2.Location = new System.Drawing.Point(1066, 487);
            this.lxLedControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lxLedControl2.Name = "lxLedControl2";
            this.lxLedControl2.RoundCorner = true;
            this.lxLedControl2.ShowHighlight = true;
            this.lxLedControl2.Size = new System.Drawing.Size(231, 48);
            this.lxLedControl2.TabIndex = 22;
            this.lxLedControl2.Text = "0";
            this.lxLedControl2.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLedControl2.TotalCharCount = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(1064, 447);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Speed:";
            // 
            // lxLedControl1
            // 
            this.lxLedControl1.BackColor = System.Drawing.Color.Transparent;
            this.lxLedControl1.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLedControl1.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLedControl1.BevelRate = 0.5F;
            this.lxLedControl1.BorderColor = System.Drawing.Color.Lavender;
            this.lxLedControl1.BorderWidth = 3;
            this.lxLedControl1.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLedControl1.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLedControl1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lxLedControl1.HighlightOpaque = ((byte)(50));
            this.lxLedControl1.Location = new System.Drawing.Point(1066, 183);
            this.lxLedControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lxLedControl1.Name = "lxLedControl1";
            this.lxLedControl1.RoundCorner = true;
            this.lxLedControl1.ShowHighlight = true;
            this.lxLedControl1.Size = new System.Drawing.Size(494, 212);
            this.lxLedControl1.TabIndex = 20;
            this.lxLedControl1.Text = "0";
            this.lxLedControl1.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLedControl1.Click += new System.EventHandler(this.lxLedControl1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1064, 152);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tag Number:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView1);
            this.groupBox5.Location = new System.Drawing.Point(6, 132);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(1017, 695);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tag list(No Repeat\n)";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 33);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(996, 652);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox_rate);
            this.groupBox4.Controls.Add(this.label80);
            this.groupBox4.Controls.Add(this.text_target);
            this.groupBox4.Controls.Add(this.check_num);
            this.groupBox4.Controls.Add(this.com_Target);
            this.groupBox4.Controls.Add(this.label79);
            this.groupBox4.Controls.Add(this.com_scantime);
            this.groupBox4.Controls.Add(this.label39);
            this.groupBox4.Controls.Add(this.com_S);
            this.groupBox4.Controls.Add(this.label32);
            this.groupBox4.Controls.Add(this.com_Q);
            this.groupBox4.Controls.Add(this.label31);
            this.groupBox4.Location = new System.Drawing.Point(819, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(768, 118);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            // 
            // checkBox_rate
            // 
            this.checkBox_rate.AutoSize = true;
            this.checkBox_rate.Checked = true;
            this.checkBox_rate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_rate.Location = new System.Drawing.Point(528, 77);
            this.checkBox_rate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_rate.Name = "checkBox_rate";
            this.checkBox_rate.Size = new System.Drawing.Size(135, 24);
            this.checkBox_rate.TabIndex = 37;
            this.checkBox_rate.Text = "Return Speed";
            this.checkBox_rate.UseVisualStyleBackColor = true;
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(165, 80);
            this.label80.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(246, 20);
            this.label80.TabIndex = 36;
            this.label80.Text = "times no tag.then A/B conversion ";
            // 
            // text_target
            // 
            this.text_target.ForeColor = System.Drawing.Color.Red;
            this.text_target.Location = new System.Drawing.Point(94, 70);
            this.text_target.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_target.MaxLength = 1;
            this.text_target.Name = "text_target";
            this.text_target.Size = new System.Drawing.Size(62, 26);
            this.text_target.TabIndex = 35;
            this.text_target.Text = "2";
            this.text_target.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_target.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // check_num
            // 
            this.check_num.AutoSize = true;
            this.check_num.Checked = true;
            this.check_num.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_num.Location = new System.Drawing.Point(22, 77);
            this.check_num.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.check_num.Name = "check_num";
            this.check_num.Size = new System.Drawing.Size(74, 24);
            this.check_num.TabIndex = 34;
            this.check_num.Text = "Read";
            this.check_num.UseVisualStyleBackColor = true;
            // 
            // com_Target
            // 
            this.com_Target.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_Target.FormattingEnabled = true;
            this.com_Target.Items.AddRange(new object[] {
            "A",
            "B"});
            this.com_Target.Location = new System.Drawing.Point(668, 25);
            this.com_Target.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.com_Target.Name = "com_Target";
            this.com_Target.Size = new System.Drawing.Size(90, 28);
            this.com_Target.TabIndex = 33;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(591, 35);
            this.label79.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(59, 20);
            this.label79.TabIndex = 32;
            this.label79.Text = "Target:";
            // 
            // com_scantime
            // 
            this.com_scantime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_scantime.FormattingEnabled = true;
            this.com_scantime.Location = new System.Drawing.Point(462, 27);
            this.com_scantime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.com_scantime.Name = "com_scantime";
            this.com_scantime.Size = new System.Drawing.Size(114, 28);
            this.com_scantime.TabIndex = 31;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(342, 32);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(118, 20);
            this.label39.TabIndex = 30;
            this.label39.Text = "Max-ScanTime:";
            // 
            // com_S
            // 
            this.com_S.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_S.FormattingEnabled = true;
            this.com_S.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "AUTO"});
            this.com_S.Location = new System.Drawing.Point(232, 27);
            this.com_S.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.com_S.Name = "com_S";
            this.com_S.Size = new System.Drawing.Size(86, 28);
            this.com_S.TabIndex = 29;
            this.com_S.SelectedIndexChanged += new System.EventHandler(this.com_S_SelectedIndexChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(140, 33);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(74, 20);
            this.label32.TabIndex = 28;
            this.label32.Text = "Session：";
            // 
            // com_Q
            // 
            this.com_Q.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_Q.FormattingEnabled = true;
            this.com_Q.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.com_Q.Location = new System.Drawing.Point(50, 25);
            this.com_Q.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.com_Q.Name = "com_Q";
            this.com_Q.Size = new System.Drawing.Size(76, 28);
            this.com_Q.TabIndex = 27;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(22, 32);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(25, 20);
            this.label31.TabIndex = 26;
            this.label31.Text = "Q:";
            // 
            // group_ant1
            // 
            this.group_ant1.Controls.Add(this.check_ant4);
            this.group_ant1.Controls.Add(this.check_ant3);
            this.group_ant1.Controls.Add(this.check_ant2);
            this.group_ant1.Controls.Add(this.check_ant1);
            this.group_ant1.Enabled = false;
            this.group_ant1.Location = new System.Drawing.Point(465, 0);
            this.group_ant1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.group_ant1.Name = "group_ant1";
            this.group_ant1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.group_ant1.Size = new System.Drawing.Size(363, 118);
            this.group_ant1.TabIndex = 16;
            this.group_ant1.TabStop = false;
            // 
            // check_ant4
            // 
            this.check_ant4.AutoSize = true;
            this.check_ant4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.check_ant4.Location = new System.Drawing.Point(273, 50);
            this.check_ant4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.check_ant4.Name = "check_ant4";
            this.check_ant4.Size = new System.Drawing.Size(75, 24);
            this.check_ant4.TabIndex = 37;
            this.check_ant4.Text = "ANT4";
            this.check_ant4.UseVisualStyleBackColor = true;
            // 
            // check_ant3
            // 
            this.check_ant3.AutoSize = true;
            this.check_ant3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.check_ant3.Location = new System.Drawing.Point(192, 50);
            this.check_ant3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.check_ant3.Name = "check_ant3";
            this.check_ant3.Size = new System.Drawing.Size(75, 24);
            this.check_ant3.TabIndex = 36;
            this.check_ant3.Text = "ANT3";
            this.check_ant3.UseVisualStyleBackColor = true;
            // 
            // check_ant2
            // 
            this.check_ant2.AutoSize = true;
            this.check_ant2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.check_ant2.Location = new System.Drawing.Point(111, 50);
            this.check_ant2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.check_ant2.Name = "check_ant2";
            this.check_ant2.Size = new System.Drawing.Size(75, 24);
            this.check_ant2.TabIndex = 35;
            this.check_ant2.Text = "ANT2";
            this.check_ant2.UseVisualStyleBackColor = true;
            // 
            // check_ant1
            // 
            this.check_ant1.AutoSize = true;
            this.check_ant1.Checked = true;
            this.check_ant1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_ant1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.check_ant1.Location = new System.Drawing.Point(30, 50);
            this.check_ant1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.check_ant1.Name = "check_ant1";
            this.check_ant1.Size = new System.Drawing.Size(75, 24);
            this.check_ant1.TabIndex = 34;
            this.check_ant1.Text = "ANT1";
            this.check_ant1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_tid);
            this.groupBox2.Controls.Add(this.rb_epc);
            this.groupBox2.Controls.Add(this.btIventoryG2);
            this.groupBox2.Location = new System.Drawing.Point(8, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(460, 118);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // rb_tid
            // 
            this.rb_tid.AutoSize = true;
            this.rb_tid.Location = new System.Drawing.Point(321, 70);
            this.rb_tid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_tid.Name = "rb_tid";
            this.rb_tid.Size = new System.Drawing.Size(60, 24);
            this.rb_tid.TabIndex = 2;
            this.rb_tid.Text = "TID";
            this.rb_tid.UseVisualStyleBackColor = true;
            // 
            // rb_epc
            // 
            this.rb_epc.AutoSize = true;
            this.rb_epc.Checked = true;
            this.rb_epc.Location = new System.Drawing.Point(321, 33);
            this.rb_epc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_epc.Name = "rb_epc";
            this.rb_epc.Size = new System.Drawing.Size(66, 24);
            this.rb_epc.TabIndex = 1;
            this.rb_epc.TabStop = true;
            this.rb_epc.Text = "EPC";
            this.rb_epc.UseVisualStyleBackColor = true;
            // 
            // btIventoryG2
            // 
            this.btIventoryG2.BackColor = System.Drawing.Color.Transparent;
            this.btIventoryG2.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btIventoryG2.ForeColor = System.Drawing.Color.DarkBlue;
            this.btIventoryG2.Location = new System.Drawing.Point(27, 33);
            this.btIventoryG2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btIventoryG2.Name = "btIventoryG2";
            this.btIventoryG2.Size = new System.Drawing.Size(256, 67);
            this.btIventoryG2.TabIndex = 0;
            this.btIventoryG2.Text = "Start";
            this.btIventoryG2.UseVisualStyleBackColor = false;
            this.btIventoryG2.Click += new System.EventHandler(this.btIventoryG2_Click);
            // 
            // tabPage_active
            // 
            this.tabPage_active.Controls.Add(this.panel3);
            this.tabPage_active.Location = new System.Drawing.Point(4, 4);
            this.tabPage_active.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage_active.Name = "tabPage_active";
            this.tabPage_active.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage_active.Size = new System.Drawing.Size(1598, 866);
            this.tabPage_active.TabIndex = 1;
            this.tabPage_active.Text = "Auto-running";
            this.tabPage_active.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox9);
            this.panel3.Controls.Add(this.groupBox8);
            this.panel3.Controls.Add(this.groupBox7);
            this.panel3.Controls.Add(this.groupBox6);
            this.panel3.Location = new System.Drawing.Point(0, 3);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1600, 837);
            this.panel3.TabIndex = 0;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label20);
            this.groupBox9.Controls.Add(this.lxLed_toltime);
            this.groupBox9.Controls.Add(this.dataGridView2);
            this.groupBox9.Controls.Add(this.label19);
            this.groupBox9.Controls.Add(this.lxLed_toltag);
            this.groupBox9.Controls.Add(this.label18);
            this.groupBox9.Controls.Add(this.lxLed_cmdsud);
            this.groupBox9.Controls.Add(this.label17);
            this.groupBox9.Controls.Add(this.lxLed_Num);
            this.groupBox9.Controls.Add(this.label13);
            this.groupBox9.Location = new System.Drawing.Point(9, 135);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox9.Size = new System.Drawing.Size(1580, 695);
            this.groupBox9.TabIndex = 20;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Data";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label20.Location = new System.Drawing.Point(2, 285);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 20);
            this.label20.TabIndex = 22;
            this.label20.Text = "Tag list:";
            // 
            // lxLed_toltime
            // 
            this.lxLed_toltime.BackColor = System.Drawing.Color.Transparent;
            this.lxLed_toltime.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLed_toltime.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLed_toltime.BevelRate = 0.5F;
            this.lxLed_toltime.BorderColor = System.Drawing.Color.Lavender;
            this.lxLed_toltime.BorderWidth = 3;
            this.lxLed_toltime.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLed_toltime.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLed_toltime.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lxLed_toltime.HighlightOpaque = ((byte)(50));
            this.lxLed_toltime.Location = new System.Drawing.Point(1124, 220);
            this.lxLed_toltime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lxLed_toltime.Name = "lxLed_toltime";
            this.lxLed_toltime.RoundCorner = true;
            this.lxLed_toltime.ShowHighlight = true;
            this.lxLed_toltime.Size = new System.Drawing.Size(243, 50);
            this.lxLed_toltime.TabIndex = 32;
            this.lxLed_toltime.Text = "0";
            this.lxLed_toltime.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLed_toltime.TotalCharCount = 10;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Column5,
            this.Column6});
            this.dataGridView2.Location = new System.Drawing.Point(2, 313);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1586, 370);
            this.dataGridView2.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "No.";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "EPC";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 380;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "First read time";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Last read time";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ant";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Times";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 150;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label19.Location = new System.Drawing.Point(1120, 188);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(117, 20);
            this.label19.TabIndex = 31;
            this.label19.Text = "Total Time(ms):";
            // 
            // lxLed_toltag
            // 
            this.lxLed_toltag.BackColor = System.Drawing.Color.Transparent;
            this.lxLed_toltag.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLed_toltag.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLed_toltag.BevelRate = 0.5F;
            this.lxLed_toltag.BorderColor = System.Drawing.Color.Lavender;
            this.lxLed_toltag.BorderWidth = 3;
            this.lxLed_toltag.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLed_toltag.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLed_toltag.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lxLed_toltag.HighlightOpaque = ((byte)(50));
            this.lxLed_toltag.Location = new System.Drawing.Point(1124, 98);
            this.lxLed_toltag.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lxLed_toltag.Name = "lxLed_toltag";
            this.lxLed_toltag.RoundCorner = true;
            this.lxLed_toltag.ShowHighlight = true;
            this.lxLed_toltag.Size = new System.Drawing.Size(243, 50);
            this.lxLed_toltag.TabIndex = 30;
            this.lxLed_toltag.Text = "0";
            this.lxLed_toltag.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLed_toltag.TotalCharCount = 10;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label18.Location = new System.Drawing.Point(1120, 68);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(108, 20);
            this.label18.TabIndex = 29;
            this.label18.Text = "Total Number:";
            // 
            // lxLed_cmdsud
            // 
            this.lxLed_cmdsud.BackColor = System.Drawing.Color.Transparent;
            this.lxLed_cmdsud.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLed_cmdsud.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLed_cmdsud.BevelRate = 0.5F;
            this.lxLed_cmdsud.BorderColor = System.Drawing.Color.Lavender;
            this.lxLed_cmdsud.BorderWidth = 3;
            this.lxLed_cmdsud.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLed_cmdsud.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLed_cmdsud.ForeColor = System.Drawing.Color.Purple;
            this.lxLed_cmdsud.HighlightOpaque = ((byte)(50));
            this.lxLed_cmdsud.Location = new System.Drawing.Point(732, 133);
            this.lxLed_cmdsud.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lxLed_cmdsud.Name = "lxLed_cmdsud";
            this.lxLed_cmdsud.RoundCorner = true;
            this.lxLed_cmdsud.ShowHighlight = true;
            this.lxLed_cmdsud.Size = new System.Drawing.Size(256, 137);
            this.lxLed_cmdsud.TabIndex = 26;
            this.lxLed_cmdsud.Text = "0";
            this.lxLed_cmdsud.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLed_cmdsud.TotalCharCount = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label17.Location = new System.Drawing.Point(735, 98);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 20);
            this.label17.TabIndex = 25;
            this.label17.Text = "Speed:";
            // 
            // lxLed_Num
            // 
            this.lxLed_Num.BackColor = System.Drawing.Color.Transparent;
            this.lxLed_Num.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLed_Num.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLed_Num.BevelRate = 0.5F;
            this.lxLed_Num.BorderColor = System.Drawing.Color.Lavender;
            this.lxLed_Num.BorderWidth = 3;
            this.lxLed_Num.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLed_Num.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLed_Num.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lxLed_Num.HighlightOpaque = ((byte)(50));
            this.lxLed_Num.Location = new System.Drawing.Point(152, 58);
            this.lxLed_Num.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lxLed_Num.Name = "lxLed_Num";
            this.lxLed_Num.RoundCorner = true;
            this.lxLed_Num.ShowHighlight = true;
            this.lxLed_Num.Size = new System.Drawing.Size(494, 212);
            this.lxLed_Num.TabIndex = 22;
            this.lxLed_Num.Text = "0";
            this.lxLed_Num.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(148, 27);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 20);
            this.label13.TabIndex = 21;
            this.label13.Text = "Tag Number:";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btClearBuffer);
            this.groupBox8.Location = new System.Drawing.Point(1054, 15);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox8.Size = new System.Drawing.Size(536, 110);
            this.groupBox8.TabIndex = 18;
            this.groupBox8.TabStop = false;
            // 
            // btClearBuffer
            // 
            this.btClearBuffer.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btClearBuffer.ForeColor = System.Drawing.Color.DarkBlue;
            this.btClearBuffer.Location = new System.Drawing.Point(32, 27);
            this.btClearBuffer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btClearBuffer.Name = "btClearBuffer";
            this.btClearBuffer.Size = new System.Drawing.Size(444, 67);
            this.btClearBuffer.TabIndex = 0;
            this.btClearBuffer.Text = "Clear data";
            this.btClearBuffer.UseVisualStyleBackColor = true;
            this.btClearBuffer.Click += new System.EventHandler(this.btClearBuffer_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btGettagbuffer);
            this.groupBox7.Location = new System.Drawing.Point(528, 15);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox7.Size = new System.Drawing.Size(528, 110);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            // 
            // btGettagbuffer
            // 
            this.btGettagbuffer.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btGettagbuffer.ForeColor = System.Drawing.Color.DarkBlue;
            this.btGettagbuffer.Location = new System.Drawing.Point(40, 27);
            this.btGettagbuffer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btGettagbuffer.Name = "btGettagbuffer";
            this.btGettagbuffer.Size = new System.Drawing.Size(444, 67);
            this.btGettagbuffer.TabIndex = 0;
            this.btGettagbuffer.Text = "Read Command notify data";
            this.btGettagbuffer.UseVisualStyleBackColor = true;
            this.btGettagbuffer.Click += new System.EventHandler(this.btGettagbuffer_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btGetrunmodedata);
            this.groupBox6.Location = new System.Drawing.Point(8, 15);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Size = new System.Drawing.Size(522, 110);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            // 
            // btGetrunmodedata
            // 
            this.btGetrunmodedata.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btGetrunmodedata.ForeColor = System.Drawing.Color.DarkBlue;
            this.btGetrunmodedata.Location = new System.Drawing.Point(32, 27);
            this.btGetrunmodedata.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btGetrunmodedata.Name = "btGetrunmodedata";
            this.btGetrunmodedata.Size = new System.Drawing.Size(444, 67);
            this.btGetrunmodedata.TabIndex = 0;
            this.btGetrunmodedata.Text = "Start";
            this.btGetrunmodedata.UseVisualStyleBackColor = true;
            this.btGetrunmodedata.Click += new System.EventHandler(this.btGetrunmodedata_Click);
            // 
            // tabPage_Realtime
            // 
            this.tabPage_Realtime.Controls.Add(this.panel10);
            this.tabPage_Realtime.Location = new System.Drawing.Point(4, 4);
            this.tabPage_Realtime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage_Realtime.Name = "tabPage_Realtime";
            this.tabPage_Realtime.Size = new System.Drawing.Size(1598, 866);
            this.tabPage_Realtime.TabIndex = 4;
            this.tabPage_Realtime.Text = "Real-time-inventory";
            this.tabPage_Realtime.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.dataGridView4);
            this.panel10.Controls.Add(this.groupBox41);
            this.panel10.Controls.Add(this.groupBox42);
            this.panel10.Location = new System.Drawing.Point(2, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1594, 840);
            this.panel10.TabIndex = 0;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AllowUserToResizeColumns = false;
            this.dataGridView4.AllowUserToResizeRows = false;
            this.dataGridView4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.Column1,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.dataGridView4.Location = new System.Drawing.Point(537, 10);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView4.MultiSelect = false;
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.RowHeadersWidth = 62;
            this.dataGridView4.RowTemplate.Height = 23;
            this.dataGridView4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(1053, 828);
            this.dataGridView4.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "No.";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn10.Width = 80;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "EPC";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn11.Width = 310;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Length";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "ANT";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn14.Width = 150;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "RSSI";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn15.Width = 150;
            // 
            // groupBox41
            // 
            this.groupBox41.Controls.Add(this.lxLed_Mtime);
            this.groupBox41.Controls.Add(this.label113);
            this.groupBox41.Controls.Add(this.lxLed_Mtag);
            this.groupBox41.Controls.Add(this.label116);
            this.groupBox41.Location = new System.Drawing.Point(4, 122);
            this.groupBox41.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox41.Name = "groupBox41";
            this.groupBox41.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox41.Size = new System.Drawing.Size(524, 373);
            this.groupBox41.TabIndex = 25;
            this.groupBox41.TabStop = false;
            this.groupBox41.Text = "Data";
            // 
            // lxLed_Mtime
            // 
            this.lxLed_Mtime.BackColor = System.Drawing.Color.Transparent;
            this.lxLed_Mtime.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLed_Mtime.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLed_Mtime.BevelRate = 0.5F;
            this.lxLed_Mtime.BorderColor = System.Drawing.Color.Lavender;
            this.lxLed_Mtime.BorderWidth = 3;
            this.lxLed_Mtime.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLed_Mtime.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLed_Mtime.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lxLed_Mtime.HighlightOpaque = ((byte)(50));
            this.lxLed_Mtime.Location = new System.Drawing.Point(33, 270);
            this.lxLed_Mtime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lxLed_Mtime.Name = "lxLed_Mtime";
            this.lxLed_Mtime.RoundCorner = true;
            this.lxLed_Mtime.ShowHighlight = true;
            this.lxLed_Mtime.Size = new System.Drawing.Size(262, 77);
            this.lxLed_Mtime.TabIndex = 32;
            this.lxLed_Mtime.Text = "0";
            this.lxLed_Mtime.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLed_Mtime.TotalCharCount = 7;
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label113.Location = new System.Drawing.Point(30, 225);
            this.label113.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(117, 20);
            this.label113.TabIndex = 31;
            this.label113.Text = "Total Time(ms):";
            // 
            // lxLed_Mtag
            // 
            this.lxLed_Mtag.BackColor = System.Drawing.Color.Transparent;
            this.lxLed_Mtag.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLed_Mtag.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLed_Mtag.BevelRate = 0.5F;
            this.lxLed_Mtag.BorderColor = System.Drawing.Color.Lavender;
            this.lxLed_Mtag.BorderWidth = 3;
            this.lxLed_Mtag.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLed_Mtag.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLed_Mtag.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lxLed_Mtag.HighlightOpaque = ((byte)(50));
            this.lxLed_Mtag.Location = new System.Drawing.Point(33, 115);
            this.lxLed_Mtag.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lxLed_Mtag.Name = "lxLed_Mtag";
            this.lxLed_Mtag.RoundCorner = true;
            this.lxLed_Mtag.ShowHighlight = true;
            this.lxLed_Mtag.Size = new System.Drawing.Size(262, 77);
            this.lxLed_Mtag.TabIndex = 22;
            this.lxLed_Mtag.Text = "0";
            this.lxLed_Mtag.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLed_Mtag.TotalCharCount = 7;
            // 
            // label116
            // 
            this.label116.AutoSize = true;
            this.label116.Location = new System.Drawing.Point(32, 68);
            this.label116.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(100, 20);
            this.label116.TabIndex = 21;
            this.label116.Text = "Tag Number:";
            // 
            // groupBox42
            // 
            this.groupBox42.Controls.Add(this.btStartMactive);
            this.groupBox42.Location = new System.Drawing.Point(6, 0);
            this.groupBox42.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox42.Name = "groupBox42";
            this.groupBox42.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox42.Size = new System.Drawing.Size(522, 110);
            this.groupBox42.TabIndex = 24;
            this.groupBox42.TabStop = false;
            // 
            // btStartMactive
            // 
            this.btStartMactive.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btStartMactive.ForeColor = System.Drawing.Color.DarkBlue;
            this.btStartMactive.Location = new System.Drawing.Point(32, 27);
            this.btStartMactive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btStartMactive.Name = "btStartMactive";
            this.btStartMactive.Size = new System.Drawing.Size(444, 67);
            this.btStartMactive.TabIndex = 0;
            this.btStartMactive.Text = "Start";
            this.btStartMactive.UseVisualStyleBackColor = true;
            this.btStartMactive.Click += new System.EventHandler(this.btStartMactive_Click);
            // 
            // tabPage_Buff
            // 
            this.tabPage_Buff.Controls.Add(this.panel8);
            this.tabPage_Buff.Location = new System.Drawing.Point(4, 4);
            this.tabPage_Buff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage_Buff.Name = "tabPage_Buff";
            this.tabPage_Buff.Size = new System.Drawing.Size(1598, 866);
            this.tabPage_Buff.TabIndex = 3;
            this.tabPage_Buff.Text = "Buffer operation";
            this.tabPage_Buff.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.groupBox27);
            this.panel8.Controls.Add(this.group_ant2);
            this.panel8.Controls.Add(this.groupBox29);
            this.panel8.Controls.Add(this.dataGridView3);
            this.panel8.Controls.Add(this.groupBox30);
            this.panel8.Location = new System.Drawing.Point(-3, 2);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1600, 838);
            this.panel8.TabIndex = 1;
            // 
            // groupBox27
            // 
            this.groupBox27.Controls.Add(this.btQueryBuffNum);
            this.groupBox27.Controls.Add(this.btRandCbuff);
            this.groupBox27.Controls.Add(this.btClearBuff);
            this.groupBox27.Controls.Add(this.btReadBuff);
            this.groupBox27.Location = new System.Drawing.Point(1032, 8);
            this.groupBox27.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox27.Name = "groupBox27";
            this.groupBox27.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox27.Size = new System.Drawing.Size(555, 118);
            this.groupBox27.TabIndex = 25;
            this.groupBox27.TabStop = false;
            // 
            // btQueryBuffNum
            // 
            this.btQueryBuffNum.ForeColor = System.Drawing.Color.Blue;
            this.btQueryBuffNum.Location = new System.Drawing.Point(291, 70);
            this.btQueryBuffNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btQueryBuffNum.Name = "btQueryBuffNum";
            this.btQueryBuffNum.Size = new System.Drawing.Size(226, 38);
            this.btQueryBuffNum.TabIndex = 3;
            this.btQueryBuffNum.Text = "Get buffer tag number";
            this.btQueryBuffNum.UseVisualStyleBackColor = true;
            this.btQueryBuffNum.Click += new System.EventHandler(this.btQueryBuffNum_Click);
            // 
            // btRandCbuff
            // 
            this.btRandCbuff.ForeColor = System.Drawing.Color.Blue;
            this.btRandCbuff.Location = new System.Drawing.Point(291, 22);
            this.btRandCbuff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRandCbuff.Name = "btRandCbuff";
            this.btRandCbuff.Size = new System.Drawing.Size(226, 38);
            this.btRandCbuff.TabIndex = 2;
            this.btRandCbuff.Text = "Read and Clear Buffer";
            this.btRandCbuff.UseVisualStyleBackColor = true;
            this.btRandCbuff.Click += new System.EventHandler(this.btRandCbuff_Click);
            // 
            // btClearBuff
            // 
            this.btClearBuff.ForeColor = System.Drawing.Color.Blue;
            this.btClearBuff.Location = new System.Drawing.Point(46, 70);
            this.btClearBuff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btClearBuff.Name = "btClearBuff";
            this.btClearBuff.Size = new System.Drawing.Size(226, 38);
            this.btClearBuff.TabIndex = 1;
            this.btClearBuff.Text = "Clear Buffer";
            this.btClearBuff.UseVisualStyleBackColor = true;
            this.btClearBuff.Click += new System.EventHandler(this.btClearBuff_Click);
            // 
            // btReadBuff
            // 
            this.btReadBuff.ForeColor = System.Drawing.Color.Blue;
            this.btReadBuff.Location = new System.Drawing.Point(46, 22);
            this.btReadBuff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btReadBuff.Name = "btReadBuff";
            this.btReadBuff.Size = new System.Drawing.Size(226, 38);
            this.btReadBuff.TabIndex = 0;
            this.btReadBuff.Text = "Read Buffer";
            this.btReadBuff.UseVisualStyleBackColor = true;
            this.btReadBuff.Click += new System.EventHandler(this.btReadBuff_Click);
            // 
            // group_ant2
            // 
            this.group_ant2.Controls.Add(this.BAnt4);
            this.group_ant2.Controls.Add(this.BAnt3);
            this.group_ant2.Controls.Add(this.BAnt2);
            this.group_ant2.Controls.Add(this.BAnt1);
            this.group_ant2.Location = new System.Drawing.Point(472, 8);
            this.group_ant2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.group_ant2.Name = "group_ant2";
            this.group_ant2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.group_ant2.Size = new System.Drawing.Size(560, 118);
            this.group_ant2.TabIndex = 24;
            this.group_ant2.TabStop = false;
            // 
            // BAnt4
            // 
            this.BAnt4.AutoSize = true;
            this.BAnt4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BAnt4.Location = new System.Drawing.Point(430, 50);
            this.BAnt4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BAnt4.Name = "BAnt4";
            this.BAnt4.Size = new System.Drawing.Size(75, 24);
            this.BAnt4.TabIndex = 37;
            this.BAnt4.Text = "ANT4";
            this.BAnt4.UseVisualStyleBackColor = true;
            // 
            // BAnt3
            // 
            this.BAnt3.AutoSize = true;
            this.BAnt3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BAnt3.Location = new System.Drawing.Point(290, 50);
            this.BAnt3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BAnt3.Name = "BAnt3";
            this.BAnt3.Size = new System.Drawing.Size(75, 24);
            this.BAnt3.TabIndex = 36;
            this.BAnt3.Text = "ANT3";
            this.BAnt3.UseVisualStyleBackColor = true;
            // 
            // BAnt2
            // 
            this.BAnt2.AutoSize = true;
            this.BAnt2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BAnt2.Location = new System.Drawing.Point(153, 50);
            this.BAnt2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BAnt2.Name = "BAnt2";
            this.BAnt2.Size = new System.Drawing.Size(75, 24);
            this.BAnt2.TabIndex = 35;
            this.BAnt2.Text = "ANT2";
            this.BAnt2.UseVisualStyleBackColor = true;
            // 
            // BAnt1
            // 
            this.BAnt1.AutoSize = true;
            this.BAnt1.Checked = true;
            this.BAnt1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BAnt1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BAnt1.Location = new System.Drawing.Point(30, 50);
            this.BAnt1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BAnt1.Name = "BAnt1";
            this.BAnt1.Size = new System.Drawing.Size(75, 24);
            this.BAnt1.TabIndex = 34;
            this.BAnt1.Text = "ANT1";
            this.BAnt1.UseVisualStyleBackColor = true;
            // 
            // groupBox29
            // 
            this.groupBox29.Controls.Add(this.rb_btid);
            this.groupBox29.Controls.Add(this.rb_bepc);
            this.groupBox29.Controls.Add(this.btStartBuff);
            this.groupBox29.Location = new System.Drawing.Point(12, 8);
            this.groupBox29.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox29.Name = "groupBox29";
            this.groupBox29.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox29.Size = new System.Drawing.Size(460, 118);
            this.groupBox29.TabIndex = 23;
            this.groupBox29.TabStop = false;
            // 
            // rb_btid
            // 
            this.rb_btid.AutoSize = true;
            this.rb_btid.Location = new System.Drawing.Point(321, 70);
            this.rb_btid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_btid.Name = "rb_btid";
            this.rb_btid.Size = new System.Drawing.Size(60, 24);
            this.rb_btid.TabIndex = 2;
            this.rb_btid.Text = "TID";
            this.rb_btid.UseVisualStyleBackColor = true;
            // 
            // rb_bepc
            // 
            this.rb_bepc.AutoSize = true;
            this.rb_bepc.Checked = true;
            this.rb_bepc.Location = new System.Drawing.Point(321, 33);
            this.rb_bepc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_bepc.Name = "rb_bepc";
            this.rb_bepc.Size = new System.Drawing.Size(66, 24);
            this.rb_bepc.TabIndex = 1;
            this.rb_bepc.TabStop = true;
            this.rb_bepc.Text = "EPC";
            this.rb_bepc.UseVisualStyleBackColor = true;
            // 
            // btStartBuff
            // 
            this.btStartBuff.BackColor = System.Drawing.Color.Transparent;
            this.btStartBuff.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btStartBuff.ForeColor = System.Drawing.Color.DarkBlue;
            this.btStartBuff.Location = new System.Drawing.Point(27, 33);
            this.btStartBuff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btStartBuff.Name = "btStartBuff";
            this.btStartBuff.Size = new System.Drawing.Size(256, 67);
            this.btStartBuff.TabIndex = 0;
            this.btStartBuff.Text = "Start";
            this.btStartBuff.UseVisualStyleBackColor = false;
            this.btStartBuff.Click += new System.EventHandler(this.btStartBuff_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.Column7});
            this.dataGridView3.Location = new System.Drawing.Point(4, 460);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(1586, 375);
            this.dataGridView3.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "No.";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "EPC";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn6.Width = 520;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Length";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "ANT";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "RSSI";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Times";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // groupBox30
            // 
            this.groupBox30.Controls.Add(this.lxLed_cmdTime);
            this.groupBox30.Controls.Add(this.label86);
            this.groupBox30.Controls.Add(this.lxLed_Btoltime);
            this.groupBox30.Controls.Add(this.label83);
            this.groupBox30.Controls.Add(this.label91);
            this.groupBox30.Controls.Add(this.lxLed_Btoltag);
            this.groupBox30.Controls.Add(this.label92);
            this.groupBox30.Controls.Add(this.lxLed_Bcmdsud);
            this.groupBox30.Controls.Add(this.label94);
            this.groupBox30.Controls.Add(this.lxLed_BNum);
            this.groupBox30.Controls.Add(this.label95);
            this.groupBox30.Location = new System.Drawing.Point(10, 135);
            this.groupBox30.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox30.Name = "groupBox30";
            this.groupBox30.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox30.Size = new System.Drawing.Size(1580, 698);
            this.groupBox30.TabIndex = 20;
            this.groupBox30.TabStop = false;
            // 
            // lxLed_cmdTime
            // 
            this.lxLed_cmdTime.BackColor = System.Drawing.Color.Transparent;
            this.lxLed_cmdTime.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLed_cmdTime.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLed_cmdTime.BevelRate = 0.5F;
            this.lxLed_cmdTime.BorderColor = System.Drawing.Color.Lavender;
            this.lxLed_cmdTime.BorderWidth = 3;
            this.lxLed_cmdTime.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLed_cmdTime.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLed_cmdTime.ForeColor = System.Drawing.Color.Purple;
            this.lxLed_cmdTime.HighlightOpaque = ((byte)(50));
            this.lxLed_cmdTime.Location = new System.Drawing.Point(738, 215);
            this.lxLed_cmdTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lxLed_cmdTime.Name = "lxLed_cmdTime";
            this.lxLed_cmdTime.RoundCorner = true;
            this.lxLed_cmdTime.ShowHighlight = true;
            this.lxLed_cmdTime.Size = new System.Drawing.Size(219, 63);
            this.lxLed_cmdTime.TabIndex = 34;
            this.lxLed_cmdTime.Text = "0";
            this.lxLed_cmdTime.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLed_cmdTime.TotalCharCount = 7;
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.ForeColor = System.Drawing.Color.Teal;
            this.label86.Location = new System.Drawing.Point(735, 190);
            this.label86.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(108, 20);
            this.label86.TabIndex = 33;
            this.label86.Text = "cmd time(ms):";
            // 
            // lxLed_Btoltime
            // 
            this.lxLed_Btoltime.BackColor = System.Drawing.Color.Transparent;
            this.lxLed_Btoltime.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLed_Btoltime.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLed_Btoltime.BevelRate = 0.5F;
            this.lxLed_Btoltime.BorderColor = System.Drawing.Color.Lavender;
            this.lxLed_Btoltime.BorderWidth = 3;
            this.lxLed_Btoltime.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLed_Btoltime.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLed_Btoltime.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lxLed_Btoltime.HighlightOpaque = ((byte)(50));
            this.lxLed_Btoltime.Location = new System.Drawing.Point(1124, 228);
            this.lxLed_Btoltime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lxLed_Btoltime.Name = "lxLed_Btoltime";
            this.lxLed_Btoltime.RoundCorner = true;
            this.lxLed_Btoltime.ShowHighlight = true;
            this.lxLed_Btoltime.Size = new System.Drawing.Size(243, 50);
            this.lxLed_Btoltime.TabIndex = 32;
            this.lxLed_Btoltime.Text = "0";
            this.lxLed_Btoltime.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLed_Btoltime.TotalCharCount = 10;
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label83.Location = new System.Drawing.Point(8, 298);
            this.label83.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(69, 20);
            this.label83.TabIndex = 22;
            this.label83.Text = "Tag List:";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.ForeColor = System.Drawing.Color.Teal;
            this.label91.Location = new System.Drawing.Point(1120, 195);
            this.label91.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(113, 20);
            this.label91.TabIndex = 31;
            this.label91.Text = "Total time(ms):";
            // 
            // lxLed_Btoltag
            // 
            this.lxLed_Btoltag.BackColor = System.Drawing.Color.Transparent;
            this.lxLed_Btoltag.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLed_Btoltag.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLed_Btoltag.BevelRate = 0.5F;
            this.lxLed_Btoltag.BorderColor = System.Drawing.Color.Lavender;
            this.lxLed_Btoltag.BorderWidth = 3;
            this.lxLed_Btoltag.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLed_Btoltag.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLed_Btoltag.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lxLed_Btoltag.HighlightOpaque = ((byte)(50));
            this.lxLed_Btoltag.Location = new System.Drawing.Point(1124, 113);
            this.lxLed_Btoltag.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lxLed_Btoltag.Name = "lxLed_Btoltag";
            this.lxLed_Btoltag.RoundCorner = true;
            this.lxLed_Btoltag.ShowHighlight = true;
            this.lxLed_Btoltag.Size = new System.Drawing.Size(243, 50);
            this.lxLed_Btoltag.TabIndex = 30;
            this.lxLed_Btoltag.Text = "0";
            this.lxLed_Btoltag.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLed_Btoltag.TotalCharCount = 10;
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.ForeColor = System.Drawing.Color.Teal;
            this.label92.Location = new System.Drawing.Point(1120, 83);
            this.label92.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(106, 20);
            this.label92.TabIndex = 29;
            this.label92.Text = "Total number:";
            // 
            // lxLed_Bcmdsud
            // 
            this.lxLed_Bcmdsud.BackColor = System.Drawing.Color.Transparent;
            this.lxLed_Bcmdsud.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLed_Bcmdsud.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLed_Bcmdsud.BevelRate = 0.5F;
            this.lxLed_Bcmdsud.BorderColor = System.Drawing.Color.Lavender;
            this.lxLed_Bcmdsud.BorderWidth = 3;
            this.lxLed_Bcmdsud.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLed_Bcmdsud.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLed_Bcmdsud.ForeColor = System.Drawing.Color.Purple;
            this.lxLed_Bcmdsud.HighlightOpaque = ((byte)(50));
            this.lxLed_Bcmdsud.Location = new System.Drawing.Point(738, 100);
            this.lxLed_Bcmdsud.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lxLed_Bcmdsud.Name = "lxLed_Bcmdsud";
            this.lxLed_Bcmdsud.RoundCorner = true;
            this.lxLed_Bcmdsud.ShowHighlight = true;
            this.lxLed_Bcmdsud.Size = new System.Drawing.Size(219, 63);
            this.lxLed_Bcmdsud.TabIndex = 26;
            this.lxLed_Bcmdsud.Text = "0";
            this.lxLed_Bcmdsud.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            this.lxLed_Bcmdsud.TotalCharCount = 7;
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.ForeColor = System.Drawing.Color.Teal;
            this.label94.Location = new System.Drawing.Point(735, 68);
            this.label94.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(60, 20);
            this.label94.TabIndex = 25;
            this.label94.Text = "Speed:";
            // 
            // lxLed_BNum
            // 
            this.lxLed_BNum.BackColor = System.Drawing.Color.Transparent;
            this.lxLed_BNum.BackColor_1 = System.Drawing.Color.Transparent;
            this.lxLed_BNum.BackColor_2 = System.Drawing.Color.DarkRed;
            this.lxLed_BNum.BevelRate = 0.5F;
            this.lxLed_BNum.BorderColor = System.Drawing.Color.Lavender;
            this.lxLed_BNum.BorderWidth = 3;
            this.lxLed_BNum.FadedColor = System.Drawing.SystemColors.ControlLight;
            this.lxLed_BNum.FocusedBorderColor = System.Drawing.Color.LightCoral;
            this.lxLed_BNum.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lxLed_BNum.HighlightOpaque = ((byte)(50));
            this.lxLed_BNum.Location = new System.Drawing.Point(152, 67);
            this.lxLed_BNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lxLed_BNum.Name = "lxLed_BNum";
            this.lxLed_BNum.RoundCorner = true;
            this.lxLed_BNum.ShowHighlight = true;
            this.lxLed_BNum.Size = new System.Drawing.Size(494, 212);
            this.lxLed_BNum.TabIndex = 22;
            this.lxLed_BNum.Text = "0";
            this.lxLed_BNum.TextAlignment = LxControl.LxLedControl.Alignment.Right;
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Location = new System.Drawing.Point(148, 37);
            this.label95.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(100, 20);
            this.label95.TabIndex = 21;
            this.label95.Text = "Tag Number:";
            // 
            // tabPage_RW
            // 
            this.tabPage_RW.Controls.Add(this.panel4);
            this.tabPage_RW.Location = new System.Drawing.Point(4, 4);
            this.tabPage_RW.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage_RW.Name = "tabPage_RW";
            this.tabPage_RW.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage_RW.Size = new System.Drawing.Size(1598, 866);
            this.tabPage_RW.TabIndex = 2;
            this.tabPage_RW.Text = "Read/Write Tag";
            this.tabPage_RW.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox21);
            this.panel4.Controls.Add(this.groupBox20);
            this.panel4.Controls.Add(this.groupBox18);
            this.panel4.Controls.Add(this.groupBox16);
            this.panel4.Controls.Add(this.groupBox13);
            this.panel4.Controls.Add(this.groupBox11);
            this.panel4.Controls.Add(this.groupBox31);
            this.panel4.Controls.Add(this.groupBox10);
            this.panel4.Location = new System.Drawing.Point(-3, -5);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1600, 937);
            this.panel4.TabIndex = 0;
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.btCheckReadProtected_G2);
            this.groupBox21.Controls.Add(this.btRemoveReadProtect_G2);
            this.groupBox21.Controls.Add(this.btSetMultiReadProtect_G2);
            this.groupBox21.Controls.Add(this.btSetReadProtect_G2);
            this.groupBox21.Controls.Add(this.text_AccessCode4);
            this.groupBox21.Controls.Add(this.label34);
            this.groupBox21.Location = new System.Drawing.Point(519, 602);
            this.groupBox21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox21.Size = new System.Drawing.Size(465, 243);
            this.groupBox21.TabIndex = 23;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Read Protection";
            // 
            // btCheckReadProtected_G2
            // 
            this.btCheckReadProtected_G2.Location = new System.Drawing.Point(18, 198);
            this.btCheckReadProtected_G2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCheckReadProtected_G2.Name = "btCheckReadProtected_G2";
            this.btCheckReadProtected_G2.Size = new System.Drawing.Size(428, 38);
            this.btCheckReadProtected_G2.TabIndex = 6;
            this.btCheckReadProtected_G2.Text = "Detect Privacy   ";
            this.btCheckReadProtected_G2.UseVisualStyleBackColor = true;
            this.btCheckReadProtected_G2.Click += new System.EventHandler(this.btCheckReadProtected_G2_Click);
            // 
            // btRemoveReadProtect_G2
            // 
            this.btRemoveReadProtect_G2.Location = new System.Drawing.Point(18, 157);
            this.btRemoveReadProtect_G2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRemoveReadProtect_G2.Name = "btRemoveReadProtect_G2";
            this.btRemoveReadProtect_G2.Size = new System.Drawing.Size(428, 38);
            this.btRemoveReadProtect_G2.TabIndex = 5;
            this.btRemoveReadProtect_G2.Text = "Reset Privacy";
            this.btRemoveReadProtect_G2.UseVisualStyleBackColor = true;
            this.btRemoveReadProtect_G2.Click += new System.EventHandler(this.btRemoveReadProtect_G2_Click);
            // 
            // btSetMultiReadProtect_G2
            // 
            this.btSetMultiReadProtect_G2.Location = new System.Drawing.Point(18, 113);
            this.btSetMultiReadProtect_G2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSetMultiReadProtect_G2.Name = "btSetMultiReadProtect_G2";
            this.btSetMultiReadProtect_G2.Size = new System.Drawing.Size(428, 38);
            this.btSetMultiReadProtect_G2.TabIndex = 4;
            this.btSetMultiReadProtect_G2.Text = "Set Privacy Without EPC";
            this.btSetMultiReadProtect_G2.UseVisualStyleBackColor = true;
            this.btSetMultiReadProtect_G2.Click += new System.EventHandler(this.btSetMultiReadProtect_G2_Click);
            // 
            // btSetReadProtect_G2
            // 
            this.btSetReadProtect_G2.Location = new System.Drawing.Point(18, 68);
            this.btSetReadProtect_G2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSetReadProtect_G2.Name = "btSetReadProtect_G2";
            this.btSetReadProtect_G2.Size = new System.Drawing.Size(428, 38);
            this.btSetReadProtect_G2.TabIndex = 3;
            this.btSetReadProtect_G2.Text = "Set Privacy By EPC";
            this.btSetReadProtect_G2.UseVisualStyleBackColor = true;
            this.btSetReadProtect_G2.Click += new System.EventHandler(this.btSetReadProtect_G2_Click);
            // 
            // text_AccessCode4
            // 
            this.text_AccessCode4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_AccessCode4.Location = new System.Drawing.Point(294, 23);
            this.text_AccessCode4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_AccessCode4.MaxLength = 8;
            this.text_AccessCode4.Name = "text_AccessCode4";
            this.text_AccessCode4.Size = new System.Drawing.Size(148, 26);
            this.text_AccessCode4.TabIndex = 2;
            this.text_AccessCode4.Text = "00000000";
            this.text_AccessCode4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(22, 33);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(120, 20);
            this.label34.TabIndex = 1;
            this.label34.Text = "Password:(Hex)";
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.btWriteEPC_G2);
            this.groupBox20.Controls.Add(this.text_AccessCode3);
            this.groupBox20.Controls.Add(this.label27);
            this.groupBox20.Controls.Add(this.text_WriteEPC);
            this.groupBox20.Controls.Add(this.label33);
            this.groupBox20.Location = new System.Drawing.Point(12, 712);
            this.groupBox20.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox20.Size = new System.Drawing.Size(498, 132);
            this.groupBox20.TabIndex = 22;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Write EPC";
            // 
            // btWriteEPC_G2
            // 
            this.btWriteEPC_G2.Location = new System.Drawing.Point(344, 73);
            this.btWriteEPC_G2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btWriteEPC_G2.Name = "btWriteEPC_G2";
            this.btWriteEPC_G2.Size = new System.Drawing.Size(135, 38);
            this.btWriteEPC_G2.TabIndex = 4;
            this.btWriteEPC_G2.Text = "Write EPC";
            this.btWriteEPC_G2.UseVisualStyleBackColor = true;
            this.btWriteEPC_G2.Click += new System.EventHandler(this.btWriteEPC_G2_Click);
            // 
            // text_AccessCode3
            // 
            this.text_AccessCode3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_AccessCode3.Location = new System.Drawing.Point(232, 73);
            this.text_AccessCode3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_AccessCode3.MaxLength = 8;
            this.text_AccessCode3.Name = "text_AccessCode3";
            this.text_AccessCode3.Size = new System.Drawing.Size(84, 26);
            this.text_AccessCode3.TabIndex = 3;
            this.text_AccessCode3.Text = "00000000";
            this.text_AccessCode3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(8, 83);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(120, 20);
            this.label27.TabIndex = 2;
            this.label27.Text = "Password:(Hex)";
            // 
            // text_WriteEPC
            // 
            this.text_WriteEPC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_WriteEPC.Location = new System.Drawing.Point(116, 28);
            this.text_WriteEPC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_WriteEPC.MaxLength = 60;
            this.text_WriteEPC.Name = "text_WriteEPC";
            this.text_WriteEPC.Size = new System.Drawing.Size(361, 26);
            this.text_WriteEPC.TabIndex = 1;
            this.text_WriteEPC.Text = "0000";
            this.text_WriteEPC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(9, 35);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(61, 20);
            this.label33.TabIndex = 0;
            this.label33.Text = "EPC号:";
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.btDestroyCard);
            this.groupBox18.Controls.Add(this.text_DestroyCode);
            this.groupBox18.Controls.Add(this.label26);
            this.groupBox18.Location = new System.Drawing.Point(12, 602);
            this.groupBox18.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox18.Size = new System.Drawing.Size(498, 93);
            this.groupBox18.TabIndex = 20;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Kill Tag";
            // 
            // btDestroyCard
            // 
            this.btDestroyCard.Location = new System.Drawing.Point(344, 35);
            this.btDestroyCard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btDestroyCard.Name = "btDestroyCard";
            this.btDestroyCard.Size = new System.Drawing.Size(135, 38);
            this.btDestroyCard.TabIndex = 3;
            this.btDestroyCard.Text = "Kill tag";
            this.btDestroyCard.UseVisualStyleBackColor = true;
            this.btDestroyCard.Click += new System.EventHandler(this.btDestroyCard_Click);
            // 
            // text_DestroyCode
            // 
            this.text_DestroyCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_DestroyCode.Location = new System.Drawing.Point(232, 38);
            this.text_DestroyCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_DestroyCode.MaxLength = 8;
            this.text_DestroyCode.Name = "text_DestroyCode";
            this.text_DestroyCode.Size = new System.Drawing.Size(82, 26);
            this.text_DestroyCode.TabIndex = 2;
            this.text_DestroyCode.Text = "00000000";
            this.text_DestroyCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(9, 43);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(143, 20);
            this.label26.TabIndex = 1;
            this.label26.Text = "Kill Password:(Hex)";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.pictureBox2);
            this.groupBox16.Controls.Add(this.btCheckEASAlarm);
            this.groupBox16.Controls.Add(this.btSetEASAlarm_G2);
            this.groupBox16.Controls.Add(this.groupBox17);
            this.groupBox16.Controls.Add(this.text_AccessCode5);
            this.groupBox16.Controls.Add(this.label28);
            this.groupBox16.Location = new System.Drawing.Point(993, 398);
            this.groupBox16.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox16.Size = new System.Drawing.Size(596, 445);
            this.groupBox16.TabIndex = 19;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "EAS Alarm";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(94, 187);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(206, 228);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // btCheckEASAlarm
            // 
            this.btCheckEASAlarm.Location = new System.Drawing.Point(420, 130);
            this.btCheckEASAlarm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCheckEASAlarm.Name = "btCheckEASAlarm";
            this.btCheckEASAlarm.Size = new System.Drawing.Size(135, 38);
            this.btCheckEASAlarm.TabIndex = 13;
            this.btCheckEASAlarm.Text = "Detect";
            this.btCheckEASAlarm.UseVisualStyleBackColor = true;
            this.btCheckEASAlarm.Click += new System.EventHandler(this.btCheckEASAlarm_Click);
            // 
            // btSetEASAlarm_G2
            // 
            this.btSetEASAlarm_G2.Location = new System.Drawing.Point(420, 42);
            this.btSetEASAlarm_G2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSetEASAlarm_G2.Name = "btSetEASAlarm_G2";
            this.btSetEASAlarm_G2.Size = new System.Drawing.Size(135, 38);
            this.btSetEASAlarm_G2.TabIndex = 12;
            this.btSetEASAlarm_G2.Text = "Configure";
            this.btSetEASAlarm_G2.UseVisualStyleBackColor = true;
            this.btSetEASAlarm_G2.Click += new System.EventHandler(this.btSetEASAlarm_G2_Click);
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.NoAlarm_G2);
            this.groupBox17.Controls.Add(this.Alarm_G2);
            this.groupBox17.Location = new System.Drawing.Point(14, 78);
            this.groupBox17.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox17.Size = new System.Drawing.Size(374, 90);
            this.groupBox17.TabIndex = 11;
            this.groupBox17.TabStop = false;
            // 
            // NoAlarm_G2
            // 
            this.NoAlarm_G2.AutoSize = true;
            this.NoAlarm_G2.Location = new System.Drawing.Point(170, 33);
            this.NoAlarm_G2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NoAlarm_G2.Name = "NoAlarm_G2";
            this.NoAlarm_G2.Size = new System.Drawing.Size(99, 24);
            this.NoAlarm_G2.TabIndex = 1;
            this.NoAlarm_G2.Text = "No Alarm";
            this.NoAlarm_G2.UseVisualStyleBackColor = true;
            // 
            // Alarm_G2
            // 
            this.Alarm_G2.AutoSize = true;
            this.Alarm_G2.Checked = true;
            this.Alarm_G2.Location = new System.Drawing.Point(9, 33);
            this.Alarm_G2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Alarm_G2.Name = "Alarm_G2";
            this.Alarm_G2.Size = new System.Drawing.Size(75, 24);
            this.Alarm_G2.TabIndex = 0;
            this.Alarm_G2.TabStop = true;
            this.Alarm_G2.Text = "Alarm";
            this.Alarm_G2.UseVisualStyleBackColor = true;
            // 
            // text_AccessCode5
            // 
            this.text_AccessCode5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_AccessCode5.Location = new System.Drawing.Point(237, 37);
            this.text_AccessCode5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_AccessCode5.MaxLength = 8;
            this.text_AccessCode5.Name = "text_AccessCode5";
            this.text_AccessCode5.Size = new System.Drawing.Size(148, 26);
            this.text_AccessCode5.TabIndex = 10;
            this.text_AccessCode5.Text = "00000000";
            this.text_AccessCode5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(9, 43);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(116, 20);
            this.label28.TabIndex = 9;
            this.label28.Text = "Password(Hex)";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.btSetProtectState);
            this.groupBox13.Controls.Add(this.Edit_AccessCode6);
            this.groupBox13.Controls.Add(this.label25);
            this.groupBox13.Controls.Add(this.groupBox14);
            this.groupBox13.Controls.Add(this.groupBox15);
            this.groupBox13.Location = new System.Drawing.Point(8, 398);
            this.groupBox13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox13.Size = new System.Drawing.Size(976, 202);
            this.groupBox13.TabIndex = 18;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Set Protect For Reading Or Writing";
            // 
            // btSetProtectState
            // 
            this.btSetProtectState.Location = new System.Drawing.Point(826, 140);
            this.btSetProtectState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSetProtectState.Name = "btSetProtectState";
            this.btSetProtectState.Size = new System.Drawing.Size(135, 38);
            this.btSetProtectState.TabIndex = 6;
            this.btSetProtectState.Text = "Lock";
            this.btSetProtectState.UseVisualStyleBackColor = true;
            this.btSetProtectState.Click += new System.EventHandler(this.btSetProtectState_Click);
            // 
            // Edit_AccessCode6
            // 
            this.Edit_AccessCode6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Edit_AccessCode6.Location = new System.Drawing.Point(826, 73);
            this.Edit_AccessCode6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Edit_AccessCode6.MaxLength = 8;
            this.Edit_AccessCode6.Name = "Edit_AccessCode6";
            this.Edit_AccessCode6.Size = new System.Drawing.Size(133, 26);
            this.Edit_AccessCode6.TabIndex = 5;
            this.Edit_AccessCode6.Text = "00000000";
            this.Edit_AccessCode6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(754, 28);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(120, 20);
            this.label25.TabIndex = 4;
            this.label25.Text = "Password:(Hex)";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.AlwaysNot2);
            this.groupBox14.Controls.Add(this.Always2);
            this.groupBox14.Controls.Add(this.Proect2);
            this.groupBox14.Controls.Add(this.NoProect2);
            this.groupBox14.Location = new System.Drawing.Point(6, 113);
            this.groupBox14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox14.Size = new System.Drawing.Size(714, 73);
            this.groupBox14.TabIndex = 3;
            this.groupBox14.TabStop = false;
            // 
            // AlwaysNot2
            // 
            this.AlwaysNot2.AutoSize = true;
            this.AlwaysNot2.Location = new System.Drawing.Point(489, 30);
            this.AlwaysNot2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AlwaysNot2.Name = "AlwaysNot2";
            this.AlwaysNot2.Size = new System.Drawing.Size(121, 24);
            this.AlwaysNot2.TabIndex = 3;
            this.AlwaysNot2.Text = "Lock forever\n";
            this.AlwaysNot2.UseVisualStyleBackColor = true;
            // 
            // Always2
            // 
            this.Always2.AutoSize = true;
            this.Always2.Location = new System.Drawing.Point(273, 30);
            this.Always2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Always2.Name = "Always2";
            this.Always2.Size = new System.Drawing.Size(136, 24);
            this.Always2.TabIndex = 2;
            this.Always2.Text = "Unlock forever\n";
            this.Always2.UseVisualStyleBackColor = true;
            // 
            // Proect2
            // 
            this.Proect2.AutoSize = true;
            this.Proect2.Location = new System.Drawing.Point(147, 30);
            this.Proect2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Proect2.Name = "Proect2";
            this.Proect2.Size = new System.Drawing.Size(68, 24);
            this.Proect2.TabIndex = 1;
            this.Proect2.Text = "Lock";
            this.Proect2.UseVisualStyleBackColor = true;
            // 
            // NoProect2
            // 
            this.NoProect2.AutoSize = true;
            this.NoProect2.Checked = true;
            this.NoProect2.Location = new System.Drawing.Point(14, 30);
            this.NoProect2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NoProect2.Name = "NoProect2";
            this.NoProect2.Size = new System.Drawing.Size(89, 24);
            this.NoProect2.TabIndex = 0;
            this.NoProect2.TabStop = true;
            this.NoProect2.Text = "UnLock";
            this.NoProect2.UseVisualStyleBackColor = true;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.p_pass);
            this.groupBox15.Controls.Add(this.P_User);
            this.groupBox15.Controls.Add(this.P_TID);
            this.groupBox15.Controls.Add(this.P_EPC);
            this.groupBox15.Controls.Add(this.P_kill);
            this.groupBox15.Location = new System.Drawing.Point(6, 22);
            this.groupBox15.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox15.Size = new System.Drawing.Size(714, 87);
            this.groupBox15.TabIndex = 2;
            this.groupBox15.TabStop = false;
            // 
            // p_pass
            // 
            this.p_pass.AutoSize = true;
            this.p_pass.Checked = true;
            this.p_pass.Location = new System.Drawing.Point(189, 30);
            this.p_pass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.p_pass.Name = "p_pass";
            this.p_pass.Size = new System.Drawing.Size(159, 24);
            this.p_pass.TabIndex = 4;
            this.p_pass.TabStop = true;
            this.p_pass.Text = "Access Password";
            this.p_pass.UseVisualStyleBackColor = true;
            // 
            // P_User
            // 
            this.P_User.AutoSize = true;
            this.P_User.Location = new System.Drawing.Point(600, 30);
            this.P_User.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.P_User.Name = "P_User";
            this.P_User.Size = new System.Drawing.Size(68, 24);
            this.P_User.TabIndex = 3;
            this.P_User.Text = "User";
            this.P_User.UseVisualStyleBackColor = true;
            // 
            // P_TID
            // 
            this.P_TID.AutoSize = true;
            this.P_TID.Location = new System.Drawing.Point(506, 30);
            this.P_TID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.P_TID.Name = "P_TID";
            this.P_TID.Size = new System.Drawing.Size(60, 24);
            this.P_TID.TabIndex = 2;
            this.P_TID.Text = "TID";
            this.P_TID.UseVisualStyleBackColor = true;
            // 
            // P_EPC
            // 
            this.P_EPC.AutoSize = true;
            this.P_EPC.Location = new System.Drawing.Point(392, 30);
            this.P_EPC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.P_EPC.Name = "P_EPC";
            this.P_EPC.Size = new System.Drawing.Size(66, 24);
            this.P_EPC.TabIndex = 1;
            this.P_EPC.Text = "EPC";
            this.P_EPC.UseVisualStyleBackColor = true;
            // 
            // P_kill
            // 
            this.P_kill.AutoSize = true;
            this.P_kill.Location = new System.Drawing.Point(14, 30);
            this.P_kill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.P_kill.Name = "P_kill";
            this.P_kill.Size = new System.Drawing.Size(126, 24);
            this.P_kill.TabIndex = 0;
            this.P_kill.Text = "Kill Password";
            this.P_kill.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.btExtWrite);
            this.groupBox11.Controls.Add(this.btExtRead);
            this.groupBox11.Controls.Add(this.textBox_pc);
            this.groupBox11.Controls.Add(this.checkBox_pc);
            this.groupBox11.Controls.Add(this.btBlockWrite);
            this.groupBox11.Controls.Add(this.btBlockErase);
            this.groupBox11.Controls.Add(this.btWrite);
            this.groupBox11.Controls.Add(this.btRead);
            this.groupBox11.Controls.Add(this.text_WriteData);
            this.groupBox11.Controls.Add(this.text_AccessCode2);
            this.groupBox11.Controls.Add(this.text_RWlen);
            this.groupBox11.Controls.Add(this.text_WordPtr);
            this.groupBox11.Controls.Add(this.label21);
            this.groupBox11.Controls.Add(this.label22);
            this.groupBox11.Controls.Add(this.label23);
            this.groupBox11.Controls.Add(this.label24);
            this.groupBox11.Controls.Add(this.groupBox12);
            this.groupBox11.Location = new System.Drawing.Point(8, 198);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox11.Size = new System.Drawing.Size(1582, 198);
            this.groupBox11.TabIndex = 17;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Read Data / Write Data / Block Erase";
            // 
            // btExtWrite
            // 
            this.btExtWrite.Location = new System.Drawing.Point(1425, 153);
            this.btExtWrite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btExtWrite.Name = "btExtWrite";
            this.btExtWrite.Size = new System.Drawing.Size(116, 38);
            this.btExtWrite.TabIndex = 33;
            this.btExtWrite.Text = "Ext Write";
            this.btExtWrite.UseVisualStyleBackColor = true;
            this.btExtWrite.Click += new System.EventHandler(this.btExtWrite_Click);
            // 
            // btExtRead
            // 
            this.btExtRead.Location = new System.Drawing.Point(1425, 92);
            this.btExtRead.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btExtRead.Name = "btExtRead";
            this.btExtRead.Size = new System.Drawing.Size(116, 38);
            this.btExtRead.TabIndex = 32;
            this.btExtRead.Text = "Ext Read";
            this.btExtRead.UseVisualStyleBackColor = true;
            this.btExtRead.Click += new System.EventHandler(this.btExtRead_Click);
            // 
            // textBox_pc
            // 
            this.textBox_pc.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_pc.Location = new System.Drawing.Point(924, 95);
            this.textBox_pc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_pc.Name = "textBox_pc";
            this.textBox_pc.ReadOnly = true;
            this.textBox_pc.Size = new System.Drawing.Size(205, 26);
            this.textBox_pc.TabIndex = 29;
            this.textBox_pc.Text = "0800";
            // 
            // checkBox_pc
            // 
            this.checkBox_pc.AutoSize = true;
            this.checkBox_pc.Location = new System.Drawing.Point(608, 98);
            this.checkBox_pc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_pc.Name = "checkBox_pc";
            this.checkBox_pc.Size = new System.Drawing.Size(225, 24);
            this.checkBox_pc.TabIndex = 28;
            this.checkBox_pc.Text = "Auto Compute and add PC";
            this.checkBox_pc.UseVisualStyleBackColor = true;
            this.checkBox_pc.CheckedChanged += new System.EventHandler(this.checkBox_pc_CheckedChanged);
            // 
            // btBlockWrite
            // 
            this.btBlockWrite.Location = new System.Drawing.Point(1155, 153);
            this.btBlockWrite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btBlockWrite.Name = "btBlockWrite";
            this.btBlockWrite.Size = new System.Drawing.Size(116, 38);
            this.btBlockWrite.TabIndex = 17;
            this.btBlockWrite.Text = "BlockWrite";
            this.btBlockWrite.UseVisualStyleBackColor = true;
            this.btBlockWrite.Click += new System.EventHandler(this.btBlockWrite_Click);
            // 
            // btBlockErase
            // 
            this.btBlockErase.Location = new System.Drawing.Point(1292, 153);
            this.btBlockErase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btBlockErase.Name = "btBlockErase";
            this.btBlockErase.Size = new System.Drawing.Size(116, 38);
            this.btBlockErase.TabIndex = 13;
            this.btBlockErase.Text = "BlockErace";
            this.btBlockErase.UseVisualStyleBackColor = true;
            this.btBlockErase.Click += new System.EventHandler(this.btBlockErase_Click);
            // 
            // btWrite
            // 
            this.btWrite.Location = new System.Drawing.Point(1292, 92);
            this.btWrite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btWrite.Name = "btWrite";
            this.btWrite.Size = new System.Drawing.Size(116, 38);
            this.btWrite.TabIndex = 12;
            this.btWrite.Text = "Write";
            this.btWrite.UseVisualStyleBackColor = true;
            this.btWrite.Click += new System.EventHandler(this.btWrite_Click);
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(1155, 92);
            this.btRead.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(116, 38);
            this.btRead.TabIndex = 11;
            this.btRead.Text = "Read";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // text_WriteData
            // 
            this.text_WriteData.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_WriteData.Location = new System.Drawing.Point(806, 33);
            this.text_WriteData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_WriteData.Name = "text_WriteData";
            this.text_WriteData.Size = new System.Drawing.Size(740, 26);
            this.text_WriteData.TabIndex = 10;
            this.text_WriteData.Text = "0000";
            this.text_WriteData.TextChanged += new System.EventHandler(this.text_WriteData_TextChanged);
            this.text_WriteData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // text_AccessCode2
            // 
            this.text_AccessCode2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_AccessCode2.Location = new System.Drawing.Point(308, 145);
            this.text_AccessCode2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_AccessCode2.MaxLength = 8;
            this.text_AccessCode2.Name = "text_AccessCode2";
            this.text_AccessCode2.Size = new System.Drawing.Size(175, 26);
            this.text_AccessCode2.TabIndex = 9;
            this.text_AccessCode2.Text = "00000000";
            this.text_AccessCode2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // text_RWlen
            // 
            this.text_RWlen.Location = new System.Drawing.Point(308, 95);
            this.text_RWlen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_RWlen.MaxLength = 2;
            this.text_RWlen.Name = "text_RWlen";
            this.text_RWlen.Size = new System.Drawing.Size(174, 26);
            this.text_RWlen.TabIndex = 8;
            this.text_RWlen.Text = "4";
            this.text_RWlen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // text_WordPtr
            // 
            this.text_WordPtr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_WordPtr.Location = new System.Drawing.Point(308, 32);
            this.text_WordPtr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_WordPtr.MaxLength = 4;
            this.text_WordPtr.Name = "text_WordPtr";
            this.text_WordPtr.Size = new System.Drawing.Size(174, 26);
            this.text_WordPtr.TabIndex = 7;
            this.text_WordPtr.Text = "0000";
            this.text_WordPtr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(603, 38);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(167, 20);
            this.label21.TabIndex = 5;
            this.label21.Text = "Read/Write data(Hex):";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(10, 152);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(124, 20);
            this.label22.TabIndex = 4;
            this.label22.Text = "Password:(Hex):";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(9, 102);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(102, 20);
            this.label23.TabIndex = 3;
            this.label23.Text = "Length(Dec):";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(9, 38);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(151, 20);
            this.label24.TabIndex = 2;
            this.label24.Text = "Start address:(Hex):";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.C_User);
            this.groupBox12.Controls.Add(this.C_TID);
            this.groupBox12.Controls.Add(this.C_EPC);
            this.groupBox12.Controls.Add(this.C_Reserve);
            this.groupBox12.Location = new System.Drawing.Point(603, 135);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox12.Size = new System.Drawing.Size(530, 52);
            this.groupBox12.TabIndex = 1;
            this.groupBox12.TabStop = false;
            // 
            // C_User
            // 
            this.C_User.AutoSize = true;
            this.C_User.Location = new System.Drawing.Point(310, 18);
            this.C_User.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.C_User.Name = "C_User";
            this.C_User.Size = new System.Drawing.Size(68, 24);
            this.C_User.TabIndex = 3;
            this.C_User.Text = "User";
            this.C_User.UseVisualStyleBackColor = true;
            this.C_User.CheckedChanged += new System.EventHandler(this.C_EPC_CheckedChanged);
            // 
            // C_TID
            // 
            this.C_TID.AutoSize = true;
            this.C_TID.Location = new System.Drawing.Point(224, 18);
            this.C_TID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.C_TID.Name = "C_TID";
            this.C_TID.Size = new System.Drawing.Size(60, 24);
            this.C_TID.TabIndex = 2;
            this.C_TID.Text = "TID";
            this.C_TID.UseVisualStyleBackColor = true;
            this.C_TID.CheckedChanged += new System.EventHandler(this.C_EPC_CheckedChanged);
            // 
            // C_EPC
            // 
            this.C_EPC.AutoSize = true;
            this.C_EPC.Checked = true;
            this.C_EPC.Location = new System.Drawing.Point(135, 18);
            this.C_EPC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.C_EPC.Name = "C_EPC";
            this.C_EPC.Size = new System.Drawing.Size(66, 24);
            this.C_EPC.TabIndex = 1;
            this.C_EPC.TabStop = true;
            this.C_EPC.Text = "EPC";
            this.C_EPC.UseVisualStyleBackColor = true;
            this.C_EPC.CheckedChanged += new System.EventHandler(this.C_EPC_CheckedChanged);
            // 
            // C_Reserve
            // 
            this.C_Reserve.AutoSize = true;
            this.C_Reserve.Location = new System.Drawing.Point(6, 18);
            this.C_Reserve.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.C_Reserve.Name = "C_Reserve";
            this.C_Reserve.Size = new System.Drawing.Size(103, 24);
            this.C_Reserve.TabIndex = 0;
            this.C_Reserve.Text = "Password";
            this.C_Reserve.UseVisualStyleBackColor = true;
            this.C_Reserve.CheckedChanged += new System.EventHandler(this.C_EPC_CheckedChanged);
            // 
            // groupBox31
            // 
            this.groupBox31.Controls.Add(this.maskData_textBox);
            this.groupBox31.Controls.Add(this.label60);
            this.groupBox31.Controls.Add(this.groupBox40);
            this.groupBox31.Controls.Add(this.checkBox1);
            this.groupBox31.Controls.Add(this.maskLen_textBox);
            this.groupBox31.Controls.Add(this.label44);
            this.groupBox31.Controls.Add(this.maskadr_textbox);
            this.groupBox31.Controls.Add(this.label43);
            this.groupBox31.Location = new System.Drawing.Point(8, 78);
            this.groupBox31.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox31.Name = "groupBox31";
            this.groupBox31.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox31.Size = new System.Drawing.Size(1584, 115);
            this.groupBox31.TabIndex = 16;
            this.groupBox31.TabStop = false;
            this.groupBox31.Text = "Mask";
            // 
            // maskData_textBox
            // 
            this.maskData_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.maskData_textBox.Enabled = false;
            this.maskData_textBox.Location = new System.Drawing.Point(792, 73);
            this.maskData_textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maskData_textBox.Name = "maskData_textBox";
            this.maskData_textBox.Size = new System.Drawing.Size(756, 26);
            this.maskData_textBox.TabIndex = 8;
            this.maskData_textBox.Text = "00";
            this.maskData_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(604, 80);
            this.label60.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(90, 20);
            this.label60.TabIndex = 7;
            this.label60.Text = "Data(Hex)：";
            // 
            // groupBox40
            // 
            this.groupBox40.Controls.Add(this.R_User);
            this.groupBox40.Controls.Add(this.R_TID);
            this.groupBox40.Controls.Add(this.R_EPC);
            this.groupBox40.Location = new System.Drawing.Point(603, 17);
            this.groupBox40.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox40.Name = "groupBox40";
            this.groupBox40.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox40.Size = new System.Drawing.Size(770, 50);
            this.groupBox40.TabIndex = 6;
            this.groupBox40.TabStop = false;
            // 
            // R_User
            // 
            this.R_User.AutoSize = true;
            this.R_User.Enabled = false;
            this.R_User.Location = new System.Drawing.Point(572, 18);
            this.R_User.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.R_User.Name = "R_User";
            this.R_User.Size = new System.Drawing.Size(68, 24);
            this.R_User.TabIndex = 2;
            this.R_User.Text = "User";
            this.R_User.UseVisualStyleBackColor = true;
            // 
            // R_TID
            // 
            this.R_TID.AutoSize = true;
            this.R_TID.Enabled = false;
            this.R_TID.Location = new System.Drawing.Point(327, 17);
            this.R_TID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.R_TID.Name = "R_TID";
            this.R_TID.Size = new System.Drawing.Size(60, 24);
            this.R_TID.TabIndex = 1;
            this.R_TID.Text = "TID";
            this.R_TID.UseVisualStyleBackColor = true;
            // 
            // R_EPC
            // 
            this.R_EPC.AutoSize = true;
            this.R_EPC.Checked = true;
            this.R_EPC.Enabled = false;
            this.R_EPC.Location = new System.Drawing.Point(88, 17);
            this.R_EPC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.R_EPC.Name = "R_EPC";
            this.R_EPC.Size = new System.Drawing.Size(66, 24);
            this.R_EPC.TabIndex = 0;
            this.R_EPC.TabStop = true;
            this.R_EPC.Text = "EPC";
            this.R_EPC.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1422, 33);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 24);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Enable";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // maskLen_textBox
            // 
            this.maskLen_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.maskLen_textBox.Enabled = false;
            this.maskLen_textBox.Location = new System.Drawing.Point(222, 73);
            this.maskLen_textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maskLen_textBox.MaxLength = 2;
            this.maskLen_textBox.Name = "maskLen_textBox";
            this.maskLen_textBox.Size = new System.Drawing.Size(259, 26);
            this.maskLen_textBox.TabIndex = 4;
            this.maskLen_textBox.Text = "00";
            this.maskLen_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(18, 80);
            this.label44.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(105, 20);
            this.label44.TabIndex = 3;
            this.label44.Text = "Length(Hex)：";
            // 
            // maskadr_textbox
            // 
            this.maskadr_textbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.maskadr_textbox.Enabled = false;
            this.maskadr_textbox.Location = new System.Drawing.Point(222, 30);
            this.maskadr_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maskadr_textbox.MaxLength = 4;
            this.maskadr_textbox.Name = "maskadr_textbox";
            this.maskadr_textbox.Size = new System.Drawing.Size(259, 26);
            this.maskadr_textbox.TabIndex = 2;
            this.maskadr_textbox.Text = "0000";
            this.maskadr_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(18, 40);
            this.label43.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(151, 20);
            this.label43.TabIndex = 1;
            this.label43.Text = "Start address(Hex)：";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.btSelectTag);
            this.groupBox10.Controls.Add(this.comboBox_EPC);
            this.groupBox10.Controls.Add(this.label16);
            this.groupBox10.Controls.Add(this.text_epc);
            this.groupBox10.Controls.Add(this.check_selecttag);
            this.groupBox10.Location = new System.Drawing.Point(8, 7);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox10.Size = new System.Drawing.Size(1586, 68);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Select tag";
            // 
            // btSelectTag
            // 
            this.btSelectTag.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btSelectTag.Location = new System.Drawing.Point(1414, 22);
            this.btSelectTag.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSelectTag.Name = "btSelectTag";
            this.btSelectTag.Size = new System.Drawing.Size(135, 38);
            this.btSelectTag.TabIndex = 4;
            this.btSelectTag.Text = "Select";
            this.btSelectTag.UseVisualStyleBackColor = true;
            this.btSelectTag.Click += new System.EventHandler(this.btSelectTag_Click);
            // 
            // comboBox_EPC
            // 
            this.comboBox_EPC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_EPC.FormattingEnabled = true;
            this.comboBox_EPC.Location = new System.Drawing.Point(855, 23);
            this.comboBox_EPC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_EPC.Name = "comboBox_EPC";
            this.comboBox_EPC.Size = new System.Drawing.Size(516, 28);
            this.comboBox_EPC.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label16.Location = new System.Drawing.Point(754, 30);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 20);
            this.label16.TabIndex = 2;
            this.label16.Text = "Tag list:";
            // 
            // text_epc
            // 
            this.text_epc.Location = new System.Drawing.Point(177, 23);
            this.text_epc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_epc.Name = "text_epc";
            this.text_epc.Size = new System.Drawing.Size(516, 26);
            this.text_epc.TabIndex = 1;
            // 
            // check_selecttag
            // 
            this.check_selecttag.AutoSize = true;
            this.check_selecttag.Checked = true;
            this.check_selecttag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_selecttag.ForeColor = System.Drawing.Color.RoyalBlue;
            this.check_selecttag.Location = new System.Drawing.Point(26, 27);
            this.check_selecttag.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.check_selecttag.Name = "check_selecttag";
            this.check_selecttag.Size = new System.Drawing.Size(129, 24);
            this.check_selecttag.TabIndex = 0;
            this.check_selecttag.Text = "Selected tag:";
            this.check_selecttag.UseVisualStyleBackColor = true;
            // 
            // Main_Page3
            // 
            this.Main_Page3.Controls.Add(this.panel5);
            this.Main_Page3.Location = new System.Drawing.Point(4, 27);
            this.Main_Page3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Main_Page3.Name = "Main_Page3";
            this.Main_Page3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Main_Page3.Size = new System.Drawing.Size(1610, 931);
            this.Main_Page3.TabIndex = 2;
            this.Main_Page3.Text = "18000-6B Test";
            this.Main_Page3.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox23);
            this.panel5.Controls.Add(this.groupBox22);
            this.panel5.Controls.Add(this.text_6BUID);
            this.panel5.Controls.Add(this.label29);
            this.panel5.Controls.Add(this.ListView_ID_6B);
            this.panel5.Controls.Add(this.groupBox19);
            this.panel5.Location = new System.Drawing.Point(-2, -2);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1604, 918);
            this.panel5.TabIndex = 0;
            // 
            // groupBox23
            // 
            this.groupBox23.Controls.Add(this.text_Statu6B);
            this.groupBox23.Controls.Add(this.btCheckLock6B);
            this.groupBox23.Controls.Add(this.btLock6B);
            this.groupBox23.Controls.Add(this.text_checkaddr);
            this.groupBox23.Controls.Add(this.label52);
            this.groupBox23.Controls.Add(this.text_lock6b);
            this.groupBox23.Controls.Add(this.label51);
            this.groupBox23.Location = new System.Drawing.Point(842, 715);
            this.groupBox23.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox23.Size = new System.Drawing.Size(742, 183);
            this.groupBox23.TabIndex = 21;
            this.groupBox23.TabStop = false;
            // 
            // text_Statu6B
            // 
            this.text_Statu6B.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_Statu6B.ForeColor = System.Drawing.Color.Red;
            this.text_Statu6B.Location = new System.Drawing.Point(378, 125);
            this.text_Statu6B.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_Statu6B.MaxLength = 2;
            this.text_Statu6B.Name = "text_Statu6B";
            this.text_Statu6B.ReadOnly = true;
            this.text_Statu6B.Size = new System.Drawing.Size(164, 26);
            this.text_Statu6B.TabIndex = 19;
            // 
            // btCheckLock6B
            // 
            this.btCheckLock6B.Location = new System.Drawing.Point(574, 110);
            this.btCheckLock6B.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCheckLock6B.Name = "btCheckLock6B";
            this.btCheckLock6B.Size = new System.Drawing.Size(150, 50);
            this.btCheckLock6B.TabIndex = 18;
            this.btCheckLock6B.Text = "Check lock";
            this.btCheckLock6B.UseVisualStyleBackColor = true;
            this.btCheckLock6B.Click += new System.EventHandler(this.btCheckLock6B_Click);
            // 
            // btLock6B
            // 
            this.btLock6B.Location = new System.Drawing.Point(574, 33);
            this.btLock6B.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btLock6B.Name = "btLock6B";
            this.btLock6B.Size = new System.Drawing.Size(150, 50);
            this.btLock6B.TabIndex = 17;
            this.btLock6B.Text = "Lock";
            this.btLock6B.UseVisualStyleBackColor = true;
            this.btLock6B.Click += new System.EventHandler(this.btLock6B_Click);
            // 
            // text_checkaddr
            // 
            this.text_checkaddr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_checkaddr.Location = new System.Drawing.Point(303, 125);
            this.text_checkaddr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_checkaddr.MaxLength = 2;
            this.text_checkaddr.Name = "text_checkaddr";
            this.text_checkaddr.Size = new System.Drawing.Size(64, 26);
            this.text_checkaddr.TabIndex = 16;
            this.text_checkaddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(70, 130);
            this.label52.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(189, 20);
            this.label52.TabIndex = 15;
            this.label52.Text = "Check lock address(Hex):";
            // 
            // text_lock6b
            // 
            this.text_lock6b.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_lock6b.Location = new System.Drawing.Point(303, 48);
            this.text_lock6b.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_lock6b.MaxLength = 2;
            this.text_lock6b.Name = "text_lock6b";
            this.text_lock6b.Size = new System.Drawing.Size(64, 26);
            this.text_lock6b.TabIndex = 14;
            this.text_lock6b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(106, 53);
            this.label51.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(146, 20);
            this.label51.TabIndex = 0;
            this.label51.Text = "Lock address(Hex):";
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.text_W6B);
            this.groupBox22.Controls.Add(this.label48);
            this.groupBox22.Controls.Add(this.btWrite6B);
            this.groupBox22.Controls.Add(this.text_W6BLen);
            this.groupBox22.Controls.Add(this.label49);
            this.groupBox22.Controls.Add(this.text_W6BAddr);
            this.groupBox22.Controls.Add(this.label50);
            this.groupBox22.Controls.Add(this.text_R6B);
            this.groupBox22.Controls.Add(this.label36);
            this.groupBox22.Controls.Add(this.btRead6B);
            this.groupBox22.Controls.Add(this.text_R6BLen);
            this.groupBox22.Controls.Add(this.label35);
            this.groupBox22.Controls.Add(this.text_R6BAddr);
            this.groupBox22.Controls.Add(this.label30);
            this.groupBox22.Location = new System.Drawing.Point(844, 117);
            this.groupBox22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox22.Size = new System.Drawing.Size(742, 598);
            this.groupBox22.TabIndex = 20;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Read/Write Data";
            // 
            // text_W6B
            // 
            this.text_W6B.Location = new System.Drawing.Point(183, 390);
            this.text_W6B.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_W6B.Multiline = true;
            this.text_W6B.Name = "text_W6B";
            this.text_W6B.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_W6B.Size = new System.Drawing.Size(536, 194);
            this.text_W6B.TabIndex = 18;
            this.text_W6B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(27, 390);
            this.label48.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(136, 20);
            this.label48.TabIndex = 17;
            this.label48.Text = "Write data(Hex):   ";
            // 
            // btWrite6B
            // 
            this.btWrite6B.Location = new System.Drawing.Point(572, 323);
            this.btWrite6B.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btWrite6B.Name = "btWrite6B";
            this.btWrite6B.Size = new System.Drawing.Size(150, 50);
            this.btWrite6B.TabIndex = 16;
            this.btWrite6B.Text = "Write";
            this.btWrite6B.UseVisualStyleBackColor = true;
            this.btWrite6B.Click += new System.EventHandler(this.btWrite6B_Click);
            // 
            // text_W6BLen
            // 
            this.text_W6BLen.Location = new System.Drawing.Point(441, 332);
            this.text_W6BLen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_W6BLen.MaxLength = 2;
            this.text_W6BLen.Name = "text_W6BLen";
            this.text_W6BLen.Size = new System.Drawing.Size(64, 26);
            this.text_W6BLen.TabIndex = 15;
            this.text_W6BLen.TextChanged += new System.EventHandler(this.text_W6BLen_TextChanged);
            this.text_W6BLen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(274, 338);
            this.label49.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(136, 20);
            this.label49.TabIndex = 14;
            this.label49.Text = "Write length(Hex):";
            // 
            // text_W6BAddr
            // 
            this.text_W6BAddr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_W6BAddr.Location = new System.Drawing.Point(186, 332);
            this.text_W6BAddr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_W6BAddr.MaxLength = 2;
            this.text_W6BAddr.Name = "text_W6BAddr";
            this.text_W6BAddr.Size = new System.Drawing.Size(64, 26);
            this.text_W6BAddr.TabIndex = 13;
            this.text_W6BAddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(9, 338);
            this.label50.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(159, 20);
            this.label50.TabIndex = 12;
            this.label50.Text = "Start address(Hex):   ";
            // 
            // text_R6B
            // 
            this.text_R6B.Location = new System.Drawing.Point(183, 103);
            this.text_R6B.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_R6B.Multiline = true;
            this.text_R6B.Name = "text_R6B";
            this.text_R6B.ReadOnly = true;
            this.text_R6B.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_R6B.Size = new System.Drawing.Size(536, 194);
            this.text_R6B.TabIndex = 11;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(27, 103);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(138, 20);
            this.label36.TabIndex = 10;
            this.label36.Text = "Read data(Hex):   ";
            // 
            // btRead6B
            // 
            this.btRead6B.Location = new System.Drawing.Point(572, 33);
            this.btRead6B.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRead6B.Name = "btRead6B";
            this.btRead6B.Size = new System.Drawing.Size(150, 50);
            this.btRead6B.TabIndex = 9;
            this.btRead6B.Text = "Read";
            this.btRead6B.UseVisualStyleBackColor = true;
            this.btRead6B.Click += new System.EventHandler(this.btRead6B_Click);
            // 
            // text_R6BLen
            // 
            this.text_R6BLen.Location = new System.Drawing.Point(441, 42);
            this.text_R6BLen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_R6BLen.MaxLength = 2;
            this.text_R6BLen.Name = "text_R6BLen";
            this.text_R6BLen.Size = new System.Drawing.Size(64, 26);
            this.text_R6BLen.TabIndex = 8;
            this.text_R6BLen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(280, 48);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(138, 20);
            this.label35.TabIndex = 7;
            this.label35.Text = "Read length(Hex):";
            // 
            // text_R6BAddr
            // 
            this.text_R6BAddr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_R6BAddr.Location = new System.Drawing.Point(186, 42);
            this.text_R6BAddr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_R6BAddr.MaxLength = 2;
            this.text_R6BAddr.Name = "text_R6BAddr";
            this.text_R6BAddr.Size = new System.Drawing.Size(64, 26);
            this.text_R6BAddr.TabIndex = 6;
            this.text_R6BAddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_address_KeyPress);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(12, 48);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(159, 20);
            this.label30.TabIndex = 5;
            this.label30.Text = "Start address(Hex):   ";
            // 
            // text_6BUID
            // 
            this.text_6BUID.Location = new System.Drawing.Point(1065, 65);
            this.text_6BUID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_6BUID.Name = "text_6BUID";
            this.text_6BUID.ReadOnly = true;
            this.text_6BUID.Size = new System.Drawing.Size(319, 26);
            this.text_6BUID.TabIndex = 19;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(842, 78);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(166, 20);
            this.label29.TabIndex = 18;
            this.label29.Text = "Current Selected UID:";
            // 
            // ListView_ID_6B
            // 
            this.ListView_ID_6B.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ListView_ID_6B.AllowDrop = true;
            this.ListView_ID_6B.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader2,
            this.columnHeader3});
            this.ListView_ID_6B.FullRowSelect = true;
            this.ListView_ID_6B.GridLines = true;
            this.ListView_ID_6B.HideSelection = false;
            this.ListView_ID_6B.HotTracking = true;
            this.ListView_ID_6B.HoverSelection = true;
            this.ListView_ID_6B.Location = new System.Drawing.Point(15, 137);
            this.ListView_ID_6B.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListView_ID_6B.Name = "ListView_ID_6B";
            this.ListView_ID_6B.Size = new System.Drawing.Size(784, 766);
            this.ListView_ID_6B.TabIndex = 17;
            this.ListView_ID_6B.UseCompatibleStateImageBehavior = false;
            this.ListView_ID_6B.View = System.Windows.Forms.View.Details;
            this.ListView_ID_6B.SelectedIndexChanged += new System.EventHandler(this.ListView_ID_6B_SelectedIndexChanged);
            this.ListView_ID_6B.DoubleClick += new System.EventHandler(this.ListView_ID_6B_DoubleClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "No.";
            this.columnHeader5.Width = 50;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 230;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ANT(4,3,2,1)";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Times";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "RSSI";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.rb_mutiple);
            this.groupBox19.Controls.Add(this.rb_single);
            this.groupBox19.Controls.Add(this.btInventory6B);
            this.groupBox19.Location = new System.Drawing.Point(15, 8);
            this.groupBox19.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox19.Size = new System.Drawing.Size(786, 118);
            this.groupBox19.TabIndex = 16;
            this.groupBox19.TabStop = false;
            // 
            // rb_mutiple
            // 
            this.rb_mutiple.AutoSize = true;
            this.rb_mutiple.Location = new System.Drawing.Point(566, 58);
            this.rb_mutiple.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_mutiple.Name = "rb_mutiple";
            this.rb_mutiple.Size = new System.Drawing.Size(85, 24);
            this.rb_mutiple.TabIndex = 2;
            this.rb_mutiple.Text = "Mutiple";
            this.rb_mutiple.UseVisualStyleBackColor = true;
            // 
            // rb_single
            // 
            this.rb_single.AutoSize = true;
            this.rb_single.Checked = true;
            this.rb_single.Location = new System.Drawing.Point(369, 58);
            this.rb_single.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_single.Name = "rb_single";
            this.rb_single.Size = new System.Drawing.Size(78, 24);
            this.rb_single.TabIndex = 1;
            this.rb_single.TabStop = true;
            this.rb_single.Text = "Single";
            this.rb_single.UseVisualStyleBackColor = true;
            // 
            // btInventory6B
            // 
            this.btInventory6B.BackColor = System.Drawing.Color.Transparent;
            this.btInventory6B.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btInventory6B.ForeColor = System.Drawing.Color.DarkBlue;
            this.btInventory6B.Location = new System.Drawing.Point(27, 33);
            this.btInventory6B.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btInventory6B.Name = "btInventory6B";
            this.btInventory6B.Size = new System.Drawing.Size(256, 67);
            this.btInventory6B.TabIndex = 0;
            this.btInventory6B.Text = "Start";
            this.btInventory6B.UseVisualStyleBackColor = false;
            this.btInventory6B.Click += new System.EventHandler(this.btInventory6B_Click);
            // 
            // Main_Page4
            // 
            this.Main_Page4.Controls.Add(this.tabControl3);
            this.Main_Page4.Location = new System.Drawing.Point(4, 27);
            this.Main_Page4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Main_Page4.Name = "Main_Page4";
            this.Main_Page4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Main_Page4.Size = new System.Drawing.Size(1610, 931);
            this.Main_Page4.TabIndex = 3;
            this.Main_Page4.Text = "Network module config";
            this.Main_Page4.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl3.Controls.Add(this.tabPage6);
            this.tabControl3.Controls.Add(this.tabPage7);
            this.tabControl3.Controls.Add(this.tabPage8);
            this.tabControl3.Controls.Add(this.tabPage9);
            this.tabControl3.ItemSize = new System.Drawing.Size(60, 23);
            this.tabControl3.Location = new System.Drawing.Point(-2, 7);
            this.tabControl3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(1608, 895);
            this.tabControl3.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.DeviceListView);
            this.tabPage6.Controls.Add(this.menuStrip);
            this.tabPage6.Location = new System.Drawing.Point(4, 4);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage6.Size = new System.Drawing.Size(1600, 864);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "   TCP config       ";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // DeviceListView
            // 
            this.DeviceListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.deviceName,
            this.deviceIP,
            this.deviceMac});
            this.DeviceListView.FullRowSelect = true;
            this.DeviceListView.HideSelection = false;
            this.DeviceListView.Location = new System.Drawing.Point(12, 50);
            this.DeviceListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeviceListView.Name = "DeviceListView";
            this.DeviceListView.Size = new System.Drawing.Size(1573, 786);
            this.DeviceListView.TabIndex = 5;
            this.DeviceListView.UseCompatibleStateImageBehavior = false;
            this.DeviceListView.View = System.Windows.Forms.View.Details;
            this.DeviceListView.DoubleClick += new System.EventHandler(this.DeviceListView_DoubleClick);
            // 
            // deviceName
            // 
            this.deviceName.Text = "Device name";
            this.deviceName.Width = 220;
            // 
            // deviceIP
            // 
            this.deviceIP.Text = "Device IP";
            this.deviceIP.Width = 280;
            // 
            // deviceMac
            // 
            this.deviceMac.Text = "Device Mac";
            this.deviceMac.Width = 245;
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.languageToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(4, 5);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1592, 35);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.configToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(108, 29);
            this.toolStripMenuItem1.Text = "&Operation";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(167, 34);
            this.searchToolStripMenuItem.Text = "&Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(167, 34);
            this.configToolStripMenuItem.Text = "&Config";
            this.configToolStripMenuItem.Click += new System.EventHandler(this.configToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(167, 34);
            this.clearToolStripMenuItem.Text = "&Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(164, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(167, 34);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iEToolStripMenuItem,
            this.telnetToolStripMenuItem,
            this.pingToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(61, 29);
            this.toolStripMenuItem2.Text = "&Tool";
            // 
            // iEToolStripMenuItem
            // 
            this.iEToolStripMenuItem.Name = "iEToolStripMenuItem";
            this.iEToolStripMenuItem.Size = new System.Drawing.Size(159, 34);
            this.iEToolStripMenuItem.Text = "&IE";
            this.iEToolStripMenuItem.Click += new System.EventHandler(this.iEToolStripMenuItem_Click);
            // 
            // telnetToolStripMenuItem
            // 
            this.telnetToolStripMenuItem.Name = "telnetToolStripMenuItem";
            this.telnetToolStripMenuItem.Size = new System.Drawing.Size(159, 34);
            this.telnetToolStripMenuItem.Text = "&Telnet";
            this.telnetToolStripMenuItem.Click += new System.EventHandler(this.telnetToolStripMenuItem_Click);
            // 
            // pingToolStripMenuItem
            // 
            this.pingToolStripMenuItem.Name = "pingToolStripMenuItem";
            this.pingToolStripMenuItem.Size = new System.Drawing.Size(159, 34);
            this.pingToolStripMenuItem.Text = "&Ping";
            this.pingToolStripMenuItem.Click += new System.EventHandler(this.pingToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.languageToolStripMenuItem.Text = "&Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(170, 34);
            this.englishToolStripMenuItem.Text = "&English";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.panel6);
            this.tabPage7.Location = new System.Drawing.Point(4, 4);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage7.Size = new System.Drawing.Size(1600, 864);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "   Serialport Config   ";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btSave);
            this.panel6.Controls.Add(this.btLoadDefault);
            this.panel6.Controls.Add(this.groupBox51);
            this.panel6.Controls.Add(this.groupBox50);
            this.panel6.Controls.Add(this.groupBox49);
            this.panel6.Controls.Add(this.groupBox47);
            this.panel6.Location = new System.Drawing.Point(-3, -13);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1604, 940);
            this.panel6.TabIndex = 0;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(1132, 795);
            this.btSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(164, 38);
            this.btSave.TabIndex = 71;
            this.btSave.Text = "Save and restart";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btLoadDefault
            // 
            this.btLoadDefault.Location = new System.Drawing.Point(1131, 730);
            this.btLoadDefault.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btLoadDefault.Name = "btLoadDefault";
            this.btLoadDefault.Size = new System.Drawing.Size(164, 38);
            this.btLoadDefault.TabIndex = 70;
            this.btLoadDefault.Text = "Load default value";
            this.btLoadDefault.UseVisualStyleBackColor = true;
            this.btLoadDefault.Click += new System.EventHandler(this.btLoadDefault_Click);
            // 
            // groupBox51
            // 
            this.groupBox51.Controls.Add(this.btGetNet);
            this.groupBox51.Controls.Add(this.btSetNet);
            this.groupBox51.Controls.Add(this.label110);
            this.groupBox51.Controls.Add(this.macTB);
            this.groupBox51.Controls.Add(this.panel_StaticIp);
            this.groupBox51.Location = new System.Drawing.Point(286, 497);
            this.groupBox51.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox51.Name = "groupBox51";
            this.groupBox51.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox51.Size = new System.Drawing.Size(831, 340);
            this.groupBox51.TabIndex = 69;
            this.groupBox51.TabStop = false;
            this.groupBox51.Text = "Net work setting";
            // 
            // btGetNet
            // 
            this.btGetNet.Location = new System.Drawing.Point(684, 218);
            this.btGetNet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btGetNet.Name = "btGetNet";
            this.btGetNet.Size = new System.Drawing.Size(135, 38);
            this.btGetNet.TabIndex = 119;
            this.btGetNet.Text = "Get";
            this.btGetNet.UseVisualStyleBackColor = true;
            this.btGetNet.Click += new System.EventHandler(this.btGetNet_Click);
            // 
            // btSetNet
            // 
            this.btSetNet.Location = new System.Drawing.Point(684, 283);
            this.btSetNet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSetNet.Name = "btSetNet";
            this.btSetNet.Size = new System.Drawing.Size(135, 38);
            this.btSetNet.TabIndex = 118;
            this.btSetNet.Text = "Set";
            this.btSetNet.UseVisualStyleBackColor = true;
            this.btSetNet.Click += new System.EventHandler(this.btSetNet_Click);
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Location = new System.Drawing.Point(333, 43);
            this.label110.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(102, 20);
            this.label110.TabIndex = 61;
            this.label110.Text = "Mac Address";
            // 
            // macTB
            // 
            this.macTB.AccessibleName = "MacAddress";
            this.macTB.Location = new System.Drawing.Point(336, 70);
            this.macTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.macTB.Name = "macTB";
            this.macTB.ReadOnly = true;
            this.macTB.Size = new System.Drawing.Size(262, 26);
            this.macTB.TabIndex = 58;
            // 
            // panel_StaticIp
            // 
            this.panel_StaticIp.Controls.Add(this.label109);
            this.panel_StaticIp.Controls.Add(this.label108);
            this.panel_StaticIp.Controls.Add(this.label107);
            this.panel_StaticIp.Controls.Add(this.label106);
            this.panel_StaticIp.Controls.Add(this.label105);
            this.panel_StaticIp.Controls.Add(this.altDNSTB);
            this.panel_StaticIp.Controls.Add(this.pDNSTB);
            this.panel_StaticIp.Controls.Add(this.gatewayTB);
            this.panel_StaticIp.Controls.Add(this.subnetTB);
            this.panel_StaticIp.Controls.Add(this.ipTB);
            this.panel_StaticIp.Location = new System.Drawing.Point(18, 33);
            this.panel_StaticIp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_StaticIp.Name = "panel_StaticIp";
            this.panel_StaticIp.Size = new System.Drawing.Size(268, 288);
            this.panel_StaticIp.TabIndex = 56;
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Location = new System.Drawing.Point(4, 213);
            this.label109.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(162, 20);
            this.label109.TabIndex = 50;
            this.label109.Text = "Alternate DNS Server";
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Location = new System.Drawing.Point(4, 143);
            this.label108.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(163, 20);
            this.label108.TabIndex = 49;
            this.label108.Text = "Preferred DNS Server";
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Location = new System.Drawing.Point(4, 100);
            this.label107.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(72, 20);
            this.label107.TabIndex = 48;
            this.label107.Text = "Gateway";
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Location = new System.Drawing.Point(4, 55);
            this.label106.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(61, 20);
            this.label106.TabIndex = 47;
            this.label106.Text = "Subnet";
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Location = new System.Drawing.Point(4, 10);
            this.label105.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(87, 20);
            this.label105.TabIndex = 46;
            this.label105.Text = "IP Address";
            // 
            // altDNSTB
            // 
            this.altDNSTB.AccessibleName = "AlternateDNS";
            this.altDNSTB.Location = new System.Drawing.Point(118, 238);
            this.altDNSTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.altDNSTB.Name = "altDNSTB";
            this.altDNSTB.Size = new System.Drawing.Size(144, 26);
            this.altDNSTB.TabIndex = 43;
            // 
            // pDNSTB
            // 
            this.pDNSTB.AccessibleName = "PreferredDNS";
            this.pDNSTB.Location = new System.Drawing.Point(118, 168);
            this.pDNSTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pDNSTB.Name = "pDNSTB";
            this.pDNSTB.Size = new System.Drawing.Size(144, 26);
            this.pDNSTB.TabIndex = 42;
            // 
            // gatewayTB
            // 
            this.gatewayTB.AccessibleName = "Gateway";
            this.gatewayTB.Location = new System.Drawing.Point(118, 95);
            this.gatewayTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gatewayTB.Name = "gatewayTB";
            this.gatewayTB.Size = new System.Drawing.Size(144, 26);
            this.gatewayTB.TabIndex = 41;
            // 
            // subnetTB
            // 
            this.subnetTB.AccessibleName = "Subnet";
            this.subnetTB.Location = new System.Drawing.Point(118, 50);
            this.subnetTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.subnetTB.Name = "subnetTB";
            this.subnetTB.Size = new System.Drawing.Size(144, 26);
            this.subnetTB.TabIndex = 40;
            // 
            // ipTB
            // 
            this.ipTB.AccessibleName = "IpAddress";
            this.ipTB.Location = new System.Drawing.Point(118, 5);
            this.ipTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ipTB.Name = "ipTB";
            this.ipTB.Size = new System.Drawing.Size(144, 26);
            this.ipTB.TabIndex = 39;
            // 
            // groupBox50
            // 
            this.groupBox50.Controls.Add(this.btGetCnt);
            this.groupBox50.Controls.Add(this.btSetCnt);
            this.groupBox50.Controls.Add(this.panel_TCP);
            this.groupBox50.Location = new System.Drawing.Point(286, 238);
            this.groupBox50.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox50.Name = "groupBox50";
            this.groupBox50.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox50.Size = new System.Drawing.Size(831, 252);
            this.groupBox50.TabIndex = 68;
            this.groupBox50.TabStop = false;
            this.groupBox50.Text = "Connection setting";
            // 
            // btGetCnt
            // 
            this.btGetCnt.Location = new System.Drawing.Point(684, 130);
            this.btGetCnt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btGetCnt.Name = "btGetCnt";
            this.btGetCnt.Size = new System.Drawing.Size(135, 38);
            this.btGetCnt.TabIndex = 119;
            this.btGetCnt.Text = "Get";
            this.btGetCnt.UseVisualStyleBackColor = true;
            this.btGetCnt.Click += new System.EventHandler(this.btGetCnt_Click);
            // 
            // btSetCnt
            // 
            this.btSetCnt.Location = new System.Drawing.Point(684, 190);
            this.btSetCnt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSetCnt.Name = "btSetCnt";
            this.btSetCnt.Size = new System.Drawing.Size(135, 38);
            this.btSetCnt.TabIndex = 118;
            this.btSetCnt.Text = "Set";
            this.btSetCnt.UseVisualStyleBackColor = true;
            this.btSetCnt.Click += new System.EventHandler(this.btSetCnt_Click);
            // 
            // panel_TCP
            // 
            this.panel_TCP.Controls.Add(this.label87);
            this.panel_TCP.Controls.Add(this.label88);
            this.panel_TCP.Controls.Add(this.label89);
            this.panel_TCP.Controls.Add(this.label90);
            this.panel_TCP.Controls.Add(this.label93);
            this.panel_TCP.Controls.Add(this.workasCB);
            this.panel_TCP.Controls.Add(this.tcpRomteHostTB);
            this.panel_TCP.Controls.Add(this.tcpRemotePortNUD);
            this.panel_TCP.Controls.Add(this.tcpLocalPortNUD);
            this.panel_TCP.Controls.Add(this.tcpActiveCB);
            this.panel_TCP.Location = new System.Drawing.Point(18, 33);
            this.panel_TCP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_TCP.Name = "panel_TCP";
            this.panel_TCP.Size = new System.Drawing.Size(632, 195);
            this.panel_TCP.TabIndex = 113;
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(4, 155);
            this.label87.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(80, 20);
            this.label87.TabIndex = 119;
            this.label87.Text = "Local Port";
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(4, 108);
            this.label88.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(99, 20);
            this.label88.TabIndex = 118;
            this.label88.Text = "Remote Port";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(4, 60);
            this.label89.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(104, 20);
            this.label89.TabIndex = 117;
            this.label89.Text = "Remote Host";
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(4, 20);
            this.label90.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(87, 20);
            this.label90.TabIndex = 116;
            this.label90.Text = "Worked As";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Location = new System.Drawing.Point(304, 20);
            this.label93.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(116, 20);
            this.label93.TabIndex = 107;
            this.label93.Text = "Active Connect";
            // 
            // workasCB
            // 
            this.workasCB.AccessibleName = "ConnWorkMode";
            this.workasCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workasCB.FormattingEnabled = true;
            this.workasCB.Items.AddRange(new object[] {
            "Server",
            "Client"});
            this.workasCB.Location = new System.Drawing.Point(118, 15);
            this.workasCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.workasCB.Name = "workasCB";
            this.workasCB.Size = new System.Drawing.Size(136, 28);
            this.workasCB.TabIndex = 106;
            // 
            // tcpRomteHostTB
            // 
            this.tcpRomteHostTB.AccessibleName = "ConnRemoteHost";
            this.tcpRomteHostTB.Location = new System.Drawing.Point(118, 53);
            this.tcpRomteHostTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tcpRomteHostTB.Name = "tcpRomteHostTB";
            this.tcpRomteHostTB.Size = new System.Drawing.Size(136, 26);
            this.tcpRomteHostTB.TabIndex = 98;
            // 
            // tcpRemotePortNUD
            // 
            this.tcpRemotePortNUD.AccessibleName = "ConnRemotePort";
            this.tcpRemotePortNUD.Location = new System.Drawing.Point(166, 98);
            this.tcpRemotePortNUD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tcpRemotePortNUD.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.tcpRemotePortNUD.Name = "tcpRemotePortNUD";
            this.tcpRemotePortNUD.Size = new System.Drawing.Size(90, 26);
            this.tcpRemotePortNUD.TabIndex = 96;
            this.tcpRemotePortNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tcpLocalPortNUD
            // 
            this.tcpLocalPortNUD.AccessibleName = "ConnLocalPort";
            this.tcpLocalPortNUD.Location = new System.Drawing.Point(166, 143);
            this.tcpLocalPortNUD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tcpLocalPortNUD.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.tcpLocalPortNUD.Name = "tcpLocalPortNUD";
            this.tcpLocalPortNUD.Size = new System.Drawing.Size(90, 26);
            this.tcpLocalPortNUD.TabIndex = 95;
            this.tcpLocalPortNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tcpActiveCB
            // 
            this.tcpActiveCB.AccessibleName = "ConnActive";
            this.tcpActiveCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tcpActiveCB.FormattingEnabled = true;
            this.tcpActiveCB.Items.AddRange(new object[] {
            "None",
            "WithAnyCharacter",
            "WithStartCharacter",
            "AutoStart"});
            this.tcpActiveCB.Location = new System.Drawing.Point(438, 12);
            this.tcpActiveCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tcpActiveCB.Name = "tcpActiveCB";
            this.tcpActiveCB.Size = new System.Drawing.Size(158, 28);
            this.tcpActiveCB.TabIndex = 93;
            // 
            // groupBox49
            // 
            this.groupBox49.Controls.Add(this.btGetSeriaPort);
            this.groupBox49.Controls.Add(this.btSetSerialPort);
            this.groupBox49.Controls.Add(this.panel7);
            this.groupBox49.Location = new System.Drawing.Point(286, 30);
            this.groupBox49.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox49.Name = "groupBox49";
            this.groupBox49.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox49.Size = new System.Drawing.Size(831, 197);
            this.groupBox49.TabIndex = 67;
            this.groupBox49.TabStop = false;
            this.groupBox49.Text = "Serialport Setting ";
            // 
            // btGetSeriaPort
            // 
            this.btGetSeriaPort.Location = new System.Drawing.Point(684, 68);
            this.btGetSeriaPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btGetSeriaPort.Name = "btGetSeriaPort";
            this.btGetSeriaPort.Size = new System.Drawing.Size(135, 38);
            this.btGetSeriaPort.TabIndex = 118;
            this.btGetSeriaPort.Text = "Get";
            this.btGetSeriaPort.UseVisualStyleBackColor = true;
            this.btGetSeriaPort.Click += new System.EventHandler(this.btGetSeriaPort_Click);
            // 
            // btSetSerialPort
            // 
            this.btSetSerialPort.Location = new System.Drawing.Point(684, 132);
            this.btSetSerialPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSetSerialPort.Name = "btSetSerialPort";
            this.btSetSerialPort.Size = new System.Drawing.Size(135, 38);
            this.btSetSerialPort.TabIndex = 117;
            this.btSetSerialPort.Text = "Set";
            this.btSetSerialPort.UseVisualStyleBackColor = true;
            this.btSetSerialPort.Click += new System.EventHandler(this.btSetSerialPort_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label72);
            this.panel7.Controls.Add(this.label73);
            this.panel7.Controls.Add(this.label74);
            this.panel7.Controls.Add(this.label75);
            this.panel7.Controls.Add(this.label76);
            this.panel7.Controls.Add(this.label77);
            this.panel7.Controls.Add(this.label78);
            this.panel7.Controls.Add(this.protocolCB);
            this.panel7.Controls.Add(this.stopbitCB);
            this.panel7.Controls.Add(this.parityCB);
            this.panel7.Controls.Add(this.databitCB);
            this.panel7.Controls.Add(this.baudrateCB);
            this.panel7.Controls.Add(this.flowCB);
            this.panel7.Controls.Add(this.fifoCB);
            this.panel7.Location = new System.Drawing.Point(27, 33);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(622, 142);
            this.panel7.TabIndex = 113;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(422, 22);
            this.label72.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(75, 20);
            this.label72.TabIndex = 112;
            this.label72.Text = "Data Bits";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(332, 107);
            this.label73.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(74, 20);
            this.label73.TabIndex = 111;
            this.label73.Text = "Stop Bits";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(332, 65);
            this.label74.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(97, 20);
            this.label74.TabIndex = 110;
            this.label74.Text = "Flow Control";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(22, 107);
            this.label75.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(48, 20);
            this.label75.TabIndex = 109;
            this.label75.Text = "Parity";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(22, 65);
            this.label76.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(86, 20);
            this.label76.TabIndex = 107;
            this.label76.Text = "Baud Rate";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(279, 22);
            this.label77.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(46, 20);
            this.label77.TabIndex = 108;
            this.label77.Text = "FIFO";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(22, 22);
            this.label78.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(67, 20);
            this.label78.TabIndex = 107;
            this.label78.Text = "Protocol";
            // 
            // protocolCB
            // 
            this.protocolCB.AccessibleName = "SerialProtocol";
            this.protocolCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.protocolCB.FormattingEnabled = true;
            this.protocolCB.Items.AddRange(new object[] {
            "RS232",
            "RS422",
            "RS485"});
            this.protocolCB.Location = new System.Drawing.Point(138, 17);
            this.protocolCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.protocolCB.Name = "protocolCB";
            this.protocolCB.Size = new System.Drawing.Size(94, 28);
            this.protocolCB.TabIndex = 83;
            // 
            // stopbitCB
            // 
            this.stopbitCB.AccessibleName = "StopBits";
            this.stopbitCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stopbitCB.FormattingEnabled = true;
            this.stopbitCB.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.stopbitCB.Location = new System.Drawing.Point(466, 102);
            this.stopbitCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stopbitCB.Name = "stopbitCB";
            this.stopbitCB.Size = new System.Drawing.Size(66, 28);
            this.stopbitCB.TabIndex = 48;
            // 
            // parityCB
            // 
            this.parityCB.AccessibleName = "SerialParity";
            this.parityCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parityCB.FormattingEnabled = true;
            this.parityCB.Items.AddRange(new object[] {
            "NONE",
            "ODD",
            "EVEN",
            "MARK",
            "SPACE"});
            this.parityCB.Location = new System.Drawing.Point(138, 102);
            this.parityCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.parityCB.Name = "parityCB";
            this.parityCB.Size = new System.Drawing.Size(130, 28);
            this.parityCB.TabIndex = 47;
            // 
            // databitCB
            // 
            this.databitCB.AccessibleName = "DataBits";
            this.databitCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.databitCB.FormattingEnabled = true;
            this.databitCB.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.databitCB.Location = new System.Drawing.Point(531, 17);
            this.databitCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.databitCB.Name = "databitCB";
            this.databitCB.Size = new System.Drawing.Size(66, 28);
            this.databitCB.TabIndex = 46;
            // 
            // baudrateCB
            // 
            this.baudrateCB.AccessibleName = "BaudRate";
            this.baudrateCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudrateCB.FormattingEnabled = true;
            this.baudrateCB.Items.AddRange(new object[] {
            "110",
            "134",
            "150",
            "300",
            "600",
            "1200",
            "1800",
            "2400",
            "4800",
            "7200",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800"});
            this.baudrateCB.Location = new System.Drawing.Point(138, 58);
            this.baudrateCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.baudrateCB.Name = "baudrateCB";
            this.baudrateCB.Size = new System.Drawing.Size(145, 28);
            this.baudrateCB.TabIndex = 45;
            // 
            // flowCB
            // 
            this.flowCB.AccessibleName = "FlowControl";
            this.flowCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flowCB.FormattingEnabled = true;
            this.flowCB.Items.AddRange(new object[] {
            "None",
            "Software",
            "Hardware"});
            this.flowCB.Location = new System.Drawing.Point(466, 60);
            this.flowCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowCB.Name = "flowCB";
            this.flowCB.Size = new System.Drawing.Size(130, 28);
            this.flowCB.TabIndex = 44;
            // 
            // fifoCB
            // 
            this.fifoCB.AccessibleName = "SerialFIFO";
            this.fifoCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fifoCB.FormattingEnabled = true;
            this.fifoCB.Items.AddRange(new object[] {
            "14",
            "8",
            "4"});
            this.fifoCB.Location = new System.Drawing.Point(332, 17);
            this.fifoCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fifoCB.Name = "fifoCB";
            this.fifoCB.Size = new System.Drawing.Size(66, 28);
            this.fifoCB.TabIndex = 43;
            // 
            // groupBox47
            // 
            this.groupBox47.Controls.Add(this.btExitAT);
            this.groupBox47.Controls.Add(this.btGotoAT);
            this.groupBox47.Location = new System.Drawing.Point(1131, 567);
            this.groupBox47.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox47.Name = "groupBox47";
            this.groupBox47.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox47.Size = new System.Drawing.Size(165, 142);
            this.groupBox47.TabIndex = 66;
            this.groupBox47.TabStop = false;
            this.groupBox47.Text = "AT Mode Change";
            // 
            // btExitAT
            // 
            this.btExitAT.Location = new System.Drawing.Point(16, 82);
            this.btExitAT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btExitAT.Name = "btExitAT";
            this.btExitAT.Size = new System.Drawing.Size(135, 38);
            this.btExitAT.TabIndex = 1;
            this.btExitAT.Text = "Exit";
            this.btExitAT.UseVisualStyleBackColor = true;
            this.btExitAT.Click += new System.EventHandler(this.btExitAT_Click);
            // 
            // btGotoAT
            // 
            this.btGotoAT.Location = new System.Drawing.Point(16, 32);
            this.btGotoAT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btGotoAT.Name = "btGotoAT";
            this.btGotoAT.Size = new System.Drawing.Size(135, 38);
            this.btGotoAT.TabIndex = 0;
            this.btGotoAT.Text = "Goto";
            this.btGotoAT.UseVisualStyleBackColor = true;
            this.btGotoAT.Click += new System.EventHandler(this.btGotoAT_Click);
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.label63);
            this.tabPage8.Controls.Add(this.stcprecv);
            this.tabPage8.Controls.Add(this.groupBox25);
            this.tabPage8.Controls.Add(this.groupBox24);
            this.tabPage8.Location = new System.Drawing.Point(4, 4);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage8.Size = new System.Drawing.Size(1600, 864);
            this.tabPage8.TabIndex = 2;
            this.tabPage8.Text = "   TCP Server   ";
            this.tabPage8.UseVisualStyleBackColor = true;
            this.tabPage8.Click += new System.EventHandler(this.tabPage8_Click);
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(306, 208);
            this.label63.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(144, 20);
            this.label63.TabIndex = 3;
            this.label63.Text = "Receive data(Hex):";
            // 
            // stcprecv
            // 
            this.stcprecv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stcprecv.EnableAutoDragDrop = true;
            this.stcprecv.Location = new System.Drawing.Point(303, 247);
            this.stcprecv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stcprecv.Name = "stcprecv";
            this.stcprecv.Size = new System.Drawing.Size(924, 539);
            this.stcprecv.TabIndex = 2;
            this.stcprecv.Text = "";
            // 
            // groupBox25
            // 
            this.groupBox25.Controls.Add(this.listtcp);
            this.groupBox25.Location = new System.Drawing.Point(768, 10);
            this.groupBox25.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox25.Size = new System.Drawing.Size(460, 177);
            this.groupBox25.TabIndex = 1;
            this.groupBox25.TabStop = false;
            this.groupBox25.Text = "Client";
            // 
            // listtcp
            // 
            this.listtcp.FormattingEnabled = true;
            this.listtcp.ItemHeight = 20;
            this.listtcp.Location = new System.Drawing.Point(12, 33);
            this.listtcp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listtcp.Name = "listtcp";
            this.listtcp.Size = new System.Drawing.Size(428, 124);
            this.listtcp.TabIndex = 0;
            // 
            // groupBox24
            // 
            this.groupBox24.Controls.Add(this.btStop);
            this.groupBox24.Controls.Add(this.btListen);
            this.groupBox24.Controls.Add(this.stcpport);
            this.groupBox24.Controls.Add(this.label62);
            this.groupBox24.Location = new System.Drawing.Point(303, 10);
            this.groupBox24.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox24.Size = new System.Drawing.Size(452, 177);
            this.groupBox24.TabIndex = 0;
            this.groupBox24.TabStop = false;
            this.groupBox24.Text = "Server Setting";
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(286, 105);
            this.btStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(138, 55);
            this.btStop.TabIndex = 3;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btListen
            // 
            this.btListen.Location = new System.Drawing.Point(140, 105);
            this.btListen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btListen.Name = "btListen";
            this.btListen.Size = new System.Drawing.Size(138, 55);
            this.btListen.TabIndex = 2;
            this.btListen.Text = "Listen";
            this.btListen.UseVisualStyleBackColor = true;
            this.btListen.Click += new System.EventHandler(this.btListen_Click);
            // 
            // stcpport
            // 
            this.stcpport.Location = new System.Drawing.Point(140, 42);
            this.stcpport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stcpport.Name = "stcpport";
            this.stcpport.Size = new System.Drawing.Size(278, 26);
            this.stcpport.TabIndex = 1;
            this.stcpport.Text = "6000";
            this.stcpport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Port_KeyPress);
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(26, 53);
            this.label62.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(80, 20);
            this.label62.TabIndex = 0;
            this.label62.Text = " TCP Port:";
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.groupBox26);
            this.tabPage9.Controls.Add(this.bttcpsend);
            this.tabPage9.Controls.Add(this.label69);
            this.tabPage9.Controls.Add(this.ctctsend);
            this.tabPage9.Controls.Add(this.label68);
            this.tabPage9.Controls.Add(this.ctctrecv);
            this.tabPage9.Location = new System.Drawing.Point(4, 4);
            this.tabPage9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage9.Size = new System.Drawing.Size(1600, 864);
            this.tabPage9.TabIndex = 3;
            this.tabPage9.Text = "   TCP Client   ";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // groupBox26
            // 
            this.groupBox26.Controls.Add(this.bttcpdisconnect);
            this.groupBox26.Controls.Add(this.bttcpconnect);
            this.groupBox26.Controls.Add(this.remotePort);
            this.groupBox26.Controls.Add(this.label71);
            this.groupBox26.Controls.Add(this.tcpremoteIp);
            this.groupBox26.Controls.Add(this.label70);
            this.groupBox26.Location = new System.Drawing.Point(314, 10);
            this.groupBox26.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox26.Name = "groupBox26";
            this.groupBox26.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox26.Size = new System.Drawing.Size(926, 105);
            this.groupBox26.TabIndex = 9;
            this.groupBox26.TabStop = false;
            this.groupBox26.Text = "Setting";
            // 
            // bttcpdisconnect
            // 
            this.bttcpdisconnect.Location = new System.Drawing.Point(782, 42);
            this.bttcpdisconnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttcpdisconnect.Name = "bttcpdisconnect";
            this.bttcpdisconnect.Size = new System.Drawing.Size(135, 38);
            this.bttcpdisconnect.TabIndex = 26;
            this.bttcpdisconnect.Text = "Disconnect";
            this.bttcpdisconnect.UseVisualStyleBackColor = true;
            this.bttcpdisconnect.Click += new System.EventHandler(this.bttcpdisconnect_Click);
            // 
            // bttcpconnect
            // 
            this.bttcpconnect.Location = new System.Drawing.Point(622, 42);
            this.bttcpconnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttcpconnect.Name = "bttcpconnect";
            this.bttcpconnect.Size = new System.Drawing.Size(135, 38);
            this.bttcpconnect.TabIndex = 25;
            this.bttcpconnect.Text = "Connect";
            this.bttcpconnect.UseVisualStyleBackColor = true;
            this.bttcpconnect.Click += new System.EventHandler(this.bttcpconnect_Click);
            // 
            // remotePort
            // 
            this.remotePort.Location = new System.Drawing.Point(402, 42);
            this.remotePort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.remotePort.Name = "remotePort";
            this.remotePort.Size = new System.Drawing.Size(139, 26);
            this.remotePort.TabIndex = 24;
            this.remotePort.Text = "27011";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(340, 50);
            this.label71.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(42, 20);
            this.label71.TabIndex = 23;
            this.label71.Text = "Port:";
            // 
            // tcpremoteIp
            // 
            this.tcpremoteIp.IpAddressStr = "192.168.0.250";
            this.tcpremoteIp.Location = new System.Drawing.Point(118, 42);
            this.tcpremoteIp.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tcpremoteIp.Name = "tcpremoteIp";
            this.tcpremoteIp.Size = new System.Drawing.Size(182, 35);
            this.tcpremoteIp.TabIndex = 22;
            this.tcpremoteIp.Tag = "";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(21, 50);
            this.label70.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(78, 20);
            this.label70.TabIndex = 0;
            this.label70.Text = "Server IP:";
            // 
            // bttcpsend
            // 
            this.bttcpsend.Enabled = false;
            this.bttcpsend.Location = new System.Drawing.Point(1095, 132);
            this.bttcpsend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttcpsend.Name = "bttcpsend";
            this.bttcpsend.Size = new System.Drawing.Size(135, 38);
            this.bttcpsend.TabIndex = 8;
            this.bttcpsend.Text = "Send";
            this.bttcpsend.UseVisualStyleBackColor = true;
            this.bttcpsend.Click += new System.EventHandler(this.bttcpsend_Click);
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(316, 143);
            this.label69.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(125, 20);
            this.label69.TabIndex = 7;
            this.label69.Text = "Send data(Hex):";
            // 
            // ctctsend
            // 
            this.ctctsend.Location = new System.Drawing.Point(314, 178);
            this.ctctsend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctctsend.Multiline = true;
            this.ctctsend.Name = "ctctsend";
            this.ctctsend.Size = new System.Drawing.Size(924, 141);
            this.ctctsend.TabIndex = 6;
            this.ctctsend.Text = "04 FF 21 19 95";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(316, 335);
            this.label68.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(144, 20);
            this.label68.TabIndex = 5;
            this.label68.Text = "Receive data(Hex):";
            // 
            // ctctrecv
            // 
            this.ctctrecv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ctctrecv.EnableAutoDragDrop = true;
            this.ctctrecv.Location = new System.Drawing.Point(314, 368);
            this.ctctrecv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctctrecv.Name = "ctctrecv";
            this.ctctrecv.Size = new System.Drawing.Size(924, 414);
            this.ctctrecv.TabIndex = 4;
            this.ctctrecv.Text = "";
            // 
            // btFlashCl
            // 
            this.btFlashCl.Location = new System.Drawing.Point(1408, 962);
            this.btFlashCl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btFlashCl.Name = "btFlashCl";
            this.btFlashCl.Size = new System.Drawing.Size(150, 38);
            this.btFlashCl.TabIndex = 5;
            this.btFlashCl.Text = "Refresh";
            this.btFlashCl.UseVisualStyleBackColor = true;
            this.btFlashCl.Click += new System.EventHandler(this.btFlashCl_Click);
            // 
            // timer_answer
            // 
            this.timer_answer.Interval = 5;
            this.timer_answer.Tick += new System.EventHandler(this.timer_answer_Tick);
            // 
            // timer_runmode
            // 
            this.timer_runmode.Interval = 50;
            this.timer_runmode.Tick += new System.EventHandler(this.timer_runmode_Tick);
            // 
            // timer_EAS
            // 
            this.timer_EAS.Tick += new System.EventHandler(this.timer_EAS_Tick);
            // 
            // Timer_Test_6B
            // 
            this.Timer_Test_6B.Tick += new System.EventHandler(this.Timer_Test_6B_Tick);
            // 
            // timer_Buff
            // 
            this.timer_Buff.Interval = 20;
            this.timer_Buff.Tick += new System.EventHandler(this.timer_Buff_Tick);
            // 
            // timer_RealTime
            // 
            this.timer_RealTime.Interval = 50;
            this.timer_RealTime.Tick += new System.EventHandler(this.timer_RealTime_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1618, 1050);
            this.Controls.Add(this.btFlashCl);
            this.Controls.Add(this.Maintab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lrtxtLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UHFReader288 Demo V1.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Maintab.ResumeLayout(false);
            this.Main_Page1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Basic.ResumeLayout(false);
            this.group_maxtime.ResumeLayout(false);
            this.gbp_buff.ResumeLayout(false);
            this.gbp_buff.PerformLayout();
            this.gpb_clock.ResumeLayout(false);
            this.gpb_clock.PerformLayout();
            this.gpb_antconfig.ResumeLayout(false);
            this.gpb_antconfig.PerformLayout();
            this.gpb_checkant.ResumeLayout(false);
            this.gpb_checkant.PerformLayout();
            this.gpb_GPIO.ResumeLayout(false);
            this.gpb_GPIO.PerformLayout();
            this.gpb_OutputRep.ResumeLayout(false);
            this.gpb_OutputRep.PerformLayout();
            this.gpb_Relay.ResumeLayout(false);
            this.gpb_Relay.PerformLayout();
            this.gpb_baud.ResumeLayout(false);
            this.gpb_DBM.ResumeLayout(false);
            this.gpb_DBM.PerformLayout();
            this.gpb_Freq.ResumeLayout(false);
            this.gpb_Freq.PerformLayout();
            this.gpb_beep.ResumeLayout(false);
            this.gpb_beep.PerformLayout();
            this.gpb_RDVersion.ResumeLayout(false);
            this.gpb_RDVersion.PerformLayout();
            this.gpb_MDVersion.ResumeLayout(false);
            this.gpb_MDVersion.PerformLayout();
            this.gpb_Serial.ResumeLayout(false);
            this.gpb_Serial.PerformLayout();
            this.gpb_address.ResumeLayout(false);
            this.gpb_address.PerformLayout();
            this.gpb_tcp.ResumeLayout(false);
            this.gpb_tcp.PerformLayout();
            this.gpb_rs232.ResumeLayout(false);
            this.gpb_rs232.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage_Mx.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gbp_trigger.ResumeLayout(false);
            this.gbp_trigger.PerformLayout();
            this.groupBox43.ResumeLayout(false);
            this.groupBox43.PerformLayout();
            this.groupBox44.ResumeLayout(false);
            this.groupBox44.PerformLayout();
            this.groupBox37.ResumeLayout(false);
            this.groupBox37.PerformLayout();
            this.groupBox36.ResumeLayout(false);
            this.groupBox36.PerformLayout();
            this.gbp_tagType.ResumeLayout(false);
            this.gbp_tagType.PerformLayout();
            this.groupBox35.ResumeLayout(false);
            this.groupBox35.PerformLayout();
            this.gbp_Response.ResumeLayout(false);
            this.gbp_Response.PerformLayout();
            this.gbp_mask.ResumeLayout(false);
            this.gbp_mask.PerformLayout();
            this.gbp_EASAcc.ResumeLayout(false);
            this.gbp_EASAcc.PerformLayout();
            this.tabPage_Module.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.groupBox39.ResumeLayout(false);
            this.groupBox39.PerformLayout();
            this.groupBox38.ResumeLayout(false);
            this.groupBox38.PerformLayout();
            this.groupBox34.ResumeLayout(false);
            this.groupBox34.PerformLayout();
            this.groupBox33.ResumeLayout(false);
            this.groupBox33.PerformLayout();
            this.groupBox32.ResumeLayout(false);
            this.groupBox32.PerformLayout();
            this.groupBox28.ResumeLayout(false);
            this.groupBox28.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Main_Page2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage_answer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLedControl1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.group_ant1.ResumeLayout(false);
            this.group_ant1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage_active.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_toltime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_toltag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_cmdsud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_Num)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.tabPage_Realtime.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.groupBox41.ResumeLayout(false);
            this.groupBox41.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_Mtime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_Mtag)).EndInit();
            this.groupBox42.ResumeLayout(false);
            this.tabPage_Buff.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.groupBox27.ResumeLayout(false);
            this.group_ant2.ResumeLayout(false);
            this.group_ant2.PerformLayout();
            this.groupBox29.ResumeLayout(false);
            this.groupBox29.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox30.ResumeLayout(false);
            this.groupBox30.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_cmdTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_Btoltime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_Btoltag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_Bcmdsud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxLed_BNum)).EndInit();
            this.tabPage_RW.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox31.ResumeLayout(false);
            this.groupBox31.PerformLayout();
            this.groupBox40.ResumeLayout(false);
            this.groupBox40.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.Main_Page3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.Main_Page4.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.groupBox51.ResumeLayout(false);
            this.groupBox51.PerformLayout();
            this.panel_StaticIp.ResumeLayout(false);
            this.panel_StaticIp.PerformLayout();
            this.groupBox50.ResumeLayout(false);
            this.panel_TCP.ResumeLayout(false);
            this.panel_TCP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcpRemotePortNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcpLocalPortNUD)).EndInit();
            this.groupBox49.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.groupBox47.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.groupBox25.ResumeLayout(false);
            this.groupBox24.ResumeLayout(false);
            this.groupBox24.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.groupBox26.ResumeLayout(false);
            this.groupBox26.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControl.LogRichTextBox lrtxtLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl Maintab;
        private System.Windows.Forms.TabPage Main_Page1;
        private System.Windows.Forms.TabPage Main_Page2;
        private System.Windows.Forms.TabPage Main_Page3;
        private System.Windows.Forms.TabPage Main_Page4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Basic;
        private System.Windows.Forms.GroupBox gpb_rs232;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_tcp;
        private System.Windows.Forms.RadioButton rb_rs232;
        private System.Windows.Forms.TabPage tabPage_Mx;
        private System.Windows.Forms.Button btDisConnect232;
        private System.Windows.Forms.Button btConnect232;
        private System.Windows.Forms.ComboBox ComboBox_baud2;
        private System.Windows.Forms.Label label47;
        internal System.Windows.Forms.ComboBox ComboBox_COM;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gpb_tcp;
        private System.Windows.Forms.Button btDisConnectTcp;
        private System.Windows.Forms.Button btConnectTcp;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Port;
        private CustomControl.IpAddressTextBox ipServerIP;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage_answer;
        private System.Windows.Forms.TabPage tabPage_active;
        private System.Windows.Forms.Button btFlashCl;
        private System.Windows.Forms.Timer timer_answer;
        private System.Windows.Forms.Panel panel1;
        private LxControl.LxLedControl lxLedControl5;
        private System.Windows.Forms.Label label9;
        private LxControl.LxLedControl lxLedControl4;
        private System.Windows.Forms.Label label8;
        private LxControl.LxLedControl lxLedControl3;
        private System.Windows.Forms.Label label7;
        private LxControl.LxLedControl lxLedControl2;
        private System.Windows.Forms.Label label6;
        private LxControl.LxLedControl lxLedControl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox com_scantime;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.ComboBox com_S;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox com_Q;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.GroupBox group_ant1;
        public System.Windows.Forms.CheckBox check_ant4;
        public System.Windows.Forms.CheckBox check_ant3;
        public System.Windows.Forms.CheckBox check_ant2;
        public System.Windows.Forms.CheckBox check_ant1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_tid;
        private System.Windows.Forms.RadioButton rb_epc;
        private System.Windows.Forms.Button btIventoryG2;
        private System.Windows.Forms.GroupBox gpb_address;
        private System.Windows.Forms.TextBox text_address;
        private System.Windows.Forms.Button btaddress;
        private System.Windows.Forms.GroupBox gpb_MDVersion;
        private System.Windows.Forms.TextBox text_MDVersion;
        private System.Windows.Forms.Button btMDVersion;
        private System.Windows.Forms.GroupBox gpb_Serial;
        private System.Windows.Forms.TextBox text_Serial;
        private System.Windows.Forms.Button btSerial;
        private System.Windows.Forms.GroupBox gpb_beep;
        private System.Windows.Forms.GroupBox gpb_RDVersion;
        private System.Windows.Forms.TextBox text_RDVersion;
        private System.Windows.Forms.RadioButton Radio_beepDis;
        private System.Windows.Forms.RadioButton Radio_beepEn;
        private System.Windows.Forms.Button Button_Beep;
        private System.Windows.Forms.GroupBox gpb_Freq;
        private System.Windows.Forms.RadioButton radioButton_band4;
        private System.Windows.Forms.RadioButton radioButton_band3;
        private System.Windows.Forms.RadioButton radioButton_band2;
        private System.Windows.Forms.RadioButton radioButton_band1;
        private System.Windows.Forms.Button btFreq;
        private System.Windows.Forms.ComboBox ComboBox_dmaxfre;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox ComboBox_dminfre;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox CheckBox_SameFre;
        private System.Windows.Forms.GroupBox gpb_DBM;
        private System.Windows.Forms.Button BT_DBM;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ComboBox_PowerDbm;
        private System.Windows.Forms.GroupBox gpb_baud;
        private System.Windows.Forms.Button btBaudRate;
        private System.Windows.Forms.ComboBox ComboBox_baud;
        private System.Windows.Forms.GroupBox gpb_Relay;
        private System.Windows.Forms.Button btRelay;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.ComboBox ComboBox_RelayTime;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.GroupBox gpb_OutputRep;
        private System.Windows.Forms.Button btOutputRep;
        private System.Windows.Forms.CheckBox check_OutputRep4;
        private System.Windows.Forms.CheckBox check_OutputRep3;
        private System.Windows.Forms.CheckBox check_OutputRep2;
        private System.Windows.Forms.CheckBox check_OutputRep1;
        private System.Windows.Forms.GroupBox gpb_antconfig;
        private System.Windows.Forms.Button Button_Ant;
        private System.Windows.Forms.CheckBox checkant4;
        private System.Windows.Forms.CheckBox checkant3;
        private System.Windows.Forms.CheckBox checkant2;
        private System.Windows.Forms.CheckBox checkant1;
        private System.Windows.Forms.GroupBox gpb_checkant;
        private System.Windows.Forms.Button btSetcheckant;
        private System.Windows.Forms.RadioButton rb_Closecheckant;
        private System.Windows.Forms.RadioButton rb_Opencheckant;
        private System.Windows.Forms.GroupBox gpb_GPIO;
        private System.Windows.Forms.Button Button_GetGPIO;
        private System.Windows.Forms.Button Button_SetGPIO;
        private System.Windows.Forms.CheckBox check_int4;
        private System.Windows.Forms.CheckBox check_int3;
        private System.Windows.Forms.CheckBox check_int2;
        private System.Windows.Forms.CheckBox check_int1;
        private System.Windows.Forms.CheckBox check_out4;
        private System.Windows.Forms.CheckBox check_out3;
        private System.Windows.Forms.CheckBox check_out2;
        private System.Windows.Forms.CheckBox check_out1;
        internal System.Windows.Forms.GroupBox gpb_clock;
        internal System.Windows.Forms.Button ClockCMD;
        internal System.Windows.Forms.RadioButton GetClock;
        internal System.Windows.Forms.RadioButton SetClock;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label40;
        internal System.Windows.Forms.Label label41;
        internal System.Windows.Forms.Label label42;
        internal System.Windows.Forms.Label label45;
        internal System.Windows.Forms.Label label46;
        internal System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.TextBox Text_sec;
        internal System.Windows.Forms.TextBox Text_min;
        internal System.Windows.Forms.TextBox Text_hour;
        internal System.Windows.Forms.TextBox Text_day;
        internal System.Windows.Forms.TextBox Text_month;
        internal System.Windows.Forms.TextBox Text_year;
        private System.Windows.Forms.Button btGetInformation;
        private System.Windows.Forms.Button btDefault;
        private System.Windows.Forms.Button btFlashROM;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbp_trigger;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Button bttrigger;
        private System.Windows.Forms.ComboBox comboBox_trigger;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.GroupBox groupBox43;
        private System.Windows.Forms.Button btGetQS;
        private System.Windows.Forms.Button btSetQS;
        private System.Windows.Forms.ComboBox com_acS;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.ComboBox com_acQ;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.GroupBox groupBox44;
        private System.Windows.Forms.TextBox text_tidlen;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.TextBox text_tidaddr;
        private System.Windows.Forms.Button btTIDpara;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Button btGetWorkmodepara;
        private System.Windows.Forms.GroupBox groupBox37;
        private System.Windows.Forms.Button btworkmode;
        private System.Windows.Forms.ComboBox comboBox_mode;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.GroupBox groupBox36;
        private System.Windows.Forms.Button btInterval;
        private System.Windows.Forms.ComboBox comboBox_intervalT;
        private System.Windows.Forms.GroupBox gbp_tagType;
        private System.Windows.Forms.RadioButton rb_G2TID;
        private System.Windows.Forms.Button bt_typeTag;
        private System.Windows.Forms.RadioButton rb_EAS;
        private System.Windows.Forms.RadioButton rb_G2;
        private System.Windows.Forms.GroupBox groupBox35;
        private System.Windows.Forms.RadioButton rb_180006B;
        private System.Windows.Forms.RadioButton rb_180006c;
        private System.Windows.Forms.GroupBox gbp_Response;
        private System.Windows.Forms.Button btResponse;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.ComboBox comboBox_RespTime;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.ComboBox comboBox_Resp;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.GroupBox gbp_mask;
        private System.Windows.Forms.Button btMaskSet;
        private System.Windows.Forms.TextBox text_mdata;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox text_mlen;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TextBox text_madds;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.RadioButton rb_MaskUser;
        private System.Windows.Forms.RadioButton rb_MaskTID;
        private System.Windows.Forms.RadioButton rb_MaskEPC;
        private System.Windows.Forms.GroupBox gbp_EASAcc;
        private System.Windows.Forms.Button btAccuracy;
        private System.Windows.Forms.ComboBox ComboBox_Accuracy;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.RadioButton rbEASAcc;
        private System.Windows.Forms.Timer timer_runmode;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btGetrunmodedata;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btClearBuffer;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btGettagbuffer;
        private System.Windows.Forms.GroupBox groupBox9;
        private LxControl.LxLedControl lxLed_cmdsud;
        private System.Windows.Forms.Label label17;
        private LxControl.LxLedControl lxLed_Num;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView2;
        private LxControl.LxLedControl lxLed_toltime;
        private System.Windows.Forms.Label label19;
        private LxControl.LxLedControl lxLed_toltag;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TabPage tabPage_RW;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox text_epc;
        private System.Windows.Forms.CheckBox check_selecttag;
        private System.Windows.Forms.Button btSelectTag;
        private System.Windows.Forms.ComboBox comboBox_EPC;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox31;
        private System.Windows.Forms.TextBox maskData_textBox;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.GroupBox groupBox40;
        private System.Windows.Forms.RadioButton R_User;
        private System.Windows.Forms.RadioButton R_TID;
        private System.Windows.Forms.RadioButton R_EPC;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox maskLen_textBox;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox maskadr_textbox;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox textBox_pc;
        private System.Windows.Forms.CheckBox checkBox_pc;
        private System.Windows.Forms.Button btBlockWrite;
        private System.Windows.Forms.Button btBlockErase;
        private System.Windows.Forms.Button btWrite;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.TextBox text_WriteData;
        private System.Windows.Forms.TextBox text_AccessCode2;
        private System.Windows.Forms.TextBox text_RWlen;
        private System.Windows.Forms.TextBox text_WordPtr;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.RadioButton C_User;
        private System.Windows.Forms.RadioButton C_TID;
        private System.Windows.Forms.RadioButton C_EPC;
        private System.Windows.Forms.RadioButton C_Reserve;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Button btSetProtectState;
        private System.Windows.Forms.TextBox Edit_AccessCode6;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.RadioButton AlwaysNot2;
        private System.Windows.Forms.RadioButton Always2;
        private System.Windows.Forms.RadioButton Proect2;
        private System.Windows.Forms.RadioButton NoProect2;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.RadioButton P_User;
        private System.Windows.Forms.RadioButton P_TID;
        private System.Windows.Forms.RadioButton P_EPC;
        private System.Windows.Forms.RadioButton P_kill;
        private System.Windows.Forms.RadioButton p_pass;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.Button btCheckEASAlarm;
        private System.Windows.Forms.Button btSetEASAlarm_G2;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.RadioButton NoAlarm_G2;
        private System.Windows.Forms.RadioButton Alarm_G2;
        private System.Windows.Forms.TextBox text_AccessCode5;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.Button btCheckReadProtected_G2;
        private System.Windows.Forms.Button btRemoveReadProtect_G2;
        private System.Windows.Forms.Button btSetMultiReadProtect_G2;
        private System.Windows.Forms.Button btSetReadProtect_G2;
        private System.Windows.Forms.TextBox text_AccessCode4;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.Button btWriteEPC_G2;
        private System.Windows.Forms.TextBox text_AccessCode3;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox text_WriteEPC;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.Button btDestroyCard;
        private System.Windows.Forms.TextBox text_DestroyCode;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Timer timer_EAS;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListView ListView_ID_6B;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.RadioButton rb_mutiple;
        private System.Windows.Forms.RadioButton rb_single;
        private System.Windows.Forms.Button btInventory6B;
        private System.Windows.Forms.Timer Timer_Test_6B;
        private System.Windows.Forms.TextBox text_6BUID;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.GroupBox groupBox23;
        private System.Windows.Forms.TextBox text_R6BLen;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox text_R6BAddr;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox text_R6B;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button btRead6B;
        private System.Windows.Forms.TextBox text_W6B;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Button btWrite6B;
        private System.Windows.Forms.TextBox text_W6BLen;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox text_W6BAddr;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.TextBox text_lock6b;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBox text_Statu6B;
        private System.Windows.Forms.Button btCheckLock6B;
        private System.Windows.Forms.Button btLock6B;
        private System.Windows.Forms.TextBox text_checkaddr;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem iEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telnetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListView DeviceListView;
        private System.Windows.Forms.ColumnHeader deviceName;
        private System.Windows.Forms.ColumnHeader deviceIP;
        private System.Windows.Forms.ColumnHeader deviceMac;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btLoadDefault;
        private System.Windows.Forms.GroupBox groupBox51;
        private System.Windows.Forms.Button btGetNet;
        private System.Windows.Forms.Button btSetNet;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.TextBox macTB;
        private System.Windows.Forms.Panel panel_StaticIp;
        private System.Windows.Forms.Label label109;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.Label label107;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.TextBox altDNSTB;
        private System.Windows.Forms.TextBox pDNSTB;
        private System.Windows.Forms.TextBox gatewayTB;
        private System.Windows.Forms.TextBox subnetTB;
        private System.Windows.Forms.TextBox ipTB;
        private System.Windows.Forms.GroupBox groupBox50;
        private System.Windows.Forms.Button btGetCnt;
        private System.Windows.Forms.Button btSetCnt;
        private System.Windows.Forms.Panel panel_TCP;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.ComboBox workasCB;
        private System.Windows.Forms.TextBox tcpRomteHostTB;
        private System.Windows.Forms.NumericUpDown tcpRemotePortNUD;
        private System.Windows.Forms.NumericUpDown tcpLocalPortNUD;
        private System.Windows.Forms.ComboBox tcpActiveCB;
        private System.Windows.Forms.GroupBox groupBox49;
        private System.Windows.Forms.Button btGetSeriaPort;
        private System.Windows.Forms.Button btSetSerialPort;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.ComboBox protocolCB;
        private System.Windows.Forms.ComboBox stopbitCB;
        private System.Windows.Forms.ComboBox parityCB;
        private System.Windows.Forms.ComboBox databitCB;
        private System.Windows.Forms.ComboBox baudrateCB;
        private System.Windows.Forms.ComboBox flowCB;
        private System.Windows.Forms.ComboBox fifoCB;
        private System.Windows.Forms.GroupBox groupBox47;
        private System.Windows.Forms.Button btExitAT;
        private System.Windows.Forms.Button btGotoAT;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.GroupBox groupBox25;
        private System.Windows.Forms.ListBox listtcp;
        private System.Windows.Forms.GroupBox groupBox24;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btListen;
        private System.Windows.Forms.TextBox stcpport;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label63;
        private CustomControl.LogRichTextBox stcprecv;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.Button bttcpsend;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.TextBox ctctsend;
        private System.Windows.Forms.Label label68;
        private CustomControl.LogRichTextBox ctctrecv;
        private System.Windows.Forms.GroupBox groupBox26;
        private System.Windows.Forms.Button bttcpdisconnect;
        private System.Windows.Forms.Button bttcpconnect;
        private System.Windows.Forms.TextBox remotePort;
        private System.Windows.Forms.Label label71;
        private CustomControl.IpAddressTextBox tcpremoteIp;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.TextBox text_target;
        private System.Windows.Forms.CheckBox check_num;
        private System.Windows.Forms.ComboBox com_Target;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.GroupBox gbp_buff;
        private System.Windows.Forms.RadioButton rb496;
        private System.Windows.Forms.RadioButton rb128;
        private System.Windows.Forms.Button btGetEPCandTIDLen;
        private System.Windows.Forms.Button btSetEPCandTIDLen;
        private System.Windows.Forms.TabPage tabPage_Buff;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.GroupBox groupBox27;
        private System.Windows.Forms.Button btQueryBuffNum;
        private System.Windows.Forms.Button btRandCbuff;
        private System.Windows.Forms.Button btClearBuff;
        private System.Windows.Forms.Button btReadBuff;
        private System.Windows.Forms.GroupBox group_ant2;
        public System.Windows.Forms.CheckBox BAnt4;
        public System.Windows.Forms.CheckBox BAnt3;
        public System.Windows.Forms.CheckBox BAnt2;
        public System.Windows.Forms.CheckBox BAnt1;
        private System.Windows.Forms.GroupBox groupBox29;
        private System.Windows.Forms.RadioButton rb_btid;
        private System.Windows.Forms.RadioButton rb_bepc;
        private System.Windows.Forms.Button btStartBuff;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.GroupBox groupBox30;
        private LxControl.LxLedControl lxLed_cmdTime;
        private System.Windows.Forms.Label label86;
        private LxControl.LxLedControl lxLed_Btoltime;
        private System.Windows.Forms.Label label91;
        private LxControl.LxLedControl lxLed_Btoltag;
        private System.Windows.Forms.Label label92;
        private LxControl.LxLedControl lxLed_Bcmdsud;
        private System.Windows.Forms.Label label94;
        private LxControl.LxLedControl lxLed_BNum;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.Timer timer_Buff;
        private System.Windows.Forms.Button btExtWrite;
        private System.Windows.Forms.Button btExtRead;
        private System.Windows.Forms.GroupBox group_maxtime;
        private System.Windows.Forms.Button btSetMaxtime;
        private System.Windows.Forms.ComboBox comboBox_maxtime;
        private System.Windows.Forms.CheckBox checkBox_rate;
        private System.Windows.Forms.TabPage tabPage_Module;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.GroupBox groupBox32;
        private System.Windows.Forms.ComboBox com_MFliterTime;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.GroupBox groupBox28;
        private System.Windows.Forms.ComboBox COM_MRPTime;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton MRB_6B;
        private System.Windows.Forms.RadioButton MRB_G2;
        private System.Windows.Forms.GroupBox groupBox33;
        private System.Windows.Forms.ComboBox com_MS;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.ComboBox com_MQ;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.GroupBox groupBox38;
        private System.Windows.Forms.TextBox txt_Mtidlen;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.TextBox txt_mtidaddr;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.GroupBox groupBox34;
        private System.Windows.Forms.TextBox txt_Mdata;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.TextBox txt_Mlen;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.TextBox txt_Maddr;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.RadioButton RBM_USER;
        private System.Windows.Forms.RadioButton RBM_TID;
        private System.Windows.Forms.RadioButton RBM_EPC;
        private System.Windows.Forms.Button btMGetParameter;
        private System.Windows.Forms.GroupBox groupBox39;
        private System.Windows.Forms.Button btSetMmode;
        private System.Windows.Forms.ComboBox com_Mmode;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Button btMSetParameter;
        private System.Windows.Forms.TabPage tabPage_Realtime;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.GroupBox groupBox41;
        private LxControl.LxLedControl lxLed_Mtime;
        private System.Windows.Forms.Label label113;
        private LxControl.LxLedControl lxLed_Mtag;
        private System.Windows.Forms.Label label116;
        private System.Windows.Forms.GroupBox groupBox42;
        private System.Windows.Forms.Button btStartMactive;
        private System.Windows.Forms.Timer timer_RealTime;
        private System.Windows.Forms.CheckBox checkBox_tid;
        private System.Windows.Forms.CheckBox checkBox_mask;
        private System.Windows.Forms.RadioButton radioButton_band8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
    }
}

