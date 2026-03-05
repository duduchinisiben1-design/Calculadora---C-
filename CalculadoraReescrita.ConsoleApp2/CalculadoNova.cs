

Console.WriteLine("-------------------------------");
Console.WriteLine("Seja Bem-Vindo à Calculadora Resumida, 2026");
Console.WriteLine("-------------------------------");

Console.WriteLine("Clique ENTER para que possamos resolver seu problema matemático");
Console.ReadLine();

Console.WriteLine("Após a sua recepção calarosa da nossa desenvolvedora, escolha uma destas opções abaixo");

Console.WriteLine();

Console.WriteLine("----------------------------------------");
Console.WriteLine("Qual o tipo do seu problema matemático?");
Console.WriteLine("----------------------------------------");

Console.WriteLine();

Console.WriteLine("1 - Adição");
Console.WriteLine("2 - Subtração");
Console.WriteLine("3 - Multiplicação");
Console.WriteLine("4 - Divisão");
Console.WriteLine("5 - Tabuada");
Console.WriteLine("S - Finalizar o programa");

Console.WriteLine();

Console.WriteLine("Relembrando, Selecione uma opção válida.");
string? operacaoSelecionada = Console.ReadLine();

Console.WriteLine();

int? primeiroNumero;
int? segundoNumero;

decimal? resultado;




switch (operacaoSelecionada)
{
    case "1": 
        Console.WriteLine("Digite o primeiro número da sua conta: ");
        primeiroNumero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("Digite o segundo número da sua conta: ");
        segundoNumero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();


        resultado = primeiroNumero + segundoNumero;
        Console.WriteLine("O resultado da sua conta seria: " + resultado);

    break;
    case "2":
        Console.WriteLine("Digite o primeiro numero da sua conta: ");
        primeiroNumero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("Digite o segundo número da sua conta: ");
        segundoNumero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        resultado = primeiroNumero - segundoNumero;
        Console.WriteLine("O resultado da sua conta seria: " + resultado);
    break;
    case "3": 
        Console.WriteLine("Digite o primeiro numero da sua conta: ");
        primeiroNumero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("Digite o segundo número da sua conta: ");
        segundoNumero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        resultado = primeiroNumero * segundoNumero;
        Console.WriteLine("O resultado da sua conta seria: " + resultado);
    break;
    case "4": 
        Console.WriteLine("Digite o primeiro numero da sua conta: ");
        primeiroNumero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("Digite o segundo número da sua conta: ");
        segundoNumero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        if (segundoNumero == 0)
        {
            Console.WriteLine("Nenhum número é divisível por 0!!");
        }

        resultado = primeiroNumero / segundoNumero;
        Console.WriteLine("O resultado da sua conta seria: " + resultado);
    break;
}



