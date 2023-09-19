#Install dotnet-ef

dotnet tool install -g dotnet-ef

dotnet tool install --global dotnet-ef --version 6.*

dotnet tool uninstall -g dotnet-ef


#Migrations

dotnet ef migrations add AddProductDataTableOnDB


'ef migrations remove'


dotnet ef database update

