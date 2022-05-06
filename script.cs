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

//Arrays**********************************************

string[] produtos = new string[5];
string[] produtos = new string[5]{"Fifa", 
			"Minecraft",
			"Age of Empires",
			"Dark Colony",
			"MIB"
			};
			
int[] valores = {40,50,60,70,20};

//Switch********************************************
	cor = "Azul";

switch(cor){
	
	
	case "Vermelho":
	console.WhiteLine("Sua cor favorita é Vermelha");
	break;
	
	case "Amarelo":
	console.WhiteLine("Sua cor favorita é Amarelo");
	break;
	
	case "Azul":
	console.WhiteLine("Sua cor favorita é Amarelo");
	break;
	
}

//ENUM*********************************************Criar tipos de dados

//Conjunto de dados limitado

class Program
{
	
	enum Cor{Azul = 33, Verde, Amarelo, Vermelho};//pode-se alterar o índice
	enum Cor{Azul, Verde, Amarelo, Vermelho};
	
	
	static void Main(string[] args)
	{
		Cor corFavorita = Cor.Vermelho;
		Cor corFavoritaCarla = Cor.Azul;
		
		Console.WriteLine(corFavorita);
		
		Console.WriteLine((int)corFavorita);//converter o tipo "cast"
		Console.WriteLine((Cor)2);//Convertendo inteiro 
	}
}

//ENUM com Switch*****************************************************************************************Criar tipos de dados

enum Opcao{Criar=1, Deletar, Editar, Listar, Atualizar};

	Console.WriteLine("1-Criar\n, 2-Deletar\n, 3-Editar\n, 4-Listar\n, 5-Atualizar\n");
	int index = int.Parse(Console.ReadLine());
	
	//Vai Pegar as opções do ENUM
	Opcao opcaoSelecionada = (Opcao)index;
	
	switch(opcaoSelecionada)
	{
		case Opcao.Criar:
		Console.WriteLine("Criar Algo");
		break;
		case Opcao.Deletar:
		Console.WriteLine("Delete");
		break;
		case Opcao.Editar:
		Console.WriteLine("Edite Algo");
		break;
	
		default:
		Console.WriteLine("Opção não encontrado");
		break;
	}
	
//While*****************************************************************************************

int contador =0;
while(contador < 10){
	
	Console.WhriteLine("Rodando o While!");
	contador++;//contador += 1;
}
	Console.WhriteLine("FIM DA LINHA!");
