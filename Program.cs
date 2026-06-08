class Program
{
    static List<Pago> pagosRealizados = new List<Pago>();
    static void Main()
    {
        int opcion = 1;


        do
        {
            Console.WriteLine("Sistema de gestion de pagos");

        Console.WriteLine(@"¿Que accion desea realizar?
        1. realizar un pago
        2. mostrar pagos realizados
        0. salir");
        opcion = int.Parse(Console.ReadLine());

        switch(opcion)
        {
            case 1:
                RealizarPago();
            break;
            case 2:
                MostrarPagosRealizados();
            break;
            case 0:
            Console.WriteLine("Saliendo del programa...");
            break;
            default:
            Console.WriteLine("Opcion no valida, intente nuevamente.");
            break;
        }

        }while(opcion != 0);
    }


    static void RealizarPago()
    {
        Console.WriteLine("Seleccione el método de pago:");
        Console.WriteLine("1. Tarjeta de Crédito");
        Console.WriteLine("2. Transferencia Bancaria");
        int metodo = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el nombre del titular:");
        string titular = Console.ReadLine();

        Console.WriteLine("Ingrese el monto a pagar:");
        double monto = double.Parse(Console.ReadLine());

        Pago nuevoPago;

        switch (metodo)
        {
            case 1:
                Console.WriteLine("Ingrese la cantidad de cuotas:");
                int cuotas = int.Parse(Console.ReadLine());
                nuevoPago = new PagoTarjetaCredito(titular, monto, cuotas);
                break;
            case 2:
                Console.WriteLine("Ingrese el nombre del banco:");
                string banco = Console.ReadLine();
                nuevoPago = new PagoTransferencia(titular, monto, banco);
                break;
            default:
                Console.WriteLine("Método de pago no válido.");
                return;
        }

        nuevoPago.ProcesarPago();
        pagosRealizados.Add(nuevoPago);
    }

    static void MostrarPagosRealizados()
    {
        if (pagosRealizados.Count == 0)
        {
            Console.WriteLine("No se han realizado pagos aún.");
            return;
        }
        else
        {
            Console.WriteLine("Pagos realizados:");
            foreach (var pago in pagosRealizados)
            {
                pago.MostrarInfo();
                Console.WriteLine(@"
                --------------------------------
                ");
            }
        }

        
    }
}
