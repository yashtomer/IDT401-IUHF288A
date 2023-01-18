unit frmUHFReader288demomain;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs,fProgressbar, StdCtrls, ComCtrls,UHFReader288_Head,UHFReader288_DLL_Head,
  ActnList, Buttons, ExtCtrls, Menus, ToolWin;

type
  TfrmUHFReader288main = class(TForm)
    PageControl1: TPageControl;
    TabSheet1: TTabSheet;
    TabSheet_EPCC1G2: TTabSheet;
    StatusBar1: TStatusBar;
    GroupBox_ReaderInfo: TGroupBox;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Label10: TLabel;
    Label11: TLabel;
    Label8: TLabel;
    Label13: TLabel;
    Label14: TLabel;
    Edit_Version: TEdit;
    Edit_ComAdr: TEdit;
    Edit_scantime: TEdit;
    Edit_Type: TEdit;
    Button3: TButton;
    Edit_dmaxfre: TEdit;
    Edit_dminfre: TEdit;
    Edit_power: TEdit;
    EPCC1G2: TCheckBox;
    GroupBox2: TGroupBox;
    Label15: TLabel;
    Label16: TLabel;
    Label17: TLabel;
    Label1: TLabel;
    Label7: TLabel;
    Label5: TLabel;
    Button5: TButton;
    ComboBox_baud: TComboBox;
    Edit_NewComAdr: TEdit;
    ComboBox_scantime: TComboBox;
    Button1: TButton;
    ComboBox_dminfre: TComboBox;
    ComboBox_dmaxfre: TComboBox;
    ComboBox_PowerDbm: TComboBox;
    CheckBox_SameFre: TCheckBox;
    GroupBox7: TGroupBox;
    RadioButton_band2: TRadioButton;
    RadioButton_band3: TRadioButton;
    RadioButton_band4: TRadioButton;
    RadioButton_band5: TRadioButton;
    GroupBox11: TGroupBox;
    ListView_EPC: TListView;
    GroupBox17: TGroupBox;
    Label25: TLabel;
    SpeedButton_Query: TSpeedButton;
    ComboBox_IntervalTime: TComboBox;
    GroupBox9: TGroupBox;
    Label33: TLabel;
    Button_DestroyCard: TButton;
    Edit_DestroyCode: TEdit;
    ComboBox_EPC3: TComboBox;
    GroupBox23: TGroupBox;
    Label38: TLabel;
    Label39: TLabel;
    Edit_AccessCode3: TEdit;
    Button_WriteEPC_G2: TButton;
    Edit_WriteEPC: TEdit;
    GroupBox20: TGroupBox;
    Label32: TLabel;
    ComboBox_EPC4: TComboBox;
    Edit_AccessCode4: TEdit;
    Button_SetReadProtect_G2: TButton;
    Button_SetMultiReadProtect_G2: TButton;
    Button_RemoveReadProtect_G2: TButton;
    Button_CheckReadProtected_G2: TButton;
    GroupBox21: TGroupBox;
    Label35: TLabel;
    SpeedButton_CheckAlarm_G2: TSpeedButton;
    Label_Alarm: TLabel;
    Button_SetEASAlarm_G2: TButton;
    ComboBox_EPC5: TComboBox;
    Edit_AccessCode5: TEdit;
    GroupBox24: TGroupBox;
    Alarm_G2: TRadioButton;
    NoAlarm_G2: TRadioButton;
    GroupBox5: TGroupBox;
    Label24: TLabel;
    ComboBox_EPC1: TComboBox;
    Button_SetProtectState: TButton;
    Edit_AccessCode1: TEdit;
    GroupBox1: TGroupBox;
    P_Reserve: TRadioButton;
    P_EPC: TRadioButton;
    P_TID: TRadioButton;
    P_User: TRadioButton;
    GroupBox16: TGroupBox;
    GroupBox4: TGroupBox;
    DestroyCode: TRadioButton;
    AccessCode: TRadioButton;
    NoProect: TRadioButton;
    Always: TRadioButton;
    Proect: TRadioButton;
    AlwaysNot: TRadioButton;
    GroupBox18: TGroupBox;
    NoProect2: TRadioButton;
    AlwaysNot2: TRadioButton;
    Proect2: TRadioButton;
    Always2: TRadioButton;
    GroupBox10: TGroupBox;
    Label9: TLabel;
    Label18: TLabel;
    Label19: TLabel;
    Label20: TLabel;
    SpeedButton_Read_G2: TSpeedButton;
    ComboBox_EPC2: TComboBox;
    Edit_AccessCode2: TEdit;
    Edit_WriteData: TEdit;
    Edit_WordPtr: TEdit;
    Edit_Len: TEdit;
    Memo_DataShow: TMemo;
    GroupBox6: TGroupBox;
    C_Reserve: TRadioButton;
    C_EPC: TRadioButton;
    C_TID: TRadioButton;
    C_User: TRadioButton;
    Button16: TButton;
    Button_DataWrite: TButton;
    Button_BlockErase: TButton;
    Timer_Test_: TTimer;
    Timer_G2_Read: TTimer;
    Button_BlockWrite: TButton;
    Timer_G2_Alarm: TTimer;
    Timer1: TTimer;
    Timer_Test_6B: TTimer;
    Timer_6B_ReadWrite: TTimer;
    TabSheet3: TTabSheet;
    Label62: TLabel;
    Label63: TLabel;
    Label64: TLabel;
    ListBox1: TListBox;
    Button21: TButton;
    Button23: TButton;
    Button24: TButton;
    GroupBox28: TGroupBox;
    Check_out1: TCheckBox;
    Check_out2: TCheckBox;
    Check_out3: TCheckBox;
    Check_out4: TCheckBox;
    Button_OutputRep: TButton;
    GroupBox29: TGroupBox;
    Label45: TLabel;
    Label46: TLabel;
    ComboBox_RelayTime: TComboBox;
    Button_RelayTime: TButton;
    GroupBox31: TGroupBox;
    Label52: TLabel;
    Edit6: TEdit;
    Label65: TLabel;
    Edit11: TEdit;
    CheckBox_TID: TCheckBox;
    CheckBox18: TCheckBox;
    Edit_PC: TEdit;
    TabSheet4: TTabSheet;
    GroupBox42: TGroupBox;
    ListView2: TListView;
    MainMenu1: TMainMenu;
    Operation1: TMenuItem;
    Search1: TMenuItem;
    clear1: TMenuItem;
    xxit1: TMenuItem;
    tools1: TMenuItem;
    IE1: TMenuItem;
    elnet1: TMenuItem;
    Ping1: TMenuItem;
    Language1: TMenuItem;
    English1: TMenuItem;
    Help1: TMenuItem;
    About1: TMenuItem;
    GroupBox43: TGroupBox;
    RadioButton13: TRadioButton;
    RadioButton14: TRadioButton;
    GroupBox_COM: TGroupBox;
    Label6: TLabel;
    Label12: TLabel;
    Label49: TLabel;
    ComboBox_COM: TComboBox;
    Button2: TButton;
    Button4: TButton;
    StaticText1: TStaticText;
    Edit_CmdComAddr: TEdit;
    ComboBox_AlreadyOpenCOM: TComboBox;
    ComboBox_baud2: TComboBox;
    GroupBox44: TGroupBox;
    Label66: TLabel;
    Label67: TLabel;
    Label68: TLabel;
    Edit12: TEdit;
    Edit13: TEdit;
    Edit14: TEdit;
    opnet: TButton;
    closenet: TButton;
    TabSheet5: TTabSheet;
    GroupBox45: TGroupBox;
    Edit15: TEdit;
    Button8: TButton;
    GroupBox46: TGroupBox;
    Label69: TLabel;
    protocolCB: TComboBox;
    Label70: TLabel;
    baudrateCB: TComboBox;
    Label71: TLabel;
    parityCB: TComboBox;
    Label72: TLabel;
    fifoCB: TComboBox;
    Label73: TLabel;
    databitCB: TComboBox;
    Label74: TLabel;
    flowCB: TComboBox;
    Label75: TLabel;
    stopbitCB: TComboBox;
    Button9: TButton;
    Button25: TButton;
    GroupBox47: TGroupBox;
    Label76: TLabel;
    workasCB: TComboBox;
    Label77: TLabel;
    tcpActiveCB: TComboBox;
    Label78: TLabel;
    tcpRomteHostTB: TEdit;
    Label80: TLabel;
    tcpRemotePortNUD: TEdit;
    Label82: TLabel;
    tcpLocalPortNUD: TEdit;
    Button26: TButton;
    Button27: TButton;
    GroupBox48: TGroupBox;
    Label83: TLabel;
    ipTB: TEdit;
    Label84: TLabel;
    subnetTB: TEdit;
    Label85: TLabel;
    gatewayTB: TEdit;
    Label86: TLabel;
    pDNSTB: TEdit;
    Label87: TLabel;
    altDNSTB: TEdit;
    Label88: TLabel;
    macTB: TEdit;
    Button28: TButton;
    Button29: TButton;
    GroupBox50: TGroupBox;
    Button30: TButton;
    Button31: TButton;
    GroupBox49: TGroupBox;
    Label89: TLabel;
    Label90: TLabel;
    ComboBox6: TComboBox;
    Edit16: TEdit;
    Button32: TButton;
    Button33: TButton;
    RichEdit1: TRichEdit;
    Button34: TButton;
    Button35: TButton;
    Label79: TLabel;
    Edit17: TEdit;
    Label81: TLabel;
    Edit18: TEdit;
    CheckBox19: TCheckBox;
    Timer2: TTimer;
    ActionList1: TActionList;
    Action_GetReaderInformation: TAction;
    Action_OpenCOM: TAction;
    Action_OpenRf: TAction;
    Action_CloseCOM: TAction;
    Action_CloseRf: TAction;
    Action_WriteComAdr: TAction;
    Action_WriteInventoryScanTime: TAction;
    Action_OpenTestMode: TAction;
    Action_CloseTestMode: TAction;
    Action_GetSystemInformation: TAction;
    Action_SetReaderInformation: TAction;
    Action_SetReaderInformation_0: TAction;
    Action_Inventory: TAction;
    Action_ShowOrChangeData: TAction;
    Action_SetProtectState: TAction;
    Action_DestroyCard: TAction;
    Action_SelfTestMode: TAction;
    Action_SelfTestMode2: TAction;
    Action_RfOutput: TAction;
    Action_RfOutput2: TAction;
    Action_SetDAC: TAction;
    Action_GetDAC: TAction;
    Action_SetPowerParameter: TAction;
    Action_SolidifyPower: TAction;
    Action_CheckPowerParameter: TAction;
    Action_GetStartInformation: TAction;
    Action_ReadPowerParameter: TAction;
    Action_Inventroy_6B: TAction;
    Action_Query_6B: TAction;
    Action_WriteData_6B: TAction;
    Action_ReadData_6B: TAction;
    Action_LockByte_6B: TAction;
    Action_CheckLock_6B: TAction;
    Action_Query2_6B: TAction;
    Action_ShowOrChangeData_write: TAction;
    Action_ShowOrChangeData_BlockErase: TAction;
    Action_SetReadProtect_G2: TAction;
    Action_RemoveReadProtect_G2: TAction;
    Action_SetMultiReadProtect_G2: TAction;
    Action_CheckReadProtected_G2: TAction;
    Action_SetEASAlarm_G2: TAction;
    Action_CheckEASAlarm_G2: TAction;
    Action_WriteEPC_G2: TAction;
    Action_LockUserBlock_G2: TAction;
    Action_WriteList: TAction;
    Action_SolidifyPWMandPowerlist: TAction;
    Action_DeleteRfOutput: TAction;
    Action_ShowOrChangeData_BlockWrite: TAction;
    Action_TagProtocol: TAction;
    Label102: TLabel;
    Com_Q: TComboBox;
    Label103: TLabel;
    Com_S: TComboBox;
    GroupBox32: TGroupBox;
    Label42: TLabel;
    Label43: TLabel;
    Label21: TLabel;
    CheckBox1: TCheckBox;
    Edit2: TEdit;
    Edit3: TEdit;
    GroupBox3: TGroupBox;
    R_EPC: TRadioButton;
    R_TID: TRadioButton;
    R_User: TRadioButton;
    Edit1: TEdit;
    TabSheet_6B: TTabSheet;
    GroupBox13: TGroupBox;
    ListView_ID_6B: TListView;
    GroupBox19: TGroupBox;
    Label30: TLabel;
    SpeedButton_Query_6B: TSpeedButton;
    ComboBox_IntervalTime_6B: TComboBox;
    Byone_6B: TRadioButton;
    Bycondition_6B: TRadioButton;
    GroupBox14: TGroupBox;
    Label34: TLabel;
    Label31: TLabel;
    Edit_Query_StartAddress_6B: TEdit;
    Edit_ConditionContent_6B: TEdit;
    Less_6B: TRadioButton;
    Different_6B: TRadioButton;
    Same_6B: TRadioButton;
    Greater_6B: TRadioButton;
    GroupBox15: TGroupBox;
    Label40: TLabel;
    Label41: TLabel;
    Label44: TLabel;
    SpeedButton_Read_6B: TSpeedButton;
    SpeedButton_Write_6B: TSpeedButton;
    ComboBox_ID1_6B: TComboBox;
    Edit_WriteData_6B: TEdit;
    Edit_StartAddress_6B: TEdit;
    Edit_Len_6B: TEdit;
    Memo_DataShow_6B: TMemo;
    Button10: TButton;
    Button11: TButton;
    Button12: TButton;
    ISO180006B: TCheckBox;
    TabSheet_active: TTabSheet;
    GroupBox27: TGroupBox;
    Label53: TLabel;
    RadioButton1: TRadioButton;
    RadioButton2: TRadioButton;
    ComboBox_Accuracy: TComboBox;
    Button_Accuracy: TButton;
    GroupBox33: TGroupBox;
    Label54: TLabel;
    Label55: TLabel;
    Label56: TLabel;
    RadioButton3: TRadioButton;
    RadioButton4: TRadioButton;
    RadioButton5: TRadioButton;
    Edit7: TEdit;
    Edit9: TEdit;
    Edit10: TEdit;
    Button13: TButton;
    GroupBox34: TGroupBox;
    Label57: TLabel;
    Label58: TLabel;
    Label59: TLabel;
    ComboBox1: TComboBox;
    ComboBox2: TComboBox;
    Button14: TButton;
    GroupBox35: TGroupBox;
    GroupBox37: TGroupBox;
    RadioButton6: TRadioButton;
    RadioButton7: TRadioButton;
    RadioButton8: TRadioButton;
    RadioButton10: TRadioButton;
    Button15: TButton;
    RadioButton11: TRadioButton;
    GroupBox30: TGroupBox;
    Label50: TLabel;
    Label51: TLabel;
    Button18: TButton;
    Edit5: TEdit;
    Edit8: TEdit;
    GroupBox36: TGroupBox;
    Label60: TLabel;
    ComboBox3: TComboBox;
    Button19: TButton;
    GroupBox38: TGroupBox;
    Label61: TLabel;
    ComboBox4: TComboBox;
    Button20: TButton;
    Button22: TButton;
    GroupBox39: TGroupBox;
    Button36: TButton;
    ListView1: TListView;
    Button_clearBuffer: TButton;
    GroupBox40: TGroupBox;
    SpeedButton1: TSpeedButton;
    Memo1: TMemo;
    Button37: TButton;
    GroupBox25: TGroupBox;
    Label47: TLabel;
    ComboBox5: TComboBox;
    ComboBox13: TComboBox;
    Label48: TLabel;
    Button17: TButton;
    Button38: TButton;
    Check_ant1: TCheckBox;
    Check_ant2: TCheckBox;
    Check_ant3: TCheckBox;
    Check_ant4: TCheckBox;
    Label91: TLabel;
    ComboBox14: TComboBox;
    grp_version: TGroupBox;
    Edit19: TEdit;
    Button39: TButton;
    GroupBox51: TGroupBox;
    Label92: TLabel;
    Label93: TLabel;
    ComboBox7: TComboBox;
    Button41: TButton;
    Button43: TButton;
    Button44: TButton;
    Group_Fenti: TGroupBox;
    Button_SetGPIO: TButton;
    Button_GetGPIO: TButton;
    COUT1: TCheckBox;
    COUT2: TCheckBox;
    COUT3: TCheckBox;
    COUT4: TCheckBox;
    CINT1: TCheckBox;
    CINT2: TCheckBox;
    CINT3: TCheckBox;
    CINT4: TCheckBox;
    grp_bufflen: TGroupBox;
    rb128: TRadioButton;
    rb496: TRadioButton;
    btSetSaveLen: TButton;
    btGetSaveLen: TButton;
    grp_antconfig: TGroupBox;
    Button_Ant: TButton;
    cant4: TCheckBox;
    cant3: TCheckBox;
    cant2: TCheckBox;
    cant1: TCheckBox;
    grp_checkant: TGroupBox;
    OpenANT: TRadioButton;
    CloseANT: TRadioButton;
    Button6: TButton;
    GroupBox8: TGroupBox;
    Radio_beepEn: TRadioButton;
    Radio_beepDis: TRadioButton;
    Button_Beep: TButton;
    grp_timer: TGroupBox;
    Label22: TLabel;
    Label23: TLabel;
    Label26: TLabel;
    Label27: TLabel;
    Label28: TLabel;
    Label29: TLabel;
    Edit_year: TEdit;
    Edit_Month: TEdit;
    Edit_date: TEdit;
    Edit_Hour: TEdit;
    Edit_minute: TEdit;
    Edit_Sedcond: TEdit;
    ClockCMD: TButton;
    RadioButton_SetClock: TRadioButton;
    RadioButton_GetClock: TRadioButton;
    Edit4: TEdit;
    Button7: TButton;
    Edit_Min: TEdit;
    TabSheet_Real: TTabSheet;
    GroupBox12: TGroupBox;
    rbm_G2: TRadioButton;
    rbm_6B: TRadioButton;
    GroupBox26: TGroupBox;
    Label94: TLabel;
    COM_MRPTime: TComboBox;
    GroupBox52: TGroupBox;
    Label95: TLabel;
    com_MFliterTime: TComboBox;
    GroupBox53: TGroupBox;
    Label96: TLabel;
    com_MQ: TComboBox;
    Label97: TLabel;
    com_MS: TComboBox;
    GroupBox54: TGroupBox;
    Label98: TLabel;
    Label99: TLabel;
    Label100: TLabel;
    rbm_epc: TRadioButton;
    rbm_tid: TRadioButton;
    rbm_user: TRadioButton;
    txt_maddr: TEdit;
    txt_mlen: TEdit;
    txt_mdata: TEdit;
    GroupBox55: TGroupBox;
    Label101: TLabel;
    Label104: TLabel;
    txt_tidadr: TEdit;
    txt_tidlen: TEdit;
    CheckBox_Mask: TCheckBox;
    Check_TID: TCheckBox;
    GroupBox41: TGroupBox;
    com_mwork: TComboBox;
    bt_setwork: TButton;
    bt_SetParameter: TButton;
    bt_GetParameter: TButton;
    Memo2: TMemo;
    SpeedButton2: TSpeedButton;
    Button40: TButton;
    RadioButton_band1: TRadioButton;
    TabSheet_Buff: TTabSheet;
    GroupBox56: TGroupBox;
    btStartBuffer: TButton;
    rb_BEPC: TRadioButton;
    rb_BTID: TRadioButton;
    GroupBox58: TGroupBox;
    btGetBuffer: TButton;
    btGetAndClBuffer: TButton;
    btClearBuffer: TButton;
    btGetBufferNum: TButton;
    Label106: TLabel;
    btClear: TButton;
    ListView3: TListView;
    Timer_Buff: TTimer;
    GroupBox59: TGroupBox;
    Check_BANT1: TCheckBox;
    Check_BANT2: TCheckBox;
    Check_BANT3: TCheckBox;
    Check_BANT4: TCheckBox;
    lb_Num: TLabel;
    Label105: TLabel;
    Action_Real: TAction;
    Action_Buff: TAction;
    grp_comType: TGroupBox;
    RB_Usb: TRadioButton;
    RB_Uart: TRadioButton;
    Button42: TButton;
    ToolBar1: TToolBar;
    procedure FormCreate(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure Button4Click(Sender: TObject);
    procedure Action_GetReaderInformationExecute(Sender: TObject);
    procedure ComboBox_AlreadyOpenCOMCloseUp(Sender: TObject);
    procedure Action_SetReaderInformationExecute(Sender: TObject);
    procedure RadioButton_band1Click(Sender: TObject);
    procedure RadioButton_band2Click(Sender: TObject);
    procedure RadioButton_band3Click(Sender: TObject);
    procedure RadioButton_band4Click(Sender: TObject);
    procedure RadioButton_band5Click(Sender: TObject);
    procedure Action_SelfTestModeExecute(Sender: TObject);
    procedure Action_GetReaderInformationUpdate(Sender: TObject);
    procedure Action_RfOutputExecute(Sender: TObject);
    procedure CheckBox_SameFreClick(Sender: TObject);
    procedure Edit2KeyPress(Sender: TObject; var Key: Char);
    procedure SpeedButton_QueryClick(Sender: TObject);
    procedure Action_InventoryExecute(Sender: TObject);
    procedure Timer_Test_Timer(Sender: TObject);
    procedure ComboBox_IntervalTimeChange(Sender: TObject);
    procedure SpeedButton_Read_G2Click(Sender: TObject);
    procedure Timer_G2_ReadTimer(Sender: TObject);
    procedure Action_ShowOrChangeDataExecuteExecute(Sender: TObject);
    procedure Action_SetProtectStateExecute(Sender: TObject);
    procedure Action_SetProtectStateUpdate(Sender: TObject);
    procedure Action_DestroyCardExecute(Sender: TObject);
    procedure Action_WriteEPC_G2Execute(Sender: TObject);
    procedure Action_SetReadProtect_G2Execute(Sender: TObject);
    procedure Action_SetMultiReadProtect_G2Execute(Sender: TObject);
    procedure Action_RemoveReadProtect_G2Execute(Sender: TObject);
    procedure Action_CheckReadProtected_G2Execute(Sender: TObject);
    procedure Action_SetEASAlarm_G2Execute(Sender: TObject);
    procedure SpeedButton_CheckAlarm_G2Click(Sender: TObject);
    procedure Timer_G2_AlarmTimer(Sender: TObject);
    procedure PageControl1Change(Sender: TObject);
    procedure Button_AntClick(Sender: TObject);
    procedure Button_BeepClick(Sender: TObject);
    procedure Edit8KeyPress(Sender: TObject; var Key: Char);
    procedure Button_clearBufferClick(Sender: TObject);
    procedure Button_RelayTimeClick(Sender: TObject);
    procedure Button_OutputRepClick(Sender: TObject);
    procedure ComboBox_dminfreSelect(Sender: TObject);
    procedure Button16Click(Sender: TObject);
    procedure Button21Click(Sender: TObject);
    procedure Button23Click(Sender: TObject);
    procedure Button24Click(Sender: TObject);
    procedure ComboBox_COMChange(Sender: TObject);
    procedure CheckBox_TIDClick(Sender: TObject);
    procedure Edit_WriteDataKeyPress(Sender: TObject; var Key: Char);
    procedure RadioButton13Click(Sender: TObject);
    procedure opnetClick(Sender: TObject);
    procedure closenetClick(Sender: TObject);
    procedure RadioButton14Click(Sender: TObject);
    procedure ListView2DblClick(Sender: TObject);
    procedure Search1Click(Sender: TObject);
    procedure clear1Click(Sender: TObject);
    procedure IE1Click(Sender: TObject);
    procedure xxit1Click(Sender: TObject);
    procedure elnet1Click(Sender: TObject);
    procedure Ping1Click(Sender: TObject);
    procedure FormCloseQuery(Sender: TObject; var CanClose: Boolean);
    procedure FormDestroy(Sender: TObject);
    procedure C_UserClick(Sender: TObject);
    procedure C_TIDClick(Sender: TObject);
    procedure C_ReserveClick(Sender: TObject);
    procedure C_EPCClick(Sender: TObject);
    procedure CheckBox18Click(Sender: TObject);
    procedure Edit_WriteDataChange(Sender: TObject);
    procedure Button8Click(Sender: TObject);
    procedure Button30Click(Sender: TObject);
    procedure Button31Click(Sender: TObject);
    procedure Button32Click(Sender: TObject);
    procedure Button33Click(Sender: TObject);
    procedure Button9Click(Sender: TObject);
    procedure Button25Click(Sender: TObject);
    procedure Button26Click(Sender: TObject);
    procedure Button27Click(Sender: TObject);
    procedure Button28Click(Sender: TObject);
    procedure Button29Click(Sender: TObject);
    procedure Button34Click(Sender: TObject);
    procedure Button35Click(Sender: TObject);
    procedure Button6Click(Sender: TObject);
    procedure ClockCMDClick(Sender: TObject);
    procedure Button_SetGPIOClick(Sender: TObject);
    procedure Button_GetGPIOClick(Sender: TObject);
    procedure Action_Query_6BExecute(Sender: TObject);
    procedure Action_Inventroy_6BExecute(Sender: TObject);
    procedure Action_LockByte_6BExecute(Sender: TObject);
    procedure Action_CheckLock_6BExecute(Sender: TObject);
    procedure Action_CheckLock_6BUpdate(Sender: TObject);
    procedure Timer_Test_6BTimer(Sender: TObject);
    procedure SpeedButton_Read_6BClick(Sender: TObject);
    procedure Timer_6B_ReadWriteTimer(Sender: TObject);
    procedure Button12Click(Sender: TObject);
    procedure ComboBox_IntervalTime_6BChange(Sender: TObject);
    procedure Button_AccuracyClick(Sender: TObject);
    procedure Button13Click(Sender: TObject);
    procedure Button14Click(Sender: TObject);
    procedure Button18Click(Sender: TObject);
    procedure Button19Click(Sender: TObject);
    procedure Button20Click(Sender: TObject);
    procedure Button22Click(Sender: TObject);
    procedure SpeedButton1Click(Sender: TObject);
    procedure Timer1Timer(Sender: TObject);
    procedure Button37Click(Sender: TObject);
    procedure Button36Click(Sender: TObject);
    procedure Action_TagProtocolExecute(Sender: TObject);
    procedure Action_TagProtocolUpdate(Sender: TObject);
    procedure Button17Click(Sender: TObject);
    procedure Button38Click(Sender: TObject);
    procedure Button39Click(Sender: TObject);
    procedure Button7Click(Sender: TObject);
    procedure Button41Click(Sender: TObject);
    procedure Button44Click(Sender: TObject);
    procedure Button43Click(Sender: TObject);
    procedure SpeedButton2Click(Sender: TObject);
    procedure Timer2Timer(Sender: TObject);
    procedure bt_SetParameterClick(Sender: TObject);
    procedure bt_GetParameterClick(Sender: TObject);
    procedure Action_RealExecute(Sender: TObject);
    procedure Action_RealUpdate(Sender: TObject);
    procedure btStartBufferClick(Sender: TObject);
    procedure btClearClick(Sender: TObject);
    procedure Timer_BuffTimer(Sender: TObject);
    procedure Action_BuffExecute(Sender: TObject);
    procedure Action_BuffUpdate(Sender: TObject);
    procedure btClearBufferClick(Sender: TObject);
    procedure btGetAndClBufferClick(Sender: TObject);
    procedure btGetBufferNumClick(Sender: TObject);
    procedure Button42Click(Sender: TObject);
    procedure btGetSaveLenClick(Sender: TObject);
    procedure btSetSaveLenClick(Sender: TObject);
  private
    { Private declarations }
     fAppClosed: Boolean; //在测试模式下响应关闭应用程序
    fComAdr: Byte; //当前操作的ComAdr
    ComIsOpen:Boolean;
    ferrorcode:LongInt;
    fBaud:Byte;
    fdminfre:Real;
    fdmaxfre:Real;
    fCmdRet: LongInt; //所有执行指令的返回值
    fOpenComIndex: Integer; //打开的串口索引号
    ReaderType:Byte;
     x_z,y_f:Real;
    Suc_count:LongInt;
    Query_count:LongInt;
    card_Count:DWORD;
     fInventory_EPC_List: string; //存贮询查列表（如果读取的数据没有变化，则不进行刷新）
    fInventory_TID_List: string; //存贮询查列表（如果读取的数据没有变化，则不进行刷新）
    Istemps02Save: boolean;
    temps02Save: string; // 存储继续询查前上次已经询查到的卡
    fIsInventoryScan : Boolean;
    fTimer_G2_Read:Boolean;
    fTimer_G2_Alarm: Boolean;
    fisinventoryscan_6B:Boolean;
    fTimer_6B_ReadWrite:Boolean;
    ISscanstring:Boolean ;
    breakflag:Boolean;
    fOperEPC: array[0..35] of Char;
    fPassWord:array[0..4] of Char;
    fOperID_6B: array[0..8] of Char;
    fLogStrings:Tstrings;
    EnableFlag:Boolean;
    SeriaATflag:Boolean;
    Inant,FastFlag,ScanTime,Target:Byte;
    ReaderType_s:Byte;
    AA_times:LongInt;
  public
    m_hDevArray:array[0..100]of LongInt;
    select_index:LongInt;
    function getStr(pStr: pchar; len: Integer): string;
    function getHexStr(sBinStr: string): string;
    procedure getCharStr(s:string;cStr: pchar);
    procedure InitComList;
    procedure InitReaderList;
    procedure RefreshStatus;
    procedure ClearLastInfo;
    procedure AddCmdLog(cmd, cmdName: string; cmdRet: Byte; errorCode: LongInt = -1);
    procedure AddCmdLog2(cmd, cmdName: string; cmdRet: Byte; CMDReturn:string;errorCode: LongInt = -1); //操作状态成功或错误提示函数
    function RoundClassic(R: Real): Int64;
    function getNoStr(no: Integer; noLen: Integer): string;
    Function Str_IntToBin(Int: LongInt; Size: Integer): String;
    function BitStrToHextStr(const BitStr: String): String;
    procedure SearchCallback1(var devIP:DWORD;mac, devName:PChar; dev:LongInt) ;
    { Public declarations }
  end;

var
  frmUHFReader288main: TfrmUHFReader288main;
  frmcomportindex:LongInt;
implementation

uses LoginForm,DevControl,shellapi;

{$R *.dfm}

function TfrmUHFReader288main.getStr(pStr: pchar; len: Integer): string;
var
  i: Integer;
begin
  result := '';
  for i := 0 to len - 1 do
    result := result + (pStr + i)^;
end;

function TfrmUHFReader288main.getHexStr(sBinStr: string): string; //获得十六进制字符串
var
  i: Integer;
begin
  result := '';
  for i := 1 to Length(sBinStr) do
    result := result + IntToHex(ord(sBinStr[i]), 2);
end;

procedure TfrmUHFReader288main.getCharStr(s:string;cStr: pchar); //获得字符串
var
  i: Integer;
begin
  try
    for i := 0 to Length(s) div 2-1 do
    (cStr+i)^ := Char(StrToInt('$' + copy(s, i * 2 + 1, 2)));
  except
  end;
end;
procedure TfrmUHFReader288main.InitReaderList;
var
  i:Integer;
begin
  for i:=0 to 62 do
  begin
    ComboBox_dminfre.Items.Add(floattostr(902.6+i*0.4)+' MHz');
    ComboBox_dmaxfre.Items.Add(floattostr(902.6+i*0.4)+' MHz');
  end;
  ComboBox_dminfre.ItemIndex := 0;
  ComboBox_dmaxfre.ItemIndex := 62;
  for i:=$03 to $ff do
    ComboBox_scantime.Items.Add(IntToStr(i)+'*100ms');
  ComboBox_scantime.ItemIndex := 17;

  i:=10;
  while i<=1000 do
  begin
    ComboBox_IntervalTime.Items.Add(IntToStr(i)+'ms');
    i:=i+10;
  end;
  ComboBox_IntervalTime.ItemIndex :=0;




  for i:=1 to 255 do
    ComboBox_RelayTime.Items.Add(IntToStr(i)) ;
  ComboBox_RelayTime.ItemIndex:=0;


  ComboBox_Accuracy.ItemIndex:=8;

  for i:=0 to 255 do
    ComboBox2.Items.Add(IntToStr(i)) ;
  ComboBox2.ItemIndex:=0;
  ComboBox1.ItemIndex:=1;
  ComboBox3.ItemIndex:=0;
  ComboBox4.ItemIndex:=0;
  ComboBox5.ItemIndex:=4;
  ComboBox13.ItemIndex:=0;

  for i:=1 to 255 do
  ComboBox6.Items.Add(IntToStr(i)) ;
  ComboBox6.ItemIndex:=29;

  protocolCB.ItemIndex:=0;


   for i:=0 to 15 do
  Com_Q.Items.Add(IntToStr(i));
  Com_Q.ItemIndex:=4;

  for i:=0 to 3 do
  Com_S.Items.Add(IntToStr(i));
  Com_S.Items.Add('AUTO');
  Com_S.ItemIndex:=4;


   i:=40;
  while i<=300 do
  begin
  ComboBox_IntervalTime_6B.Items.Add(IntToStr(i)+'ms');
  i:=i+10;
  end;
  ComboBox_IntervalTime_6B.ItemIndex :=1;

  for i:=$03 to $ff do
    ComboBox14.Items.Add(IntToStr(i)+'*100ms');
  ComboBox14.ItemIndex := 17;

   for i:=0 to 255 do
   begin
   ComboBox7.Items.Add(IntToStr(i)) ;
   com_MFliterTime.Items.Add(IntToStr(i)+'*1s');
   end;
  ComboBox7.ItemIndex:=0;
  com_MFliterTime.ItemIndex:=0;

end;
procedure TfrmUHFReader288main.InitComList; //串口号初始化列表函数
var
  i: Integer;
begin
  ComboBox_COM.Items.Clear;
  ComboBox_COM.Items.Add(' AUTO');
  for i := 1 to 12 do
    ComboBox_COM.Items.Add(' COM' + IntToStr(i));
  ComboBox_COM.Items.Add(' USB' );
  ComboBox_COM.ItemIndex := 0;
  RefreshStatus;
end;
procedure TfrmUHFReader288main.RefreshStatus; //通讯端口更新函数
begin
  if not (ComboBox_AlreadyOpenCOM.Items.Count <> 0) then
    StatusBar1.Panels.Items[1].Text := 'Closed'
  else
    StatusBar1.Panels.Items[1].Text := ' COM' + IntToStr(frmcomportindex);
  StatusBar1.Panels.Items[0].Text :='';
  StatusBar1.Panels.Items[2].Text :='';
end;
procedure TfrmUHFReader288main.FormCreate(Sender: TObject);
begin
  fOpenComIndex := -1;
  fComAdr := 0;
  ferrorcode:= -1;
  fBaud:=5;
  InitComList;
  InitReaderList;
  ComboBox_baud2.ItemIndex:=3;
  RadioButton_band3.Checked:=True;
  ComboBox_PowerDbm.ItemIndex:=30;
  ComboBox_baud.ItemIndex:=3;
  R_EPC.Checked:=True;
  C_EPC.Checked:=True;
  P_EPC.Checked:=True;
  Radio_beepEn.Checked:=True;

  Istemps02Save := false;
  fAppClosed := False;
  Timer_Test_.Enabled := False;
  Timer_G2_Alarm.Enabled := False;
  Timer_G2_Read.Enabled := False;
   RadioButton1.Checked:=True;
  RadioButton3.Checked:=True;
  RadioButton6.Checked:=True;
  RadioButton8.Checked:=True;

  PageControl1.TabIndex:=0;
  fIsInventoryScan:=False;
  fisinventoryscan_6B:=False;
  ISscanstring:=False;
  AccessCode.Checked:=True;
  NoProect.Checked:=True;
  NoProect2.Checked:=True;
  Alarm_G2.Checked:=true;
  breakflag:=False;
  fLogStrings := TStringList.Create;
  EnableFlag:=False;
  CheckBox_TID.Checked:=False;
  FillChar(m_hDevArray,100,0);
  DM_Init(@SearchCallback,0);
  RadioButton13.Checked:=True;
  SeriaATflag:=False;
  Byone_6B.Checked:=True;
  COM_MRPTime.ItemIndex:=0;
  com_MQ.ItemIndex:=4;
  com_MS.ItemIndex:=4;
  com_mwork.ItemIndex:=0;
  //TabSheet_Real.TabVisible:=False;
end;

procedure TfrmUHFReader288main.Button2Click(Sender: TObject);
var
  port,i: LongInt;
  openresult :byte;
begin
  openresult:=48;
  Screen.Cursor := crHourGlass;
  if  Edit_CmdComAddr.Text='' then
  Edit_CmdComAddr.Text:='FF';
  fComAdr := StrToInt('$' + Edit_CmdComAddr.Text); // $FF;
  try
      if ComboBox_COM.ItemIndex = 0 then //Auto
      begin
        fbaud:=ComboBox_baud2.ItemIndex;
        if fbaud>2 then fbaud:=fbaud+2;
        openresult := AutoOpenComPort(port,fComAdr,fBaud,frmcomportindex);
        fOpenComIndex := frmcomportindex;
        if openresult = 0 then
        begin
            if(fBaud>3)then
              ComboBox_baud.ItemIndex:=fBaud-2
            else
              ComboBox_baud.ItemIndex:=fBaud;
          Action_GetReaderInformationExecute(Sender); //自动执行读取写卡器信息
          if (fCmdRet=$35) or (fCmdRet=$30)then
          begin
           Application.MessageBox('Serial Communication Error or Occupied', 'Information', MB_ICONINFORMATION);
           CloseSpecComPort(frmcomportindex) ;
           exit;
          end;
        end;
      end
      else if(ComboBox_COM.ItemIndex = 13)then
      begin
        openresult := OpenUSBPort(fComAdr,frmcomportindex);
        fOpenComIndex := frmcomportindex;
        if openresult = 0 then
        begin
          Action_GetReaderInformationExecute(Sender); //自动执行读取写卡器信息
          if (fCmdRet=$35) or (fCmdRet=$30)then
          begin
           Application.MessageBox('USBCommunication Error or Occupied', 'Information', MB_ICONINFORMATION);
           CloseSpecComPort(frmcomportindex) ;
           exit;
          end;
        end;
      end
      else
      begin
        port := strtoint(copy(ComboBox_COM.items[ComboBox_COM.itemindex],5,3));
         for i:=6 downto 0 do
        begin
          fBaud:=i;
          if(fBaud=3) or (fBaud=4)then
          Continue;
          openresult := opencomport(port,fComAdr,fBaud,frmcomportindex);
          fOpenComIndex := frmcomportindex;
          if openresult= $35 then
          begin
            Application.MessageBox('COM is opened', 'Information',MB_ICONINFORMATION);
            Exit;
          end;
          if openresult = 0 then
          begin
            if(fBaud>3)then
              ComboBox_baud.ItemIndex:=fBaud-2
            else
              ComboBox_baud.ItemIndex:=fBaud;
            Action_GetReaderInformationExecute(Sender); //自动执行读取写卡器信息
            if (fCmdRet=$35) or (fCmdRet=$30)then
            begin
              Application.MessageBox('Serial Communication Error or Occupied', 'Information', MB_ICONINFORMATION);
             CloseSpecComPort(frmcomportindex) ;
            end;
            Break;
          end;
        end;
      end;
  finally
    Screen.Cursor := crDefault;
  end;

  if (fOpenComIndex <> -1) and
     (openresult <> $35)  and
     (openresult <> $30)  then
  begin
    if(fOpenComIndex>255)and(fOpenComIndex<1024)then
     ComboBox_AlreadyOpenCOM.Items.Add('USB'+inttostr(fOpenComIndex)) 
    else
     ComboBox_AlreadyOpenCOM.Items.Add('COM'+inttostr(fOpenComIndex)) ;
    ComboBox_AlreadyOpenCOM.ItemIndex := ComboBox_AlreadyOpenCOM.ItemIndex + 1;
    // Button19.Enabled:=True;
    ComIsOpen:=True;
  end;
  if (fOpenComIndex = -1) and
     (openresult = $30)  then
  begin
     Application.MessageBox('Serial Communication Error', 'Information', MB_ICONINFORMATION);
  end;

  if (ComboBox_AlreadyOpenCOM.Items.Count <> 0) then
  begin
    if(Edit_ComAdr.Text<>'')then
    fComAdr := StrToInt('$' +Edit_ComAdr.Text);
    frmcomportindex := strtoint(copy(ComboBox_AlreadyOpenCOM.items[ComboBox_AlreadyOpenCOM.itemindex],4,3));
  end;
  RefreshStatus;
end;

procedure TfrmUHFReader288main.Button4Click(Sender: TObject);
var
port:Integer;
SelectCom :string;
begin
ClearLastInfo;
  try
    if ComboBox_AlreadyOpenCOM.itemindex < 0 then
      begin
        Application.MessageBox('Please Choose COM Port to close', 'Information', MB_ICONINFORMATION);
        exit;
      end
    else
    begin
      SelectCom := copy(ComboBox_AlreadyOpenCOM.Items[ComboBox_AlreadyOpenCOM.ItemIndex],4,3);
      port := strtoint(SelectCom);
      if(port>255)then
      begin
        fComAdr:=CloseUSBPort(port);
      end
      else
      fComAdr := CloseSpecComPort(port) ;
      if fComAdr  = 0 then
      begin
        ComIsOpen:=False;
        ComboBox_AlreadyOpenCOM.DeleteSelected;
        if ComboBox_AlreadyOpenCOM.items.Count <> 0 then
          begin
            ComIsOpen:=True;
            port := strtoint(copy(ComboBox_AlreadyOpenCOM.items[0],4,2));
            CloseSpecComPort(port);
            fComAdr := $FF;
            opencomport(port,fComAdr,fBaud,frmcomportindex);
            fOpenComIndex := frmcomportindex;
            RefreshStatus;
            Action_GetReaderInformationExecute(Sender); //自动执行读取写卡器信息
          end;
      end
      else
      begin
         Application.MessageBox('Serial Communication Error', 'Information', MB_ICONINFORMATION);
        exit;
      end;
    end;
  finally

  end;

  if ComboBox_AlreadyOpenCOM.items.Count <> 0 then
    ComboBox_AlreadyOpenCOM.ItemIndex := 0
  else
  begin
    fOpenComIndex := -1;
    ComboBox_AlreadyOpenCOM.clear;
    ComboBox_AlreadyOpenCOM.Repaint;
  //  Button19.Enabled:=False;
    RefreshStatus;
  end;
end;
procedure TfrmUHFReader288main.AddCmdLog(cmd, cmdName: string; cmdRet: Byte; errorCode: LongInt = -1); //操作状态成功或错误提示函数
var
  s: string;
begin
if cmdRet <> 0 then
  begin
    s := ' “' + cmdName + '” Command Response=0x' + IntToHex(cmdRet, 2) + '(' + UHFReader288_GetReturnCodeDesc(cmdRet) + ')';
    if ErrorCode <> -1 then
    begin
        s := s + #13#10 + 'ErrorCode=0x' + IntToHex(ErrorCode, 2) + '(' + UHFReader288_GetErrorCodeDesc(ErrorCode) + ')';
      Application.MessageBox(pchar(s), 'Error Information', MB_ICONINFORMATION);
    end;
  end;
  ferrorcode:=-1;
  if cmdRet = 0 then
    StatusBar1.Panels.Items[0].text := FormatDateTime('hh:mm:ss', Now) + ' “' + cmdName + '” : successfully'
  else
    StatusBar1.Panels.Items[0].text := FormatDateTime('hh:mm:ss', Now) + '' + s;
end;

procedure TfrmUHFReader288main.AddCmdLog2(cmd, cmdName: string; cmdRet: Byte; CMDReturn:string;errorCode: LongInt = -1); //操作状态成功或错误提示函数
var
  s: string;
begin
  if cmdRet <> 0 then
  begin
    s := ' “' + cmdName + '” Command Response=0x' + IntToHex(cmdRet, 2) + '(' + CMDReturn + ')';
    if ErrorCode <> -1 then
    begin
        s := s + #13#10 + 'ErrorCode=0x' + IntToHex(ErrorCode, 2) + '(' + UHFReader288_GetErrorCodeDesc(ErrorCode) + ')';
      Application.MessageBox(pchar(s), 'Error Information', MB_ICONINFORMATION);
    end;
  end;
  ferrorcode:=-1;
  if cmdRet = 0 then
    StatusBar1.Panels.Items[0].text := FormatDateTime('hh:mm:ss', Now) + ' “' + cmdName + '” : successfully'
  else
    StatusBar1.Panels.Items[0].text := FormatDateTime('hh:mm:ss', Now) + '' + s;
end;
procedure TfrmUHFReader288main.ClearLastInfo;
begin
  ComboBox_AlreadyOpenCOM.Repaint;
  RefreshStatus;
  Edit_Type.Text := '';
  Edit_Version.Text := '';
  ISO180006B.Checked:=False;
  EPCC1G2.Checked:=False;
  Edit_ComAdr.Text := '';
  Edit_power.Text := '';
  Edit_scantime.Text := '';
  Edit_dminfre.Text := '';
  Edit_dmaxfre.Text := '';
  PageControl1.TabIndex := 0;
end;
procedure TfrmUHFReader288main.Action_GetReaderInformationExecute(
  Sender: TObject);
function getNoStr(no: Integer; noLen: Integer): string;
  begin
    result := intToStr(no);
    while Length(result) < noLen do
      result := '0' + result;
  end;
var
  VersionInfo: array[0..2] of Char;
  ScanTime,dmaxfre,dminfre,powerdBm,FreBand,TrType,Ant,BeepEn,OutputRep,CheckAnt: Byte;
begin
  Edit_Version.Text := '';
  Edit_ComAdr.Text := '';
  Edit_ScanTime.Text := '';
  Edit_Type.text := '';
  ISO180006B.Checked:=False;
  EPCC1G2.Checked:=False;
  Edit_Power.text := '';
  Edit_dminfre.text := '';
  Edit_dmaxfre.text := '';
  fCmdRet:=GetReaderInformation(fComAdr,@VersionInfo,ReaderType,TrType, dmaxfre ,dminfre,powerdBm,
                                 ScanTime,Ant,BeepEn,OutputRep,CheckAnt,frmComPortindex);
 if(fCmdRet=0)then
 begin
  Edit_Version.Text := getnostr(Ord(versioninfo[0]),2)+'.'+getnostr(Ord(versioninfo[1]),2);
  Edit_ComAdr.Text := IntToHex(fComAdr,2);
  Edit_NewComAdr.Text := IntToHex(fComAdr,2);
  Edit_ScanTime.Text := inttostr(ScanTime)+'*100ms';
  ComboBox_scantime.ItemIndex:= scantime-3;

 FreBand:= ((dmaxfre and $c0)shr 4)or(dminfre shr 6) ;
 case FreBand of
 $01:begin
         RadioButton_band2.Checked:=True;
         fdminfre := 920.125+(dminfre and $3F)*0.25;
         fdmaxfre := 920.125+(dmaxfre and $3F)*0.25;

         ComboBox_dminfre.ItemIndex:=dminfre and $3F;
         ComboBox_dmaxfre.ItemIndex:=dmaxfre and $3F;
     end;
 $02:begin
         RadioButton_band3.Checked:=True;
         fdminfre := 902.75+(dminfre and $3F)*0.5;
         fdmaxfre := 902.75+(dmaxfre and $3F)*0.5;
         ComboBox_dminfre.ItemIndex:=dminfre and $3F;
         ComboBox_dmaxfre.ItemIndex:=dmaxfre and $3F;
     end;
 $03:begin
         RadioButton_band4.Checked:=True;
         fdminfre := 917.1+(dminfre and $3F)*0.2;
         fdmaxfre := 917.1+(dmaxfre and $3F)*0.2;
         ComboBox_dminfre.ItemIndex:=dminfre and $3F;
         ComboBox_dmaxfre.ItemIndex:=dmaxfre and $3F;
     end;
  $04:begin
         RadioButton_band5.Checked:=True;
         fdminfre := 865.1+(dminfre and $3F)*0.2;
         fdmaxfre := 865.1+(dmaxfre and $3F)*0.2;
         ComboBox_dminfre.ItemIndex:=dminfre and $3F;
         ComboBox_dmaxfre.ItemIndex:=dmaxfre and $3F;
     end;
  $8:begin
         RadioButton_band1.Checked:=True;
         fdminfre := 840.125+(dminfre and $3F)*0.25;
         fdmaxfre := 840.125+(dmaxfre and $3F)*0.25;

         ComboBox_dminfre.ItemIndex:=dminfre and $3F;
         ComboBox_dmaxfre.ItemIndex:=dmaxfre and $3F;
     end;
 end;
  Edit_dminfre.Text := FloatToStr(fdminfre)+'MHz';
  Edit_dmaxfre.Text := FloatToStr(fdmaxfre)+'MHz';
  if fdmaxfre<>fdminfre then
  CheckBox_SameFre.Checked:=False
  else
  CheckBox_SameFre.Checked:=True;

  case ReaderType of
    $0C: begin
          Edit_Type.text := 'UHFReader288M';
          Edit_power.Text   :=IntToStr(powerdBm);
          // GPIO显示
          COUT3.Visible:=False;
          COUT4.Visible:=False;
          CINT2.Visible:=False;
          CINT3.Visible:=False;
          CINT4.Visible:=False;
          ///2881独有
          grp_version.Visible:=False;
          grp_timer.Visible:=False;
          Button7.Visible:=False;
          TabSheet5.TabVisible:=False;
          ///天线配置显示
          grp_antconfig.Visible:=True;
          grp_checkant.Visible:=True;
          //// 主动
          TabSheet_active.TabVisible:=false;
          TabSheet_Real.TabVisible:=True;
          ///
          grp_bufflen.Visible:=true;
          grp_antconfig.Visible:=true;
          grp_checkant.Visible:=true;
          ////缓存模式
          TabSheet_Buff.TabVisible:=True;
          //通讯类型
          grp_comType.Visible:=True;
         end;
    $8A: begin
          Edit_Type.text := 'UHFReader288';
          Edit_power.Text   :=IntToStr(powerdBm);
          // GPIO显示
          COUT3.Visible:=True;
          COUT4.Visible:=True;
          CINT2.Visible:=True;
          CINT3.Visible:=True;
          CINT4.Visible:=True;
           ///2881独有
          grp_version.Visible:=True;
          grp_timer.Visible:=True;
          Button7.Visible:=True;
          TabSheet5.TabVisible:=true;
          ///天线配置显示
          grp_antconfig.Visible:=True;
          grp_checkant.Visible:=True;
          //// 主动
          TabSheet_active.TabVisible:=true;
          TabSheet_Real.TabVisible:=true;
          ///
          grp_bufflen.Visible:=true;
          grp_antconfig.Visible:=true;
          grp_checkant.Visible:=true;
          ////缓存模式
          TabSheet_Buff.TabVisible:=True;
          //通讯类型
          grp_comType.Visible:=false;
         end;
    $8B: begin
          Edit_Type.text := 'UHFReader288ADV';
          Edit_power.Text   :=IntToStr(powerdBm);
          // GPIO显示
          COUT3.Visible:=True;
          COUT4.Visible:=True;
          CINT2.Visible:=True;
          CINT3.Visible:=True;
          CINT4.Visible:=True;
          ///2881独有
          grp_version.Visible:=True;
          grp_timer.Visible:=True;
          Button7.Visible:=True;
          TabSheet5.TabVisible:=true;
          ///天线配置显示
          grp_antconfig.Visible:=True;
          grp_checkant.Visible:=True;
          //// 主动
          TabSheet_active.TabVisible:=true;
          TabSheet_Real.TabVisible:=true;
          ///
          grp_bufflen.Visible:=true;
          grp_antconfig.Visible:=true;
          grp_checkant.Visible:=true;
          ////缓存模式
          TabSheet_Buff.TabVisible:=True;
          //通讯类型
          grp_comType.Visible:=false;
         end;
    $16: begin
          Edit_Type.text := 'UHFReader98';
          Edit_power.Text   :=IntToStr(powerdBm);
          // GPIO显示
          COUT3.Visible:=False;
          COUT4.Visible:=False;
          CINT2.Visible:=False;
          CINT3.Visible:=False;
          CINT4.Visible:=False;
          ///2881独有
          grp_version.Visible:=false;
          grp_timer.Visible:=false;
          Button7.Visible:=false;
          TabSheet5.TabVisible:=False;
          ///天线配置显示
          grp_antconfig.Visible:=false;
          grp_checkant.Visible:=false;
          //// 主动
          TabSheet_active.TabVisible:=false;
          TabSheet_Real.TabVisible:=false;
          ///
          grp_bufflen.Visible:=false;
          grp_antconfig.Visible:=False;
          grp_checkant.Visible:=false;
          ////缓存模式
          TabSheet_Buff.TabVisible:=False;
          //通讯类型
          grp_comType.Visible:=True;
         end;            
  end;
  ComboBox_PowerDbm.ItemIndex:=powerDbm;
  if (ord(TrType) and $02) = $02 then //第二个字节低第四位代表支持的协议“
  begin
  ISO180006B.Checked:=True;
  EPCC1G2.Checked:=True;
  end
  else
  begin
  ISO180006B.Checked:=False;
  EPCC1G2.Checked:=False;
  end;
  case BeepEn of
  1: Radio_beepEn.Checked:=True;
  0: Radio_beepDis.Checked:=True;
  end;

  ANT:=ANT and $0F;
  if(Ant and $01)= 1then
  begin
   Check_ant1.Checked:=True;
   cant1.Checked:=True;
   Check_BANT1.Checked:=True;
  end
  else
  begin
   Check_ant1.Checked:=False;
   cant1.Checked:=False;
   Check_BANT1.Checked:=False;
  end;

  if(Ant and $02)= 2then
  begin
   Check_ant2.Checked:=True;
   cant2.Checked:=True;
   Check_BANT2.Checked:=True;
  end
  else
  begin
   Check_ant2.Checked:=False;
   cant2.Checked:=False;
   Check_BANT2.Checked:=false;
  end;

  if(Ant and $04)= 4then
  begin
   Check_ant3.Checked:=True;
   cant3.Checked:=True;
   Check_BANT3.Checked:=True;
  end
  else
  begin
   Check_ant3.Checked:=False;
   cant3.Checked:=False;
   Check_BANT3.Checked:=false;
  end;

  if(Ant and $08)= 8then
  begin
   Check_ant4.Checked:=True;
   cant4.Checked:=True;
   Check_BANT4.Checked:=True;
  end
  else
  begin
   Check_ant4.Checked:=False;
   cant4.Checked:=False;
   Check_BANT4.Checked:=false;
  end;

  if(OutputRep and $01)= 1then
   Check_out1.Checked:=True
  else
   Check_out1.Checked:=False;

  if(OutputRep and $02)= 2then
   Check_out2.Checked:=True
  else
   Check_out2.Checked:=False;

  if(OutputRep and $04)= 4then
   Check_out3.Checked:=True
  else
   Check_out3.Checked:=False;

  if(OutputRep and $08)= 8then
   Check_out4.Checked:=True
  else
   Check_out4.Checked:=False;
   IF(CheckAnt=1)then OpenANT.Checked:=True
   else CloseANT.Checked:=True;
 end;
  AddCmdLog('GetReaderInformation','GetReaderInformation', fCmdRet);
end;

procedure TfrmUHFReader288main.ComboBox_AlreadyOpenCOMCloseUp(Sender: TObject);
var
  SelectCom:string;
  port :byte;
begin
  if ComboBox_AlreadyOpenCOM.items.count <>0 then
  begin
    SelectCom := copy(ComboBox_AlreadyOpenCOM.Items[ComboBox_AlreadyOpenCOM.ItemIndex],4,3);
    port := strtoint(SelectCom);
    CloseSpecComPort(port);
    fComAdr := $FF;
    if opencomport(port,fComAdr,fBaud,frmcomportindex) <> 0 then
    begin
      Application.MessageBox('Serial Communication Error', 'Information', MB_ICONINFORMATION);
      exit;
    end;
    fOpenComIndex := frmcomportindex;
    ClearLastInfo;
    RefreshStatus;
    Action_GetReaderInformationExecute(Action_GetReaderInformation); //自动执行读取写卡器信息
  end;
end;

procedure TfrmUHFReader288main.Action_SetReaderInformationExecute(
  Sender: TObject);
var
  aNewComAdr,powerDbm,dminfre, dmaxfre ,scantime,band: Byte;
  returninfo:string;
  returninfoDlg:string;
  setinfo:string;
begin
  frmprogress.Show;
  frmUHFReader288main.Enabled:=False;
  band:=2;
  if(RadioButton_band2.Checked)then
  band:=1;
  if(RadioButton_band3.Checked)then
  band:=2;
  if(RadioButton_band4.Checked)then
  band:=3;
  if(RadioButton_band5.Checked)then
  band:=4;
  if(RadioButton_band1.Checked)then
  band:=8;
  frmprogress.ProgressBar1.Position:=0;
  if Sender = Action_SetReaderInformation then
  begin
    dminfre := ((band and 3)shl 6)or (ComboBox_dminfre.ItemIndex and $3F) ;
    dmaxfre := ((band and $c)shl 4)or (ComboBox_dmaxfre.ItemIndex and $3F) ;
    aNewComAdr := StrToInt('$' + Edit_NewComAdr.Text);
    powerDbm:=ComboBox_PowerDbm.ItemIndex;
    fbaud:=ComboBox_baud.ItemIndex;
    if fbaud>2 then fbaud:=fbaud+2;
    scantime:= ComboBox_scantime.ItemIndex+3;
    setinfo:=' Write';
  end
  else
  begin  //
    dminfre := $80;
    dmaxfre := 49;
    aNewComAdr :=$00;
    powerDbm:=30;
    fbaud:=5;
    scantime:=20;   //
    setinfo:=' Restore';
    ComboBox_baud.itemindex:=3;
  end;
  frmprogress.ProgressBar1.StepBy(25);
  fCmdRet := SetAddress(fComAdr, aNewComAdr,frmcomportindex);
  if fCmdRet=ParameterSaveFailCanUseBeforeNoPower then
  fComAdr := aNewComAdr;
  if fCmdRet = 0 then
  begin
    fComAdr := aNewComAdr;
    returninfo:=returninfo+setinfo+'Address Successfully';
  //  Action_GetReaderInformationExecute(Sender);
  end
  else if fCmdRet=RecmdErr then
  returninfo:=returninfo+setinfo+'Address Response Command Error'
  else
  begin
  returninfo:=returninfo+setinfo+'Address Fail';
  returninfoDlg:=returninfoDlg+setinfo+'Address Fail Command Response=0x'
       +inttostr(fCmdRet)+'('+UHFReader288_GetReturnCodeDesc(fCmdRet)+')';
  end;
  frmprogress.ProgressBar1.StepBy(25);
  fCmdRet := SetRfPower(fComAdr,powerDbm,frmcomportindex);
  if fCmdRet = 0 then
   returninfo:=returninfo+setinfo+'Power Success'
  else if fCmdRet=RecmdErr then
  returninfo:=returninfo+setinfo+'Power Response Command Error'
  else
  begin
  returninfo:=returninfo+setinfo+'Power Fail';
  returninfoDlg:=returninfoDlg+#13#10+setinfo+'Power Fail Command Response 0x='
       +inttostr(fCmdRet)+'('+UHFReader288_GetReturnCodeDesc(fCmdRet)+')';
  end;

  frmprogress.ProgressBar1.StepBy(25);
  fCmdRet := SetRegion(fComAdr,dmaxfre,dminfre,frmcomportindex);
  if fCmdRet = 0 then
   returninfo:=returninfo+setinfo+'Region Success'
  else if fCmdRet=RecmdErr then
  returninfo:=returninfo+setinfo+'Region Response Command Error'
  else
  begin
  returninfo:=returninfo+setinfo+'Region Fail';
  returninfoDlg:=returninfoDlg+#13#10+setinfo+'Region Fail Command Response0x='
       +inttostr(fCmdRet)+'('+UHFReader288_GetReturnCodeDesc(fCmdRet)+')';
  end;

  frmprogress.ProgressBar1.StepBy(25);
  fCmdRet := SetBaudRate(fComAdr, fBaud,frmcomportindex);
  if fCmdRet = 0 then
   returninfo:=returninfo+setinfo+'BaudRate Success'
  else if fCmdRet=RecmdErr then
  returninfo:=returninfo+setinfo+'BaudRate Response Command Error'
  else
  begin
  returninfo:=returninfo+setinfo+'BaudRate Fail';
  returninfoDlg:=returninfoDlg+#13#10+setinfo+'BaudRate Fail Command Response0x='
       +inttostr(fCmdRet)+'('+UHFReader288_GetReturnCodeDesc(fCmdRet)+')';
  end;

  frmprogress.ProgressBar1.StepBy(25);
  fCmdRet := SetInventoryScanTime(fComAdr, scantime,frmcomportindex);
  if fCmdRet = 0 then
   returninfo:=returninfo+setinfo+'InventoryScanTime Success'
  else if fCmdRet=RecmdErr then
  returninfo:=returninfo+setinfo+'InventoryScanTime Response Command Error0x'
  else
  begin
  returninfo:=returninfo+setinfo+'InventoryScanTime Fail';
  returninfoDlg:=returninfoDlg+#13#10+setinfo+'InventoryScanTime Fail Command Response='
       +inttostr(fCmdRet)+'('+UHFReader288_GetReturnCodeDesc(fCmdRet)+')';
  end;

  Action_GetReaderInformationExecute(Sender);
  frmprogress.Close;
  frmUHFReader288main.Enabled:=True;
 // AddCmdLog('SetReaderInformation', TAction(Sender).Caption, fCmdRet);
  StatusBar1.Panels.Items[0].text := FormatDateTime('hh:mm:ss', Now) +  returninfo;
  if  returninfoDlg<>'' then
  MessageDlg(returninfoDlg, mtInformation, [mbOK], 0);
end;

procedure TfrmUHFReader288main.RadioButton_band1Click(Sender: TObject);
var
  i:Integer;
begin
  CheckBox_SameFre.Checked:=False;
  ComboBox_dminfre.Items.Clear;
  ComboBox_dmaxfre.Items.Clear;
 for i:=0 to 19 do
  begin
    ComboBox_dminfre.Items.Add(floattostr(840.125+i*0.25)+' MHz');
    ComboBox_dmaxfre.Items.Add( floattostr(840.125+i*0.25)+' MHz');
  end;
  ComboBox_dminfre.ItemIndex := 0;
  ComboBox_dmaxfre.ItemIndex := 19;
end;

procedure TfrmUHFReader288main.RadioButton_band2Click(Sender: TObject);
var
  i:Integer;
begin
  CheckBox_SameFre.Checked:=False;
  ComboBox_dminfre.Items.Clear;
  ComboBox_dmaxfre.Items.Clear;
 for i:=0 to 19 do
  begin
    ComboBox_dminfre.Items.Add(floattostr(920.125+i*0.25)+' MHz');
    ComboBox_dmaxfre.Items.Add( floattostr(920.125+i*0.25)+' MHz');
  end;
  ComboBox_dminfre.ItemIndex := 0;
  ComboBox_dmaxfre.ItemIndex := 19;
end;

procedure TfrmUHFReader288main.RadioButton_band3Click(Sender: TObject);
var
  i:Integer;
begin
  CheckBox_SameFre.Checked:=False;
  ComboBox_dminfre.Items.Clear;
  ComboBox_dmaxfre.Items.Clear;
 for i:=0 to 49 do
  begin
    ComboBox_dminfre.Items.Add(floattostr(902.75+i*0.5)+' MHz');
    ComboBox_dmaxfre.Items.Add( floattostr(902.75+i*0.5)+' MHz');
  end;
  ComboBox_dminfre.ItemIndex := 0;
  ComboBox_dmaxfre.ItemIndex := 49;
end;

procedure TfrmUHFReader288main.RadioButton_band4Click(Sender: TObject);
var
  i:Integer;
begin
  CheckBox_SameFre.Checked:=False;
  ComboBox_dminfre.Items.Clear;
  ComboBox_dmaxfre.Items.Clear;
 for i:=0 to 31 do
  begin
    ComboBox_dminfre.Items.Add(floattostr(917.1+i*0.2)+' MHz');
    ComboBox_dmaxfre.Items.Add( floattostr(917.1+i*0.2)+' MHz');
  end;
  ComboBox_dminfre.ItemIndex:=0;
  ComboBox_dmaxfre.ItemIndex:=31;
end;

procedure TfrmUHFReader288main.RadioButton_band5Click(Sender: TObject);
var
  i:Integer;
begin
  CheckBox_SameFre.Checked:=False;
  ComboBox_dminfre.Items.Clear;
  ComboBox_dmaxfre.Items.Clear;
 for i:=0 to 14 do
  begin
    ComboBox_dminfre.Items.Add(floattostr(865.1+i*0.2)+' MHz');
    ComboBox_dmaxfre.Items.Add( floattostr(865.1+i*0.2)+' MHz');
  end;
  ComboBox_dminfre.ItemIndex:=0;
  ComboBox_dmaxfre.ItemIndex:=14;
end;

procedure TfrmUHFReader288main.Action_SelfTestModeExecute(Sender: TObject);
var
    IsSelfTestMode:Boolean;
begin
   IsSelfTestMode:=False ;
   if sender=Action_SelfTestMode then
   begin
    IsSelfTestMode:=True;
   end
   else if sender=Action_SelfTestMode2 then
   begin
    IsSelfTestMode:=False;
   end;
   fCmdRet:=InSelfTestMode(fComAdr,IsSelfTestMode,frmComPortindex);
   AddCmdLog('SelfTestMode', TAction(Sender).Caption+'SelfTestMode', fCmdRet);
end;

procedure TfrmUHFReader288main.Action_GetReaderInformationUpdate(
  Sender: TObject);
begin
  Button3.Enabled:=ComIsOpen;
  Button5.Enabled:=ComIsOpen;
  Button1.Enabled:=ComIsOpen;

  Button_Ant.Enabled:=ComIsOpen;
  Button_Beep.Enabled:=ComIsOpen;
  Button_SetGPIO.Enabled:=ComIsOpen;
  Button_GetGPIO.Enabled:=ComIsOpen;
  ClockCMD.Enabled:= ComIsOpen;
  Button_RelayTime.Enabled:=ComIsOpen;
  Button_OutputRep.Enabled:=ComIsOpen;
  Button21.Enabled:=ComIsOpen ;
  Button8.Enabled:=ComIsOpen ;
  Button9.Enabled:=ComIsOpen ;
  Button25.Enabled:=ComIsOpen ;
  Button26.Enabled:=ComIsOpen ;
  Button27.Enabled:=ComIsOpen ;
  Button28.Enabled:=ComIsOpen ;
  Button29.Enabled:=ComIsOpen ;
  Button30.Enabled:=ComIsOpen ;
  Button31.Enabled:=ComIsOpen ;
  Button32.Enabled:=ComIsOpen ;
  Button34.Enabled:=ComIsOpen ;
  Button35.Enabled:=ComIsOpen ;
  Button39.Enabled:=ComIsOpen ;
  Button6.Enabled:=ComIsOpen ;
  btGetSaveLen.Enabled:= ComIsOpen;
  btSetSaveLen.Enabled:= ComIsOpen;
  Button7.Enabled:=ComIsOpen ;
  Button42.Enabled:=ComIsOpen ;
end;

procedure TfrmUHFReader288main.Action_RfOutputExecute(Sender: TObject);
var
  onoff:Byte;
begin
  if sender = Action_RfOutput then
  onoff:=1
  else
  onoff:=0;
  fCmdRet := RfOutput(fComAdr, onoff,frmcomportindex);
  AddCmdLog('RfOutput', TAction(Sender).Caption, fCmdRet);
end;

function TfrmUHFReader288main.RoundClassic(R: Real): Int64;
begin
Result:= Trunc(R);
if Frac(R) >= 0.5 then
    Result:= Result + 1;
end;
procedure TfrmUHFReader288main.CheckBox_SameFreClick(Sender: TObject);
begin
    if CheckBox_SameFre.Checked then
    ComboBox_dmaxfre.ItemIndex:=ComboBox_dminfre.ItemIndex;
end;

procedure TfrmUHFReader288main.Edit2KeyPress(Sender: TObject; var Key: Char);
  var L:Boolean;
begin
    L:=(key<#8)or(key>#8)and(key<#48)or(key>#57)and (key<#65)or(key>#70)and (key<#97)or(key>#102);
    if l then key:=#0;
    if ( (key>#96)and(key<#103))   then  key:=  char(Ord(key)-32) ;
end;

procedure TfrmUHFReader288main.SpeedButton_QueryClick(Sender: TObject);
begin
  if(CheckBox_TID.Checked)then
  begin
    if(Length(Edit6.Text)<>2)or(Length(Edit11.Text)<>2)then
    begin
     StatusBar1.Panels[0].Text:='TID Parameter Error！';
     SpeedButton_Query.down:=False;
     Exit;
    end;
  end;
  if((Edit2.Text='')or(Edit3.Text=''))then
  begin
    StatusBar1.Panels[0].Text:='Mask adress or Length is Null';
    SpeedButton_Query.down:=False;
    Exit;
  end;
  if(CheckBox1.Checked)then
  begin
    if(Length(Edit1.Text)mod 2<>0)then
    begin
      StatusBar1.Panels[0].Text:='Mask Data error!';
      SpeedButton_Query.down:=False;
      Exit;
    end;
  end;
  if not (SpeedButton_Query.down) then
  begin
    AddCmdLog('Inventory', 'Exit Query', 0);
    Timer_Test_.Enabled:=False;
    Edit6.Enabled:=true;
    Edit11.Enabled:=true;
    CheckBox_TID.Enabled:=True;
    Com_Q.Enabled:=True ;
    Com_S.Enabled:=True ;
  end
  else
  begin
    fInventory_EPC_List := ''; //先清除原来的缓冲
    ListView_EPC.Items.Clear;
    Timer_Test_.Enabled:=True;
    ListView_EPC.Clear;
    ComboBox_EPC1.Clear;
    ComboBox_EPC2.Clear;
    ComboBox_EPC3.Clear;
    ComboBox_EPC4.Clear;
    ComboBox_EPC5.Clear;
     Edit6.Enabled:=False;
    Edit11.Enabled:=False;
    CheckBox_TID.Enabled:=False;
    Edit18.Text:='';
    Edit17.Text:='';
    Com_Q.Enabled:=False;
    Com_S.Enabled:=False;
  end;
end;

procedure TfrmUHFReader288main.Action_InventoryExecute(Sender: TObject);
 procedure ChangeSubItem1(aListItem: TListItem; subItemIndex: Integer; ItemText: string;ant1,RSSI:string);
  begin
    //if aListItem.SubItems[subItemIndex] = ItemText then
    begin
      if(aListItem.SubItems[2]='')then
      begin
         aListItem.SubItems[2]:=ant1;
      end
      else
      begin
         aListItem.SubItems[2]:=Str_IntToBin(StrToInt('$'+BitStrToHextStr(aListItem.SubItems[2]))or StrToInt('$'+BitStrToHextStr(ant1)),4) ;
      //  aListItem.SubItems[2]:=IntToStr(StrToInt(aListItem.SubItems[2])or StrToInt(ant1));
      end;
      if (aListItem.SubItems[3]='99999') or (aListItem.SubItems[3]='')then              //aListItem.SubItems[2]为次数
       aListItem.SubItems[3]:='0'                        //aListItem.SubItems[0]为 EPC号
      else
      begin
       aListItem.SubItems[3]:= IntToStr(StrToInt(aListItem.SubItems[3])+1);
       aListItem.SubItems[4]:=RSSI;
       exit; //内容相同则不需要修改，可以不闪烁
      end;
    end;
    //aListItem.SubItems[subItemIndex] := ItemText;

  end;
  procedure ChangeSubItem2(aListItem: TListItem; subItemIndex: Integer; ItemText: string;ant1,RSSI:string);
  begin
   { if aListItem.SubItems[subItemIndex] = ItemText then         //aListItem.SubItems[1]为 EPC长度
    exit; //内容相同则不需要修改，可以不闪烁
    aListItem.SubItems[subItemIndex] := ItemText;  }
    aListItem.SubItems[1]:= IntToStr(Length(ItemText)div 2) ;
    aListItem.SubItems[2]:=ant1;
    aListItem.SubItems[3]:='1';
    aListItem.SubItems[4]:=RSSI;
    aListItem.SubItems[subItemIndex] := ItemText;
  end;
var
  CardNum:Integer;
  EPClen,m,Totallen:Integer;
  EPC: array[0..65535] of Char;
  isonstring:Boolean;
  isonlistview:Boolean;
  CardIndex: Integer;
  temps: string;
  s,ss, sEPC: string;
  aListItem: TListItem;
  temp1,temp2,temps2, temps3: string;
  i, j,n_index: integer;
  baifenbi:Real;
  MaskMem:Byte;
  MaskAdr:array[0..2]of Char;
  MaskLen:Byte;
  MaskData:array[0..80]of Char;
  MaskFlag:Byte;
  Ant,AdrTID,LenTID,TIDFlag:Byte;
  antstr,lastepc:string;
  line:string;
  RSSI,S1,s2,FileName:string;
  QValue,Session:Byte;
  m_ant:LongInt;
  queryFlag:Boolean;
  BufferFlag:Boolean;
begin
   fIsInventoryScan := true;
  for m_ant:=0 to  3 do
    begin
        queryFlag:=False;
        if(m_ant=0)and Check_ant1.Checked then
        begin
            Inant := $80;
            queryFlag:=True;
        end
        else if(m_ant=1)and Check_ant2.Checked then
        begin
          Inant := $81;
          queryFlag:=True;
        end
        else if(m_ant=2)and Check_ant3.Checked then
        begin
          Inant := $82;
          queryFlag:=True;
        end
        else if(m_ant=3)and Check_ant4.Checked then
        begin
          Inant := $83;
          queryFlag:=True;
        end;

        ScanTime:=ComboBox14.ItemIndex+3;
        FastFlag:=0;
        FillChar( MaskData,80,0);
        if(R_EPC.Checked)then MaskMem:=1;
        if(R_TID.Checked)then MaskMem:=2;
        if(R_User.Checked)then MaskMem:=3;
        getCharStr(Edit2.Text,MaskAdr);
        if(CheckBox1.Checked)then
        MaskFlag:=1
        else
        MaskFlag:=0;
        QValue:=Com_Q.ItemIndex;
        if(Com_S.ItemIndex=4)then
        begin
        Session:=255 ;
        //queryFlag:=True;
        end
        else
        Session:=Com_S.ItemIndex;
        MaskLen:=StrToInt('$'+trim(edit3.Text));
        getCharStr(Edit1.Text,MaskData);
        if(CheckBox_TID.Checked)then
        begin
          AdrTID:=StrToInt('$'+Trim(Edit6.Text));
          LenTID:=StrToInt('$'+Trim(Edit11.Text));
          TIDFlag:=1;
        end
        else
        begin
          AdrTID:=0;
          LenTID:=0;
          TIDFlag:=0;
        end;
        try
          CardNum:=0;
           FastFlag:=1;
           if (Session = 0)then
           begin
             Target:=0;
           end;
           if(queryFlag)then
           begin
             if (Session = 0) or (Session=1) then
             begin
                 Target:=0;
             end
             else
             begin
                 if(AA_times > 1)then
                 begin
                   Target:=1- Target;
                 end;
             end;
           fCmdRet :=Inventory_G2(fComAdr,QValue,Session,MaskMem,@MaskAdr,MaskLen,@MaskData,MaskFlag,AdrTID,LenTID,TIDFlag,Target,InAnt,Scantime,FastFlag,@EPC,Ant,Totallen,CardNum,frmcomportindex);
           AddCmdLog('Inventory', 'Inventory', fCmdRet);
           Query_count:=Query_count+1;
           if(fCmdRet = $01)or (fCmdRet = $02)or (fCmdRet = $03)or (fCmdRet = $04)or(fCmdRet = $FB)  then //代表已查找结束，并且内容有发生变化
           begin
              if(CardNum=0)then
              begin
                AA_times:=AA_times+1;
              end
              else
              begin
                AA_times:=0;
              end;
              temps :=getStr(EPC,Totallen);
              m:=1;
              for CardIndex := 1 to CardNum do
              begin
                EPClen:=ord(tempS[m])+2;
                sEPC := copy(tempS,m,EPClen) ;
                m:=m+EPClen;
                if Length(sEPC) <> EPClen then Continue;
                s := getHexStr(sEPC);
                RSSI:= IntToStr(StrToInt('$'+copy(s,Length(s)-1,2)));
                isonlistview:=False;
                s2:= copy(s, 3, Length(s)-4);
                for i:=1 to ListView_EPC.Items.Count do      //判断是否在Listview列表内
                begin
                  if s2=(ListView_EPC.Items[i - 1]).SubItems[0] then
                  begin
                   aListItem := ListView_EPC.Items[i - 1];
                   ChangeSubItem1(aListItem, 0, S2, Str_IntToBin(Ant,4),RSSI);
                   isonlistview:=True;
                   Break;
                  end;
                end;
                if (not isonlistview) then
                begin
                  aListItem := ListView_EPC.Items.Add;
                  aListItem.Caption := IntToStr(aListItem.Index + 1);
                  aListItem.SubItems.Add('');
                  aListItem.SubItems.Add('');
                  aListItem.SubItems.Add('');
                  aListItem.SubItems.Add('');
                  aListItem.SubItems.Add('');
                  aListItem := ListView_EPC.Items[ListView_EPC.Items.Count - 1];
                  ChangeSubItem2(aListItem, 0, S2, Str_IntToBin(Ant,4),RSSI);
                  if(not CheckBox_TID.Checked)then
                  begin
                  ComboBox_EPC1.Items.Add(S2);
                  ComboBox_EPC2.Items.Add(S2);
                  ComboBox_EPC3.Items.Add(S2);
                  ComboBox_EPC4.Items.Add(S2);
                  ComboBox_EPC5.Items.Add(S2);
                  end;
                end;

                if(s<>'')then lastepc:=S2;
                Application.ProcessMessages;
              end;
              if(ListView_EPC.Items.Count>0)then
              begin
                if ((Query_count > 1) or (Session = 0))then
                Edit18.Text:=IntToStr(ListView_EPC.Items.Count);
                Edit17.Text:= lastepc;
                ListView_EPC.ItemIndex := ListView_EPC.Items.Count -1;
                ListView_EPC.Selected.MakeVisible(False);
                if(not CheckBox_TID.Checked)then
                begin
                ComboBox_EPC1.Itemindex:=0;
                ComboBox_EPC2.Itemindex:=0;
                ComboBox_EPC3.Itemindex:=0;
                ComboBox_EPC4.Itemindex:=0;
                ComboBox_EPC5.Itemindex:=0;
                end;
              end;
              Application.ProcessMessages;
           end;
           end;

        finally

        end;
       // if(Session=255)then Break;
    end;
     fIsInventoryScan := False;
end;

procedure TfrmUHFReader288main.Timer_Test_Timer(Sender: TObject);
begin
 if fisinventoryscan then    Exit;
    Action_InventoryExecute(sender);
end;

procedure TfrmUHFReader288main.ComboBox_IntervalTimeChange(Sender: TObject);
begin
Timer_Test_.Interval :=(ComboBox_IntervalTime.ItemIndex+1)*10;
end;

procedure TfrmUHFReader288main.SpeedButton_Read_G2Click(Sender: TObject);
begin
  if SpeedButton_Read_G2.Down  then
  begin
    if Length(Edit_AccessCode2.Text)<8 then
    begin
      SpeedButton_Read_G2.Down:=False;
      MessageDlg('Access Password Less Than 8 digit!Please input again!', mtInformation, [mbOK], 0);
      Exit;
    end;
    if (Edit_WordPtr.Text='')or (Edit_Len.Text='')then
    begin
      SpeedButton_Read_G2.Down:=False;
      MessageDlg('Start address or length is empty!Please input!', mtInformation, [mbOK], 0);
      Exit;
    end;
  Timer_G2_Read.Enabled:=True;
  end
  else
  begin
  Timer_G2_Read.Enabled:=False;
  StatusBar1.Panels.Items[0].text := FormatDateTime('hh:mm:ss', Now) +  ' "Read" over' ;
  end;
end;

procedure TfrmUHFReader288main.Timer_G2_ReadTimer(Sender: TObject);
var
    Mem,Num,WordPtr:Byte;
    ENum:byte;
    i: Integer;
    s2: string;
    CardData: array[0..320] of Char;
     MaskMem:Byte;
    MaskAdr:array[0..2]of Char;
    MaskLen:Byte;
    MaskData:array[0..80]of Char;
begin
  FillChar( MaskData,80,0);
  if  fTimer_G2_Read then    exit;
  fTimer_G2_Read:=true;
  try
    if SpeedButton_Read_G2.Down  then
    begin
      if(R_EPC.Checked)then MaskMem:=1;
      if(R_TID.Checked)then MaskMem:=2;
      if(R_User.Checked)then MaskMem:=3;

      if(CheckBox1.Checked)then
      begin
        ENum:=255;
        if(Edit2.Text='')then Exit;
        if(Edit3.Text='')then Exit;
        if(Edit1.Text='')or(Length(Edit1.Text)mod 2<>0)then Exit;
        getCharStr(Edit2.Text,MaskAdr);
        MaskLen:=StrToInt('$'+trim(edit3.Text));
        getCharStr(Edit1.Text,MaskData);
      end
      else
        ENum:=Length(ComboBox_EPC2.text) div 4;

      getCharStr(ComboBox_EPC2.text,fOperEPC);
      getCharStr(Edit_AccessCode2.text,fPassword);
      WordPtr:=StrToInt('$'+Edit_WordPtr.Text);
      Num:=StrToInt(Edit_Len.Text);
      if  C_Reserve.Checked then
        Mem:=0
      else if  C_EPC.Checked then
        Mem:=1
      else if  C_TID.Checked then
        Mem:=2
      else if  C_User.Checked then
        Mem:=3;
      fCmdRet:=ReadData_G2(fComAdr,@fOperEPC,ENum,Mem,WordPtr,Num,@fPassword,MaskMem,@MaskAdr,MaskLen,MaskData,@CardData,ferrorcode,frmComPortindex);
      if fCmdRet=0 then
      begin
        for i := 0 to Num*2 - 1 do
        s2 := s2 + IntToHex(ord(CardData[i]), 2);
        Memo_DataShow.Lines.Add(s2);
      end;
      if  fErrorCode<>-1 then
      begin
      StatusBar1.Panels.Items[0].text := FormatDateTime('hh:mm:ss', Now) +
       ' "Read" Response ErrorCode=0x'+ IntToHex(fErrorCode, 2) +
       '(' + UHFReader288_GetErrorCodeDesc(fErrorCode) + ')';
        ferrorcode:=-1;
      end
      else
      AddCmdLog('ReadData','Read', fCmdRet);
      if not (SpeedButton_Read_G2.Down)  then
      StatusBar1.Panels.Items[0].text := FormatDateTime('hh:mm:ss', Now) +  '"Read" over' ;
    end;
  finally
  fTimer_G2_Read:=false;
  end;
  if fAppClosed then Close;
end;

procedure TfrmUHFReader288main.Action_ShowOrChangeDataExecuteExecute(
  Sender: TObject);
var
    Mem,Num,WordPtr:Byte;
    Writedata:array[0..320] of Char;
    WNum:Byte;
    ENum:Byte;
    EPClength:byte;
    i: Integer;
    s,s2: string;
    CardData: array[0..320] of Char;
    WrittenDataNum:LongInt;
    MaskMem:Byte;
    MaskAdr:array[0..2]of Char;
    MaskLen:Byte;
    MaskData:array[0..80]of Char;
begin
    FillChar( MaskData,80,0);
    if(R_EPC.Checked)then MaskMem:=1;
    if(R_TID.Checked)then MaskMem:=2;
    if(R_User.Checked)then MaskMem:=3 ;
    if(CheckBox1.Checked)then
    begin
      ENum:=255;
      if(Edit2.Text='')then Exit;
      if(Edit3.Text='')then Exit;
      if(Edit1.Text='')or(Length(Edit1.Text)mod 2<>0)then Exit;
      getCharStr(Edit2.Text,MaskAdr);
      MaskLen:=StrToInt('$'+trim(edit3.Text));
      getCharStr(Edit1.Text,MaskData);
    end
    else
     ENum:=Length(ComboBox_EPC2.text) div 4;
     if Length(Edit_AccessCode2.Text)<8 then
      begin
       MessageDlg('Access Password Less Than 8 digit!Please input again!', mtInformation, [mbOK], 0);
        Exit;
      end;
      if (Edit_WordPtr.Text='')or(Edit_Len.Text='')then
      begin
       MessageDlg('Start address or length is empty!Please input!', mtInformation, [mbOK], 0);
        Exit;
      end;
    getCharStr(ComboBox_EPC2.text,fOperEPC);
   // getCharStr('DA7DE000',fOperEPC);
    getCharStr(Edit_AccessCode2.text,fPassword);
    WordPtr:=StrToInt('$'+Edit_WordPtr.Text);
    Num:=StrToInt(Edit_Len.Text);
    if  C_Reserve.Checked then
      Mem:=0
    else if  C_EPC.Checked then
      Mem:=1
    else if  C_TID.Checked then
      Mem:=2
    else if  C_User.Checked then
      Mem:=3;
    if Sender=Action_ShowOrChangeData_write then
    begin
      if (Edit_WriteData.Text='' )or (Length(Edit_WriteData.Text)mod 4<>0) then
      begin
      MessageDlg('Please input Data in words in hexadecimal form!'+#13+#10+'For example: 1234、12345678', mtInformation, [mbOK], 0);
      Exit;  //
      end;
      WNum:= Length(Edit_WriteData.text)div 4 ;
      getCharStr(Edit_WriteData.text,Writedata);
      if(CheckBox18.Checked)and(C_EPC.Checked)then
      begin
       WordPtr:=1;
       WNum:= Length(Edit_WriteData.text)div 4 +1;
       getCharStr(edit_pc.Text+Edit_WriteData.text,Writedata);
      end;
      fCmdRet:=WriteData_G2(fComAdr,@fOperEPC,WNum,ENum,Mem,WordPtr,@Writedata,@fPassword,MaskMem,@MaskAdr,MaskLen,@MaskData,ferrorcode,frmComPortindex);
      AddCmdLog('WriteData','Write', fCmdRet,ferrorcode);
      if fCmdRet=0 then
      begin
      StatusBar1.Panels.Items[0].text := FormatDateTime('hh:mm:ss', Now) +  ' "Write"Command Response=0x00' +
                  '(completely write Data successfully)';
      end;
    end;
     if Sender=Action_ShowOrChangeData_BlockWrite then
    begin
      if ( Edit_WriteData.Text='' )or (Length(Edit_WriteData.Text)mod 4<>0) then
      begin
       MessageDlg('Please input Data in words in hexadecimal form!'+#13+#10+'For example: 1234、12345678', mtInformation, [mbOK], 0);
      Exit;
      end;
      WNum:= Length(Edit_WriteData.text)div 4 ;
      getCharStr(Edit_WriteData.text,Writedata);
      if(CheckBox18.Checked)and(C_EPC.Checked)then
      begin
       WordPtr:=1;
       WNum:= Length(Edit_WriteData.text)div 4 +1;
       getCharStr(edit_pc.Text+Edit_WriteData.text,Writedata);
      end;
      fCmdRet:=BlockWrite_G2(fComAdr,@fOperEPC,WNum,ENum,Mem,WordPtr,@Writedata,@fPassword,MaskMem,@MaskAdr,MaskLen,@MaskData,ferrorcode,frmComPortindex);
     AddCmdLog('BlockWrite','Block Write', fCmdRet,ferrorcode);
      if fCmdRet=0 then
      begin
      StatusBar1.Panels.Items[0].text := FormatDateTime('hh:mm:ss', Now) +  ' “"BlockWrite"Command Response=0x00' +
                  '(completely Blockwrite Data successfully)';
      end;
    end;
    if Sender=Action_ShowOrChangeData_BlockErase then
    begin
      if Length(Edit_AccessCode2.Text)<8 then
      begin
        MessageDlg('Access Password Less Than 8 digit!Please input again!', mtInformation, [mbOK], 0);
        Exit;
      end;
      if (Edit_WordPtr.Text='')or (Edit_Len.Text='')then
      begin
        SpeedButton_Read_G2.Down:=False;
        MessageDlg('Start address or Length of Block erase is empty!Please input!', mtInformation, [mbOK], 0);
        Exit;
      end;
      if (strtoint(Edit_WordPtr.Text)<1)and C_EPC.checked then
      begin
       MessageDlg('the length of start Address of erasing EPC area is equal or greater than 0x01!', mtInformation, [mbOK], 0);
        Exit;   //
      end;
      fCmdRet:=BlockErase_G2(fComAdr,@fOperEPC,ENum,Mem,WordPtr,Num,@fPassword,MaskMem,@MaskAdr,MaskLen,@MaskData,ferrorcode,frmComPortindex);
       AddCmdLog('BlockErase', 'Erase Block', fCmdRet,ferrorcode);
      if fCmdRet=0 then
      begin
      StatusBar1.Panels.Items[0].text := FormatDateTime('hh:mm:ss', Now) +  ' “Block Erase”指令返回=0x00' +
                '(Block Erase successfully)';
      end;
    end;
end;

procedure TfrmUHFReader288main.Action_SetProtectStateExecute(Sender: TObject);
var
  select:byte;
  setprotect:Byte;
  return:Integer;
  ENum:Byte;
  MaskMem:Byte;
  MaskAdr:array[0..2]of Char;
  MaskLen:Byte;
  MaskData:array[0..80]of Char;
begin
    if(R_EPC.Checked)then MaskMem:=1;
    if(R_TID.Checked)then MaskMem:=2;
    if(R_User.Checked)then MaskMem:=3;
    FillChar( MaskData,80,0);
    if(CheckBox1.Checked)then
    begin
    ENum:=255;
     if(Edit2.Text='')then Exit;
    if(Edit3.Text='')then Exit;
    if(Edit1.Text='')or(Length(Edit1.Text)mod 2<>0)then Exit;
     MaskLen:=StrToInt('$'+trim(edit3.Text));
    getCharStr(Edit1.Text,MaskData);
    getCharStr(Edit2.Text,MaskAdr);
    end
    else
    ENum:=Length(ComboBox_EPC1.text) div 4;

    getCharStr(ComboBox_EPC1.text,fOperEPC);
    getCharStr(Edit_AccessCode1.text,fPassword);
    if P_Reserve.Checked and DestroyCode.Checked  then
     select:=$00
    else if P_Reserve.Checked and AccessCode.Checked then
     select:=$01
    else if P_EPC.Checked then
     select:=$02
    else if P_TID.Checked then
     select:=$03
    else if P_User.Checked then
     select:=$04;
    if P_Reserve.Checked then
    begin
      if NoProect.Checked then
       setprotect:=$00
      else if Proect.Checked then
       setprotect:=$02
      else if Always.Checked then
      begin
       setprotect:=$01;
       return:=MessageDlg('Set permanently readable and writeable Confirmed?', mtInformation, [mbOK, mbCancel], 0);
       if return = IDCancel then
       Exit;
      end
      else if AlwaysNot.Checked then
      begin
       setprotect:=$03;
       return:=MessageDlg('Set never readable and writeable Confirmed?', mtInformation, [mbOK, mbCancel], 0);
       if return = IDCancel then
       Exit;
      end;
    end
    else
    begin
      if NoProect2.Checked then
       setprotect:=$00
      else if Proect2.Checked then
       setprotect:=$02
      else if Always2.Checked then
      begin
       setprotect:=$01;
       return:=MessageDlg('Set permanently writeable Confirmed?', mtInformation, [mbOK, mbCancel], 0);
       if return = IDCancel then
       Exit;
      end
      else if AlwaysNot2.Checked then
      begin
       setprotect:=$03;
       return:=MessageDlg('Set never writeable Confirmed?', mtInformation, [mbOK, mbCancel], 0);
       if return = IDCancel then
       Exit;
      end;
    end;
    if Length(Edit_AccessCode1.Text)<8 then
    begin
       MessageDlg('Access Password Less Than 8 digit!Please input again!', mtInformation, [mbOK], 0);
      Exit;
    end;
    fCmdRet:=Lock_G2(fComAdr,@fOperEPC,ENum,select,setprotect,@fPassword,MaskMem,@MaskAdr,MaskLen,@MaskData,ferrorcode,frmComPortindex);  ;
    AddCmdLog('Lock', 'Lock', fCmdRet,ferrorcode);
end;

procedure TfrmUHFReader288main.Action_SetProtectStateUpdate(Sender: TObject);
var
  CanEnabled:Boolean;
  CanEnabled2:Boolean;
begin
   SpeedButton_Query .Enabled:=ComIsOpen and (not (SpeedButton_CheckAlarm_G2.Down) )
                                 and (not (SpeedButton_Read_G2.Down) ) ;
//    SpeedButton_detect.Enabled:=ComIsOpen and (not (SpeedButton_CheckAlarm_G2.Down));

    CanEnabled:=not (SpeedButton_Query.down) and  ComIsOpen and (ListView_EPC.Items.Count<>0)
                and (not (SpeedButton_CheckAlarm_G2.Down))and (not (SpeedButton_Read_G2.Down) );
    CanEnabled2:=not (SpeedButton_Query.down) and  ComIsOpen
                and (not (SpeedButton_CheckAlarm_G2.Down))and (not (SpeedButton_Read_G2.Down) );
    ComboBox_IntervalTime.Enabled:= CanEnabled2;

    AccessCode.Enabled:=CanEnabled and (P_Reserve.Checked) ;
    DestroyCode.Enabled:=CanEnabled and (P_Reserve.Checked) ;
    NoProect.Enabled:=CanEnabled and (P_Reserve.Checked) ;
    Proect.Enabled:=CanEnabled and (P_Reserve.Checked) ;
    Always.Enabled:=CanEnabled and (P_Reserve.Checked) ;
    AlwaysNot.Enabled:=CanEnabled and (P_Reserve.Checked) ;

    NoProect2.Enabled:=not (P_Reserve.Checked)and CanEnabled;
    Proect2.Enabled:=not (P_Reserve.Checked)and CanEnabled;
    Always2.Enabled:=not (P_Reserve.Checked)and CanEnabled;
    AlwaysNot2.Enabled:=not (P_Reserve.Checked)and CanEnabled;

    GroupBox5.Enabled:=CanEnabled;
    Label24.Enabled:=CanEnabled;
    ComboBox_EPC1.Enabled:=CanEnabled;
    GroupBox18.Enabled:=CanEnabled;

    Edit_AccessCode1.Enabled:=CanEnabled;
    GroupBox1.Enabled:=CanEnabled;
    P_Reserve.Enabled:=CanEnabled;
    P_EPC.Enabled:=CanEnabled;
    P_TID.Enabled:=CanEnabled;
    P_User.Enabled:=CanEnabled;
    GroupBox9.Enabled:=CanEnabled;
    Label33.Enabled:=CanEnabled;
    Edit_DestroyCode.Enabled:=CanEnabled;
    ComboBox_EPC3.Enabled:=CanEnabled;
    Button43.Enabled:= CanEnabled;
    Button44.Enabled:=  CanEnabled;
    GroupBox10.Enabled:=not (SpeedButton_Query.down) and  ComIsOpen and (ListView_EPC.Items.Count<>0)
                        and (not (SpeedButton_CheckAlarm_G2.Down));
    SpeedButton_Read_G2.Enabled:=GroupBox10.Enabled ;
    Memo_DataShow.Enabled:=GroupBox10.Enabled ;
    Button16.Enabled:=GroupBox10.Enabled ;
    
    Label9.Enabled:=CanEnabled;
    Label18.Enabled:=CanEnabled;
    Label19.Enabled:=CanEnabled;
    Label20.Enabled:=CanEnabled;
    ComboBox_EPC2.Enabled:=CanEnabled;
    Edit_AccessCode2.Enabled:=CanEnabled;
    Edit_WriteData.Enabled:=CanEnabled;
    Edit_WordPtr.Enabled:=CanEnabled;
    Edit_Len.Enabled:=CanEnabled;

    GroupBox6.Enabled:=CanEnabled;
    C_Reserve.Enabled:=CanEnabled;
    C_EPC.Enabled:=CanEnabled;
    C_TID.Enabled:=CanEnabled;
    C_User.Enabled:=CanEnabled;
    Button_SetProtectState.Enabled:=CanEnabled;
//    Button_DataRead.Enabled:=CanEnabled;

    Button_DataWrite.Enabled:=CanEnabled ;
    Button_BlockErase.Enabled:=CanEnabled;
    Button_BlockWrite.Enabled:=CanEnabled;
    Button_DestroyCard.Enabled:=CanEnabled;
   if CheckBox1.Checked and (not SpeedButton_Read_G2.Down) then
    begin
      Edit2.Enabled:=True;
      Edit3.Enabled:=True;
      Edit1.Enabled:=True;
      R_EPC.Enabled:=True;
      R_TID.Enabled:=True;
      R_User.Enabled:=True;
    end
    else
    begin
      Edit2.Enabled:=False ;
      Edit3.Enabled:=False;
      Edit1.Enabled:=False;
      R_EPC.Enabled:=False;
      R_TID.Enabled:=False;
      R_User.Enabled:=False;
    end;

    GroupBox23.Enabled:=CanEnabled2;
    Label38.Enabled:=CanEnabled2;
    Label39.Enabled:=CanEnabled2;
    Edit_AccessCode3.Enabled:=CanEnabled2;
    Button_WriteEPC_G2.Enabled:=CanEnabled2;
    Edit_WriteEPC.Enabled:=CanEnabled2;

    ComboBox_EPC4.Enabled:=CanEnabled;
    Button_SetReadProtect_G2.Enabled:=CanEnabled;

    GroupBox20.Enabled:=CanEnabled2;
    Label32.Enabled:=CanEnabled2;
    Edit_AccessCode4.Enabled:=CanEnabled2;
    Button_SetMultiReadProtect_G2.Enabled:=CanEnabled2;
    Button_RemoveReadProtect_G2.Enabled:=CanEnabled2;
    Button_CheckReadProtected_G2.Enabled:=CanEnabled2;

    Label35 .Enabled:=CanEnabled;
    Button_SetEASAlarm_G2.Enabled:=CanEnabled;
    ComboBox_EPC5.Enabled:=CanEnabled;
    Edit_AccessCode5.Enabled:=CanEnabled;
    GroupBox24 .Enabled:=CanEnabled;
    Alarm_G2 .Enabled:=CanEnabled;
    NoAlarm_G2.Enabled:=CanEnabled;

    GroupBox21.Enabled:=not (SpeedButton_Query.down) and  ComIsOpen
                        and(not (SpeedButton_Read_G2.Down) ) ;

    SpeedButton_CheckAlarm_G2.Enabled:=GroupBox21.Enabled;
end;

procedure TfrmUHFReader288main.Action_DestroyCardExecute(Sender: TObject);
var
  return:Integer;
  ENum:byte;
  MaskMem:Byte;
  MaskAdr:array[0..2]of Char;
  MaskLen:Byte;
  MaskData:array[0..80]of Char;
begin
    if(Edit2.Text='')then Exit;
    if(Edit3.Text='')then Exit;
    if(Edit1.Text='')or(Length(Edit1.Text)mod 2<>0)then Exit;
    if(R_EPC.Checked)then MaskMem:=1;
    if(R_TID.Checked)then MaskMem:=2;
    if(R_User.Checked)then MaskMem:=3;
    FillChar( MaskData,80,0);
    getCharStr(Edit2.Text,MaskAdr);
    if(CheckBox1.Checked)then
    ENum:=255
    else
    ENum:=Length(ComboBox_EPC3.text) div 4;
    MaskLen:=StrToInt('$'+trim(edit3.Text));
    getCharStr(Edit1.Text,MaskData);
   return:=MessageDlg('Kill the Tag  Confirmed?', mtInformation, [mbOK, mbCancel], 0);
  if return = IDok then
  begin
    if Length(Edit_DestroyCode.Text)<8 then
    begin
      MessageDlg('Kill Password Less Than 8 digit!Please input again!', mtInformation, [mbOK], 0);
      Exit;
    end;
    getCharStr(ComboBox_EPC3.text,fOperEPC);
    getCharStr(Edit_DestroyCode.text,fPassword);
    fCmdRet:=KillTag_G2(fComAdr,@fOperEPC,ENum,@fPassword,MaskMem,@MaskAdr,MaskLen,@MaskData,ferrorcode,frmComPortindex);
    AddCmdLog('KillTag_G2', 'Kill Tag', fCmdRet,ferrorcode);
    if fCmdRet=0 then
    begin
    StatusBar1.Panels.Items[0].text := FormatDateTime('hh:mm:ss', Now) +  ' "Kill Tag"Command Response=0x00' +
              '(Kill successfully)'
    end;
  end;
end;

procedure TfrmUHFReader288main.Action_WriteEPC_G2Execute(Sender: TObject);
var
  WriteEPC:array[0..100] of Char;
  ENum:byte;
begin
  if Length(Edit_AccessCode3.Text)<8 then
  begin
    MessageDlg('Access Password Less Than 8 digit!Please input again!', mtInformation, [mbOK], 0);
    Exit;
  end;
  if (Length(Edit_WriteEPC.Text)mod 4<>0) then
  begin
  MessageDlg('Please input Data in words in hexadecimal form!'+#13+#10+'For example: 1234、12345678', mtInformation, [mbOK], 0);
  Exit;
  end;
   ENum:=Length(Edit_WriteEPC.text) div 4;
  getCharStr(Edit_WriteEPC.text,WriteEPC);
  getCharStr(Edit_AccessCode3.text,fPassword);
  fCmdRet:=WriteEPC_G2(fComAdr,@fPassword,@WriteEPC,ENum,ferrorcode,frmComPortindex);
  AddCmdLog('WriteEPC_G2', 'Wtite EPC', fCmdRet,ferrorcode);
  if fCmdRet=0 then
  begin
  StatusBar1.Panels.Items[0].text := FormatDateTime('hh:mm:ss', Now) +  ' "Write EPC"Command Response=0x00' +
            '(Write EPC successfully)'
  end;
end;

procedure TfrmUHFReader288main.Action_SetReadProtect_G2Execute(Sender: TObject);
var
  ENum:byte;
  MaskMem:Byte;
  MaskAdr:array[0..2]of Char;
  MaskLen:Byte;
  MaskData:array[0..80]of Char;
begin
    if(Edit2.Text='')then Exit;
    if(Edit3.Text='')then Exit;
    if(Edit1.Text='')or(Length(Edit1.Text)mod 2<>0)then Exit;
    if(R_EPC.Checked)then MaskMem:=1;
    if(R_TID.Checked)then MaskMem:=2;
    if(R_User.Checked)then MaskMem:=3;
    FillChar( MaskData,80,0);
    getCharStr(Edit2.Text,MaskAdr);
     MaskLen:=StrToInt('$'+trim(edit3.Text));
      getCharStr(Edit1.Text,MaskData);
  if Length(Edit_AccessCode4.Text)<8 then
  begin
    MessageDlg('Access Password Less Than 8 digit!Please input again!', mtInformation, [mbOK], 0);
    Exit;
  end;
   if(CheckBox1.Checked)then
    ENum:=255
   else
   ENum:=Length(ComboBox_EPC4.text)div 4;
  getCharStr(ComboBox_EPC4.text,fOperEPC);
  getCharStr(Edit_AccessCode4.text,fPassword);
  fCmdRet:=SetPrivacyByEPC_G2(fComAdr,@fOperEPC,ENum,@fPassword,MaskMem,@MaskAdr,MaskLen,@MaskData,ferrorcode,frmComPortindex);
  AddCmdLog('SetPrivacyByEPC_G2', 'Set PrivacyBy EPC', fCmdRet,ferrorcode);
  if fCmdRet=0 then
  begin
  StatusBar1.Panels.Items[0].text := FormatDateTime('hh:mm:ss', Now) +  ' "Set PrivacyBy EPC"Command Response=0x00' +
            '(Set PrivacyBy EPC successfully)'
  end;
end;

procedure TfrmUHFReader288main.Action_SetMultiReadProtect_G2Execute(
  Sender: TObject);
begin
 if Length(Edit_AccessCode4.Text)<8 then
  begin
    MessageDlg('Access Password Less Than 8 digit!Please input again!', mtInformation, [mbOK], 0);
    Exit;
  end;
  getCharStr(Edit_AccessCode4.text,fPassword);
  fCmdRet:=SetPrivacyWithoutEPC_G2(fComAdr,@fPassword,ferrorcode,frmComPortindex);
  AddCmdLog('SetPrivacyWithoutEPC_G2', 'Set Privacy Without EPC', fCmdRet,ferrorcode);
  if fCmdRet=0 then
  begin
  StatusBar1.Panels.Items[0].text := FormatDateTime('hh:mm:ss', Now) +  ' "Set Privacy Without EPC"Command Response=0x00' +
            '(Set Privacy Without EPC successfully)'
  end;
end;

procedure TfrmUHFReader288main.Action_RemoveReadProtect_G2Execute(
  Sender: TObject);
begin
  if Length(Edit_AccessCode4.Text)<8 then
  begin
   MessageDlg('Access Password Less Than 8 digit!Please input again!', mtInformation, [mbOK], 0);
    Exit;
  end;
  getCharStr(Edit_AccessCode4.text,fPassword);
  fCmdRet:=ResetPrivacy_G2(fComAdr,@fPassword,ferrorcode,frmComPortindex);
  AddCmdLog('ResetPrivacy_G2', 'ResetPrivacy', fCmdRet,ferrorcode );
  if fCmdRet=0 then
  begin
  StatusBar1.Panels.Items[0].text := FormatDateTime('hh:mm:ss', Now) +  '"Reset Privacy"Command Response=0x00' +
            '(Reset Privacy successfully)'
  end;
end;

procedure TfrmUHFReader288main.Action_CheckReadProtected_G2Execute(
  Sender: TObject);
var
  readpro:Byte;
begin
  fCmdRet:=CheckPrivacy_G2(fComAdr,readpro,ferrorcode,frmComPortindex);
  AddCmdLog('CheckPrivacy_G2', 'Check Privacy', fCmdRet);
  if fCmdRet=0 then
  begin
   if readpro=0 then
  StatusBar1.Panels.Items[0].text := FormatDateTime('hh:mm:ss', Now) +  ' "Check Privacy"Command Response=0x00' +
            '(Single Tag is unprotected)';
   if readpro=1 then
  StatusBar1.Panels.Items[0].text := FormatDateTime('hh:mm:ss', Now) +  ' "Check Privacy"Command Response=0x01' +
            '(Single Tag is protected)';
  end ;
end;

procedure TfrmUHFReader288main.Action_SetEASAlarm_G2Execute(Sender: TObject);
var
  ENum:byte;
  EAS:Byte;
  MaskMem:Byte;
  MaskAdr:array[0..2]of Char;
  MaskLen:Byte;
  MaskData:array[0..80]of Char;
begin
    if(R_EPC.Checked)then MaskMem:=1;
    if(R_TID.Checked)then MaskMem:=2;
    if(R_User.Checked)then MaskMem:=3;
    FillChar( MaskData,80,0);
  if Length(Edit_AccessCode5.Text)<8 then
  begin
    MessageDlg('Access Password Less Than 8 digit!Please input again!', mtInformation, [mbOK], 0);
    Exit;
  end;
   if(CheckBox1.Checked)then
   begin
    ENum:=255;
     if(Edit2.Text='')then Exit;
      if(Edit3.Text='')then Exit;
      if(Edit1.Text='')or(Length(Edit1.Text)mod 2<>0)then Exit;
      getCharStr(Edit2.Text,MaskAdr);
        MaskLen:=StrToInt('$'+trim(edit3.Text));
        getCharStr(Edit1.Text,MaskData);
    end
   else
    ENum:=Length(ComboBox_EPC5.text) div 4;
  getCharStr(ComboBox_EPC5.text,fOperEPC);
  getCharStr(Edit_AccessCode5.text,fPassword);
  if Alarm_G2.checked then EAS:= $01
  else EAS:=$00;
  fCmdRet:=EASConfigure_G2(fComAdr,@fOperEPC,ENum,@fPassword,EAS,MaskMem,@MaskAdr,MaskLen,@MaskData,ferrorcode,frmComPortindex);
  AddCmdLog('EASConfigure_G2', 'EAS Configure', fCmdRet,ferrorcode);   //v2.1改
  if fCmdRet=0 then
  begin
   if Alarm_G2.checked then  //v2.1 add
   StatusBar1.Panels.Items[0].text := FormatDateTime('hh:mm:ss', Now) +  ' "EAS Configure"Command Response=0x00' +
            '(Set EAS Alarm successfully)'                 //
   else
   StatusBar1.Panels.Items[0].text := FormatDateTime('hh:mm:ss', Now) +  ' "EAS Configure"Command Response=0x00' +
            '(Clear EAS Alarm successfully)'
  end;
end;

procedure TfrmUHFReader288main.SpeedButton_CheckAlarm_G2Click(Sender: TObject);
begin
  if SpeedButton_CheckAlarm_G2.Down  then
  begin
    Timer_G2_Alarm.Enabled:=True;
  end
  else
  begin
    Timer_G2_Alarm.Enabled:=False;
    Label_Alarm.Visible:=False;                       //v2.1增加
    StatusBar1.Panels.Items[0].text := FormatDateTime('hh:mm:ss', Now) +  ' "EAS Alarm"over' ;
  end;
end;

procedure TfrmUHFReader288main.Timer_G2_AlarmTimer(Sender: TObject);
var
  ENum:byte;
begin
  if  fTimer_G2_Alarm then    exit;
  fTimer_G2_Alarm:=true;
  try
    if SpeedButton_CheckAlarm_G2.Down  then
    begin
      fCmdRet:=EASAlarm_G2(fComAdr,ferrorcode,frmComPortindex);
      if fCmdRet=0 then
      begin
         StatusBar1.Panels.Items[0].text := FormatDateTime('hh:mm:ss', Now) +  ' "EAS Alarm"Command Response=0x00' +
                  '(EAS alarm detected)';
         Label_Alarm.Visible:=True;                       //v2.1增加
      end
      else
      begin
        Label_Alarm.Visible:=False;                       //v2.1增加
        AddCmdLog('EASAlarm_G2', 'EAS Alarm', fCmdRet);
      end;
      if not(SpeedButton_CheckAlarm_G2.Down)then
      begin
        Label_Alarm.Visible:=False;                       //v2.1增加
        StatusBar1.Panels.Items[0].text := FormatDateTime('hh:mm:ss', Now) +  '"EAS Alarm"over' ;
      end;
    end;
  finally
    fTimer_G2_Alarm:=false;
  end;
  if fAppClosed then Close;
end;

procedure TfrmUHFReader288main.PageControl1Change(Sender: TObject);
begin
  if (PageControl1.ActivePage <> TabSheet_EPCC1G2) then
  begin
    Timer_Test_.Enabled := False;
    SpeedButton_Query.Down:=False;
    SpeedButton_CheckAlarm_G2.Down:=False;
    SpeedButton_Read_G2.Down:=False;
    Timer_G2_Alarm.Enabled:=False;
    Timer_G2_Read.Enabled:=False;
    SpeedButton_Write_6B.Down:=False;
    SpeedButton_Read_6B.Down:=False;
  end;
  if (PageControl1.ActivePage <> TabSheet_6B) then
  begin
  Timer_Test_6B.Enabled := False;
  SpeedButton_Query_6B.Down:=False;
  end;
  if(PageControl1.ActivePage<>TabSheet_Real)then
  begin
  Timer2.Enabled:=False;
  SpeedButton2.Down:=False;
  SpeedButton2.Caption:='Get';
  ISscanstring:=False;
  end;
  if(PageControl1.ActivePage<>TabSheet_active)then
  begin
    Timer1.Enabled:=False;
    SpeedButton1.Down:=False;
    SpeedButton1.Caption:='Get';
    ISscanstring:=False;
  end;
  if (PageControl1.ActivePage <> TabSheet3) then
  begin
  breakflag:=True;
  Button21.Enabled:=ComIsOpen;
  Button23.Enabled:=False;
  end
  else
  begin
   breakflag:=False;
  end;
  if (PageControl1.ActivePage <> TabSheet_Real)then
  begin
    Timer_Buff.Enabled:=False;
    btStartBuffer.Caption:='Start';
  end;
end;

procedure TfrmUHFReader288main.Button_AntClick(Sender: TObject);
var
  ANT:Byte;
begin
  ANT:=0;
  if(cant1.Checked)then ANT:=ANT or 1;
  if(cant2.Checked)then ANT:=ANT or 2;
  if(cant3.Checked)then ANT:=ANT or 4;
  if(cant4.Checked)then ANT:=ANT or 8;
  fCmdRet:=SetAntennaMultiplexing(fComAdr,ANT,frmComPortindex);
  if(fCmdRet=0)then
  begin
    ANT:=ANT and $0F;
    if(Ant and $01)= 1then
     Check_ant1.Checked:=True
    else
     Check_ant1.Checked:=False;

    if(Ant and $02)= 2then
     Check_ant2.Checked:=True
    else
     Check_ant2.Checked:=False;

    if(Ant and $04)= 4then
     Check_ant3.Checked:=True
    else
     Check_ant3.Checked:=False;

    if(Ant and $08)= 8then
     Check_ant4.Checked:=True
    else
     Check_ant4.Checked:=False;
  end;
  AddCmdLog('SetAntennaMultiplexing', 'SetAntenna', fCmdRet);
end;

procedure TfrmUHFReader288main.Button_BeepClick(Sender: TObject);
var
  BeepEn:byte;
begin
 if(Radio_beepEn.Checked)then
  BeepEn:=1
 else
  BeepEn:=0;
 fCmdRet:=SetBeepNotification(fComAdr,BeepEn,frmComPortindex);
 AddCmdLog('SetBeepNotification', 'Set', fCmdRet);
end;

procedure TfrmUHFReader288main.Edit8KeyPress(Sender: TObject; var Key: Char);
  var L:Boolean;
begin
   L:=(key<#8)or(key>#8)and(key<#48)or(key>#57) ;
    if l then key:=#0;
end;
function TfrmUHFReader288main.getNoStr(no: Integer; noLen: Integer): string;
begin
  result := intToStr(no);
  while Length(result) < noLen do
    result := '0' + result;
end;
procedure TfrmUHFReader288main.Button_clearBufferClick(Sender: TObject);
begin
  fCmdRet:=ClearTagBuffer(fcomadr,frmcomportindex);
  AddCmdLog('ClearTagBuffer', 'Clear Buffer', fCmdRet);
end;

procedure TfrmUHFReader288main.Button_RelayTimeClick(Sender: TObject);
var
RelayTime:Byte;
begin
  RelayTime:=ComboBox_RelayTime.ItemIndex+1;
  fCmdRet:=SetRelay(fcomadr,RelayTime,frmcomportindex);
  AddCmdLog('SetRelay', 'Set', fCmdRet);
end;

procedure TfrmUHFReader288main.Button_OutputRepClick(Sender: TObject);
var
  OutputRep:Byte;
begin
  OutputRep:=0;
  if(Check_out1.Checked)then
  OutputRep:=OutputRep or $01;
  if(Check_out2.Checked)then
  OutputRep:=OutputRep or $02;
  if(Check_out3.Checked)then
  OutputRep:=OutputRep or $04;
  if(Check_out4.Checked)then
  OutputRep:=OutputRep or $08;
  fCmdRet:=SetNotificationPulseOutput(fcomadr,OutputRep,frmcomportindex);
  AddCmdLog('SetNotificationPulseOutput', 'Set', fCmdRet);
end;

Function TfrmUHFReader288main.Str_IntToBin(Int: LongInt; Size: Integer): String;
Var
  i: Integer;
Begin
  Result:='';
  If Size < 1 Then Exit;
  For i := Size Downto 1 Do
    Begin
      If Int And (1 Shl (Size - i)) <> 0 Then
        Result := '1' + Result
      Else
        Result := '0' + Result;
    End;
End;
function TfrmUHFReader288main.BitStrToHextStr(const BitStr: String): String;
var
  vD : Byte;
  I : Integer;
  vHextStr : String;
  vP : PChar;
  vLen : Integer;
begin
  vLen := Length(BitStr);
  if vLen mod 4 > 0 then
  begin
      SetLength(vHextStr,   vLen   div   4   +   1);
      vLen := vlen div 4 + 1;
  end
  else
  begin
      SetLength(vHextStr,   vLen   div   4);
      vLen := vlen div 4 ;
  end;
  //初始化
  vD := 0;
  vP := PChar(BitStr)+length(BitStr)-1;
  I := 0;   //开始计数
  while vP^ <> #0 do
  begin
      if vp^ = '1' then
      begin
        case i of
          0:    vD :=vd+1;
          1:    vD :=vd+2;
          2:    vD :=vd+4;
          3:    vD :=vd+8;
        end;
      end;
      Dec(vP);
      Inc(I);
      if I = 4 then
      begin
        case vD of
          0..9 : vHextStr[vLen] := Chr(vD + $30);
          10..15 : vHextStr[vLen] := Chr(vD - 10 + $41);
        end;
        Dec(vLen);
        I :=   0;
        vD :=   0;
      end;
  end;
  if I > 0then
  begin
      case   vD   of
        0..9 : vHextStr[vLen] := Chr(vD + $30);
        10..15 : vHextStr[vLen] := Chr(vD + $41);
      end;
  end;
  Result := vHextStr;
end;
procedure TfrmUHFReader288main.ComboBox_dminfreSelect(Sender: TObject);
begin
  if CheckBox_SameFre.Checked then
  begin
    if TComboBox(Sender).Tag=1 then
    ComboBox_dminfre.ItemIndex:=ComboBox_dmaxfre.ItemIndex
    else
    ComboBox_dmaxfre.ItemIndex:=ComboBox_dminfre.ItemIndex;
  end
  else if  ComboBox_dminfre.ItemIndex> ComboBox_dmaxfre.ItemIndex  then
  begin
    if TComboBox(Sender).Tag=0 then
    ComboBox_dminfre.ItemIndex:=ComboBox_dmaxfre.ItemIndex
    else
    ComboBox_dmaxfre.ItemIndex:=ComboBox_dminfre.ItemIndex;
    Application.MessageBox('Min.Frequency is equal or lesser than Max.Frequency', 'Error Information', MB_ICONINFORMATION);
  end;
end;

procedure TfrmUHFReader288main.Button16Click(Sender: TObject);
begin
 Memo_DataShow.Lines.Clear;
end;

procedure TfrmUHFReader288main.Button21Click(Sender: TObject);
var
  dminfre, dmaxfre,Ffenpin:Byte;
  i,j,ncount:Integer;
  CardNum:Integer;
  Totallen,UID_index,n_index:Integer;
  EPC: array[0..5000] of Char;
  temp1,temp2,temp3,temp4:string;
  MaskMem:Byte;
  MaskAdr:array[0..2]of Char;
  MaskLen:Byte;
  MaskData:array[0..80]of Char;
  MaskFlag:Byte;
  Ant,AdrTID,LenTID,TIDFlag,QValue,Session:Byte;
begin
  Button21.Enabled:=False;
  Button23.Enabled:=True;
  ListBox1.Items.Clear;
  TIDFlag:=0;
  AdrTID:=0;
  LenTID:=0;
  QValue:=4;
  Session:=0;
  if(Session=4)then Session:=255;
     for  Ffenpin:=0 to 49 do
     begin
       Application.ProcessMessages;
       if(breakflag=True)then
       begin
       breakflag:=False;
       if fAppClosed then Close;
       Exit;
       end;
       dminfre := ((2 and 3)shl 6)or (Ffenpin and $3F) ;
       dmaxfre := ((2 and $c)shl 4)or (Ffenpin and $3F) ;
       y_f:=902.75+(Ffenpin and $3F)*0.5;
       temp4:=Format('%f',[y_f,0]);
       temp3:=temp4+'MHz'+'('+Format('%-2d',[Ffenpin])+')';
      // ListBox1.Items.Add(Format('%-4d',[Ffenpin]));
      ListBox1.Items.Add(temp3);
       for i:=0 to 3 do
       begin
       fCmdRet := SetRegion(fComAdr,dmaxfre,dminfre,frmcomportindex);
       if(fCmdRet=0)then
       Break;
       end;
       ncount:=0;
       for j:=0 to 29 do
       begin
         Application.ProcessMessages;
         if(breakflag)then
         begin
         breakflag:=False;
         if fAppClosed then Close;
         Exit;
         end;
         CardNum:=0;
         MaskFlag:=0 ;
         FastFlag:=0;
         fCmdRet :=Inventory_G2(fComAdr,QValue,Session,MaskMem,@MaskAdr,MaskLen,@MaskData,MaskFlag,AdrTID,LenTID,TIDFlag,Target,InAnt,Scantime,FastFlag,@EPC,Ant,Totallen,CardNum,frmcomportindex);
         if(fCmdRet=1) or(fCmdRet=2) or(fCmdRet=3)or(fCmdRet=4)  then
         begin
            ncount:=ncount+1;
            if(ncount=1)then
            UID_index := ListBox1.Items.IndexOf(temp3)
            else
            UID_index := ListBox1.Items.IndexOf(temp3+'            '+Format('%-2d',[ncount-1])+'/30');
            if UID_index>=0 then
            begin
              ListBox1.Items[UID_index] := temp3+'            '+Format('%-2d',[ncount])+'/30';
            end;
         end;
       end;
       if(ncount=0)then
       begin
         UID_index := ListBox1.Items.IndexOf(temp3);
          if UID_index>=0 then
            begin
              ListBox1.Items[UID_index] := temp3+'            '+Format('%-2d',[ncount])+'/30'+'                  '+'00.00%';
            end;
       end;
        UID_index := ListBox1.Items.IndexOf(temp3+'            '+Format('%-2d',[ncount])+'/30');
        if UID_index>=0 then
        begin
          x_z:=ncount/30*100;
          temp1:= FloatToStr(x_z);
          if(ncount=30)then
          temp2:='100.00%'
          else
          begin
             n_index:=Pos('.',temp1);
          //temp2:=Copy(temp1,1,2)+'.'+copy(temp1,3,2)+'%';
           if(n_index>0)then
            temp2:=Copy(temp1,1,n_index-1)+'.'+copy(temp1,n_index+1,2)+'%'
           else
            temp2:= temp1+'.'+'00'+'%';
        //  temp2:=Copy(temp1,1,2)+'.'+copy(temp1,3,2)+'%';
          end;
          ListBox1.Items[UID_index] := temp3+'            '+Format('%-2d',[ncount])+'/30'+'                  '+temp2;
        end;
        ListBox1.ItemIndex:=ListBox1.Items.Count-1;
     end;
    Button21.Enabled:=True;
    Button23.Enabled:=False;
end;

procedure TfrmUHFReader288main.Button23Click(Sender: TObject);
begin
 breakflag:=True;
 Button21.Enabled:=True;
 Button23.Enabled:=False;
end;

procedure TfrmUHFReader288main.Button24Click(Sender: TObject);
begin
ListBox1.Items.Clear;
end;

procedure TfrmUHFReader288main.ComboBox_COMChange(Sender: TObject);
begin
  ComboBox_baud2.Items.Clear;
  if(ComboBox_COM.ItemIndex=0)then
  begin
    ComboBox_baud2.Items.Add('9600bps');
    ComboBox_baud2.Items.Add('19200bps');
    ComboBox_baud2.Items.Add('38400bps');
    ComboBox_baud2.Items.Add('57600bps');
    ComboBox_baud2.Items.Add('115200bps');
    ComboBox_baud2.ItemIndex:=3;
  end
  else
  begin
    ComboBox_baud2.Items.Add('Auto');
    ComboBox_baud2.ItemIndex:=0;
  end;
end;

procedure TfrmUHFReader288main.CheckBox_TIDClick(Sender: TObject);
begin
 if(CheckBox_TID.Checked)then
  begin
  GroupBox31.Enabled:=True;
  Edit6.Enabled:=True;
  Edit11.Enabled:=True;
  end
 else
  begin
  GroupBox31.Enabled:=False;
  Edit6.Enabled:=False;
  Edit11.Enabled:=False;
  end;
end;

procedure TfrmUHFReader288main.Edit_WriteDataKeyPress(Sender: TObject;
  var Key: Char);
var L:Boolean;
begin
    L:=(key<#8)or(key>#8)and(key<#48)or(key>#57)and (key<#65)or(key>#70)and (key<#97)or(key>#102);
    if(key=#22)or (key=#3)then L:=False;
    if l then key:=#0;
    if ( (key>#96)and(key<#103))   then  key:=  char(Ord(key)-32) ;
end;

procedure TfrmUHFReader288main.SearchCallback1(var devIP:DWORD;mac, devName:PChar; dev:LongInt ) ;
type
    PIp_Addr=^IP_Addr;
    Ip_Addr=record
          a,b,c,d:byte;
    end;
var
  dwNo:LongInt;
  strmac,strdevName,strdevIP:string;
  IP: PIp_Addr;
  aListItem:TListItem;
begin
  dwNo:=ListView2.Items.Count;
  m_hDevArray[dwNo]:=dev;
  IP:=@devIP;
  strdevIP:=format('%d.%d.%d.%d ',[IP.d,Ip.c,Ip.b,Ip.a]);
  strmac:=mac;
  strdevName:=devName;
  aListItem := ListView2.Items.Add;
 // aListItem.Caption := IntToStr(aListItem.Index + 1);
 // aListItem.SubItems.Add('');
  aListItem.SubItems.Add('');
  aListItem.SubItems.Add('');
  aListItem.SubItems.Add('');//
  aListItem.Caption:=strdevName;
  ListView2.Items[dwNo].SubItems[0]:=strdevIP;
  ListView2.Items[dwNo].SubItems[1]:=strmac;
 // ListView2.Items[dwNo].SubItems[2]:=strmac;
end;

procedure TfrmUHFReader288main.RadioButton13Click(Sender: TObject);
begin
Button2.Enabled:=True;
Button4.Enabled:=True;
opnet.Enabled:=False;
closenet.Enabled:=False;
closenetClick(Sender);
end;

procedure TfrmUHFReader288main.opnetClick(Sender: TObject);
var
  Port:LongInt;
  IPaddr:string;
  openresult:LongInt;
begin
  Screen.Cursor := crHourGlass;
  try
  if(Edit12.Text='')then
  Exit;
  if(Edit13.Text='')then
  Exit;
  fComAdr := StrToInt('$' + Edit14.Text);
  Port:= StrToInt(Edit12.Text);
  IPaddr:=Trim(Edit13.Text);
  openresult:=OpenNetPort(Port,IPaddr,fComAdr,frmcomportindex) ;
  fOpenComIndex := frmcomportindex;
  if(openresult=0)then
  begin
    Action_GetReaderInformationExecute(Sender); //自动执行读取写卡器信息

    ComIsOpen:=True;
  end;
  finally
    Screen.Cursor := crDefault;
  end;
  if (fOpenComIndex <> -1) and
     (openresult <> $35)  and
     (openresult <> $30)  then
  begin

  end;
  if fOpenComIndex = -1 then
  begin
    Application.MessageBox('Communication error!', 'Information', MB_ICONINFORMATION);
  end;

  if ComIsOpen then
  begin
     RefreshStatus;
  end;
end;

procedure TfrmUHFReader288main.closenetClick(Sender: TObject);
begin
ClearLastInfo;
frmcomportindex:=StrToInt(Edit12.Text);
fCmdRet:=CloseNetPort(frmcomportindex);
if(fCmdRet=0)then
begin
  frmcomportindex:=-1;
  ComIsOpen:=False;
  fOpenComIndex := -1;
  ComboBox_AlreadyOpenCOM.clear;
  ComboBox_AlreadyOpenCOM.Repaint;
end;
end;

procedure TfrmUHFReader288main.RadioButton14Click(Sender: TObject);
begin
if(ComboBox_AlreadyOpenCOM.Items.Count>0)then
Button4Click(Sender) ;
Button2.Enabled:=False;
Button4.Enabled:=False;
opnet.Enabled:=True;
closenet.Enabled:=True;
end;

procedure TfrmUHFReader288main.ListView2DblClick(Sender: TObject);
var
  IP,temp:string;
  IPchar:PAnsiChar;
  name:string;
  pwd:string;
  dwno:Integer;
  errorcode:TagErrorCode;
begin       //
   if ListView2.Selected = nil then exit;
   if ListView2.Selected.SubItems[0]<>''then
   begin
     IP:=ListView2.Selected.SubItems[0];
     select_index:= ListView2.Selected.Index;
     fLoginForm.Show;
   end;
end;

procedure TfrmUHFReader288main.Search1Click(Sender: TObject);
var
  ret_tpye:LongInt;
  i:Integer;
  errorcode:Byte;
begin
 ListView2.Items.Clear;
  for i:=0 to 100 do
  begin //
    if(m_hDevArray[i]<>0)then
    DM_FreeDevice(m_hDevArray[i]) ;
  end;
  errorcode :=DM_SearchDevice($FFFFFFFF, 1000);
  if(errorcode<>0)then
  begin
    MessageDlg(GetDeviceErrorCodeDesc(errorcode), mtConfirmation, [mbOK], 0);
  end;
end;

procedure TfrmUHFReader288main.clear1Click(Sender: TObject);
var
  i,m:Integer;
begin
  m:=ListView2.Items.Count;
  if(m=0)then Exit;
  for i:=0 to m-1 do
  begin   //
    if(m_hDevArray[i]<>0)then
    DM_FreeDevice(m_hDevArray[i]) ;
  end;
  ListView2.Items.Clear;
  FillChar(m_hDevArray,100,0);
end;

procedure TfrmUHFReader288main.IE1Click(Sender: TObject);
var
  IP,temp:string;
  IPchar:PAnsiChar;
  name:string;
  pwd:string;
  dwno:Integer;
  errorcode:TagErrorCode;
begin
   if ListView2.Selected = nil then exit;
   if ListView2.Selected.SubItems[0]<>''then
   begin
     IP:=ListView2.Selected.SubItems[0];
     select_index:= ListView2.Selected.Index;

     IP:='http://'+IP;//
     IPchar:=PAnsiChar(IP);
     ShellExecute(Application.Handle,'open','IEXPLORE.EXE',IPchar,'',SW_SHOWNORMAL);
   end;
end;

procedure TfrmUHFReader288main.xxit1Click(Sender: TObject);
begin
Close;
end;

procedure TfrmUHFReader288main.elnet1Click(Sender: TObject);
var
  IP,temp:string;
  IPchar:PAnsiChar;
  name:string;
  pwd:string;
  dwno:Integer;
  errorcode:TagErrorCode;
begin
   if ListView2.Selected = nil then exit;
   if ListView2.Selected.SubItems[0]<>''then
   begin
     IP:=ListView2.Selected.SubItems[0];
     select_index:= ListView2.Selected.Index;
     IPchar:=PAnsiChar(IP);
     ShellExecute(Application.Handle,'open','telnet.EXE',IPchar,'',SW_SHOWNORMAL);
   end;
end;

procedure TfrmUHFReader288main.Ping1Click(Sender: TObject);
var
  IP,temp:string;
  IPchar:PAnsiChar;
  name:string;
  pwd:string;
  dwno:Integer;
  errorcode:TagErrorCode;
begin
   if ListView2.Selected = nil then exit;
   if ListView2.Selected.SubItems[0]<>''then
   begin
     IP:=ListView2.Selected.SubItems[0];
     select_index:= ListView2.Selected.Index;
     IP:=IP+'  -t';
     IPchar:=PAnsiChar(IP);
     ShellExecute(Application.Handle,'open','ping.exe',IPchar,'',SW_SHOWNORMAL);
   end;
end;

procedure TfrmUHFReader288main.FormCloseQuery(Sender: TObject;
  var CanClose: Boolean);
begin
  breakflag:=True;
  fAppClosed:=True;
end;

procedure TfrmUHFReader288main.FormDestroy(Sender: TObject);
begin
DM_DeInit() ;
end;

procedure TfrmUHFReader288main.C_UserClick(Sender: TObject);
begin
Edit_WordPtr.ReadOnly:=False;
end;

procedure TfrmUHFReader288main.C_TIDClick(Sender: TObject);
begin
Edit_WordPtr.ReadOnly:=False;
end;

procedure TfrmUHFReader288main.C_ReserveClick(Sender: TObject);
begin
Edit_WordPtr.ReadOnly:=False;
end;

procedure TfrmUHFReader288main.C_EPCClick(Sender: TObject);
begin
 if CheckBox18.Checked then
  begin
    Edit_WordPtr.ReadOnly:=True;
    Edit_WordPtr.Text:='0002';
  end
  else
  begin
   Edit_WordPtr.ReadOnly:=False;
  end;
end;

procedure TfrmUHFReader288main.CheckBox18Click(Sender: TObject);
var
  m,n:Integer;
begin
  if(CheckBox18.Checked)then
  begin
    Edit_WordPtr.Text:='0002';
    Edit_WordPtr.ReadOnly:=True;
    n:= Length(Trim(Edit_WriteData.Text));
    if(CheckBox18.Checked)and(n mod 4=0)and(C_EPC.Checked)then
    begin
      m:=n div 4;
      m:=(m and $3F) shl 3;
      Edit_PC.Text:=IntToHex(m,2)+'00';
    end;

  end
  else
  begin
    Edit_WordPtr.ReadOnly:=False;;
  end;
end;

procedure TfrmUHFReader288main.Edit_WriteDataChange(Sender: TObject);
var
  m,n:Integer;
begin
    n:= Length(Trim(Edit_WriteData.Text));
    if(CheckBox18.Checked)and(n mod 4=0)and(C_EPC.Checked)then
    begin
      m:=n div 4;
      m:=(m and $3F) shl 3;
      Edit_PC.Text:=IntToHex(m,2)+'00';
    end;
end;

procedure TfrmUHFReader288main.Button8Click(Sender: TObject);
var
  SeriaNo:array[0..4]of Char;
  temp:string;
begin
  fCmdRet:=GetSeriaNo(fComAdr,SeriaNo,frmComPortindex);
  if(fCmdRet=0)then
  begin
     temp:=getStr(SeriaNo,4);
     Edit15.Text:=getHexStr(temp);
  end;
  AddCmdLog('GetSeriaNo', 'Get', fCmdRet);
end;

procedure TfrmUHFReader288main.Button30Click(Sender: TObject);
var
  ATMode:Byte;
begin
  ATMode:=1;
  SeriaATflag:=False;
  fCmdRet:=ChangeATMode(fComAdr,ATMode,frmComPortindex);
  if(fCmdRet<>0)then
  begin
    SeriaATflag:=True;
  end;
  AddCmdLog('ChangeATMode', 'GOTO', fCmdRet);
end;

procedure TfrmUHFReader288main.Button31Click(Sender: TObject);
var
  ATMode:Byte;
begin
  ATMode:=0;
  fCmdRet:=ChangeATMode(fComAdr,ATMode,frmComPortindex);
  AddCmdLog('ChangeATMode', 'EXIT', fCmdRet);
end;

procedure TfrmUHFReader288main.Button32Click(Sender: TObject);
var
  timeout:Byte;
  nlen:Byte;
  cmddata:array[0..100]of Char;
  recvLen:Byte;
  recvdata:array[0..1000]of Char;
  i,m:Integer;
begin
  if(Edit16.Text='')then
  begin
  MessageDlg('AT command is null!', mtWarning, [mbOK], 0);
  Exit;
  end;
  m:= Length(Edit16.Text);
  move(Edit16.Text[1],cmddata,m);
  nlen:=m+2;
  cmddata[m]:=Char(13);
  cmddata[m+1]:=Char(10);
  timeout:=ComboBox6.ItemIndex+1;
  FillChar(recvdata,1000,0);
  fCmdRet:=TransparentCMD(fComAdr,timeout,nlen,cmddata,recvLen,recvdata,frmComPortindex);
  if(fCmdRet=0)then
  begin
   RichEdit1.Text:=strpas(recvdata);
  end;
   AddCmdLog('TransparentCMD', 'Send', fCmdRet);
end;

procedure TfrmUHFReader288main.Button33Click(Sender: TObject);
begin
  Edit16.Text:='';
  RichEdit1.Text:='';
end;

procedure TfrmUHFReader288main.Button9Click(Sender: TObject);
var
  timeout:Byte;
  nlen:Byte;
  cmddata:array[0..100]of Char;
  recvLen:Byte;
  recvdata:array[0..1000]of Char;
  i,q,m,n:Integer;
  cmd,recv,code:string;
begin
  SeriaATflag:=False;
  cmd:='AT!SP?';
  q:= Length(cmd);
  move(cmd[1],cmddata,q);
  nlen:=q+2;
  cmddata[q]:=Char(13);
  cmddata[q+1]:=Char(10);
  timeout:=30;
  FillChar(recvdata,1000,0);
  fCmdRet:=TransparentCMD(fComAdr,timeout,nlen,cmddata,recvLen,recvdata,frmComPortindex);
  if(fCmdRet=0)then
  begin
   recv:=strpas(recvdata);
  if(Pos('ERROR',recv)>0)or(recvLen=0)then
   begin
      MessageDlg('Get failed', mtWarning, [mbOK], 0);
      SeriaATflag:=True;
      Exit;
   end;
   m:= Pos(',',recv);
   recv:= Copy(recv,m+1,recvLen-m);
   recvLen:=recvLen-m;

   m:= Pos(',',recv);
   recv:= Copy(recv,m+1,recvLen-m);
   recvLen:=recvLen-m;

   m:= Pos(',',recv);
   code:= Copy(recv,1,m-1);
   baudrateCB.ItemIndex:=StrToInt(code);
   recv:= Copy(recv,m+1,recvLen-m);
   recvLen:=recvLen-m;

   m:= Pos(',',recv);
   code:= Copy(recv,1,m-1);
   databitCB.ItemIndex:=StrToInt(code);
   recv:= Copy(recv,m+1,recvLen-m);
   recvLen:=recvLen-m;

   m:= Pos(',',recv);
   code:= Copy(recv,1,m-1);
   stopbitCB.ItemIndex:=StrToInt(code);
   recv:= Copy(recv,m+1,recvLen-m);
   recvLen:=recvLen-m;

    m:= Pos(',',recv);
   code:= Copy(recv,1,m-1);
   parityCB.ItemIndex:=StrToInt(code);
   recv:= Copy(recv,m+1,recvLen-m);
   recvLen:=recvLen-m;

   m:= Pos(',',recv);
   code:= Copy(recv,1,m-1);
   flowCB.ItemIndex:=StrToInt(code);
   recv:= Copy(recv,m+1,recvLen-m);
   recvLen:=recvLen-m;

   m:= Pos(Char(13)+char(10),recv);
   code:= Copy(recv,1,m-1);
   fifoCB.ItemIndex:=StrToInt(code);
  end;
   AddCmdLog('TransparentCMD', 'Get', fCmdRet);
end;

procedure TfrmUHFReader288main.Button25Click(Sender: TObject);
var
  timeout:Byte;
  nlen:Byte;
  cmddata:array[0..100]of Char;
  recvLen:Byte;
  recvdata:array[0..1000]of Char;
  i,q,m,n:Integer;
  cmd,recv,code:string;
begin
  cmd:='AT!SP=0,1,';
  cmd:=cmd+inttostr(baudrateCB.ItemIndex) + ','+ inttostr(databitCB.ItemIndex)
                    + ','+ inttostr(stopbitCB.ItemIndex)+ ',' +inttostr(parityCB.ItemIndex)
                    + ',' + inttostr(flowCB.ItemIndex) + ','+ inttostr(fifoCB.ItemIndex);
  q:= Length(cmd);
  move(cmd[1],cmddata,q);
  nlen:=q+2;
  cmddata[q]:=Char(13);
  cmddata[q+1]:=Char(10);
  timeout:=30;
  FillChar(recvdata,1000,0);
  fCmdRet:=TransparentCMD(fComAdr,timeout,nlen,cmddata,recvLen,recvdata,frmComPortindex);
  if(fCmdRet=0)then
  begin
   recv:=strpas(recvdata);
   if(Pos('ERROR',recv)>0)or(recvLen=0)then
   begin
      MessageDlg('Set failed', mtWarning, [mbOK], 0);
      Exit;
   end;
  end;
  AddCmdLog('TransparentCMD', 'Set', fCmdRet);
end;

procedure TfrmUHFReader288main.Button26Click(Sender: TObject);
var
  timeout:Byte;
  nlen:Byte;
  cmddata:array[0..100]of Char;
  recvLen:Byte;
  recvdata:array[0..1000]of Char;
  i,q,m,n:Integer;
  cmd,recv,code:string;
begin
  SeriaATflag:=False;
   cmd:='AT!TC?';
  q:= Length(cmd);
  move(cmd[1],cmddata,q);
  nlen:=q+2;
  cmddata[q]:=Char(13);
  cmddata[q+1]:=Char(10);
  timeout:=30;
  FillChar(recvdata,1000,0);
  fCmdRet:=TransparentCMD(fComAdr,timeout,nlen,cmddata,recvLen,recvdata,frmComPortindex);
  if(fCmdRet=0)then
  begin
   recv:=strpas(recvdata);
   if(Pos('ERROR',recv)>0)or(recvLen=0)then
   begin
      MessageDlg('Get failed', mtWarning, [mbOK], 0);
      SeriaATflag:=True;
      Exit;
   end;
   m:= Pos(',',recv);
   recv:= Copy(recv,m+1,recvLen-m);
   recvLen:=recvLen-m;

   m:= Pos(',',recv);
   code:= Copy(recv,1,m-1);
   workasCB.ItemIndex:=StrToInt(code);
   recv:= Copy(recv,m+1,recvLen-m);
   recvLen:=recvLen-m;

   m:= Pos(',',recv);
   code:= Copy(recv,1,m-1);
   tcpActiveCB.ItemIndex:=StrToInt(code)-1;
   recv:= Copy(recv,m+1,recvLen-m);
   recvLen:=recvLen-m;

   m:= Pos(',',recv);
   code:= Copy(recv,1,m-1);
   tcpLocalPortNUD.Text:=code;
   recv:= Copy(recv,m+1,recvLen-m);
   recvLen:=recvLen-m;

   if(Pos('1800',recv)>0)then
   begin
     m:= Pos('"',recv);
     recv:= Copy(recv,m+1,recvLen-m);
     recvLen:=recvLen-m;
     m:= Pos(',',recv);
     code:= Copy(recv,1,m-2);
     tcpRomteHostTB.Text:=code;
     recv:= Copy(recv,m+1,recvLen-m);
     m:= Pos(',',recv);
     code:= Copy(recv,1,m-1);
     tcpRemotePortNUD.Text:=code;
   end
   else
   begin
     m:= Pos(',',recv);
     code:= Copy(recv,1,m-1);
     tcpRemotePortNUD.Text:=code;
     recv:= Copy(recv,m+1,recvLen-m);
     recvLen:=recvLen-m;
     m:= Pos(',',recv);
     code:= Copy(recv,2,m-3);
     tcpRomteHostTB.Text:=code;
     recv:= Copy(recv,m+1,recvLen-m);
     recvLen:=recvLen-m;
   end
  end;
   AddCmdLog('TransparentCMD', 'Get', fCmdRet);
end;

procedure TfrmUHFReader288main.Button27Click(Sender: TObject);
var
  timeout:Byte;
  nlen:Byte;
  cmddata:array[0..100]of Char;
  recvLen:Byte;
  recvdata:array[0..1000]of Char;
  i,q,m,n:Integer;
  cmd,recv,code:string;
begin
  cmd:='AT!TC= 0,';
  cmd:=cmd+inttostr(workasCB.ItemIndex) + ','+ inttostr(tcpActiveCB.ItemIndex+1)
                    + ','+ tcpLocalPortNUD.Text+ ',' +tcpRemotePortNUD.Text
                    + ',"' + tcpRomteHostTB.Text + '",'+ ',';
  q:= Length(cmd);
  move(cmd[1],cmddata,q);
  nlen:=q+2;
  cmddata[q]:=Char(13);
  cmddata[q+1]:=Char(10);
  timeout:=30;
  FillChar(recvdata,1000,0);
  fCmdRet:=TransparentCMD(fComAdr,timeout,nlen,cmddata,recvLen,recvdata,frmComPortindex);
  if(fCmdRet=0)then
  begin
   recv:=strpas(recvdata);
   if(Pos('ERROR',recv)>0)or(recvLen=0)then
   begin
      cmd:='AT!TC= 0,';
      cmd:=cmd+inttostr(workasCB.ItemIndex) + ','+ inttostr(tcpActiveCB.ItemIndex+1)
                        + ','+ tcpLocalPortNUD.Text+ ',' +tcpRomteHostTB.Text
                        + ',"' + tcpRemotePortNUD.Text + '",'+ ',';
      q:= Length(cmd);
      move(cmd[1],cmddata,q);
      nlen:=q+2;
      cmddata[q]:=Char(13);
      cmddata[q+1]:=Char(10);
      timeout:=30;
      FillChar(recvdata,1000,0);
      fCmdRet:=TransparentCMD(fComAdr,timeout,nlen,cmddata,recvLen,recvdata,frmComPortindex);
      if(fCmdRet=0)then
      begin
       recv:=strpas(recvdata);
       if(Pos('ERROR',recv)>0)or(recvLen=0)then
       begin

          MessageDlg('Set failed', mtWarning, [mbOK], 0);
          Exit;
       end;
      end;
   end;
  end;
  AddCmdLog('TransparentCMD', 'Set', fCmdRet);
end;

procedure TfrmUHFReader288main.Button28Click(Sender: TObject);
var
  timeout:Byte;
  nlen:Byte;
  cmddata:array[0..100]of Char;
  recvLen:Byte;
  recvdata:array[0..1000]of Char;
  i,q,m,n:Integer;
  cmd,recv,code:string;
begin
  SeriaATflag:=False;
  cmd:='AT!IC?';
  q:= Length(cmd);
  move(cmd[1],cmddata,q);
  nlen:=q+2;
  cmddata[q]:=Char(13);
  cmddata[q+1]:=Char(10);
  timeout:=30;
  FillChar(recvdata,1000,0);
  fCmdRet:=TransparentCMD(fComAdr,timeout,nlen,cmddata,recvLen,recvdata,frmComPortindex);
  if(fCmdRet=0)then
  begin
   recv:=strpas(recvdata);
   if(Pos('ERROR',recv)>0)or(recvLen=0)then
   begin
      MessageDlg('Get failed', mtWarning, [mbOK], 0);
      SeriaATflag:=True;
      Exit;
   end;
   m:= Pos('"',recv);
   recv:= Copy(recv,m+1,recvLen-m);
   recvLen:=recvLen-m;

   m:= Pos('"',recv);
   code:= Copy(recv,1,m-1);
   ipTB.Text:=code;
   recv:= Copy(recv,m+3,recvLen-m);
   recvLen:=recvLen-m;

   m:= Pos('"',recv);
   code:= Copy(recv,1,m-1);
   subnetTB.Text:=code;
   recv:= Copy(recv,m+3,recvLen-m);
   recvLen:=recvLen-m;

   m:= Pos('"',recv);
   code:= Copy(recv,1,m-1);
   gatewayTB.Text:=code;
   recv:= Copy(recv,m+3,recvLen-m);
   recvLen:=recvLen-m;

   m:= Pos('"',recv);
   code:= Copy(recv,1,m-1);
   pDNSTB.Text:=code;
   recv:= Copy(recv,m+3,recvLen-m);
   recvLen:=recvLen-m;

   m:= Pos('"',recv);
   code:= Copy(recv,1,m-1);
   altDNSTB.Text:=code;
  end;
   AddCmdLog('TransparentCMD', 'Get', fCmdRet);
   Sleep(500);
  cmd:='AT!EC?';
  q:= Length(cmd);
  move(cmd[1],cmddata,q);
  nlen:=q+2;
  cmddata[q]:=Char(13);
  cmddata[q+1]:=Char(10);
  timeout:=30;
  FillChar(recvdata,1000,0);
  fCmdRet:=TransparentCMD(fComAdr,timeout,nlen,cmddata,recvLen,recvdata,frmComPortindex);
  if(fCmdRet=0)then
  begin
   recv:=strpas(recvdata);
   if(Pos('ERROR',recv)>0)or(recvLen=0)then
   begin
      MessageDlg('Get failed', mtWarning, [mbOK], 0);
      Exit;
   end;
   m:= Pos('"',recv);
   recv:= Copy(recv,m+1,recvLen-m);
   recvLen:=recvLen-m;

   m:= Pos('"',recv);
   code:= Copy(recv,1,m-1);
   macTB.Text:=code;
  end;
end;

procedure TfrmUHFReader288main.Button29Click(Sender: TObject);
var
  timeout:Byte;
  nlen:Byte;
  cmddata:array[0..100]of Char;
  recvLen:Byte;
  recvdata:array[0..1000]of Char;
  i,q,m,n:Integer;
  cmd,recv,code:string;
begin
  cmd:='AT!IC=0,"';
  cmd:=cmd+ipTB.Text + '","' + subnetTB.Text
                    + '","' + gatewayTB.Text + '","' + pDNSTB.Text
                    + '","'+ altDNSTB.Text+'"';
  q:= Length(cmd);
  move(cmd[1],cmddata,q);
  nlen:=q+2;
  cmddata[q]:=Char(13);
  cmddata[q+1]:=Char(10);
  timeout:=30;
  FillChar(recvdata,1000,0);
  fCmdRet:=TransparentCMD(fComAdr,timeout,nlen,cmddata,recvLen,recvdata,frmComPortindex);
  if(fCmdRet=0)then
  begin
   recv:=strpas(recvdata);
   if(Pos('ERROR',recv)>0)or(recvLen=0)then
   begin
      cmd:='AT!IC=0,"';
      cmd:=cmd+ipTB.Text + '","'
                        + '","' + gatewayTB.Text + '","' + pDNSTB.Text
                        + '","'+ altDNSTB.Text+'"';
      q:= Length(cmd);
      move(cmd[1],cmddata,q);
      nlen:=q+2;
      cmddata[q]:=Char(13);
      cmddata[q+1]:=Char(10);
      timeout:=30;
      FillChar(recvdata,1000,0);
      Sleep(500);
      fCmdRet:=TransparentCMD(fComAdr,timeout,nlen,cmddata,recvLen,recvdata,frmComPortindex);
      if(fCmdRet=0)then
      begin
       recv:=strpas(recvdata);
       if(Pos('ERROR',recv)>0)or(recvLen=0)then
       begin
          MessageDlg('Set failed', mtWarning, [mbOK], 0);
          Exit;
       end;
      end;
      MessageDlg('Set failed', mtWarning, [mbOK], 0);
      Exit;
   end;
  end;
  AddCmdLog('TransparentCMD', 'Send', fCmdRet);
end;

procedure TfrmUHFReader288main.Button34Click(Sender: TObject);
var
  timeout:Byte;
  nlen:Byte;
  cmddata:array[0..100]of Char;
  recvLen:Byte;
  recvdata:array[0..1000]of Char;
  i,q,m,n:Integer;
  cmd,recv,code:string;
begin
  cmd:='AT!S';
  q:= Length(cmd);
  move(cmd[1],cmddata,q);
  nlen:=q+2;
  cmddata[q]:=Char(13);
  cmddata[q+1]:=Char(10);
  timeout:=30;
  FillChar(recvdata,1000,0);
  fCmdRet:=TransparentCMD(fComAdr,timeout,nlen,cmddata,recvLen,recvdata,frmComPortindex);
  if(fCmdRet=0)then
  begin
   recv:=strpas(recvdata);
   if(Pos('ERROR',recv)>0)or(recvLen=0)then
   begin
      MessageDlg('Set failed', mtWarning, [mbOK], 0);
      Exit;
   end;
  end;
  AddCmdLog('TransparentCMD', 'Send', fCmdRet);
  Sleep(500);
  cmd:='AT!R';
  q:= Length(cmd);
  move(cmd[1],cmddata,q);
  nlen:=q+2;
  cmddata[q]:=Char(13);
  cmddata[q+1]:=Char(10);
  timeout:=30;
  FillChar(recvdata,1000,0);
  fCmdRet:=TransparentCMD(fComAdr,timeout,nlen,cmddata,recvLen,recvdata,frmComPortindex);
  if(fCmdRet=0)then
  begin
   recv:=strpas(recvdata);
   if(Pos('ERROR',recv)>0)or(recvLen=0)then
   begin
      MessageDlg('Set failed', mtWarning, [mbOK], 0);
      Exit;
   end;
  end;
  AddCmdLog('TransparentCMD', 'Send', fCmdRet);
end;

procedure TfrmUHFReader288main.Button35Click(Sender: TObject);
var
  timeout:Byte;
  nlen:Byte;
  cmddata:array[0..100]of Char;
  recvLen:Byte;
  recvdata:array[0..1000]of Char;
  i,q,m,n:Integer;
  cmd,recv,code:string;
begin
  cmd:='AT!LD';
  q:= Length(cmd);
  move(cmd[1],cmddata,q);
  nlen:=q+2;
  cmddata[q]:=Char(13);
  cmddata[q+1]:=Char(10);
  timeout:=30;
  FillChar(recvdata,1000,0);
  fCmdRet:=TransparentCMD(fComAdr,timeout,nlen,cmddata,recvLen,recvdata,frmComPortindex);
  if(fCmdRet=0)then
  begin
   recv:=strpas(recvdata);
   if(Pos('ERROR',recv)>0)or(recvLen=0)then
   begin
      MessageDlg('Set failed', mtWarning, [mbOK], 0);
      Exit;
   end;
  end;
  AddCmdLog('TransparentCMD', 'Load default value', fCmdRet);
end;

procedure TfrmUHFReader288main.Button6Click(Sender: TObject);
var
  CheckANT:Byte ;
begin
  if OpenANT.Checked then  CheckANT:=1
  else CheckANT:=0;
   fCmdRet:=SetCheckAnt(fComAdr,CheckANT,frmComPortindex);
  AddCmdLog('SetCheckAnt', 'Set', fCmdRet);
end;

procedure TfrmUHFReader288main.ClockCMDClick(Sender: TObject);
var
  SetTime:array[0..6] of char;
  CurrentTime:array[0..6] of char;
begin
  if RadioButton_SetClock.checked then
  begin
    if (Edit_year.Text = '')   or (Edit_Month.Text = '') or
       (Edit_Date.Text = '')   or (Edit_Hour.Text = '')  or
       (Edit_Min.Text = '') or (Edit_Sedcond.Text = '') then
    begin
     Application.MessageBox('Please input data', 'Infomation', MB_ICONINFORMATION);
     exit;
    end;
    SetTime[0] := char(strtoint(copy(Edit_year.Text, 1, 2)));           //需要设置的时间
    SetTime[1] := char(strtoint(copy(Edit_Month.Text, 1, 2)));
    SetTime[2] := char(strtoint(copy(Edit_Date.Text, 1, 2)));
    SetTime[3] := char(strtoint(copy(Edit_Hour.Text, 1, 2)));
    SetTime[4] := char(strtoint(copy(Edit_Min.Text, 1, 2)));
    SetTime[5] := char(strtoint(copy(Edit_Sedcond.Text, 1, 2)));

    if (strtoint(Edit_year.Text) < 0) or
      (strtoint(Edit_year.Text) > $63) then
    begin
      Application.MessageBox('Please input data from 00-99', 'Infomation', MB_ICONINFORMATION);
      exit;
    end;
    fCmdRet := SetReal_timeClock(fComAdr, SetTime,frmComPortindex);
    AddCmdLog('@', 'Set Clock', fCmdRet);
  end
  else if RadioButton_GetClock.Checked then
  begin
    fCmdRet := GetTime(fComAdr, CurrentTime,frmComPortindex);
    if fCmdRet  = OK then
    begin
      Edit_year.Text := getNoStr(Ord(CurrentTime[0]),2);          //查询得到的时间
      Edit_Month.Text := getNoStr(Ord(CurrentTime[1]),2);
      Edit_Date.Text := getNoStr(Ord(CurrentTime[2]),2);
      Edit_Hour.Text := getNoStr(Ord(CurrentTime[3]),2);
      Edit_Min.Text := getNoStr(Ord(CurrentTime[4]),2);
      Edit_Sedcond.Text := getNoStr(Ord(CurrentTime[5]),2);
    end;
    AddCmdLog('GetTime', 'Query Clock', fCmdRet);
  end;
end;

procedure TfrmUHFReader288main.Button_SetGPIOClick(Sender: TObject);
var
  OutputPin:Byte;
begin
  OutputPin:=0;
  if(COUT1.Checked)then
  OutputPin:=OutputPin or $01;
  if(COUT2.Checked)then
  OutputPin:=OutputPin or $02;
  if(COUT3.Checked)then
  OutputPin:=OutputPin or $04;
  if(COUT4.Checked)then
  OutputPin:=OutputPin or $08;
  fCmdRet:=SetGPIO(fcomadr,OutputPin,frmcomportindex);
  AddCmdLog('SetGPIO', 'Set', fCmdRet);
end;

procedure TfrmUHFReader288main.Button_GetGPIOClick(Sender: TObject);
var
  OutputPin:Byte;
begin
  OutputPin:=0;
  fCmdRet:=GetGPIOStatus(fcomadr,OutputPin,frmcomportindex);
  if(fCmdRet=0)then
  begin
   if(OutputPin and $01)=1then
   CINT1.Checked:=True
   else
   CINT1.Checked:=False;

   if(OutputPin and $02)=$02then
   CINT2.Checked:=True
   else
   CINT2.Checked:=False;
   if(OutputPin and $04)=$04then
   CINT3.Checked:=True
   else
   CINT3.Checked:=False;
   if(OutputPin and $08)=$08then
   CINT4.Checked:=True
   else
   CINT4.Checked:=False;


   if(OutputPin and $10)=$10then
   COUT1.Checked:=True
   else
   COUT1.Checked:=False;
   if(OutputPin and $20)=$20then
   COUT2.checked:=True
   else
   COUT2.Checked:=False;
   if(OutputPin and $40)=$40then
   COUT3.Checked:=True
   else
   COUT3.Checked:=False;
   if(OutputPin and $80)=$80then
   COUT4.Checked:=True
   else
   COUT4.Checked:=False;
  end;
  AddCmdLog('GetGPIO', 'Get', fCmdRet);
end;

procedure TfrmUHFReader288main.Action_Query_6BExecute(Sender: TObject);
var
   i:   Integer;
begin
    if not (SpeedButton_Query_6B.down) then
    begin
      AddCmdLog('Inventory', 'Exit query', 0);
      Timer_Test_6B.Enabled:=False;
    end
    else
    begin
      if Bycondition_6B.Checked then
      begin
        if (Edit_Query_StartAddress_6B.Text='') or (Edit_ConditionContent_6B.Text='') then
        begin
          MessageDlg('Start address or condition is empty!Please input!', mtInformation, [mbOK], 0);
          SpeedButton_Query_6B.down:=False;
          Exit;
        end;
      end;
      Timer_Test_6B.Enabled:=True;
      ListView_ID_6B.Clear;
      ComboBox_ID1_6B.Clear;
    end;
end;

procedure TfrmUHFReader288main.Action_Inventroy_6BExecute(Sender: TObject);
procedure ChangeSubItem1(aListItem: TListItem; subItemIndex: Integer; ItemText: string;ant1,RSSI:string);
  begin
    if aListItem.SubItems[subItemIndex] = ItemText then
    begin
      if(aListItem.SubItems[1]='')then
      begin
         aListItem.SubItems[1]:=ant1;
      end
      else
      begin
         aListItem.SubItems[1]:=Str_IntToBin(StrToInt('$'+BitStrToHextStr(aListItem.SubItems[1]))or StrToInt('$'+BitStrToHextStr(ant1)),4) ;
      //  aListItem.SubItems[2]:=IntToStr(StrToInt(aListItem.SubItems[2])or StrToInt(ant1));
      end;
      if (aListItem.SubItems[2]='99999') or (aListItem.SubItems[2]='')then              //aListItem.SubItems[2]为次数
       aListItem.SubItems[2]:='0'                        //aListItem.SubItems[0]为 EPC号
      else
      begin
       aListItem.SubItems[2]:= IntToStr(StrToInt(aListItem.SubItems[2])+1);
       aListItem.SubItems[3]:=RSSI;
       exit; //内容相同则不需要修改，可以不闪烁
      end;
    end;
     aListItem.SubItems[1]:=ant1;
    aListItem.SubItems[2]:='1';
    aListItem.SubItems[3]:=RSSI;
    aListItem.SubItems[subItemIndex] := ItemText;

  end;
   procedure ChangeSubItem2(aListItem: TListItem; subItemIndex: Integer; ItemText,RSSI: string);
  begin
    if aListItem.SubItems[subItemIndex] = ItemText then         //aListItem.SubItems[1]为 EPC长度
    exit; //内容相同则不需要修改，可以不闪烁
    aListItem.SubItems[subItemIndex] := ItemText;
  end;
var
  CardNum:Integer;
  EPClen,m,Totallen:Integer;
  ID_6B: array[0..2000] of Char;
  ID2_6B: array[0..5000] of Char;
  isonstring:Boolean;
  isonlistview:Boolean;
  CardIndex: Integer;
  temps: string;
  s,ss, sID: string;
  aListItem: TListItem;
  RSSI,temps2, temps3: string;
  i, j: integer;
  Condition,Ant:Byte;
  StartAddress,mask:Byte;
  ConditionContent:array[0..300] of Char;
  Contentlen:Byte;

begin
  fIsInventoryScan_6B := true;
  try
    if Byone_6B.Checked then
    begin
    fCmdRet :=InventorySingle_6B(fComAdr,Ant,@ID_6B,frmcomportindex);
      if  fCmdRet = $00  then //代表已查找结束，并且内容有发生变化
      begin
         temps :=getStr(ID_6B,10);                                                       //屏蔽
              s := getHexStr(temps);
              RSSI:= Copy(s,19,2);
              s:=Copy(s,3,16);

              RSSI:= IntToStr(StrToInt('$'+RSSI));
            isonlistview:=False;
           // Str_IntToBin(Ant,4)//
            for i:=1 to ListView_ID_6B.Items.Count do      //判断是否在Listview列表内
            begin
              if s=(ListView_ID_6B.Items[i - 1]).SubItems[0] then
              begin
               aListItem := ListView_ID_6B.Items[i - 1];
               isonlistview:=True;
              end;
            end;
            if (not isonlistview) then
            begin
              aListItem := ListView_ID_6B.Items.Add;
              aListItem.Caption := IntToStr(aListItem.Index + 1);
              aListItem.SubItems.Add('');
              aListItem.SubItems.Add('');
              aListItem.SubItems.Add('');
              aListItem.SubItems.Add('');
              aListItem.SubItems.Add('');
              aListItem.SubItems.Add('');
              aListItem := ListView_ID_6B.Items[ListView_ID_6B.Items.Count - 1];
            //  ChangeSubItem2(aListItem, 1, ,RSSI);
              ComboBox_ID1_6B.Items.Add(s);
            end;
             ChangeSubItem1(aListItem, 0,s, Str_IntToBin(Ant,4),RSSI);
              ComboBox_ID1_6B.Itemindex:=0;
      end;
    end

    else if Bycondition_6B.Checked then
    begin
      if  Same_6B.Checked then
      Condition:=$00
      else if Different_6B.Checked then
      Condition:=$01
      else if Greater_6B.Checked  then
      Condition:=$02
      else if Less_6B.Checked then
      Condition:=$03;
      ss:=Edit_ConditionContent_6B.text;
      Contentlen:=Length(Edit_ConditionContent_6B.text) ;
      for i:=1 to 16-Contentlen do
      ss:=ss+'0';
      getCharStr(ss,ConditionContent);
      case (Contentlen div 2) of
        1: mask:=$80;
        2: mask:=$C0;
        3: mask:=$E0;
        4: mask:=$F0;
        5: mask:=$F8;
        6: mask:=$FC;
        7: mask:=$FE;
        8: mask:=$FF;
      end;
      StartAddress:= StrToInt(Edit_Query_StartAddress_6B.Text);
      //mask:=StrToInt('$'+Edit_mask_6B.Text);
      fCmdRet :=InventoryMultiple_6B(fComAdr,Condition,StartAddress,mask,@ConditionContent,Ant,@ID2_6B,Cardnum,frmcomportindex);

      if  (fCmdRet = $15)or (fCmdRet = $16)or (fCmdRet = $17)or (fCmdRet = $18)or(fCmdRet = $FB)    then
      begin
         temps :=getStr(ID2_6B,Cardnum*10);
          fInventory_EPC_List := tempS;             //存贮记录
            m:=1;
          for CardIndex := 1 to CardNum do
          begin
              sID := copy(tempS,m,10) ;
              m:=m+10;
              if Length(sID) <> 10 then Continue;
              s := getHexStr(sID);
              RSSI:= Copy(s,19,2);
              s:=Copy(s,3,16);
              RSSI:= IntToStr(StrToInt('$'+RSSI));
            isonlistview:=False;
            for i:=1 to ListView_ID_6B.Items.Count do      //判断是否在Listview列表内
            begin
              if copy(s, 1, Length(s))=(ListView_ID_6B.Items[i - 1]).SubItems[0] then
              begin
               aListItem := ListView_ID_6B.Items[i - 1];
               isonlistview:=True;
              end;
            end;
            if (not isonlistview) then
            begin
              aListItem := ListView_ID_6B.Items.Add;
              aListItem.Caption := IntToStr(aListItem.Index + 1);
              aListItem.SubItems.Add('');
              aListItem.SubItems.Add('');
              aListItem.SubItems.Add('');
              aListItem.SubItems.Add('');
              aListItem.SubItems.Add('');
              aListItem.SubItems.Add('');
              aListItem := ListView_ID_6B.Items[ListView_ID_6B.Items.Count - 1];
              ComboBox_ID1_6B.Items.Add(copy(s, 1, Length(s)));
            end;
            ChangeSubItem1(aListItem, 0,s, Str_IntToBin(Ant,4),RSSI);
            ComboBox_ID1_6B.Itemindex:=0;
          end;
      end;
    end;
  //        if ByEffect_6B.Checked  then
//          ListView_ID_6B.Clear;
    if Timer_Test_6B.Enabled then
    begin
      if Bycondition_6B.Checked then
      begin
        if  fCmdRet<>0 then
       AddCmdLog('Inventory', 'Query tag', fCmdRet);
      end
      else if fCmdRet = $FB then //说明还未将所有卡读取完
      begin

          StatusBar1.Panels.Items[0].text := FormatDateTime('hh:mm:ss', Now) + ' "Query Tag"Command Response=0xFB' +
               '(No Tag Operable)'
      end
      else if fCmdRet = $00 then
         StatusBar1.Panels.Items[0].text := FormatDateTime('hh:mm:ss', Now) +  ' "Query Tag"Command Response=0x00' +
               '(Find a Tag)'
      else
        AddCmdLog('Inventory', 'Query Tag', fCmdRet);
      if fCmdRet=RecmdErr then
       StatusBar1.Panels.Items[0].text := FormatDateTime('hh:mm:ss', Now) +  ' "Query Tag"Command Response=0xee' +
                    '(Response Command Error)' ;
    end;
  finally
     fIsInventoryScan_6B := False;
  end;
  if fAppClosed then Close;
end;

procedure TfrmUHFReader288main.Action_LockByte_6BExecute(Sender: TObject);
var
   return,Address:Byte;
begin
   getCharStr(ComboBox_ID1_6B.text,fOperID_6B);
   Address:=StrToInt('$'+Edit_StartAddress_6B.Text);
   return:=MessageDlg('permanently Lock the address Confirmed？', mtInformation, [mbOK, mbCancel], 0);
   if return = IDCancel then
   Exit;
   fCmdRet:=Lock_6B(fComAdr,@fOperID_6B,Address,ferrorcode,frmComPortindex);
   AddCmdLog('Lock', 'Lock', fCmdRet);
end;

procedure TfrmUHFReader288main.Action_CheckLock_6BExecute(Sender: TObject);
var
Address,ReLockState:Byte;
begin
   getCharStr(ComboBox_ID1_6B.text,fOperID_6B);
   Address:=StrToInt('$'+Edit_StartAddress_6B.Text);
   fCmdRet:=CheckLock_6B(fComAdr,@fOperID_6B,Address,ReLockState,ferrorcode,frmComPortindex);
   AddCmdLog('CheckLock_6B', 'Check Lock', fCmdRet);
   if fCmdRet=0 then
   begin
     if  ReLockState=$00  then
     StatusBar1.Panels.Items[0].text := FormatDateTime('hh:mm:ss', Now) +  ' "Check Lock"Command Response=0x00' +
               '(The Byte is unlocked)' ;
     if  ReLockState=$01  then
     StatusBar1.Panels.Items[0].text := FormatDateTime('hh:mm:ss', Now) +  ' "Check Lock"Command Response=0x01' +
               '(The Byte is locked)';
   end;
end;

procedure TfrmUHFReader288main.Action_CheckLock_6BUpdate(Sender: TObject);
var
  CanEnabled_6B:Boolean;
  CanEnabled2_6B:Boolean;
begin
   SpeedButton_Query_6B.Enabled:=ComIsOpen and not (SpeedButton_Read_6B.down)
                                   and not (SpeedButton_Write_6B.down);
    ComboBox_IntervalTime_6B.Enabled:=not (SpeedButton_Query_6B.down) and  ComIsOpen
                   and not (SpeedButton_Read_6B.down)and not (SpeedButton_Write_6B.down);
    CanEnabled_6B:=not (SpeedButton_Query_6B.down) and  ComIsOpen and (ComboBox_ID1_6B.Text<>'')
                   and not (SpeedButton_Read_6B.down)and not (SpeedButton_Write_6B.down);
    CanEnabled2_6B:=not (SpeedButton_Query_6B.down) and  ComIsOpen and (Bycondition_6B.Checked)
                   and not (SpeedButton_Read_6B.down)and not (SpeedButton_Write_6B.down);

    if  Byone_6B.Checked then
     SpeedButton_Query_6B.Caption:='Query by one'
    else
    begin
     SpeedButton_Query_6B.Caption:='Query by Condition';
    end;
     GroupBox14.Enabled:=CanEnabled2_6B;
    Label34.Enabled:=CanEnabled2_6B;
    Label28.Enabled:=CanEnabled2_6B;
//    Label32.Enabled:=CanEnabled2_6B;
//    Edit_mask_6B.Enabled:=CanEnabled2_6B;
    Edit_Query_StartAddress_6B.Enabled:=CanEnabled2_6B;
    Edit_ConditionContent_6B.Enabled:=CanEnabled2_6B;
    Less_6B.Enabled:=CanEnabled2_6B;
    Different_6B.Enabled:=CanEnabled2_6B;
    Same_6B.Enabled:=CanEnabled2_6B;
    Greater_6B.Enabled:=CanEnabled2_6B;

    GroupBox13.Enabled:=not (SpeedButton_Query_6B.down) and  ComIsOpen
                        and (ComboBox_ID1_6B.Text<>'');
    Memo_DataShow_6B.Enabled:=GroupBox13.Enabled;
    Button12.Enabled:=GroupBox13.Enabled;
    SpeedButton_Read_6B.Enabled:=GroupBox13.Enabled and not (SpeedButton_Write_6B.down);
    SpeedButton_Write_6B.Enabled:=GroupBox13.Enabled and not (SpeedButton_Read_6B.down);

    Label29.Enabled:=CanEnabled_6B;
    Label30.Enabled:=CanEnabled_6B;
    Label31.Enabled:=CanEnabled_6B;
    ComboBox_ID1_6B.Enabled:=CanEnabled_6B;
    Edit_WriteData_6B.Enabled:=CanEnabled_6B;
    Edit_StartAddress_6B.Enabled:=CanEnabled_6B;
    Edit_Len_6B.Enabled:=CanEnabled_6B;
    Button11.Enabled:=CanEnabled_6B;
    Button10.Enabled:=CanEnabled_6B;

//    Button14.Enabled:=CanEnabled_6B;
//    Button15.Enabled:=CanEnabled_6B;
end;

procedure TfrmUHFReader288main.Timer_Test_6BTimer(Sender: TObject);
begin
    if fisinventoryscan_6B then    Exit;
    Action_Inventroy_6BExecute(sender);
end;

procedure TfrmUHFReader288main.SpeedButton_Read_6BClick(Sender: TObject);
begin
  if SpeedButton_Write_6B.Down  then
  begin
  if ( Edit_WriteData_6B.Text='' )or (Length(Edit_WriteData_6B.Text)mod 2<>0) then
  begin
    MessageDlg('Please input in bytes in hexadecimal form!'+#13+#10+'for example: 12、1234', mtInformation, [mbOK], 0);
    SpeedButton_Write_6B.Down:=False;
    Exit;
  end;
  end;
  if SpeedButton_Read_6B.Down or SpeedButton_Write_6B.Down  then
  begin
  if ( Edit_StartAddress_6B.Text='' )or (Edit_Len_6B.Text='') then
  begin
  MessageDlg('Start address or length is empty!Please input!', mtInformation, [mbOK], 0);
    SpeedButton_Read_6B.Down:=False;
  SpeedButton_Write_6B.Down:=False;
  Exit;
  end;
  Timer_6B_ReadWrite.Enabled:=True;
  end
  else
  begin
  if Sender= SpeedButton_Read_6B  then
   StatusBar1.Panels.Items[0].text := FormatDateTime('hh:mm:ss', Now) +  ' "Read"over' ;
  if Sender= SpeedButton_Write_6B  then
    StatusBar1.Panels.Items[0].text := FormatDateTime('hh:mm:ss', Now) +  ' "Write"over' ;
  Timer_6B_ReadWrite.Enabled:=False;
  end;
end;

procedure TfrmUHFReader288main.Timer_6B_ReadWriteTimer(Sender: TObject);
var
    i: Integer;
    s2: string;
    CardData: array[0..320] of Char;
    Mem,Num,StartAddress:Byte;
    Writedata:array[0..320] of Char;
    Writedatalen:byte;
    writtenbyte:longint;
begin
  if  fTimer_6B_ReadWrite then    exit;
  fTimer_6B_ReadWrite:=true;
  try
    if SpeedButton_Read_6B.Down  then
    begin
      getCharStr(ComboBox_ID1_6B.text,fOperID_6B);
      StartAddress:=StrToInt('$'+Edit_StartAddress_6B.Text);
      Num:=StrToInt(Edit_Len_6B.Text);
      fCmdRet:=ReadData_6B(fComAdr,@fOperID_6B,StartAddress,Num,CardData,ferrorcode,frmComPortindex);
      if fCmdRet=0 then
      begin
        for i := 0 to Num - 1 do
        s2 := s2 + IntToHex(ord(CardData[i]), 2);
        Memo_DataShow_6B.Lines.Add(s2);
      end;
      AddCmdLog('ReadData', 'Read', fCmdRet);
      if not (SpeedButton_Read_6B.Down)  then
      StatusBar1.Panels.Items[0].text := FormatDateTime('hh:mm:ss', Now) +  ' "Read"over' ;
    end;
    
    if SpeedButton_Write_6B.Down  then
    begin
      getCharStr(ComboBox_ID1_6B.text,fOperID_6B);
      StartAddress:=StrToInt('$'+Edit_StartAddress_6B.Text);
      getCharStr(Edit_WriteData_6B.text,Writedata);
      Writedatalen:= Length(Edit_WriteData_6B.text)div 2 ;
      fCmdRet:=WriteData_6B(fComAdr,@fOperID_6B,StartAddress,Writedata,Writedatalen,writtenbyte,ferrorcode,frmComPortindex);
      AddCmdLog('WriteData_6B', 'Write', fCmdRet);
      if not (SpeedButton_Write_6B.Down)  then
      StatusBar1.Panels.Items[0].text := FormatDateTime('hh:mm:ss', Now) +  '  "Write"over' ;
    end;
  finally
  fTimer_6B_ReadWrite:=false;
  end;
  if fAppClosed then Close;
end;

procedure TfrmUHFReader288main.Button12Click(Sender: TObject);
begin
Memo_DataShow_6B.Lines.Clear;
end;

procedure TfrmUHFReader288main.ComboBox_IntervalTime_6BChange(Sender: TObject);
begin
Timer_Test_6B.Interval :=(ComboBox_IntervalTime_6B.ItemIndex+4)*10;
end;

procedure TfrmUHFReader288main.Button_AccuracyClick(Sender: TObject);
var
  Accuracy:Byte;
begin
  Accuracy:=ComboBox_Accuracy.ItemIndex;
  if(RadioButton1.Checked)then
  Accuracy:=Accuracy or $80 ;
  fCmdRet:=SetEASSensitivity(fcomadr,Accuracy,frmcomportindex);
  AddCmdLog('SetEASSensitivity', 'Set', fCmdRet);
end;

procedure TfrmUHFReader288main.Button13Click(Sender: TObject);
var
  MaskMem:Byte;
  MaskAdr:array[0..2]of Char;
  MaskLen:Byte;
  MaskData:array[0..80]of Char;
begin
  FillChar( MaskData,80,0);
  if(Length(Edit7.Text)<>4)or(Length(Edit9.Text)<>2)or(Length(Edit10.Text)mod 2 <>0)then
  begin
  MessageBox(0, 'Please input right data！', 'Information', MB_ICONWARNING or MB_OK);
  Exit;
  end;
  if(RadioButton3.Checked)then MaskMem:=1;
  if(RadioButton4.Checked)then MaskMem:=2;
  if(RadioButton5.Checked)then MaskMem:=3;
  getCharStr(Edit7.Text,MaskAdr);
  MaskLen:=StrToInt('$'+trim(edit9.Text));
  getCharStr(Edit10.Text,MaskData);
  fCmdRet:=SetMask(fcomAdr,MaskMem,MaskAdr,MaskLen,MaskData,frmcomportindex);
  AddCmdLog('SetMask', 'Set', fCmdRet);
end;

procedure TfrmUHFReader288main.Button14Click(Sender: TObject);
var
   RepCondition:Byte;
   RepPauseTime:Byte;
begin
   RepCondition:=ComboBox1.ItemIndex;
   RepPauseTime:=ComboBox2.ItemIndex;
   fCmdRet:=SetResponsePamametersofAuto_runningMode(fComAdr,RepCondition,RepPauseTime,frmComPortindex);
   AddCmdLog('SetResponsePamametersofAuto_runningMode', 'Set', fCmdRet);
end;

procedure TfrmUHFReader288main.Button18Click(Sender: TObject);
var
  LenTID,AdrTID:byte;
begin
  if(Length(Edit5.Text)<>2)or(Length(Edit8.Text)<>2)then
  begin
  MessageDlg('TID Parameter Error', mtWarning, [mbOK], 0);
  exit;
  end;
  AdrTID:=StrToInt('$'+Trim(Edit5.Text));
  LenTID:=StrToInt('$'+Trim(Edit8.Text));
  fCmdRet:=SetTIDParameter(fComAdr,AdrTID,LenTID,frmComPortindex);
  AddCmdLog('SetTIDParameter', 'Set', fCmdRet);
end;

procedure TfrmUHFReader288main.Button19Click(Sender: TObject);
var
  ReadPauseTim:Byte;
begin
  ReadPauseTim:=ComboBox3.ItemIndex;
  fCmdRet:=SetInventoryInterval(fComAdr,ReadPauseTim,frmComPortindex);
  AddCmdLog('SetInventoryInterval', 'Set', fCmdRet);
end;

procedure TfrmUHFReader288main.Button20Click(Sender: TObject);
var
   Read_mode:Byte;
begin
  Read_mode:=ComboBox4.ItemIndex;
  fCmdRet:=SetWorkMode(fComAdr,Read_mode,frmComPortindex);
  AddCmdLog('SetWorkMode', 'Set', fCmdRet);
end;

procedure TfrmUHFReader288main.Button22Click(Sender: TObject);
var
  Read_mode,Accuracy,RepCondition,RepPauseTime,ReadPauseTim,TagProtocol,MaskMem,TriggerTime,AdrTID,LenTID:Byte;
  MaskAdr:array[0..2]of Char;
  MaskData:array[0..40]of char;
  MaskLen:Byte;
  i,m_byte:Integer;
  temp:string;
begin
  temp:='';
  Edit7.Text:='';
  Edit9.Text:='';
  Edit10.Text:='';
  Edit5.Text:='';
  Edit8.Text:='';
  fCmdRet:=GetSystemParameter(fComAdr,Read_mode,Accuracy,RepCondition,RepPauseTime,ReadPauseTim,TagProtocol,MaskMem,MaskAdr,MaskLen,MaskData,TriggerTime,AdrTID,LenTID,frmComPortindex);
  if(fCmdRet=0)then
  begin
    ComboBox4.ItemIndex:=Read_mode;
    if(Accuracy and $80)=$80then
    RadioButton1.Checked:=True
    else
    RadioButton2.Checked:=True;
    ComboBox_Accuracy.ItemIndex:= (Accuracy and $3F);
    ComboBox1.ItemIndex:= RepCondition;
    ComboBox2.ItemIndex:=RepPauseTime;
    if(ComboBox1.ItemIndex=1)then
    ComboBox2.Enabled:=True
    else
    ComboBox2.Enabled:=False;
    ComboBox3.ItemIndex:=ReadPauseTim;
    case TagProtocol of
      0:
      begin
         RadioButton6.Checked:=True;
         RadioButton8.Checked:=True;
      end;
      1:
      begin
         RadioButton6.Checked:=True;
      end;
      2:
      begin
         RadioButton6.Checked:=True;
         RadioButton10.Checked:=True;
      end;
      $10:
      begin
         RadioButton6.Checked:=True;
         RadioButton11.Checked:=True;
      end;
      $11:
      begin
         RadioButton6.Checked:=True;
      end;
      $80:
      begin
         RadioButton7.Checked:=True;
      end;
    end;
    case MaskMem of
    1: RadioButton3.Checked:=True;
    2: RadioButton4.Checked:=True;
    3: RadioButton5.Checked:=True;
    end;
     for i := 0 to 1 do
        temp := temp + IntToHex(ord(MaskAdr[i]), 2);
     Edit7.Text:=temp;
     Edit9.Text:=IntToHex(MaskLen,2);
     temp:='';
     if(MaskLen mod 8)=0 then
     m_byte:=MaskLen div 8
     else
     m_byte:=MaskLen div 8 +1;

    for i := 0 to m_byte-1 do
        temp := temp + IntToHex(ord(MaskData[i]), 2);
    Edit10.Text:=temp;
    Edit5.Text:=IntToHex(AdrTID,2);
    Edit8.Text:=IntToHex(LenTID,2);
    ComboBox7.ItemIndex:= TriggerTime;
  end;
  AddCmdLog('GetSystemParameter', 'GetSystemParameter', fCmdRet);
end;

procedure TfrmUHFReader288main.SpeedButton1Click(Sender: TObject);
begin
 if not (SpeedButton1.Down) then
  begin
   Timer1.Enabled:=False;
   SpeedButton1.Caption:='Get';
  end
 else
 begin
  Memo1.Lines.Clear;
  Timer1.Enabled:=True;
  SpeedButton1.Caption:='Stop';
 end;
end;

procedure TfrmUHFReader288main.Timer1Timer(Sender: TObject);
var
  ScanModeData:array[0..40960]of Char;
  ValidDatalength:LongInt;
  temp,temp1:string;
  temps:string;
  i:Integer;
begin
  if(ISscanstring)then
  Exit;
  ISscanstring:=True;
  fCmdRet:=ReadActiveModeData(ScanModeData, ValidDatalength,frmComPortindex);
  if(fCmdRet=0)then
  begin
    temp:=getStr(ScanModeData,ValidDatalength);
    temps:=getHexStr(temp);
    temp1:='';
    for i:=0 to  ValidDatalength-1 do
    temp1:=temp1+copy(temps,i*2+1,2)+' ';
    if(Trim(temp1)<>'')then
    Memo1.Lines.Add(temp1);
  end;
  ISscanstring:=False;
  if fAppClosed then Close;
end;

procedure TfrmUHFReader288main.Button37Click(Sender: TObject);
begin
Memo1.Lines.Clear;
Memo2.Lines.Clear;
end;

procedure TfrmUHFReader288main.Button36Click(Sender: TObject);
var
   Data:array[0..50000]of Char;
   dataLength:LongInt;
   nLen,i,NumLen,NumLen1:LongInt;
   temp,temp1,temp2:string;
   aListItem: TListItem;
   syear,smonth,sday,shour,smin,ssec:string;
   Lyear,Lmonth,Lday,Lhour,Lmin,Lsec:string;
   binarystr1,binarystr2,hexstr:string;
   CountStr,AntStr:string;
   EPCStr:string;
begin
   ListView1.Items.Clear;
  fCmdRet:=GetTagBufferInfo(fComAdr,Data,dataLength,frmComPortindex);
  if(fCmdRet=0)then
  begin
    nLen:= dataLength*2;
    for i:=0 to dataLength-1 do
    begin
      temp:=temp+IntToHex(ord(Data[i]), 2);
    end;
    while(nLen>0)do
    begin
      NumLen:=24+StrToInt('$'+Copy(temp,23,2))*2;
      temp1:=Copy(temp,1,NumLen);
      binarystr1:=Str_IntToBin(StrToInt64('$'+Copy(temp1,1,8)),32);
      syear:= getNoStr(StrToInt('$'+BitStrToHextStr(Copy(binarystr1,1,6))),2);
      smonth:=getNoStr(StrToInt('$'+BitStrToHextStr(Copy(binarystr1,7,4))),2);
      sday:=getNoStr(StrToInt('$'+BitStrToHextStr(Copy(binarystr1,11,5))),2);
      shour:=getNoStr(StrToInt('$'+BitStrToHextStr(Copy(binarystr1,16,5))),2);
      smin:=getNoStr(StrToInt('$'+BitStrToHextStr(Copy(binarystr1,21,6))),2);
      ssec:=getNoStr(StrToInt('$'+BitStrToHextStr(Copy(binarystr1,27,6))),2);
      binarystr2:=Str_IntToBin(StrToInt('$'+Copy(temp1,9,8)),32);
      Lyear:= getNoStr(StrToInt('$'+BitStrToHextStr(Copy(binarystr2,1,6))),2);
      Lmonth:=getNoStr(StrToInt('$'+BitStrToHextStr(Copy(binarystr2,7,4))),2);
      Lday:=getNoStr(StrToInt('$'+BitStrToHextStr(Copy(binarystr2,11,5))),2);
      Lhour:=getNoStr(StrToInt('$'+BitStrToHextStr(Copy(binarystr2,16,5))),2);
      Lmin:=getNoStr(StrToInt('$'+BitStrToHextStr(Copy(binarystr2,21,6))),2);
      Lsec:=getNoStr(StrToInt('$'+BitStrToHextStr(Copy(binarystr2,27,6))),2);

      CountStr:=IntToStr(StrToInt('$'+copy(temp1,17,4)));

      AntStr:=Str_IntToBin(StrToInt('$'+copy(temp1,21,2)),4);
      EPCStr:=Copy(temp1,25,Length(temp1)-24);
      aListItem := ListView1.Items.Add;
      aListItem.Caption := IntToStr(aListItem.Index + 1);
      aListItem.SubItems.Add('');
      aListItem.SubItems.Add('');
      aListItem.SubItems.Add('');
      aListItem.SubItems.Add('');
      aListItem.SubItems.Add('');
      aListItem := ListView1.Items[ListView1.Items.Count - 1];

      aListItem.SubItems[0]:= EPCStr ;
      aListItem.SubItems[1]:= '20'+syear+'-'
                              + smonth+'-'
                              + sday+' '
                              + shour+':'
                              + smin+':'
                              + ssec;
      aListItem.SubItems[2]:= '20'+Lyear+'-'
                              + Lmonth+'-'
                              + Lday+' '
                              + Lhour+':'
                              + Lmin+':'
                              + Lsec;
      aListItem.SubItems[3]:=AntStr;
      aListItem.SubItems[4]:=CountStr;
      if(Length(temp)-NumLen>0)then
      temp:=Copy(temp,NumLen+1,Length(temp)-NumLen);
      nLen:=nLen-NumLen;
      ListView1.Items[ListView1.Items.Count-1].MakeVisible(True) ;
    end;
  end;
 // Sleep(100);
 // EnableFlag:=false;;
  AddCmdLog('GetTagBufferInfo', 'GetSystemParameter', fCmdRet);
end;

procedure TfrmUHFReader288main.Action_TagProtocolExecute(Sender: TObject);
var
   Protocol:Byte;
begin
   if(RadioButton6.Checked)then
   begin
     if(RadioButton8.Checked)then Protocol:=0;
     if(RadioButton10.Checked)then Protocol:=2;
     if(RadioButton11.Checked)then Protocol:=$10;
   end
   else
    Protocol:=$80; //
   fCmdRet:=SelectTagType(fComAdr,Protocol,frmComPortindex);
   AddCmdLog('SelectTagType', 'Set', fCmdRet);
end;

procedure TfrmUHFReader288main.Action_TagProtocolUpdate(Sender: TObject);
begin
  if(RadioButton6.Checked)then
  begin
    RadioButton8.Enabled:=True;
    RadioButton10.Enabled:=True;
    RadioButton11.Enabled:=True;
  end
  else
  begin
    RadioButton8.Enabled:=False ;
    RadioButton10.Enabled:=False;
    RadioButton11.Enabled:=False;
  end;
  Button_Accuracy.Enabled:=ComIsOpen and (not SpeedButton1.Down);
  Button13.Enabled:=ComIsOpen and (not SpeedButton1.Down);
  Button14.Enabled:=ComIsOpen and (not SpeedButton1.Down);
  Button15.Enabled:=ComIsOpen and (not SpeedButton1.Down);
  Button18.Enabled:=ComIsOpen and (not SpeedButton1.Down);
  Button19.Enabled:=ComIsOpen and (not SpeedButton1.Down);
  Button20.Enabled:=ComIsOpen and (not SpeedButton1.Down);
  Button17.Enabled:=ComIsOpen and (not SpeedButton1.Down);
  Button38.Enabled:=ComIsOpen and (not SpeedButton1.Down);
  Button41.Enabled:=ComIsOpen and (not SpeedButton1.Down);
  Button36.Enabled:=ComIsOpen and (not SpeedButton1.Down)and (ComboBox1.ItemIndex=0);
  Button22.Enabled:=ComIsOpen and (not SpeedButton1.Down);
  SpeedButton1.Enabled:=ComIsOpen;
  Button_clearBuffer.Enabled:=ComIsOpen and (not SpeedButton1.Down) and (ComboBox1.ItemIndex=0);
end;

procedure TfrmUHFReader288main.Button17Click(Sender: TObject);
var
  Qvalue,Session:Byte;
begin
  Qvalue:=ComboBox5.ItemIndex;
  Session:=ComboBox13.ItemIndex;
  fCmdRet:=SetQS(fComAdr,Qvalue,Session,frmComPortindex);
  AddCmdLog('SetQS', 'Set', fCmdRet);
end;

procedure TfrmUHFReader288main.Button38Click(Sender: TObject);
var
  Qvalue,Session:Byte;
begin
   fCmdRet:=GetQS(fComAdr,Qvalue,Session,frmComPortindex);
   if(fCmdRet=0)then
   begin
     ComboBox5.ItemIndex:= Qvalue;
     ComboBox13.ItemIndex:= Session;
   end;
   AddCmdLog('GetQS', 'Get', fCmdRet);
end;

procedure TfrmUHFReader288main.Button39Click(Sender: TObject);
var
  Version:array[0..2]of Char;
  temp:string;
begin
  Edit19.Text:='';
  fCmdRet:=GetModuleVersion(fComAdr,Version,frmComPortindex);
  if(fCmdRet=0)then
  begin
       Edit19.Text:= getnostr(Ord(Version[0]),2)+'.'+getnostr(Ord(Version[1]),2);
  end;
  AddCmdLog('GetModuleVersion', 'Get', fCmdRet);
end;

procedure TfrmUHFReader288main.Button7Click(Sender: TObject);
var
return:Integer;
begin
 return:=MessageDlg('After change to flash mode,if you want to recovery, need to reset power,are you sure want to do this?', mtInformation, [mbOK, mbCancel], 0);
  if return = IDok then
  begin

   fCmdRet:=SetFlashRom(fComAdr,frmComPortindex);
   AddCmdLog('SetFlashRom', 'Change', fCmdRet,ferrorcode);
  end;
end;

procedure TfrmUHFReader288main.Button41Click(Sender: TObject);
var
  TriggerTime:Byte;
begin
  TriggerTime:=ComboBox7.ItemIndex;
  fCmdRet:=SetTriggerTime(fComAdr,TriggerTime,frmComPortindex);
  AddCmdLog('SetTriggerTime', 'Set', fCmdRet);
end;

procedure TfrmUHFReader288main.Button44Click(Sender: TObject);
var
    Mem,Num:Byte;
    WordPtr:array[0..2]of Char;
    Writedata:array[0..320] of Char;
    WNum:Byte;
    ENum:Byte;
    EPClength:byte;
    i: Integer;
    s,s2: string;
    CardData: array[0..320] of Char;
    WrittenDataNum:LongInt;
    MaskMem:Byte;
    MaskAdr:array[0..2]of Char;
    MaskLen:Byte;
    MaskData:array[0..80]of Char;
begin
    FillChar( MaskData,80,0);
    if(R_EPC.Checked)then MaskMem:=1;
    if(R_TID.Checked)then MaskMem:=2;
    if(R_User.Checked)then MaskMem:=3 ;
    if(CheckBox1.Checked)then
    begin
      ENum:=255;
      if(Edit2.Text='')then Exit;
      if(Edit3.Text='')then Exit;
      if(Edit1.Text='')or(Length(Edit1.Text)mod 2<>0)then Exit;
      getCharStr(Edit2.Text,MaskAdr);
      MaskLen:=StrToInt('$'+trim(edit3.Text));
      getCharStr(Edit1.Text,MaskData);
    end
    else
     ENum:=Length(ComboBox_EPC2.text) div 4;
    if Length(Edit_AccessCode2.Text)<8 then
    begin
      MessageDlg('Access Password Less Than 8 digit!Please input again!', mtInformation, [mbOK], 0);
      Exit;
    end;
    if (Edit_WordPtr.Text='')or(Edit_Len.Text='')then
    begin
      MessageDlg('Start address or length is empty!Please input!', mtInformation, [mbOK], 0);
      Exit;
    end;
    getCharStr(ComboBox_EPC2.text,fOperEPC);
    getCharStr(Edit_AccessCode2.text,fPassword);
    getCharStr(Edit_WordPtr.Text,WordPtr);
    Num:=StrToInt(Edit_Len.Text);
    if  C_Reserve.Checked then
      Mem:=0
    else if  C_EPC.Checked then
      Mem:=1
    else if  C_TID.Checked then
      Mem:=2
    else if  C_User.Checked then
      Mem:=3;
    if (Edit_WriteData.Text='' )or (Length(Edit_WriteData.Text)mod 4<>0) then
    begin
    MessageDlg('Please input Data in words in hexadecimal form!'+#13+#10+'For example: 1234、12345678', mtInformation, [mbOK], 0);
      Exit;   //
    end;
    WNum:= Length(Edit_WriteData.text)div 4 ;
    getCharStr(Edit_WriteData.text,Writedata);
    if(CheckBox18.Checked)and(C_EPC.Checked)then
    begin
     getCharStr('0001',WordPtr);
     WNum:= Length(Edit_WriteData.text)div 4 +1;
     getCharStr(edit_pc.Text+Edit_WriteData.text,Writedata);
    end;
    fCmdRet:=ExtWriteData_G2(fComAdr,@fOperEPC,WNum,ENum,Mem,WordPtr,@Writedata,@fPassword,MaskMem,@MaskAdr,MaskLen,@MaskData,ferrorcode,frmComPortindex);
    AddCmdLog('WriteData','Ext Write', fCmdRet,ferrorcode);
    if fCmdRet=0 then
    begin
    StatusBar1.Panels.Items[0].text := FormatDateTime('hh:mm:ss', Now) +  ' "Write"Command Response=0x00' +
                  '(completely write Data successfully)';
    end;


end;

procedure TfrmUHFReader288main.Button43Click(Sender: TObject);
var
    Mem,Num:Byte;
    WordPtr:array[0..2]of Char;
    ENum:byte;
    i: Integer;
    s2: string;
    CardData: array[0..320] of Char;
     MaskMem:Byte;
    MaskAdr:array[0..2]of Char;
    MaskLen:Byte;
    MaskData:array[0..80]of Char;
begin
  FillChar( MaskData,80,0);
  try
      if(R_EPC.Checked)then MaskMem:=1;
      if(R_TID.Checked)then MaskMem:=2;
      if(R_User.Checked)then MaskMem:=3;
      if(CheckBox1.Checked)then
      begin
      ENum:=255;
      if(Edit2.Text='')then Exit;
      if(Edit3.Text='')then Exit;
      if(Edit1.Text='')or(Length(Edit1.Text)mod 2<>0)then Exit;
      getCharStr(Edit2.Text,MaskAdr);
      MaskLen:=StrToInt('$'+trim(edit3.Text));
      getCharStr(Edit1.Text,MaskData);
      END
      else
       ENum:=Length(ComboBox_EPC2.text) div 4;

      getCharStr(ComboBox_EPC2.text,fOperEPC);
      getCharStr(Edit_AccessCode2.text,fPassword);
      getCharStr(Edit_WordPtr.text,WordPtr);

      Num:=StrToInt(Edit_Len.Text);
      if  C_Reserve.Checked then
        Mem:=0
      else if  C_EPC.Checked then
        Mem:=1
      else if  C_TID.Checked then
        Mem:=2
      else if  C_User.Checked then
        Mem:=3;
      fCmdRet:=ExtReadData_G2(fComAdr,@fOperEPC,ENum,Mem,WordPtr,Num,@fPassword,MaskMem,@MaskAdr,MaskLen,MaskData,@CardData,ferrorcode,frmComPortindex);
      if fCmdRet=0 then
      begin
        for i := 0 to Num*2 - 1 do
        s2 := s2 + IntToHex(ord(CardData[i]), 2);
        Memo_DataShow.Lines.Add(s2);
      end;
      if  fErrorCode<>-1 then
      begin
      StatusBar1.Panels.Items[0].text := FormatDateTime('hh:mm:ss', Now) +
       ' "Read" Response ErrorCode=0x'+ IntToHex(fErrorCode, 2) +
       '(' + UHFReader288_GetErrorCodeDesc(fErrorCode) + ')';
        ferrorcode:=-1;
      end
      else      
      AddCmdLog('ReadData','Ext Read', fCmdRet);
  finally
  end;
end;

procedure TfrmUHFReader288main.SpeedButton2Click(Sender: TObject);
begin
 if not (SpeedButton2.Down) then
  begin
   Timer2.Enabled:=False;
   SpeedButton2.Caption:='Get';
  end
 else
 begin
  Memo2.Lines.Clear;
  Timer2.Enabled:=True;
  SpeedButton2.Caption:='Stop';
 end;
end;

procedure TfrmUHFReader288main.Timer2Timer(Sender: TObject);
var
  ScanModeData:array[0..40960]of Char;
  ValidDatalength:LongInt;
  temp,temp1:string;
  temps:string;
  i:Integer;
begin
  if(ISscanstring)then
  Exit;
  ISscanstring:=True;
  fCmdRet:=ReadActiveModeData(ScanModeData, ValidDatalength,frmComPortindex);
  if(fCmdRet=0)then
  begin
    temp:=getStr(ScanModeData,ValidDatalength);
    temps:=getHexStr(temp);
    temp1:='';
    for i:=0 to  ValidDatalength-1 do
    temp1:=temp1+copy(temps,i*2+1,2)+' ';
    if(Trim(temp1)<>'')then
    Memo2.Lines.Add(temp1);
  end;
  ISscanstring:=False;
  if fAppClosed then Close;
end;

procedure TfrmUHFReader288main.bt_SetParameterClick(Sender: TObject);
var
Parameter:array[0..10]of Char;
MaskMem:Byte;
MaskAdr:array[0..2]of Char;
MaskLen:Byte;
MaskData:array[0..100]of Char;
MaskFlag,AdrTID,LenTID,TIDFlag:Byte;
begin
  if(rbm_G2.Checked)then
  Parameter[0]:=Char(0)
  else
  Parameter[0]:=Char(1);
  Parameter[1]:=Char(COM_MRPTime.ItemIndex);
  Parameter[2]:=Char(com_MFliterTime.ItemIndex);
  Parameter[3]:=Char(com_MQ.ItemIndex);
  if (com_MS.ItemIndex<4)then
  Parameter[4]:=char(com_MS.ItemIndex)
  else
  Parameter[4]:=Char(255);
  MaskFlag:=0;
  if(CheckBox_Mask.Checked)then
  begin
    MaskFlag:=1;
    if(Length(txt_maddr.Text)<>4)or(Length(txt_mlen.Text)<>2)or(Length(txt_mdata.Text)mod 2 <>0)then
    begin
    MessageBox(0, 'Input right data！', 'information', MB_ICONWARNING or MB_OK);
    Exit;
    end;

    if(rbm_epc.Checked)then MaskMem:=1;
    if(rbm_tid.Checked)then MaskMem:=2;
    if(rbm_user.Checked)then MaskMem:=3;
    getCharStr(txt_maddr.Text,MaskAdr);
    MaskLen:=StrToInt('$'+trim(txt_mlen.Text));
    getCharStr(txt_mdata.Text,MaskData);
  end;
  TIDFlag:=0;
  if(Check_TID.Checked)then
  begin
    TIDFlag:=1;
    AdrTID:=StrToInt('$'+trim(txt_tidadr.Text));
    LenTID:=StrToInt('$'+trim(txt_tidlen.Text));
  end;
  fCmdRet:= SetReadParameter(fComAdr,Parameter,MaskMem,MaskAdr,MaskLen,MaskData,MaskFlag,AdrTID,LenTID,TIDFlag,frmComPortindex);
  AddCmdLog('SetReadParameter','Set parameter', fCmdRet);
end;

procedure TfrmUHFReader288main.bt_GetParameterClick(Sender: TObject);
var
  Parameter:array[0..50]of Char;
  MaskMem:Byte;
  MaskAdr:array[0..2]of Char;
  MaskLen:Byte;
  MaskData:array[0..100]of Char;
  MaskFlag,AdrTID,LenTID,TIDFlag:Byte;
  temp:string;
  i,len:Integer;
begin
  fCmdRet:=GetReadParameter(fComAdr,Parameter,frmComPortindex);
  if(fCmdRet=0)then
  begin
     com_mwork.ItemIndex:= Ord(Parameter[0]);
     if(Ord(Parameter[1])=0)then
     rbm_G2.Checked:=True
     else
     rbm_6B.Checked:=True;
     COM_MRPTime.ItemIndex:=  Ord(Parameter[2]);
     com_MFliterTime.ItemIndex:=  Ord(Parameter[3]);
     com_MQ.ItemIndex:=  Ord(Parameter[4]);
     if(Ord(Parameter[5])=255)then
     com_MS.ItemIndex:=4
     else
     com_MS.ItemIndex:=Ord(Parameter[5]);
     if(Ord(Parameter[6])=1)then
     rbm_epc.Checked:=True
     else if (Ord(Parameter[6])=2)then
     rbm_tid.Checked:=True
     else if (Ord(Parameter[6])=3)then
     rbm_user.Checked:=True;
     temp:='';
     for i := 0 to 1 do
        temp := temp + IntToHex(ord(Parameter[7+i]), 2);
     txt_maddr.Text:=temp;
     txt_mlen.Text:= IntToHex(ord(Parameter[9]), 2);
     len:= ord(Parameter[9]);
     if(len mod 8)=0 then
     len:=len div 8
     else
     len:=len div 8 +1;
     temp:='';
     for i := 0 to len-1 do
        temp := temp + IntToHex(ord(Parameter[10+i]), 2);
     txt_mdata.Text:=temp;
     txt_tidadr.Text:= IntToHex(ord(Parameter[42]), 2);
     txt_tidlen.Text:= IntToHex(ord(Parameter[43]), 2);
  end;
  AddCmdLog('SetReadParameter','Get parameter', fCmdRet);
end;

procedure TfrmUHFReader288main.Action_RealExecute(Sender: TObject);
var
  ReadMode:Byte;
begin
  if(Edit_Type.Text='UHFReader288M')then
  begin
    ReadMode:= com_mwork.ItemIndex;
    fCmdRet:=SetReadMode(fComAdr,ReadMode,frmComPortindex);
  end
  else
  begin
    if(com_mwork.ItemIndex=0)then
    begin
       ReadMode:=0
    end
    else
    begin
      ReadMode:=6;
    end;
    fCmdRet:=SetWorkMode(fComAdr,ReadMode,frmComPortindex);
  end;

   AddCmdLog('SetReadMode','Mode set', fCmdRet);
end;

procedure TfrmUHFReader288main.Action_RealUpdate(Sender: TObject);
begin
   bt_setwork.Enabled:=ComIsOpen and (not SpeedButton2.Down);
   bt_SetParameter.Enabled:= ComIsOpen and (not SpeedButton2.Down);
   bt_GetParameter.Enabled:= ComIsOpen and (not SpeedButton2.Down);
   SpeedButton2.Enabled:=ComIsOpen;
end;

procedure TfrmUHFReader288main.btStartBufferClick(Sender: TObject);
begin
  Timer_Buff.Enabled:= not Timer_Buff.Enabled;
  if(Timer_Buff.Enabled)then
  begin
    btStartBuffer.Caption:='Stop';
  end
  else
  begin
    btStartBuffer.Caption:='Start';
  end;
  
end;

procedure TfrmUHFReader288main.btClearClick(Sender: TObject);
begin
lb_Num.Caption:='0';
ListView3.Items.Clear;
end;

procedure TfrmUHFReader288main.Timer_BuffTimer(Sender: TObject);
var
  CardNum:Integer;
  temps: string;
  s,ss, sEPC: string;
  MaskMem:Byte;
  MaskAdr:array[0..2]of Char;
  MaskLen:Byte;
  MaskData:array[0..800]of Char;
  MaskFlag:Byte;
  Ant,AdrTID,LenTID,TIDFlag:Byte;
  QValue,Session:Byte;
  BufferCount,TagNum:LongInt;
begin
  if fIsInventoryScan then Exit;
  fIsInventoryScan:=True;
  QValue:=4;
  FastFlag:=1;
  MaskMem:=0;
  MaskFlag:=0;
  if(rb_BEPC.Checked)then //EPC询查Session自动，TID使用S1
  begin
  TIDFlag:=0 ;
  Session:=255;
  end
  else
  begin
  TIDFlag:=1;
  Session:=1;
  end;
  AdrTID:=0;
  LenTID:=6;
  Target:=0;
  Scantime:=20;

  if(Check_BANT1.Checked)then
  begin
    BufferCount:=0;
    TagNum:=0;
    InAnt:=$80;
    fCmdRet :=InventoryBuffer_G2(fComAdr,QValue,Session,MaskMem,@MaskAdr,MaskLen,@MaskData,MaskFlag,AdrTID,LenTID,TIDFlag,Target,InAnt,Scantime,FastFlag,BufferCount, TagNum,frmcomportindex);
    if(fCmdRet=0)then
    begin
       lb_Num.Caption:=IntToStr(BufferCount);
    end
    else
    begin
      lb_Num.Caption:='0';
    end;
    AddCmdLog('InventoryBuffer_G2','Buffer Inventory',fCmdRet);
  end;
  if(Check_BANT2.Checked)then
  begin
    BufferCount:=0;
    TagNum:=0;
    InAnt:=$81;
    fCmdRet :=InventoryBuffer_G2(fComAdr,QValue,Session,MaskMem,@MaskAdr,MaskLen,@MaskData,MaskFlag,AdrTID,LenTID,TIDFlag,Target,InAnt,Scantime,FastFlag,BufferCount, TagNum,frmcomportindex);
    if(fCmdRet=0)then
    begin
       lb_Num.Caption:=IntToStr(BufferCount);
    end
    else
    begin
      lb_Num.Caption:='0';
    end;
    AddCmdLog('InventoryBuffer_G2','Buffer Inventory',fCmdRet);
  end;
  if(Check_BANT3.Checked)then
  begin
    BufferCount:=0;
    TagNum:=0;
    InAnt:=$82;
    fCmdRet :=InventoryBuffer_G2(fComAdr,QValue,Session,MaskMem,@MaskAdr,MaskLen,@MaskData,MaskFlag,AdrTID,LenTID,TIDFlag,Target,InAnt,Scantime,FastFlag,BufferCount, TagNum,frmcomportindex);
    if(fCmdRet=0)then
    begin
       lb_Num.Caption:=IntToStr(BufferCount);
    end
    else
    begin
      lb_Num.Caption:='0';
    end;
    AddCmdLog('InventoryBuffer_G2','Buffer Inventory',fCmdRet);
  end;
  if(Check_BANT4.Checked)then
  begin
    BufferCount:=0;
    TagNum:=0;
    InAnt:=$83;
    fCmdRet :=InventoryBuffer_G2(fComAdr,QValue,Session,MaskMem,@MaskAdr,MaskLen,@MaskData,MaskFlag,AdrTID,LenTID,TIDFlag,Target,InAnt,Scantime,FastFlag,BufferCount, TagNum,frmcomportindex);
    if(fCmdRet=0)then
    begin
       lb_Num.Caption:=IntToStr(BufferCount);
    end
    else
    begin
      lb_Num.Caption:='0';
    end;
    AddCmdLog('InventoryBuffer_G2','Buffer Inventory',fCmdRet);
  end;

  fIsInventoryScan:=False;
end;

procedure TfrmUHFReader288main.Action_BuffExecute(Sender: TObject);
var
  pEPCList:array[0..30000]of Char;
  Totallen,CardNum,CardIndex,EPClen,m:LongInt;
  temps,sEPC,s,s2,RSSI,ANTstr,strcount:string;
  aListItem: TListItem;
begin
  Totallen:=0;
  CardNum:=0;
  lb_Num.Caption:='0';
  ListView3.Items.Clear;
  fCmdRet:=ReadBuffer_G2(fComAdr, Totallen,CardNum,pEPCList, frmcomportindex);
  AddCmdLog('ReadBuffer_G2','Read Buffer',fCmdRet);
  if(fCmdRet=1)then
  begin
    temps :=getStr(pEPCList,Totallen);
    m:=1;
    for CardIndex := 1 to CardNum do
    begin
      ANTstr:=IntToStr(ord(tempS[m]));
      EPClen:=ord(tempS[m+1]);
      sEPC := copy(tempS,m+2,EPClen) ;
      s := getHexStr(sEPC);
      RSSI:= IntToStr(ord(tempS[m+2+EPClen]));
      strcount:=IntToStr(ord(tempS[m+3+EPClen]));
      m:=m+4+ EPClen;
      aListItem := ListView3.Items.Add;
      aListItem.Caption := IntToStr(aListItem.Index + 1);
      aListItem.SubItems.Add('');
      aListItem.SubItems.Add('');
      aListItem.SubItems.Add('');
      aListItem.SubItems.Add('');
      aListItem.SubItems.Add('');
      aListItem.SubItems.Add('');
      aListItem.SubItems[0]:=s;
      aListItem.SubItems[1]:=IntToStr(EPClen);
      aListItem.SubItems[2]:=ANTstr;
      aListItem.SubItems[3]:=RSSI;
      aListItem.SubItems[4]:=strcount;

    end;
    lb_Num.Caption:= IntToStr(CardNum);
    StatusBar1.Panels[0].Text:= FormatDateTime('hh:mm:ss', Now) + '' + 'Read buffer over';
  end;
end;

procedure TfrmUHFReader288main.Action_BuffUpdate(Sender: TObject);
begin
  btStartBuffer.Enabled:=ComIsOpen;
  btGetBuffer.Enabled:=ComIsOpen;
  btClearBuffer.Enabled:=ComIsOpen;
  btGetAndClBuffer.Enabled:=ComIsOpen;
  btGetBufferNum.Enabled:=ComIsOpen; ;
end;

procedure TfrmUHFReader288main.btClearBufferClick(Sender: TObject);
begin
fCmdRet:=ClearBuffer_G2(fComAdr,frmcomportindex);
AddCmdLog('ClearBuffer_G2','Clear buffer',fCmdRet);
end;

procedure TfrmUHFReader288main.btGetAndClBufferClick(Sender: TObject);
begin
  Action_BuffExecute(Sender);
  btClearBufferClick(Sender);
end;

procedure TfrmUHFReader288main.btGetBufferNumClick(Sender: TObject);
var
  Count:LongInt;
begin
  Count:=0;
  lb_Num.Caption:='0';
  fCmdRet:=GetBufferCnt_G2(fComAdr,Count,frmcomportindex);
  if(fCmdRet=0)then
  begin
     lb_Num.Caption:= IntToStr(Count);
  end;
  AddCmdLog('GetBufferCnt_G2','Get buffer count ',fCmdRet);
end;

procedure TfrmUHFReader288main.Button42Click(Sender: TObject);
var
  CommType:Byte;
begin
  if(RB_Usb.Checked)then
  CommType:=0
  else
  CommType:=1;
  fCmdRet:=SetCommType(fComAdr,CommType,frmcomportindex) ;
  AddCmdLog('SetCommType', Button42.Caption, fCmdRet);
end;

procedure TfrmUHFReader288main.btGetSaveLenClick(Sender: TObject);
var
  SaveLen:Byte;
begin
  fCmdRet:=GetSaveLen(fComAdr,SaveLen,frmcomportindex);
  if(fCmdRet=0)then
  begin
    if(SaveLen=0)then
      rb128.Checked:=True
    else
      rb496.Checked:=True;
  end;
  AddCmdLog('GetSaveLen', 'Get', fCmdRet);
end;

procedure TfrmUHFReader288main.btSetSaveLenClick(Sender: TObject);
var
  SaveLen:Byte;
begin
  if(rb128.Checked)then
  SaveLen:=0
  else
  SaveLen:=1;
  fCmdRet:=SetSaveLen(fComAdr,SaveLen,frmcomportindex);
  AddCmdLog('SetSaveLen', 'Set', fCmdRet);
end;

end.



