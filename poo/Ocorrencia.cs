using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo
{
    public class Ocorrencia
    {
        private DateOnly data;
        private DateTime horas;
        public static List<Ocorrencia> ocorrencias_list = new List<Ocorrencia>();

        public DateOnly Data
        { get { return this.data; }
            set { this.data = value; }
        }
        public DateTime Horas
        { get { return this.horas; }
            set { this.horas = value; }
              public void AdicionarListaOcorencia(Ocorrencia ocorrencia_new)
        {

            ocorrencias_lista.Add(ocorrencia_new);
        }
        public static void InformacaoOcorrencia()
        {
            foreach (var medico in ocorrencias_lista)
            {

                Console.WriteLine(medico.ToString());
            }
}
