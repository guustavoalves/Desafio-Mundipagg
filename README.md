<img src="https://www.mundipagg.com/wp-content/uploads/2018/02/mundipagg-colorida.svg" height="90px" width="300px" alt="Mundipagg"> 


Desafio Mundipagg ![Build status](https://ci.appveyor.com/api/projects/status/rl2ja69994rt3ei6?svg=true)
=====================
Desafio Técnico - Processo Seletivo Mundipagg.

## Tecnologias Implementadas:

- ASP.NET Core 2.2 (com .NET Core 2.2)
- ASP.NET MVC Core 
- ASP.NET WebApi Core
- NUnit
- Swagger UI
- MongoGB
- Docker

## Requisitos necessários:
- Você precisa ter a última versão do Visual Studio 2017 e o .NET Core 2.2 SDK / Ou Docker 
- A última versão do SDK por ser baixada em https://dot.net/core.
- MongoDB instalado na máquina rodando na porta 27017

Você também pode rodar o projeto no Visual Studio Code (Windows, Linux or MacOS).

## Arquitetura:

- Arquitetura completa com preocupação de separação de responsabilidade, SOLID e código limpo
- Domain Driven Design
- Repositório e Serviço

## Como usar:
Visual Studio:
- Abra o VS e vá até o Projeto "Desafio.Mundipagg.Infra" e mude a conexão do MongoDB para "mongodb://localhost:27017"
- Build na Solution
- Start

Docker:
1 - Abra o prompt de comando
2 - Vá até o diretório da "Solution" utilizando o comando "cd"
3 - Rode o comando "docker-compose up -d"
4 - Vá até o diretório do csproj "Desafio.Mundipagg.UI.Web/Desafio.Mundipagg.UI.Web.csproj"


## News

**v1.0 - 27/08/2019**
- Criação do repositório

## Sobre:
Desenvolvido por Gustavo Brum Alves 
