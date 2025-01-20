# Gesti�n de Veh�culos - Proyecto ASP.NET Core

�Bienvenido al proyecto de **Gesti�n de Veh�culos**! Este proyecto es una aplicaci�n web desarrollada en **ASP.NET Core**, que utiliza patrones de dise�o como **Factory Method**, **Builder**, y un repositorio en memoria para gestionar veh�culos.

Este proyecto forma parte de las tareas asignadas a Pepito, un Ingeniero de Software Junior en **Codificando Con Patrones C�a. Ltda.**. El objetivo principal es implementar y mejorar las funcionalidades de un sistema de gesti�n de autom�viles utilizando patrones de dise�o y buenas pr�cticas.

---

## **Requerimientos del Proyecto**

El proyecto cuenta con los siguientes requerimientos funcionales:

### **1. Implementar m�todos para agregar veh�culos**
- Agregar veh�culos (**Mustang** y **Explorer**) desde la p�gina principal (Home Page).
- El proyecto ya cuenta con un patr�n **Repositorio** para manejar las operaciones CRUD de autom�viles. Sin embargo, el equipo de QA ha reportado que no funciona como se espera. Es necesario revisarlo y corregirlo.

### **2. Probar funcionalidad sin conexi�n a la base de datos**
- El equipo de bases de datos indic� que el esquema de la base de datos a�n no est� listo.
- Es necesario probar las funcionalidades utilizando un repositorio **en memoria** como soluci�n temporal, para luego conectar con la base de datos una vez est� disponible.

### **3. Agregar propiedades por defecto**
- El equipo de negocio solicit� agregar el a�o actual y **20 propiedades m�s** como valores por defecto en los veh�culos.
- Implementar un patr�n de dise�o para agregar propiedades por defecto (por ejemplo, **Builder**) de manera que los cambios futuros sean m�nimos.

### **4. Implementar un patr�n Factory Method**
- El Arquitecto de Software sugiri� implementar el patr�n **Factory Method** para crear nuevos modelos de veh�culos, anticipando que se agregar�n m�s modelos en el futuro.

---

## **Implementaci�n**

El proyecto utiliza patrones de dise�o para cumplir con los requerimientos:

1. **Repositorio en memoria:**
   - Se cre� el repositorio `InMemoryVehicleRepository` para almacenar los veh�culos temporalmente sin necesidad de una base de datos.

2. **M�todos para agregar veh�culos:**
   - Se implementaron los m�todos `AddMustang` y `AddExplorer` en el `HomeController` para permitir agregar veh�culos desde la interfaz de usuario.

3. **Patr�n Builder:**
   - Se dise�� la clase `VehicleBuilder` para agregar propiedades por defecto a los veh�culos. Esto permite una f�cil extensibilidad para futuros cambios.

4. **Patr�n Factory Method:**
   - Se cre� la clase `VehicleFactory` para centralizar la creaci�n de nuevos modelos de veh�culos, facilitando la adici�n de nuevas variantes como el modelo **Escape**.

---

## **Tecnolog�as Utilizadas**

- **ASP.NET Core MVC:** Para el desarrollo de la aplicaci�n web.
- **C#:** Lenguaje principal para la implementaci�n del proyecto.
- **Bootstrap:** Framework CSS utilizado para mejorar la interfaz de usuario.
- **Patrones de Dise�o:**
  - Factory Method
  - Builder
  - Repository

---

## **Gu�a de Uso**

### **1. Agregar veh�culos**
Desde la p�gina principal, haz clic en los botones:
- **Agregar Mustang**
- **Agregar Explorer**

Esto agregar� los veh�culos seleccionados al repositorio en memoria.

### **2. Gestionar veh�culos**
- **Encender motor:** Haz clic en "Encender Motor ??" para arrancar el motor de un veh�culo.
- **Apagar motor:** Haz clic en "Apagar Motor ??" para apagar el motor.
- **Llenar tanque:** Haz clic en "Llenar Tanque ?" para a�adir gasolina.

### **3. Ver lista de veh�culos**
En la tabla de la p�gina principal podr�s ver los siguientes datos:
- Identificador (ID)
- Tipo de veh�culo
- Marca
- Modelo
- Color
- Nivel de gasolina
- Estado del motor (Encendido o Apagado)

---

## **Estructura del Proyecto**

