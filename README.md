# Projeto DoeFácil

**Plataforma de Doações e Recebimentos**

## Introdução

A doação é um ato de solidariedade que reflete a generosidade de um coração altruísta. O **DoeFácil** foi desenvolvido para facilitar o processo de doação de alimentos, roupas, brinquedos, livros e outros itens essenciais, conectando doadores a beneficiários de forma organizada, acessível e eficiente. Este README resume os principais pontos da documentação técnica do projeto.

## 1. Visão Geral da Aplicação

* **Cadastro de Doadores e Beneficiários:** Registro de usuários com informações básicas (nome, email, telefone, endereço, CPF, tipo de pessoa).
* **Categorização de Doações:** Itens classificados por categoria (alimentos, vestuário, brinquedos, livros etc.).
* **Geolocalização para Retirada de Itens:** Consulta de CEP e exibição de mapa; opção de retirada pelo beneficiário ou entrega pelo doador.
* **Sistema de Comunicação Direta:** Contato via WhatsApp ou chamada telefônica.
* **Público-Alvo:** Indivíduos solidários, comunidades carentes, empresas e parceiros sociais.

## 2. Arquitetura

### 2.1 Tecnologias

* **Frontend:** HTML5, CSS3 (Bootstrap), JavaScript
* **Backend:** C# (.NET 7), SQLite, Dapper
* **APIs Externas:** Serviço de CEP/endereçamento, WhatsApp link
* **Ambientes de Desenvolvimento:** Visual Studio, VS Code

### 2.2 Estrutura de Diretórios

```
Projeto-DoeFacil/
├── backend caminho: C:\SUA_PASTA\Projeto-DoeFacil-master\projeto extensao\back-end\ProjetoDoacao        # Código C# e configuração do .NET
│   ├── Controllers/  # DoacaoController, UsuarioController, LoginController
│   ├── Models/       # Usuario, Doacao, Login
│   ├── Repositories/ # DoacaoRepository, UsuarioRepositorio, LoginRepositorio
│   └── ConexaoDB.cs  # Classe de conexão SQLite
├── frontend caminho: C:\SUA_PASTA\Projeto-DoeFacil-master\projeto extensao\projeto-Ext      # Páginas HTML, CSS, JS (login, cadastro, doar, receber, histórico)
├── database caminho: C:\SUA_PASTA\Projeto-DoeFacil-master\projeto extensao\DB       # Arquivo SQLite e scripts de criação de tabelas

```

## 3. Instalação e Execução

**Etapa 1:**

* Extraia o arquivo ZIP em alguma pasta no disco \**C:\** do computador.

**Etapa 2:**

* Abra o Explorador de Arquivos e navegue até o caminho: `C:\SUA_PASTA\Projeto-DoeFacil-master\projeto extensao\back-end\ProjetoDoacao`.
* É necessário ter o **Visual Studio Code** instalado para dar dois cliques e abrir o arquivo **ProjetoDoacao.sln**.

**Etapa 3:**

* Clique em **ProjetoDoacao - appsettings.json** (Microsoft Visual Studio), dessa forma irá abrir os códigos.

**Etapa 4:**

* Em `appsettings.json`, localize a linha que define o caminho do banco de dados ( linha que contém "DefaultConnection": "Data Source=C:\\Projeto_GIT\\Projeto-DoeFacil-master\\projeto extensao\\DB\\projeto.db")
* Apague o trecho de caminho atual (ficará desta forma após apagado: "DefaultConnection": "Data Source=DB\\projeto.db").
* Abra o Explorador de Arquivos, acesse a pasta "DB".
* Copie este caminho e cole no lugar do texto apagado no `appsettings.json` (deverá ficar desta forma: "DefaultConnection": "Data Source=C:\\SUA_PASTA \\Projeto-DoeFacil-master\\projeto extensao\\DB\\projeto.db"

**Etapa 5:**

* Execute a depuração do projeto (`Debug`). Deve abrir um terminal e, depois, o navegador com a página **Swagger**, indicando que o back-end está rodando.

**Etapa 6:**

* No Explorador de Arquivos, navegue até `C:\SUA_PASTA\Projeto-DoeFacil-master\projeto extensao\projeto-Ext\login.html`.
* Dê dois cliques em **login.html** para abri-lo no navegador e usar a aplicação.

## 4. Manual do Usuário

### 4.1 Criação de Conta e Login

1. Acesse a tela de login (`frontend/login.html`).
2. Clique em **Cadastre-se aqui**, preencha o formulário e confirme.
3. Faça login com email e senha.

### 4.2 Realizar Doação

1. No menu, selecione **Eu quero Doar**.
2. Preencha os dados do item e escolha a forma de retirada.
3. Clique em **Cadastrar Doação**.

### 4.3 Receber Doação

1. Selecione **Doações Disponíveis**.
2. Clique em um item, visualize detalhes e contate via WhatsApp ou ligação.

### 4.4 Histórico de Doações

1. Acesse **Meu Histórico** no menu.
2. Use os botões **✓ Doado** e **🗑 Excluir** para gerenciar seus itens.

## 5. Conclusão

O projeto cumpriu seu propósito de organizar e simplificar o processo de doação, promovendo impacto social positivo e facilitando a comunicação entre doadores e beneficiários. A arquitetura em camadas (MVC) e o uso de SQLite garantem manutenção e escalabilidade.

## Referências

* **Bootstrap.** *Bootstrap Documentation – Getting Started: Introduction.*
* **Git.** *Pro Git Book.*
* **Microsoft.** *Documentação C#.*
* **SQLite Consortium.** *Documentação do SQLite.*
* **W3Schools.** *HTML Tutorial; JavaScript Tutorial; CSS Tutorial*


* 
