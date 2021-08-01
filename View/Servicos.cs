using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudBD
{
    public partial class frmServicos : Form
    {
        public frmServicos()
        {
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir o serviço selecionado?", "Alerta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                int id_servico = (int)gridServicos.SelectedRows[0].Cells[0].Value;
                bool resultado = ServicoDAO.excluirServico(id_servico);

                if (!resultado)
                    MessageBox.Show("Não foi possível excluir o serviço, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Serviço excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gridServicos.DataSource = ServicoDAO.consultaServicos();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
