namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Paquetes mipaquete = new PaqueteGeneral(new MedioCamion());
            mipaquete.entrega();

            Paquetes mipaquete2 = new PaqueteFragil(new MedioMiniFlete());
            mipaquete2.entrega();
        }
    }
}