using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class Logger
    {

        // Singleton pattern: Aseguramos que solo haya una instancia del Logger
        private static readonly Lazy<Logger> _instance =
            new Lazy<Logger>(() => new Logger());

        public static Logger Instance => _instance.Value;

        private readonly List<ILogAppender> _appenders;

        private Logger()
        {
            _appenders = new List<ILogAppender>();
        }

        /// <summary>
        /// Agrega un adjuntador al logger.
        /// </summary>
        /// <param name="appender">La implementación de ILogAppender (ej. ConsoleAppender, FileAppender).</param>
        public void AddAppender(ILogAppender appender)
        {
            if (appender == null)
            {
                throw new ArgumentNullException(nameof(appender));
            }
            _appenders.Add(appender);
        }

        /// <summary>
        /// Método privado para procesar el mensaje de log a todos los adjuntadores.
        /// </summary>
        /// <param name="level">Nivel de severidad del log.</param>
        /// <param name="message">Mensaje a registrar.</param>
        private void Log(LogLevel level, string message)
        {
            foreach (var appender in _appenders)
            {
                appender.Append(level, message);
            }
        }

        // Métodos de conveniencia para cada nivel de log
        public void Debug(string message) => Log(LogLevel.Debug, message);
        public void Info(string message) => Log(LogLevel.Info, message);
        public void Warning(string message) => Log(LogLevel.Warning, message);
        public void Error(string message) => Log(LogLevel.Error, message);
        public void Fatal(string message) => Log(LogLevel.Fatal, message);

        // Opcional: Para registrar excepciones
        public void Error(Exception ex, string message) => Log(LogLevel.Error, $"{message} {ex.GetType().Name}: {ex.Message}{Environment.NewLine}{ex.StackTrace}");
        public void Fatal(Exception ex, string message) => Log(LogLevel.Fatal, $"{message} {ex.GetType().Name}: {ex.Message}{Environment.NewLine}{ex.StackTrace}");
    }
}

