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
    public partial class frmEdiatrFilme : Form
    {

        Filme filme;
        Contexto db;
        public frmEdiatrFilme(Filme filme, Contexto db)
        {
            InitializeComponent();

            this.filme = filme;
            this.db = db;

            if (this.filme == null)
            {
                MessageBox.Show("Filme não encontrado no banco de dados.");
                this.Close();
                return;
            }

            txtNome.Text = filme.Nome;

            txtAno.Text = filme.AnoLancamento.ToString();

            List<Pais> paises = this.db.Pais.ToList();
            cbxPais.DataSource = paises;
            cbxPais.SelectedIndex = cbxPais.FindStringExact(filme.Nacionalidade.Nome);
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {

            filme.Nome = txtNome.Text;
            filme.AnoLancamento = int.Parse(txtAno.Text);

            Pais pais = db.Pais.Where(p => p.Nome == cbxPais.SelectedItem.ToString()).First();
            filme.Nacionalidade = pais;

            this.db.Filme.Update(filme);
            this.db.SaveChanges();
            MessageBox.Show("Sucesso!");

            this.Hide();
        }
    }
}
