namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> _clientes;

            _clientes = new List<Cliente>
            {
                new Cliente { Nombre = "Juan Perez" },
                new Cliente { Nombre = "Maria Lopez" },
                new Cliente { Nombre = "Carlos Sanchez" }
            };

            Prestamo prestamoPersonal = new PrestamoPersonal(_clientes[0]);
            prestamoPersonal.Verificar();

            Prestamo prestamoHipotecario = new PrestamoHipotecario(_clientes[1]);
            prestamoHipotecario.Verificar();

            Prestamo prestamoPersonal2 = new PrestamoPersonal(_clientes[2]);
            prestamoPersonal2.Verificar();

        }
    }
}
