Console.Clear(); 

int primeiroNumero, segundoNumero;

Console.WriteLine("--- Maior 2 Numeros ---");

Console.Write("Digite o primeiro numero: ");

primeiroNumero = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o segundo numero: ");

segundoNumero = Convert.ToInt32(Console.ReadLine());

if(primeiroNumero > segundoNumero)
{
    Console.WriteLine($"o maior numero é {primeiroNumero}");
}
else 
{
    Console.WriteLine($"o maior numero é {segundoNumero}");
}