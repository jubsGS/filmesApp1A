namespace filmesApp1A
{
    partial class frmNovoAtor
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
            txtNome = new TextBox();
            label1 = new Label();
            btCadastrar = new Button();
            cbxPais = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(148, 38);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(270, 27);
            txtNome.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 41);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 1;
            label1.Text = "Nome:";
            // 
            // btCadastrar
            // 
            btCadastrar.Location = new Point(135, 155);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(185, 29);
            btCadastrar.TabIndex = 2;
            btCadastrar.Text = "Cadastrar";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += btCadastrar_Click;
            // 
            // cbxPais
            // 
            cbxPais.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPais.FormattingEnabled = true;
            cbxPais.Location = new Point(148, 71);
            cbxPais.Name = "cbxPais";
            cbxPais.Size = new Size(270, 28);
            cbxPais.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 79);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 4;
            label2.Text = "Nacionalidade:";
            // 
            // frmNovoAtor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 210);
            Controls.Add(label2);
            Controls.Add(cbxPais);
            Controls.Add(btCadastrar);
            Controls.Add(label1);
            Controls.Add(txtNome);
            MaximizeBox = false;
            Name = "frmNovoAtor";
            Text = "frmNovoAtor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label label1;
        private Button btCadastrar;
        private ComboBox cbxPais;
        private Label label2;
    }
}