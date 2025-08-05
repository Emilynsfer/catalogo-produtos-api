# 🛍️ Catálogo de Produtos API

Uma **Minimal API desenvolvida em ASP.NET Core 9** para gerenciar um catálogo de produtos.  
Projeto criado com foco em **boas práticas, aprendizado de conceitos fundamentais** e aplicação prática para o portfólio.  

> 🚀 Desenvolvido como parte dos estudos e práticas no Bootcamp Start #7 da [GFT na DIO](https://web.dio.me), aplicando conceitos modernos do ecossistema .NET.

---

## ✨ Funcionalidades

- 📌 CRUD completo de Produtos  
- 🔎 Consulta de produto por **ID**  
- 📦 Controle de estoque  
- 💾 Persistência de dados com **Entity Framework Core + SQLite**  
- 📄 Documentação automática com **Swagger (OpenAPI)**  
- 🚀 Estrutura simples e clara utilizando **Minimal APIs**  

---


---

## 🛠️ Tecnologias Utilizadas

- [ASP.NET Core 9 Minimal APIs](https://learn.microsoft.com/aspnet/core)  
- [Entity Framework Core](https://learn.microsoft.com/ef/core/)  
- [SQLite](https://www.sqlite.org/)  
- [Swagger / Swashbuckle](https://github.com/domaindrivendev/Swashbuckle.AspNetCore)  
- C# 12  

---

## 🚦 Como Executar

1. Clone o repositório:
```bash
   git clone https://github.com/SeuUsuario/CatalogoProdutosMinimalAPI.git
   cd CatalogoProdutosMinimalAPI
```

2. Restaure pacotes:
```bash
   dotnet restore
```

3. Crie um banco de dados:
```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
```

4. Execute o projeto:
```bash
   dotnet run
````

5. Acesse:
   - Swagger: http://localhost:5209/swagger
   - Listar produtos: http://localhost:5209/products

---

## ✨ Principais aprendizados 

Durante o desenvolvimento deste projeto, aprimorei conhecimentos fundamentais de desenvolvimento backend com .NET:

- Minimal APIs → criar endpoints enxutos, rápidos e sem boilerplate
- Entity Framework Core → mapear entidades e gerenciar migrações
- SQLite → usar um banco leve para protótipos e aprendizado
- Swagger → documentar e testar APIs sem precisar de ferramentas externas
- Boas práticas de organização → separar models, data context e endpoints

---

## ✨ Desafios e soluções

Durante o desenvolvimento deste projeto, aprimorei conhecimentos fundamentais de desenvolvimento backend com .NET:

- Configuração inicial do EF Core: entender como criar e aplicar migrações corretamente → Solução: estudo da documentação oficial e prática com dotnet ef.
- Erros de top-level statements: compreender a restrição de apenas um Program.cs com esse formato → Solução: ajuste da estrutura de arquivos e limpeza do projeto.
- SQLite → usar um banco leve para protótipos e aprendizado
- Listagem inicial vazia ([]): entender que era o comportamento esperado do JSON sem dados → Solução: inserir registros via Swagger e validar o fluxo CRUD.

Esses desafios foram fundamentais para consolidar meu entendimento sobre o ciclo de vida de uma Minimal API.

---

## 🎯 Próximos Passos

Durante o desenvolvimento deste projeto, aprimorei conhecimentos fundamentais de desenvolvimento backend com .NET:

- Implementar autenticação JWT para proteger endpoints
- Criar entidade Categoria e relacionar com Produtos
- Deploy gratuito no Railway ou Azure
- Adicionar testes unitários

---

## 👩‍💻 Autora

Feito com ❤️ por Emilyn

- 📌 [LinkedIn](https://www.linkedin.com/in/emilynsfer013)
- 🚀 Focada em desenvolvimento .NET e soluções inovadoras

---


