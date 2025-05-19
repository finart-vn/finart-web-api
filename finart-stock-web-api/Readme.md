| Command                                     | Purpose                                       |
| ------------------------------------------- | --------------------------------------------- |
| `dotnet ef migrations add <MigrationName>`  | Create a new migration based on model changes |
| `dotnet ef database update`                 | Apply the latest migration to the database    |
| `dotnet ef migrations remove`               | Delete the last (not yet applied) migration   |
| `dotnet ef database update <MigrationName>` | Rollback or migrate to a specific migration   |
