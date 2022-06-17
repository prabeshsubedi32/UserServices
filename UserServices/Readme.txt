1. Create the database and required schema.
	Database Script:
	CREATE DATABASE users_information;
	
    CREATE TABLE public.user
    (
   	    user_Id int GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
        address varchar NOT NULL,
        first_name varchar NOT NULL,
        last_name varchar NOT NULL
    )

Add nuget:
Microsoft.EntityFrameworkCore.Tools
Npgsql.EntityFrameworkCore.PostgreSQL

2. Provide scaffold command on package manager consle and provide the connection string as below to 
    create the models and dbcontext
    
    Scaffold-DbContext -Connection "Server=127.0.0.1;Database=users_information;Username=postgres;Password=root;" -Provider Npgsql.EntityFrameworkCore.PostgreSQL -OutputDir ".\POCO\Models" -ContextDir ".\POCO\Data" -Context SystemGeneratedDbContext –DataAnnotations -Force

3. Once the scaffold command ran successfully it should create the required models and dbcontext 
inside the POCO foler. 

4. Create a repository for the database CRUD operations. 
