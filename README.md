# My-River-Raid
Desenvolvimento do jogo River Raid para processo seletivo de estágio no Samsung Ocean

O jogo deste projeto contém algumas das funcionalidades do River Raid original, além delas foi incrementado um Menu Principal e um Menu de Instruções.

No jogo é possível voar ir com o avião para a esquerda, direita e atirar nos inimigos que aparecerão na frente do avião do jogador.

A movimentação na vertical é o mapa, então não fica a cargo do jogador.

Do Menu Principal é possível ir para o a Tela de Jogo a partir do botão "Novo Jogo" ou para a Tela de Instruções a partir do botão "Instruções".

Na Tela de Instruções há algumas explicações, quantos pontos cada inimigo dá e os comandos que é possível executar.

Como caso base para testes pode ser considerado:

	- Iniciar o jogo.
	- Clicar no botão "Instruções" para ir ao Menu de Instruções.
	- O jogador será redirecioando para o Menu de Instruções.
	- Ler as instruções.
	- Clicar no botão Voltar do Menu de Instruções para voltar ao Menu Principal.
	- Clicar no botão Novo Jogo.
	- O jogador será redirecionado para a tela do jogo.
	- O jogador poderá jogar o jogo, indo para a esquerda, direita e atirando nos inimigos que aparecerão.
	- Atirar na ponte quando esta aparecer.
	- Ao explodir inimigos o jogador irá ganhar pontos de acordo com as pontuações no Menu de Instruções.
	- Se o jogador conseguir chegar a 1.000.000 (um milhão) o jogo termina, o avião do jogador explode e na pontuação aparece "!!!!!!" indicando que o jogador venceu o jogo.

O jogador pode morrer ao encostar nos inimigos, em postos de combustível, pontes ou nas bordas do mapa.

O jogador pode morrer quando o marcador do tanque de combustível chegar em "E" (vazio).

Algumas dificuldades foram encontradas e não foi possivel adicionar ao projeto:
	
	- Não foi possível implementar o Jato do jogo original.
	- Inimigos podem ser destruídos mesmo que não estejam no campo de visão do jogador.
	- Os inimigos podem explodir o avião do jogador mesmo que este já o tenha explodido.
	- Os inimigos podem aparecer em lugares inusitados, como em cima da terra.
	- Os sons originais do jogo não foram encontrados, assim o jogo ficou sem som.
	- Não foi descoberto como fazer o tanque do jogador abastecer ao passar por cima do combustível, assim esta funcionalidade foi alterada, neste projeto o jogador deve explodir o posto de combustível para abastecer.
	- Os inimigos podem ficar presos quando se encontram no mesmo eixo Y de um posto de combustível.
	- Apesar de os postos de combustível estarem com as propriedades parecidas dos inimigos, foi possível impedir que eles subam quando são acertados por um tiro.
	- Sempre será o mesmo cenário que irá se repetir.