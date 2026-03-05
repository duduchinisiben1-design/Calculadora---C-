using System.Net;

Console.WriteLine("------------------------------");
Console.WriteLine("Calculadora 2026");
Console.WriteLine("------------------------------");

Console.WriteLine("1 - Adição");
Console.WriteLine("2 - Subtração");
Console.WriteLine("3 - Multiplicação");
Console.WriteLine("4 - Divisão");
Console.WriteLine("5 - Sair");

Console.WriteLine("Selecione Uma Operação Válida: ");
string? operacaoSelecionada = Console.ReadLine();


switch (operacaoSelecionada)
{
    case "1":
        Console.Write("Digite o primeiro número: ");
        string? strprimeiroNumeroA = Console.ReadLine();

        Console.Write("Digiteo segundo numero: ");
        string? strsegundoNumeroA = Console.ReadLine();

        Console.WriteLine();

        bool primeiroNumeroVazioA = string.IsNullOrEmpty(strprimeiroNumeroA);
        bool segundonumeroVazioA = string.IsNullOrEmpty(strsegundoNumeroA);

        if(primeiroNumeroVazioA == true || segundonumeroVazioA == true)
        {
            Console.WriteLine("Escreva Um Número Válido");
            break;

        } 


        Console.WriteLine("O primeiro número digitado foi: " + strprimeiroNumeroA);
        Console.WriteLine("O segundo número digitado foi: " + strsegundoNumeroA);


        decimal primeiroNumero = Convert.ToDecimal(strprimeiroNumeroA);
        decimal segundoNumero = Convert.ToDecimal(strsegundoNumeroA);

        decimal resultadoSoma = primeiroNumero + segundoNumero;

        Console.WriteLine("O resultado da sua soma é: " + resultadoSoma);


        break;
    case "2":
        Console.Write("Digite o primeiro número: ");
        string? strprimeiroNumeroS = Console.ReadLine();

        Console.Write("Digiteo segundo numero: ");
        string? strsegundoNumeroS = Console.ReadLine();

        Console.WriteLine();

        bool primeiroNumeroVazioS = string.IsNullOrEmpty(strprimeiroNumeroS);
        bool segundonumeroVazioS = string.IsNullOrEmpty(strsegundoNumeroS);
         
        if(primeiroNumeroVazioS == true || segundonumeroVazioS == true)
        {
            Console.WriteLine("Escreva Um Número Válido");
            break;

        } 

        Console.WriteLine("O primeiro número digitado foi: " + strprimeiroNumeroS);
        Console.WriteLine("O segundo número digitado foi: " + strsegundoNumeroS);

        decimal primeiroNumeroSub = Convert.ToDecimal(strprimeiroNumeroS);
        decimal segundoNumeroSub = Convert.ToDecimal(strsegundoNumeroS);

        decimal resultadoSub = primeiroNumeroSub - segundoNumeroSub;
        Console.WriteLine("A subtração dos número é: " + resultadoSub);

        break;
    case "3":
        Console.Write("Digite o primeiro número: ");
        string? strprimeiroNumeroM = Console.ReadLine();

        Console.Write("Digiteo segundo numero: ");
        string? strsegundoNumeroM = Console.ReadLine();

        Console.WriteLine();

        bool primeiroNumeroVazioM = string.IsNullOrEmpty(strprimeiroNumeroM);
        bool segundonumeroVazioM = string.IsNullOrEmpty(strsegundoNumeroM);
         
        if(primeiroNumeroVazioM == true || segundonumeroVazioM == true)
        {
            Console.WriteLine("Escreva Um Número Válido");
            break;

        } 

        

        Console.WriteLine("O primeiro número digitado foi: " + strprimeiroNumeroM);
        Console.WriteLine("O segundo número digitado foi: " + strsegundoNumeroM);

        decimal primeiroNumeroM = Convert.ToDecimal(strprimeiroNumeroM);
        decimal segundoNumeroM = Convert.ToDecimal(strsegundoNumeroM);

        decimal resultadoM = primeiroNumeroM * segundoNumeroM;
        Console.WriteLine("A subtração dos número é: " + resultadoM);

        break;
    case "4":
        Console.Write("Digite o primeiro número: ");
        string? strprimeiroNumeroD = Console.ReadLine();

        Console.Write("Digiteo segundo numero: ");
        string? strsegundoNumeroD = Console.ReadLine();

          Console.WriteLine();

        bool primeiroNumeroVazioD = string.IsNullOrEmpty(strprimeiroNumeroD);
        bool segundonumeroVazioD = string.IsNullOrEmpty(strsegundoNumeroD);
         
        if(primeiroNumeroVazioD == true || segundonumeroVazioD == true)
        {
            Console.WriteLine("Escreva Um Número Válido");
            break;

        } 

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










