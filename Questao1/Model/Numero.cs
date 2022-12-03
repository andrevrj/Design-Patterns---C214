using Questao1.Controller;

namespace Questao1.Model{

    public class Numero : ListaTelefonica
    {
        public Numero(List<Telefone> telefones){
            this.telefones = telefones;
            this.iOrdenacao = new OrdenaNumero();
        }
    }
}