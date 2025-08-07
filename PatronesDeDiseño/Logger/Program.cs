namespace Logger
{
    class Program
    {
        static void Main (string[] args)
        {
            // --- 1. Configurar el Logger ---
            // Obtenemos la única instancia del Logger (Singleton)
            Logger logger = Logger.Instance;

            // Agregamos los adjuntadores que queremos usar
            // El ConsoleAppender registrará desde DEBUG
            logger.AddAppender(new ConsoleAppender(LogLevel.Debug));

            // El FileAppender registrará desde INFO y guardará en la carpeta 'logs'
            logger.AddAppender(new FileAppender("logs/mi_aplicacion_custom.log", LogLevel.Info));

            // --- 2. Usar el Logger ---
            try
            {
                logger.Debug("Esta es una prueba de depuración. Solo se ve si ConsoleAppender está en Debug.");
                logger.Info("La aplicación se ha iniciado correctamente.");
                logger.Info("Procesando datos para el usuario: 12345"); // Sin logging estructurado tan avanzado como Serilog aquí

                int numero1 = 10;
                int numero2 = 0;

                // Intentamos una operación que podría fallar
                try
                {
                    logger.Warning("Se ha detectado una posible división por cero. Intentando operación...");
                    int resultado = numero1 / numero2; // Esto lanzará una excepción
                    logger.Info($"El resultado de la operación es: {resultado}");
                }
                catch (DivideByZeroException ex)
                {
                    logger.Error(ex, "Se produjo un error al intentar dividir por cero."); // Registra la excepción completa
                }

                // Simular otra acción
                logger.Info($"Proceso completado para el usuario: 12345. Registros procesados: 500");

                // Un mensaje fatal, indicando un fallo irrecuperable
                // logger.Fatal("La aplicación se ha terminado debido a un error irrecuperable.");

                Console.WriteLine("\nRevisa la consola y el archivo 'logs/mi_aplicacion_custom.log' para ver los logs.");
            }
            catch (Exception ex)
            {
                // Asegurarse de que cualquier excepción no controlada sea loggeada antes de que la app termine
                logger.Fatal(ex, "Se produjo una excepción no controlada que terminó la aplicación.");
            }

            Console.WriteLine("Presiona cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}