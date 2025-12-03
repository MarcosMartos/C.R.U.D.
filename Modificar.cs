
// 3. Modificar gastos

using System.Text.Json;

class Modificar
{
    // Inicializamos la variable de la eleccion
    public int propiedad {  get; set; }

    // Menu donde seleccionamos que propiedad cambiar
    public void elegirPropiedad()
    {
        Console.WriteLine("Elegí la propiedad a modificar: ");
        Console.WriteLine("1. Descripción");
        Console.WriteLine("2. Categoría");
        Console.WriteLine("3. Monto");
        Console.WriteLine("4. Vencimiento");
        Console.WriteLine("5. Estado");
        propiedad = int.Parse(Console.ReadLine());

        switch (propiedad)
        {
            case 1:
                modificarDescripcion();
                break;
            case 2:
                modificarCategoria();
                break;
            case 3:
                modificarMonto();
                break;
            case 4:
                modificarVencimiento();
                break;
            case 5:
                modificarEstado();
                break;
        }
    }

    // Funcion para modificar la descripción
    public void modificarDescripcion()
    {
        // Buscamos el archivo en la ruta
        string rutaData = "C:\\Users\\Marcos\\source\\repos\\CRUD\\data";
        string archivo = Path.Combine(rutaData, "gastos.json");

        List<Gastos> gastos = new List<Gastos>();

        // Verificamos que existe o lo creamos
        if (File.Exists(archivo))
        {
            var opciones = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            string json = File.ReadAllText(archivo);
            gastos = JsonSerializer.Deserialize<List<Gastos>>(json, opciones) ?? new List<Gastos>();

            Console.WriteLine("Ingrese ID del elemento a modificar: ");
            int idElemento = int.Parse(Console.ReadLine());

            var gastoEncontrado = gastos.FirstOrDefault(g => g.id == idElemento);

            if (gastoEncontrado != null)
            {
                try
                {
                    Console.WriteLine("Escriba la nueva descripción.");
                    gastoEncontrado.descripcion = Console.ReadLine();

                    Console.WriteLine("Descripción modificada correctamente.");
                }
                catch
                {
                    Console.WriteLine("Error al cambiar la descripción.");
                }
               
                string archivoJson = JsonSerializer.Serialize(gastos, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(archivo, archivoJson);
            }
            else
            {
                Console.WriteLine("No se encontró ese ID.");
            }
        }
        else
        {
            Console.WriteLine("No se encuentra un archivo de gastos.");
        }
    }


    // Funcion para modificar la categoria
    public void modificarCategoria()
    {
        // Buscamos el archivo en la ruta
        string rutaData = "C:\\Users\\Marcos\\source\\repos\\CRUD\\data";
        string archivo = Path.Combine(rutaData, "gastos.json");

        List<Gastos> gastos = new List<Gastos>();

        // Verificamos que existe o lo creamos
        if (File.Exists(archivo))
        {
            var opciones = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            string json = File.ReadAllText(archivo);
            gastos = JsonSerializer.Deserialize<List<Gastos>>(json, opciones) ?? new List<Gastos>();

            Console.WriteLine("Ingrese ID del elemento a modificar: ");
            int idElemento = int.Parse(Console.ReadLine());

            var gastoEncontrado = gastos.FirstOrDefault(g => g.id == idElemento);

            if (gastoEncontrado != null)
            {
                try
                {
                    Console.WriteLine("Escriba la nueva descripción.");
                    gastoEncontrado.categoria = Console.ReadLine();

                    Console.WriteLine("Categoría modificada correctamente.");
                }
                catch
                {
                    Console.WriteLine("Error al cambiar la categoría.");
                }

                string archivoJson = JsonSerializer.Serialize(gastos, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(archivo, archivoJson);
            }
            else
            {
                Console.WriteLine("No se encontró ese ID.");
            }
        }
        else
        {
            Console.WriteLine("No se encuentra un archivo de gastos.");
        }

    }


    // Funcion para modificar el monto
    public void modificarMonto()
    {
        // Buscamos el archivo en la ruta
        string rutaData = "C:\\Users\\Marcos\\source\\repos\\CRUD\\data";
        string archivo = Path.Combine(rutaData, "gastos.json");

        List<Gastos> gastos = new List<Gastos>();

        // Verificamos que existe o lo creamos
        if (File.Exists(archivo))
        {
            var opciones = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            string json = File.ReadAllText(archivo);
            gastos = JsonSerializer.Deserialize<List<Gastos>>(json, opciones) ?? new List<Gastos>();

            Console.WriteLine("Ingrese ID del elemento a modificar: ");
            int idElemento = int.Parse(Console.ReadLine());

            var gastoEncontrado = gastos.FirstOrDefault(g => g.id == idElemento);

            if (gastoEncontrado != null)
            {
                try
                {
                    Console.WriteLine("Escriba la nueva descripción.");
                    gastoEncontrado.monto = int.Parse(Console.ReadLine());

                    Console.WriteLine("Monto modificado correctamente.");
                }
                catch
                {
                    Console.WriteLine("Error al cambiar la monto.");
                }

                string archivoJson = JsonSerializer.Serialize(gastos, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(archivo, archivoJson);
            }
            else
            {
                Console.WriteLine("No se encontró ese ID.");
            }
        }
        else
        {
            Console.WriteLine("No se encuentra un archivo de gastos.");
        }

    }


    // Funcion para modificar el vencimiento
    public void modificarVencimiento()
    {
        Console.WriteLine("Vencimiento");

    }
    public void modificarEstado()
    {
        Console.WriteLine("Estado");

    }

}
