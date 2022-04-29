using eAgenda.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloContato
{
    public partial class TelaContato : Form
    {
        Repositorio<Contato> _repositorioContato;
        public TelaContato()
        {
            _repositorioContato = new Repositorio<Contato>();
            InitializeComponent();
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            CadastrarContato novoContato = new();
            //this.Hide();
            novoContato.Contato = new();
            DialogResult res = novoContato.ShowDialog();
            if(res == DialogResult.OK)
            {
                _repositorioContato.Inserir(novoContato.Contato);
                CarregarContatos();
            }
        }

        private void CarregarContatos()
        {
            List<Contato> contatos = _repositorioContato.SelecionarTodos();
            listBoxContato.Items.Clear();
            foreach (Contato c in contatos)
            {
                listBoxContato.Items.Add(c);
            }
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            Contato contatoSelecionado = (Contato)listBoxContato.SelectedItem;
            CadastrarContato novoContato = new();
            novoContato.Contato = contatoSelecionado;
            DialogResult res = novoContato.ShowDialog();
            if (res == DialogResult.OK)
            {
                _repositorioContato.Editar(novoContato.Contato);
                CarregarContatos();
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            Contato contatoSelecionado = (Contato)listBoxContato.SelectedItem;
            CadastrarContato novoContato = new();
            novoContato.Contato = contatoSelecionado;
        }
    }
}