using ListaAtividades.Dominio;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividades.Repositorio
{
    internal class AtividadeRepositorio
    {
        public void Criar(String titulo)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = "INSERT INTO atividades (titulo) VALUES (@titulo)";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@titulo", titulo); //ADICIONAR VALOR DO PARAMETRO
                    cmd.ExecuteNonQuery(); //EXECUTAR QUERY

                }
            }
        }

        public void AtualizarSituacao(int id, int novaSituacao)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = "UPDATE atividades SET situacao = @novaSituacao WHERE id = @id";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@situacao", novaSituacao);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public Atividade BuscarAtividadeEmAndamento() 
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = $"SELECT * FROM atividade WHERE situacao = {(int)Situacao.Realizando};";

                using (var cmd = new MySqlCommand(query, con))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Atividade()
                            {
                                Id = reader.GetInt32("id"),
                                Titulo = reader.GetString("titulo"),
                                Situacao = (Situacao)reader.GetInt32("situacao")
                            };
                            
                        }
                    }
                }
            }

            return new Atividade();
        }

        public List<Atividade> ListarAtividadesPendentes()
        {
            List<Atividade> atividades = [];
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = $"SELECT * FROM atividade WHERE situacao = {(int)Situacao.Pendente};";

                using (var cmd = new MySqlCommand(query,con))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            atividades.Add(new Atividade()
                            {
                                Id = reader.GetInt32("id"),
                                Titulo = reader.GetString("titulo"),
                                Situacao = (Situacao)reader.GetInt32("situacao")
                            });

                        }
                    }
                }
            }
            return atividades;
        }
    }
}
