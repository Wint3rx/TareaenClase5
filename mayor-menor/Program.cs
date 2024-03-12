Console.WriteLine("Ingrese valores positivos (Ingrese 0 para que acabe el programa)");

int n1;
int max = int.MinValue;
int min = int.MaxValue;

while (true)
{
    Console.WriteLine("Ingrese un valor: ");
    string input = Console.ReadLine();
    if (int.TryParse(input, out n1))
    {
        if (n1 == 0)
        {
            Console.WriteLine("Gracias por usar este programa <3");
            break;
        }
        if (n1 < 0)
        {
            Console.WriteLine("Ingrese un valor positivo");
            continue;
        }
        if (n1 > max)
        {
            max = n1;
        }
        if (n1 < min) 
        { 
            min = n1; 
        }
    }
    else
    {
        Console.WriteLine("Ingrese un numero valido");
    }
}

if (int.MinValue != max)
{
    Console.WriteLine($"El numero menor es {min}");
}
else
{
    Console.WriteLine("No se ingresaron valores.");
}
if (int.MaxValue != min)
{
    Console.WriteLine($"El numero mayor es {max}");
}
else
{
    Console.WriteLine("No se ingresaron valores.");
}
