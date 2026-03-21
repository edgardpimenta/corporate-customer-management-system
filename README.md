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

### 🟡 v2 — Modelagem de Domínio + Preparação para SQL *(Em desenvolvimento)*

Nesta etapa o projeto está sendo reestruturado para evoluir de um modelo simples para uma base mais próxima de sistemas reais.

**O que já foi implementado:**

* Criação da entidade `Empresa`
* Definição do relacionamento **1:N (Empresa → Clientes)**
* Criação de **Enums** para controle de status e tipos
* Implementação da camada de **Controllers**
* Separação de responsabilidades no projeto:

  * `Entities`
  * `Controllers`
  * `Validations`
  * `Enums`
* Início da camada de **Validações**
* Estrutura preparada para futura integração com banco de dados

**Objetivos da versão:**

* Integrar com banco de dados SQL
* Criar tabela `Clientes`
* Implementar verificação de regras como **CPF único**
* Persistir dados utilizando `SqlConnection` ou ORM futuramente

Essa etapa introduz conceitos de **modelagem de domínio, organização de código e preparação para persistência em banco de dados**.

---

### 🔵 v3 — Validações e Regras de Negócio

Foco em melhorar a **qualidade, consistência e regras do sistema**.

**Melhorias planejadas:**

* Implementação completa da camada de **validações**
* Validação de campos obrigatórios:

  * Nome
  * Email
  * CPF
* Implementação de **regras de negócio**, como:

  * Cliente bloqueado não pode realizar ações
* Melhor organização do código seguindo boas práticas
* Separação clara entre **validação e regra de negócio**

Essa fase reforça conceitos importantes de **arquitetura, domínio e manutenção de software**.

---

### 🚀 v4 — Próximos Passos

Possíveis evoluções futuras do projeto:

* Implementação de **CRUD completo de clientes**
* Criação de um **menu interativo no console**
* Transformação do projeto em uma **API REST com ASP.NET**
* Aplicação de princípios **SOLID**
* Integração com banco de dados utilizando ORM (Entity Framework)
* Possível criação de uma **interface web**
