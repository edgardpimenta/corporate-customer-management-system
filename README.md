## 📈 Project Evolution

Este projeto foi criado com o objetivo de praticar e consolidar conhecimentos em **desenvolvimento backend com C# e .NET**.
O sistema está sendo desenvolvido de forma **incremental**, onde cada versão adiciona novos conceitos e melhorias na arquitetura.

---

### 🟢 v1 — Console Application + TXT Storage

Primeira versão funcional do sistema de cadastro de clientes.

**Principais características:**

* Cadastro de clientes via aplicação **Console**
* Captura de dados do usuário (`nome`, `email`, `telefone`)
* Persistência de dados em arquivo `.txt`
* Utilização de `StreamWriter` para gravação dos registros
* Estrutura inicial do projeto com separação de responsabilidades:

  * `Entities`
  * `Repositories`

Essa versão teve como objetivo praticar **fundamentos de C#**, manipulação de arquivos e organização básica de código.

---

### 🟡 v2 — Integração com Banco de Dados SQL *(Em desenvolvimento)*

Nesta etapa o sistema evolui para utilizar **banco de dados relacional** em vez de arquivos `.txt`.

**Objetivos da versão:**

* Conectar a aplicação a um banco de dados SQL
* Criar a tabela `Clientes`
* Persistir dados utilizando `SqlConnection`
* Melhorar a camada de acesso a dados (Repository)

Essa etapa introduz conceitos de **persistência de dados e integração com banco de dados**.

---

### 🔵 v3 — Validações e Melhor Organização do Código

Foco em melhorar a **qualidade e estrutura do código**.

**Melhorias planejadas:**

* Implementação de camada de **validações**
* Validação de campos obrigatórios:

  * Nome
  * Email
  * Telefone
* Melhor separação de responsabilidades no projeto
* Código mais limpo e organizado seguindo boas práticas

Essa fase reforça conceitos importantes de **arquitetura e manutenção de software**.

---

### 🚀 v4 — Próximos Passos

Possíveis evoluções futuras do projeto:

* Implementação de **CRUD completo de clientes**
* Criação de um **menu interativo no console**
* Transformação do projeto em uma **API REST com ASP.NET**
* Aplicação de princípios **SOLID**
* Possível criação de uma **interface web**

O objetivo final é evoluir o projeto de um **exercício de console** para uma **aplicação backend mais completa**.
