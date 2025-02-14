# KYH_WebApi_ENDE_Crypt

<!-- Step 1 Main -->

1. First Make Prodject Folder structure:
```powershell
mkdir D0tNet
cd D0tNet
mkdir WebApi_ENDE_Crypt
```

2. move to the folder
```powershell
cd D0tNet/WebApi_ENDE_Crypt
```

3. Create Github Page *KYH_WebApi_EN-DE_Crypt* + Readme + First commit:
```powershell
echo "# KYH_WebApi_ENDE_Crypt" >> README.md
git init
git add README.md
git commit -m "first commit"
git branch -M main
git remote add origin https://github.com/WANTEDSIMON/KYH_WebApi_ENDE_Crypt.git
git push -u origin main
```

<!-- Step 2 For dev.1 -->

1. Make Github Actions Folder path + changes.yml:
*"chnages" for ReaMe -File*
*"test" For Tesin every thing
*"dev" For to test befor allowing Merge to Main
*"main" For allowing contetnt to go to AWS
```powershell
New-Item -ItemType File -Path .github\workflows\changes.yml -Force
New-Item -ItemType File -Path .github\workflows\test.yml
New-Item -ItemType File -Path .github\workflows\dev.yml
New-Item -ItemType File -Path .github\workflows\main.yml
```

2. Add/generate gitignore
```
dotnet new gitignore
```

3. Opened the project in Visual Studio:
```sh
start devenv .
```
> [!NOTE]
> Opened the project in VS Code:```code .```

4. Set up the yaml file "changes".

```YML
name: 🔄 Changes Branch - CI Check

on:
  push:
    branches:
      - Changes
      - changes
      - Changes_*
      - changes_*
      - Changes.*
      - changes.*
    paths:
      - "README.md"  # Only runs if README.md is modified
  pull_request:
    branches:
      - Changes
      - changes
      - Changes_*
      - changes_*
      - Changes.*
      - changes.*
    paths:
      - "README.md"

jobs:
  check-readme:
    runs-on: ubuntu-latest

    steps:
    - name: 🛠️ Checkout repository
      uses: actions/checkout@v3

    - name: ✅ Validate Markdown (README.md)
      run: echo "Markdown validation would be done here"

```


5. Make Basic yml for first "dev" push/commit
```YML
name: 🛠️ Dev Branch - Build

on:
  push:
    branches:
      - dev
      - Dev
      - Dev_*
      - dev_*
      - Dev.*
      - dev.*
  pull_request:
    branches:
      - dev
      - Dev
      - Dev_*
      - dev_*
      - Dev.*
      - dev.*

jobs:
  build: 
    runs-on: ubuntu-latest
    
    steps:
      - name: 🛠️ Checkout repository
        uses: actions/checkout@v3
      
      - name: 🔧 Set up .NET 8
        uses: actions/setup-dotnet@v3
        with:
          dotnet-version: '8.0'

      - name: 📦 Restore dependencies
        run: dotnet restore

      - name: 🏗️ Build the project
        run: dotnet build --configuration Debug

```

6. Ok, now let get all Dev changes beffore we add, Readme..(changes)
*Make branch dev.1*
```
git checkout -b dev.1
```

7. Add All GitHub Actions Workflow Files
```
git add .gitignore
git add .github/workflows/changes.yml
git add .github/workflows/dev.yml
git add .github/workflows/main.yml
git add .github/workflows/test.yml
```

8. Add commit message:
```
git commit -m "🔄 Added GitHub Actions workflows files main, test, changes, and dev branches + .gitignore"
```

9. Push the dev.1 Branch to Github
```
git push origin dev.1
```


10. Create a Pull Request on GitHub
11. Merge the Pull Request
12. Delete the Branch


<!-- Step 3 For changes.1 -->

1. Now add changes branch to add ReadMe update
*Make branch changes.1*
```
git checkout -b changes.1
```

2. Add README.md file
```
git add README.md
```

3. Add commit message:
```
git commit -m "🔄 Updated README.md"
```

4. Push the changes.1 Branch to Github
```
git push origin changes.1
```

5. Merge and Delete branch

<!-- Step 4 For changes.2 + dev.2  -->

1. Create WebApi Project
```powershell
dotnet new web
```

2. change the "WebApi_EN-DE_Crypt.csproj" to(change dotnet_version):
```
<Project Sdk="Microsoft.NET.Sdk.Web">

  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
    <RootNamespace>WebApi_ENDE_Crypt</RootNamespace>
  </PropertyGroup>


</Project>
```

3. Run the project
```powershell
dotnet run
```

