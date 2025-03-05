# Projeto Final de POO - AdoCÃO - Adoção de Animais

## Descrição Geral

O **AdoCÃO** é um sistema desenvolvido para gerenciar a adoção de animais, permitindo a interação entre adotantes e abrigos. O sistema é composto por duas partes principais:

- **Backend**: API RESTful construída com **.NET 6**.
- **Frontend**: Interface de usuário responsiva desenvolvida com **Vite**, **React** e **Tailwind CSS**.

Toda a documentação de setup para o backend e frontend está organizada nas pastas respectivas.

---

## Funcionalidades da API

### ✅ Criação de pelo menos 7 classes

A API foi implementada com as seguintes classes:

- **Animal** (abstrata): Classe base para animais, com o método `EmitirSom()` a ser implementado pelas subclasses.
- **Cachorro** (herda de Animal): Representa a classe de cachorro.
- **Gato** (herda de Animal): Representa a classe de gato.
- **Abrigo**: Representa o abrigo responsável pelos animais.
- **Pessoa** (abstrata): Classe base para pessoas.
- **Adotante** (herda de Pessoa): Representa uma pessoa que adota animais.
- **AdocaoService** (implementa a interface `IAdocaoService`): Responsável pelos serviços de adoção de animais.

### ✅ Implementação de pelo menos 3 heranças

A API utiliza herança nas seguintes classes:

- **Cachorro** herda de **Animal**
- **Gato** herda de **Animal**
- **Adotante** herda de **Pessoa**

### ✅ Utilização de pelo menos 5 associações

As associações entre as classes foram implementadas da seguinte forma:

- **Abrigo** contém uma lista de **Animal**.
- **Adotante** possui um **AnimalAdotado**.
- **AdocaoService** gerencia uma lista de **Animal**.
- O controlador **AnimaisController** utiliza **IAdocaoService** para as operações de adoção.
- **AdocaoService** implementa a interface **IAdocaoService** para gerenciar as adoções.

### ✅ Utilização de 2 classes abstratas ou interfaces

Foram utilizadas as seguintes classes abstratas e interfaces:

- **Animal** (classe abstrata): Define o método `EmitirSom()`, que deve ser implementado pelas subclasses.
- **IAdocaoService** (interface): Define os métodos para adoção e listagem de animais, como `AdotarAnimal()` e `GetTodosAnimais()`.

### ✅ Implementação de pelo menos 3 chamadas com polimorfismo

A API faz uso de polimorfismo nos seguintes casos:

- **Cachorro** e **Gato** sobrescrevem o método **EmitirSom()** (polimorfismo de método).
- O controlador **AnimaisController** chama **GetTodosAnimais()** sem precisar conhecer a implementação específica do serviço.
- O método **AdotarAnimal()** recebe um objeto **Animal** genérico, permitindo a adoção de qualquer tipo de animal, seja cachorro ou gato.

### ✅ Utilização dos 3 modificadores de acesso

A API faz uso dos seguintes modificadores de acesso:

- **public**: Usado em classes e métodos acessíveis externamente (ex.: `GetTodosAnimais()`).
- **protected**: Usado na classe **Pessoa** para restringir acesso a subclasses.
- **private**: Usado para o atributo `totalAnimais` da classe **Animal**, garantindo encapsulamento.

### ✅ Uso de um atributo estático e um método estático

A API implementa:

- **Atributo estático `totalAnimais`** na classe **Animal**: Conta o número total de instâncias de animais criadas.
- **Método estático `GetTotalAnimais()`** na classe **Animal**: Retorna o total de animais criados, acessível sem a necessidade de instanciar a classe.

---
