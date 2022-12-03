using Questao1.Controller;

namespace Questao1.Model{

    public class Operadora : ListaTelefonica
    {
        public Operadora(List<Telefone> telefones){
            this.telefones = telefones;
            this.iOrdenacao = new OrdenaOperadora();
        } 
    }
}