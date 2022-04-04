/*
Entrada
A primeira linha da entrada é composta por um número inteiro T que indica a quantidade de casos de testes. Cada caso de teste é composto por uma cadeia de caracteres de tamanho N (1 < N < 26). Todos os caracteres são letras maiúsculas ou minúsculas do alfabeto inglês.

Saída
Caso o vilão alguma vez já foi capturado pelo Batmain, imprima Y. Caso contrário, imprima N. Nesse caso, por simplicidade, assumiremos que qualquer cadeia de caracteres é um vilão válido e já capturado pelo Batmain, ok?
*/

let numeroCasos = parseInt(gets());

let viloes = gets();

for (let i = 0; i < numeroCasos; i++) {

    viloes.length > 1 && typeof viloes === "string" ? console.log("Y") : null;
    
}