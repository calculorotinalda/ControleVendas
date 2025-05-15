using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleVendas.pt.projeto.dao;

namespace ControleVendas.pt.projeto.view
{
    public partial class frmDetalhes : Form
    {
        int venda_id;
        public frmDetalhes(int idvenda)
        {
            InitializeComponent();
            venda_id = idvenda;
        }

        private void txtdinheiro_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDetalhes_Load(object sender, EventArgs e)
        {
            itensvendasDao itens = new itensvendasDao();
            tabeladetalhes.DataSource = itens.ListaritensVenda(venda_id);
        }
    }
}
