﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleVendas.pt.projeto.dao;
using ControleVendas.pt.projeto.model;
using MySqlX.XDevAPI;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ControleVendas.pt.projeto.view
{
    public partial class frmVendas : Form
    {
        Produtos p = new Produtos();
        ProdutosDao pdao = new ProdutosDao();

        clientes c = new clientes();
        ClienteDao clienteDao = new ClienteDao();

        int qtd;
        decimal preco;
        decimal subtotal, total;
        DataTable carrinho = new DataTable();
        private clientes cliente;
        public frmVendas()
        {
            InitializeComponent();
            carrinho.Columns.Add("Codigo", typeof(int));
            carrinho.Columns.Add("Produto", typeof(string));
            carrinho.Columns.Add("Quantidade", typeof(int));
            carrinho.Columns.Add("Preço", typeof(decimal));
            carrinho.Columns.Add("Subtotal", typeof(decimal));

            tabelaprodutos.DataSource = carrinho;

        }

        private void txtcodigoproduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                p = pdao.ListarProdutosCodigo(int.Parse(txtcodigoproduto.Text));

                if(p != null) 
                {

                    txtcodigoproduto.Text = p.codigo.ToString();
                    txtdescricaoproduto.Text = p.descricao.ToString();
                    txtpreco.Text = p.preco.ToString();

                }
                else 
                {
                    txtcodigoproduto.Clear();
                    txtdescricaoproduto.Clear();
                    txtpreco.Clear();
                }
                
            }
        }

        private void txtcodigocliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                c = clienteDao.ListarClientesCodigo(int.Parse(txtcodigocliente.Text));

                if(c != null) 
                {

                    txtcodigocliente.Text = c.codigo.ToString();
                    txtnome.Text = c.nome.ToString();

                }
                else 
                {
                    txtcodigocliente.Clear();
                    txtnome.Clear();
                }
                

            }
        }

        private void frmVendas_Load(object sender, EventArgs e)
        {
            txtdata.Text = DateTime.Now.ToShortDateString();
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            qtd = int.Parse(txtquantidade.Text);
            preco = decimal.Parse(txtpreco.Text);

            subtotal = qtd * preco;
            total += subtotal;

            carrinho.Rows.Add(int.Parse(txtcodigoproduto.Text), txtdescricaoproduto.Text, qtd, preco, subtotal);
            txttotal.Text = total.ToString();

            txtcodigoproduto.Clear();
            txtdescricaoproduto.Clear();
            txtquantidade.Clear();
            txtpreco.Clear();
            //txtcodigocliente.Clear();
            //txtnome.Clear();

            txtcodigocliente.Focus();
        }

        private void btnremover_Click(object sender, EventArgs e)
        {
            decimal subproduto = decimal.Parse(tabelaprodutos.CurrentRow.Cells[4].Value.ToString());
            int indice = tabelaprodutos.CurrentRow.Index;
            DataRow linha = carrinho.Rows[indice];

            carrinho.Rows.Remove(linha);
            carrinho.AcceptChanges();

            total -= subproduto;
            txttotal.Text = total.ToString();
            MessageBox.Show("Produto removido do carrinho com sucesso");
        }

        private void btnpagamento_Click(object sender, EventArgs e)
        {
            DateTime data = DateTime.Parse(txtdata.Text);
            
            frmPagamento tela = new frmPagamento(cliente, carrinho, data);
            tela.txttotal.Text = total.ToString();

            tela.ShowDialog();
            //frmVendas frm = new frmVendas();
            this.Hide();
            //frm.Dispose();
            //new frmVendas().Close();
        }
    }
}
