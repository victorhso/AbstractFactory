# Abstract Factory
 
## Intenção
Segundo Erich Gamma, este padrão tem como objetivo fornecer para a criação de famílias de objetos relacionados ou dependentes sem especificar suas classes concretas.

## Aplicabilidade
Use o padrão quado: 

- Um sistema deve ser independente de como seus produtos são criados, compostos ou representados;
- Um sistema deve ser configurado como um produto de uma família de múltiplos produtos;
- Uma família de objetos-produto for projetada para ser usada em conjunto, e você necessita garantir esta restrição;
- Você quer fornecer uma biblioteca de classes de produtos e quer revelar somente suas interfaces, não suas implementações.

## Participantes
- Abstract Factory (DBfactory)
  - Declara uma interface para operações que criam objetos-produtos abstratos.
- Concrete Factory (OracleFactory, SQLfactory)
	- Implementa as operações que criam objetos-produto concretos.
- Abstract Product (DBcommand, DBconnection)
	- Declara uma interface para um tipo de objeto-produto.
	- Implementa a interface de Abstract Product.
- Concrete Product (OracleCommand, OracleConnection , SQLcommand, SQLconnection)
	- Define um objeto-produto a ser criado pelo correspondente fábrica concreta.
- Client (Program)
	- Usa somente interfaces declaradas pelas classes Abstract Factory Product.

## Vantagens / Desvantagens
	1. Ele isola as classes concretas
	2. Ele torna fácil a troca de famílias de produtos.
	3. Ela promove a harmonia entre produtos.
	4. É difícil de suportar novos tipos de produtos.
  
  ## REFERENCIA
  > GAMMA, E.; HELM, R.; JOHNSON, R.; BLISSIDES, J.; **Padrões de Projeto Soluções reutilizáveis de software orientado a objetos**, Porto Alegre, 2000.
