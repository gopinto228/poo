using poo.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo
{
    public class Instituicao
    {
        private TipoInstituicao Enum tipo_de_instituiçao
        private string nome;



        public TipoInstituicaoEnum Especialidade
        {
            get { return this.tipo_de_Instituicao; }
            set
            {
                this.tipo_de_instituicao = value;
            }

        public string nome
        {
            get { return this.nome; }
            set { this.nome = value; }


            public static void InformacaoInstituicao()
        {
            foreach (var instituicao in instituicao_lista)
            {

                Console.WriteLine(instituicao.ToString());
            }
        }
    }
}
