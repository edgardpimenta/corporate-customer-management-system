📈 Project Evolution

Este projeto consiste em um sistema de gestão de clientes corporativos, desenvolvido com o objetivo de aplicar e evoluir conceitos de backend com C# e .NET, seguindo boas práticas de arquitetura e modelagem de domínio.

O sistema simula um cenário real onde uma empresa pode gerenciar múltiplos clientes, aplicando validações, regras de negócio e controle de dados.

---

🟢 v1 — Console Application + TXT Storage

Primeira versão funcional do sistema, com foco em fundamentos.

✔ Cadastro de clientes via console  
✔ Captura de dados (nome, email, telefone)  
✔ Persistência em arquivo .txt  
✔ Uso de StreamWriter  
✔ Estrutura inicial com separação de responsabilidades  

Objetivo: consolidar fundamentos de C# e manipulação de dados.

Status: ✅ Finalizado 

---

🟡 v2 — Modelagem de Domínio + Relacionamentos

Nesta versão, o projeto evolui de uma estrutura básica para uma abordagem mais próxima de aplicações reais, com foco em organização, domínio e separação de responsabilidades.

🚀 Principais melhorias

✔ Modelagem de Domínio aprimorada

Introdução da entidade Empresa
Estruturação do relacionamento 1 (Empresa → Clientes)
Uso de encapsulamento nas entidades (private set) para maior controle das regras de negócio

✔ Aplicação de Enumerações (Enums)

Implementação de StatusCliente (Ativo, Inativo, Bloqueado)
Implementação de TipoCliente (Pessoa Física, Pessoa Jurídica)
Uso dos enums dentro da lógica de domínio (não apenas estrutural)

✔ Separação de camadas (Arquitetura)

Introdução da camada de Controllers para orquestração das requisições
Criação da camada de Repositories para acesso a dados
Organização inicial visando baixo acoplamento

✔ Uso de DTOs (Data Transfer Objects)

Separação entre entrada e saída de dados
Evita exposição direta das entidades do domínio
Preparação para escalabilidade e versionamento de API

✔ Validações no domínio

Regras de negócio movidas para dentro das entidades
Redução de lógica nos controllers
Maior consistência e proteção do modelo de dados
🎯 Objetivo da versão

Aplicar conceitos fundamentais de:

Modelagem de domínio
Boas práticas em orientação a objetos
Separação de responsabilidades
Estruturação inicial em camadas

Status: ✅ Finalizado 

---

🔵 v3 — Regras de Negócio e Validações

Foco em consistência e integridade dos dados.

✔ Validação de CPF, Email e Nome  
✔ Separação entre validação e regra de negócio  
✔ Regras como:
   - Cliente bloqueado não pode executar determinadas ações  

Objetivo: garantir integridade e confiabilidade do sistema.

---

🟣 v4 — Persistência com Banco de Dados (Em breve)

✔ Integração com SQL Server  
✔ Implementação de repositórios  
✔ Verificação de CPF único  
✔ Uso de ORM (Entity Framework)

---

🚀 v5 — API REST (Planejado)

✔ Transformação em API com ASP.NET Core  
✔ Endpoints RESTful  
✔ Autenticação e autorização (JWT)  
✔ Aplicação de princípios SOLID  
✔ Estrutura baseada em Clean Architecture  

---

🎯 Objetivo do Projeto

Desenvolver um sistema evolutivo que simula um ambiente real de backend, consolidando conhecimentos em:

- C#
- .NET
- Arquitetura de Software
- Modelagem de Domínio
- Boas práticas de desenvolvimento
