using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace CrudBD
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult confirmar = MessageBox.Show("Tem certeza de que deseja sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if(confirmar == DialogResult.Yes)
                Application.Exit();
        }

        private void optionCadastro_Click(object sender, EventArgs e)
        {

        }

        private void btnHospedes_Click(object sender, EventArgs e)
        {
            panelForms.Controls.Clear();
            frmHospedes hospedes = new frmHospedes() { TopLevel = false, TopMost = true };
            panelForms.Controls.Add(hospedes);
            hospedes.Dock = DockStyle.Fill;
            hospedes.Show();

            hospedes.gridHospedes.DataSource = HospedeDAO.consultaHospedes();
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            panelForms.Controls.Clear();
            frmReservas reservas = new frmReservas () { TopLevel = false, TopMost = true };
            panelForms.Controls.Add(reservas);
            reservas.Dock = DockStyle.Fill;
            reservas.Show();

            reservas.gridReservas.DataSource = ReservaDAO.consultaReservas();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            panelForms.Controls.Clear();
            frmFuncionarios funcionarios = new frmFuncionarios() { TopLevel = false, TopMost = true };
            panelForms.Controls.Add(funcionarios);
            funcionarios.Dock = DockStyle.Fill;
            funcionarios.Show();

            funcionarios.gridFuncionarios.DataSource = FuncionarioDAO.consultaFuncionarios();
        }

        private void btnAtividades_Click(object sender, EventArgs e)
        {
            panelForms.Controls.Clear();
            frmAtividades atividades = new frmAtividades() { TopLevel = false, TopMost = true };
            panelForms.Controls.Add(atividades);
            atividades.Dock = DockStyle.Fill;
            atividades.Show();

            atividades.gridAtividades.DataSource = AtividadeDAO.consultaAtividades();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            panelForms.Controls.Clear();
            frmProdutos produtos = new frmProdutos() { TopLevel = false, TopMost = true };
            panelForms.Controls.Add(produtos);
            produtos.Dock = DockStyle.Fill;
            produtos.Show();

            produtos.gridProdutos.DataSource = ProdutoDAO.consultaProdutos();
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            panelForms.Controls.Clear();
            frmServicos servicos = new frmServicos() { TopLevel = false, TopMost = true };
            panelForms.Controls.Add(servicos);
            servicos.Dock = DockStyle.Fill;
            servicos.Show();

            servicos.gridServicos.DataSource = ServicoDAO.consultaServicos();
        }

        private void btnQuartos_Click(object sender, EventArgs e)
        {
            panelForms.Controls.Clear();
            frmQuartos quartos = new frmQuartos() { TopLevel = false, TopMost = true };
            panelForms.Controls.Add(quartos);
            quartos.Dock = DockStyle.Fill;
            quartos.Show();

            quartos.gridQuartos.DataSource = QuartoDAO.consultaQuartos();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        public static void atualizarPainel(Form formulario)
        {
            panelForms.Controls.Clear();
            panelForms.Controls.Add(formulario);
        }
    }
}
