﻿namespace filmesApp1A
{
    partial class frmMenu
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
            btAtores = new Button();
            btFilmes = new Button();
            SuspendLayout();
            // 
            // btAtores
            // 
            btAtores.Location = new Point(58, 68);
            btAtores.Name = "btAtores";
            btAtores.Size = new Size(231, 29);
            btAtores.TabIndex = 0;
            btAtores.Text = "Gerenciar atores";
            btAtores.UseVisualStyleBackColor = true;
            btAtores.Click += btAtores_Click;
            // 
            // btFilmes
            // 
            btFilmes.Location = new Point(60, 114);
            btFilmes.Name = "btFilmes";
            btFilmes.Size = new Size(231, 29);
            btFilmes.TabIndex = 1;
            btFilmes.Text = "Gerenciar filmes";
            btFilmes.UseVisualStyleBackColor = true;
            btFilmes.Click += btFilmes_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 213);
            Controls.Add(btFilmes);
            Controls.Add(btAtores);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += frmMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btAtores;
        private Button btFilmes;
    }
}