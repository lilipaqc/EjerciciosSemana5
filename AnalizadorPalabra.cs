using System;

// Clase que analiza palabras ingresadas por el usuario
class AnalizadorPalabra
{
    public void ComprobarPalindromo()
    {
        Console.Write("Ingrese una palabra para analizar: ");

        // Se asegura que el texto no sea nulo
        string textoIngresado = Console.ReadLine() ?? "";

        // Convertimos a minúsculas para evitar problemas al comparar
        textoIngresado = textoIngresado.ToLower();

        char[] letras = textoIngresado.ToCharArray();
        Array.Reverse(letras);

        string palabraInvertida = new string(letras);

        if (textoIngresado == palabraInvertida)
        {
            Console.WriteLine("La palabra ingresada es un palíndromo.");
        }
        else
        {
            Console.WriteLine("La palabra ingresada no es un palíndromo.");
        }
    }
}
