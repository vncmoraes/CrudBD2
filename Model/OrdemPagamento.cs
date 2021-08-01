using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudBD.Model
{
    class OrdemPagamento
    {
        public int numero_ordem;
        public double valor_total;
        public double valor_diaria;
        public string forma_pagamento;
        public int qtd_parcelas;
        public double taxa_cancelamento;

        public OrdemPagamento(int numero_ordem, double valor_total, double valor_diaria, string forma_pagamento, int qtd_parcelas, double taxa_cancelamento)
        {
            this.numero_ordem = numero_ordem;
            this.valor_total = valor_total;
            this.valor_diaria = valor_diaria;
            this.forma_pagamento = forma_pagamento;
            this.qtd_parcelas = qtd_parcelas;
            this.taxa_cancelamento = taxa_cancelamento;
        }
    }
}
