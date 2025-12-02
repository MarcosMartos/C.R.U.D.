
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
        Console.WriteLine("5. Salir");
        Console.WriteLine(" ");
        Console.WriteLine("ELIGE UNA OPCIÓN");
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Agregar agregar = new Agregar();
                agregar.agregarGasto();
                break;
            case 2:
                Mostrar mostrar = new Mostrar();
                mostrar.mostrarGastos();
                break;
        }

        return opcion;
    }
}

// Creamos una clase Gastos con sus atributos
class Gastos
{
    public int id { get; set; }
    public string descripcion { get; set; }
    public string categoria { get; set; }
    public int monto { get; set; }
    public DateTime vencimiento { get; set; }
    public bool estado { get; set; }

}

// 1. Agregar gastos
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
        Console.WriteLine(gasto.estado);

        gastos.Add(gasto);

        // Guardar lista actualizada
        string archivoJson = JsonSerializer.Serialize(gastos, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(archivo, archivoJson);

        Console.WriteLine("Gasto agregado con éxito\n");
    }
}
   
// 2. Listar gastos
class Mostrar 
{
    public void mostrarGastos()
    {
        string rutaData = "C:\\Users\\Marcos\\source\\repos\\CRUD\\data";
        string archivo = Path.Combine(rutaData, "gastos.json");

        List<Gastos> gastos = new List<Gastos>();

        if (File.Exists(archivo))
        {
            var opciones = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            string json = File.ReadAllText(archivo);
            gastos = JsonSerializer.Deserialize<List<Gastos>>(json, opciones) ?? new List<Gastos>();

            foreach (Gastos g in gastos)
            {
                Console.WriteLine(g.id);
                Console.WriteLine(g.descripcion);
                Console.WriteLine(g.categoria);
                Console.WriteLine(g.monto);
                Console.WriteLine(g.vencimiento);
                string estadoTexto = g.estado ? "Pagado" : "Pendiente";
                Console.WriteLine(estadoTexto);
                Console.WriteLine(" ");
            }
        }
        else
        {
            Console.WriteLine("Aún no hay gastos previstos.");
        }
        

    }
}



// 4. Eliminar gastos
//class Eliminar
//{
//    public void eliminarGastos(List<Gastos> gastos))
//    {

//    }
//}