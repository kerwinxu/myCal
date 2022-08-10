%namespace io.github.kerwinxu.Math.LibMath
%partial
%parsertype LibMathParser
%visibility internal
%tokentype Token

%{
    System.Numerics.Complex result;
%}

%union { 
			public System.Numerics.Complex n; 
			public string s; 
	   }

%start line

%token COMPLEX OP_ADD OP_SUB OP_MUL OP_DIV OP_REM OP_FACT END NEG OP_POW OP_FUN LEFT_BRACKET RIGHT_BRACKET
// 优先级和结合性如下
%left OP_ADD OP_SUB 
%left OP_MUL OP_DIV OP_REM OP_FACT
%right OP_POW
%left OP_FUN
%left NEG

%%

line:
    line expr END {
        //printf("%2f\n", $2);
        result = $2.n;
        }
    |;

expr:
    expr OP_ADD term {$$.n = $1.n + $3.n;}
    | expr OP_SUB term {$$.n = $1.n - $3.n;}
    | term {$$.n=$1.n;}
;
term:
    term OP_MUL factor {$$.n = $1.n * $3.n;}
    | term OP_DIV factor {$$.n = $1.n / $3.n;}
    | term OP_POW factor {$$.n = System.Numerics.Complex.Pow($1.n,$3.n);}
    | term OP_REM factor {$$.n = new System.Numerics.Complex((int)$1.n.Real % (int)$3.n.Real,0 );} // 余数，仅仅是针对整数的
    | factor {$$.n=$1.n;}
;
factor:
    COMPLEX {$$.n=$1.n;}
    | LEFT_BRACKET expr RIGHT_BRACKET {$$.n=$2.n;}
    | OP_SUB COMPLEX %prec NEG {$$.n=0-$2.n;}
    | fun
;
fun:
    OP_FUN LEFT_BRACKET expr RIGHT_BRACKET {
        if ("sin" ==  $1.s)
        {
            $$.n = System.Numerics.Complex.Sin($3.n* System.Math.PI / 180);
        }else if ("cos" ==  $1.s)
        {
            $$.n = System.Numerics.Complex.Cos($3.n* System.Math.PI / 180);
        }
        else{
            yyerror("错误的函数:", new object[] {$1.s});
        }
    } // end
;

%%