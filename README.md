# OAuth/OpenID Example

Brief,

1. `Client Credentials Flow` (Machine 2 Machine) is used in this example.
2. `Code as configuration` approach was used for conciseness.
3. For the sake of example, no keys or secrets are hidden in .env files


To develop,

1. Start IdentityServer via:
  ``` 
  $ dotnet run --project ./src/IdentityServer/IdentityServer.csproj 
  ```
2. Start EmployeeApi via:
  ``` 
  $ dotnet run --project ./src/Api/EmployeeApi.csproj 
  ```
3. Try to access employee api with `non`-tokenized requests
  ``` 
  $ dotnet run --project ./src/Client/Client.csproj
  
  Unauthorized
  ```
4. Try to access employee api with `tokenized` requests
  ``` 
  $ dotnet run --project ./src/Client/Client.csproj tokenize
  
  [
  {
    "name": "Sawyer",
    "gender": "male",
    "age": 18
  },
  {
    "name": "Juliet",
    "gender": "female",
    "age": 18
  },
  ...
  ```

Tech Stack,

Web Framework | OAuth / OpenID Framework   |
------------- | -------------------------- |
.NET 6.0      | Duende Identity Server     |
