using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ControleVendas.pt.projeto.conection;
using ControleVendas.pt.projeto.model;
using MySql.Data.MySqlClient;

namespace ControleVendas.pt.projeto.dao
{
    public class itensvendasDao
    {
        private MySqlConnection conexao;

        public itensvendasDao()
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

        public void Cadastraritensvendas(Itensvendas obj) 
        {
            try
            {
                string sql = @"insert into tb_itensvendas  (venda_id, produto_id, qtd, subtotal) values (@venda_id, @produto_id, @qtd, @subtotal)";
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@venda_id", obj.venda_id);
                executacmd.Parameters.AddWithValue("@produto_id", obj.produto_id);
                executacmd.Parameters.AddWithValue("@qtd", obj.qtd);
                executacmd.Parameters.AddWithValue("@subtotal", obj.subtotal);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                //MessageBox.Show("Item criado com sucesso");
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Encontrado o erro" + erro);
            }
        }

        public DataTable ListaritensVenda(int venda_id)
        {
            try
            {
                DataTable tabelaitens = new DataTable();

                string sql = @"select i.id as 'Codigo', p.descricao as 'Descricao', i.qtd as 'Quantidade', p.preco as 'Preço',
                           i.subtotal as 'Subtotal' from tb_itensvendas as i join tb_produtos as p on (i.produto_id = p.id)
                            where venda_id = @venda_id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@venda_id", venda_id);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter query = new MySqlDataAdapter(executacmd);
                query.Fill(tabelaitens);

                return tabelaitens;
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro : " + erro);
                return null;
            }
        }
    }
}
