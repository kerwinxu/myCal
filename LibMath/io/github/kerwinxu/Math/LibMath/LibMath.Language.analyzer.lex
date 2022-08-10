%namespace io.github.kerwinxu.Math.LibMath
%scannertype LibMathScanner
%visibility internal
%tokentype Token

%option stack, minimize, parser, verbose, persistbuffer, noembedbuffers 

Eol             (\r\n?|\n)
NotWh           [^ \t\r\n]
Space           [ \t]
Number          [0-9]+
alpha [a-zA-Z]

%{

%}

%%

/* Scanner body */

[0-9]+"i"|[0-9]+"."[0-9]*"i" {GetImaginary(); return (int)Token.COMPLEX;} // �������鲿
[0-9]+|[0-9]+"."[0-9]* {GetReal();  return (int)Token.COMPLEX;}            // ������ʵ������
// ������һ�ѵ������
"+" {return  (int)Token.OP_ADD;}
"-" {return  (int)Token.OP_SUB;}
"**" {return (int)Token.OP_POW;}
"*" {return  (int)Token.OP_MUL;}
"%" {return  (int)Token.OP_REM;}
"/" {return  (int)Token.OP_DIV;}
// ���ŵ���������
"(" {return  (int)Token.LEFT_BRACKET;}
")" {return  (int)Token.RIGHT_BRACKET;}


alpha[+] { yylval.s = yytext;return (int)Token.OP_FUN;}  // �����ȡ�ú�����

{Space}+		/* skip */

"\n" {return (int)Token.END;} // ���������Ϊ������

%%