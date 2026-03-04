Console.WriteLine("------------------------------");
Console.WriteLine("Calculadora 2026");
Console.WriteLine("------------------------------");

Console.WriteLine("1 - Adição");
Console.WriteLine("2 - Subtração");
Console.WriteLine("3 - Multiplicação");
Console.WriteLine("4 - Divisão");
Console.WriteLine("5 - Sair");

Console.WriteLine("Selecione Uma Operação Válida: ");
string operacaoSelecionada = Console.ReadLine();


switch (operacaoSelecionada)
{
    case "1":
        Console.Write("Digite o primeiro número: ");
        string strprimeiroNumeroA = Console.ReadLine();

        Console.Write("Digiteo segundo numero");
        string strsegundoNumeroA = Console.ReadLine();

        Console.WriteLine();

        Console.WriteLine("O primeiro número digitado foi: " + strprimeiroNumeroA);
        Console.WriteLine("O segundo número digitado foi: " + strsegundoNumeroA);


        int primeiroNumero = Convert.ToInt32(strprimeiroNumeroA);
        int segundoNumero = Convert.ToInt32(strsegundoNumeroA);

        int resultadoSoma = primeiroNumero + segundoNumero;

        Console.WriteLine("O resultado da sua soma é: " + resultadoSoma);


        break;
    case "2":
        Console.Write("Digite o primeiro número: ");
        string strprimeiroNumeroS = Console.ReadLine();

        Console.Write("Digiteo segundo numero");
        string strsegundoNumeroS = Console.ReadLine();

        Console.WriteLine();

        Console.WriteLine("O primeiro número digitado foi: " + strprimeiroNumeroS);
        Console.WriteLine("O segundo número digitado foi: " + strsegundoNumeroS);

        int primeiroNumeroSub = Convert.ToInt32(strprimeiroNumeroS);
        int segundoNumeroSub = Convert.ToInt32(strsegundoNumeroS);

        int resultadoSub = primeiroNumeroSub - segundoNumeroSub;
        Console.WriteLine("A subtração dos número é: " + resultadoSub);

        break;
    case "3":
        Console.Write("Digite o primeiro número: ");
        string strprimeiroNumeroM = Console.ReadLine();

        Console.Write("Digiteo segundo numero");
        string strsegundoNumeroM = Console.ReadLine();

        Console.WriteLine();

        Console.WriteLine("O primeiro número digitado foi: " + strprimeiroNumeroM);
        Console.WriteLine("O segundo número digitado foi: " + strsegundoNumeroM);

        int primeiroNumeroM = Convert.ToInt32(strprimeiroNumeroM);
        int segundoNumeroM = Convert.ToInt32(strsegundoNumeroM);

        int resultadoM = primeiroNumeroM * segundoNumeroM;
        Console.WriteLine("A subtração dos número é: " + resultadoM);

        break;
    case "4":
        Console.Write("Digite o primeiro número: ");
        string strprimeiroNumeroD = Console.ReadLine();

        Console.Write("Digiteo segundo numero: ");
        string strsegundoNumeroD = Console.ReadLine();

        Console.WriteLine();

        Console.WriteLine("O primeiro número digitado foi: " + strprimeiroNumeroD);
        Console.WriteLine("O segundo número digitado foi: " + strsegundoNumeroD);

        decimal primeiroNumeroD = Convert.ToDecimal(strprimeiroNumeroD);
        decimal segundoNumeroD = Convert.ToDecimal(strsegundoNumeroD);

        decimal resultadoD = primeiroNumeroD / segundoNumeroD;
        Console.WriteLine("A subtração dos número é: " + resultadoD);
        break;
    case "5":
        Console.WriteLine("Seu Programa Foi FInalizado!!");
        break;
    default:
        Console.WriteLine("Operação Inválida");
        break;
}










