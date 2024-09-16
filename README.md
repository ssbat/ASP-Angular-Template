# ASP-Angular-Template

## To Create a Migration
### run this in the root folder
dotnet ef migrations add Initial --startup-project LaptopShop --project Library --context AppDbContext
## To Update the database
dotnet ef database update --startup-project LaptopShop --project Library --context AppDbContext