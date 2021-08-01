using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;

namespace CrudBD
{
    class ServicoDAO
    {
        public static DataTable consultaServicos()
        {
            NpgsqlConnection conn = ConnectionFactory.getConnection();

            try
            {
                using (conn)
                {
                    conn.Open();
                    DataTable reservas = new DataTable();
                    string consultaReservas = "SELECT * FROM SERVICO";

                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(consultaReservas, conn))
                    {
                        Adpt.Fill(reservas);
                    }

                    return reservas;
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static bool excluirServico(int id_servico)
        {
            NpgsqlConnection conn = ConnectionFactory.getConnection();

            try
            {
                using (conn)
                {
                    conn.Open();
                    string cmdExcluirServico = $"DELETE FROM SERVICO WHERE id_servico={id_servico};";
                    NpgsqlCommand command = new NpgsqlCommand(cmdExcluirServico, conn);
                    command.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
