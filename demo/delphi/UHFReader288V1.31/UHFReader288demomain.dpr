program UHFReader288demomain;



uses
  Forms,
  frmUHFReader288demomain in 'frmUHFReader288demomain.pas' {frmUHFReader288main},
  UHFReader288_Head in 'UHFReader288_Head.pas',
  UHFReader288_DLL_Head in 'UHFReader288_DLL_Head.pas',
  fProgressbar in 'fProgressbar.pas' {frmprogress},
  LoginForm in 'LoginForm.pas' {fLoginForm},
  DevControl in 'DevControl.pas';

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TfrmUHFReader288main, frmUHFReader288main);
  Application.CreateForm(Tfrmprogress, frmprogress);
  Application.CreateForm(TfLoginForm, fLoginForm);
  Application.Run;
end.
