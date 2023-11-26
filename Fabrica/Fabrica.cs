using practica2_copia2.Autos;
using practica2_copia2.CrearAutos;

class CFabrica
{
    private static CrearCamioneta camionetaInstance;
    private static CrearDeportivo deportivoIntace;
    private static CrearSedan sedanIntance;
    private static CrearMoto motoIntace;

    public static Vehiculos GetVehiculos(int opcion)
    {
        try
        {
            if (opcion == 1)
            {
                sedanIntance ??= new CrearSedan();
                return sedanIntance;

            }
            else if (opcion == 2)
            {
                motoIntace ??= new CrearMoto();
                return motoIntace;

            }
            else if (opcion == 3)
            {
                deportivoIntace ??= new CrearDeportivo();
                return deportivoIntace;
            }
            else if (opcion == 4)
            {
                camionetaInstance ??= new CrearCamioneta();
                return camionetaInstance;
            }
            else { throw new Exception("Opción no válida."); }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
    }
}