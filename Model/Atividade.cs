using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudBD.Model
{
    class Atividade
    {
        // Definição dos atributos da classe Atividade
        public int id_atividade;
        public string descricao;
        public string empresa;
        public string local;
        public double valor;
        public string hora_inicio;
        public string hora_fim;

        // Construtor da classe
        public Atividade(int id_atividade, string descricao, string empresa, string local, double valor, string hora_inicio, string hora_fim)
        {
            this.id_atividade = id_atividade;
            this.descricao = descricao;
            this.empresa = empresa;
            this.local = local;
            this.valor = valor;
            this.hora_inicio = hora_inicio;
            this.hora_fim = hora_fim;
        }
    }
}
