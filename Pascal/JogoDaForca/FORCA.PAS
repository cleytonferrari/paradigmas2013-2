Program teste;
uses crt;
var
   palavra, letra, op :  string;
   tamanho, x, acertos, digitos, erros : integer;
   fim, fechar, achou: boolean;
procedure pedeLetra;
begin
  gotoxy(1,1);
  write('Digite uma letra: ');
  readln(letra);
end;

procedure posicionaLetra;
begin
  gotoxy(1,10);
  for x:=1 to tamanho do
  begin
    write('~');
  end;
  gotoxy(1,11);
  write('Voce ja digitou: ');
  digitos := digitos + 1;
  gotoxy(digitos,11);
  write(letra);
  achou := false;
  for x:=1 to tamanho do
  begin
    if palavra[x] = letra then
    begin
      gotoxy(x,9);
      write(letra);
      acertos := acertos + 1;
      achou := true;
      if acertos = tamanho then
        fim := true;
    end;
  end;
  if achou=false then
  begin
    erros := erros + 1;
    gotoxy(1,12);
    write('Voce ja errou ', erros, 'x, voce so pode errar 3x');
    if erros > 2 then
    begin
      fim := true;
     end;
  end;
end;

Begin
  fechar := false;
  digitos := 17;
  while fechar = false do
  begin
    clrscr;
    erros := 0;
    acertos:= 0;
    write('Digite uma palavra: ');
    readln(palavra);
    tamanho := length(palavra);
    clrscr;
    fim := false;
    while fim = false do
    begin
     pedeLetra;
     posicionaLetra;
    end;

    clrscr;
    if erros > 2 then
      writeln('VOCE PERDEU')
    else
      writeln('PARABENS VOCE GANHOU');
    writeln('Fim do jogo!');
    write('Jogar novamente? (y/n): ');
    readln(op);
    if op = 'n' then
      fechar := true;
  end;

  readln;
End.