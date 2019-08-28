<img src="https://www.mundipagg.com/wp-content/uploads/2018/02/mundipagg-colorida.svg" height="90px" width="300px" alt="Mundipagg"> 


Desafio Mundipagg ![Build status](https://ci.appveyor.com/api/projects/status/rl2ja69994rt3ei6?svg=true)
=====================
Minha coleção de Livro/CD/DVD - Processo Seletivo Mundipagg (Desafio Ténico)

## Tecnologias Implementadas:

- ASP.NET Core 2.2 (com .NET Core 2.2)
- ASP.NET MVC Core 
- ASP.NET WebApi Core
- NUnit
- Swagger UI
- MongoGB
- Docker

## Requisitos necessários:
- Você precisa ter o Visual Studio 2017/2019 e o .NET Core 2.2 SDK / Ou Docker.
- A última versão do SDK por ser baixada em https://dot.net/core.
- MongoDB instalado na máquina rodando na porta 27017.

Você também pode rodar o projeto no Visual Studio Code (Windows, Linux or MacOS).

## Arquitetura:

- SOLID
- Domain Driven Design
- Repositório e Serviço

## Como usar:
Visual Studio:
- Abra o VS, no Projeto "Desafio.Mundipagg.Infra" mude a conexão do MongoDB para "mongodb://localhost:27017"
- Build na Solution
- Start
- Será aberto dois projetos: API e Web

Docker:
 - Abra o VS, no Projeto "Desafio.Mundipagg.Infra" mude a conexão do MongoDB para "mongodb://mongo:27017"
 - Abra o prompt de comando
 - Vá até o diretório da "Solution" utilizando o comando "cd"
 - Execute o comando "docker-compose up -d"
 - Execute o comando "docker-compose up"
 - Vá até o diretório do csproj "Desafio.Mundipagg.UI.Web/Desafio.Mundipagg.UI.Web.csproj"
 - Execute o comando novamente "docker-compose up -d"
 - Execute o comando novamente "docker-compose up"
 - Abra o navegador e acesse a API pelo endereço: "http://localhost:44394/swagger/index.html";
 - Acesse a interface pelo endereço: "http://localhost:44309/".

## News

**v1.0 - 27/08/2019**
- Criação do repositório

## Sobre:
Desenvolvido por Gustavo Alves - gustavo.alves@live.com
