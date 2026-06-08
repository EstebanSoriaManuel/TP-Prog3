public class PagoTransferencia : Pago
{
    public string Banco { get; set; }

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
