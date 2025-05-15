﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleVendas.pt.projeto.model;
using MySql.Data.MySqlClient;
using ControleVendas.pt.projeto.dao;
using System.Diagnostics.Metrics;
//using ControleVendas.pt.projeto.view;

namespace ControleVendas.pt.projeto.dao
{
    public class ProdutosDao
    {
        private MySqlConnection conexao;

        public ProdutosDao()
        {
            this.conexao = new ConnectionFactory().getConnection();
        }

        public class ConnectionFactory
        {
            public MySqlConnection getConnection()
            {
                string connectionString = "Server=localhost;Database=vendas;Uid=root;Pwd=12345;";
                return new MySqlConnection(connectionString);
            }
        }

        public DataTable ListarProdutos()
        {
            DataTable dataproduto = new DataTable();
            try
            {
                string sql = @"SELECT p.id as 'codigo',
                                p.descricao as 'Descriçao',
                                p.preco as 'Preço',
                                p.quantidade as 'Quantidade',
                                p.familia as 'Familia',
                                f.nome as 'Fornecedor' FROM tb_produtos as p 
                                join tb_fornecedores as f on p.for_id = f.id";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);

                conexao.Open();
                da.Fill(dataproduto);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na query SQL: " + erro.Message);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
            return dataproduto;
        }

        public void apagarProdutos(Produtos obj)
        {
            try
            {
                string sql = "delete from tb_produtos where id=@id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Produto apagado com sucesso");

                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Existe um erro no codigo" + erro.Message);
            }
        }

        public void CriarProdutos(Produtos obj)
        {
            try
            {

                string sql = @"insert into tb_produtos (descricao, preco, quantidade, familia, for_id)
                values(@descricao, CONVERT(REPLACE(@preco, ',', '.') using utf8mb4), @quantidade, @familia, @for_id)";


                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executacmd.Parameters.AddWithValue("@preco", obj.preco);
                executacmd.Parameters.AddWithValue("@quantidade", obj.quantidade);
                executacmd.Parameters.AddWithValue("@familia", obj.familia);
                executacmd.Parameters.AddWithValue("@for_id", obj.for_id);
                
                conexao.Open();
                executacmd.ExecuteNonQuery();
                conexao.Close();
                ListarProdutos();


                MessageBox.Show("Produto Criado com sucesso");
            }
            catch (Exception erro)
            {

                MessageBox.Show("Existe um erro no codigo" + erro.Message);
            }

        }

        public void editarProdutos(Produtos obj)
        {
            try
            {
                string sql = @"update tb_produtos set descricao=@descricao, 
                             preco = CONVERT(REPLACE(@preco, ',', '.') using utf8mb4), quantidade=@quantidade, familia=@familia, 
                             for_id=@for_id where id=@id";


                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.codigo);
                executacmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executacmd.Parameters.AddWithValue("@preco", obj.preco);
                executacmd.Parameters.AddWithValue("@quantidade", obj.quantidade);
                executacmd.Parameters.AddWithValue("@familia", obj.familia);
                executacmd.Parameters.AddWithValue("@for_id", obj.for_id);


                conexao.Open();
                executacmd.ExecuteNonQuery();


                MessageBox.Show("Produto editado com sucesso");
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro na query sql" + erro.Message);
            }
        }

        public DataTable pesquisaProdutos(string descricao)
        {
            DataTable dataproduto = new DataTable();
            try
            {
                string sql = "select * from tb_produtos where descricao like @descricao";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@descricao", descricao);


                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(dataproduto);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na query SQL: " + erro.Message);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }

            return dataproduto;
        }

        public Produtos ListarProdutosCodigo(int id) 
        {
            try
            {
                string sql = "select * from tb_produtos where id=@id";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@id", id);
                conexao.Open();

                MySqlDataReader rs = executacmd.ExecuteReader();

                if (rs.Read())
                {
                    Produtos p = new Produtos();
                    p.codigo = rs.GetInt32("id").ToString();
                    p.descricao = rs.GetString("descricao");
                    p.preco = rs.GetDecimal("preco").ToString();
                    conexao.Close();
                    return p;
                }
                else
                {
                    MessageBox.Show("Nenhum produto encontrado");
                    conexao.Close();
                    return null;
                }

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao listar os produtos por codigo" + erro);
                return null;
            }


        }

        public void baixaStock(int idproduto, int qtdstock) 
        {
            try
            {
                string sql = @"update tb_produtos set quantidade=@qtd where id=@id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@qtd", qtdstock);
                executacmd.Parameters.AddWithValue("@id", idproduto);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
                conexao.Close();
            }
        }
        public int RetornaStockAtual(int codigo) 
        {
            try
            {
                string sql = "select quantidade from tb_produtos where id=@id";
                int quantidade = 0;
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@id", codigo);
                conexao.Open();

                MySqlDataReader reader = executacmd.ExecuteReader();
                if (reader.Read()) 
                {
                    quantidade = reader.GetInt32("quantidade");
                    conexao.Close() ;
                }
                return quantidade;
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
                return 0;
            }
        }
    }
}
