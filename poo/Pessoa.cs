using poo.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo
{
    abstract public class Pessoa
    {
        private string nome;
        private int id;
        private string email;
        private int numero_telefone;
        private DateOnly data_aniversario;
        private TurnoEnum turno;

        public int Id
        {
            get { return this.id; }
            set
            {
                this.id = value;
            }
        }
        public string Nome
        {
            get { return this.nome; }
            set
            {
                if (value.Length > 0)
                {
                    this.nome = value;
                }
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (value.Length > 0)
                {
                    this.email = value;
                }
            }
        }

        public int Numero_Telefone
        {
            get { return this.numero_telefone; }
            set
            {
                this.numero_telefone = value;
            }
        }

        public DateOnly Data_aniversario
        {
            get
            {
                return this.data_aniversario;
            }
            set
            {
                this.data_aniversario = value;
            }
        }

        public TurnoEnum Turno
        {
            get { return this.turno; }
            set { this.turno = value; }
        }

        public Pessoa(int id, string nome, string email, int numero_telefone, DateOnly data_aniversario, TurnoEnum turno)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.numero_telefone = numero_telefone;
            this.data_aniversario = data_aniversario;
            this.turno = turno;
        }

        public abstract string ToString();

    }



}
