using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudBD.Model
{
    class Reserva
    {
        // Definição dos atributos da Classe Reserva
        public int cod;
        public int numero_ordem;
        public string data_reserva;
        public string data_checkin;
        public string data_checkout;
        public int qtd_diarias;
        public int qtd_adultos;
        public int qtd_criancas;
        public int qtd_quartos;

        // Construtor da classe
        public Reserva(int cod, int numero_ordem, string data_reserva, string data_checkin, string data_checkout, int qtd_diarias, int qtd_adultos, int qtd_criancas, int qtd_quartos)
        {
            this.cod = cod;
            this.numero_ordem = numero_ordem;
            this.data_reserva = data_reserva;
            this.data_checkin = data_checkin;
            this.data_checkout = data_checkout;
            this.qtd_diarias = qtd_diarias;
            this.qtd_adultos = qtd_adultos;
            this.qtd_criancas = qtd_criancas;
            this.qtd_quartos = qtd_quartos;
        }
    }
}
