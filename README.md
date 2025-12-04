# CRUD de Gastos en C# (.NET Console App)

Este proyecto es un **CRUD (Crear, Leer, Actualizar y Eliminar)** desarrollado en **C#** como ejercicio práctico para aprender:

* Programación orientada a objetos
* Manejo de colecciones y archivos
* Serialización JSON
* Organización de un proyecto .NET real

El sistema permite gestionar una lista de gastos persistidos en un archivo JSON.

---

## 🚀 Funcionalidades

### ✔️ Crear gastos

Permite agregar un gasto con:

* Descripción
* Categoría
* Monto
* Vencimiento
* Estado

### ✔️ Listar gastos

Muestra todos los gastos guardados en el archivo `gastos.json`.

### ✔️ Modificar gastos

Permite editar propiedades específicas de un gasto:

* Descripción
* Categoría
* Monto
* Vencimiento
* Estado

### ✔️ Eliminar gastos

Elimina un gasto por ID.

### ✔️ Persistencia de datos

Los datos se guardan automáticamente en `/data/gastos.json` usando **System.Text.Json**.

---

## 📂 Estructura del proyecto

```
C.R.U.D.
├── data/                # Archivo JSON para persistencia y manejo de datos
├── models/              # Clase (Gasto)
├── services/            # Lógica CRUD y manejo JSON
├── ui/                  # Interfaz de usuario en consola
├── Program.cs           # Punto de entrada
└── C.R.U.D..csproj      # Configuración de proyecto
```

* `models/` contiene las entidades
* `services/` organiza la lógica (leer, guardar, buscar, modificar, etc)
* `ui/` contiene los menús y entrada por consola

Esta separación facilita la lectura y mantenimiento del código.

---

## 🛠️ Tecnologías usadas

* **C# 10 / .NET 10
* **System.Text.Json** para serialización
* Arquitectura simple basada en capas (Models / Services / UI)

---

## 📦 Cómo ejecutar el proyecto

### 1. Clonar el repositorio

```bash
git clone https://github.com/MarcosMartos/C.R.U.D.git
cd C.R.U.D.
```

### 2. Restaurar y compilar

```bash
dotnet restore
dotnet build
```

### 3. Ejecutar

```bash
dotnet run
```

### 4. Asegurate de que la carpeta `data/` existe

Si no existe, el programa la creará automáticamente.

---

## 📘 Ejemplo de `gastos.json`

```json
[
  {
    "id": 1,
    "descripcion": "Supermercado",
    "categoria": "Alimentos",
    "monto": 12000,
    "vencimiento": "2025-01-10",
    "estado": true
  }
]
```

---

## 🧩 Posibles mejoras futuras

Estas ideas pueden transformar este CRUD básico en un proyecto más profesional:

* ✔️ Validaciones más completas
* ✔️ Menús más amigables y reutilizables
* ✔️ Manejo de excepciones más robusto
* ✔️ Implementación de logs
* ✔️ Migrar de archivo JSON a una base de datos (SQLite o PostgreSQL)
* ✔️ Crear API REST con ASP.NET Core
* ✔️ Crear interfaz web o desktop

Estas mejoras pueden servirte para convertir este CRUD en un proyecto de portafolio más completo.

---

## 📄 Licencia

Proyecto abierto. Puedes usarlo, modificarlo o expandirlo libremente.

---

## 👤 Autor

**Marcos Martos**

Proyecto desarrollado para aprender C# y como parte del portafolio inicial.
