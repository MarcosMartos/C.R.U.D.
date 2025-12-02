
// 2. Listar gastos
using System.Text.Json;

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