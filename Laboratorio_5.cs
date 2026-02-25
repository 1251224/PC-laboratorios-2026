using System;
class Program
{
    static void Main()
    {
        // ===== EJERCICIO 1 =====

        Console.WriteLine("EJERCICIO 1");

        Console.Write("ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("PIN: ");
        int pin = int.Parse(Console.ReadLine());

        Console.Write("Token: ");
        int token = int.Parse(Console.ReadLine());

        Console.Write("Modo seguro (1/0): ");
        int modo = int.Parse(Console.ReadLine());

        if (id == 2026)
            Console.WriteLine("Usuario reconocido.");
        else
            Console.WriteLine("Usuario no reconocido.");

        if (pin == 1234)
            Console.WriteLine("PIN correcto.");
        else
            Console.WriteLine("PIN incorrecto.");

        if (token == 777)
            Console.WriteLine("Token válido.");
        else
            Console.WriteLine("Token inválido.");

        if (modo == 1)
            Console.WriteLine("Modo seguro activado: se aplican reglas extra.");
        else
            Console.WriteLine("Modo seguro desactivado.");

        if (id == 2026 && pin == 1234 && token == 777)
            Console.WriteLine("Acceso total concedido.");
        else
            Console.WriteLine("Acceso denegado.");

        if (modo == 1)
        {
            if (token >= 700)
                Console.WriteLine("Regla extra aprobada.");
            else
                Console.WriteLine("Regla extra fallida.");
        }

        // ===== EJERCICIO 2 =====

        Console.WriteLine("\nEJERCICIO 2");

        Console.Write("PIN: ");
        int pin2 = int.Parse(Console.ReadLine());

        if (pin2 >= 1000 && pin2 <= 9999)
            Console.WriteLine("PIN de 4 dígitos: OK.");
        else
            Console.WriteLine("PIN inválido: debe tener 4 dígitos.");

        if (pin2 % 2 == 0)
            Console.WriteLine("PIN par.");
        else
            Console.WriteLine("PIN impar.");

        if (pin2 % 5 == 0)
            Console.WriteLine("Múltiplo de 5.");
        else
            Console.WriteLine("No es múltiplo de 5.");

        if (pin2 >= 1000 && pin2 <= 9999 && pin2 % 2 == 0 && pin2 % 5 != 0)
            Console.WriteLine("PIN aceptado por política.");
        else
            Console.WriteLine("PIN rechazado por política.");

        // ===== EJERCICIO 3 =====

        Console.WriteLine("\nEJERCICIO 3");

        Console.Write("Código: ");
        int codigo = int.Parse(Console.ReadLine());

        Console.Write("Edad: ");
        int edad = int.Parse(Console.ReadLine());

        Console.Write("Términos (1/0): ");
        int terminos = int.Parse(Console.ReadLine());

        Console.Write("2FA (1/0): ");
        int fa = int.Parse(Console.ReadLine());

        Console.Write("Puntaje: ");
        int puntaje = int.Parse(Console.ReadLine());

        if (codigo == 2026)
            Console.WriteLine("Código correcto.");
        else
            Console.WriteLine("Código incorrecto.");

        if (edad >= 18)
            Console.WriteLine("Edad válida.");
        else
            Console.WriteLine("Edad no válida.");

        if (terminos == 1)
            Console.WriteLine("Términos aceptados.");
        else
            Console.WriteLine("Debe aceptar términos.");

        if (fa == 1)
            Console.WriteLine("2FA activado.");
        else
            Console.WriteLine("2FA no activado.");

        if (puntaje >= 70)
            Console.WriteLine("Puntaje suficiente.");
        else
            Console.WriteLine("Puntaje insuficiente.");

        if (codigo == 2026 && edad >= 18 && terminos == 1 && fa == 1 && puntaje >= 70)
            Console.WriteLine("Cuenta activada exitosamente.");
        else
            Console.WriteLine("Cuenta NO activada.");

        // ===== RETO FINAL =====

        Console.WriteLine("\nRETO FINAL");

        Console.Write("Nota: ");
        int nota = int.Parse(Console.ReadLine());

        Console.Write("Minutos tarde: ");
        int tarde = int.Parse(Console.ReadLine());

        Console.Write("Solvencia (1/0): ");
        int solvencia = int.Parse(Console.ReadLine());

        Console.Write("Identificación (1/0): ");
        int identificacion = int.Parse(Console.ReadLine());

        Console.Write("Calculadora (1/0): ");
        int calculadora = int.Parse(Console.ReadLine());

        if (nota >= 61)
            Console.WriteLine("Requisito académico aprobado.");
        else
            Console.WriteLine("Requisito académico NO aprobado.");

        if (tarde <= 10)
            Console.WriteLine("Hora válida.");
        else
            Console.WriteLine("Llegada tarde: fuera de tiempo.");

        if (solvencia == 1)
            Console.WriteLine("Solvencia validada.");
        else
            Console.WriteLine("Sin solvencia.");

        if (identificacion == 1)
            Console.WriteLine("Identificación validada.");
        else
            Console.WriteLine("Sin identificación.");

        if (calculadora == 1)
            Console.WriteLine("Calculadora permitida: OK.");
        else
            Console.WriteLine("Sin calculadora permitida.");

        if (nota >= 61 && tarde <= 10 && solvencia == 1 && identificacion == 1)
            Console.WriteLine("Acceso a sala de examen concedido.");
        else
            Console.WriteLine("Acceso denegado.");

        if (tarde > 0 && tarde <= 10)
            Console.WriteLine("Advertencia: llegó tarde, pero aún puede ingresar.");
    }
}