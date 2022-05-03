using eAgenda.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                bool podeSeguir = VerificarDuplicidade(telaCadContato.Contato);
                if (!podeSeguir)
                {
                    return;
                }

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

            if (contatoSelecionado == null)
            {
                MessageBox.Show("É preciso selecionar um contato para editar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool temAlgo = VerificarContinuidade(contatoSelecionado, "Editar");
            if (!temAlgo)
                return;

            Contato novoContato = new();

            novoContato.id = contatoSelecionado.id;
            novoContato.Nome = contatoSelecionado.Nome;
            novoContato.Email = contatoSelecionado.Email;
            novoContato.Telefone = contatoSelecionado.Telefone;
            novoContato.Empresa = contatoSelecionado.Empresa;
            novoContato.Cargo = contatoSelecionado.Cargo;
            novoContato.EstaEmCompromisso = contatoSelecionado.EstaEmCompromisso;

            TelaCadastrarContato telaCadContato = new(novoContato); // Povoa com as mesmas informações sem editar as antigas

            DialogResult res = telaCadContato.ShowDialog();

            if (res == DialogResult.OK)
            {
                if(telaCadContato.Contato.id == contatoSelecionado.id == false)
                {
                    bool podeSeguir = VerificarDuplicidade(telaCadContato.Contato);
                    if (!podeSeguir)
                    {
                        return;
                    }
                }

                string status = _repositorioContato.Editar(novoContato, contatoSelecionado);
                if (status == "REGISTRO_VALIDO")
                {
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

            if (listBoxContato.Items.Count == 0)
            {
                MessageBox.Show("Nenhum contato para excluir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (contatoSelecionado == null)
            {
                MessageBox.Show("É necessário selecionar um contato para excluir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (contatoSelecionado.EstaEmCompromisso)
            {
                MessageBox.Show("O contato está presente em um compromisso, não é possível excluir", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool temAlgo = VerificarContinuidade(contatoSelecionado, "Excluir");
            if (!temAlgo)
                return;

            DialogResult resultado = MessageBox.Show("Excluir contato?",
                "Excluir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                _repositorioContato.Excluir(contatoSelecionado);
                CarregarContatosNaTela();
            }
        }
        private bool VerificarDuplicidade(Contato contato)
        {
            List<Contato> todos = _repositorioContato.SelecionarTodos();

            foreach (Contato contatoJaRegistrado in todos)
            {
                StringBuilder sb = new();

                if (contatoJaRegistrado.Nome == contato.Nome)
                    sb.AppendLine("O nome do contato já existe");

                if (contatoJaRegistrado.Email == contato.Email)
                    sb.AppendLine("O email do contato já existe");

                if (contatoJaRegistrado.Telefone == contato.Telefone)
                    sb.AppendLine("O telefone já existe");

                if (sb.Length > 0)
                {
                    MessageBox.Show($"{sb}\nTente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private bool VerificarContinuidade(Contato contatoSelecionado, string tipo)
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

        private void buttonVisualizarNormal_Click(object sender, EventArgs e)
        {
            if (listBoxContato.Items.Count == 0)
            {
                MessageBox.Show("Sem contatos cadastrados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CarregarContatosNaTela();
        }
        private void buttonVisualizarCargo_Click(object sender, EventArgs e)
        {
            if (listBoxContato.Items.Count == 0)
            {
                MessageBox.Show("Sem contatos cadastrados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CarregarContatosPorGrupo();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void CarregarContatosPorGrupo()
        {
            var contatosPorCargo = _repositorioContato.SelecionarTodos()
                                                    .OrderBy(x => x.Cargo)
                                                    .ToList();

            listBoxContato.Items.Clear();

            foreach (var c in contatosPorCargo)
            {
                listBoxContato.Items.Add(c);
            }
        }
    }
}