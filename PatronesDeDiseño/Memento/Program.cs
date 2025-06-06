namespace Memento
{
    class Program
    {
        static CareTaker careTaker = new CareTaker();
        static void Main(string[] args)
        {
            var p = new Persona();
            p.Nombre = "Pepe";

            careTaker.Add(p.saveToMemento());

            p.Nombre = "Pepe1";
            careTaker.Add(p.saveToMemento());

            p.Nombre = "Pepe2";
            careTaker.Add(p.saveToMemento());

            Memento m1 = careTaker.GetMemento(0);

            Console.WriteLine("Viendo memento 1: " + m1.Estado);
            Console.WriteLine("Viendo memento 2: " + careTaker.GetMemento(1).Estado);
            Console.WriteLine("Viendo memento 3: " + careTaker.GetMemento(2).Estado);

            Console.WriteLine("\n------");
            Console.WriteLine(p.Nombre);
            p.restoreToMemento(m1);
            Console.WriteLine(p.Nombre);

        }
    }
}