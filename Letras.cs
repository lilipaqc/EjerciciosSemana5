using System;
using System.Collections.Generic;

// Clase que trabaja con el abecedario
class Letras
{
    public void ProcesarAbecedario()
    {
        List<char> abecedario = new List<char>();

        // Generamos el abecedario completo
        for (char letra = 'A'; letra <= 'Z'; letra++)
        {
            abecedario.Add(letra);
        }

        // Eliminamos las letras en posiciones múltiplos de 3
        for (int i = abecedario.Count - 1; i >= 0; i--)
        {
            if ((i + 1) % 3 == 0)
            {
                abecedario.RemoveAt(i);
            }
        }

        Console.WriteLine("Abecedario luego del proceso:");
        Console.WriteLine(string.Join(", ", abecedario));
    }
}
