using eAgenda.Dominio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloContato
{
    public partial class TelaContato : Form
    {
        Repositorio<Contato> _repositorioContato;
        public TelaContato(Repositorio<Contato> repositorio)
        {
            InitializeComponent();
            _repositorioContato = repositorio;
            CarregarContatosNaTela();
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            TelaCadastrarContato telaCadContato = new(new Contato());

            DialogResult res = telaCadContato.ShowDialog();

            if (res == DialogResult.OK)
            {
                string status = _repositorioContato.Inserir(telaCadContato.Contato);

                if (status == "REGISTRO_VALIDO")
                    MessageBox.Show("Contato inserido com sucesso!", "Contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show($"{status}\nTente novamente", "Contato", MessageBoxButtons.OK, MessageBoxIcon.Error);

                CarregarContatosNaTela();
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            Contato contatoSelecionado = (Contato)listBoxContato.SelectedItem;

            Contato novoContato = new();

            novoContato.id = contatoSelecionado.id;
            novoContato.Nome = contatoSelecionado.Nome;
            novoContato.Email = contatoSelecionado.Email;
            novoContato.Telefone = contatoSelecionado.Telefone;
            novoContato.Empresa = contatoSelecionado.Empresa;
            novoContato.Cargo = contatoSelecionado.Cargo;

            bool temAlgo = VerificarContinuidade(contatoSelecionado, "Editar");
            if (!temAlgo)
                return;

            TelaCadastrarContato telaCadContato = new(novoContato); // Povoa com as mesmas informações sem editar as antigas

            DialogResult res = telaCadContato.ShowDialog();

            if (res == DialogResult.OK)
            {
                string status = _repositorioContato.Editar(novoContato, contatoSelecionado);
                if (status == "REGISTRO_VALIDO")
                {
                    //contatoSelecionado = novoContato;
                    MessageBox.Show("Contato editado com sucesso!", "Contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    CarregarContatosNaTela();
                }
                else
                { 
                    MessageBox.Show($"{status}\nTente novamente", "Contato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CarregarContatosNaTela();
                }
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            Contato contatoSelecionado = (Contato)listBoxContato.SelectedItem;

            bool temAlgo = VerificarContinuidade(contatoSelecionado, "Excluir");
            if (!temAlgo)
                return;

            DialogResult resultado = MessageBox.Show("Excluir esta contato?",
                "Excluir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                _repositorioContato.Excluir(contatoSelecionado);
                CarregarContatosNaTela();
            }
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool VerificarContinuidade(Contato contatoSelecionado, string tipo)
        {
            bool temAlgo = _repositorioContato.ExisteRegistro();
            if (!temAlgo)
            {
                MessageBox.Show($"Nenhum contato para {tipo}", tipo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (contatoSelecionado == null)
            {
                MessageBox.Show($"Selecione um contato para {tipo}", tipo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }
        private void CarregarContatosNaTela()
        {
            List<Contato> contatos = _repositorioContato.SelecionarTodos();
            listBoxContato.Items.Clear();
            foreach (Contato c in contatos)
            {
                listBoxContato.Items.Add(c);
            }
        }
    }
}