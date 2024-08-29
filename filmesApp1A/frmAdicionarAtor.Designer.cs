namespace filmesApp1A
{
    partial class frmAdicionarAtor
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
            atorBindingSource = new BindingSource(components);
            btAdicionar = new Button();
            dgvAdicionarAtor = new DataGridView();
            atorBindingSource1 = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nacionalidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)atorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAdicionarAtor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)atorBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // btAdicionar
            // 
            btAdicionar.Location = new Point(132, 391);
            btAdicionar.Margin = new Padding(3, 4, 3, 4);
            btAdicionar.Name = "btAdicionar";
            btAdicionar.Size = new Size(195, 31);
            btAdicionar.TabIndex = 3;
            btAdicionar.Text = "Adicionar";
            btAdicionar.UseVisualStyleBackColor = true;
            btAdicionar.Click += btAdicionar_Click;
            // 
            // dgvAdicionarAtor
            // 
            dgvAdicionarAtor.AutoGenerateColumns = false;
            dgvAdicionarAtor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdicionarAtor.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, nacionalidadeDataGridViewTextBoxColumn });
            dgvAdicionarAtor.DataSource = atorBindingSource1;
            dgvAdicionarAtor.Location = new Point(21, 27);
            dgvAdicionarAtor.Margin = new Padding(3, 4, 3, 4);
            dgvAdicionarAtor.Name = "dgvAdicionarAtor";
            dgvAdicionarAtor.RowHeadersWidth = 51;
            dgvAdicionarAtor.Size = new Size(428, 356);
            dgvAdicionarAtor.TabIndex = 2;
            dgvAdicionarAtor.CellClick += dgvAdicionarAtor_CellClick;
            // 
            // atorBindingSource1
            // 
            atorBindingSource1.DataSource = typeof(Models.Ator);
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
            // frmAdicionarAtor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 450);
            Controls.Add(dgvAdicionarAtor);
            Controls.Add(btAdicionar);
            Name = "frmAdicionarAtor";
            Text = "AdicionarAtor";
            ((System.ComponentModel.ISupportInitialize)atorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAdicionarAtor).EndInit();
            ((System.ComponentModel.ISupportInitialize)atorBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource atorBindingSource;
        private Button btAdicionar;
        private DataGridView dgvAdicionarAtor;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nacionalidadeDataGridViewTextBoxColumn;
        private BindingSource atorBindingSource1;
    }
}