using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;
using CrudBD.Model;

namespace CrudBD
{
    class AtividadeDAO
    {
        public static bool novaAtividade(Atividade atividade)
        {
            // Obtém a conexão com o banco de dados
            NpgsqlConnection conn = ConnectionFactory.getConnection();

            try
            {
                using (conn)
                {
                    // Abre a conexão com o banco de dados
                    conn.Open();

                    // Define a string de comando para inserção da Atividade
                    string cmdInserirAtividade = $"INSERT INTO ATIVIDADE VALUES(" +
                        $"'{atividade.id_atividade}'," +
                        $"'{atividade.descricao}'," +
                        $"'{atividade.empresa}'," +
                        $"'{atividade.local}'," +
                        $"'{atividade.valor}'," +
                        $"'{atividade.hora_inicio}'," +
                        $"'{atividade.hora_fim}')";

                    // Cria e executa o comando de inserir atividade
                    NpgsqlCommand command = new NpgsqlCommand(cmdInserirAtividade, conn);
                    command.ExecuteNonQuery();

                    // Fecha a conexão e retorna True para indicar sucesso na operação
                    conn.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                // Retorna False indicando falha na execução da operação
                return false;
            }
            finally
            {
                // Fecha a conexão em caso de erro
                conn.Close();
            }
        }

        public static DataTable consultaAtividades()
        {
            // Obtém a conexão com o banco de dados
            NpgsqlConnection conn = ConnectionFactory.getConnection();

            try
            {
                using (conn)
                {
                    // Abre a conexão com o banco de dados
                    conn.Open();

                    // Cria um datatable para receber as atividades
                    DataTable atividades = new DataTable();

                    // Define a string de comando para consulta de Atividades
                    string cmdConsultaAtividades = "SELECT * FROM ATIVIDADE";

                    // Define um Data Adapter para leitura das informações da consulta
                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdConsultaAtividades, conn))
                    {
                        // Preenche o datatable de Atividades com os dados retornados pela consulta
                        Adpt.Fill(atividades);
                    }

                    // Fecha a conexão e retorna o datatable preenchido
                    conn.Close();
                    return atividades;
                }
            }
            catch (Exception)
            {
                // Retorna um datatable vazio em caso de erro
                return new DataTable();
            }
            finally
            {
                // Fecha a conexão em caso de erro
                conn.Close();
            }
        }

        public static bool alterarAtividade(Atividade atividade)
        {
            // Obtém a conexão com o banco de dados
            NpgsqlConnection conn = ConnectionFactory.getConnection();

            try
            {
                using (conn)
                {
                    // Abre a conexão com o banco de dados
                    conn.Open();

                    // Define a string de comando para alteração da Atividade
                    string cmdAlterarAtividade = $"UPDATE ATIVIDADE SET" +
                        $"descricao = '{atividade.descricao}'," +
                        $"empresa = '{atividade.empresa}'," +
                        $"local = '{atividade.local}'," +
                        $"valor = '{atividade.valor}'," +
                        $"hora_inicio = '{atividade.hora_inicio}'," +
                        $"hora_fim = '{atividade.hora_fim}'" +
                        $"WHERE id_atividade = '{atividade.id_atividade}'";

                    // Cria e executa o comando de alterar atividade
                    NpgsqlCommand command = new NpgsqlCommand(cmdAlterarAtividade, conn);
                    command.ExecuteNonQuery();

                    // Fecha a conexão e retorna True para indicar sucesso na operação
                    conn.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                // Retorna False indicando falha na execução da operação
                return false;
            }
            finally
            {
                // Fecha a conexão em caso de erro
                conn.Close();
            }
        }

        public static bool excluirAtividade(int id_atividade)
        {
            // Obtém a conexão com o banco de dados
            NpgsqlConnection conn = ConnectionFactory.getConnection();

            try
            {
                using (conn)
                {
                    // Abre a conexão com o banco de dados
                    conn.Open();

                    // Define a string de comando para exclusão de Atividade
                    string cmdExcluirAtividade = $"DELETE FROM ATIVIDADE WHERE id_atividade='{id_atividade}';";

                    // Cria e executa o comando de exclusão de atividade
                    NpgsqlCommand command = new NpgsqlCommand(cmdExcluirAtividade, conn);
                    command.ExecuteNonQuery();

                    // Fecha a conexão e retorna True para indicar sucesso na operação
                    conn.Close();
                    return true;
                }
            }
            catch (Exception)
            {
                // Retorna False indicando falha na execução da operação
                return false;
            }
            finally
            {
                // Fecha a conexão em caso de erro
                conn.Close();
            }
        }
    }
}
