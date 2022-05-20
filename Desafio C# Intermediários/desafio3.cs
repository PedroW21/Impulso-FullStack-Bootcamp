/*

Entrada
Cada caso de teste inicia com um inteiro N, indicando quantos minutos faltam para o final do expediente (2 <= N <= 100).

Em seguida haverá dois inteiros A e B, indicando quantos minutos são necessários para fabricar os dois presentes que Dobby precisa fabricar (1 <= A, B <= 100).

Saída
Imprima uma linha, contendo a frase "Farei hoje!" caso seja possível fabricar os dois presentes antes do final do expediente, ou "Deixa para amanha!" caso contrário.

*/


using System;

//TODO: Complete os espaços em branco com uma possível solução para o problema. 
class MinhaClasse {
  public static void Main (string[] args) {
    string[] line1 = Console.ReadLine().Split(" "); // recebe a primeira informaçãp
    string[] line2 = Console.ReadLine().Split(" "); // recebe a segunda informação bruta, transformando em um array
    
    
    int finalExpediente = int.Parse(line1[0]);
    

    int presente1 = int.Parse(    line2[0]        );
    int presente2 = int.Parse(      line2[1]      );
    
    
    int totalNecessario =  presente1 + presente2;
    
    if (      totalNecessario > finalExpediente                       )
    {
      Console.WriteLine("Deixa para amanha!");
    }
    else
    {
      Console.WriteLine("Farei hoje!");
    }
  }
}