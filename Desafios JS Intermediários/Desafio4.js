/*
Entrada
A entrada consiste de várias linhas e cada uma contém uma string que descreve uma das jóias de Pedro Bento. Essa string é composta apenas dos caracteres '(' e ')', a soma do tamanho de todas as string não excede 106.

Saída
Imprima quantos tipos de jóias distintas Pedro Bento possui.
*/

let jewels = []; 

while(true) {
    
    let input = gets();
    
    if(!input) {
        
        break;
    
    }
  
    let find = jewels.find(el => el == input);
  
    if(!find) {
        
        jewels.push(input);
  
    }
}

console.log(jewels.length);

/* COMO ESTAVA NA PLATAFORMA DA DIO
const joias = [];
const isUnique = [];
let count = 0;

do {
  const value = gets();
  if (value == '') {
    break;
  } else {
    array.push(value);
  }
} while (true);


 for (item       array) {
   if (!isUnique.includes(item)) isUnique.push(  item   );
}

const result = isUnique.length    ;

console.log(result);
*/