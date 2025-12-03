using System.Text.Json;

class GastosRepository
{
    private string archivo = "gastos.json";


    // FUNCION CARGAR DATOS
    public List<Gastos> CargarGastos()
    {
        if (!File.Exists(archivo))
        {
            return new List<Gastos>();
        }

        var opciones = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        string json = File.ReadAllText(archivo);
        return JsonSerializer.Deserialize<List<Gastos>>(json, opciones) ?? new List<Gastos>();
    }


    // FUNCION GUARDAR DATOS
    public void GuardarGastos(List<Gastos> gastos)
    {
        string json = JsonSerializer.Serialize(gastos, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(archivo, json);
    }
}
