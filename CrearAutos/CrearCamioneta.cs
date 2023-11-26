using practica2_copia2.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace practica2_copia2.Autos
{

    class CrearCamioneta : Vehiculos
    {
        private static CCamioneta _camioneta = new();

        // Creación de la lista de camionetas
        private static List<CCamioneta> _ListaCamionetas = new List<CCamioneta>();

        // Constructor para agregar las camionetas a la lista en el momento de la creación
        public CrearCamioneta()
        {
            _ListaCamionetas.Add(new CCamioneta
            {
                Nombre = "Ford Ranger",
                Precio = 10000,
                Combustible = "Gasolina",
                Pasajeros = 5,
                Transmision = "Automática",
                Traccion = "4x4",
                Motor = "2.5L"
            });

            _ListaCamionetas.Add(new CCamioneta
            {
                Nombre = "Toyota Hilux",
                Precio = 15000,
                Combustible = "Diésel",
                Pasajeros = 7,
                Transmision = "Automática",
                Traccion = "4x2",
                Motor = "3.0L"
            });

            _ListaCamionetas.Add(new CCamioneta
            {
                Nombre = "Chevrolet S10",
                Precio = 12000,
                Combustible = "Gasolina",
                Pasajeros = 6,
                Transmision = "Manual",
                Traccion = "4x4",
                Motor = "2.8L"
            });
        }

        public void CrearAuto()
        {
            int index = 0;
            foreach (CCamioneta camioneta in _ListaCamionetas)
            {

                Console.WriteLine(
                $@"Camioneta {index} 
                Precio :{camioneta.Nombre}
                Precio : {camioneta.Precio}
                Motor : {camioneta.Motor}
                Combustible : {camioneta.Combustible}
                Pasajeros : {camioneta.Pasajeros}
                Transmision : {camioneta.Transmision}
                Traccion : {camioneta.Traccion}
                ========================================================");
                index++;
            }

            Console.Write("Seleccione una camioneta: ");
            int opcion = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (opcion >= 0 && opcion < 4)
            {
                CCamioneta camionetaSeleccionada = _ListaCamionetas.ElementAt(opcion);
                Console.WriteLine(camionetaSeleccionada.ToString());

                CFactura.Precio = camionetaSeleccionada.Precio;

                CCrearFactura Factura = new CCrearFactura();
                Factura.CCrearFactura1(opcion, camionetaSeleccionada.ToString());
            }
            else
            {
                Console.WriteLine("\nOpción inválida. Intente nuevamente.");
            }

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}