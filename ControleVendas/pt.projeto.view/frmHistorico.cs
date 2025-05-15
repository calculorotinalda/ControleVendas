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
    public partial class frmHistorico : Form
    {
        public frmHistorico()
        {
            InitializeComponent();
        }

        private void btnpesquisadata_Click(object sender, EventArgs e)
        {
            DateTime datainicio, datafim;

            datainicio = Convert.ToDateTime(datainicial.Value.ToString("yyyy-MM-dd"));
            datafim = Convert.ToDateTime(datafinal.Value.ToString("yyyy-MM-dd"));

            vendasDao dao = new vendasDao();

            tabelahistorico.DataSource = dao.ListarVendasPeriodo(datainicio, datafim);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmHistorico_Load(object sender, EventArgs e)
        {
            vendasDao dao = new vendasDao();

            tabelahistorico.DataSource = dao.ListarVendas();
            tabelahistorico.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void tabelahistorico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idvenda = int.Parse(tabelahistorico.CurrentRow.Cells[0].Value.ToString());

            frmDetalhes frm = new frmDetalhes(idvenda);

            DateTime datavenda = Convert.ToDateTime(tabelahistorico.CurrentRow.Cells[1].Value.ToString());

            frm.txtdata.Text = datavenda.ToString("dd/MM/yyyy");
            frm.txtcliente.Text = tabelahistorico.CurrentRow.Cells[2].Value.ToString();
            frm.txttotal.Text = tabelahistorico.CurrentRow.Cells[3].Value.ToString();
            frm.txtobs.Text = tabelahistorico.CurrentRow.Cells[4].Value.ToString();

            frm.ShowDialog();
        }
    }
}
