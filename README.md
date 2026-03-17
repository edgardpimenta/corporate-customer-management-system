# Cadastro de Clientes em C#

Projeto desenvolvido em **C# (Console Application)** com o objetivo de praticar conceitos fundamentais de programação, organização de código e manipulação de arquivos.

---

## 📌 Objetivo do Projeto

Criar uma aplicação de console que permita **cadastrar clientes informando alguns dados básicos** e salvar essas informações em um **arquivo TXT** na máquina local.

O usuário informa os dados pelo console e o sistema grava as informações no arquivo utilizando **StreamWriter**.

---

## ⚙️ Funcionalidades

* Solicitar dados do cliente via console:

  * Nome
  * Email
  * Telefone

* Criar um objeto **Cliente**

* Registrar a **data e hora do cadastro**

* Salvar os dados em um **arquivo TXT**

---

## 🧠 Conceitos aplicados

Durante o desenvolvimento deste projeto foram utilizados conceitos importantes de C#:

* Classes e Objetos
* Propriedades (`get` / `set`)
* Organização em **camadas**
* Separação de responsabilidades
* Manipulação de arquivos com **StreamWriter**
* Uso de **DateTime**

---

## 🏗 Estrutura do Projeto

```
CadastroDeClientes
│
├── Entities
│   └── Cliente.cs
│
├── Repositories
│   └── ClienteRepository.cs
│
├── Program.cs
│
└── README.md
```

**Entities**

* Representa as entidades do sistema.

**Repositories**

* Responsável por salvar os dados no arquivo.

**Program**

* Responsável pela interação com o usuário no console.

---

## 💻 Exemplo de Execução

Entrada informada pelo usuário no console:

```
Nome: João
Email: joao@email.com
Telefone: 219999999
```

---

## 📄 Resultado Gerado

Após o cadastro, os dados são salvos em um **arquivo TXT** no computador.

Exemplo do conteúdo do arquivo:

```
João;joao@email.com;219999999;17/03/2026 00:30
```

---

## 🧪 Resultado do Projeto

Aqui você pode adicionar um **print do programa rodando** ou do **arquivo TXT gerado**.

## Execução do programa

![Execução](CadastrodeClientes/Images/execucao.jpeg)

## Arquivo TXT gerado

![Resultado](CadastrodeClientes/Images/resultado.jpeg)
---

## 🚀 Tecnologias utilizadas

* C#
* .NET
* Console Application

---

## 👨‍💻 Autor

Edgard Pimenta

GitHub:
https://github.com/edgardpimenta
