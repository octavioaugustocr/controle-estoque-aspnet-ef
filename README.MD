# Controle de Estoque ASP.NET Core com Entity Framework e MySQL

## Descrição do Projeto

Este projeto é uma aplicação web de **Controle de Estoque** desenvolvida utilizando **ASP.NET Core 8.0** e **Entity Framework Core 9.0.9**. Ele oferece uma solução robusta para gerenciar produtos, categorias e movimentações de estoque de forma eficiente. A aplicação foi projetada para ser intuitiva e fácil de usar, permitindo o cadastro, edição, exclusão e visualização de itens de estoque, além de registrar entradas e saídas de produtos.

O banco de dados utilizado é o **MySQL**, integrado através do provedor `Pomelo.EntityFrameworkCore.MySql`, garantindo flexibilidade e escalabilidade para o armazenamento de dados. A arquitetura segue os princípios do MVC (Model-View-Controller), proporcionando uma separação clara de responsabilidades e facilitando a manutenção e futuras expansões.

## Funcionalidades

*   **Gestão de Produtos:** Cadastro, listagem, edição e exclusão de produtos com detalhes como nome, descrição, preço e quantidade em estoque.
*   **Gestão de Categorias:** Organização de produtos por categorias para facilitar a busca e o gerenciamento.
*   **Movimentação de Estoque:** Registro de entradas e saídas de produtos, atualizando automaticamente a quantidade em estoque.
*   **Visualização Detalhada:** Telas para visualizar informações completas de produtos e suas movimentações.
*   **Interface Responsiva:** Desenvolvida com Bootstrap para garantir uma boa experiência em diferentes dispositivos.

## Tecnologias Utilizadas

*   **Backend:**
    *   ASP.NET Core 8.0
    *   C#
    *   Entity Framework Core 9.0.9
    *   MySQL (via Pomelo.EntityFrameworkCore.MySql 9.0.0)
*   **Frontend:**
    *   HTML5, CSS3, JavaScript
    *   Bootstrap 5
    *   jQuery
    *   jQuery Validation e Unobtrusive Validation
*   **Ferramentas:**
    *   Visual Studio
    *   Git

## Como Instalar e Rodar o Projeto

Siga os passos abaixo para configurar e executar o projeto em sua máquina local:

### Pré-requisitos

Certifique-se de ter os seguintes softwares instalados:

*   [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0)
*   [MySQL Server](https://dev.mysql.com/downloads/mysql/)
*   [Visual Studio](https://visualstudio.microsoft.com/vs/) (recomendado) ou [Visual Studio Code](https://code.visualstudio.com/) com a extensão C#.

### Configuração do Banco de Dados

1.  Crie um banco de dados MySQL. Você pode usar um cliente MySQL como o MySQL Workbench ou o terminal.
2.  Atualize a string de conexão no arquivo `appsettings.json` (ou `appsettings.Development.json`) do projeto `ControleEstoqueAspNetEF` para apontar para o seu servidor MySQL. Exemplo:

    ```json
    {
      "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;Database=nome_do_seu_banco;Uid=seu_usuario;Pwd=sua_senha;"
      },
      "Logging": {
        "LogLevel": {
          "Default": "Information",
          "Microsoft.AspNetCore": "Warning"
        }
      },
      "AllowedHosts": "*"
    }
    ```

3.  Abra o terminal na pasta raiz do projeto (`ControleEstoqueAspNetEF/ControleEstoqueAspNetEF/ControleEstoqueAspNetEF/`) e aplique as migrações do Entity Framework Core para criar o esquema do banco de dados:

    ```bash
    dotnet ef database update
    ```

### Executando a Aplicação

1.  Abra o projeto no Visual Studio ou Visual Studio Code.
2.  No Visual Studio, pressione `F5` ou clique no botão 

"Executar" para iniciar a aplicação.
3.  Se estiver usando o terminal, navegue até a pasta raiz do projeto (`ControleEstoqueAspNetEF/ControleEstoqueAspNetEF/ControleEstoqueAspNetEF/`) e execute:

    ```bash
    dotnet run
    ```

    A aplicação estará disponível em `https://localhost:7000` (ou outra porta configurada).

## Estrutura do Projeto

```
ControleEstoqueAspNetEF/
├── ControleEstoqueAspNetEF.sln
└── ControleEstoqueAspNetEF/
    ├── ControleEstoqueAspNetEF/
    │   ├── Controllers/
    │   ├── Data/
    │   ├── Models/
    │   ├── Views/
    │   ├── wwwroot/
    │   ├── appsettings.json
    │   ├── Program.cs
    │   └── ControleEstoqueAspNetEF.csproj
    └── ... (outros arquivos e pastas gerados pelo Visual Studio)
```

## Contribuição

Contribuições são bem-vindas! Se você tiver sugestões, melhorias ou encontrar algum bug, sinta-se à vontade para abrir uma *issue* ou enviar um *pull request*.

## Autor

[Octávio Augusto Campos Ribeiro/https://www.linkedin.com/in/octavio-augusto-7b3501325/]

---
