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
    public partial class frmAtividades : Form
    {
        public frmAtividades()
        {
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem certeza que deseja excluir a atividade selecionada?", "Alerta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes){
                int id_atividade = (int)gridAtividades.SelectedRows[0].Cells[0].Value;
                bool resultado = AtividadeDAO.excluirAtividade(id_atividade);

                if (!resultado)
                    MessageBox.Show("Não foi possível excluir a atividade, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Atividade excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gridAtividades.DataSource = AtividadeDAO.consultaAtividades();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovaAtividade_Click(object sender, EventArgs e)
        {
            frmCriarAtividade criarAtividade = new frmCriarAtividade() { TopLevel = false, TopMost = true };
            frmMenu.atualizarPainel(criarAtividade);
            criarAtividade.Dock = DockStyle.Fill;
            criarAtividade.Show();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmAlterarAtividade alterarAtividade = new frmAlterarAtividade() { TopLevel = false, TopMost = true };

            alterarAtividade.txtIdAtividade.Text = gridAtividades.SelectedRows[0].Cells[0].Value.ToString();
            alterarAtividade.txtDescricao.Text = gridAtividades.SelectedRows[0].Cells[1].Value.ToString();
            alterarAtividade.txtEmpresa.Text = gridAtividades.SelectedRows[0].Cells[2].Value.ToString();
            alterarAtividade.txtLocal.Text = gridAtividades.SelectedRows[0].Cells[3].Value.ToString();
            alterarAtividade.txtValor.Text = gridAtividades.SelectedRows[0].Cells[4].Value.ToString();
            alterarAtividade.txtHoraInicio.Text = gridAtividades.SelectedRows[0].Cells[5].Value.ToString();
            alterarAtividade.txtHoraFim.Text = gridAtividades.SelectedRows[0].Cells[6].Value.ToString();

            frmMenu.atualizarPainel(alterarAtividade);
            alterarAtividade.Dock = DockStyle.Fill;
            alterarAtividade.Show();
        }
    }
}
