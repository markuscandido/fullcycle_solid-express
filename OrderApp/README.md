# Para instalar o .NET Core 8 no Ubuntu usando o WSL2, siga os passos abaixo

## Instale os pacotes necessários

```shell
sudo apt-get update
sudo apt-get install -y wget gpg

```

## Adicione a chave GPG da Microsoft

```shell
wget https://packages.microsoft.com/config/ubuntu/$(lsb_release -rs)/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb

```

## Atualize o índice de pacotes do apt

```shell
sudo apt-get update

```

## Instale o .NET SDK 8.0

```shell
sudo apt-get install -y dotnet-sdk-8.0

```

## Verifique a Instalação

```shell
dotnet --version
```

## Configuração Adicional (Opcional)

Caso precise desenvolver ou executar projetos ASP.NET Core, você também pode instalar o runtime do ASP.NET Core:

```shell
sudo apt-get install -y aspnetcore-runtime-8.0
```

## Atualizando a Lista de Templates (Opcional)

```shell
dotnet new --install Microsoft.DotNet.Common.ProjectTemplates.8.0
```

## Criando um Novo Projeto .NET

```shell
# Crie um diretório para o projeto:
mkdir OrderApp
cd OrderApp

# Crie os subprojetos usando o .NET CLI:
dotnet new classlib -n OrderApp.Domain
dotnet new classlib -n OrderApp.Application
dotnet new classlib -n OrderApp.Infrastructure
dotnet new console -n OrderApp.Console
dotnet new xunit -n OrderApp.Tests

# Adicione referências entre os projetos:
dotnet add OrderApp.Application/OrderApp.Application.csproj reference OrderApp.Domain/OrderApp.Domain.csproj
dotnet add OrderApp.Infrastructure/OrderApp.Infrastructure.csproj reference OrderApp.Domain/OrderApp.Domain.csproj
dotnet add OrderApp.Console/OrderApp.Console.csproj reference OrderApp.Application/OrderApp.Application.csproj
dotnet add OrderApp.Console/OrderApp.Console.csproj reference OrderApp.Infrastructure/OrderApp.Infrastructure.csproj
dotnet add OrderApp.Tests/OrderApp.Tests.csproj reference OrderApp.Application/OrderApp.Application.csproj
dotnet add OrderApp.Tests/OrderApp.Tests.csproj reference OrderApp.Domain/OrderApp.Domain.csproj


# Restaure os pacotes e faça o build
dotnet restore
dotnet build

# Execute o projeto de console:
dotnet run --project OrderApp.Console/OrderApp.Console.csproj


```