4. Add images folder + image of first run
```powershell
mkdir images_readme
```

img(dotnet run):
![New Endpoint](images_readme/img_dotnet-run.png)

img(first run):
![First Run](images_readme/img_first-run.png)

5. Beffore adding the dev.2 changes lets add the changes to the changes.4 branch
```
git checkout -b changes.2
```

6. Add README.md + imag folder and content to changes.4
```
git add README.md
git add images_readme/img_dotnet-run.png
git add images_readme/img_first-run.png
```

7. Add commit message:
```
git commit -m "🔄 Added image of first run of the WebApi project"
```

8. Push the changes.2 Branch to Github
```
git push origin changes.2
```

9. Merge and Delete branch

10. Adding dev.2 branch
```
git checkout -b dev.2
```

11. Add, commit and push the changes to Github to get remaining changes
```
git add .
```

12. Add commit message:
```
git commit -m "🔄 Created WebApi project"
```

13. Push the dev.4 Branch to Github
```
git push origin dev.2
```

14. Merge and Delete branch

<!-- Step 5 Update folder structure dev.3-->

1. Add new folders to the project
```powershell
mkdir Endpoints
mkdir Services
```

2. Add dev.3 branch
```
git checkout -b dev.3
```

3. Add KeyEndpoints.cs to Endpoints folder
```powershell
New-Item -ItemType File -Path Endpoints\KeyEndpoints.cs
```

4. Add IKeyService.cs, KeyGenerator.cs, KeyService to Services folder,
```powershell
New-Item -ItemType File -Path Services\IKeyService.cs
New-Item -ItemType File -Path Services\KeyGenerator.cs
New-Item -ItemType File -Path Services\KeyService.cs
```

5. Add the code to following files:
*Endpoints\KeyEndpoints.cs*
*Services\IKeyService.cs*
*Services\KeyGenerator.cs*
*Services\KeyService.cs*
```csharp //KeyEndpoints.cs
using Microsoft.AspNetCore.Builder;
using WebApi_ENDE_Crypt.Services;

namespace WebApi_ENDE_Crypt.Endpoints;

public static class KeyEndpoints
{
    public static void MapKeyEndpoints(this WebApplication app)
    {
        app.MapGet("/key", (IKeyService keyService) => keyService.GenerateRandomKey());
    }
}
```
```csharp //IKeyService.cs
public interface IKeyService
{
    string GenerateRandomKey();
}
```
```csharp //KeyGenerator.cs
using System.Security.Cryptography;

namespace WebApi_ENDE_Crypt.Services;

public class KeyGenerator
{
    private const int KeyLength = 32;

    public static string GenerateRandomKey()
    {
        byte[] key = new byte[KeyLength];
        RandomNumberGenerator.Fill(key);
        return Convert.ToBase64String(key);
    }
}
```
```csharp //KeyService.cs
namespace WebApi_ENDE_Crypt.Services;

public class KeyService : IKeyService
{
    public string GenerateRandomKey()
    {
        return KeyGenerator.GenerateRandomKey();
    }
}
```

6. Update the Program.cs
```csharp //Program.cs
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebApi_ENDE_Crypt.Endpoints;
using WebApi_ENDE_Crypt.Services;

var builder = WebApplication.CreateBuilder(args);

// Register Services for Dependency Injection (DI)
builder.Services.AddSingleton<IKeyService, KeyService>();


var app = builder.Build();
app.MapGet("/", () => "Hello Earth 🌎!");

// Map API Endpoints
app.MapKeyEndpoints();


app.Run();

// Ensure Program is accessible for testing
public partial class Program { }
```

7. Run the current project
```powershell
dotnet run
```

img(img_second run):
![New Endpoint](images_readme/img_second-run.png)

img(/key first run):
![First Run](images_readme/img_Key_First-run.png)

8. Add the files to dev.3 commit 
```powershell
git add Endpoints/KeyEndpoints.cs
git add Services/IKeyService.cs
git add Services/KeyGenerator.cs
git add Services/KeyService.cs
git add Program.cs
git commit -m " Added /key Endpoint, Services, and  directories related code, exept Test"
git push origin dev.3
```

9. Merge and Delete branch

<!-- Step 6 Add Documentation structure change.3-->

1. Create changes.3 branch
```
git checkout -b changes.3
```

2. Add Documentation files
```powershell
git add README.md
git add images_readme/img_second-run.png
git add images_readme/img_Key_First-run.png
```

3. Add commit message:
```
git commit -m "🔄 Added images of the second run of the WebApi project and /key first run"
```

4. Push the changes.3 Branch to Github
```

5. Merge and Delete branch

