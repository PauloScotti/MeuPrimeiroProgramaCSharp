string nomecompleto;
string textoolamundo = "Olá mundo, meu primeiro programa CSharp! Feito por ";
int idade;

Console.WriteLine("Qual o seu nome?");

nomecompleto = Console.ReadLine().ToString();

Console.WriteLine("Qual a sua idade?");

idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(textoolamundo + nomecompleto + " que tem " + idade + " anos.");