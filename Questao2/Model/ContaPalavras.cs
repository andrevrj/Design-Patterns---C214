using Questao2.View;
using Questao2.Controller;

namespace Questao2.Model{

    public class ContaPalavras : IContaPalavras
    {
        private AnalisaPalavras analisaPalavras; 
        private int id;

        public ContaPalavras(int id){
            this.id = id;
            this.analisaPalavras = new AnalisaPalavras();
        }
        
        public void update(Palavras palavras)
        {
            this.analisaPalavras.calcula(palavras.getFrase());
            Console.WriteLine($"Observador {this.id}");
            Console.WriteLine($"Total de palavras: {this.analisaPalavras.totalPalavras}");
            Console.WriteLine($"Palavras com caracteres pares: {this.analisaPalavras.qtdParesCaracteres}");
            Console.WriteLine($"Palavras começadas com letras maiúsculas: {this.analisaPalavras.palavrasMaiusculas}");
            Console.WriteLine("-----------------------------------------------------");
        }
    }
}