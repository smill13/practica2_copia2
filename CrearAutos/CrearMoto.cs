using practica2_copia2.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2_copia2.Autos
{
    class CrearMoto : Vehiculos
    {

        //creacion Lista 
        private static HashSet<CMoto> _ListaMoto = new HashSet<CMoto>();

        //Crear autos
        public CrearMoto()
        {
            CMoto moto1 = new CMoto()
            {
                Nombre = "Honda CBR650R",
                Precio = 950000,
                Freno = "ABS",
                Peso = "208 kg",
                Capacidad = "2 personas",
                Dimensiones = "2130mm x 750mm x 1149mm",
                Transmision = "6 velocidades"
            };

            CMoto moto2 = new CMoto()
            {
                Nombre = "Kawasaki Ninja 400",
                Precio = 500000,
                Freno = "ABS",
                Peso = "167 kg",
                Capacidad = "2 personas",
                Dimensiones = "1990mm x 710mm x 1120mm",
                Transmision = "6 velocidades"
            };

            CMoto moto3 = new CMoto()
            {
                Nombre = "Yamaha YZF-R6",
                Precio = 1200000,
                Freno = "ABS",
                Peso = "190 kg",
                Capacidad = "2 personas",
                Dimensiones = "2050mm x 690mm x 1140mm",
                Transmision = "6 velocidades"
            };

            //añadir elementos
            _ListaMoto.Add(moto1);
            _ListaMoto.Add(moto2);
            _ListaMoto.Add(moto3);
        }

        public void CrearAuto()
        {
            int index = 0;
            foreach (CMoto moto in _ListaMoto)
            {

                Console.WriteLine(
                $@"Deportivo {index} 
                Nombre :{moto.Nombre}
                Precio : {moto.Precio}
                Freno : {moto.Freno}
                Capacidad : {moto.Capacidad}
                Dimensiones : {moto.Dimensiones}
                Transmision : {moto.Transmision}
                Peso : {moto.Peso}
                ========================================================");
                index++;
            }

            Console.Write("Seleccione una moto: ");

            int opcion = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (opcion >= 0 && opcion < 4)
            {
                CMoto motoSeleccionada = _ListaMoto.ElementAt(opcion);
                Console.WriteLine(motoSeleccionada.ToString());

                CFactura.Precio = motoSeleccionada.Precio;

                CrearFactura Factura = new CrearFactura();
                Factura.CrearFactura1(opcion, motoSeleccionada.ToString());
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
