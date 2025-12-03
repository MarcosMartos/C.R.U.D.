
// 4. Eliminar gastos
using System.Text.Json;

class Eliminar
{
    public void eliminarGastos()
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

            Console.WriteLine("Ingrese ID del elemento a borrar: ");
            int idABorrar = int.Parse(Console.ReadLine());

            var gastoAEliminar = gastos.FirstOrDefault(g => g.id == idABorrar);

            if (gastoAEliminar != null)
            {
                gastos.Remove(gastoAEliminar);
                Console.WriteLine("Gasto eliminado correctamente.");

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
}