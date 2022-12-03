using System.Text.RegularExpressions;

namespace Questao1.Model{

    public class Telefone : Pessoa
    {
        public Telefone(string nome, int anoNasc, string endereco)
         : base(nome, anoNasc, endereco){}

        private int _ddd;
        private int _operadora;

        private string _numero = "";
        
        private static string regra = @"^\(([1-9]){2}\)(?:([0-9]{5})|([0-9]{4}))-([0-9]{4})$"; // regex para validar numero (xx)xxxxx-xxxx ou (xx)xxxx-xxxx
        Regex regex = new Regex(regra);

        public string telefone{
            get{return _numero;} 
            set{
                if(regex.IsMatch(value)){
                    this._numero = value;
                    string operadora = "";

                    char [] charNumero = this._numero.ToCharArray();

                    string ddd = charNumero[1].ToString() + charNumero[2].ToString();
                    this._ddd = int.Parse(ddd);

                    for(int i = (this._numero.IndexOf(")") + 1); i < this._numero.IndexOf("-"); i++){
                        operadora = operadora + charNumero[i].ToString();
                    }
                    this._operadora = int.Parse(operadora);

                }
                else{
                    throw new ArgumentException("Telefone no formato inválido");
                }
            }
        }

        public override void mostraInfo(){
            base.mostraInfo();
            Console.WriteLine($"Telefone: {this._numero}");
            Console.WriteLine("-----------------------------------");
        }

        public int getDDD(){
            return this._ddd;
        }

        public int getOperadora(){
            return this._operadora;
        }

        public long getNumero(){
            string num = this._numero.Replace("(", "");
            num = num.Replace(")", "");
            num = num.Replace("-", "");
            long numero = long.Parse(num);
            return numero;
        }
    }
}