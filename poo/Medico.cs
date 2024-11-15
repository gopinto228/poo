using poo.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo
{
    public class Medico : Pessoa
    {
        private EspecialidadeEnum especialidade;
        private int numero_ordem_dos_medicos;
        public static List<Medico> medicos_lista = new List<Medico>();

        public EspecialidadeEnum Especialidade
        {
            get { return this.especialidade; }
            set
            {
                this.especialidade = value;
            }
        }

        public int Numero_Ordem_Dos_Medicos
        {
            get { return this.numero_ordem_dos_medicos; }
            set { this.numero_ordem_dos_medicos = value; }
        }

        public Medico(int id, string nome, string email, int numero_telefone, TurnoEnum turno, DateOnly data_aniversario, EspecialidadeEnum especialidade, int numero_ordem_dos_medicos) : base(id, nome, email, numero_telefone, data_aniversario, turno)
        {
            this.especialidade = especialidade;
            this.numero_ordem_dos_medicos = numero_ordem_dos_medicos;
        }

        public void AdicionarListaMedico(Medico medico_new)
        {

            medicos_lista.Add(medico_new);
        }

        public override string ToString()
        {
            string outStr = String.Format("Id: {0}, Nome: {1}, Email: {2}, NumeroTelefone: {3}, Turno: {4}, DataAniversario: {5}, Especialidade: {6}, NumeroOrdemDosMedicos: {7}", Id, Nome, Email, Numero_Telefone, Turno, Data_aniversario, Especialidade, Numero_Ordem_Dos_Medicos);
            return outStr;
        }

        public static void InformacaoMedico()
        {
            foreach (var medico in medicos_lista)
            {
                
                Console.WriteLine(medico.ToString());
            }
        }
    }
}
