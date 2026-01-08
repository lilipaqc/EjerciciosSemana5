using System;

// Clase principal donde inicia el programa
class Program
{
    static void Main()
    {
        Console.WriteLine("=== PROGRAMA DE EJERCICIOS CON LISTAS ===\n");

        // EJERCICIO 4: LOTERÍA
        JuegoLoteria juego = new JuegoLoteria();
        juego.RegistrarNumeros();
        juego.MostrarResultado();

        Console.WriteLine("\n----------------------------------\n");

        // EJERCICIO 6: MATERIAS A REPETIR
        ControlAcademico control = new ControlAcademico();
        control.PedirCalificaciones();
        control.MostrarMateriasPendientes();

        Console.WriteLine("\n----------------------------------\n");

        // EJERCICIO 7: ABECEDARIO
        Letras letras = new Letras();
        letras.ProcesarAbecedario();

        Console.WriteLine("\n----------------------------------\n");

        // EJERCICIO 8: PALÍNDROMO
        AnalizadorPalabra analizador = new AnalizadorPalabra();
        analizador.ComprobarPalindromo();

        Console.WriteLine("\n----------------------------------\n");

        // EJERCICIO 11: PRODUCTO ESCALAR
        OperacionesVectoriales vectores = new OperacionesVectoriales();
        vectores.CalcularProducto();

        Console.WriteLine("\nFin del programa. Presione una tecla para salir.");
        Console.ReadKey();
    }
}
