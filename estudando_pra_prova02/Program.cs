int total;
double numero;
double soma = 0;

Console.WriteLine("Digite o total de números: ");
total = Convert.ToInt32(Console.ReadLine());

while (total < 3 || total > 10)
{
    Console.WriteLine("Somente valores entre 3 e 10.");
    Console.WriteLine("Digite o total de números: ");
    total = Convert.ToInt32(Console.ReadLine());
}

if (total >= 3 && total <= 10)
{
    double[] lista = new double[total];
    for(int i = 0; i < lista.Length; i++)
    {
        Console.WriteLine($"Digite o {i + 1}º número: ");
        numero = Convert.ToDouble(Console.ReadLine());

        soma += numero;
    }

    Console.WriteLine($"A média da soma dos números é {soma / total}.");
}

