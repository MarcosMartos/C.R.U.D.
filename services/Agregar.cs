
// 1. Agregar gastos
using System.Text.Json;

class Agregar
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


        // Generar ID incremental
        int nuevoId = 1;
        if (gastos.Count > 0)
        {
            nuevoId = gastos.Max(gasto => gasto.id) + 1;
        }

        gasto.id = nuevoId;
        Console.WriteLine("Descripcion: ");
        gasto.descripcion = Console.ReadLine();
        Console.WriteLine("Categoria: ");
        gasto.categoria = Console.ReadLine();
        Console.WriteLine("Monto: ");
        gasto.monto = int.Parse(Console.ReadLine());
        Console.WriteLine("Vencimiento (dd/mm/yyyy): ");
        gasto.vencimiento = DateTime.Parse(Console.ReadLine());
        gasto.estado = false;

        gastos.Add(gasto);

        // Guardar lista actualizada
        string archivoJson = JsonSerializer.Serialize(gastos, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(archivo, archivoJson);

        Console.WriteLine("Gasto agregado con éxito\n");
    }
}
