Console.WriteLine("Ingrese una palabra:");
string palabra = Console.ReadLine();

if (EsPalindromo(palabra))
{
    Console.WriteLine($"{palabra} si es un palindromo");
}
else
{
    Console.WriteLine($"{palabra} no es un palidromo");
}

static bool EsPalindromo(string palabra)
{
    int longitud = palabra.Length;

    for (int i = 0; i < longitud / 2; i++)
    {
        if (palabra[i] != palabra[longitud - 1 - i])
        {
            return false;
        }
    }
    return true;
}