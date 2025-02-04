//positivo e negativo

double[] numeros = new double[15];
double num;

int positivo = 0;
int negativo = 0;
int zeros = 0;

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Digite o {i + 1}º número: ");
    num = Convert.ToDouble(Console.ReadLine());

    numeros[i] = num;
}
for (int i = 0;i < numeros.Length; i++)
{
    if (numeros[i] < 0)
    {
        negativo++;
    }
    else if (numeros[i] > 0)
    {
        positivo++;
    }
    else
    {
        zeros++;
    }

}

Console.WriteLine($"{positivo} são positivos, e {negativo} são negativos. Tem {zeros} número(s) 0 na lista.");