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
    public partial class Form2 : Form
    {
        FormHome origem;
        Contato contato;

        public Form2(FormHome origem, Contato selecionado)
        {
            InitializeComponent();
            this.origem = origem;

            cbxTipo.Items.Add(new TipoTelefone(1, "Profissional"));
            cbxTipo.Items.Add(new TipoTelefone(2, "Pessoal"));
            cbxTipo.Items.Add(new TipoTelefone(3, "Whatsapp"));
            cbxTipo.Items.Add(new TipoTelefone(4, "Recado"));
            cbxTipo.DisplayMember = "nome";

            this.contato = selecionado;
            if (contato != null)
            {
                txbNome.Text = contato.nome;
                txbSobrenome.Text = contato.sobrenome;
                txbTelefone.Text = contato.telefone;

                foreach (TipoTelefone tipo in cbxTipo.Items)
                {
                    if (tipo.id == contato.tipo.id && tipo.nome == contato.tipo.nome)
                    {
                        cbxTipo.SelectedItem = tipo;
                        break;
                    }
                }
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if(this.contato == null)
            {
                int proxID = origem.listaContatos.Count + 1;
                Contato aux = new Contato(proxID, txbNome.Text, txbSobrenome.Text, txbTelefone.Text, (TipoTelefone)cbxTipo.SelectedItem);
                origem.listaContatos.Add(aux);
            }
            else
            {
                contato.nome = txbNome.Text;
                contato.sobrenome = txbSobrenome.Text;
                contato.telefone = txbTelefone.Text;
                contato.tipo = (TipoTelefone)cbxTipo.SelectedItem;

                origem.listaContatos[contato.id - 1] = contato;
            }


            origem.dgvContatos.DataSource = null;
            origem.dgvContatos.DataSource = origem.listaContatos;
            origem.dgvContatos.Refresh();

            this.Close();
        }
    }
}
