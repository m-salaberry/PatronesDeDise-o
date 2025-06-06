using Practica.DAL.Implementations.Memory;
using Practica.Domain.Models;

namespace Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            var ventaRepository = new VentaRepository();

            Boleto b = new Turista(402);
            Boleto b2 = new Ejecutivo(505);
            Boleto b3 = new Ejecutivo(506);

            b.FechaSalida = DateTime.Parse("20/06/2025");
            b.TiempoEnDias = 10;
            b2.FechaSalida = DateTime.Parse("15/07/2025");
            b2.TiempoEnDias = 14;
            ventaRepository.Insert(b);
            ventaRepository.Insert(b2);
            ventaRepository.Insert(b3);
            Console.WriteLine((b.CalcularRegreso()).ToString());
            Console.WriteLine(b.CostoBoleto());


            Console.WriteLine("\n--- List ---");
            foreach( var item in ventaRepository.GetAll())
            {
                Console.WriteLine($"Boleto {item.Numero} - Costo: {item.CostoBoleto()} - Fecha de Salida: {item.FechaSalida.ToShortDateString()} - Regreso: {item.CalcularRegreso().ToShortDateString()}");
            }

            Console.WriteLine("\n--- Update ---");
            b2.TiempoEnDias = 20;
            ventaRepository.Update(b2);
            Console.WriteLine(b2.TiempoEnDias);

            Console.WriteLine("\n--- Delete ---");
            ventaRepository.Delete(b);

            Console.WriteLine("\n--- List One---");
            Console.WriteLine((ventaRepository.GetById(b3.Id)).Numero);

            Console.WriteLine("\n--- List ---");
            foreach (var item in ventaRepository.GetAll())
            {
                Console.WriteLine($"Boleto {item.Numero} - Costo: {item.CostoBoleto()} - Fecha de Salida: {item.FechaSalida.ToShortDateString()} - Regreso: {item.CalcularRegreso().ToShortDateString()}");
            }



        }
    }
}