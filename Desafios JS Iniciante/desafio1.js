/*

Entrada
A primeira linha contém um inteiro N, indicando o número de casos de teste a seguir.

Cada caso de teste inicia com um inteiro M (1 ≤ M ≤ 1000), indicando o número de clientes. Em seguida haverá M inteiros distintos Pi (1 ≤ Pi ≤ 1000), onde o i-ésimo inteiro indica o número recebido via sms do i-ésimo cliente.

Os inteiros acima são dados em ordem de chegada, ou seja, o primeiro inteiro diz respeito ao primeiro cliente a chegar na fila, o segundo inteiro diz respeito ao segundo cliente, e assim sucessivamente.

Saída
Para cada caso de teste imprima uma linha, contendo um inteiro, indicando o número de clientes que não precisaram trocar de lugar mesmo após a fila ser reordenada.

*/



let numeroCasos = 3;
let clientes = [3, 100, 80, 90]; // 3 clientes, 1o = 100, 2o = 80, 3o = 90


// Resolução oficial

const nCasos = parseInt(gets());
let nClientes = [];
let senhas = [];


for (let n = 0; n < nCasos; n++) {
  nClientes[n] = parseInt(gets());
  senhas[n] = gets().split(' ');


  let senhasOrdenadas = Array.from(senhas[n]).sort((a, b) => b - a);
  let contadorSemTroca = 0;
  
  for (let i = 0; i < senhas[n].length; i++) {
    senhas[n][i] === senhasOrdenadas[i] && (contadorSemTroca++);
  }
  console.log(contadorSemTroca);
}



// Resolução (tentada)

// a função gets é implementada dentro do sistema para ler as entradas(inputs) dos dados
// let numeroCasos = gets();

// for(testaCasos=0; testaCasos < numeroCasos; testaCasos++) { // roda o codigo para numeroDeCasos

// let qtdClientes = parseInt(gets()); // pois a cada novo loop geral, a qtd pode mudar
  
// let senhaClientes = gets().split(" ")
// let ordenaMaiorPraMenor = senhaClientes.sort((a,b) => b-a); //ordena do maior para o menor
    
//   var mudouPosicao = 0; //guarda quantas posições mudaram

//   for(i = 0; i <= ordenaMaiorPraMenor.length; i++) {
      

//     if(ordenaMaiorPraMenor[i] - senhaClientes[i] > 0){
//       mudouPosicao++
//     } 
    
//   }
  
//     console.log(mudouPosicao);
    
    
// // }
