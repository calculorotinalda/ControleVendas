namespace ControleVendas.pt.projeto.view
{
    partial class frmDetalhes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txttitulo = new Label();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            txtobs = new TextBox();
            label3 = new Label();
            txtdata = new TextBox();
            label2 = new Label();
            txttotal = new TextBox();
            label1 = new Label();
            txtcliente = new TextBox();
            lblcodigo = new Label();
            tabeladetalhes = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabeladetalhes).BeginInit();
            SuspendLayout();
            // 
            // txttitulo
            // 
            txttitulo.AutoSize = true;
            txttitulo.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txttitulo.ForeColor = SystemColors.ButtonHighlight;
            txttitulo.Location = new Point(281, 31);
            txttitulo.Name = "txttitulo";
            txttitulo.Size = new Size(353, 54);
            txttitulo.TabIndex = 0;
            txttitulo.Text = "Detalhes da Venda";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(txttitulo);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(896, 115);
            panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtobs);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtdata);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txttotal);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtcliente);
            groupBox1.Controls.Add(lblcodigo);
            groupBox1.Location = new Point(1, 124);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(896, 198);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // txtobs
            // 
            txtobs.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtobs.Location = new Point(548, 87);
            txtobs.Multiline = true;
            txtobs.Name = "txtobs";
            txtobs.ReadOnly = true;
            txtobs.Size = new Size(336, 105);
            txtobs.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(470, 93);
            label3.Name = "label3";
            label3.Size = new Size(72, 41);
            label3.TabIndex = 10;
            label3.Text = "Obs";
            // 
            // txtdata
            // 
            txtdata.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtdata.Location = new Point(138, 87);
            txtdata.Name = "txtdata";
            txtdata.ReadOnly = true;
            txtdata.Size = new Size(310, 47);
            txtdata.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 90);
            label2.Name = "label2";
            label2.Size = new Size(79, 41);
            label2.TabIndex = 8;
            label2.Text = "Data";
            // 
            // txttotal
            // 
            txttotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txttotal.Location = new Point(701, 23);
            txttotal.Name = "txttotal";
            txttotal.ReadOnly = true;
            txttotal.Size = new Size(183, 47);
            txttotal.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(470, 26);
            label1.Name = "label1";
            label1.Size = new Size(210, 41);
            label1.TabIndex = 6;
            label1.Text = "Total da venda";
            // 
            // txtcliente
            // 
            txtcliente.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcliente.Location = new Point(138, 20);
            txtcliente.Name = "txtcliente";
            txtcliente.ReadOnly = true;
            txtcliente.Size = new Size(310, 47);
            txtcliente.TabIndex = 5;
            txtcliente.TextChanged += txtdinheiro_TextChanged;
            // 
            // lblcodigo
            // 
            lblcodigo.AutoSize = true;
            lblcodigo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblcodigo.Location = new Point(22, 23);
            lblcodigo.Name = "lblcodigo";
            lblcodigo.Size = new Size(110, 41);
            lblcodigo.TabIndex = 4;
            lblcodigo.Text = "Cliente";
            // 
            // tabeladetalhes
            // 
            tabeladetalhes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabeladetalhes.Location = new Point(1, 337);
            tabeladetalhes.Name = "tabeladetalhes";
            tabeladetalhes.RowHeadersWidth = 51;
            tabeladetalhes.Size = new Size(896, 244);
            tabeladetalhes.TabIndex = 4;
            // 
            // frmDetalhes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 586);
            Controls.Add(tabeladetalhes);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "frmDetalhes";
            Text = "frmDetalhes";
            Load += frmDetalhes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabeladetalhes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label txttitulo;
        private Panel panel1;
        private GroupBox groupBox1;
        public TextBox txtcliente;
        private Label lblcodigo;
        public TextBox txttotal;
        private Label label1;
        public TextBox txtobs;
        private Label label3;
        public TextBox txtdata;
        private Label label2;
        private DataGridView tabeladetalhes;
    }
}