namespace ControleVendas.pt.projeto.view
{
    partial class frmHistorico
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
            panel1 = new Panel();
            txttitulo = new Label();
            groupBox1 = new GroupBox();
            btnpesquisadata = new Button();
            datafinal = new DateTimePicker();
            datainicial = new DateTimePicker();
            lbldatafim = new Label();
            lbldataini = new Label();
            tabelahistorico = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabelahistorico).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(txttitulo);
            panel1.Location = new Point(-206, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1196, 165);
            panel1.TabIndex = 1;
            // 
            // txttitulo
            // 
            txttitulo.AutoSize = true;
            txttitulo.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txttitulo.ForeColor = SystemColors.ButtonHighlight;
            txttitulo.Location = new Point(517, 54);
            txttitulo.Name = "txttitulo";
            txttitulo.Size = new Size(374, 54);
            txttitulo.TabIndex = 0;
            txttitulo.Text = "Historico de Vendas";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnpesquisadata);
            groupBox1.Controls.Add(datafinal);
            groupBox1.Controls.Add(datainicial);
            groupBox1.Controls.Add(lbldatafim);
            groupBox1.Controls.Add(lbldataini);
            groupBox1.Location = new Point(2, 172);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(988, 112);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnpesquisadata
            // 
            btnpesquisadata.BackColor = Color.DodgerBlue;
            btnpesquisadata.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnpesquisadata.ForeColor = SystemColors.ButtonHighlight;
            btnpesquisadata.Location = new Point(776, 32);
            btnpesquisadata.Name = "btnpesquisadata";
            btnpesquisadata.Size = new Size(189, 48);
            btnpesquisadata.TabIndex = 25;
            btnpesquisadata.Text = "Pesquisar";
            btnpesquisadata.UseVisualStyleBackColor = false;
            btnpesquisadata.Click += btnpesquisadata_Click;
            // 
            // datafinal
            // 
            datafinal.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datafinal.Format = DateTimePickerFormat.Short;
            datafinal.Location = new Point(555, 45);
            datafinal.Name = "datafinal";
            datafinal.Size = new Size(190, 27);
            datafinal.TabIndex = 4;
            // 
            // datainicial
            // 
            datainicial.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datainicial.Format = DateTimePickerFormat.Short;
            datainicial.Location = new Point(186, 45);
            datainicial.Name = "datainicial";
            datainicial.Size = new Size(190, 27);
            datainicial.TabIndex = 3;
            // 
            // lbldatafim
            // 
            lbldatafim.AutoSize = true;
            lbldatafim.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbldatafim.Location = new Point(403, 41);
            lbldatafim.Name = "lbldatafim";
            lbldatafim.Size = new Size(116, 31);
            lbldatafim.TabIndex = 2;
            lbldatafim.Text = "Data Final";
            // 
            // lbldataini
            // 
            lbldataini.AutoSize = true;
            lbldataini.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbldataini.Location = new Point(27, 41);
            lbldataini.Name = "lbldataini";
            lbldataini.Size = new Size(128, 31);
            lbldataini.TabIndex = 1;
            lbldataini.Text = "Data Inicial";
            // 
            // tabelahistorico
            // 
            tabelahistorico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelahistorico.Location = new Point(2, 290);
            tabelahistorico.Name = "tabelahistorico";
            tabelahistorico.RowHeadersWidth = 51;
            tabelahistorico.Size = new Size(976, 299);
            tabelahistorico.TabIndex = 3;
            tabelahistorico.CellClick += tabelahistorico_CellClick;
            // 
            // frmHistorico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 594);
            Controls.Add(tabelahistorico);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "frmHistorico";
            Text = "frmHistorico";
            Load += frmHistorico_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabelahistorico).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label txttitulo;
        private GroupBox groupBox1;
        public DateTimePicker datainicial;
        private Label lbldatafim;
        private Label lbldataini;
        public DateTimePicker datafinal;
        private Button btnpesquisadata;
        public DataGridView tabelahistorico;
    }
}