public class PagoTransferencia : Pago
{
    private string banco;
    public string Banco { get { return this.banco; } set { this.banco = value; } }

    public PagoTransferencia(string titular, double monto, string banco) : base(titular, monto)
    {
        Banco = banco;
    }



    public override string ObtenerNombreMetodo()
    {
        return $"Transferencia Bancaria - {Banco}";
    }


    public override double CalcularComision()
    {
        return 500;
    }
}
