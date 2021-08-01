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
    public partial class frmHospedes : Form
    {
        public frmHospedes()
        {
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir o hóspede selecionado?", "Alerta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                int id_hospede = (int)gridHospedes.SelectedRows[0].Cells[0].Value;
                bool resultado = HospedeDAO.excluirHospede(id_hospede);

                if (!resultado)
                    MessageBox.Show("Não foi possível excluir o hóspede, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Hóspede excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gridHospedes.DataSource = HospedeDAO.consultaHospedes();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
