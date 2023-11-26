class CCamioneta
{
    public string Nombre { get; set; }
    public double Precio { get; set; }
    public string Motor { get; set; }
    public string Combustible { get; set; }
    public int Pasajeros { get; set; }
    public string Transmision { get; set; }
    public string Traccion { get; set; }
    public CCamioneta() { }

    public override string ToString()
    {
        return $"Nombre: {Nombre} \nPrecio: US${Precio} \nCombustible: {Combustible} \nMotor: {Motor} \nTracción: {Traccion} \nTransmisición: {Transmision} \nPasajeros: {Pasajeros}";
    }
}