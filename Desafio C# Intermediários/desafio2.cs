/*

Desafio
Você terá o desafio de ler um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma loja, e informe-o expresso no formato horas:minutos:segundos.

Entrada
O arquivo de entrada contém um valor inteiro N.

Saída
Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos, conforme exemplo fornecido.


*/

using System;

    class MinhaClasse {
        static void Main(string[] args) {
          
            var timeInSeconds = int.Parse(Console.ReadLine());
            
            //var timeInSeconds = int.Parse(Console.ReadLine());
            //TODO: Implementar a formula para calcular as horas.
            
            var hours = timeInSeconds / 3600;
            //timeInSeconds = timeInSeconds % (       );
            //TODO: Implementar a formula para calcular as horas.
            //var minutes = timeInSeconds / 60;
           // var seconds = timeInSeconds - (minutes * 60);
            
            int calcMin = (hours * 3600);
            
            int minutes =  (timeInSeconds - calcMin) / 60;
            int seconds = timeInSeconds - (minutes * 60); 

            Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }
    }

