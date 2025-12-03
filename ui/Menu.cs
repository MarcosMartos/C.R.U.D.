
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
            case 3:
                Modificar modificar = new Modificar();
                modificar.elegirPropiedad();
                break;
            case 4: 
                Eliminar eliminar = new Eliminar();
                eliminar.eliminarGastos();
                break;
        }

        return opcion;
    }
}




