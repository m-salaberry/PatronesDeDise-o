namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoPrototype prototipoFiat = new FiatPrototype();
            AutoPrototype prototipoAlfa = new AlfaromeoPrototype();
            AutoPrototype prototipoDs = new DsPrototype();

            AutoPrototype fiatPalio = prototipoFiat.Clonar();
            fiatPalio.Color = "Rojo";
            fiatPalio.Modelo = "Palio Fire";
            Console.WriteLine(fiatPalio.VerAuto());

            AutoPrototype fiatCronos = prototipoFiat.Clonar();
            fiatCronos.Color = "Blanco";
            fiatCronos.Modelo = "Cronos ST";
            Console.WriteLine(fiatCronos.VerAuto());

            AutoPrototype alfaGiulia = prototipoAlfa.Clonar();
            alfaGiulia.Color = "Negro";
            alfaGiulia.Modelo = "Giulia Veloce";
            Console.WriteLine(alfaGiulia.VerAuto());

            AutoPrototype ds7 = prototipoDs.Clonar();
            ds7.Color = "Azul";
            ds7.Modelo = "DS7 Crossback";
            Console.WriteLine(ds7.VerAuto());
        }
    }
}