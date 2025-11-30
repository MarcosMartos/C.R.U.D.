/*
 3. **Mini sistema CRUD simple (sin base de datos real)**
    - Implementar un menú en consola con opciones como “Agregar cliente”,
    “Listar clientes”, “Modificar cliente”, “Eliminar cliente”, “Guardar cambios en archivo”. 
    Esto te obliga a pensar en estructura de datos, persistencia simple y lógica.
 */

using System.Security.Cryptography.X509Certificates;

class CRUD
{
    public static void Main(string[] args)
    {
        // Instanciamos las clases de la app
         Menu menu = new Menu();

        // Llamamos a los métodos de la app
         menu.MostrarMenu();

    }
}

