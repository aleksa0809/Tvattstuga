dotnet new sln
dotnet new mvc -o app --auth Individual
dotnet new nunit -o tests
dotnet sln add app/app.csproj
dotnet sln add tests/tests.csproj
cd tests
dotnet add reference ../app/app.csproj
cd ../app
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
cd ..
git init
#ne zabit dobavit .gitignore!!!
#app/bin/**
#app/obj/**
#tests/bin/**
#tests/obj/**

git add .
git commit -am first
git remote add origin https://github.com/aleksa0809/Tvattstuga.git
git push origin master