```plaintext
DesignPatterns/
??? Controllers/          # Controladores para manejar las solicitudes HTTP
?   ??? HomeController.cs
??? Factories/            # Clase Factory Method para crear veh�culos
?   ??? VehicleFactory.cs
??? Models/               # Modelos de datos del proyecto
?   ??? Vehicle.cs
?   ??? Car.cs
?   ??? Motorcycle.cs
??? ModelBuilders/        # Clase Builder para propiedades por defecto
?   ??? VehicleBuilder.cs
??? Repositories/         # Repositorios para manejar los datos
?   ??? InMemoryVehicleRepository.cs
??? Views/                # Vistas para la interfaz de usuario
?   ??? Home/
?       ??? Index.cshtml
??? wwwroot/              # Archivos est�ticos (CSS, JS, im�genes)
??? appsettings.json      # Configuraci�n de la aplicaci�n
??? Program.cs            # Punto de entrada del proyecto
??? Startup.cs            # Configuraci�n inicial del proyecto
## Tabla de Contenidos
1. [Descripci�n](#descripci�n)
2. [Caracter�sticas](#caracter�sticas)
3. [Requisitos Previos](#requisitos-previos)
4. [Instalaci�n](#instalaci�n)
5. [Ejecuci�n](#ejecuci�n)
6. [Estructura del Proyecto](#estructura-del-proyecto)
7. [Uso](#uso)
8. [Contribuci�n](#contribuci�n)
9. [Licencia](#licencia)

## Descripci�n

Esta aplicaci�n permite gestionar veh�culos como `Mustang`, `Explorer`, y `Escape`. Los usuarios pueden:
- Agregar veh�culos a la lista.
- Encender o apagar el motor de los veh�culos.
- Llenar el tanque de gasolina.
- Ver propiedades adicionales como el a�o de fabricaci�n y otras configuraciones por defecto.

## Caracter�sticas

- **Patr�n de Dise�o Factory Method:** Crear veh�culos centralizando la l�gica de creaci�n.
- **Patr�n Builder:** A�adir propiedades por defecto a los veh�culos de forma extensible.
- **Repositorio en Memoria:** Permite pruebas sin una base de datos.
- **Interfaz de Usuario Mejorada:** Dise�o amigable con Bootstrap, emojis e im�genes.
- **Expansi�n F�cil:** Puedes agregar nuevos modelos de veh�culos r�pidamente.

## Requisitos Previos

Aseg�rate de tener lo siguiente instalado en tu m�quina:

1. **.NET Core SDK 6.0 o superior**
   - Descarga desde: [Descargar .NET](https://dotnet.microsoft.com/download)
2. **Visual Studio 2022** (o superior)
   - Incluye soporte para ASP.NET y C#.
3. **Git** (opcional, para clonar el repositorio)
   - Descarga desde: [Descargar Git](https://git-scm.com/).

## Instalaci�n

Sigue estos pasos para configurar el proyecto:

1. **Clonar el repositorio:**

   ```bash
   git clone https://github.com/tu_usuario/gestion-vehiculos.git
   cd gestion-vehiculos

## Abrir el proyecto en Visual Studio

1. **Abre el archivo de soluci�n:**
   - Localiza el archivo `DesignPatterns.sln` y �brelo en Visual Studio.

2. **Restaurar paquetes NuGet:**
   - En Visual Studio, ve a `Herramientas > Administrador de paquetes NuGet > Restaurar paquetes`.

3. **Compilar la soluci�n:**
   - En el men� principal, selecciona `Compilar > Recompilar Soluci�n`.

---

## Ejecuci�n

1. **Ejecuta la aplicaci�n desde Visual Studio:**
   - Haz clic en el bot�n **Iniciar** (o presiona `F5`).

2. **Abre tu navegador:**
   - Accede a la URL: [https://localhost:5001](https://localhost:5001)

---

## Uso

### **1. P�gina Principal**
- Accede a la p�gina principal para ver la lista de veh�culos gestionados.

### **2. Agregar Veh�culos**
- Haz clic en los botones **Agregar Mustang** o **Agregar Explorer** para a�adir veh�culos a la lista.

### **3. Gestionar Veh�culos**
Puedes realizar las siguientes acciones en cada veh�culo desde la tabla de la p�gina principal:
- **Encender Motor:** Haz clic en el bot�n **Encender Motor ??**.
- **Apagar Motor:** Haz clic en el bot�n **Apagar Motor ??**.
- **Llenar Tanque:** Haz clic en el bot�n **Llenar Tanque ?**.

---

## Contribuci�n

�Tienes ideas o mejoras? �Eres bienvenido a contribuir!

1. **Haz un fork del proyecto.**
2. **Crea una nueva rama:**
   ```bash
   git checkout -b mi-nueva-funcionalidad
