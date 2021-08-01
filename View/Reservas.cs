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
    public partial class frmReservas : Form
    {
        public frmReservas()
        {
            InitializeComponent();
        }

        private void frmReservas_Load(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir a reserva selecionada?", "Alerta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                int id_reserva = (int)gridReservas.SelectedRows[0].Cells[0].Value;
                bool resultado = ReservaDAO.excluirReserva(id_reserva);

                if (!resultado)
                    MessageBox.Show("Não foi possível excluir a reserva, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Reserva excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gridReservas.DataSource = ReservaDAO.consultaReservas();


            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
