# DesignPatterns.Mediator

Utilização básica do padrão de projeto Mediator de modo manual e através do package MediatR

## Criando o projeto

```zsh
 $ dotnet new webapi -o DesignPatterns.Mediator
```

## Adicionando pacotes do MediatR

```zsh
 $ dotnet add package MediatR  
```

```zsh
 $ dotnet add package MediatR.Extensions.Microsoft.DependencyInjection
```

## Injetando a dependência manualmente

```vb
builder.Services.AddTransient<ICustomerHandler, CustomerHandler>();
```

## Injetando a dependência dinâmicamente com o MediatR

```vb
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
```

## Executando o projeto

```zsh
 $ dotnet watch run
```
