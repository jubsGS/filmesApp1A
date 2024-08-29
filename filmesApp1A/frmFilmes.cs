using filmesApp1A.Models;
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
    public partial class frmFilmes : Form
    {
        Contexto db;
        Form anterior;
        public frmFilmes(Form anterior)
        {
            InitializeComponent();
            this.anterior = anterior;

            this.db = new Contexto();
            this.db.Database.EnsureCreated();
            Recarregar("");//vai servir pra atualizar o dgv e a busca
        }

        public void Recarregar(string busca)
        {
            List<Filme> filmes = this.db.Filme.Where(a => a.Nome.ToUpper().Contains(busca.ToUpper())).ToList();//puxando do banco COM filtro
            dgvFilmes.DataSource = filmes;
        }


        private void frmFilmes_Load(object sender, EventArgs e)
        {

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            frmNovoFilme f = new frmNovoFilme();
            f.ShowDialog();
            Recarregar(txtBusca.Text);
        }
        Filme selecionado;

        private void btGerenciar_Click(object sender, EventArgs e)
        {
            frmGerenciarElenco g = new frmGerenciarElenco(selecionado, db);
            g.ShowDialog();
            Recarregar(txtBusca.Text);
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            frmEdiatrFilme f = new frmEdiatrFilme(selecionado, db);
            f.ShowDialog();
            Recarregar(txtBusca.Text);
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (selecionado != null)
            {
                this.db.Filme.Remove(selecionado);
                this.db.SaveChanges();

                btEditar.Enabled = false;
                btRemover.Enabled = false;

                Recarregar(txtBusca.Text);
            }
            else
            {
                MessageBox.Show("Nenhum filme foi slecionado paara exclusão.");
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            Recarregar(txtBusca.Text);
        }
        private void dgvFilmes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgvFilmes.SelectedCells[0].RowIndex;
            int id = (int)dgvFilmes.Rows[linha].Cells[0].Value;

            selecionado = this.db.Filme.Where(a => a.Id == id).First();

            btEditar.Enabled = true;
            btRemover.Enabled = true;
        }
        private void frmFilmes_FormClosing(object sender, FormClosingEventArgs e)
        {
            anterior.Show();
        }


        private void txtBusca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}