using System;
using System.Data;
using Npgsql;
using CrudBD.Model;

namespace CrudBD
{
    class ReservaDAO
    {
        public static bool novaReserva(Reserva reserva, OrdemPagamento ordemPagamento)
        {
            // Obtém a conexão com o banco de dados
            NpgsqlConnection conn = ConnectionFactory.getConnection();

            try
            {
                using (conn)
                {
                    // Abre a conexão com o banco de dados
                    conn.Open();

                    // Define a string do comando com os dados da Ordem de Pagamento
                    string cmdInserirOrdem = 
                        $"INSERT INTO ORDEM_PAGAMENTO VALUES(" +
                        $"{ordemPagamento.numero_ordem}, " +
                        $"{ordemPagamento.valor_total}, " +
                        $"{ordemPagamento.valor_diaria}, " +
                        $"{ordemPagamento.forma_pagamento}, " +
                        $"{ordemPagamento.qtd_parcelas}, " +
                        $"{ordemPagamento.taxa_cancelamento})";
                      

                    // Define a string de comando com os dados da Reserva
                    string cmdInserirReserva = $"INSERT INTO RESERVA VALUES(" +
                        $"{reserva.cod}, " +
                        $"{reserva.numero_ordem}, " +
                        $"{reserva.data_reserva}, " +
                        $"{reserva.data_checkin}, " +
                        $"{reserva.data_checkout}, " +
                        $"{reserva.qtd_diarias}, " +
                        $"{reserva.qtd_adultos}, " +
                        $"{reserva.qtd_criancas}, " +
                        $"{reserva.qtd_quartos})";
                    
                    // Cria e executa o comando de inserir ordem
                    NpgsqlCommand command = new NpgsqlCommand(cmdInserirOrdem, conn);
                    command.ExecuteNonQuery();

                    // Cria e executa o comando de inserir reserva
                    command = new NpgsqlCommand(cmdInserirReserva, conn);
                    command.ExecuteNonQuery();

                    // Fecha a conexão e retorna True para indicar sucesso nas operações
                    conn.Close();
                    return true;
                }
            }
            catch (Exception)
            {
                // Retorna False indicando falha na execução das operações
                return false;
            }
            finally
            {
                // Fecha a conexão em caso de erro
                conn.Close();
            }
        }

        public static DataTable consultaReservas()
        {
            // Obtém a conexão com o banco de dados
            NpgsqlConnection conn = ConnectionFactory.getConnection();

            try
            {
                using (conn)
                {
                    // Abre a conexão com o banco de dados
                    conn.Open();

                    // Cria um datatable para receber as reservas
                    DataTable reservas = new DataTable();

                    // Define a string do comando para consulta de reservas
                    string consultaReservas = "SELECT * FROM RESERVA";

                    // Define um Data Adapter para leitura das informações da consulta
                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(consultaReservas, conn))
                    {
                        // Preenche o datatable de Reservas com os dados retornados pela consulta
                        Adpt.Fill(reservas);
                    }

                    // Fecha a conexão e retorna True para indicar sucesso nas operações
                    conn.Close();
                    return reservas;
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

        public static bool excluirReserva(int id_reserva)
        {
            // Obtém a conexão com o banco de dados
            NpgsqlConnection conn = ConnectionFactory.getConnection();

            try
            {
                using (conn)
                {
                    // Abre a conexão com o banco de dados
                    conn.Open();

                    // Define a string de comando para excluir a reserva
                    string cmdExcluirReserva = $"DELETE FROM RESERVA WHERE cod={id_reserva};";

                    // Cria e executa o comando de inserir reserva
                    NpgsqlCommand command = new NpgsqlCommand(cmdExcluirReserva, conn);
                    command.ExecuteNonQuery();

                    // Fecha a conexão e retorna True para indicar sucesso na 
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
