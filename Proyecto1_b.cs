using System;
class Program
{
    static void Main()
    {
        Console.Write("Operador: ");
        string operador = Console.ReadLine();

        Console.Write("Capacidad: ");
        int capacidad = int.Parse(Console.ReadLine());

        bool activo = false;
        string placa = "", cliente = "";
        int tipo = 0, entrada = 0, tiempo = 0;
        double total = 0;

        int op = 0;

        while (op != 5)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n1.Crear 2.Salida 3.Estado 4.Tiempo 5.Salir");
            Console.ResetColor();

            op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                if (activo)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ocupado");
                }
                else
                {
                    Console.Write("Placa: ");
                    placa = Console.ReadLine();

                    Console.Write("Cliente: ");
                    cliente = Console.ReadLine();

                    Console.Write("Tipo(1-3): ");
                    tipo = int.Parse(Console.ReadLine());

                    entrada = tiempo;
                    activo = true;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ticket creado");
                }
            }

            else if (op == 2)
            {
                if (!activo)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No hay carro");
                }
                else
                {
                    int min = tiempo - entrada;
                    double pago = 0;

                    if (min > 15)
                    {
                        int h = (min + 59) / 60;

                        if (tipo == 1) pago = h * 5;
                        if (tipo == 2) pago = h * 10;
                        if (tipo == 3) pago = h * 15;

                        if (min > 360) pago += 25;
                    }

                    Console.Write("VIP S/N: ");
                    if (Console.ReadLine() == "S") pago *= 0.9;

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Cliente: " + cliente);
                    Console.WriteLine("Placa: " + placa);
                    Console.WriteLine("Paga: Q" + pago);

                    total += pago;
                    activo = false;
                }
            }

            else if (op == 3)
            {
                Console.WriteLine("Cap: " + capacidad);
                Console.WriteLine("Disp: " + (activo ? 0 : 1));
                Console.WriteLine("Tiempo: " + tiempo);
                Console.WriteLine("Total: Q" + total);
            }

            else if (op == 4)
            {
                Console.Write("Min: ");
                tiempo += int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Total Q" + total);
    }
}