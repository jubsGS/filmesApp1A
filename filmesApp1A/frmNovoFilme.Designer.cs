namespace filmesApp1A
{
    partial class frmNovoFilme
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
            label2 = new Label();
            cbxPais = new ComboBox();
            btCadastrar = new Button();
            label1 = new Label();
            txtNome = new TextBox();
            label3 = new Label();
            txtAnoLanc = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 117);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 9;
            label2.Text = "Nacionalidade:";
            // 
            // cbxPais
            // 
            cbxPais.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPais.FormattingEnabled = true;
            cbxPais.Location = new Point(171, 109);
            cbxPais.Name = "cbxPais";
            cbxPais.Size = new Size(270, 28);
            cbxPais.TabIndex = 8;
            // 
            // btCadastrar
            // 
            btCadastrar.Location = new Point(132, 154);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(185, 29);
            btCadastrar.TabIndex = 7;
            btCadastrar.Text = "Cadastrar";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += btCadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 40);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 6;
            label1.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(171, 37);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(270, 27);
            txtNome.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 76);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 11;
            label3.Text = "Ano de Lançamento:";
            // 
            // txtAnoLanc
            // 
            txtAnoLanc.Location = new Point(171, 73);
            txtAnoLanc.Name = "txtAnoLanc";
            txtAnoLanc.Size = new Size(270, 27);
            txtAnoLanc.TabIndex = 12;
            // 
            // frmNovoFilme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 211);
            Controls.Add(txtAnoLanc);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbxPais);
            Controls.Add(btCadastrar);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Name = "frmNovoFilme";
            Text = "frmNovoFilme";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ComboBox cbxPais;
        private Button btCadastrar;
        private Label label1;
        private TextBox txtNome;
        private Label label3;
        private TextBox txtAnoLanc;
    }
}