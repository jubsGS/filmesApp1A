namespace filmesApp1A
{
    partial class frmGerenciarElenco
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
            dgvElenco = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nacionalidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            atorBindingSource = new BindingSource(components);
            btRemover = new Button();
            btAdicionar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvElenco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)atorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvElenco
            // 
            dgvElenco.AutoGenerateColumns = false;
            dgvElenco.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvElenco.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, nacionalidadeDataGridViewTextBoxColumn });
            dgvElenco.DataSource = atorBindingSource;
            dgvElenco.Location = new Point(38, 23);
            dgvElenco.Name = "dgvElenco";
            dgvElenco.RowHeadersWidth = 51;
            dgvElenco.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvElenco.Size = new Size(426, 272);
            dgvElenco.TabIndex = 13;
            dgvElenco.CellContentClick += dgvElenco_CellContentClick;
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
            // nacionalidadeDataGridViewTextBoxColumn
            // 
            nacionalidadeDataGridViewTextBoxColumn.DataPropertyName = "Nacionalidade";
            nacionalidadeDataGridViewTextBoxColumn.HeaderText = "Nacionalidade";
            nacionalidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            nacionalidadeDataGridViewTextBoxColumn.Name = "nacionalidadeDataGridViewTextBoxColumn";
            nacionalidadeDataGridViewTextBoxColumn.Width = 125;
            // 
            // atorBindingSource
            // 
            atorBindingSource.DataSource = typeof(Models.Ator);
            // 
            // btRemover
            // 
            btRemover.Location = new Point(326, 314);
            btRemover.Name = "btRemover";
            btRemover.Size = new Size(138, 29);
            btRemover.TabIndex = 15;
            btRemover.Text = "Remover Ator";
            btRemover.UseVisualStyleBackColor = true;
            btRemover.Click += btRemover_Click;
            // 
            // btAdicionar
            // 
            btAdicionar.Location = new Point(38, 314);
            btAdicionar.Name = "btAdicionar";
            btAdicionar.Size = new Size(194, 29);
            btAdicionar.TabIndex = 14;
            btAdicionar.Text = "Adicionar Ator no Elenco";
            btAdicionar.UseVisualStyleBackColor = true;
            btAdicionar.Click += btAdicionar_Click;
            // 
            // frmGerenciarElenco
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 366);
            Controls.Add(dgvElenco);
            Controls.Add(btRemover);
            Controls.Add(btAdicionar);
            Name = "frmGerenciarElenco";
            Text = "GerenciarElenco";
            Load += frmGerenciarElenco_Load;
            ((System.ComponentModel.ISupportInitialize)dgvElenco).EndInit();
            ((System.ComponentModel.ISupportInitialize)atorBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvElenco;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nacionalidadeDataGridViewTextBoxColumn;
        private BindingSource atorBindingSource;
        private Button btRemover;
        private Button btAdicionar;
    }
}