using System;
using System.Collections.Generic;

// Clase que realiza operaciones con vectores
class OperacionesVectoriales
{
    public void CalcularProducto()
    {
        List<int> primerVector = new List<int> { 1, 2, 3 };
        List<int> segundoVector = new List<int> { -1, 0, 2 };

        int producto = 0;

        for (int i = 0; i < primerVector.Count; i++)
        {
            producto += primerVector[i] * segundoVector[i];
        }

        Console.WriteLine($"Resultado del producto escalar: {producto}");
    }
}
