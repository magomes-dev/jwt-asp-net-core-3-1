# PIX FORCE API ![.NET Core](https://github.com/magomes-dev/jwt-asp-net-core-3-1/workflows/.NET%20Core/badge.svg)
Implementação de uma API do ASP.NET Core 3.1 com autenticação JWT.

## Uso da API
[Consulte aqui](https://documenter.getpostman.com/view/2137744/SzmcbzLZ?version=latest) a documentação completa para a utilização da API

## Construído com:
* Asp.Net core 3.1 we
* AutoMapper - Mapear entidades e Dtos
* EF Core - ORM
* Sql Server 2017
* Docker Compose

## Como obter e executar uma cópia local

### Pré-requisitos 
Certifique-se que tenha instalado em sua máquina
* [Docker](https://docs.docker.com/compose/install/)
* [Git](https://git-scm.com/downloads)
* [POSTMAN](https://www.postman.com/downloads/) - (Ou Similar) Para testar a chamada dos endpoints

### Clonando o projeto
``` bash
 $ git clone https://github.com/magomes-dev/jwt-asp-net-core-3-1.git
```

### Docker Compose
Dentro da raiz do projeto
``` bash
 $ docker-compose up
```

Pronto, a API estará rodando localhost na porta 5000.
O banco de dados SqlServer estará rodando na porta 1433.

### Dados de inicialização
Alguns usuários e registros de estoque são criados no banco de dados ao inicializar a aplicação.
Os usuários podem ser consultados na rota pública da API localhost:5000/users. Utilize um dos usernames criados e a senha para login é "123456".

### Autor
* **Matheus Gomes** - [LinkedIn](https://www.linkedin.com/in/matheusandradegomes/)

### Considerações Finais
Por se tratar de uma pequena aplicação, optei por concentrar tudo em um único projeto, mas mantendo uma organização nos diretórios baseado em responsabilidade.
Em aplicações maiores os indicado é separar os diretórios em DLLs.

