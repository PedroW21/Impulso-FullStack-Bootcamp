/*
Entrada
.
A primeira linha contém um inteiro T representando o tipo de vinho (1 ≤ T ≤ 4). A segunda linha contém cinco inteiros A, B, C, D e 
E, que indica a resposta dada por cada competidor (1 ≤ A, B, C, D, E ≤ 4).

Saída
.
A saída contém um inteiro representando o número de concorrentes que obtiveram a resposta correta

*/

let opcaoCorreta = gets();
let chutes = gets().split(' ');

//TODO: Complete o código com uma possível solução para o problema.
let acertos = 0;

for (let chute = 0; chute <= chutes.length; chute++)
  if (chutes[chute] == opcaoCorreta) acertos++

console.log(acertos);