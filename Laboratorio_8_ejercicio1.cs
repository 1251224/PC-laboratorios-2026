using System;
class Program
{
    static void Main()
    {
        int aprobados = 0;
        int reprobados = 0;
        int suma = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Ingrese la nota del estudiante " + i + ": ");
            int nota = int.Parse(Console.ReadLine());

            suma = suma + nota;

            if (nota >= 61)
            {
                Console.WriteLine("El estudiante APRUEBA");
                aprobados++;
            }
            else
            {
                Console.WriteLine("El estudiante REPRUEBA");
                reprobados++;
            }
        }

        double promedio = suma / 10.0;

        Console.WriteLine("\nResultados finales:");
        Console.WriteLine("Promedio de la clase: " + promedio);
        Console.WriteLine("Cantidad de aprobados: " + aprobados);
        Console.WriteLine("Cantidad de reprobados: " + reprobados);

        Console.ReadKey();
    }
}