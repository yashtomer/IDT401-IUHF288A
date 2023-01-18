unit LoginForm;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls,DevControl,UHFReader288_Head;

type
  TfLoginForm = class(TForm)
    Label1: TLabel;
    Edit1: TEdit;
    Label2: TLabel;
    Edit2: TEdit;
    Button1: TButton;
    Button2: TButton;
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
  private
    { Private declarations }
  public
    user_str:string;
    password_str:string;
    { Public declarations }
  end;

var
  fLoginForm: TfLoginForm;

implementation
uses frmUHFReader288demomain;
{$R *.dfm}

procedure TfLoginForm.Button1Click(Sender: TObject);
var
  usname:array[0..30]of Char;
  pass:array[0..30]of Char;
  m,i:Integer;
  errorcode:TagErrorCode;
  temp:string;
begin
  user_str:=Trim(Edit1.Text);
  password_str:=Trim(Edit2.Text);
  for i:=0 to Length(user_str)-1 do
     usname[i]:=user_str[i+1];
  for i:=0 to Length(password_str)-1 do
     pass[i]:=password_str[i+1];
  m:=frmUHFReader288main.select_index;
  errorcode:=DM_AuthLogin(frmUHFReader288main.m_hDevArray[m],usname,pass,1000);
  temp:=GetDeviceErrorTypeDesc(errorcode);
  if(errorcode<>DM_ERR_OK) then
   MessageDlg(temp, mtWarning, [mbOK], 0);
  Close;
end;

procedure TfLoginForm.Button2Click(Sender: TObject);
begin
Close;
end;

end.
