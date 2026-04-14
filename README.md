# Export Data from Collections to Excel and Group It in C#

This sample demonstrates how to export data from .NET collections to an Excel workbook and group the data programmatically using C# and Syncfusion XlsIO. It is a practical example for generating structured, well‑organized Excel reports without relying on Microsoft Excel. The project shows how data can be imported into Excel, grouped by categories, and displayed with expand/collapse functionality. Developers can see how to configure layout options, grouping behavior, and outline levels to produce professional reports that are both dynamic and easy to navigate.

## What this sample shows
* Creates custom business objects stored in .NET collections
* Exports collection data to an Excel worksheet
* Groups rows based on specific fields
* Supports layout options such as Default, Merge, and Repeat for nested data
* Applies Excel outline levels for collapsible grouping
* Saves the Excel file efficiently using XlsIO
* Applies custom styles to headers and page titles for improved readability

## Prerequisites
* .NET Framework / .NET
* Syncfusion XlsIO NuGet package

## Use cases
* Creating grouped Excel reports from in‑memory data
* Automating report generation for analytics, finance, or inventory management
* Structuring large datasets for better readability with collapsible sections

## Repository Structure
* **Collections-to-Excel-with-Grouping:** Demonstrates how to bind nested collections (Brand → VehicleType → Model) to Excel worksheets and apply grouping. The sample shows how to configure layout options, enable expand/collapse grouping, and apply styles to headers for a polished report.

## Key Highlights
* **Nested Data Import:** Use ImportData with ExcelImportDataOptions to bring hierarchical collections into Excel.
* **Grouping Options:** Choose between expand or collapse modes, with configurable collapse levels.
* **Layout Options:** Control how nested data is displayed (Default, Merge, Repeat).
* **Expand/Collapse:** Enable users to expand or collapse grouped sections in Excel for easier navigation.
* **Automation:** Generate Excel files dynamically without manual intervention.

This project serves as a practical reference for developers looking to transform collection‑based data into grouped, professional Excel reports using C#. By following the examples, you can adapt the approach to your own business objects, ensuring that Excel reports are generated dynamically with consistent formatting, layout, and grouping logic. The sample demonstrates best practices for importing hierarchical data, applying grouping, and styling reports, making it a valuable resource for reporting and automation scenarios.