using System;
using System.Collections.Generic;

// Clase que controla las calificaciones del estudiante
class ControlAcademico
{
    // Diccionario donde se guarda la materia y su nota
    private Dictionary<string, double> registroNotas = new Dictionary<string, double>()
    {
        { "Matemáticas", 0 },
        { "Física", 0 },
        { "Química", 0 },
        { "Historia", 0 },
        { "Lengua", 0 }
    };

    // Método para ingresar las notas
    public void PedirCalificaciones()
    {
        Console.WriteLine("Ingrese las calificaciones obtenidas:");

        foreach (string materia in new List<string>(registroNotas.Keys))
        {
            Console.Write($"{materia}: ");
            double nota;

            while (!double.TryParse(Console.ReadLine(), out nota))
            {
                Console.Write("Valor incorrecto, intente nuevamente: ");
            }

            registroNotas[materia] = nota;
        }
    }

    // Método para mostrar solo las materias reprobadas
    public void MostrarMateriasPendientes()
    {
        Console.WriteLine("Materias que deben repetirse:");

        foreach (var item in registroNotas)
        {
            if (item.Value < 7)
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}
