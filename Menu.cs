
// MOSTRAR MENU
using System.Text.Json;

class Menu
{
    public int opcion { get; set; }

    public int MostrarMenu()
    {
        Console.WriteLine("1. Agregar gastos");
        Console.WriteLine("2. Listar gastos");
        Console.WriteLine("3. Modificar gastos");
        Console.WriteLine("4. Eliminar gastos");
        Console.WriteLine("5. Guardar cambios");
        Console.WriteLine("6. Salir");
        Console.WriteLine(" ");
        Console.WriteLine("ELIGE UNA OPCIÓN");
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Agregar agregar = new Agregar();
                agregar.agregarGasto();
                break;
        }

        return opcion;
    }
}

// Creamos una clase Gastos con sus atributos
class Gastos
{
    public string descripcion { get; set; }
    public string categoria { get; set; }
    public int monto { get; set; }
    public DateTime vencimiento { get; set; }

}

// 1. Agregar gastos
class Agregar : Gastos
{

    public string rutaData = "C:\\Users\\Marcos\\source\\repos\\CRUD\\data";

    List<Gastos> gastos = new List<Gastos>();

    public void agregarGasto()
    {
        // Crear carpeta si no existe
        if (!Directory.Exists(rutaData))
        {
            Directory.CreateDirectory(rutaData);
        }

        // Combinar ruta con nombre de archivo
        string archivo = Path.Combine(rutaData, "gastos.json");

        // Leer el archivo si ya existe
        if (File.Exists(archivo))
        {
            string json = File.ReadAllText(archivo);
            gastos = JsonSerializer.Deserialize<List<Gastos>>(json) ?? new List<Gastos>();
        }

        // Crear el objeto de gasto
        Gastos gasto = new Gastos();

        Console.WriteLine("Descripcion: ");
        gasto.descripcion = Console.ReadLine();
        Console.WriteLine("Categoria: ");
        gasto.categoria = Console.ReadLine();
        Console.WriteLine("Monto: ");
        gasto.monto = int.Parse(Console.ReadLine());
        Console.WriteLine("Vencimiento (dd/mm/yyyy): ");
        gasto.vencimiento = DateTime.Parse(Console.ReadLine());

        gastos.Add(gasto);

        // Guardar lista actualizada
        string archivoJson = JsonSerializer.Serialize(gastos);
        File.WriteAllText(archivo, archivoJson);

        Console.WriteLine("Gasto agregado con éxito\n");
    }
}
   
