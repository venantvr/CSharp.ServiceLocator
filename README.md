# CSharp.ServiceLocator

Implémentation du pattern Service Locator en C# : résolution de dépendances via configuration, avec factory et interfaces découplées.

## Structure

- `ServiceLocator/` — Bibliothèque principale
  - `ServiceLocator.cs` — Localisateur de services
  - `DefaultFactory.cs` — Factory par défaut
  - `Interfaces/IFactory.cs`, `ILocator.cs` — Contrats
  - `ClassDiagram.cd` — Diagramme de classes
- `Business/` — Couche métier avec interfaces
  - `Manager.cs` — Gestionnaire métier
  - `Interfaces/IService.cs`, `ILogger.cs` — Contrats
  - `ServiceA.cs`, `LoggerA.cs` — Implémentations
- `Tools/Configuration.cs` — Configuration du mapping
- `Sample/` — Application console de démonstration

## Stack

[![Stack](https://skillicons.dev/icons?i=dotnet,cs&theme=dark)](https://skillicons.dev)