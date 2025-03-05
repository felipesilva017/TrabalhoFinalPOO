# Projeto Final de POO - AdoCÃO - Adoção de Animais

## Toda a documentação necessária de setup está nas pastas de frontend e backend separadamente.

## Aqui está uma descrição detalhada do funcionamento da API, organizada conforme os requisitos do trabalho final:

✅ Criação de pelo menos 7 classes

A API possui as seguintes classes:

Animal (abstrata)
Cachorro (herda de Animal)
Gato (herda de Animal)
Abrigo
Pessoa (abstrata)
Adotante (herda de Pessoa)
AdocaoService (implementa a interface IAdocaoService)

✅ Implementação de pelo menos 3 heranças

A API utiliza herança nas seguintes classes:

Cachorro herda de Animal
Gato herda de Animal
Adotante herda de Pessoa

✅ Utilização de pelo menos 5 associações

A API estabelece associações entre classes:

Abrigo contém uma lista de Animal
Adotante possui um AnimalAdotado
AdocaoService gerencia uma lista de Animal
O controlador AnimaisController utiliza IAdocaoService
AdocaoService implementa a interface IAdocaoService

✅ Utilização de 2 classes abstratas ou interfaces

A API implementa:

A classe abstrata Animal, que define um método EmitirSom() a ser implementado por subclasses
A interface IAdocaoService, que define métodos de adoção e listagem de animais

✅ Implementação de pelo menos 3 chamadas com polimorfismo

A API contém chamadas polimórficas nos seguintes pontos:

Cachorro e Gato sobrescrevem EmitirSom() (uso de polimorfismo de método)
O controlador AnimaisController chama GetTodosAnimais() sem precisar conhecer a implementação específica do serviço
O método AdotarAnimal() recebe um objeto Animal genérico, permitindo adoção de qualquer tipo de animal

✅ Utilização dos 3 modificadores de acesso

A API utiliza:

public em classes e métodos acessíveis externamente (ex.: GetTodosAnimais())
protected na classe Pessoa para restringir acesso a subclasses
private para o atributo totalAnimais da classe Animal, garantindo encapsulamento

✅ Uso de um atributo estático e um método estático'

A API contém:

Atributo estático totalAnimais na classe Animal, contando o número de instâncias criadas
Método estático GetTotalAnimais() na classe Animal, retornando o total de animais criados
