# Json-Nested-Processor 

## Description / Beschreibung

**EN:** A C# .NET console application demonstrating advanced JSON deserialization techniques. This project focuses on handling "nested JSON" where a property contains a stringified JSON object that requires a second layer of parsing.

**DE:** Eine C# .NET Konsolenanwendung, die fortgeschrittene Techniken zur JSON-Deserialisierung demonstriert. Dieses Projekt konzentriert sich auf den Umgang mit "verschachteltem JSON", bei dem eine Eigenschaft ein stringifiziertes JSON-Objekt enthält, das eine zweite Ebene des Parsings erfordert.

---

## Features / Funktionen

* **Two-Step Deserialization:** Extracts a nested JSON string from a parent object (`Product.Data`) into a concrete class (`Data`).
* **Data Transformation:** Uses Extension Methods to map separate arrays (Color, Price, OfferPrice) into a structured `Dictionary`.
* **LINQ Integration:** Dynamically calculates the `MinPrice` using LINQ logic within the data model.
* **Robust Framework:** Built on .NET Framework 4.6.1 using the `Newtonsoft.Json` library.

---

## Project Structure / Projektstruktur

| File / Datei | Role / Rolle |
| :--- | :--- |
| **`Product.cs`** | The main wrapper model containing the raw JSON string. |
| **`Data.cs`** | The internal model for product details like colors and prices. |
| **`DataHelper.cs`** | Contains extension methods to process and sync raw data. |
| **`Program.cs`** | Entry point that executes the parsing and displays results. |

---

## How to Run / Ausführung

### Prerequisites / Voraussetzungen
* **Visual Studio 2017+**.
* **.NET Framework 4.6.1**.
* **Newtonsoft.Json** NuGet Package (v13.0.3).

### Steps / Schritte
1.  **Clone the repository** / Repository klonen.
2.  **Open** `JasonSerializedDeserialized.sln` in Visual Studio.
3.  **Restore NuGet packages** / NuGet-Pakete wiederherstellen.
4.  **Run the project (F5)** / Projekt ausführen (F5).

---

## Example Output / Beispielausgabe

**EN:** The application takes a complex JSON string and outputs:
* The minimum price calculated from the nested data.
* A mapped list of prices and offer prices organized by color.

**DE:** Die Anwendung nimmt einen komplexen JSON-String entgegen und gibt Folgendes aus:
* Den aus den verschachtelten Daten berechneten Mindestpreis.
* Eine nach Farben geordnete Liste von Preisen und Angebotspreisen.

---

### Technical Note / Technischer Hinweis
**EN:** The project utilizes `[JsonIgnore]` on calculated properties to prevent circular references and keep the serialization clean.

**DE:** Das Projekt verwendet `[JsonIgnore]` für berechnete Eigenschaften, um Zirkelbezüge zu verhindern und die Serialisierung sauber zu halten.

---

### ⚖️ License
This project is open-source and available under the **MIT License**.
