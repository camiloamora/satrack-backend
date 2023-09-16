## Getting Started

Para ejecutar el proyecto, primero se debe tener instalado el SDK de .net core v7.0:

```bash
dotnet build
```
Para ejecutar el proyecto y verlo en el navegador con este comando:

```bash
dotnet run
```

*  El proyecto cuenta con los siguientes recursos para ser ejecutados:
*  Get para obtener todos los registros de la base de datos filtrados por un unico usuario (versión inicial)
*  Post para crear un nuevo recurso (tarea)
*  Patch para actualizar parcialmente un registro de la base de datos
*  Delete para borrar un registro de la base de datos

Abrir [[http://localhost:3000](http://localhost:5274/v1/todos)](http://localhost:5274/v1/todos) con un programa como postman para ejecutar el api

Para la base de datos la url esta configurada en el archivo  ./apps/Todo/Backend/appsettings.json

## Información para la conexión con la api

Se tiene configurada una base de datos Mongo Atlas, unicamente funciona con las ips configuradas (Azure, mi local):

- La estructura del proyecto se basa en arquitecturas limpias tomando como unidad de negocio las "todo"

Mejoras a implementar:
*  Registro de usuarios (autenticación) para tener sus propias tareas
*  CRUD para la creación de categorias
*  Creación de pipeline para despliegue y compilación
*  Completar las pruebas unitarias
*  Hacer las mejoras sugeridas por sonar

