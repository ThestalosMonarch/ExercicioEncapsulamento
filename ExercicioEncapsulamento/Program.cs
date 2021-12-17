// See https://aka.ms/new-console-template for more information

using ExercicioEncapsulamento;

Console.Write("Digitar o nome do Títular: ");
string nome = Console.ReadLine();

Console.Write("Digite saldo em conta: ");
double saldo = double.Parse(Console.ReadLine());

Console.Write("Digite a senha da conta: ");
string senha = Console.ReadLine();

Conta conta = new Conta(nome,saldo,senha);
Console.WriteLine(conta);

//-------- Função de Deposito ------------------
Console.Write("Digite um valor para ser depositado: ");
double deposito = double.Parse(Console.ReadLine());
conta.Depositar(deposito);
Console.WriteLine(conta);

//-------- Função de saque ------------------
Console.Write("Digite um valor para ser sacado: ");
double saque = double.Parse(Console.ReadLine());
conta.Saque(saque);
Console.WriteLine(conta);

//-------- Função alterar o Limite do cartão de Crédito -----------------
Console.Write("Digite o limite para seu cartão de crédito: ");
double limite = double.Parse(Console.ReadLine());
conta.AlterarLimite(limite);
Console.WriteLine(conta);


