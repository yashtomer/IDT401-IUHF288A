unit DevControl;

interface
uses Windows;
const
    DLL_NAME = 'dmdll.dll';

type
TagErrorCode=(
              DM_ERR_OK ,
              DM_ERR_PARA,
              DM_ERR_NOAUTH,
              DM_ERR_AUTHFAIL ,
              DM_ERR_SOCKET,
              DM_ERR_MEM ,
              DM_ERR_TIMEOUT ,
              DM_ERR_ARG,
              DM_ERR_MATCH,
              DM_ERR_MAX);

type
ParaTypes=(
    BAUDRATE  ,                    // '������
    DATABITS ,                     // '���ڴ��������λ����
    STOPBITS  ,                    // '����ֹͣλ
    PARITY   ,                     // '����У��λ��żУ��
    FLOWCONTROL  ,                 // '���ô�������
    FIFO      ,                    // '���ڽ��շ��ͻ�����ֽ���
    ENABLEPACKING  ,               // '�����Ƿ�ְ�
    IDLEGAPTIME  ,                 // 'ѡ�񴮿������ķǻʱ��
    MATCH2BYTESEQUENCE ,           // 'ʹ�������ݰ�ƥ����β�����ֽ�
    SENDFRAMEONLY ,                // '���������ݰ�ʱ�Ƿ�ֻ�����ݷ���ȥ���ǰ����ְ��ֽ�
    SENDTRAILINGBYTES,            // 'ѡ����None/One/Two���ְ�ƥ���ֽ�
    INPUTWITHACTIVECONNECT ,       // 'ѡ���ǵ�ģ����Ϊ�ͻ��������ӽ���ʱ�������ģ�鵽�����������ʹ�õ����뻺����
    OUTPUTWITHACTIVECONNECT ,      // 'ѡ���ǵ�ģ����Ϊ�ͻ��������ӽ���ʱ�������ģ�鵽�����������ʹ�õ����������
    INPUTWITHPASSIVECONNECT ,      // 'ѡ���ǵ�ģ����Ϊ����������ӽ���ʱ����������絽ģ���������ʹ�õ����뻺����
    OUTPUTWITHPASSIVECONNECT,      // 'ѡ���ǵ�ģ����Ϊ����������ӽ���ʱ����������絽ģ���������ʹ�õ����������
    INPUTATTIMEOFDISCONNECT,       // 'ѡ���ǵ��豸������֮������ӶϿ�ʱ����������뻺����
    OUTPUTATTIMEOFDISCONNECT ,     // 'ѡ���ǵ��豸������֮������ӶϿ�ʱ����������������
    IPCONFIGURATION ,             //  '�����ֶ�/�Զ���ȡIP
    AUTONEGOTIATE ,                // 'ѡ��Trueģ�齫�������Զ�Э�����ټ�ȫ˫��or��˫���Ĺ�����ʽ
    MACADDRESS ,                   // '��ģ��ָ��һ��MAC��ַͬһ�����ڵĲ�ͬģ��Ҫ�в�ͬ��MAC��ַ
    SPEED ,                        // 'ѡ������10M or 100M
    Duplex ,                       // 'ѡ�������Ĺ���ģʽȫ˫�� or ��˫��
    NETPROTOCOL ,                  // 'ѡ��ģ��������ͨѶ��ʹ�õ�����Э��
    ACCEPTINCOMING  ,              // '�����Ƿ����UDP��
    ARPCACHETIMEOUT,               // '����ARP���峬ʱʱ��
    TCPKEEPACTIVE ,                // '
    CPUPERFORMANCEMODE,            // 'CPUʵ��ģʽ�ṩ����ģʽ���û�ѡ��High or Regular
    HTTPSERVERPORT ,               // '�趨����ģ��HTTP WEB�������˿�
    MTUSIZE    ,                   // '�����MTU���ֵ
    RETRYCOUNTER ,                 // '��ģ����Ϊ�ͻ������γ�������Hostlist�������Ĵ���
    IPADDRESS  ,                   // 'IP��ַ
    FIRMWARE  ,                    // '
    UPTIME  ,                      // '
    SERIALNO  ,                    // '
    RETRYTIMEOUT  ,                // '��ģ����Ϊ�ͻ������γ�������Hostlist��������ʱ��ʱ�䵥λΪ��
    HOSTLIST1_IP ,
    HOSTLIST1_PORT   ,
    HOSTLIST2_IP,
    HOSTLIST2_PORT ,
    HOSTLIST3_IP ,
    HOSTLIST3_PORT ,
    HOSTLIST4_IP ,
    HOSTLIST4_PORT ,
    HOSTLIST5_IP,
    HOSTLIST5_PORT ,
    HOSTLIST6_IP ,
    HOSTLIST6_PORT,
    HOSTLIST7_IP ,
    HOSTLIST7_PORT ,
    HOSTLIST8_IP ,
    HOSTLIST8_PORT ,
    HOSTLIST9_IP ,
    HOSTLIST9_PORT ,
    HOSTLIST10_IP ,
    HOSTLIST10_PORT  ,
    HOSTLIST11_IP ,
    HOSTLIST11_PORT ,
    HOSTLIST12_IP  ,
    HOSTLIST12_PORT,
    FIRSTMATCHBYTE ,              // '�趨ƥ�����ݰ������ֽڸ�ʽΪ16����
    LASTMATCHBYTE ,               // '�趨ƥ�����ݰ���β�ֽڸ�ʽΪ16����
    DATAGRAMTYPE  ,                // 'ѡ�����ݰ����ͷ�ʽ
    DEVICEADDRESSTABLE1_BEGINIP ,   //'
    UDPLOCALPORT  ,                // 'UDP�鲥���ض˿ں�
    UDPREMOTEPORT  ,               // 'UDPԶ�������˿ں�
    UDPNETSEGMENT  ,               // 'UDP�鲥�ε�ַ
    DEVICEADDRESSTABLE2_BEGINIP ,
    DEVICEADDRESSTABLE2_PORT  ,
    DEVICEADDRESSTABLE2_ENDIP  ,
    DEVICEADDRESSTABLE3_BEGINIP ,
    DEVICEADDRESSTABLE3_PORT  ,
    DEVICEADDRESSTABLE3_ENDIP  ,
    DEVICEADDRESSTABLE4_BEGINIP  ,
    DEVICEADDRESSTABLE4_PORT  ,
    DEVICEADDRESSTABLE4_ENDIP ,
    UDPUNICASTLOCALPORT ,          // '�������ض˿�
    ACCEPTIONINCOMING ,            // 'ѡ��Yesģ����Ϊ�����������µ���������ѡ��Noģ����Ϊ�ͻ�������������������
    ACTIVECONNECT ,                // '���ü�����������
    STARTCHARACTER  ,             //  '�趨��ʼ�ַ���ʽΪ16����
    ONDSRDROP ,                   //  'ѡ��Yes��ģ���鵽�����������DSR�ɸߵ�ƽ��Ϊ�͵�ƽʱ��ģ�������TCP����ȫ���Ͽ�
    HARDDISCONNECT ,             //   'ģ��Ͽ�����ʱ������Э�̣� fin-ack ʽ�� ������ֱ�ӶϿ�
    CHECKEOT ,                    //  'ѡ��Yes��ģ���鵽�������������д���EOT(Ctr-D)�ַ�ʱ�Ͽ�����TCP����
    INACTIVITYTIMEOUT_M ,
    INACTIVITYTIMEOUT_S ,
    LOCALPORT  ,                  //  '�趨ģ������ͨѶ��TCP���ض˿�
    REMOTEHOST ,                  //  '�趨TCP������ģ��ͨѶ��Զ��������IP��ַ
    REMOTEPORT  ,                //  '�趨TCP������ģ��ͨѶ��Զ�������˿�
    DNSQUERYPERIOD  ,             //  'DNS��Чʱ��
    DEVICEADDRESSTABLE1_ENDIP,
    DEVICEADDRESSTABLE1_PORT ,
    CONNECTRESPONSE,              //  '����������Ӧģʽ
    TERMINALNAME ,                //  '�ն�����
    USEHOSTLIST ,                 //  '�����Ƿ�ʹ�������б�
    EMAILADDRESS ,                //  'EMAIL���͵�ַ
    EMAILUSERNAME ,               //  'EMAIL�û���
    EMAILPASSWORD ,               //  'EMAIL����
    EMAILINPUTTRIGGERMESSAGE ,    //  'EMAIL����
    EMAILADDRESS1,               //   '�����ʼ��ĵ�ַ1
    EMAILADDRESS2 ,              //   '�����ʼ��ĵ�ַ2
    EMAILADDRESS3 ,               //  '�����ʼ��ĵ�ַ3
    POP3DOMAINNAME ,
    SMTPDOMAINNAME ,               // 'SMTP����������
    POP3PORT ,
    SMTPPORT  ,                   //  'SMTP�������˿ں�
    COLDSTART ,                   //  '����������
    DCDCHANGED ,                  //  '��modem��DCD״̬�����仯ʱ�����ʼ�
    DSRCHANGED ,                  //  '
    WARMSTART ,                   //  '�����������ʼ�
    AUTHENTICATIONFAILURE ,       //  '���������û�������������ɵ�¼ʧ�ܴ����ʼ�
    IPADDRESSCHANGED ,             // '����ģ�鵱ǰ��IP��ַ�����ʼ�
    ENABLESERIALTRIGGERINPUT,      // 'ѡ��True��ģ�鴮�ڽ��յ������緢�������ض��ַ�ʱ�������ʼ�
    SERIALCHANNEL  ,               // 'ѡ�񴥷��ʼ��Ĵ��ں�
    SERIALDATASIZE ,               // 'ѡ�񴮿ڴ����ʼ����ַ�����
    SERIALMATCHDATA1 ,             // '�����ַ�1�趨�����ʼ����ض��ַ���ʽΪ16����
    SERIALMATCHDATA2  ,            // '�����ַ�2�趨�����ʼ����ض��ַ���ʽΪ16����
    EMAILTRIGGERSUBJECT ,          // '�ʼ�����
    PRIORITY  ,                    // '�ʼ����ȼ�
    INPUTPRIORITY,
    INPUTMINNOTIFICATIONINTERVAL ,
    MINNOTIFICATIONINTERVAL  ,
    RENOTIFICATIONINTERVAL  ,
    NEWUSERPSW  ,
    BOOTP   ,                     //  '�Ƿ�����������Э�����IP��ַ
    DHCP   ,                      //  '�Ƿ�����DHCPЭ�����IP��ַ
    AUTOIP  ,                    //   '�Ƿ�����AUTO IPЭ�����IP��ַ
    DHCPHOSTNAME  ,              //   'DHCP������
    subnet  ,                    //   '��������
    DEFAULTGATEWAY ,            //    '����
    DeviceName  ,               //    '�豸��
    TIMEZONE ,                  //    'ʱ��
    LOCALTIME_YEAR  ,
    LOCALTIME_MONTH   ,
    LOCALTIME_DAY ,
    LOCALTIME_HOUR  ,
    LOCALTIME_MINUTE  ,
    LOCALTIME_SECOND ,
    TIMESERVER ,                  //  'ʱ�������
    WEBCONSOLE ,                 //   'Webʹ��
    TELNETCONSOLE  ,             //   'Telnetʹ��
    PASSWORDCHANGED ,            //   '�������봥���ʼ�
    SERIALPORTOPTIONS ,          //   '����ʹ��
    PREFERREDDNSSERVER ,         //   '��ѡDNS������
    ALTERNATEDNSSERVER  ,        //   '����DNS������
    SERIALMATCHDATA3  ,          //   '�����ַ�3�趨�����ʼ����ض��ַ���ʽΪ16����
    INPUT1  ,                   //   'I/O ����1 �����ʼ���I/O ����1��ƽ
    INPUT2 ,                    //    'I/O ����2 �����ʼ���I/O ����1��ƽ
    IO1  ,                      //    'Input/Output 1
    IO2  ,                     //     'Input/Output 2
    IO1TYPE  ,
    IO2TYPE ,
    IO1STATE  ,
    IO2STATE  ,
    SERIALPORTPROTOCOL ,
    FIRMWAREID ,
    PPPOEUSERNAME  ,             //   'PPPoE�˺�
    PPPOEPASSWORD  ,             //   'PPPoE����
    PPPOEWORKMODE   ,            //   'PPPoE����ģʽ
    PPPOEMAXREDIALTIMES ,         //  '����ز�����
    PPPOEREDIALINTERVAL ,         //  'PPPoE�ز����
    PPPOEIDLETIME  ,             //   'PPPoE�Ҷ�ǰ����ʱ��
    PPPOESTATUS   ,               //  'PPPoE����״̬
    PPPOEIP   ,                   //  'PPPoE��ǰ��ȡ��IP��ַ
    PPPOEGATEWAY  ,                // 'PPPoE��ǰ��ȡ������
    PPPOEDNS1 ,                   //  'PPPoE��ǰ��ȡ��DNS1
    PPPOEDNS2 ,                    // '��ʾPPPoE��ǰ��ȡ��DNS2
    ENABLEBACKUPLINK );
    Function DM_Init(searchCB:PLongInt;
                     data:LongInt ): LongInt;
                       stdcall;external DLL_NAME ;

    Function DM_SearchDevice(devIP:DWORD;
                     timeout:LongInt ): LongInt;
                       stdcall;external DLL_NAME ;

    Function DM_DeInit(): LongInt;
                       stdcall;external DLL_NAME ;

    Function DM_GetDeviceInfo(devhandle:LongInt;
                              var devIP:DWORD;
                              mac:PChar;
                              devName:PChar): LongInt;
                       stdcall;external DLL_NAME ;

     Function DM_AuthLogin(devhandle:LongInt;
                              name:PChar;
                              pwd:PChar;
                              timeout:LongInt): TagErrorCode;
                       stdcall;external DLL_NAME ;

     Function DM_FreeDevice(devhandle:LongInt): TagErrorCode;
                       stdcall;external DLL_NAME ;

     Function paralistCreate(devhandle:LongInt): LongInt;
                       stdcall;external DLL_NAME ;

     Function paralistDestroy(list:LongInt): TagErrorCode;
                       stdcall;external DLL_NAME ;

     Function paralist_addnode(list:LongInt;
                              chanNo:LongInt;
                              paraType:ParaTypes;
                              valueLen:LongInt;
                              var value:Byte): TagErrorCode;
                       stdcall;external DLL_NAME ;

     Function paralist_getnode(list:LongInt;
                              chanNo:LongInt;
                              paraType:ParaTypes;
                              var valueLen:LongInt;
                              var value:Byte): TagErrorCode;
                       stdcall;external DLL_NAME ;

     Function DM_GetPara(devhandle:LongInt;
                              list:LongInt;
                              timeout:LongInt): TagErrorCode;
                       stdcall;external DLL_NAME ;
     Function DM_SetPara(devhandle:LongInt;
                              list:LongInt;
                              timeout:LongInt): TagErrorCode;
                       stdcall;external DLL_NAME ;

     Function DM_ResetDevice(devhandle:LongInt;
                              timeout:LongInt): TagErrorCode;
                       stdcall;external DLL_NAME ;

     Function DM_LogOutDevice(devhandle:LongInt;
                              timeout:LongInt): TagErrorCode;
                       stdcall;external DLL_NAME ;


   type
     TSearchCallback=procedure( dev:LongInt;
                               data:LongInt); stdcall;
     procedure SearchCallback ( dev:LongInt;
                               data:LongInt); stdcall;
  //

implementation
uses  frmUHFReader288demomain;
    procedure SearchCallback ( dev:LongInt;
                               data:LongInt); stdcall;
    var   //
      devIP:DWORD;
      mac:array[0..30]of Char;
      devName:array[0..30]of Char;
    begin
      devIP:=0;
      mac:='';
      DM_GetDeviceInfo (dev, devIP, mac, devName);
      frmUHFReader288main.SearchCallback1(devIP, mac, devName, dev ) ;
    end;

end.