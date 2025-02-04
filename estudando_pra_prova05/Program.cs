using System.ComponentModel;

int[] numeros = new int[7];
int num = 0;

int verificar = 0;
bool existe = false;
int posicao = 0;
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine("Digite um número: ");
    num = Convert.ToInt32(Console.ReadLine());

    numeros[i] = num;
}

Console.WriteLine("Digite um número para verificar a posição: ");
verificar = Convert.ToInt32(Console.ReadLine());

for(int i = 0;i < numeros.Length; i++)
{
    if(numeros[i] == verificar)
    {
        existe = true;
        posicao = i;
    }
}

if (existe)
{
    Console.WriteLine($"O número está na posição {posicao}. Elemento {posicao + 1}.");
}
else
{
    Console.WriteLine("Esse número não está presente.");
}