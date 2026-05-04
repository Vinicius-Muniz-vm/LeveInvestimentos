# LeveInvestimentos

Este é um sistema web desenvolvido em ASP.NET Core MVC para a gestão de usuários e tarefas. O projeto inclui funcionalidades de autenticação, perfis de acesso (Gestores e Usuários), integração com a API ViaCEP para preenchimento de endereço e gestão completa de tarefas.

O banco de dados utilizado foi o Entity Framework Core (In-Memory Database) justamente para facilitar a avaliação do projeto, não exigindo configurações adicionais de banco de dados por parte do avaliador.

Abaixo, você encontra o passo a passo detalhado para rodar a aplicação em qualquer máquina.

## Passo a Passo para Execução da Aplicação

### Pré-requisitos
Para executar este projeto, é necessário ter o SDK do .NET instalado no seu computador.
1. Acesse o site oficial da Microsoft: [Download .NET](https://dotnet.microsoft.com/download)
2. Baixe e instale o **.NET 8.0 SDK** (ou uma versão superior).

### Passo 1: Baixar o Projeto
Você pode clonar este repositório via Git ou baixar o código fonte em formato ZIP.
- **Via Git:** Abra o seu terminal e execute o comando:
  ```bash
  git clone https://github.com/Vinicius-Muniz-vm/LeveInvestimentos.git
  ```
- **Via ZIP:** Na página inicial do repositório no GitHub, clique no botão "Code" e depois em "Download ZIP". Extraia o arquivo no seu computador.

### Passo 2: Acessar a pasta do projeto
Abra o seu terminal (Prompt de Comando, PowerShell ou terminal do VS Code) e navegue até a pasta onde o projeto foi extraído:
```bash
cd LeveInvestimentos
```

### Passo 3: Compilar e Executar
Ainda dentro do terminal, na raiz do projeto (onde está localizado o arquivo `LeveInvestimentos.csproj` e `Program.cs`), execute o seguinte comando:
```bash
dotnet run
```
Aguarde alguns segundos. O terminal exibirá mensagens de inicialização indicando que o servidor local foi iniciado.

### Passo 4: Acessar no Navegador
Quando o terminal exibir uma mensagem parecida com `Now listening on: http://localhost:5000`, abra o navegador de sua preferência e acesse o endereço fornecido. Geralmente será:
- `http://localhost:5000`

### Passo 5: Fazer o Login (Dados de Teste)
O banco de dados roda em memória, portanto começa vazio a cada nova execução. Para facilitar os testes, a aplicação já cria um usuário Gestor padrão automaticamente quando é iniciada.

Utilize as seguintes credenciais na tela de login para acessar o sistema:
- **Email:** ti@leveinvestimentos.com.br
- **Senha:** teste123

Com este login de Gestor, você terá acesso total para criar novos usuários, gerenciar tarefas e testar todas as funcionalidades desenvolvidas.
