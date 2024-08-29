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
    public partial class frmAdicionarAtor : Form
    {
        Filme filme;
        Contexto db;
        public frmAdicionarAtor(Filme filme, Contexto db)
        {
            InitializeComponent();
            this.db = db;
            this.filme = filme;

            List<Ator> atores = this.db.Ator.ToList();
            dgvAdicionarAtor.DataSource = atores;
        }

        Ator selecionado;

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            filme.Atores.Add(selecionado);
            db.Filme.Update(filme);

            db.SaveChanges();

            MessageBox.Show("Ator adicionado com sucesso ao filme!");
            this.Hide();
        }

        private void dgvAdicionarAtor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgvAdicionarAtor.SelectedCells[0].RowIndex;
            int id = (int)dgvAdicionarAtor.Rows[linha].Cells[0].Value;

            selecionado = this.db.Ator.Where(a => a.Id == id).First();
        }
    }
}
