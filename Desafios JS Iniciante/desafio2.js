/* No planeta Alpha vive a criatura Blobs, que come precisamente 1/2 de seu suprimento de comida disponível todos os dias.
 Escreva um algoritmo que leia a capacidade inicial de suprimento de comida (em Kg), 
 e calcule quantos dias passarão antes que Blobs coma todo esse suprimento até restar um quilo ou menos. */

 // Entrada 

 //A primeira linha de entrada contem um único inteiro N (1 ≤ N ≤ 1000), indicando o número de casos de teste. As N linhas seguintes contém um valor de ponto flutuante 
 // C (1 ≤ C ≤ 1000) correspondente à quantidade de comida disponível para Blobs.

 var n = parseInt(gets());

 //implemente sua solução nos espaços em branco
 
 while (n >=       && n <=        ) {
   var c = parseFloat(gets());
   
 var dias =     ;
   while ( c >       && c <=        ) {
     c = c / 2.0;
     dias++;
   }
   n--;
   print(`${dias}  dias`);
 }