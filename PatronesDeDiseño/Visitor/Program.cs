namespace Visitor
{
    class Progra
    {
        static void Main(string[] args)
        {
            IVisitor visitor = new VisitanteConcreto();
            
            Componente hdd = new DiscoDuro("HDD12345");
            Componente cpu = new Procesador("CPU12345");
            Componente mb = new Motherboard("MB12345");

            hdd.Accept(visitor);
            cpu.Accept(visitor);
            mb.Accept(visitor);

            Console.ReadKey();
        }
    }
}