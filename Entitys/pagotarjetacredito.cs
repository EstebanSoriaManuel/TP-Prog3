public class PagoTarjetaCredito : Pago
{
    private int cuotas;
    public int Cuotas { get {return this.cuotas;} set {this.cuotas = value;} }

    public PagoTarjetaCredito(string titular, double monto, int cuotas): base(titular, monto)
    {
        Cuotas = cuotas;
    }



    public override string ObtenerNombreMetodo()
    {
        return $"Tarjeta de Crédito ({Cuotas} cuotas)";
    }


    public override double CalcularComision()
    {
        return Monto * 0.08;
    }
}
