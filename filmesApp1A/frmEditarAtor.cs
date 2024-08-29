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
    public partial class frmEditarAtor : Form
    {
        Ator ator;
        Contexto db;
        public frmEditarAtor(Ator ator, Contexto db)
        {
            InitializeComponent();

            this.ator = ator;
            this.db = db;

            txtNome.Text = ator.Nome;

            List<Pais> paises = this.db.Pais.ToList();
            cbxPais.DataSource = paises;

            cbxPais.SelectedIndex =
                cbxPais.FindStringExact(ator.Nacionalidade.Nome);

            dgvFilmes.DataSource = ator.Filmes;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            ator.Nome = txtNome.Text;
            Pais pais = this.db.Pais
                        .Where(p => p.Nome == cbxPais.SelectedItem.ToString())
                        .First();
            ator.Nacionalidade = pais;

            this.db.Ator.Update(ator);
            this.db.SaveChanges();
            MessageBox.Show("Sucesso!");

            this.Hide();
        }
        private void frmAtores_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
