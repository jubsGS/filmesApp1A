namespace filmesApp1A
{
    partial class frmAtores
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
            txtBusca = new TextBox();
            btBuscar = new Button();
            dgvAtores = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nacionalidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            atorBindingSource = new BindingSource(components);
            btCadastrar = new Button();
            btRemover = new Button();
            btEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAtores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)atorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(14, 25);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(279, 27);
            txtBusca.TabIndex = 0;
            // 
            // btBuscar
            // 
            btBuscar.Location = new Point(303, 24);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(138, 29);
            btBuscar.TabIndex = 1;
            btBuscar.Text = "Buscar";
            btBuscar.TextAlign = ContentAlignment.TopCenter;
            btBuscar.UseVisualStyleBackColor = true;
            btBuscar.Click += btBuscar_Click;
            // 
            // dgvAtores
            // 
            dgvAtores.AutoGenerateColumns = false;
            dgvAtores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAtores.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, nacionalidadeDataGridViewTextBoxColumn });
            dgvAtores.DataSource = atorBindingSource;
            dgvAtores.Location = new Point(14, 69);
            dgvAtores.Name = "dgvAtores";
            dgvAtores.RowHeadersWidth = 51;
            dgvAtores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAtores.Size = new Size(427, 272);
            dgvAtores.TabIndex = 2;
            dgvAtores.CellClick += dgvAtores_CellClick;
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
            // btCadastrar
            // 
            btCadastrar.Location = new Point(14, 360);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(119, 29);
            btCadastrar.TabIndex = 3;
            btCadastrar.Text = "Cadastrar Ator";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += btCadastrar_Click;
            // 
            // btRemover
            // 
            btRemover.Location = new Point(321, 360);
            btRemover.Name = "btRemover";
            btRemover.Size = new Size(120, 29);
            btRemover.TabIndex = 4;
            btRemover.Text = "Remover Ator";
            btRemover.UseVisualStyleBackColor = true;
            btRemover.Click += btRemover_Click;
            // 
            // btEditar
            // 
            btEditar.Location = new Point(213, 360);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(102, 29);
            btEditar.TabIndex = 5;
            btEditar.Text = "Editar Ator";
            btEditar.UseVisualStyleBackColor = true;
            btEditar.Click += btEditar_Click;
            // 
            // frmAtores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 401);
            Controls.Add(btEditar);
            Controls.Add(btRemover);
            Controls.Add(btCadastrar);
            Controls.Add(dgvAtores);
            Controls.Add(btBuscar);
            Controls.Add(txtBusca);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmAtores";
            Text = "Atores";
            FormClosing += frmAtores_FormClosing;
            Load += frmAtores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAtores).EndInit();
            ((System.ComponentModel.ISupportInitialize)atorBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBusca;
        private Button btBuscar;
        private DataGridView dgvAtores;
        private Button btCadastrar;
        private Button btRemover;
        private Button btEditar;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nacionalidadeDataGridViewTextBoxColumn;
        private BindingSource atorBindingSource;
    }
}