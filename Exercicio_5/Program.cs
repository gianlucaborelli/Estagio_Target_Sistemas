using Exercicio_5;

Console.WriteLine("Este projeto, a cada texto digitado, entregará o texto digitado de forma invertida");

bool finalizarExecucao = false;

do
{
    string texto = string.Empty;

    Console.WriteLine("Digite o texto que deseja inverter:");
        
    try
    {
        texto = Console.ReadLine();
    }
    catch (FormatException)
    {
        Console.WriteLine("Entrada inválida! Digite um texto válido.");
        continue;
    }

    Console.WriteLine("O texto digitado, de forma invertidá é:\n");
    Console.WriteLine(ManipuladorDeTexto.InverterTexto(texto));

    Console.WriteLine("\nDeseja repetir?\nTecle ENTER para repetir:");

    ConsoleKeyInfo keyInfo = Console.ReadKey();
    if (keyInfo.Key != ConsoleKey.Enter)
    {
        finalizarExecucao = true;
    }

    Console.Clear();

} while(finalizarExecucao == false);
