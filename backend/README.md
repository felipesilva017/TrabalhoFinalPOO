# 🚀 Configurando o Backend - API AdoCAO - Adoção de Animais

Este projeto é uma API para gerenciar a adoção de animais. Ele utiliza .NET 6, Entity Framework Core com um banco de dados em memória e Swagger para documentação da API.

## 📌 Requisitos

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/)

## 🛠️ Configuração do Projeto

1. **Clone o repositório:**

2. **Abra a solução no Visual Studio 2022:**

   Abra o arquivo `API_Adocao_Animais.sln` no Visual Studio 2022.

3. **Restaurar pacotes NuGet:**

   No Visual Studio, vá para o Gerenciador de Soluções, clique com o botão direito na solução e selecione `Restaurar Pacotes NuGet`.

4. **Compilar a solução:**

   No Visual Studio, vá para `Compilar` > `Compilar Solução` ou pressione `Ctrl+Shift+B`.

5. **Executar a aplicação:**

   No Visual Studio, defina o projeto `API_Adocao_Animais.Application` como projeto de inicialização. Em seguida, pressione `F5` para iniciar a aplicação.

## 📂 Estrutura do Projeto

- **API_Adocao_Animais.Application**: Contém a API e a configuração do pipeline de requisição.
- **API_Adocao_Animais.Domain**: Contém as entidades e interfaces do domínio.
- **API_Adocao_Animais.Service**: Contém os serviços de aplicação.
- **API_Adocao_Animais_Infrastructure**: Contém a configuração do Entity Framework Core e o contexto do banco de dados.

## 🚀 Endpoints Principais

### 📌 Animais
- `GET /api/animais` - Lista todos os animais
- `POST /api/animais` - Adiciona um novo animal
- `DELETE /api/animais/{id}` - Remove um animal

### 📌 Adotantes
- `GET /api/adotantes` - Lista todos os adotantes
- `POST /api/adotantes` - Registra um novo adotante

## 🛠 Tecnologias Utilizadas
- .NET 6
- ASP.NET Core Web API
- Entity Framework Core (InMemory Database)
- Swagger para documentação


## Dados Iniciais

A aplicação inicializa com alguns dados iniciais para facilitar o teste:

- **Abrigo**:
  - Id: 1
  - Nome: "Abrigo Central"
  - Endereço: "Rua Principal, 123"

- **Animais**:
  - Cachorro:
    - Id: 1
    - Nome: "Rex"
    - Idade: 3
    - AbrigoId: 1
  - Gato:
    - Id: 2
    - Nome: "Mia"
    - Idade: 2
    - AbrigoId: 1

## Contribuição

Se você deseja contribuir com este projeto, por favor, siga os passos abaixo:

1. Faça um fork do repositório.
2. Crie uma branch para sua feature (`git checkout -b feature/nova-feature`).
3. Commit suas mudanças (`git commit -am 'Adiciona nova feature'`).
4. Faça o push para a branch (`git push origin feature/nova-feature`).
5. Crie um novo Pull Request.

## Licença

Este projeto está licenciado sob a [MIT License](LICENSE).

