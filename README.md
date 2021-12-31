# README.md

Create solution, create class library, create xUnit project, create reference on xUnit project to class library:

```text
dotnet new sln -o Pattern
cd Pattern
dotnet new gitignore
dotnet new classlib -o FactoryLib
dotnet sln add ./FactoryLib/FactoryLib.csproj
dotnet new xunit -o FactoryLibTest
dotnet sln add ./FactoryLibTest/FactoryLibTest.csproj
dotnet add ./FactoryLibTest/FactoryLibTest.csproj reference ./FactoryLib/FactoryLib.csproj
```

run xUnit test:

```bash
dotnet test ./FactoryLibTest/FactoryLibTest.csproj --no-restore
```
