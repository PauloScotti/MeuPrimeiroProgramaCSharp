/*
string nomecompleto;
string textoolamundo = "Olá mundo, meu primeiro programa CSharp! Feito por ";
int idade;

Console.WriteLine("Qual o seu nome?");

nomecompleto = Console.ReadLine().ToString();

Console.WriteLine("Qual a sua idade?");

idade = Convert.ToInt32(Console.ReadLine());

switch (nomecompleto)
{
    case "Paulo": Console.WriteLine("Dev"); break;
    case "Danilo": Console.WriteLine("Guitarra"); break;
    default: Console.WriteLine("Não encontrado"); break;
}

bool valido = false;

if(valido)
{
    Console.WriteLine("Passou como verdadeiro");
}
else
{
    Console.WriteLine("Passou como falso");
}

Console.WriteLine(!valido);
Console.WriteLine(valido);

if(idade == 40 || nomecompleto == "Paulo Scotti")
{
    Console.WriteLine(textoolamundo + nomecompleto + " que tem " + idade + " anos.");
} else
{
    Console.WriteLine("Você errou a idade ou o nome");
}

Console.WriteLine(textoolamundo + nomecompleto + " que tem " + idade + " anos.");

*/

//Exercicio

string nomeDoJogador;

Console.WriteLine("Qual o nome do jogador");
nomeDoJogador = Console.ReadLine().ToString();

/* Não é o ideal para esse caso
if(nomeDoJogador == "Paulo" || nomeDoJogador.Contains("Danilo"))
{
    Console.WriteLine("Jogador autorizado");
}
else
{
    Console.WriteLine("Jogador não autorizado");
} */

switch (nomeDoJogador)
{
    case "Paulo":
    case "Danilo":
    case "Fernando":
        Console.WriteLine("Jogador autorizado");
        break;
    default:
        Console.WriteLine("Jogador não autorizado");
        break;
}