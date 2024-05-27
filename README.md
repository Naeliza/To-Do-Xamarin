# To-Do Xamarin

## Descripción
To-Do Xamarin es una aplicación móvil multiplataforma desarrollada con Xamarin.Forms. Permite a los usuarios crear, editar y eliminar tareas, proporcionando una forma sencilla y efectiva de gestionar listas de tareas diarias.

## Características
- **Crear Tareas**: Añadir nuevas tareas con nombre y descripción.
- **Editar Tareas**: Modificar tareas existentes.
- **Eliminar Tareas**: Eliminar tareas de la lista.
- **Persistencia de Datos**: Las tareas se almacenan en una base de datos SQLite local.

## Instalación
1. Clona el repositorio:
   ```bash
   git clone https://github.com/Naeliza/To-Do-Xamarin.git

2. Abre el archivo de solución toDo.sln en Visual Studio.

## Configuración

Asegúrate de tener instaladas las siguientes herramientas:

Visual Studio

- Xamarin
- SDK de Android (si compilas para Android)
- SDK de iOS (si compilas para iOS)

## Uso

Compila y ejecuta el proyecto usando Visual Studio.

1. La aplicación se iniciará, mostrando la página principal con una lista de tareas.
2. Usa el botón "Agregar Tarea" para crear una nueva tarea.
3. Toca una tarea existente para editarla o eliminarla.

## Estructura del Código

- Models: Contiene la clase Tarea, que representa una tarea.
- Views: Contiene las páginas de la interfaz de usuario, incluyendo MainPage y TaskDetailPage.
- Services: Contiene la clase TareaDatabase, que maneja las operaciones de la base de datos.

## Base de Datos

- La aplicación utiliza SQLite para el almacenamiento local de datos.
- El archivo de la base de datos tareas.db se crea y gestiona dentro de la aplicación.
