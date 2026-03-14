# Reactivities

Aplicação full-stack para gestão de atividades e comunidades, com backend em **ASP.NET Core** e frontend em **React + TypeScript**.

## Visão geral

O projeto foi estruturado em camadas, separando domínio, regras de aplicação, persistência e infraestrutura. No lado cliente, a aplicação usa React moderno com React Query, MobX e Material UI.

### Principais capacidades

- Cadastro, edição, listagem e remoção de atividades.
- Participação em atividades (attend/unattend).
- Fluxos de autenticação com ASP.NET Identity (registro, login, confirmação de e-mail e recuperação de senha).
- Perfis de usuário e recursos sociais (seguidores/seguidos).
- Comentários em tempo real com SignalR.
- Upload e gerenciamento de fotos com Cloudinary.
- API paginada e validada com FluentValidation + MediatR.

## Arquitetura

### Backend (.NET)

- **API**: camada HTTP, autenticação/autorização, SignalR e middleware global de exceção.
- **Application**: casos de uso (commands/queries), validações e mapeamentos.
- **Domain**: entidades centrais de negócio.
- **Persistence**: DbContext, migrations e seed de dados.
- **Infrastructure**: integrações externas (e-mail, fotos, segurança).

### Frontend (React)

- **Vite + React 19 + TypeScript**
- **React Router** para navegação.
- **TanStack Query** para estado assíncrono/cache.
- **MobX** para estado de aplicação.
- **Material UI** para UI.

## Tecnologias

- .NET 9 (ASP.NET Core Web API)
- Entity Framework Core + SQL Server
- ASP.NET Core Identity
- MediatR + FluentValidation
- SignalR
- React 19 + TypeScript + Vite
- Docker Compose (SQL Server)

## Pré-requisitos

- .NET SDK 9+
- Node.js 20+
- Docker e Docker Compose

## Como executar localmente

### 1) Subir banco de dados

Na raiz do projeto:

```bash
docker compose up -d
```

Isso inicia um SQL Server local na porta `1433`.

### 2) Backend

```bash
dotnet restore
cd API
dotnet run
```

A API aplica migrations automaticamente ao iniciar.

### 3) Frontend

Em outro terminal:

```bash
cd client
npm install
npm run dev
```

Aplicação web disponível em `https://localhost:3000`.

## Variáveis de ambiente

### Backend

Arquivo principal para desenvolvimento:

- `API/appsettings.Development.json`

A conexão padrão já aponta para o SQL local do `docker-compose`.

### Frontend

Arquivos:

- `client/.env.development`
- `client/.env.production`

Variáveis importantes:

- `VITE_API_URL`
- `VITE_COMMENTS_URL`
- `VITE_GITHUB_CLIENT_ID`
- `VITE_REDIRECT_URL`

> **Atenção:** não exponha chaves sensíveis em commits públicos.

## Build de produção

### Frontend

```bash
cd client
npm run build
```

O build é gerado em `API/wwwroot` (configurado no Vite), permitindo servir o SPA diretamente pela API.

### Backend

```bash
dotnet build Reactivities.sln
```

## Estrutura do repositório

```text
Reactivities/
├─ API/
├─ Application/
├─ Domain/
├─ Infrastructure/
├─ Persistence/
├─ client/
├─ docker-compose.yml
└─ Reactivities.sln
```

## Roadmap sugerido

- Testes automatizados (unitários e integração).
- CI/CD para build, lint e migrations.
- Observabilidade (logs estruturados, tracing e métricas).
- Hardening de segurança (rate limiting, CSP, secrets management).

## Licença

Defina a licença do projeto (ex.: MIT, Apache-2.0, proprietária) antes de distribuição pública.
