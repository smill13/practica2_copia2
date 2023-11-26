using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2_copia2.Modelos
{
    class CrearFactura
    {
        private static int númeroFactura = 0;

        //crear la factura
        public void CrearFactura1(int opcionVehiculo, string vehiculoSeleccionado)
        {
            if (opcionVehiculo == 0 || opcionVehiculo == 1 || opcionVehiculo == 2)
            {
                Console.WriteLine("\nQuiere generar una factura S/N");
                Console.Write("Seleccione: ");
                string opciondeCompra = Console.ReadLine();

                if (opciondeCompra.ToUpper() == "S")
                {
                    string nombreFactura = "Factura";
                    string rutaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    númeroFactura++;

                    string rutaArchivo = Path.Combine(rutaDocumentos, $"{nombreFactura}_{númeroFactura}.txt");

                    try
                    {
                        using (StreamWriter writer = new StreamWriter(rutaArchivo))
                        {
                            string resultado = CFactura.VariablesDeUso();
                            writer.WriteLine($"Descripción del producto\n\n{vehiculoSeleccionado.ToString()} {resultado}");
                        }

                        Console.WriteLine("\nArchivo creado correctamente en: " + rutaArchivo);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("\nError al crear el archivo: " + ex.Message);
                    }
                }
            }
        }
    }
}
