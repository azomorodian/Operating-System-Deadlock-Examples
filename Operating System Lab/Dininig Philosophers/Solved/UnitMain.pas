unit UnitMain;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, ExtCtrls, UnitThreadPhilosophor, StdCtrls;

type
  TFrmMain = class(TForm)
    Button1: TButton;
    procedure FormShow(Sender: TObject);
    procedure Button1Click(Sender: TObject);
    procedure FormCloseQuery(Sender: TObject; var CanClose: Boolean);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  FrmMain: TFrmMain;
  endProgram: Boolean = False;
  diedPhilosopher: integer = -1;
  plate, fork: array [1..5] of tshape;
  philosopher: array [1..5] of TTheardPhilosopher;

  state: array [1..5] of 0..2;
  mutex: THandle;
  tCtrl: array [1..5] of THandle; 
implementation

{$R *.dfm}

procedure TFrmMain.FormShow(Sender: TObject);
var
  i: integer;
  ox, oy, maxx, maxy: integer;
  rdsx, rdsy, angle: Double;
begin
  Randomize;
  ox:= 150;
  oy:= 150;
  maxx:= 0;
  maxy:= 0;
  rdsx:= 120;
  rdsy:= 120;
  angle:= 3*pi/2;
  for i:= 1 to 5 do begin
    //Create plate[i] as philopher[i]'s plate
    plate[i]:= TShape.Create(FrmMain);
    plate[i].Parent:= FrmMain;
    plate[i].Shape:= stCircle;
    plate[i].Left:= ox + round(rdsx*cos(angle));
    plate[i].Top:= oy + round(rdsy*sin(angle));
    angle:= angle + pi/5;
    plate[i].Brush.Color:= RGB(random(256), random(256), random(256));

    //Create fork[i]
    fork[i]:= TShape.Create(FrmMain);
    fork[i].Parent:= FrmMain;
    fork[i].Shape:= stRectangle;
    fork[i].Brush.Color:= rgb(255, 255, 255);
    fork[i].Width:= 20;
    fork[i].Height:= 20;
    angle:= angle + pi/5;
    if maxx < plate[i].Left + plate[i].Width then
      maxx:= plate[i].Left + plate[i].Width;
    if maxy < plate[i].Top + plate[i].Height then
      maxy:= plate[i].Top + plate[i].Height;
  end;
  for i:= 1 to 5 do begin
    fork[i].Left:= (plate[(i mod 5) + 1].Left + plate[((i-1) mod 5) + 1].Left + plate[i].Width) div 2 - fork[i].Width div 2;
    fork[i].Top:= (plate[(i mod 5) + 1].top + plate[((i-1) mod 5) + 1].top + plate[i].height) div 2 - fork[i].Height div 2;
  end;
  FrmMain.ClientWidth:= maxx + 35;
  FrmMain.ClientHeight:= maxy + 35;
end;

procedure TFrmMain.Button1Click(Sender: TObject);
var
  i: integer;
begin
  mutex:= CreateSemaphore(nil, 1, 1, nil);
  diedPhilosopher:= 0;
  for i:= 1 to 5 do begin
    philosopher[i]:= TTheardPhilosopher.Create(True);
    philosopher[i].ID:= i;
    philosopher[i].Resume;
    tCtrl[i]:= CreateSemaphore(nil, 0, 1, nil);
    state[i]:= 0;
  end;
end;

procedure TFrmMain.FormCloseQuery(Sender: TObject; var CanClose: Boolean);
var
  i: integer;
begin
  if diedPhilosopher <> -1 then begin
    endProgram:= True;
    while diedPhilosopher < 5 do
      sleep(20);
    for i:= 1 to 5 do
      CloseHandle(tctrl[i]);
    CloseHandle(mutex);
  end;
  CanClose:= True;
end;

end.
