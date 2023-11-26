class CFactura
{
    public static DateTime FechaEmision { get; set; }
    public static double Precio { get; set; }
    public static double Impuesto { get; set; }
    private static double Total { get; set; }

    public static string VariablesDeUso()
    {
        FechaEmision = DateTime.Now;
        string FechaCustomisada = FechaEmision.ToString("dd/MM/yyyy 'Hora:' hh:mm tt");

        Impuesto = Precio * 0.10;
        Total = Impuesto + Precio;
        return $"\n\nFecha de creación: {FechaCustomisada}\nImpuestos: {Impuesto}\nTotal: {Total}";
    }
}