// Para visualizar mi menú
bool encendido = true;

if (encendido)
{
    while (encendido)
    {

        Console.Clear();
        Console.WriteLine("         ╔══════════════════════════════════════════════════╗");
        Console.WriteLine("         ║                                                  ║");
        Console.WriteLine("         ║                      Menú                        ║");
        Console.WriteLine("         ║              Opciones de compra                  ║");
        Console.WriteLine("         ║              1.Sedán                             ║");
        Console.WriteLine("         ║              2.Moto                              ║");
        Console.WriteLine("         ║              3.Coupé/Sport                       ║");
        Console.WriteLine("         ║              4.Camionetas                        ║");
        Console.WriteLine("         ║              5.Detener programa                  ║");
        Console.WriteLine("         ║                                                  ║");
        Console.WriteLine("         ╠══════════════════════════════════════════════════╣");
        Console.Write("\nElija: ");


        int opcion;
        while (!int.TryParse(Console.ReadLine(), out opcion))
        {
            Console.WriteLine("Por favor, introduce un número entero.");
        }

        Console.Clear();

        //completar el menú
        if (opcion == 5)
        {
            Console.Clear();
            Console.WriteLine("         ╔════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("         ║                                                                                                ║");
            Console.WriteLine("         ║          Gracias por utilizar el Sistema de Inscripción de Estudiantes. ¡Hasta luego!          ║");
            Console.WriteLine("         ║                                                                                                ║");
            Console.WriteLine("         ╠════════════════════════════════════════════════════════════════════════════════════════════════╣");
            break;
        }

        Vehiculos auto = CFabrica.GetVehiculos(opcion); // llamada a la fábrica

        if (auto != null)
        {
            auto.CrearAuto(); // implementación de la interfaz
        }
        else
        {
            Console.WriteLine("Por favor, elija una opción del menú.");
            Console.ReadKey();
        }

    }
}