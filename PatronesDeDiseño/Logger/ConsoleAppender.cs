using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class ConsoleAppender : ILogAppender
    {

        private readonly LogLevel _minimumLevel;

        public ConsoleAppender(LogLevel minimumLevel = LogLevel.Debug)
        {
            _minimumLevel = minimumLevel;
        }

        public void Append(LogLevel level, string message)
        {
            if (level < _minimumLevel)
            {
                return; // No registrar si el nivel es menor al mínimo configurado
            }

            ConsoleColor originalColor = Console.ForegroundColor;
            try
            {
                // Asignar colores según el nivel de log para mejor visibilidad
                switch (level)
                {
                    case LogLevel.Debug:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    case LogLevel.Info:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case LogLevel.Warning:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case LogLevel.Error:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case LogLevel.Fatal:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                }
                Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] [{level.ToString().ToUpper()}] {message}");
            }
            finally
            {
                Console.ForegroundColor = originalColor; // Restaurar el color original
            }

        }
    }
}
