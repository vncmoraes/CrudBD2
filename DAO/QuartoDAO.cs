using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;

namespace CrudBD
{
    class QuartoDAO
    {
        public static DataTable consultaQuartos()
        {
            NpgsqlConnection conn = ConnectionFactory.getConnection();

            try
            {
                using (conn)
                {
                    conn.Open();
                    DataTable reservas = new DataTable();
                    string consultaReservas = "SELECT * FROM QUARTO";

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

        public static bool excluirQuarto(int id_quarto)
        {
            NpgsqlConnection conn = ConnectionFactory.getConnection();

            try
            {
                using (conn)
                {
                    conn.Open();
                    string cmdExcluirQuarto = $"DELETE FROM QUARTO WHERE id_quarto={id_quarto};";
                    NpgsqlCommand command = new NpgsqlCommand(cmdExcluirQuarto, conn);
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
