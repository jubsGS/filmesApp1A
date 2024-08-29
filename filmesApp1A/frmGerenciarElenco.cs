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
    public partial class frmGerenciarElenco : Form
    {
        Contexto db;
        Filme filme;
        public frmGerenciarElenco(Filme filme, Contexto db)
        {
            InitializeComponent();
            this.filme = filme;
            this.db = db;
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            frmAdicionarAtor f = new frmAdicionarAtor(filme, db);
            f.ShowDialog();

            Recarregar();
        }

        public void Recarregar()
        {
            List<Ator> atores = this.db.Ator.Where(a => a.Filmes.Contains(filme)).ToList();
            dgvElenco.DataSource = atores;
        }

        Ator selecionado;

        private void btRemover_Click(object sender, EventArgs e)
        {
            filme.Atores.Remove(selecionado);
            db.Filme.Update(filme);
            this.db.SaveChanges();
            Recarregar();
        }

        private void frmGerenciarElenco_Load(object sender, EventArgs e)
        {
            Recarregar();
            filme.Atores.ToList();
            dgvElenco.DataSource = filme.Atores;
        }

        private void dgvElenco_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
