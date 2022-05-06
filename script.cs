//
//           .NET Framework                            .NET Core          XAMARIN
//            WPF     Windows Forms                    	UWP               IOS, Android, OS X
//			  ASP.NET									ASP.NET
//
//**********************************.NET STANDARD LIBRARY***********************************
//
//

//Quarto Ambiente
//MONO - TV Sansumg, Playstation, xbox, nintendo switch

//Program Default 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorld
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

    }
}


//Declaração de Variáveis

var meuTexto = "Hello!!!"; //variável sem tipo
int num = 5; // 156 como 32334
float num = 5.0;//15.6 como 232.132
double num = 15.0;
decimal num = 4;
bool verdadeiro = true;
string texto = "Esse é um texto";
char car = 'a';

//Tipagem dinamica

dynamic cor_favorita = "Vermelho";

cor_favorita = 1122332; //mudar o tipo da variável

//constantes

const float PI = 3.14;

//Entrada de usuários

string nome = Console.ReadLine();

//funções

Console.ReadLine();

//Operadores Matemáticos
//* + / % -

//Condicionais
//10 > 200
//10 < 2
//10 >=10
//2 <= 50
// "vi" == "vic"
// 11 != 11

if(num > num2)
{
	//Executa código
}else
{
	//Executa código
}else if(num2 == num){
	//Executa código
}

//&&(e AND) e || (OU/OR);

//Programa que captura a idade
//Criança -- 
//Adolescente --
//Adulto --
//Idoso --

//Converter texto para numero

int idade = int.Parse("123");
int idade = int.Parse(Console.ReadLine());

//Trabalhando com função

 class Program
    {
        static void Main(string[] args)
        {
            var meuTexto = "Hello!!!";
            Console.WriteLine("Hello, World!\n");
            Console.WriteLine(meuTexto);

            ExibirMsg();
            GerarPreco(10);
        }

        //Função void
        static void ExibirMsg()
        {
            Console.WriteLine("Esse é um texto de teste Função");
        }

        //Recebendo parametro
        static void GerarPreco(int preco)
        {
            Console.WriteLine(preco);

        }
	 
	 static int Nota(int Nota1, int Nota2)
	{
		int resultado = Nota1+Nota2;
		return resultado;
	}

    }
	
//Função de Modulo que transforma numero negativo em positivo

int precoAbs = Math.Abs(preco);
