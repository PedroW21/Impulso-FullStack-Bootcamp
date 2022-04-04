/*

Entrada
A primeira linha da entrada contém um inteiro L (1 ≤ L ≤ 1000) indicando o número de linhas do tabuleiro.
A segunda linha da entrada contém um inteiro C (1 ≤ C ≤ 1000) representando o número de colunas.

Saída
Imprima uma linha na saída. A linha deve conter um inteiro, representando a cor da casa no canto inferior direito do tabuleiro, e para identificar, considere o inteiro 1 para a cor branca e 0 para a cor preta.

*/

let lines = gets().split("\n");

var l = parseInt(lines[0]);
var c = parseInt(lines[1]);

if (l % 2 === 0) // se linha é par
  if (c % 2 === 0) print(1); // e coluna é par, sempre dara branco no tabuleiro (2com2,4com4)
  else print(0); // caso coluna impar, e linha CONTINUA par, sempre dará preto
else if (  c % 2 !==  0 ) print(  1  ); // caso coluna NÃO seja par, e linha é impar, é branca
 else print(  0   );      //e caso coluna é impar mas linha é par, sempre dara preto