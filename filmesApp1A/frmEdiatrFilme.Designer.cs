namespace filmesApp1A
{
    partial class frmEdiatrFilme
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
            label3 = new Label();
            txtAno = new TextBox();
            btSalvar = new Button();
            cbxPais = new ComboBox();
            txtNome = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 82);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
            label3.TabIndex = 13;
            label3.Text = "Ano de lançamento:";
            // 
            // txtAno
            // 
            txtAno.Location = new Point(166, 75);
            txtAno.Margin = new Padding(3, 4, 3, 4);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(114, 27);
            txtAno.TabIndex = 12;
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(117, 189);
            btSalvar.Margin = new Padding(3, 4, 3, 4);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(86, 31);
            btSalvar.TabIndex = 11;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // cbxPais
            // 
            cbxPais.FormattingEnabled = true;
            cbxPais.Location = new Point(165, 136);
            cbxPais.Margin = new Padding(3, 4, 3, 4);
            cbxPais.Name = "cbxPais";
            cbxPais.Size = new Size(138, 28);
            cbxPais.TabIndex = 10;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(166, 13);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(114, 27);
            txtNome.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 144);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 8;
            label2.Text = "Nacionalidade:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 25);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 7;
            label1.Text = "Nome:";
            // 
            // frmEdiatrFilme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 243);
            Controls.Add(label3);
            Controls.Add(txtAno);
            Controls.Add(btSalvar);
            Controls.Add(cbxPais);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmEdiatrFilme";
            Text = "frmEdiatrFilme";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtAno;
        private Button btSalvar;
        private ComboBox cbxPais;
        private TextBox txtNome;
        private Label label2;
        private Label label1;
    }
}