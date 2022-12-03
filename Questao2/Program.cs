using Questao2.Model;

namespace Questao2{
   
    class Program{
        public static void Main(String [] args){

            Palavras palavras = new Palavras();

            ContaPalavras cp1 = new ContaPalavras(1);
            ContaPalavras cp2 = new ContaPalavras(2);
            ContaPalavras cp3 = new ContaPalavras(3);

            palavras.registraContador(cp1);
            palavras.registraContador(cp2);
            palavras.registraContador(cp3);

            Console.WriteLine(palavras.getContadores().Count());

            palavras.setNovaFrase("Frase um para testeee!!");
            
            palavras.removeContador(cp3);
            palavras.setNovaFrase("Mais uma frase nova para teste!!");
            
        }
    } 
}