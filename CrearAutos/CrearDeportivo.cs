using practica2_copia2.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2_copia2.CrearAutos
{
    class CrearDeportivo : Vehiculos
    {
        private static CDeportivo _deportivo = new();

        //creacion Lista 
        private static HashSet<CDeportivo> _ListaDeportivo = new HashSet<CDeportivo>();

        //Crear autos
        public CrearDeportivo()
        {
            CDeportivo deportivo1 = new CDeportivo()
            {
                Precio = 225000,
                Nombre = "Porsche 911 Carrera",
                Motor = "3.0, 6 cilindros, Turbo",
                Combustible = "Gasolina",
                Pasajeros = 4,
                Transmision = "Automática",
                Traccion = "Trasera",
            };

            CDeportivo deportivo2 = new CDeportivo()
            {
                Precio = 110950,
                Nombre = "Ford Mustang Mach-E",
                Combustible = "Electrico",
                Pasajeros = 5,
                Transmision = "Automática",
                Traccion = "AWD",
                Motor = "Eléctrico"
            };

            CDeportivo deportivo3 = new CDeportivo()
            {
                Precio = 750000,
                Nombre = "Ferrari SF90 Stradale",
                Motor = "8 cilindros",
                Combustible = "Gasolina",
                Pasajeros = 2,
                Transmision = "Automática",
                Traccion = "AWD",
            };

            //añadir elementos
            _ListaDeportivo.Add(deportivo1);
            _ListaDeportivo.Add(deportivo2);
            _ListaDeportivo.Add(deportivo3);

        }

        public void CrearAuto()
        {
            int index = 0;
            foreach (CDeportivo deportivo in _ListaDeportivo)
            {

                Console.WriteLine(
                $@"Deportivo {index} 
                Precio :{deportivo.Nombre}
                Precio : {deportivo.Precio}
                Motor : {deportivo.Motor}
                Combustible : {deportivo.Combustible}
                Pasajeros : {deportivo.Pasajeros}
                Transmision : {deportivo.Transmision}
                Traccion : {deportivo.Traccion}
                ========================================================");
                index++;
            }

            Console.Write("Seleccione una deportivo: ");
            int opcion = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (opcion >= 0 && opcion < 4)
            {
                CDeportivo deportivoSeleccionado = _ListaDeportivo.ElementAt(opcion);
                Console.WriteLine(deportivoSeleccionado.ToString());

                CFactura.Precio = deportivoSeleccionado.Precio;

                CCrearFactura Factura = new CCrearFactura();
                Factura.CCrearFactura1(opcion, deportivoSeleccionado.ToString());
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
