# Proyecto Final Curso RESTful API

## Descripción
Este proyecto consiste en un proxy reverso del API del Ministerio de Hacienda. Además, se implementaron las siguientes funcionalidades:
- Middleware para el control de errores.
- Middleware para la autenticación.
- Middleware para el log de las peticiones al API.
- Método de **Login** para autenticación de usuarios.
- Método para la creación de nuevos usuarios.

El proyecto sigue una arquitectura por capas, utiliza **Dapper** como ORM y emplea **SQL Server Express** como base de datos.

## Tecnologías Utilizadas
- **.NET / C#**
- **Dapper** (ORM)
- **SQL Server Express**
- **API RESTful**

## Características
- **Proxy Reverso**: Redirección de peticiones hacia el API del Ministerio de Hacienda.
- **Middleware**: 
  - Manejo de errores centralizado.
  - Control de autenticación.
  - Log de peticiones al API.
- **Autenticación**:
  - Endpoint para login.
  - Endpoint para registro de nuevos usuarios.

## Instalación
1. Clona este repositorio.
2. Restaura el respaldo de base de datos.
3. Ajusta la cadena de conexión en el archivo appsettings.json.
