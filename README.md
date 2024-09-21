# SOLID Express

Síntese do curso **SOLID Express**, parte integrante do [FullCycle 3.0](https://curso.fullcycle.com.br/curso-fullcycle/) by [Full Cycle](https://fullcycle.com.br/)

## Introdução ao SOLID: Princípios de Boas Práticas na Programação Orientada a Objetos

No mundo do desenvolvimento de software, especialmente em projetos orientados a objetos, seguir boas práticas é essencial para garantir um código limpo, de fácil manutenção e escalável. Um dos pilares fundamentais para isso é o conjunto de princípios conhecido como **SOLID**. Este artigo tem como objetivo introduzir esses princípios, que foram formulados como um guia para programadores que desejam melhorar suas habilidades e a qualidade de seu código.

**O que é SOLID?**: SOLID é um acrônimo que representa cinco princípios fundamentais de design de software. Esses princípios foram consolidados por **Robert C. Martin**, também conhecido como **Uncle Bob**, um dos signatários do Manifesto Ágil e autor de diversas obras importantes, como o livro *Agile Software Development: Principles, Patterns, and Practices* e *Clean Code*. O SOLID surgiu como uma forma de organizar e estruturar o código em linguagens orientadas a objetos, promovendo a manutenção, extensão e flexibilidade de software.

Cada letra do acrônimo representa um princípio:

1. **S** - **Single Responsibility Principle (SRP)**: Princípio da Responsabilidade Única.
2. **O** - **Open/Closed Principle (OCP)**: Princípio do Aberto/Fechado.
3. **L** - **Liskov Substitution Principle (LSP)**: Princípio da Substituição de Liskov.
4. **I** - **Interface Segregation Principle (ISP)**: Princípio da Segregação de Interfaces.
5. **D** - **Dependency Inversion Principle (DIP)**: Princípio da Inversão de Dependência.

**A Origem dos Princípios SOLID**: Esses princípios não surgiram por acaso, mas foram desenvolvidos ao longo dos anos com base nas experiências de Robert C. Martin e outros desenvolvedores renomados. A primeira vez que o conceito de SOLID foi introduzido foi em seu livro sobre desenvolvimento ágil, e rapidamente se tornou um referencial para desenvolvedores em todo o mundo.

Cada princípio do **SOLID** tem um papel específico na melhoria da estrutura do código, ajudando a resolver problemas comuns que ocorrem em projetos orientados a objetos, como acoplamento excessivo, dependências complexas e dificuldade de manutenção.

**Entendendo os Princípios**: Aqui está uma visão geral dos princípios **SOLID**:

1. **SRP (Single Responsibility Principle)** – Este princípio afirma que uma classe deve ter apenas uma responsabilidade, ou seja, ela deve executar uma única função ou propósito. Isso facilita a manutenção, pois mudanças em uma funcionalidade específica não devem impactar outras áreas do código.
2. **OCP (Open/Closed Principle)** – Um sistema deve ser **aberto para extensão**, mas **fechado para modificação**. Isso significa que podemos adicionar novas funcionalidades sem alterar o código existente, evitando a introdução de novos erros em partes já testadas.
3. **LSP (Liskov Substitution Principle)** – As subclasses devem poder substituir suas superclasses sem quebrar a lógica da aplicação. Em outras palavras, objetos de uma classe derivada devem poder ser utilizados como objetos da classe base, sem afetar o comportamento do programa.
4. **ISP (Interface Segregation Principle)** – Esse princípio recomenda que interfaces específicas sejam criadas para cada necessidade, ao invés de uma interface genérica e grande. Isso evita que os clientes de uma interface sejam forçados a implementar métodos que não utilizam.
5. **DIP (Dependency Inversion Principle)** – As classes de alto nível não devem depender de classes de baixo nível. Ambas devem depender de abstrações. Esse princípio promove a flexibilidade ao garantir que as dependências sejam injetadas de forma a permitir a substituição fácil de componentes.

**Conclusão**: Os princípios **SOLID** são guias valiosos para qualquer desenvolvedor que deseje escrever código orientado a objetos com qualidade, favorecendo a manutenibilidade e a escalabilidade do software. Cada princípio aborda um aspecto crucial do design de software, e a sua aplicação prática resulta em soluções mais robustas, flexíveis e fáceis de evoluir. Nos próximos artigos, vamos explorar cada princípio em detalhes, começando com o **Single Responsibility Principle**. Fique ligado!

Até o próximo artigo!

## Single Responsibility Principle: Entendendo o Primeiro Princípio do SOLID

O **Single Responsibility Principle** (SRP), ou Princípio da Responsabilidade Única, é o primeiro dos cinco princípios fundamentais do SOLID. Esses princípios foram desenvolvidos para guiar os desenvolvedores a escreverem um código orientado a objetos mais limpo, modular e fácil de manter. O SRP é considerado um dos mais simples de entender, mas também um dos mais poderosos, quando aplicado corretamente.

**O que é o Single Responsibility Principle?**: O SRP define que **uma classe deve ter apenas uma única responsabilidade**. Em outras palavras, uma classe deve ser responsável por executar apenas uma tarefa ou função dentro de um sistema. Sempre que uma classe começa a ter várias funções, ela acaba se tornando difícil de manter e propensa a falhas, pois cada nova responsabilidade introduzida aumenta a complexidade.

A forma prática de verificar se uma classe está violando o SRP é se perguntar: **essa classe tem mais de um motivo para mudar?** Se a resposta for sim, ela provavelmente está fazendo mais do que deveria e precisa ser refatorada.

**Exemplo Prático de Violação do SRP**: Vamos considerar uma classe chamada `Course`, que armazena atributos relacionados a um curso, como `Name`, `Category` e `Description`. Além de armazenar dados, essa classe também possui métodos para:

- Criar uma conexão com o banco de dados.
- Adicionar uma nova categoria ao curso.
- Persistir dados no banco.

Esse cenário exemplifica uma clara violação do SRP. A classe está acumulando responsabilidades que vão além do seu propósito principal. A função de **conectar ao banco de dados** e a **persistência de dados** não deveriam estar presentes dentro da mesma classe que define os atributos de um curso.

O código começa a se tornar complicado, pois uma alteração no método de conexão, por exemplo, poderia afetar outras funcionalidades da classe que não deveriam estar relacionadas. Isso quebra a coesão e introduz uma alta complexidade desnecessária.

**Como Corrigir?**: Uma solução mais adequada seria:

1. **Entidade Anêmica**: A classe `Course` deveria ser apenas uma entidade anêmica, ou seja, conter apenas **getters** e **setters** para os atributos do curso, sem lógica adicional.
2. **Categoria em uma Classe Própria**: A lógica de adicionar ou modificar uma categoria poderia ser delegada para uma classe separada, especializada no gerenciamento de categorias.
3. **Repositório para Conexão**: A responsabilidade de conexão e persistência de dados deveria ser transferida para um **repositório** dedicado, seguindo o padrão de repositório. Esse repositório seria responsável por todas as interações com o banco de dados.

Com essa abordagem, cada classe teria uma responsabilidade única e bem definida, tornando o código mais organizado e fácil de dar manutenção.

**Conclusão**: O **Single Responsibility Principle** é uma regra fundamental para manter a simplicidade e a modularidade em sistemas orientados a objetos. Sempre que você perceber que uma classe está se expandindo em termos de responsabilidades, é hora de reavaliar sua estrutura. A aplicação do SRP não apenas facilita a manutenção do código, mas também ajuda a evitar bugs e tornar o sistema mais escalável a longo prazo.

No próximo artigo, continuaremos explorando os princípios do SOLID, passando para o próximo da lista: o **Open/Closed Principle**. Até lá!

## O Princípio do Aberto/Fechado (Open/Closed Principle) no SOLID

O Open/Closed Principle, ou Princípio do Aberto/Fechado, é o segundo princípio do SOLID e talvez um dos mais fundamentais na orientação a objetos. Ele estabelece que uma classe deve estar aberta para extensão, mas fechada para modificação. Em termos práticos, isso significa que uma classe deve permitir a adição de novos comportamentos sem que seu código-fonte original precise ser alterado. Vamos explorar como aplicar esse princípio de forma efetiva em nossos projetos de software.

**Entendendo o Conceito**: A ideia central do Open/Closed Principle é que uma classe deve estar preparada para receber novos comportamentos sem precisar ser modificada. Quando alteramos uma classe constantemente para adicionar funcionalidades, acabamos aumentando sua complexidade e risco de introduzir bugs. Portanto, em vez de editar o código de uma classe existente, devemos estender sua funcionalidade.

Considere um cenário em que temos uma classe que calcula o interesse do público por um vídeo. Dependendo do tipo de vídeo (filme, série, anime), o cálculo varia. Um jeito comum de implementar isso é com condicionais, como `if` ou `switch`, verificando o tipo e aplicando a lógica correspondente. O problema com essa abordagem é que, a cada novo tipo de vídeo, precisamos adicionar mais condicionais, o que torna o código difícil de manter e modificar.

**Exemplo Prático: Calculando Interesse de Vídeos**: Imaginemos uma classe `Video` que possui um método para calcular o interesse do público:

```java
public class Video {
    private String _type; // tipo do vídeo

    public int calculateInterest() {
        if (_type.equals("movie")) {
            // Lógica para calcular interesse em filmes
        } else if (_type.equals("tvShow")) {
            // Lógica para calcular interesse em séries
        } else if (_type.equals("anime")) {
            // Lógica para calcular interesse em animes
        }
        return 0;
    }
}
```

Toda vez que precisarmos adicionar um novo tipo de vídeo, teremos que modificar a classe `Video`, violando o princípio do Aberto/Fechado.

Para resolver isso, aplicamos o Open/Closed Principle criando uma classe base abstrata `Video` e subclasses específicas para cada tipo de vídeo. Veja como fica a implementação:

```java
public abstract class Video {
    public abstract int calculateInterest();
}

public class Movie extends Video {
    @Override
    public int calculateInterest() {
        // Lógica para calcular interesse em filmes
    }
}

public class TVShow extends Video {
    @Override
    public int calculateInterest() {
        // Lógica para calcular interesse em séries
    }
}
```

Agora, podemos adicionar novos tipos de vídeos criando novas subclasses sem modificar o código existente. Isso torna o sistema extensível e fácil de manter.

**Benefícios da Aplicação do Open/Closed Principle**:

1. **Facilidade de Manutenção:** Como o código existente não precisa ser modificado, a probabilidade de introduzir novos bugs é reduzida.
2. **Extensibilidade:** Novos comportamentos podem ser adicionados sem alterar o código legado.
3. **Reuso de Código:** Partes do sistema podem ser reutilizadas em diferentes contextos, evitando duplicação.

**Conclusão**: O Open/Closed Principle incentiva o uso de herança e polimorfismo para criar sistemas flexíveis e extensíveis. Ao aplicá-lo, evitamos a criação de classes monolíticas e complexas, favorecendo a modularização e a simplicidade. Sempre que percebermos que uma classe está se tornando um "monstro" com muitas condições, devemos reavaliar sua estrutura e considerar a aplicação desse princípio para manter o código limpo e sustentável.

Esperamos que este artigo tenha esclarecido como aplicar o Open/Closed Principle na prática. Fique ligado para mais conteúdos sobre os princípios do SOLID e como eles podem transformar sua forma de desenvolver software!

## Entendendo o Princípio da Substituição de Liskov (LSP)

O Princípio da Substituição de Liskov (LSP) é um dos cinco princípios do SOLID, um conjunto de diretrizes para o desenvolvimento de software orientado a objetos, criado para garantir que o código seja mais robusto e fácil de manter. O LSP recebe seu nome em homenagem à cientista da computação Barbara Liskov, que introduziu esse conceito fundamental na engenharia de software. Mas, afinal, o que significa esse princípio e como ele pode ser aplicado na prática?

**Definição do Princípio**: O Princípio da Substituição de Liskov estabelece que subclasses devem ser substituíveis por suas classes base sem alterar o comportamento esperado do sistema. Em outras palavras, se uma classe `X` é estendida por uma classe `Y`, então `Y` deve poder substituir `X` sem causar nenhum impacto negativo no funcionamento do programa. Isso significa que as subclasses devem manter a interface e o comportamento esperados pela classe base, garantindo que qualquer instância da classe base possa ser substituída por uma instância da subclasse sem problemas.

**Exemplos Práticos**: Para facilitar o entendimento, vamos analisar um exemplo comum no mundo da orientação a objetos. Imagine que temos uma classe `Movie` que possui métodos como `play` e `increaseVolume`. Agora, criamos uma subclasse chamada `TheLionKing` que herda de `Movie`. De acordo com o LSP, podemos substituir `Movie` por `TheLionKing` em qualquer parte do código, pois `TheLionKing` é um filme e deve se comportar como tal.

```csharp
using System;

// Classe base que representa um filme genérico
public class Movie
{
    public virtual void Play()
    {
        Console.WriteLine("Reproduzindo o filme.");
    }

    public virtual void IncreaseVolume()
    {
        Console.WriteLine("Aumentando o volume do filme.");
    }
}

// Subclasse que representa o filme The Lion King
public class TheLionKing : Movie
{
    // Herda o comportamento padrão de Movie
    public override void Play()
    {
        Console.WriteLine("Reproduzindo O Rei Leão.");
    }

    public override void IncreaseVolume()
    {
        Console.WriteLine("Aumentando o volume d'O Rei Leão.");
    }
}

// Subclasse que representa o filme mudo Modern Times
public class ModernTimes : Movie
{
    // Override do método Play para o filme mudo
    public override void Play()
    {
        Console.WriteLine("Reproduzindo Tempos Modernos.");
    }

    // Método IncreaseVolume não deve existir, pois ModernTimes é mudo.
    // Em vez disso, vamos lançar uma exceção para indicar que esse método não é aplicável.
    public override void IncreaseVolume()
    {
        throw new InvalidOperationException("Não é possível aumentar o volume de um filme mudo.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Usando The Lion King como substituto para Movie - válido
        Movie lionKing = new TheLionKing();
        lionKing.Play();
        lionKing.IncreaseVolume();

        // Usando Modern Times como substituto para Movie - vai lançar exceção
        Movie modernTimes = new ModernTimes();
        modernTimes.Play();

        try
        {
            modernTimes.IncreaseVolume();
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

```

```csharp
Movie movie = new TheLionKing();
movie.play(); // Isso deve funcionar sem problemas
```

Neste exemplo, o código continua a funcionar como esperado, pois `TheLionKing` herda e respeita a interface de `Movie`.

**Problemas de Violação do LSP**: Agora, considere uma classe chamada `ModernTimes`, que também estende `Movie`. Porém, `ModernTimes` é um filme mudo, como o famoso filme de Charlie Chaplin. Nesse caso, se tentarmos aumentar o volume de `ModernTimes`, um problema surgirá, pois ele não possui som.

```csharp
Movie movie = new ModernTimes();
movie.increaseVolume(); // Isso vai causar um problema, pois ModernTimes não tem som
```

Mesmo que `ModernTimes` seja tecnicamente um `Movie`, ele não respeita completamente a interface da classe base. Isso viola o LSP, pois, ao tentar substituir `Movie` por `ModernTimes`, o comportamento esperado não é mantido. Dessa forma, `ModernTimes` não deveria herdar de `Movie`, já que ele não pode cumprir todas as expectativas da classe base.

**Aplicando o LSP na Prática**: Para evitar a violação do LSP, é fundamental projetar suas classes e heranças de forma que todas as subclasses possam ser usadas de maneira intercambiável com suas classes base. Aqui estão algumas dicas para aplicar o LSP na prática:

1. **Utilize Interfaces**: Se uma classe base possui métodos que nem todas as subclasses conseguem implementar corretamente, considere usar interfaces mais específicas para evitar heranças inadequadas.
2. **Evite Modificar Comportamento Herdado**: Subclasses não devem modificar de forma significativa o comportamento herdado da classe base.
3. **Teste de Substituição**: Sempre que possível, substitua a classe base por subclasses em testes unitários para verificar se o comportamento esperado se mantém.

**Conclusão**: O Princípio da Substituição de Liskov é uma peça-chave para a construção de sistemas orientados a objetos robustos e flexíveis. Seguindo esse princípio, você garantirá que suas subclasses possam ser utilizadas de maneira intercambiável com suas classes base, sem alterar o comportamento esperado do sistema. Aplicar o LSP ajuda a evitar bugs e facilita a manutenção e evolução do código.

Então, da próxima vez que você estiver projetando uma hierarquia de classes, lembre-se de garantir que suas subclasses respeitem a promessa feita pela classe base. Isso tornará seu código mais confiável, reutilizável e preparado para mudanças futuras.

## Princípio da Segregação de Interfaces (ISP): Melhoria na Organização e Manutenção do Código

O Princípio da Segregação de Interfaces, conhecido como Interface Segregation Principle (ISP), é um conceito fundamental na programação orientada a objetos. Embora seja simples de entender, sua aplicação prática é crucial para evitar problemas comuns na implementação de classes. Neste artigo, discutiremos o ISP, o que ele representa e como aplicá-lo corretamente para melhorar a qualidade do seu código.

**O Que é o Princípio da Segregação de Interfaces?**: O ISP afirma que uma classe não deve ser forçada a implementar métodos de uma interface que ela não utilizará. Isso significa que interfaces grandes e com muitos métodos devem ser divididas em interfaces menores e mais específicas. Dessa forma, uma classe pode implementar apenas os métodos que realmente precisa, sem carregar a responsabilidade de métodos desnecessários.

**Problema Comum na Implementação de Interfaces**: Imagine que você tem uma interface chamada `IMovie` que define dois métodos: `Play()` e `IncreaseVolume()`. Agora, considere que você está criando duas classes diferentes que implementam essa interface:

1. **TheLionKing**: Esta classe representa um filme com áudio e deve implementar ambos os métodos `Play()` e `IncreaseVolume()`.
2. **ModernTimes**: Esta classe representa um filme mudo e, portanto, não precisa do método `IncreaseVolume()`.

Se `ModernTimes` for forçada a implementar `IncreaseVolume()`, ela teria que incluir um método que não faz sentido para seu contexto. Muitos desenvolvedores acabam deixando o método vazio ou lançando uma exceção, o que viola o princípio de que uma classe deve fazer sentido em todas as suas operações.

**Solução com o Princípio da Segregação de Interfaces**: Para resolver este problema, podemos aplicar o ISP de forma a separar os métodos em interfaces menores e mais coesas. No exemplo anterior, podemos criar duas interfaces:

- **IMovie**: com o método `Play()`.
- **IAudioControl**: com o método `IncreaseVolume()`.

Dessa forma, a classe `TheLionKing` pode implementar ambas as interfaces, enquanto a classe `ModernTimes` implementa apenas `IMovie`, evitando a implementação desnecessária de um método não utilizado.

**Código Exemplo**:

```csharp
// Interface que define o comportamento de um filme
public interface IMovie
{
    void Play();
}

// Interface separada para controle de áudio
public interface IAudioControl
{
    void IncreaseVolume();
}

// Classe que representa o filme The Lion King
public class TheLionKing : IMovie, IAudioControl
{
    public void Play()
    {
        Console.WriteLine("Reproduzindo O Rei Leão.");
    }

    public void IncreaseVolume()
    {
        Console.WriteLine("Aumentando o volume de O Rei Leão.");
    }
}

// Classe que representa o filme mudo Modern Times
public class ModernTimes : IMovie
{
    public void Play()
    {
        Console.WriteLine("Reproduzindo Tempos Modernos.");
    }
}
```

Neste exemplo, cada classe implementa apenas as interfaces que fazem sentido para ela. `TheLionKing` implementa `IMovie` e `IAudioControl`, enquanto `ModernTimes` implementa apenas `IMovie`.

**Benefícios da Segregação de Interfaces**: Aplicar o ISP traz várias vantagens:

1. **Coesão**: As classes são mais coesas, implementando apenas métodos que realmente usam.
2. **Facilidade de Manutenção**: Alterações em métodos de uma interface não afetam classes que não utilizam esses métodos.
3. **Legibilidade e Clareza**: Fica mais claro quais são as responsabilidades de cada classe e interface.
4. **Reusabilidade**: Interfaces menores e específicas podem ser reutilizadas em outros contextos sem sobrecarregar classes que as implementam.

**Conclusão**: O Princípio da Segregação de Interfaces é uma prática essencial para manter a organização e a clareza do código. Ele nos ajuda a evitar o erro comum de forçar classes a implementar métodos desnecessários, tornando o código mais fácil de entender e manter. Da próxima vez que você criar uma interface, lembre-se de avaliar se ela pode ser dividida em interfaces menores e mais específicas. Isso garantirá que suas classes implementem apenas o que realmente precisam, seguindo os princípios da programação orientada a objetos de forma mais eficiente.

## Entendendo o Princípio da Inversão de Dependência (DIP) em Projetos de Software

O Princípio da Inversão de Dependência (DIP) é o último dos cinco princípios SOLID, essenciais para a construção de software robusto e flexível. Ele pode parecer complexo à primeira vista, mas seu conceito é mais simples do que aparenta. Neste artigo, vamos desmistificar o DIP, mostrando como ele pode transformar a estrutura de seus projetos e facilitar a manutenção e escalabilidade do código.

**O Que é o Princípio da Inversão de Dependência?**: O DIP preconiza que módulos de alto nível não devem depender de módulos de baixo nível, mas ambos devem depender de abstrações. Em outras palavras, ao invés de dependermos diretamente de implementações concretas (classes específicas), devemos depender de interfaces ou classes abstratas, que representam contratos de comportamento. Isso significa que, ao desenvolvermos uma funcionalidade, precisamos projetá-la de forma que dependa de uma abstração ao invés de uma classe concreta.

**Entendendo na Prática**: Imagine que você tem uma classe `Movie` e deseja definir um atributo para armazenar o gênero do filme. Uma implementação inicial poderia ser algo como:

```java
class DramaCategory { }

class Movie {
    private String name;
    private DramaCategory category;

    public void setCategory(DramaCategory category) {
        this.category = category;
    }
}
```

Neste exemplo, a classe `Movie` depende diretamente de `DramaCategory`. Isso cria um forte acoplamento entre as duas classes, tornando difícil modificar ou estender o comportamento do sistema. Se quisermos adicionar novas categorias de filme, como comédia ou ação, será necessário alterar a classe `Movie`, violando o princípio de aberto-fechado (OCP) e dificultando a manutenção.

**Como Aplicar o DIP?**: Para aplicar o DIP, podemos introduzir uma interface que abstrai o comportamento das categorias de filme:

```java
interface Category { }

class DramaCategory implements Category { }
class ComedyCategory implements Category { }

class Movie {
    private String name;
    private Category category;

    public Movie(String name, Category category) {
        this.name = name;
        this.category = category;
    }
}
```

Agora, a classe `Movie` depende de `Category`, uma abstração, ao invés de depender de uma classe concreta específica. Com isso, podemos facilmente passar qualquer implementação de `Category` para a classe `Movie`, tornando o código mais flexível e aberto para extensões.

**Inversão de Controle**: Além de depender de abstrações, o DIP também sugere que devemos inverter o controle da criação das dependências. Ou seja, em vez de instanciar diretamente as dependências dentro da classe, passamos essas dependências por meio de um construtor ou de um método setter.

```java
class Movie {
    private String name;
    private Category category;

    public Movie(String name, Category category) {
        this.name = name;
        this.category = category;
    }

    // getters and setters
}
```

Ao usar um construtor ou setters, evitamos instanciar diretamente as classes dependentes dentro de `Movie`. Dessa forma, quando criamos um objeto `Movie`, passamos a dependência necessária:

```java
Movie movie = new Movie("Inception", new DramaCategory());
```

Se precisarmos mudar a categoria, podemos facilmente passar uma nova implementação de `Category`, como `ComedyCategory`, sem alterar a classe `Movie`.

**Vantagens do DIP**:

1. **Flexibilidade**: Com o DIP, podemos mudar ou estender o comportamento das classes sem modificá-las diretamente, facilitando a manutenção e evolução do sistema.
2. **Redução de Acoplamento**: Ao depender de abstrações, evitamos o acoplamento forte entre as classes, permitindo que elas sejam desenvolvidas e testadas de forma independente.
3. **Facilidade de Teste**: A injeção de dependências facilita a criação de testes unitários, pois podemos substituir as implementações concretas por mocks ou stubs.

**Conclusão**: O Princípio da Inversão de Dependência é uma poderosa ferramenta para melhorar a estrutura do código e garantir a flexibilidade necessária para a manutenção e evolução de um sistema. Aplicar o DIP envolve depender de abstrações, utilizando interfaces e classes abstratas, e garantir que a criação das dependências seja gerenciada fora das classes, por meio de injeção de dependências.

Ao adotar esse princípio, seu código se tornará mais modular, mais fácil de testar e, principalmente, preparado para futuras mudanças e extensões. Se você se pegar instanciando diretamente classes concretas em seu código, lembre-se: dependa de abstrações, não de implementações.

Um grande abraço e até o próximo artigo!
