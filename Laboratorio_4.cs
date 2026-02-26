using System;
class Program
{
    static void Main()
    {
        string modelo = "Nave Espacial2000";
        int capacidadCarga = 2500;
        float nivelCombustible = 92.4f;
        bool motorSaltoActivo = true;

        Console.WriteLine("--- FICHA DE NAVE ---");
        Console.WriteLine("Modelo: " + modelo + " | Carga: " + capacidadCarga + " | Combustible: " + nivelCombustible + " | Motor de salto activo: " + motorSaltoActivo);

        short sensoresActivos = 128;
        int registroProcesador = sensoresActivos;
        double precisionTotal = registroProcesador;
        Console.WriteLine("Precisión Total: " + precisionTotal);

        double energiaGenerada = 987.65;
        int energiaLimitada = (int)energiaGenerada;
        Console.WriteLine("Energía: Original " + energiaGenerada + " -> Truncada " + energiaLimitada);

        Console.Write("\nDistancia al planeta: ");
        string entradaRadar = Console.ReadLine();
        int distancia = int.Parse(entradaRadar);
        Console.WriteLine("Distancia final: " + (distancia + 100));

        string señalOxigeno = "true";
        bool oxigeno = Convert.ToBoolean(señalOxigeno);
        string temperaturaCabina = "22.8";
        double temp = Convert.ToDouble(temperaturaCabina);
        Console.WriteLine("Oxígeno: " + oxigeno + " | Temperatura: " + temp);

        double velocidadLuz = 299792.458;
        Console.WriteLine("Velocidad Formateada: " + velocidadLuz.ToString("N3"));

        Console.Write("\nPrecio Galón de Litio: ");
        string precioTxt = Console.ReadLine();
        double precioBase = Convert.ToDouble(precioTxt);
        double impuesto = precioBase * 0.12;
        double costoTotal = precioBase + impuesto;

        int totalFinal = (int)costoTotal;
        Console.WriteLine("El costo final de suministro es: " + totalFinal);

        Console.WriteLine("\n   (\\__/)");
        Console.WriteLine("   (o^.^)");
        Console.WriteLine("  z(_(\")(\")");
        Console.WriteLine("\n¡Pikachu te desea suerte en tus parciales!");

        Console.WriteLine("¿Qué harás el 14 de febrero?");
        string respuesta = Console.ReadLine();
        Console.WriteLine("Mensaje de misión: " + respuesta);
    }
}