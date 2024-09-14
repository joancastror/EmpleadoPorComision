using System;

// Definición de la clase EmpleadoPorComision
public class EmpleadoPorComision
{
    private string primerNombre;
    private string apellidoPaterno;
    private string numeroSeguroSocial;
    private decimal ventasBrutas; // Ventas semanales totales
    private decimal tarifaComision; // Porcentaje de comisión

    public EmpleadoPorComision(string nombre, string apellido, string nss, decimal ventas, decimal tarifa)
    {
        primerNombre = nombre;
        apellidoPaterno = apellido;
        numeroSeguroSocial = nss;
        VentasBrutas = ventas; // Valida las ventas brutas mediante una propiedad
        TarifaComision = tarifa; // Valida la tarifa de comisión mediante una propiedad
    }

    public string PrimerNombre
    {
        get { return primerNombre; }
    }

    public string ApellidoPaterno
    {
        get { return apellidoPaterno; }
    }

    public string NumeroSeguroSocial
    {
        get { return numeroSeguroSocial; }
    }

    public decimal VentasBrutas
    {
        get { return ventasBrutas; }
        set { ventasBrutas = (value < 0) ? 0 : value; }
    }

    public decimal TarifaComision
    {
        get { return tarifaComision; }
        set { tarifaComision = (value > 0 && value < 1) ? value : 0; }
    }

    public decimal Ingresos()
    {
        return tarifaComision * ventasBrutas;
    }

    public override string ToString()
    {
        return string.Format(
            "{0}: {1} {2}\n{3}: {4}\n{5}: {6:C}\n{7}: {8:F2}",
            "Empleado por comisión", PrimerNombre, ApellidoPaterno,
            "Número de seguro social", NumeroSeguroSocial,
            "Ventas brutas", VentasBrutas, "Tarifa de comisión", TarifaComision);
    }
}

// Definición de la clase PruebaEmpleadoPorComision
public class PruebaEmpleadoPorComision
{
    public static void Main(string[] args)
    {
        // crea instancia de objeto EmpleadoPorComision
        EmpleadoPorComision empleado = new EmpleadoPorComision("Sue", "Jones", "222-22-2222", 10000.00M, 0.06M);
        // muestra datos del empleado por comisión
        Console.WriteLine("Información del empleado obtenida por las propiedades y los métodos:\n");
        Console.WriteLine("{0} {1}", "El primer nombre es", empleado.PrimerNombre);
        Console.WriteLine("{0} {1}", "El apellido es", empleado.ApellidoPaterno);
        Console.WriteLine("{0} {1}", "El número de seguro social es", empleado.NumeroSeguroSocial);
        Console.WriteLine("{0} {1:C}", "Las ventas brutas son", empleado.VentasBrutas);
        Console.WriteLine("{0} {1:F2}", "La tarifa de comisión es", empleado.TarifaComision);
        Console.WriteLine("{0} {1:C}", "Los ingresos son", empleado.Ingresos());

        empleado.VentasBrutas = 5000.00M; // establece las ventas brutas
        empleado.TarifaComision = 0.1M; // establece la tarifa de comisión

        Console.WriteLine("\n{0}:\n\n{1}", "Se actualizó la información del empleado obtenida por ToString", empleado);
        Console.WriteLine("Ingresos: {0:C}", empleado.Ingresos());
    }// fin de Main
} // fin de la clase PruebaEmpleadoPorComision
