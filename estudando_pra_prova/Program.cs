//Impares e 10.
double num1;
double num2;

Console.WriteLine("Digite o primeiro número: ");
num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
num2 = Convert.ToDouble(Console.ReadLine());

if(num1 > 10)
{
    Console.WriteLine($"O numero {num1} é maior que 10.");
    if(num1 % 2 != 0)
    {
        Console.WriteLine($"O número {num1} é impar.");
    }else
    {
        Console.WriteLine($"O número {num1} não é impar.");
    }
}
if(num2 > 10)
{
    Console.WriteLine($"O numero {num2} é maior que 10.");
    if (num2 % 2 != 0)
    {
        Console.WriteLine($"O número {num2} é impar.");
    }
    else
    {
        Console.WriteLine($"O número {num2} não é impar.");
    }
}
else
{
    Console.WriteLine("Nenhum número é maior que 10.");
    if(num1 % 2 != 0)
    {
        Console.WriteLine($"O número {num1} é impar.");
    }
    if(num2 % 2 != 0)
    {
        Console.WriteLine($"O número {num2} é impar.");
    }
    else
    {
        Console.WriteLine("Nenhum número é impar.");
    }
}