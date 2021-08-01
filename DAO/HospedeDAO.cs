using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;

namespace CrudBD
{
    class HospedeDAO
    {
        public static DataTable consultaHospedes()
        {
            NpgsqlConnection conn = ConnectionFactory.getConnection();

            try
            {
                using (conn)
                {
                    conn.Open();
                    DataTable reservas = new DataTable();
                    string consultaReservas = "SELECT * FROM HOSPEDE";

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

        public static bool excluirHospede(int id_hospede)
        {
            NpgsqlConnection conn = ConnectionFactory.getConnection();

            try
            {
                using (conn)
                {
                    conn.Open();
                    string cmdExcluirHospede = $"DELETE FROM HOSPEDE WHERE id_hospede={id_hospede};";
                    NpgsqlCommand command = new NpgsqlCommand(cmdExcluirHospede, conn);
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
