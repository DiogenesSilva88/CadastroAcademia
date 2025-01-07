# CadastroAcademia API 🏋️‍♂️

Uma API desenvolvida em **C#** com **ASP.NET Core**, voltada para a gestão de academias. Permite operações de CRUD (Create, Read, Update, Delete) para gerenciar alunos e planos de treino.

---

## 🎯 Objetivo do Projeto
O objetivo deste projeto é demonstrar habilidades no desenvolvimento de APIs RESTful, utilizando boas práticas de programação, como separação de responsabilidades, configuração de banco de dados com **Entity Framework Core**, e organização do código.

---

## 🛠️ Tecnologias Utilizadas
- **C#** e **ASP.NET Core**  
- **Entity Framework Core** (ORM para interação com banco de dados)  
- **SQL Server** (banco de dados relacional)  
- **Swagger** (documentação e teste dos endpoints)  

---

## 🚀 Funcionalidades
- **Cadastro de Alunos:**  
  - Adicionar novos alunos com informações como nome, idade, e contato.
  - Visualizar, editar ou excluir registros de alunos.
  
- **Gestão de Planos:**  
  - Gerenciar os planos de treinamento e mensalidades.

- **Relatórios:**  
  - Obter dados básicos sobre alunos e planos cadastrados.

---

## 📂 Estrutura do Projeto
```plaintext
CadastroAcademia/
├── Controllers/       # Lida com as requisições HTTP
├── Models/            # Modelos do domínio da aplicação
├── Data/              # Configuração do Entity Framework
├── Migrations/        # Histórico de migrações do banco de dados
├── appsettings.json   # Configuração da aplicação
├── Program.cs         # Ponto de entrada da aplicação
└── Startup.cs         # Configuração de serviços e middlewares
