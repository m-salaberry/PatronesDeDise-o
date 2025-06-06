namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Ejemplo de Simple Factory ---");

            try
            {
                IVehiculo miCoche = VehiculoFactory.CrearVehiculo("auto");
                miCoche.Conducir();
                miCoche.Bocina();

                Console.WriteLine();

                IVehiculo miMoto = VehiculoFactory.CrearVehiculo("moto");
                miMoto.Conducir();
                miMoto.Bocina();

                Console.WriteLine();

                IVehiculo miBicicleta = VehiculoFactory.CrearVehiculo("bici");
                miBicicleta.Conducir();
                miBicicleta.Bocina();

                Console.WriteLine();

                // Intentando crear un vehículo no válido
                // IVehiculo vehiculoInvalido = VehiculoFactory.CrearVehiculo("avion");
                // vehiculoInvalido.Conducir();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}