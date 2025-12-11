# AppPYLL - Sistema de Gestión Administrativa

## Descripción

**AppPYLL** es una aplicación web diseñada para optimizar la administración contable y operativa de un negocio de logística y correo. 

El objetivo principal del sistema es digitalizar el seguimiento de ingresos y egresos, gestionar datos de clientes y proveer un control financiero claro y eficiente, reemplazando procesos manuales y reduciendo errores administrativos.

## Funcionalidades Principales

* **Gestión de Gastos:** Registro detallado de egresos operativos y administrativos.
* **Gestión de Usuarios:** Sistema de autenticación para restringir acceso a información sensible.
* **Reportes:** Visualización de datos para la toma de decisiones.

## Tecnologías Utilizadas

Este proyecto fue desarrollado siguiendo patrones de arquitectura limpia y buenas prácticas de desarrollo.

**Backend:**
* **C# / ASP.NET Core MVC:** Framework principal.
* **Entity Framework Core:** ORM para el manejo de datos.
* **LINQ:** Consultas eficientes a la base de datos.

**Base de Datos:**
* **PostgreSQL:** Base de datos relacional.

**Frontend:**
* **Razor Views:** Motor de plantillas.
* **Bootstrap 5:** Para el diseño visual.
* **jQuery / JavaScript:** Lógica del lado del cliente y manipulación del DOM.

## Instalación y Configuración

Sigue estos pasos para ejecutar el proyecto en tu entorno local:

1.  **Clonar el repositorio:**
    ```bash
    git clone https://github.com/Zeta279/AppPYLL
    cd AppPYLL
    ```

2.  **Configurar la Base de Datos:**
    * Asegúrate de tener **PostgreSQL** instalado y corriendo.
    * Renombra el archivo `appsettings.Example.json` a `appsettings.json`.
    * Edita la cadena de conexión (`ConnectionStrings`) con tus credenciales locales de Postgres.

3.  **Aplicar Migraciones (EF Core):**
    Este proyecto utiliza *Code First*. Para generar la base de datos, ejecuta:
    ```bash
    dotnet ef database update
    ```

4.  **Ejecutar la aplicación:**
    ```bash
    dotnet run
    ```
    La aplicación estará disponible en `http://localhost:5xxx` (o el puerto configurado).

## Estructura del Proyecto

* `/Controllers`: Lógica de control y manejo de peticiones HTTP.
* `/Models`: Definición de entidades y reglas de negocio.
* `/Views`: Interfaz de usuario (Razor).
* `/Data`: Contexto de base de datos y configuraciones de EF Core.

## Autor

**Ezequiel Acosta Baca**
* LinkedIn: [Perfil](https://www.linkedin.com/in/ezequiel-acosta-baca/)

---