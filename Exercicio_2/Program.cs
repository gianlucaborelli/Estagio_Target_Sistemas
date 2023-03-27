using Exercicio_2;

bool finalizarExecucao = false;

Console.WriteLine("Este projeto verifica se o valor inteiro digitado pertence a seguencia de Fibonacci.\n");

do
{
    Console.WriteLine("Qual o valor que gostaria de verificar se pertence a Sequencia de Fibonacci?\n");

    int valor;
    try
    {
        valor = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("Entrada inválida! Digite um número inteiro.");
        continue;
    }

    if (Fibonacci.IsFibonacci(valor))
    {
        Console.WriteLine("O número escolhido PERTENCE à sequência de Fibonacci.\n");
    }
    else
    {
        Console.WriteLine("O número escolhido NÃO PERTENCE à sequência de Fibonacci.\n");
    }

    Console.WriteLine("Deseja verificar um novo número?\nTecle ENTER para repetir:");

    ConsoleKeyInfo keyInfo = Console.ReadKey();
    if (keyInfo.Key != ConsoleKey.Enter)
    {
        finalizarExecucao = false;
    }

    Console.Clear();

} while(finalizarExecucao == false);

