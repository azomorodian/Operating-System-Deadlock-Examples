program DiningPhilosophers;

uses
  Forms,
  UnitMain in 'UnitMain.pas' {FrmMain},
  UnitThreadPhilosophor in 'UnitThreadPhilosophor.pas';

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TFrmMain, FrmMain);
  Application.Run;
end.
