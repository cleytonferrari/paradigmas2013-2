program exer15;
uses crt;
 var
  nome: string;



   Function subString(nome:string;inicio,quantidade:integer):string;
   var
    x : integer;
    retorno: string;

   begin
    retorno := '';

    for x := inicio to inicio+quantidade-1 do
     begin
      retorno:= retorno +nome[x];
     end;

    subString:= retorno;
  end;


begin
 clrscr;
 write('digite um nome:');
 readln(nome);


 writeln('Todo Nome: ', nome);
 writeln('Primeiro Caracter: ', nome[1]);
 writeln('Ultimo Caracter: ',nome[length(nome)] );
 writeln('Do Primeiro ate o Terceiro: ',subString(nome,1,3));
 writeln('Quarto Caracter: ', nome[4]);
 writeln('Todos Menos o Primeiro: ',subString(nome,2,length(nome)-1));
 writeln('Os dois Ultimos: ',subString(nome,length(nome)-1,2));

 readln;
end.
