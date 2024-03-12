Dictionary<string, object> variables = new Dictionary<string, object>();

Console.WriteLine("Anote el número que está pensando y yo lo adivinaré (por motivos tecnicos esta limitado a 995)");
string input = Console.ReadLine();

// Nos aseguramos que ingresen numero positivos enteros
if (!int.TryParse(input, out int adivinar))
{
    Console.WriteLine("Por favor, ingrese un número válido.");
    return;
}

if (adivinar < 0)
{
    Console.WriteLine("Por favor, ingrese un número positivo.");
    return;
}

// Agregamos las variables respectivas y elaboramos las primeras operaciones matematicas
variables["adivinar"] = adivinar;
variables["res1"] = adivinar * 2;
variables["res2"] = (int)variables["res1"] + 8;
int res3 = (int)variables["res2"] * 5;

// Verificar la cantidad de dígitos en res3
string res3Str = res3.ToString();
int digitCount = res3Str.Length;

// Elimina el ultimo digito antes de hacer la resta y da el resultado
if (digitCount == 4)
{
    string elim0 = res3.ToString().Remove(3, 1);
    variables["resfinal"] = int.Parse(elim0) - 4;
    Console.WriteLine("El numero que estas pensando es... " + variables["resfinal"]);
}

if (digitCount == 3)
{
    string elim0 = res3.ToString().Remove(2, 1);
    variables["resfinal"] = int.Parse(elim0) - 4;
    Console.WriteLine("El numero que estas pensando es... " + variables["resfinal"]);
}

if (digitCount == 2)
{
    string elim0 = res3.ToString().Remove(1, 1);
    variables["resfinal"] = int.Parse(elim0) - 4;
    Console.WriteLine("El numero que estas pensando es... " + variables["resfinal"]);
}