using poo.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo
{
    public class Enfermeiro : Pessoa
    {
        private int anos_servico;
        private Enfermeiro? enfermeiro_supervisor;
        public static List<Enfermeiro> enfermeiros_lista = new List<Enfermeiro>();
        public int Anos_Servico
        {
            get { return this.anos_servico; }
            set { this.anos_servico = value; }
        }

        public Enfermeiro? Enfermeiro_Supervisor
        {
            get { return this.enfermeiro_supervisor; }
            set { this.enfermeiro_supervisor = value; }
        }

        public Enfermeiro(int id, string nome, string email, int numero_telefone, TurnoEnum turno, DateOnly data_aniversario, int anos_servico, Enfermeiro enfermeiro_supervisor) : base(id, nome, email, numero_telefone, data_aniversario, turno)
        {
            this.anos_servico = anos_servico;
            this.enfermeiro_supervisor = enfermeiro_supervisor;
        }

        public void AdicionarListaEnfermeiro(Enfermeiro enfermeiro_new)
        {

            enfermeiros_lista.Add(enfermeiro_new);
        }

        public override string ToString()
        {
            string outStr = String.Format("Id: {0}, Nome: {1}, Email: {2}, NumeroTelefone: {3}, Turno: {4}, DataAniversario: {5}, AnosSevico: {6}, EnfermeiroSupervisor: {7}", Id, Nome, Email, Numero_Telefone, Turno, Data_aniversario, Anos_Servico, Enfermeiro_Supervisor);
            return outStr;
        }

        public static void InformacaoEnfermeiro()
        {
            foreach(var enfermeiro in enfermeiros_lista)
            {
                Console.WriteLine(enfermeiro.ToString());
            }
        }
    }


}
