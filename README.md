# BuccalMedic - Sistema de Gestión Odontológica

Un sistema completo de gestión para consultorios dentales desarrollado en C# con arquitectura de tres capas, diseñado para optimizar la administración de pacientes, citas y tratamientos odontológicos.

## 🚀 Características Principales

### 👥 Gestión de Empleados
- **Roles diferenciados**: Recepcionistas y Odontólogos con permisos específicos
- **Sistema de autenticación** seguro con usuarios y contraseñas
- **Búsqueda avanzada** por ID, nombre o credenciales de login

### 📅 Gestión de Citas
- **Programación flexible** de citas con diferentes tipos (consulta, tratamiento)
- **Filtrado avanzado** por paciente, odontólogo, fecha y estado
- **Historial completo** de citas por empleado y paciente

### 🏥 Gestión Clínica
- **Diagnósticos detallados** con resultados y recomendaciones
- **Catálogo de tratamientos** con precios y descripciones
- **Seguimiento de atenciones** y procedimientos realizados

### 👤 Gestión de Pacientes
- **Registro completo** con datos personales y estado clínico
- **Búsqueda por DNI** para acceso rápido a historiales
- **Modificación de datos** con validaciones integradas

## 🏗️ Arquitectura del Sistema

El proyecto implementa una **arquitectura de tres capas** que garantiza separación de responsabilidades y mantenibilidad:

```
📁 CapaPresentacion/     # Interfaz de usuario (Windows Forms)
📁 CapaLogica/          # Lógica de negocio
📁 CapaDatos/           # Acceso a datos
📁 CapaEntidad/         # Modelos de datos
```

### Patrón Singleton
Todas las clases de acceso a datos implementan el patrón Singleton para garantizar una única instancia y optimizar el uso de recursos.

## 🛠️ Tecnologías Utilizadas

- **Lenguaje**: C# (.NET Framework)
- **Base de datos**: SQL Server con procedimientos almacenados
- **Interfaz**: Windows Forms
- **Arquitectura**: Patrón de tres capas + Singleton
- **ORM**: ADO.NET con SqlConnection

## 📋 Requisitos del Sistema

- Windows 10 o superior
- .NET Framework 4.7.2+
- SQL Server 2016 o superior
- Visual Studio 2019+ (para desarrollo)

## ⚙️ Instalación y Configuración

### 1. Clonar el Repositorio
```bash
git clone https://github.com/franklinnot/Boki.git
cd Boki
```

### 2. Configurar Base de Datos
1. Crear una base de datos llamada `BuccalMedicDB` en SQL Server
2. Ejecutar los procedimientos almacenados incluidos en el archivo README.md

### 3. Configurar Conexión
Modificar la cadena de conexión en `Conexion.cs` si es necesario:
```csharp
string server = "localhost"; // Tu servidor SQL
string database = "BuccalMedicDB";
```

### 4. Compilar y Ejecutar
1. Abrir `BuccalMedic.sln` en Visual Studio
2. Restaurar paquetes NuGet
3. Compilar la solución (F6)
4. Ejecutar el proyecto (F5)

## 🎯 Uso del Sistema

### Inicio de Sesión
El sistema cuenta con autenticación por roles:
- **Recepcionistas**: Gestión de citas y pacientes
- **Odontólogos**: Acceso completo incluyendo diagnósticos y tratamientos

### Flujo de Trabajo Típico
1. **Login** con credenciales de empleado
2. **Registro/búsqueda** de pacientes
3. **Programación** de citas
4. **Realización** de consultas y diagnósticos
5. **Asignación** de tratamientos
6. **Seguimiento** y evaluaciones

## 🗄️ Estructura de la Base de Datos

### Procedimientos Almacenados Principales
- `sp_ListarEmpleados`: Lista todos los empleados
- `sp_BuscarEmpleadoLogin`: Autenticación de usuarios
- `sp_ListarOdontologos`: Filtra empleados odontólogos
- `sp_InsertarCliente`: Registro de nuevos pacientes
- `sp_RegistrarDiagnostico`: Almacena diagnósticos médicos

## 🤝 Contribución

1. Fork el proyecto
2. Crea una rama para tu feature (`git checkout -b feature/AmazingFeature`)
3. Commit tus cambios (`git commit -m 'Add some AmazingFeature'`)
4. Push a la rama (`git push origin feature/AmazingFeature`)
5. Abre un Pull Request

## 📝 Licencia

Este proyecto está bajo la Licencia MIT. Ver el archivo `LICENSE` para más detalles.

## 👨‍💻 Desarrolladores

- **Franklin Not** - Desarrollador Principal
- **Belen** - Desarrollo Frontend
- **Levi360xd** - Módulo de Diagnósticos
- **PapuLap** - Gestión de Clientes
- **Flavio Zavaleta** - Módulo de Evaluaciones

## 📞 Soporte

Para reportar bugs o solicitar nuevas características, por favor abre un issue en el repositorio de GitHub.

---

⭐ **¡No olvides dar una estrella al proyecto si te resulta útil!**
