/*
Entrada
A entrada consiste de múltiplos casos de teste, e cada um consiste em duas linhas: A primeira linha contém um inteiro L (1 ≤ L ≤ 500) representando o número de tartarugas do grupo, e a segunda linha contém L inteiros Vi (1 ≤ Vi ≤ 50) representando as velocidades de cada tartaruga do grupo.

Saída
Para cada caso de teste, imprima uma única linha indicando o nível de velocidade da tartaruga mais veloz do grupo.

*/


//TODO: Complete os espaços em branco com uma possível resolução para o problema.
for(let j = 0; j<3;j++)
{
  let number = parseInt(gets()); // qtd tartarugas
  let velocity = gets().split(" "); // suas velocidades
  let max = 0;
  let level = 0;

  for(i = 0 ; i < number; i++){
    if(max < parseInt(velocity[i])){ //se 0 menor que 10
      max = parseInt(velocity[i]); // maximo vira 10
    }
  }
  
  if(max < 10 ){
    level = 1;
  }
  else if(max >= 10 && max < 20 ){
    level = 2;
  } 
  else{
    level = 3;
  }
  console.log(level);
}