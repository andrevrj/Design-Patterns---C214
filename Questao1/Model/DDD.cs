using Questao1.Controller;

namespace Questao1.Model{

    public class DDD : ListaTelefonica
    {
        public DDD(List<Telefone> telefones){
            this.telefones = telefones;
            this.iOrdenacao = new OrdenaDDD();
        } 
    }
}