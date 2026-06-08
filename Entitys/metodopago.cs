public abstract class Pago
{
    public string Titular { get; set; }
    public double Monto { get; set; }

    public Pago(string titular, double monto)
    {
        Titular = titular;
        Monto = monto;
    }



    public abstract double CalcularComision();
    public abstract string ObtenerNombreMetodo();

    public void MostrarInfo()
    {
        double comision   = CalcularComision();
        double montoFinal = Monto + comision;

        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Método:  {ObtenerNombreMetodo()}");
        Console.WriteLine($"Monto original: ${Monto}");
        Console.WriteLine($"Comisión aplicada: ${comision}");
        Console.WriteLine($"Monto final: ${montoFinal}");
    }


    public void ProcesarPago()
    {
        Console.WriteLine("Procesando pago...");
        MostrarInfo();
        Console.WriteLine("Pago realizado correctamente.");
        Console.WriteLine("--------------------------------");
    }
}