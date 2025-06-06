using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public static class VehiculoFactory
    {

        public static IVehiculo CrearVehiculo (string tipo)
        {
            switch (tipo.ToLower())
            {
                case "auto":
                    return new Auto();
                case "moto":
                    return new Moto();
                case "bici":
                    return new Bicicleta();
                default:
                    throw new Exception("Tipo de vehiculo invalido");
            }
        }

    }
}
