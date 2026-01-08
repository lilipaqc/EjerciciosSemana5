using System;
using System.Collections.Generic;

// Clase que simula el ingreso de números de lotería
class JuegoLoteria
{
    // Lista donde se guardan los números ingresados
    private List<int> boletos = new List<int>();

    // Método para pedir los números al usuario
    public void RegistrarNumeros()
    {
        Console.WriteLine("Ingrese los números ganadores de la lotería:");

        for (int i = 1; i <= 6; i++)
        {
            Console.Write($"Número {i}: ");
            int valor;

            // Validamos que el dato sea correcto
            while (!int.TryParse(Console.ReadLine(), out valor))
            {
                Console.Write("Entrada incorrecta, ingrese un número válido: ");
            }

            boletos.Add(valor);
        }
    }

    // Método que ordena y muestra los números
    public void MostrarResultado()
    {
        boletos.Sort();
        Console.WriteLine("Números ordenados de menor a mayor:");
        Console.WriteLine(string.Join(" - ", boletos));
    }
}
