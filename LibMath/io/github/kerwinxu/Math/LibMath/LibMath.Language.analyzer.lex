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

[0-9]+"i"|[0-9]+"."[0-9]*"i" {GetImaginary(); return (int)Token.COMPLEX;} // 复数的虚部
[0-9]+|[0-9]+"."[0-9]* {GetReal();  return (int)Token.COMPLEX;}            // 复数的实数部分
// 如下是一堆的运算符
"+" {return  (int)Token.OP_ADD;}
"-" {return  (int)Token.OP_SUB;}
"**" {return (int)Token.OP_POW;}
"*" {return  (int)Token.OP_MUL;}
"%" {return  (int)Token.OP_REM;}
"/" {return  (int)Token.OP_DIV;}
// 括号单独阔出来
"(" {return  (int)Token.LEFT_BRACKET;}
")" {return  (int)Token.RIGHT_BRACKET;}

"PI" {GetPI();return (int)Token.COMPLEX;}
"EXP" {GetEXP();return (int)Token.COMPLEX;}
"ANS" {yylval.s = yytext;return (int)Token.ANS;}

"AX"|"BX"|"CX"|"DX"|"EX"|"FX" {yylval.s = yytext;return (int)Token.REG;} // 寄存器的。


[a-zA-Z]+ { yylval.s = yytext;return (int)Token.OP_FUN;}  // 这个是取得函数的

"," {return  (int)Token.COMMA;}

{Space}+		/* skip */

"\n" {yylval.s = yytext;return (int)Token.END;} // 我以这个作为结束。
"="  {yylval.s = yytext;return (int)Token.END;}

. {yyerror("error chars:{0}", new object[]{ yytext});}

%%