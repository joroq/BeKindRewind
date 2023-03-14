dotnet new gitignore
dotnet new classlib --output src/Rewind
dotnet new nunit --output test/Rewind.Tests
dotnet add test/Rewind.Tests reference src/Rewind/Rewind.csproj
dotnet new sln
dotnet sln add src/Rewind/Rewind.csproj
dotnet sln add test/Rewind.Tests/Rewind.Tests.csproj

