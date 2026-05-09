<p align="center">
  <img src="https://img.shields.io/badge/UNIVERSIDAD%20NACIONAL%20DE%20INGENIER%C3%8DA-UNI-blue?style=for-the-badge" />
</p>

# 🖥️ Informe de Desarrollo: Ecosistema C# & SQL Server
> **Proyecto:** Portafolio de Soluciones en Windows Forms  
> **Asignatura:** Programación II  
> **Desarrollador:** Oscar Hernández (@xOfho)

---

## 📊 Resumen del Proyecto
Este repositorio es una compilación técnica de **10 módulos funcionales** que demuestran el dominio de la programación orientada a objetos (POO), el manejo de bases de datos relacionales y la optimización de consultas mediante **LINQ**.

<h2> Herramientas Tecnológicas</h2>

<!-- Badges -->
<p align="center">
  <img src="https://img.shields.io/badge/C%23-Programming-blue?style=for-the-badge&logo=csharp&logoColor=white">
  <img src="https://img.shields.io/badge/.NET-6.0-purple?style=for-the-badge&logo=dotnet&logoColor=white">
  <img src="https://img.shields.io/badge/WinForms-UI-blueviolet?style=for-the-badge&logo=windows&logoColor=white">
  <img src="https://img.shields.io/badge/Async-Await-success?style=for-the-badge">
  <img src="https://img.shields.io/badge/PLINQ-Parallel-orange?style=for-the-badge">
  <img src="https://img.shields.io/badge/JSON-Serialization-lightgrey?style=for-the-badge&logo=json&logoColor=black">
</p>

---

## 📥 Documentación Oficial
Puedes descargar la guía detallada de la práctica aquí:

<p align="left">
  <a href="https://github.com/xOfho/CSharp-FileSystem-UNI-Prog_I1/raw/main/docs/Documentacion_Repositorio_U3UNI.pdf">
    <img src="https://img.shields.io/badge/DESCARGAR%20DOCUMENTACI%C3%93N-PDF-red?style=for-the-badge&logo=adobe-acrobat-reader&logoColor=white" />
  </a>
</p>

<p align="left">
  <a href="https://www.mediafire.com/file/bispaktagnrqjn8/Archive.zip/file">
    <img src="https://img.shields.io/badge/DESCARGAR .ZIPS-Docs?style=for-the-badge&logo=adobe-acrobat-reader" />
  </a>
</p>

---

## 🚀 Catálogo de Sistemas Desarrollados

<details>
<summary><b>📂 Ver lista detallada de los 10 Ejercicios (Click aquí)</b></summary>

| ID | Sistema | Funcionalidad Principal | Concepto Técnico Aplicado |
| :--- | :--- | :--- | :--- |
| 01 | **Clientes** | Registro y persistencia. | SQL Parameters (Anti-Injection) |
| 02 | **Productos** | Búsqueda dinámica. | LINQ `.Contains()` |
| 03 | **Estudiantes** | Ranking académico. | `OrderByDescending` |
| 04 | **Empleados** | Gestión de nómina. | Agregación de datos (`.Sum`) |
| 05 | **Inventario** | Control de Stock. | Filtrado condicional por stock crítico |
| 06 | **Biblioteca** | Préstamos activos. | Manejo de estados booleanos |
| 07 | **Ventas** | Business Intelligence. | `GroupBy` & Agrupamiento complejo |
| 08 | **Médico** | Expedientes clínicos. | Filtrado demográfico por edad |
| 09 | **Facturación** | Transacciones seguras. | `SqlTransaction` (Atomicidad/Rollback) |
| 10 | **Universitario**| Relaciones de Datos. | LINQ Joins (Relaciones 1:N) |

</details>

---

## 💡 Highlights Técnicos

### 🛡️ Transaccionalidad de Datos
En el **Ejercicio 9**, garantizamos que la base de datos nunca quede en un estado inconsistente mediante el uso de transacciones:

```csharp
using (SqlTransaction transaction = connection.BeginTransaction()) {
    try {
        // Lógica de inserción de factura y detalle...
        transaction.Commit();
    } catch (Exception) {
        transaction.Rollback(); // Si un producto falla, nada se guarda
    }
}

```
# Contribuidores
<a href="https://github.com/ThePhilos/CSharp-Ventas-UNI-Prog_I2/graphs/contributors">
<table align="center">
  <tr>
    <td align="center">
      <a href="https://github.com/ThePhilos">
        <img src="https://github.com/ThePhilos.png" width="100px;" style="border-radius:50%;" /><br />
        <sub><b>ThePhilos</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/maurijrbs">
        <img src="https://github.com/maurijrbs.png" width="100px;" style="border-radius:50%;" /><br />
        <sub><b>maurijrbs</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/xOfho">
        <img src="https://github.com/xOfho.png" width="100px;" style="border-radius:50%;" /><br />
        <sub><b>xOfho</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/joletteolivas">
        <img src="https://github.com/joletteolivas.png" width="100px;" style="border-radius:50%;" /><br />
        <sub><b>joletteolivas</b></sub>
      </a>
    </td>
  </tr>
</table>
