create migration:
dotnet ef migrations add <MiragtionNameHere>

apply migration:
dotnet ef database update

revert migration:
dotnet ef migrations remove
