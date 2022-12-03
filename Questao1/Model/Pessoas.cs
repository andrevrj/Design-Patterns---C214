namespace Questao1.Model{
    
    public abstract class Pessoa{
        public string nome{get;}
        public int anoNasc{get;}
        public string endereco{get;}

        public Pessoa(string nome, int anoNasc, string endereco){
            this.nome = nome;
            this.anoNasc = anoNasc;
            this.endereco = endereco;
        }

        public virtual void mostraInfo(){
            Console.WriteLine($"Nome: {this.nome}");
            Console.WriteLine($"Ano de Nascimento: {this.anoNasc}");
            Console.WriteLine($"Endereço: {this.endereco}");
        }
    }
}