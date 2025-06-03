namespace Composite
{   
    public class Program
    {
        public static void Main(string[] args)
        {
            // Crear archivos
            File file1 = new File("documento.txt", 1024);
            File file2 = new File("imagen.jpg", 2048);
            File file3 = new File("presentacion.pptx", 5120);
            File file4 = new File("cancion.mp3", 3072);

            // Crear carpetas
            Folder root = new Folder("MiPC");
            Folder documentsFolder = new Folder("Documentos");
            Folder photosFolder = new Folder("Fotos");
            Folder musicFolder = new Folder("Música");

            // Construir la jerarquía
            root.Add(documentsFolder);
            root.Add(photosFolder);
            root.Add(musicFolder);

            documentsFolder.Add(file1);
            documentsFolder.Add(file3);

            photosFolder.Add(file2);

            musicFolder.Add(file4);

            // Crear una subcarpeta dentro de Documentos
            Folder reportsFolder = new Folder("Informes");
            reportsFolder.Add(new File("informe_anual.pdf", 4096));
            documentsFolder.Add(reportsFolder);

            Console.WriteLine("--- Estructura del Sistema de Archivos ---");
            root.Display(0);

            Console.WriteLine("\n--- Tamaños ---");
            Console.WriteLine($"Tamaño de {file1.Name}: {file1.GetSize()} bytes");
            Console.WriteLine($"Tamaño de la carpeta '{documentsFolder.Name}': {documentsFolder.GetSize()} bytes");
            Console.WriteLine($"Tamaño de la carpeta '{root.Name}': {root.GetSize()} bytes");

            // Ejemplo de eliminar un componente
            Console.WriteLine("\n--- Eliminando 'cancion.mp3' ---");
            musicFolder.Remove(file4);
            root.Display(0);
            Console.WriteLine($"Tamaño de la carpeta '{musicFolder.Name}' después de eliminar: {musicFolder.GetSize()} bytes");
        }
    }
}