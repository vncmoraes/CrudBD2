using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudBD.Model;

namespace CrudBD
{
    public partial class frmAlterarAtividade : Form
    {
        public frmAlterarAtividade()
        {
            InitializeComponent();
        }

        private void btnAlterarAtividade_Click(object sender, EventArgs e)
        {
            Atividade atividade;
            try
            {
                atividade = new Atividade(
                    Convert.ToInt32(txtIdAtividade.Text),
                    txtDescricao.Text.ToString(),
                    txtEmpresa.Text.ToString(),
                    txtLocal.Text.ToString(),
                    Convert.ToDouble(txtValor.Text),
                    txtHoraInicio.Text.ToString(),
                    txtHoraFim.Text.ToString()
                    );
            }
            catch (Exception)
            {
                MessageBox.Show("Preencha as informações corretamente!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (AtividadeDAO.alterarAtividade(atividade))
            {
                MessageBox.Show("Atividade alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
            else
            {
                MessageBox.Show("Não foi possível alterar a atividade, tente novamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
