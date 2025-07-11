namespace Decorator
{
    class Program
    {
        static void Main (string[] args)
        {
            BebidaComponent cafe = new CafeSolo();

            cafe = new Leche(cafe);
            cafe = new Azucar(cafe);

            Console.WriteLine("Producto: " + cafe.Descripcion + ". Tiene un costo de $" + cafe.Costo);
            Console.ReadKey();

            BebidaComponent cafe2 = new CafeSinCafeina();

            cafe2 = new Crema(cafe2);
            for (int i = 2; i > 0; i--)
            {
                cafe2 = new Edulcorante(cafe2);
            }

            Console.WriteLine("Producto: " + cafe2.Descripcion + ". Tiene un costo de $" + cafe2.Costo);
            Console.ReadKey();
        }
    }
}