
// 3. Modificar gastos

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

    public void modificarDescripcion()
    {
        Console.WriteLine("Descripcion");
    }

    public void modificarCategoria()
    {
        Console.WriteLine("Categoria");

    }
    public void modificarMonto()
    {
        Console.WriteLine("Monto");

    }
    public void modificarVencimiento()
    {
        Console.WriteLine("Vencimiento");

    }
    public void modificarEstado()
    {
        Console.WriteLine("Estado");

    }

}
