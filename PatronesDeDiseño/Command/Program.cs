namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var empresa = new EmpresaInvoker();
            var producto1 = new ProductoReceiver { Nombre = "Producto A", Cantidad = 100 };

            empresa.AgregarOrden(new BajaStockCommand(producto1, 10));

            empresa.AgregarOrden(new AltaStockCommand(producto1, 20));

            empresa.ProcesarOrdenes();
            Console.WriteLine($"Total stock es {producto1.Cantidad}");
            Console.ReadKey();
        }
    }
}