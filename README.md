# Check_box_select_list_ASP.Net_core_mvc_5_Identity_roles_Sqlite

 1-Create an ASP.Net Core MVC 5 project with individual accounts Identity option selected. 
 2-Install Microsoft.AspNetCore.Session NuGet Package 
 3-In Startup.cs add services.AddSession();
 4-In Startup.cs add app.UseSession();
 5-In Startup.cs add services.AddHttpContextAccessor();
 6-Install nuget package Microsoft.EntityFrameworkCore.Sqlite
 7-Modify Startup.cs services with Usesqlite instruction. 
 8-Modify connection string in appsettings.json.
 9-Create model classes, add model classes DbSets in ApplicationDbContext. Create controllers, views. 
 10-SQLite app.db is created by Visual Studio by update-database migration command thanks to nuget package Microsoft.EntityFrameworkCore.Sqlite 
 11-If Visual Studio created app.db file but identity tables migration errored then keep app.db file but delete migrations folder and renew migrations by add-migration        and update-database commands. 
 12-Put sqlite db file in a folder and modify connection string accordingly. 
 13-Putting Sqlite db in folder is optional to easily arrange and upgrade folder read write permissions in remote plesk hosting. 
 14-Db browser for Sqlite is management studio for Sqlite. Download and install it to work with internal structures and tables in Sqlite.
 15-Add _TopMenuPartial.cshtml in Views->Shared folder.
 16-Multiselect plugin is implemented in PlayersController->Create.cshtml with chosen.jquery.min.js and chosen.css.

