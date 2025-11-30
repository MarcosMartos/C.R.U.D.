
// MOSTRAR MENU
class Menu
{
    public int opcion { get; set; }

    public int MostrarMenu()
    {
        Console.WriteLine("1. Agregar cliente");
        Console.WriteLine("2. Listar clientes");
        Console.WriteLine("3. Modificar cliente");
        Console.WriteLine("4. Eliminar cliente");
        Console.WriteLine("5. Guardar cambios");
        Console.WriteLine("6. Salir");
        Console.WriteLine(" ");
        Console.WriteLine("ELIGE UNA OPCIÓN");
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Saludar saludar = new Saludar();
                saludar.saludo();
                break;
        }

        return opcion;
    }
}