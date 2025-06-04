using ObserverBattaglia;

namespace Observer
{
    class Program
    {
        static void Main(string[] args) 
        {
            var user1 = new Usuario("Adrian", "Martinez");
            var user2 = new Usuario("Maximiliano", "Salas");

            var p1 = new Producto("OneDrive", 10);
            var p2 = new Producto("Spotify", 5);
            var p3 = new Producto("Netflix", 30);

            p1.Agregar(user1);
            p1.Agregar(user2);

            p2.Agregar(user1);
            p2.Agregar(user2);

            p3.Agregar(user1);

            p1.Precio = 15;

            p2.Quitar(user2);

            p2.Precio = 2.5;

            p3.Precio = 40;
        }
    }
}