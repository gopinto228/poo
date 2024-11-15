using poo;
using poo.Enum;

namespace Projeto_Unidades_Socorro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Enfermeiro enfermeiro1 = new Enfermeiro(1, "Maria", "maria@gmail.com", 923709172, TurnoEnum.diurno, DateOnly.Parse("05-04-1978"), 5, null);
            Enfermeiro enfermeiro2 = new Enfermeiro(2, "Pedro", "pedro@gmail.com", 915843791, TurnoEnum.diurno, DateOnly.Parse("07-11-1998"), 5, enfermeiro1);
            enfermeiro1.AdicionarListaEnfermeiro(enfermeiro1);
            enfermeiro2.AdicionarListaEnfermeiro(enfermeiro2);
            Enfermeiro.InformacaoEnfermeiro();
            Console.WriteLine("\n");

            Medico medico1 = new Medico(1, "Mario", "mario24@outlook.pt", 908632867, TurnoEnum.noturno, DateOnly.Parse("06-12-1988"), EspecialidadeEnum.cardiologia, 261836);
            medico1.AdicionarListaMedico(medico1);
            Medico.InformacaoMedico();
            Console.WriteLine("\n");
        }
    }
}