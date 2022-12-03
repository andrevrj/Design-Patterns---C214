using System.Text.RegularExpressions;
using Questao2.View;

namespace Questao2.Controller{
    public class AnalisaPalavras{
        private string [] palavras;
        private Regex regex = new Regex("([A-Z].*)");
        public int totalPalavras{get; set;}
        public int qtdParesCaracteres{get; set;} 
        public int palavrasMaiusculas{get; set;}

        public void calcula(string frase){
            frase = frase.Replace(".", "");
            frase = frase.Replace(",", "");
            frase = frase.Replace("?", "");
            frase = frase.Replace("!", "");

            palavras = frase.Split();

            this.totalPalavras = 0;
            this.qtdParesCaracteres = 0;
            this.palavrasMaiusculas = 0;

            foreach(string palavra in palavras)
            {
                if((palavra.ToCharArray().Length) % 2 == 0){
                    this.qtdParesCaracteres++;
                }
                
                if(regex.IsMatch(palavra)){
                    this.palavrasMaiusculas++;
                }
                this.totalPalavras++;
            }
        }
    }
}