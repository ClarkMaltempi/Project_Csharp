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

int contador2 =0;
	do{
		
		Console.WhriteLine("Rodando o While!");
		contador2++;
		
	}while(contador2 < 20);
	
	
//Foreach************************************************************

string[] palavras = {"Vitor", "Lima", "Guia do prog"};

foreach(string palavra in palavras)// Para cada palavra no array palavras, repita o bloco de código
{
	Console.WhriteLine("FOREACH RODANDO");
	Console.WhriteLine(palavra);
}

//For*************************************************************

for(int contador=0; contador < 10; contador++){
	Console.WhriteLine("FOR RODANDO");
}





//Compilador SDK
//.NET Core
//shaplarb.io ver o código gerado
//comandos
dotnet new tipo *console *WindowsForms 
dotnet run 
dotnet run --Curso//Passando um agumento para o método Main
//F12 ver a estrutura
//static somente funcionalidades

//Operadores

//ternário retorna valor se true "10" || se false "20"
i = i2 == 42 ? 10 : 20;

//Ignorando maiusculas e minusculas
string[] names = {"Fredi","Mariana","Isabella"};

if(string.Equals(names[0], "fredi", StringComparison.OrdinalIgnoreCase))
{
	Console.WriteLine("Igual");
}

foreach(string name in names)
{
	Console.WhriteLine(name);
}

//Trabalhando com strings Ctrl+F12 (manual) || para ter informação do método Ctrl+Shift+Space
//Método Contains --utilizado para ver se a string tem algum Caracter
string name = "Fredi";

