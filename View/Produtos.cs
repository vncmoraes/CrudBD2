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
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir o produto selecionado?", "Alerta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                int id_produto = (int)gridProdutos.SelectedRows[0].Cells[0].Value;
                bool resultado = ProdutoDAO.excluirProduto(id_produto);

                if (!resultado)
                    MessageBox.Show("Não foi possível excluir o produto, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Produto excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gridProdutos.DataSource = ProdutoDAO.consultaProdutos();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
