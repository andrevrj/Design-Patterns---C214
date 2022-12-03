using System;
using Questao1.Model;
using Questao1.Controller;

namespace Questao1 {

    class Program{
        public static void Main(String [] args){
            Console.WriteLine("---------------Lista Telefônica---------------");
            
            Telefone telefone = new Telefone("Sabrina", 1995, "Avenida Brasil");
            Telefone telefone1 = new Telefone("Pedro", 1985, "Rua do Samba");
            Telefone telefone2 = new Telefone("André", 1966, "Rua da Pedra");

            telefone.telefone = "(35)1234-5678";
            telefone1.telefone = "(35)9876-4567";
            telefone2.telefone = "(35)2345-7895";


            List<Telefone> tels = new List<Telefone>();
            tels.Add(telefone);
            tels.Add(telefone1);
            tels.Add(telefone2);

            Console.WriteLine("---------Lista Original----------");
            foreach(Telefone t in tels){
                t.mostraInfo();
            }

            Console.WriteLine("\n-----------OddEvenSort - Numero-----------");
            Numero numero = new Numero(tels);
             foreach(Telefone t in numero.ordenar())
            {
                t.mostraInfo();
            }

            Console.WriteLine("\n-----------BubbleSort - DDD----------");
            DDD ddd = new DDD(tels);
             foreach(Telefone t in ddd.ordenar())
            {
                t.mostraInfo();
            } 
            
            Console.WriteLine("\n-----------QuickSort - Operadora-----------");
            Operadora operadora = new Operadora(tels);
             foreach(Telefone t in operadora.ordenar())
            {
                t.mostraInfo();
            }
        }
    }
}