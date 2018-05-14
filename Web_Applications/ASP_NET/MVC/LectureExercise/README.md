# Project Workflow

1. Create Blank Solution
2. Create repository 
	- git init
2. Add new project -ASP.Net Web Application
	- naming - CompanyName.ProjectName.<Suffix - Web-Server .. etc.>
	- select Mvc
	- select Authentication - Individual User Account
3. Remove Unnessesary Things
	- ApplicationInsights.config
	- fonts
4. Run The Project
---------------------------------------
5. Install IIS 
	- go to Windows Features
	- install
		- Internet Information Servicess 
		- WWS
		- Application Developing Features
6. Open IIS
	- Add site
	- Point it to web project
	- add Host name
7. Settup hosts file
	- Goto - c\windows\System32\drivers\etc
	- add entry - IP address
----------------------------------------
8. Extract every class in seperated class
9 . Comment password requirements - App_Start -> IdentityConfig.cs
10. Modify Models -> IdentityModel
	- change ApplicationUser To User
	- rename DB name
	10.2 Add to solution new folder -> Data 
	10.3. Add to Data ClassLibrary ( .NET Framework) .Data -> Add class and copy DB class
	10.4. Add to Data ClassLubrary (.Net Framework) .Data.Model -> Add class and copy User
	10.5 Remove IdentityModels.cs
	10.6. Manage NuGet package for solution
		- add Microsoft.AspNet.Identity.EntityFramework
		- add all usings
11. Change connection string "DefaulConnection" -> change the name in Web.config, change and DataSouce
12. Fix all referance errors
13. Enable-Migrations -> Package Manager Console -> Enable-Migrations to project.forum.Data
14. Add Default Admin to Seed
15. change internal to public in Configuration class of Migrations
	- add controll to database
		- this. AutomaticMigrationSeed to false and this. AutomaticMigrationDataLossAllowed to false
16. Migrting to latest version
	- in Global.asax
		- add Database SetInitializer (new MigrationDatabaseToLatestVersion<MY SQL DATABASE CONTEXT, MIGRATION CONFIG>)
17. Project.Data.Model
	- Add Contracts
		- IDeletable
			- IsDelated
			- DateTime? DaletedOn
		- IAuditable
			- DateTime? CreatedOn
			- DateTime? Modified On
	- Add Abstracts
		- base class -> abstract DataModel who implements the interfacess
		- add DataTime arguments + Index
		- add property Guid with [Key] id 
		- add ctor to initialize struct Guide.NewGuid();
	- Add Class
		- Post (Forum)
	- Add to context
		- in DbContext add prop Posts, type IDSet<Post>
18. Add admin seed to Migration Configuration
19. Add-Migration to Data
20. Update-Database
21. Open SQL Managment Studio and see if the database exist
22. Build Generic Repository
	- create Repositories folder
		- add interfaces
		- create repository pattern
23. Install NinJect - to .web
	- add NinjectWebCommon.cs
24. Install Ninject.Extension.Convention
	- add default bind
25. MsqDbContext -> add void ApplyAuditInfoRules

Note: Don't forget to uncoment password requirements - App_Start -> IdentityConfig.cs