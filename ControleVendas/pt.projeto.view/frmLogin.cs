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

namespace ControleVendas.pt.projeto.view
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text;
            string senha = txtpassword.Text;

            FuncionariosDao dao = new FuncionariosDao();

            if (dao.Login(email, senha))
            {
               
                Menu telamenu = new Menu();
                telamenu.Show(); 
                telamenu.menuutilizador.Text = txtemail.Text;
                this.Hide();
                
            }
        }
    }
}
