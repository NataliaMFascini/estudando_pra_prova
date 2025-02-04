//exercicios que deveriam me dar um bolo
double n1;
double numTotal = 0;

double soma = 0;
double tabuada;

double[] numeros = new double[10];
double maiorNum = 0;
double menorNum = 1000000000000000;

for(int i = 0; numTotal < numeros.Length; i++)
{
    Console.WriteLine("Digite um número: ");
    n1 = Convert.ToDouble(Console.ReadLine());
    numeros[i] = n1;
    
    if(maiorNum < numeros[i])
    {
        maiorNum = numeros[i];
    }
    if(menorNum > numeros[i])
    {
        menorNum = numeros[i];
    }

    soma += n1;
    numTotal++;
}

Console.WriteLine($"A soma de todos os números é {soma}");

Console.WriteLine($"O maior número é {maiorNum}.");
Console.WriteLine($"O menor número é {menorNum}.");

if (soma % 2 == 0)
{
    Console.WriteLine("A soma é par.");
}else
{
    Console.WriteLine("A soma é impar.");
}

for(int i = 1; i <= 10; i++)
{
    tabuada = soma * i;
    Console.WriteLine($"{soma} x {i} = {tabuada}");
}
