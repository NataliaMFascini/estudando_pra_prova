
double num1;
double num2;

Console.WriteLine("Digite o tipo de operação:");
string operacao = Console.ReadLine();

if (operacao == "Soma" || operacao == "soma")
{
    Console.WriteLine("Digite o primeiro número: ");
    num1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite o segundo número: ");
    num2 = Convert.ToDouble(Console.ReadLine());

    Soma(num1, num2);
}
else if (operacao == "Substração" || operacao == "substração")
{
    Console.WriteLine("Digite o primeiro número: ");
    num1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite o segundo número: ");
    num2 = Convert.ToDouble(Console.ReadLine());

    Subtracao(num1, num2);
}
else if (operacao == "Multiplicação" || operacao == "multiplicação")
{
    Console.WriteLine("Digite o primeiro número: ");
    num1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite o segundo número: ");
    num2 = Convert.ToDouble(Console.ReadLine());

    Multiplicacao(num1, num2);
}
else if (operacao == "Divisão" || operacao == "divisão")
{
    Console.WriteLine("Digite o primeiro número: ");
    num1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite o segundo número: ");
    num2 = Convert.ToDouble(Console.ReadLine());

    while (num2 == 0)
    {
        Console.WriteLine("Não pode dividir por 0.");
        Console.WriteLine("Digite o segundo numero: ");
        num2 = Convert.ToDouble(Console.ReadLine());
    }
    Divisao(num1, num2);
}else if(operacao == "Potencia" || operacao == "potencia")
{
    Console.WriteLine("Digite o primeiro número: ");
    num1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite o segundo número: ");
    num2 = Convert.ToDouble(Console.ReadLine());

    Potencia(num1, num2);
}
else
{
    Console.WriteLine("Comando invalido");
}

void Soma(double n1, double n2)
{
    Console.Clear();
    Console.WriteLine($"A soma é {n1 + n2}.");
}

void Subtracao(double n1, double n2)
{
    Console.Clear();

    Console.WriteLine($"A subtração é {n1 - n2}.");
}

void Multiplicacao(double n1, double n2)
{
    Console.Clear();

    Console.WriteLine($"A multiplicação é {n1 * n2}.");
}

void Divisao(double n1, double n2)
{
    Console.Clear();

    Console.WriteLine($"A divisão é {n1 / n2}.");
    Console.WriteLine($"O resto é {n1 % n2}.");
}

void Potencia(double n1, double n2)
{
    Console.Clear();
    double n = 1;
    double resultado = n1;
    while(n < n2)
    {
        resultado *= n1;
        n++;
    }

    Console.WriteLine($"A potencia é {resultado}.");
}