Console.WhriteLine(name.length); //Tamanho
Console.WriteLine(name.EndsWith('a');//Ela finaliza com a letra A retorna um bool
Console.WriteLine(name.StartsWith("F");//começa com a letra
Console.WriteLine(name.Contains('a'));//contem a letra
Console.WriteLine(name.IndexOF("ed"));//retorna o índice

string.IsNullOrEmpty //string nula ou vazia
Console.WriteLine(string.IsNullOrEmpty(name));

string.IsNullOrWriteSpace//Verifica se tem espaço em branco
string.join //Juntar strings
string[] names = {"Fredi", "Machado"};
Console.WriteLine(string.join(' ',names));// em vez de ' '

int i = 10;
int.tryParse("42", out i);//passa uma string retorna um inteiro, ele tenta e verifica se a conversão é feito com sucesso

//conversão implicita
//Tipos de Refencia X Tipo de Valor

int i =10;//int tipo de valor, ou seja, vão conter diretamente o valor atribuído a elas
long l = 10; //armazenar numeros muito maiores

i = l;//não é possivel criar atribuir sendo que long é um tipo diferente
string = (string)l; //também não aplicavel nesse caso 

i = (int)l; //uma solução nesses casos é a conversão do valor, chamado de conv explicita
string s= l.ToString();//tipos de reference (class), é mais complexos, armazenar várias valores, o objeto da variavel é armazenado em um endereço de memory
//então nós teriamos o endereço da memory onde o objeto é armazenado

//Exemplificando string
//Criar uma instancia do Objeto
//main - comparando dois objeto com o mesmo endereço
int i =10;
int i2 = i;
i2 = 20;
Test t = new Test();
t.x  = 10;

Test t2 = t;
t2 = new Test();
t2.X = 20;

Console.WhriteLine(t.X);
//fora main
class Test
{
	public int x;
}

//Tipos anuláveis

int? i = 10;
int? i2 = i;

if(i != null) //Diferente de Nulo
if(i is null)//return bool
if(i is not null)//return não é nulo

i.HasValue//Método return bool caso possua um valor
i.value//return o valor do objeto
i.GetValueOrDefault //retun o valor ou valor padrão

//NullReferenceException exemplo, quando o valor é nulo sem retorno
string s = null;
Console.WriteLine(s.Length); 
//.csproj na arquivo de inicialização do projeto podemos adicionar o tratamento dessa exceção
<Nullable>enable</Nullable>

//tratamento de exceção Try/Cat

try
{
	Console.WriteLine(s.Length); 
}
catch(System.Exception)
{
	Console.WriteLine("Erro"); 
}
		  
		  
//Classes 
/*
[ModificadorClasse] class NomeDaClasse{
	//Variaveis / Propriedades
	[EspecificadorAcesso] tipo NomePropriedade
	
	//Métodos
	[EspecificadorAcesso] retorno NomeMetodo([arg1...]){
		//Corpo do Método
	}
}

[ModificadorClasse] Define a visibilidade da classe
//public: Pública, se restrição
//abstract: Classe-Base para outras classes, não pode ser estanciado objetos dessa classe
//sealed: Classe não pode ser herdada
static: Classe não permite a instanciação de objetos e seus
	Membros devem ser static
	
EspecificadorAcesso: Onde um membro da classe pode ser acessado
public: Sem restrição de acesso
private: Só podem ser acessado pela própria classe
protected: Podem ser acessados na própria classe e nas classes derivadas

abstract: Os métodos não tem implementação somente os cabeçalhos
sealed: O método não pode ser redefinido
virtual: o método pode ser redefinido em uma classe derivada
static: o método pode ser chamado mesmo sem a instanciação de um objeto

*/

//Classes exemplo contas Bancárias***********************************************************
//Main
//Instanciando criamos duas referencias na memória e atribuimos no ex account1 e account2.
BankAccount account1 = new BankAccount();//é possível acessar os métodos e atributos desse objeto
BankAccount account2 = new BankAccount();

account1.name = "Fredi";


class BankAccount
{
	public string name;//definir a acessibilidade
	public decimal balance;
}

//Mas como uma boa prática definimos um construtor por que qualquer um com a reference account1 pode atribuir 
//qualquer valor, null por exemplo.

BankAccount account1 = new BankAccount();//é possível acessar os métodos e atributos desse objeto
BankAccount account2 = new BankAccount();

account1.name = "Fredi";


class BankAccount
{
	private string name;//definir a acessibilidade
	private decimal balance;
	
	public BankAccount(string name, decimal balance)//construtor
	{
		name = name;
		balance = balance;
	}
}

//Os atributos estão com o mesmo nome, para resolver isso podemos utilizar

private string _name;//definir a acessibilidade
private decimal _balance;//renomeando o atributo
	
	public BankAccount(string name, decimal balance)//construtor
	{
		_name = name;
		_balance = balance;
	}

//Ou utilizando o this***************************
//main
//ConsoleLogger logger = new ConsoleLogger(); //Pode ser representado da mesma maneira abaixo, o fato de substituir o ConsoleLogger, é devido a implementação para salvar em um arquivo externo os logs
ILogger logger = new FileLogger("filePath.txt");//Adicionando o filePath
BankAccount account1 = new BankAccount("Fredi",100, logger);
BankAccount account2 = new BankAccount("Mari",100, logger);

accont1.Deposit(-100);

accont2.Deposit(100);



//Console.WriteLine(decimal GetBalance());

class BankAccount
{
	private string name;//definir a acessibilidade
	private decimal balance;
	private readonly ILogger logger; //Propriedade só é possível atribuir através de um construtor
	
	public BankAccount(string name, decimal balance, ILogger logger)//construtor, podemos adicionar um parametro e selecionar a opção Create and assign field 'logger'
	{
		if(string.IsNullOrWriteSpace(name))
		{
			throw new Exception();//Lançando uma excessão throw e criando uma instancia exceção
			//throw new ArgmentException("Nome inválido","name"); --outra maneira de verificar || throw new ArgmentException("Nome inválido",nameof(name)); 
		}//nameof altera todos os atributos vantagem ao mudar o código
		if(balance < 0)
		{
			throw new Exception("Saldo não pode ser negativo");
		}
		this.name = name;
		this.balance = balance;
		this.logger = logger;
	}
	
	//Em vez de utilizar como a parte comentada um método para return o valor de balance, utilizamos uma Propriedade
	//prop
	//public int MyProperty{get; set;}
	public decimal Balance
	{
		get{return balance;}
		private set{balance = value;}//atribuir para 
		
	} //controlar ou buscar ou o valor atribuído 
	
	public void Deposit(decimal amount)//Quantidade de dinheiro
	{
		if(amount <= 0)
		{
			logger.log("Não é possivel depositar{amount} na conta de {name}. ");
			return;	
		}
	  //balance = balance + amount;
	  balance += amount;
	}
/*
	public decimal GetBalance()
	{
		return balance;
	}
*/
}

//Interface --

class ConsoleLogger : ILogger//Ctrl . --Escolhendo implement interface
{
	//public void Log(string message) --
	//{
		//throw new NoImplementedException();
//		Console.WhriteLine($"LOGGER:{message}");
	//}
}

interface ILogger
{
   void Log(string message)
   {
	   Console.WhriteLine($"LOGGER:{message}");
   }			
}

//Criar outra aplicação, Salvar a mensagem em um arquivo
class FileLogger:ILogger//Ctrl .
{
	//ctor
	public FileLogger(string filePath)//Criando um construtor para modificar o nome do arquivo
	{
		this.filePath = filePath;
	}
	
	public void Log(string message)
	{
		//File.AppendAllText("log.txt", $"{message}{Environment.NewLine}");//Passar o caminho do arquivo, interpolar através da classe reservada environment para criar uma outra linha só para manter multiplataforma
		File.AppendAllText(filePath, $"{message}{Environment.NewLine}");
	}
}


//Tipo Genericos Lista**********************************************************************************************************************

//BankAccount account1 = new BankAccount("Fredi",100, logger);
//BankAccount account2 = new BankAccount("Mari",100, logger);
//Adicionar em uma lista um objeto
List<BankAccount> accounts = new List<BankAccount>();//

accounts.Add(account1);//adicionar em uma lista
accounts.Add(account2);

accounts.Remove(account1);
//OU
//Pode ser inicializado
List<BankAccount> accounts = new List<BankAccount>()
{
	account1,
	account2
};


List<int> accounts = new List<int>(){1,4,8,10};

foreach(int number in numbers)
{
	Console.WhriteLine(number);
}

//OU

foreach(BankAccount account in accounts)
{
	Console.WhriteLine(account.Balance);
}

//Criando tipos Genericos

class DataStore<T>
{
	public T Value {get; set;} //Propriedade generica com nome value
	
	
}

List<BankAccount> accounts = new List<BankAccount>()
{
	account1,
	account2
};

DataStore<int> store = new DataStore<int>();
store.Value = 42;
Console.WriteLine(store.Value);

//Tipagem Implicita, passa pro compilador a tarefa de definir a variável, o código pode ser modificado*************************************************


var logger = new FileLogger("filePath.txt");//Adicionando o filePath
var account1 = new BankAccount("Fredi",100, logger);
var account2 = new BankAccount("Mari",100, logger);

var accounts = new List<BankAccount>()
{
	account1,
	account2
};

var store = new DataStore<string>();
store.Value = "Nome";
Console.WriteLine(store.Value);

//Delegate um objeto para executar métodos************************************************************************************

delegate int Calculate (int x,int y);

//Método compatível com o delegate
static int Sum(int a, int b)
{
	return a+b;
}

//Main - No construtor passamos o Método
Caculate calculate = new Calculate(Sum);
int result = calculate(10,20);//Executar como um método
Console.WriteLine(result);

//Outro exemplo
Run(Sum);

static void Run(Calculate calc)
{
	Console.WriteLine(calc(20,30)); 
}

//Anonimo
var multiply = delegate(int x, int y){return x*y;};

//Definindo um método Func
//main
Run(multiply);
//
static void Run(Func<int,int,int>calc)
{
	Console.WriteLine(calc(20,30)); 
}

//Outra maneira sem passar parametro
Func<decimal> test2 = delegate(){return 4.2m;};
Console.WriteLine(test2());

Func<string, bool> checkName = delegate(string name){return name == "John";};
Console.WriteLine(checkName("John"));

//Action
var test = delegate (string name){Console.WhriteLine($"Olá{name}");};

test("John Wick");

//Expressão Lambda
var multiply = (int x, int y) => x*y;//O que define uma expressão lambda "=>"
Run(multiply);

var test = (string name)=> Console.WhriteLine($"Olá{name}");
test("John Wick");

Func<decimal> test2 = () => 4.2m; //Quando não há parametro tem que colocar os parenteses
Console.WriteLine(test2());

unc<string, bool> checkName =(name) => name == "John";
Console.WriteLine(checkName("John"));


//Passando o método diretamente 
var multiply = (int x, int y) => x*y;//O que define uma expressão lambda "=>"
Run((x,y)=>x*y); //Passando a função lambda como parametro


static void Run(Func<int,int,int>calc)
{
	Console.WriteLine(calc(20,30)); 
}

//Extender qualquer Tipo, 

Console.ForgroundColor = ConsoleColor.Red;
Console.WhriteLine("teste");
Console.ResetColor();
Console.WhriteLine("teste");

//Main
WhriteLine("Testando", ConsoleColor.yellow); //Nesse class não precisamos passar o tipo como Program. por que estamos dentro da classe

static void WhriteLine(string text, ConsoleColor color)
{
	Console.ForgroundColor = color;
	Console.WhriteLine("teste");
	Console.ResetColor();
}

static void WhriteLine(this string text, ConsoleColor color) // declarando uma extensão colocando o this nos parametros do método
{
	Console.ForgroundColor = color;
	Console.WhriteLine("teste");
	Console.ResetColor();
}

//Definir a class Program como static class Program
//Qualquer objeto do tipo string podemos executar esse método

"Testando".WhriteLine(ConsoleColor.Yellow);

//Classes específicas para métodos de extensão

static class Extensions
{
	
	public static void WhriteLine(this string text, ConsoleColor color) // declarando uma extensão colocando o this nos parametros do método
	{
		Console.ForgroundColor = color;
		Console.WhriteLine("teste");
		Console.ResetColor();
	}	
}

//Extender qualquer método
//main
var logger = new ConsoleLogger();
logger.Test();

public static void Test(this ConsoleLogger logger)
{
	
}

//Se no caso essas classes estiver em outro doc
//utilizando outro namespace Banks por exemplo
using Bank;

//Bank.BankAccount account = new Bank.BankAccount("John",100, new Bank.ConsoleLogger()); Omitimos chamar a namespace individualmente

BankAccount account = new BankAccount("John",100, new ConsoleLogger());

//Podemos nomear o namespace como system, conforme exemplo

namespace System
{
	static class Extensions
	{
		
		public static void WhriteLine(this string text, ConsoleColor color) // declarando uma extensão colocando o this nos parametros do método
		{
			Console.ForgroundColor = color;
			Console.WhriteLine("teste");
			Console.ResetColor();
		}	
	}
}

//Trabalhando com Json C#****************************************************************************************************************

using System.Text.Json;

string json = JsonSerializer.Serialize(account);

Console.WhriteLine(json);//Vai gerar um arquivo json

//Podemos utilizar esse formato no processo inverso -- Deserialize
BankAccount account1 = jsonSerializer.Deserialize<BankAccount>(json);

Console.WhriteLine(account1.Name);

//Atributos

[JsonConstructor]//Marcação, para criar uma nova instancia 

public BankAccount(string name, decimal balance): this (name,balance,new ConsoleLogger())//o this é utilizado para referenciar o BankAccount e atribuir a outra função a responsabilidade
{}

public BankAccount(string name, decimal balance, ILogger logger)//construtor, podemos adicionar um parametro e selecionar a opção Create and assign field 'logger'
	{
		if(string.IsNullOrWriteSpace(name))
		{
			throw new Exception();//Lançando uma excessão throw e criando uma instancia exceção
			//throw new ArgmentException("Nome inválido","name"); --outra maneira de verificar || throw new ArgmentException("Nome inválido",nameof(name)); 
		}//nameof altera todos os atributos vantagem ao mudar o código
		if(balance < 0)
		{
			throw new Exception("Saldo não pode ser negativo");
		}
		this.name = name;
		this.balance = balance;
		this.logger = logger;
	}
	
	
//LINQ -Language Integrated Query -- Consulta integrada em Documentos*******************************************************************************************
using System.Linq;

int[] number = {1,4,10,42};

//Essa Maneira de escrever Query sintax ou Sintexe de Consulta
var query = from number in numbers
			where number < 10 
			select number;
			
	//usando expressão lambda, metodos de instenção, sintax de método
var query2 = numbers.Where(number => number < 10);

var result = query.toList();//retornar uma lista de inteiros
//Outros métodos
//Console.WhriteLine(query.Count());//contar elementos, o problema de executar diretamente é pode ocorrer incoerencias através do filtro para resolver utilizamos as funções toList, que return o object integrated
Console.WhriteLine(result.Count());

foreach(var number in query)
{
	Console.WriteLine(number);
}

//First, FirstOrDefaul, OrderBy, OrderByDescending, GroupBy, Select

var query = number.First();
var query = number.Where(number => number > 8).First(); //Pode-se encadear os métodos
var query = number.First(number => number > 8);//Funciona da mesma maneira
var query = number.First();

var n = numbers.FirstOrDefaul(number => number > 42);//Numero maior que 42, ele retorna 0 (Padrão)

var n = numbers.OrderByDescending(number => number);//Ordena

var accounts = new List<BankAccount>
{
	new BankAccount("Fred", 100),
	new BankAccount("mari", 50)
	
	
};

var acc = accounts.OrderBy(account => account.Balance).toArray();//consulta que gera um objeto

//GroupBy pode agrupar propriedades, por exemplo agrupar por uma agencia

var accounts = new List<BankAccount>
{
	new BankAccount("Fred", 100){Branch = "123"},
	new BankAccount("mari", 50){Branch = "321"}
	
};

var acc = accounts.GroupBy(account => account.Branch);

foreach(var group in acc)//Impirmir os valores agrupando
{
	Console.WhriteLine($"Agencia: {group.Key}");
	Console.WhriteLine("---");
	foreach (var account in group)
	{
		Console.WhriteLine($"{account.Name} possui ${account.Balance}")
	}
	Console.WhriteLine("---");
}

//Select
var namesQuery = account.Select(account => account.Name); //Seleciona a conta e retorna somente os nomes
var namesQuery = account.Select(account => $"{account.Name} ${account.Balance}");

//Podemos criar um tipo
class BranchCustomer
{
	public string Name {get; set;}
	public string Branch {get; set;}
	
}
//Ficaria dessa maneira
var namesQuery = account.Select(account => new BranchCustomer {Name = account.Name, Branch = account.Branch});

//Retornando anonimo criando nova instancia de um tipo
var namesQuery = account.Select(account => new {Name = account.Name, Branch = account.Branch});

//Empty******

var test = Enumerable.Empty<int>(); //retorna, representado um enumerado

//Range
var range = Enumerable.Range(0,5);//criar numeros aleatóriso
//Random
var random = new Random();
var range = Enumerable.Range(0,5).select(number => random.next(1,100));//next recebe (minimo, max)

//Outro exemplo
var range = Enumerable.Range(0,26).Select(number => (char)('a' + number));



