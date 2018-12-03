## Buffteks Project Management Web Application

We are completing a website to manage Buffteks projects, students, and clients.

### You will use ASP.NET MVC Core 2.0 to build a web application subject to the following requirements:

#### Using Entity Framework,  you will maintain a SQLite database for the following entities:
* Member - A member of the Buffteks
* Client - A client who provides a project to the Buffteks members
* Project - A project for Members and Clients to collaborate on

* Using Scaffolding, create Controllers and Views to manage the 
    * Create, Read, Update, and Delete operations for each of the entities above

___________________________________________________________________________________________________

#### Scaffolding info

[Microsoft Docs:  Add a model to an ASP.NET Core MVC app Tutorial](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app-xplat/adding-model?view=aspnetcore-2.1#prepare-the-project-for-scaffolding)
Run this ` dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design ` and the following line will be added to your .csproj in your <code>`<ItemGroup`</code>
```xml
<PackageReference Include="Microsoft.VisualStudio.Web.CodeGeneration.Design" Version="2.1.6" /> 
```

You may need to add the Microsoft.EntityFrameworkCore.Tools.DotNet package by running ` dotnet add package Microsoft.EntityFrameworkCore.Tools.DotNet `

```
dotnet aspnet-codegenerator controller -name MemberController -m Member -dc AppDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries

dotnet aspnet-codegenerator controller -name ClientController -m Client -dc AppDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries

dotnet aspnet-codegenerator controller -name ProjectController -m Project -dc AppDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries
```

___________________________________________________________________________________________________
    
#### Data seeding:
* Create at least two projects
* Create at least two clients
* Create at least ten Members
* Assign Members and Clients to Projects
* Be able to search/filter for Clients or Members by Project (this can't be scaffolded)
* Use Layouts and Views and Bootstrap 4 to create a unique visual appearance and style for your app

#### Submission Requirements

* ZIP up your solution folder and submit to this dropbox.
* Also, provide the URL to the Github repository you've used for this project. 
* BOTH ARE REQUIRED or you will receive ZERO credit for this project.

