namespace Repository
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("--- Demostración del Patrón Repository en Memoria ---");

            IRepository<Producto> productoRepository = new InMemoryRepository<Producto>();
            IRepository<Cliente> clienteRepository = new InMemoryRepository<Cliente>();
            
            var p1 = new Producto { Name = "Laptop", Price = 1200.99, Stock = 10 };
            var p2 = new Producto { Name = "Keyboard", Price = 75.99, Stock = 20 };

            var c1 = new Cliente { Name = "Juan", Edad = 18 };
            var c2 = new Cliente { Name = "Gaston", Edad = 23 };

            Console.WriteLine("\n--- Agregando productos ---");
            await productoRepository.AddAsync(p1);
            await productoRepository.AddAsync(p2);

            Console.WriteLine("\n--- Agregando clientes ---");
            await clienteRepository.AddAsync(c1);
            await clienteRepository.AddAsync(c2);

            Console.WriteLine("\n--- Listando ---");
            var allP = await productoRepository.GetAllAsync();
            foreach (var p in allP)
            {
                Console.WriteLine(p.ToString());
            }
            var allC = await clienteRepository.GetAllAsync();
            foreach(var c in allC)
            {
                Console.WriteLine(c.ToString());
            }

            Console.WriteLine("\n--- Modificando Nombre---");
            Cliente cToMod = await clienteRepository.GetByIdAsync(2);
            cToMod.Name = "Mariano";
            await clienteRepository.UpdateAsync(cToMod);

            Console.WriteLine("\n--- Eliminando Producto");
            Producto pToDelete = await productoRepository.GetByIdAsync(1);
            await productoRepository.DeleteAsync(pToDelete);

            Console.WriteLine("\n--- Listando ---");
            allP = await productoRepository.GetAllAsync();
            foreach (var p in allP)
            {
                Console.WriteLine(p.ToString());
            }
            allC = await clienteRepository.GetAllAsync();
            foreach (var c in allC)
            {
                Console.WriteLine(c.ToString());
            }
        }
    }
}