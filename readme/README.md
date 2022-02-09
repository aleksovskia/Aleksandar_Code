
# AAF Web Shop


## Table of Contents


- [Git Commands](#Git-Commadns)
- [Configuration appsettings.json](#configuration-appsettings.json)
- [How to open the project](#How-to-open-the-project)
- [test](#test)

#
### Git Commands


#### `git init` turn a directory into empty git repository
#### `git clone "link for the git repositori"` -  is a command for downloading existing source code from repository
#### `git pull` - get lastet changes
#### `git add .` - add all files to be commited
#### `git commit -m "comit merssage"` - create commit
#### `git push` - push commits
#### `git status` - show latest git status

#

### Configuration appsettings.json  
    {
    "Logging":
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    },
    {
       "AllowedHosts": "*",
       "ConnectionString": {
    "AAFWebShop": "Server=.;Database=AAFWebShopDb;Integrated Security = true;"}

### In Startup.cs it connects to Sql Server  
     public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<DataContext>(options =>
            options.UseSqlServer(Configuration["ConnectionString:AAFWebShop"]));
            
        }

#
### How to open the project 

 ##### The project opens at a Visual Studio AAF.WebShop.sln
 ##### IIS Express - AFF.WebShop.API 
### Install NuGet Packages
#### `Microsoft.EntityFrameworkCore`
#### `Microsoft.EntityFrameworkCore.Design`
#### `Microsoft.EntityFrameworkCore.Relational`
#### `Microsoft.EntityFrameworkCore.SqlServer `
#### `Microsoft.EntityFrameworkCore.Tools`
#### `Newtonsoft.Json`
#### `Swashbuckle.AspNetCore`


### test 
