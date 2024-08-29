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
    public partial class frmNovoFilme : Form
    {
        Contexto db;
        public frmNovoFilme()
        {
            InitializeComponent();
            this.db = new Contexto();

            List<Pais> paises = this.db.Pais.ToList();//puxando do banco SEM filtro
            cbxPais.DataSource = paises;
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            Filme novo = new Filme();
            novo.Nome = txtNome.Text;

            Pais pais = this.db.Pais.Where(p => p.Nome == cbxPais.SelectedItem.ToString()).First();
            novo.Nacionalidade = pais;

            if (int.TryParse(txtAnoLanc.Text, out int anoLancamento))
            {
                novo.AnoLancamento = anoLancamento;
            }
            else
            {
                MessageBox.Show("Ano de lançamento inválido.");
                return;
            }

            this.db.Filme.Add(novo);
            this.db.SaveChanges();

            MessageBox.Show("Sucesso!");
            this.Close();
        }
                
    }
}
