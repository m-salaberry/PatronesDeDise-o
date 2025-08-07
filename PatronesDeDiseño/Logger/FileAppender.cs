using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class FileAppender: ILogAppender
    {

        private readonly string _filePath;
        private readonly LogLevel _minimumLevel;
        private readonly object _lock = new object(); // Para sincronizar el acceso al archivo

        public FileAppender(string filePath, LogLevel minimumLevel = LogLevel.Info)
        {
            _filePath = filePath;
            _minimumLevel = minimumLevel;

            // Asegurarse de que el directorio exista
            string directory = Path.GetDirectoryName(_filePath)!;
            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }

        public void Append(LogLevel level, string message)
        {
            if (level < _minimumLevel)
            {
                return; // No registrar si el nivel es menor al mínimo configurado
            }

            string logEntry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{level.ToString().ToUpper()}] {message}";

            // Usar un bloqueo para evitar que múltiples hilos escriban al mismo tiempo
            lock (_lock)
            {
                try
                {
                    File.AppendAllText(_filePath, logEntry + Environment.NewLine);
                }
                catch (Exception ex)
                {
                    // En un logger real, aquí podrías tener un mecanismo de logging de emergencia
                    // para notificar que el FileAppender no pudo escribir.
                    Console.Error.WriteLine($"ERROR: No se pudo escribir en el archivo de log {_filePath}. {ex.Message}");
                }
            }
        }

    }
}
