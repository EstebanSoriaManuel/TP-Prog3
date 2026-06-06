public abstract class Pago
{
    private string titular;
    private double monto;

    public string Titular { get {return this.titular;} set {this.titular = value;} }
    public double Monto   { get {return this.monto;} set {this.monto = value;} }

    public Pago(string titular, double monto)
    {
        Titular = titular;
        Monto   = monto;
    }



    public abstract double CalcularComision();
    public abstract string ObtenerNombreMetodo();

    public void MostrarInfo()
    {
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Método:  {ObtenerNombreMetodo()}");
        Console.WriteLine($"Monto original: ${Monto}");
    }


    public void ProcesarPago()
    {
        MostrarInfo();
        Console.WriteLine("Procesando pago...");

        double comision   = CalcularComision();
        double montoFinal = Monto + comision;

        Console.WriteLine($"Comisión aplicada: ${comision}");
        Console.WriteLine($"Monto final: ${montoFinal}");
        Console.WriteLine("Pago realizado correctamente.");
        Console.WriteLine("--------------------------------");
    }
}