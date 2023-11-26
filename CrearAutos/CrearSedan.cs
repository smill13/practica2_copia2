using practica2_copia2.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2_copia2.Autos
{
    class CrearSedan : Vehiculos
    {
        //creacion Lista 
        private static HashSet<CSedan> _ListaSedan = new HashSet<CSedan>();

        //Crear autos
        public CrearSedan()
        {
            CSedan sedan1 = new CSedan()
            {
                Nombre = "Model S",
                Precio = 300000,
                Combustible = "Eléctrico",
                Pasajeros = 5,
                Transmision = "Automática",
                Traccion = "Trasera y total (con motor dual)",
                Motor = "Eléctrico trasero de 476 CV y  delantero de 224"
            };

            CSedan sedan2 = new CSedan()
            {
                Nombre = "Citroën C-4 2024",
                Precio = 300000,
                Combustible = "Gasolina",
                Pasajeros = 5,
                Transmision = "Automática",
                Traccion = "Delantera",
                Motor = "4 cilindros"
            };

            CSedan sedan3 = new CSedan()
            {
                Nombre = "Audi A4 Turbo S-Line",
                Precio = 3000000,
                Motor = "2.0, 4 cilindros, Turbo",
                Combustible = "Gasolina",
                Pasajeros = 5,
                Transmision = "Automática",
                Traccion = "2WD",
            };

            //añadir elementos
            _ListaSedan.Add(sedan1);
            _ListaSedan.Add(sedan2);
            _ListaSedan.Add(sedan3);

        }

        public void CrearAuto()
        {

            int index = 0;
            foreach (CSedan sedan in _ListaSedan)
            {

                Console.WriteLine(
                $@"Sedan {index} 
                Nombre :{sedan.Nombre}
                Precio : {sedan.Precio}
                Motor : {sedan.Motor}
                Combustible : {sedan.Combustible}
                Pasajeros : {sedan.Pasajeros}
                Transmision : {sedan.Transmision}
                Traccion : {sedan.Traccion}
                ========================================================");
                index++;
            }

            Console.Write("Seleccione un Sedan: ");
            int opcionSedan = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (opcionSedan >= 0 && opcionSedan < 4)
            {
                CSedan sedanSeleccionado = _ListaSedan.ElementAt(opcionSedan);
                Console.WriteLine(sedanSeleccionado.ToString());

                CFactura.Precio = sedanSeleccionado.Precio;

                CCrearFactura Factura = new CCrearFactura();
                Factura.CCrearFactura1(opcionSedan, sedanSeleccionado.ToString());
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
