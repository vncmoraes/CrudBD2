using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;

namespace CrudBD
{
    class FuncionarioDAO
    {
        public static DataTable consultaFuncionarios()
        {
            NpgsqlConnection conn = ConnectionFactory.getConnection();

            try
            {
                using (conn)
                {
                    conn.Open();
                    DataTable reservas = new DataTable();
                    string consultaReservas = "SELECT * FROM FUNCIONARIO";

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
        public static bool excluirFuncionario(int id_funcionario)
        {
            NpgsqlConnection conn = ConnectionFactory.getConnection();

            try
            {
                using (conn)
                {
                    conn.Open();
                    string cmdExcluirFuncionario = $"DELETE FROM FUNCIONARIO WHERE id_funcionario={id_funcionario};";
                    NpgsqlCommand command = new NpgsqlCommand(cmdExcluirFuncionario, conn);
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
