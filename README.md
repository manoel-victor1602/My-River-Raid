# My-River-Raid
Desenvolvimento do jogo River Raid para processo seletivo de est�gio no Samsung Ocean

O jogo deste projeto cont�m algumas das funcionalidades do River Raid original, al�m delas foi incrementado um Menu Principal e um Menu de Instru��es.

No jogo � poss�vel voar ir com o avi�o para a esquerda, direita e atirar nos inimigos que aparecer�o na frente do avi�o do jogador.

A movimenta��o na vertical � o mapa, ent�o n�o fica a cargo do jogador.

Do Menu Principal � poss�vel ir para o a Tela de Jogo a partir do bot�o "Novo Jogo" ou para a Tela de Instru��es a partir do bot�o "Instru��es".

Na Tela de Instru��es h� algumas explica��es, quantos pontos cada inimigo d� e os comandos que � poss�vel executar.

Como caso base para testes pode ser considerado:

	- Iniciar o jogo.
	- Clicar no bot�o "Instru��es" para ir ao Menu de Instru��es.
	- O jogador ser� redirecioando para o Menu de Instru��es.
	- Ler as instru��es.
	- Clicar no bot�o Voltar do Menu de Instru��es para voltar ao Menu Principal.
	- Clicar no bot�o Novo Jogo.
	- O jogador ser� redirecionado para a tela do jogo.
	- O jogador poder� jogar o jogo, indo para a esquerda, direita e atirando nos inimigos que aparecer�o.
	- Atirar na ponte quando esta aparecer.
	- Ao explodir inimigos o jogador ir� ganhar pontos de acordo com as pontua��es no Menu de Instru��es.
	- Se o jogador conseguir chegar a 1.000.000 (um milh�o) o jogo termina, o avi�o do jogador explode e na pontua��o aparece "!!!!!!" indicando que o jogador venceu o jogo.

O jogador pode morrer ao encostar nos inimigos, em postos de combust�vel, pontes ou nas bordas do mapa.

O jogador pode morrer quando o marcador do tanque de combust�vel chegar em "E" (vazio).

Algumas dificuldades foram encontradas e n�o foi possivel adicionar ao projeto:
	
	- N�o foi poss�vel implementar o Jato do jogo original.
	- Inimigos podem ser destru�dos mesmo que n�o estejam no campo de vis�o do jogador.
	- Os inimigos podem explodir o avi�o do jogador mesmo que este j� o tenha explodido.
	- Os inimigos podem aparecer em lugares inusitados, como em cima da terra.
	- Os sons originais do jogo n�o foram encontrados, assim o jogo ficou sem som.
	- N�o foi descoberto como fazer o tanque do jogador abastecer ao passar por cima do combust�vel, assim esta funcionalidade foi alterada, neste projeto o jogador deve explodir o posto de combust�vel para abastecer.
	- Os inimigos podem ficar presos quando se encontram no mesmo eixo Y de um posto de combust�vel.
	- Apesar de os postos de combust�vel estarem com as propriedades parecidas dos inimigos, foi poss�vel impedir que eles subam quando s�o acertados por um tiro.
	- Sempre ser� o mesmo cen�rio que ir� se repetir.