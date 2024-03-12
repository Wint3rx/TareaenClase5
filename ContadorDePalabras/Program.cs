Console.WriteLine("Ingrese una frase:");
string frase = Console.ReadLine();

int cantidadPalabras = ContarPalabras(frase);
int cantidadVocales = ContarVocales(frase);

Console.WriteLine($"Número de palabras: {cantidadPalabras}");
Console.WriteLine($"Número de vocales: {cantidadVocales}");

// Creamos una funcion unica para el apartado de contar las palabras
static int ContarPalabras(string texto)
{
    int contadorPalabras = 0;
    int indice = 0;

    while (indice < texto.Length) // Este while avanza hasta que se encuentre el primer caracter no espaciado
    {
        while (indice < texto.Length && char.IsWhiteSpace(texto[indice])) // En este momento el while va a ir agregando un valor al contador por cada palabra que encuentre y si encuentra un espacio en blanco incrementa el indice
        { 
            indice++;
        }

        if (indice < texto.Length && !char.IsWhiteSpace(texto[indice]))
        {
            contadorPalabras++;

            while (indice < texto.Length && !char.IsWhiteSpace(texto[indice]))
            {
            indice++;
            }
        }
    }

    return contadorPalabras;
}

// Creamos una segunda funcion para el apartado de contar las vocales
static int ContarVocales(string texto)
{
    int contadorVocales = 0;

    foreach (char caracter in texto.ToLower()) // Utilizamos un bucle foreach para iterar sobre cada carácter en la cadena convertida a minúsculas.
    {
        if ("aeiou".Contains(caracter)) // Verifica si el caracter contiene una vocal (las que se contienen en la cadena) y luego las va sumando al contador de vocales.
        {
            contadorVocales++;
        }
    }

    return contadorVocales;
}