using poo.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo
{
    public class Bombeiro : Pessoa
    {
        
        private int numero_ordem_dos_bombeiros;
        public static List<Bombeiro> bombeiros_lista = new List<Bombeiro>();

        
        

        public int Numero_Ordem_Dos_Bombeiros
        {
            get { return this.numero_ordem_dos_bombeiros; }
            set { this.numero_ordem_dos_bombeiros = value; }
        }

        public Bombeiro(int id, string nome, string email, int numero_telefone, TurnoEnum turno, DateOnly data_aniversario, int numero_ordem_dos_bombeiros) : base(id, nome, email, numero_telefone, data_aniversario, turno)
        {
            
            this.numero_ordem_dos_bombeiros = numero_ordem_dos_bombeiros;
        }

        public void AdicionarListaBombeiro(Medico bombeiro_new)
        {

            bombeiros_lista.Add(bombeiro_new);
        }

        public override string ToString()
        {
            string outStr = String.Format("Id: {0}, Nome: {1}, Email: {2}, NumeroTelefone: {3}, Turno: {4}, DataAniversario: {5}, NumeroOrdemDosBombeiros: {6}", Id, Nome, Email, Numero_Telefone, Turno, Data_aniversario, );
            return outStr;
        }

        public static void InformacaoBombeiro()
        {
            foreach (var bombeiro in bombeiro_lista)
            {

                Console.WriteLine(bombeiro.ToString());
            }
        }
    }
}
    

