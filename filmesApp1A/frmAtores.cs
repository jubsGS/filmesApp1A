﻿using filmesApp1A.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filmesApp1A
{
    public partial class frmAtores : Form
    {
        Contexto db;
        Form anterior;
        public frmAtores(Form anterior)
        {
            InitializeComponent();

            this.anterior = anterior;

            this.db = new Contexto();
            this.db.Database.EnsureCreated();
            Recarregar("");//vai servir pra atualizar o dgv e a busca

        }
        public void Recarregar(string busca)
        {
            List<Ator> atores = this.db.Ator
                .Where(a => a.Nome.ToUpper().Contains(busca.ToUpper())).ToList();//puxando do banco COM filtro
            dgvAtores.DataSource = atores;
        }

        private void frmAtores_Load(object sender, EventArgs e)
        {

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            Recarregar(txtBusca.Text);
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            frmNovoAtor f = new frmNovoAtor();
            f.ShowDialog();
            Recarregar(txtBusca.Text);

        }
        Ator selecionado;

        private void btEditar_Click(object sender, EventArgs e)
        {
            frmEditarAtor f = new frmEditarAtor(selecionado, db);
            f.ShowDialog();
            Recarregar(txtBusca.Text);
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            this.db.Ator.Remove(selecionado);
            this.db.SaveChanges();

            btEditar.Enabled = false;
            btRemover.Enabled = false;

            Recarregar(txtBusca.Text);
        }
        private void frmAtores_FormClosing(object sender, FormClosingEventArgs e)
        {
            anterior.Show();
        }

        private void dgvAtores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgvAtores.SelectedCells[0].RowIndex;
            int id = (int)dgvAtores.Rows[linha].Cells[0].Value;

            selecionado = this.db.Ator.Where(a => a.Id == id).First();

            btEditar.Enabled = true;
            btRemover.Enabled = true;
        }
    }
}
