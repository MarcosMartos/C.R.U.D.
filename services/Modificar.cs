
// 3. Modificar gastos

using System.Text.Json;

class Modificar
{
    // Inicializamos la variable de la eleccion
    public int propiedad {  get; set; }
    private GastosRepository repo = new GastosRepository();

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
                ModificarDescripcion();
                break;
            case 2:
                ModificarCategoria();
                break;
            case 3:
                ModificarMonto();
                break;
            case 4:
                ModificarVencimiento();
                break;
            case 5:
                ModificarEstado();
                break;
        }
    }

    // Funcion para modificar la descripción
    public void ModificarDescripcion()
    {
        var gastos = repo.CargarGastos();

        Console.WriteLine("Ingrese ID del elemento a modificar: ");
        int idElemento = int.Parse(Console.ReadLine());

        var gasto = gastos.FirstOrDefault(g => g.id == idElemento);

        if (gasto == null)
        {
            Console.WriteLine("No se encontró ese ID.");
            return;
        }

        Console.WriteLine("Escriba la nueva descripción:");
        gasto.descripcion = Console.ReadLine();

        repo.GuardarGastos(gastos);
        Console.WriteLine("Descripción modificada correctamente.");
    }

    // Funcion para modificar la categoria
    public void ModificarCategoria()
    {
        var gastos = repo.CargarGastos();

        Console.WriteLine("Ingrese ID del elemento a modificar: ");
        int idElemento = int.Parse(Console.ReadLine());

        var gasto = gastos.FirstOrDefault(g => g.id == idElemento);

        if (gasto == null)
        {
            Console.WriteLine("No se encontró ese ID.");
            return;
        }

        Console.WriteLine("Escriba la nueva categoría:");
        gasto.categoria = Console.ReadLine();

        repo.GuardarGastos(gastos);
        Console.WriteLine("Categoría modificada correctamente.");
    }


    // Funcion para modificar el monto
    public void ModificarMonto()
    {
        var gastos = repo.CargarGastos();

        Console.WriteLine("Ingrese ID del elemento a modificar: ");
        int idElemento = int.Parse(Console.ReadLine());

        var gasto = gastos.FirstOrDefault(g => g.id == idElemento);

        if (gasto == null)
        {
            Console.WriteLine("No se encontró ese ID.");
            return;
        }

        Console.WriteLine("Escriba el nuevo monto:");
        gasto.monto = int.Parse(Console.ReadLine());

        repo.GuardarGastos(gastos);
        Console.WriteLine("Monto modificado correctamente.");
    }

    // Funcion para modificar el vencimiento
    public void ModificarVencimiento()
    {
        var gastos = repo.CargarGastos();

        Console.WriteLine("Ingrese ID del elemento a modificar: ");
        int idElemento = int.Parse(Console.ReadLine());

        var gasto = gastos.FirstOrDefault(g => g.id == idElemento);

        if (gasto == null)
        {
            Console.WriteLine("No se encontró ese ID.");
            return;
        }

        Console.WriteLine("Escriba el nuevo vencimiento (dd/mm/aa):");
        gasto.vencimiento = DateTime.Parse(Console.ReadLine());

        repo.GuardarGastos(gastos);
        Console.WriteLine("Vencimiento modificado correctamente.");
    }

    // Funcion para modificar el estado (Pagado)
    public void ModificarEstado()
    {
        var gastos = repo.CargarGastos();


        Console.WriteLine("Ingrese ID del elemento a modificar: ");
        int idElemento = int.Parse(Console.ReadLine());

        var gasto = gastos.FirstOrDefault(g => g.id == idElemento);

        if (gasto == null)
        {
            Console.WriteLine("No se encontró ese ID.");
            return;
        }

        gasto.estado = !gasto.estado;

        repo.GuardarGastos(gastos);
        Console.WriteLine("Estado modificado correctamente.");

    }
    

    }


