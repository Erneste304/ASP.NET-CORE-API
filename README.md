# ASP.NET Core API and Razor Pages

A self-study ASP.NET Core project containing a Minimal API, an in-memory Entity Framework Core database, and Razor Pages for managing movies.

## Projects

- `RazorPagesMovie` - standalone Razor Pages tutorial project using .NET 10.
- `WebApplication1/WebApplication1` - combined Todo Minimal API and Movie Razor Pages application.

## Movie features

- View movies
- Create a movie
- Edit a movie
- View movie details
- Delete a movie
- Client-side form validation

The Movie CRUD pages use the shared `TodoDb` Entity Framework Core `DbContext` and an in-memory database.

## Todo API

The `WebApplication1` project also exposes Todo endpoints at `/todoitems`:

- `GET /todoitems`
- `GET /todoitems/complete`
- `GET /todoitems/{id}`
- `POST /todoitems`
- `PUT /todoitems/{id}`
- `PATCH /todoitems/{id}`
- `DELETE /todoitems/{id}`

## Run

```bash
cd WebApplication1/WebApplication1
dotnet run
```

Open the movie list at `/MoviePages/Index`. Open `/openapi/v1.json` for the Todo API OpenAPI document in development.
