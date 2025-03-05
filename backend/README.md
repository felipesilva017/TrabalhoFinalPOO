
2. **Abra a solu��o no Visual Studio 2022:**

   Abra o arquivo `API_Adocao_Animais.sln` no Visual Studio 2022.

3. **Restaurar pacotes NuGet:**

   No Visual Studio, v� para o Gerenciador de Solu��es, clique com o bot�o direito na solu��o e selecione `Restaurar Pacotes NuGet`.

4. **Compilar a solu��o:**

   No Visual Studio, v� para `Compilar` > `Compilar Solu��o` ou pressione `Ctrl+Shift+B`.

5. **Executar a aplica��o:**

   No Visual Studio, defina o projeto `API_Adocao_Animais.Application` como projeto de inicializa��o. Em seguida, pressione `F5` para iniciar a aplica��o.

## Estrutura do Projeto

- **API_Adocao_Animais.Application**: Cont�m a API e a configura��o do pipeline de requisi��o.
- **API_Adocao_Animais.Domain**: Cont�m as entidades e interfaces do dom�nio.
- **API_Adocao_Animais.Service**: Cont�m os servi�os de aplica��o.
- **API_Adocao_Animais_Infrastructure**: Cont�m a configura��o do Entity Framework Core e o contexto do banco de dados.

## Endpoints da API

Ap�s iniciar a aplica��o, voc� pode acessar a documenta��o da API gerada pelo Swagger em `http://localhost:5000/swagger`.

## Dados Iniciais

A aplica��o inicializa com alguns dados iniciais para facilitar o teste:

- **Abrigo**:
  - Id: 1
  - Nome: "Abrigo Central"
  - Endere�o: "Rua Principal, 123"

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

## Contribui��o

Se voc� deseja contribuir com este projeto, por favor, siga os passos abaixo:

1. Fa�a um fork do reposit�rio.
2. Crie uma branch para sua feature (`git checkout -b feature/nova-feature`).
3. Commit suas mudan�as (`git commit -am 'Adiciona nova feature'`).
4. Fa�a o push para a branch (`git push origin feature/nova-feature`).
5. Crie um novo Pull Request.

## Licen�a

Este projeto est� licenciado sob a [MIT License](LICENSE).

