namespace filmesApp1A
{
    partial class frmFilmes
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
            components = new System.ComponentModel.Container();
            btEditar = new Button();
            btRemover = new Button();
            btCadastrar = new Button();
            btBuscar = new Button();
            txtBusca = new TextBox();
            btGerenciar = new Button();
            dgvFilmes = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            anoLancamentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nacionalidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            filmeBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvFilmes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filmeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btEditar
            // 
            btEditar.Location = new Point(332, 350);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(126, 29);
            btEditar.TabIndex = 11;
            btEditar.Text = "Editar Filme";
            btEditar.UseVisualStyleBackColor = true;
            btEditar.Click += btEditar_Click;
            // 
            // btRemover
            // 
            btRemover.Location = new Point(487, 350);
            btRemover.Name = "btRemover";
            btRemover.Size = new Size(126, 29);
            btRemover.TabIndex = 10;
            btRemover.Text = "Remover Filme";
            btRemover.UseVisualStyleBackColor = true;
            btRemover.Click += btRemover_Click;
            // 
            // btCadastrar
            // 
            btCadastrar.Location = new Point(27, 350);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(138, 29);
            btCadastrar.TabIndex = 9;
            btCadastrar.Text = "Cadastrar Filme";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += btCadastrar_Click;
            // 
            // btBuscar
            // 
            btBuscar.Location = new Point(459, 21);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(138, 29);
            btBuscar.TabIndex = 7;
            btBuscar.Text = "Buscar";
            btBuscar.TextAlign = ContentAlignment.TopCenter;
            btBuscar.UseVisualStyleBackColor = true;
            btBuscar.Click += btBuscar_Click;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(27, 21);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(426, 27);
            txtBusca.TabIndex = 6;
            txtBusca.TextChanged += txtBusca_TextChanged;
            // 
            // btGerenciar
            // 
            btGerenciar.Location = new Point(176, 350);
            btGerenciar.Name = "btGerenciar";
            btGerenciar.Size = new Size(132, 29);
            btGerenciar.TabIndex = 12;
            btGerenciar.Text = "Gerenciar Elenco";
            btGerenciar.UseVisualStyleBackColor = true;
            btGerenciar.Click += btGerenciar_Click;
            // 
            // dgvFilmes
            // 
            dgvFilmes.AutoGenerateColumns = false;
            dgvFilmes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFilmes.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, anoLancamentoDataGridViewTextBoxColumn, nacionalidadeDataGridViewTextBoxColumn });
            dgvFilmes.DataSource = filmeBindingSource;
            dgvFilmes.Location = new Point(49, 68);
            dgvFilmes.Name = "dgvFilmes";
            dgvFilmes.RowHeadersWidth = 51;
            dgvFilmes.Size = new Size(548, 263);
            dgvFilmes.TabIndex = 13;
            dgvFilmes.CellClick += dgvFilmes_CellClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // anoLancamentoDataGridViewTextBoxColumn
            // 
            anoLancamentoDataGridViewTextBoxColumn.DataPropertyName = "AnoLancamento";
            anoLancamentoDataGridViewTextBoxColumn.HeaderText = "AnoLancamento";
            anoLancamentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            anoLancamentoDataGridViewTextBoxColumn.Name = "anoLancamentoDataGridViewTextBoxColumn";
            anoLancamentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nacionalidadeDataGridViewTextBoxColumn
            // 
            nacionalidadeDataGridViewTextBoxColumn.DataPropertyName = "Nacionalidade";
            nacionalidadeDataGridViewTextBoxColumn.HeaderText = "Nacionalidade";
            nacionalidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            nacionalidadeDataGridViewTextBoxColumn.Name = "nacionalidadeDataGridViewTextBoxColumn";
            nacionalidadeDataGridViewTextBoxColumn.Width = 125;
            // 
            // filmeBindingSource
            // 
            filmeBindingSource.DataSource = typeof(Models.Filme);
            // 
            // frmFilmes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 397);
            Controls.Add(dgvFilmes);
            Controls.Add(btGerenciar);
            Controls.Add(btEditar);
            Controls.Add(btRemover);
            Controls.Add(btCadastrar);
            Controls.Add(btBuscar);
            Controls.Add(txtBusca);
            Name = "frmFilmes";
            Text = "frmFilmes";
            FormClosing += frmFilmes_FormClosing;
            Load += frmFilmes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFilmes).EndInit();
            ((System.ComponentModel.ISupportInitialize)filmeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btEditar;
        private Button btRemover;
        private Button btCadastrar;
        private Button btBuscar;
        private TextBox txtBusca;
        private Button btGerenciar;
        private DataGridView dgvFilmes;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn anoLancamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nacionalidadeDataGridViewTextBoxColumn;
        private BindingSource filmeBindingSource;
    }
}