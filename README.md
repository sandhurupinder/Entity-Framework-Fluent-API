# About

This repository demonstrates Entity Framework's Fluent API which is used in Code First development. The Fluent API maps POCOs to DB tables, similar to Data Annotations which cover a subset of the fluent API functionality. 

## Note
Fluent API takes precedence over Data Annotations.

## Setup
Check the following configuration file:

`EfFluentApi.ConsoleApp\appsettings.json`

Ensure that the connection string is set correctly and can connect to your test database:

```
{
  "ConnectionStrings": {
    "EfFluentApi" : "Server=(local);Database=EfFluentApi;Trusted_Connection=True;MultipleActiveResultSets=true;"
  }
}
```

Notice that MARS (MultipleActiveResultSets) should be on.

The project will fail if run as is. The reason is that `Category.Products` is not loaded, and you need to specify a type of loading (Eager, Lazy or Explicit). Comments are place in different places of the code, and you need to follow them to enable the loading that you want to test.

## WARNING

Running the console app will drop the `EfFluentApi` database and recreate it based on the mapping specified in the program.