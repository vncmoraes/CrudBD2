using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;

namespace CrudBD
{
    class ProdutoDAO
    {
        public static DataTable consultaProdutos()
        {
            NpgsqlConnection conn = ConnectionFactory.getConnection();

            try
            {
                using (conn)
                {
                    conn.Open();
                    DataTable reservas = new DataTable();
                    string consultaReservas = "SELECT * FROM PRODUTO";

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

        public static bool excluirProduto(int id_produto)
        {
            NpgsqlConnection conn = ConnectionFactory.getConnection();

            try
            {
                using (conn)
                {
                    conn.Open();
                    string cmdExcluirProduto = $"DELETE FROM PRODUTO WHERE id_produto={id_produto};";
                    NpgsqlCommand command = new NpgsqlCommand(cmdExcluirProduto, conn);
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
