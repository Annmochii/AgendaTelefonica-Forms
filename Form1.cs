using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaTelefonica
{
    public partial class FormHome : Form
    {
        public List<Contato> listaContatos;
        public Contato selecionado;

        public FormHome()
        {
            InitializeComponent();
            listaContatos = new List<Contato>();

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this, null);
            form2.Show();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this, selecionado);
            form2.Show();
        }

        private void dgvContatos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int x = e.RowIndex;
            selecionado = listaContatos[x];
        }
    }
}
