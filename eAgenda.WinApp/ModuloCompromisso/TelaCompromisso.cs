using eAgenda.Dominio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloCompromisso
{
    public partial class TelaCompromisso : Form
    {
        Repositorio<Compromisso> _repositorioCompromisso;
        Repositorio<Contato>? _repositorioContato;

        public TelaCompromisso(Repositorio<Compromisso> repositorio, Repositorio<Contato> repositorioContato)
        {
            InitializeComponent();
            _repositorioCompromisso = repositorio;
            _repositorioContato = repositorioContato;
            CarregarCompromissosPassados();
            CarregarCompromissosFuturos();
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            TelaCadastrarCompromisso telaCadCompromisso = new(new Compromisso(), _repositorioContato!);
            DialogResult res = telaCadCompromisso.ShowDialog();
            if (res == DialogResult.OK)
            {
                string status = _repositorioCompromisso.Inserir(telaCadCompromisso.Compromisso);

                if (status == "REGISTRO_VALIDO")
                {
                    telaCadCompromisso.Compromisso.Contato.EstaEmCompromisso = true;
                    MessageBox.Show("Compromisso inserido com sucesso!", "Contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show($"{status}\nTente novamente", "Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                CarregarCompromissosPassados();
                CarregarCompromissosFuturos();
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            Compromisso compromissoSelecionado = (Compromisso)listBoxCompromissosFuturos.SelectedItem;

            Compromisso novoCompromisso = new();

            novoCompromisso.id = compromissoSelecionado.id;
            novoCompromisso.Assunto = compromissoSelecionado.Assunto;
            novoCompromisso.Local = compromissoSelecionado.Local;
            novoCompromisso.DataCompromisso = compromissoSelecionado.DataCompromisso;
            novoCompromisso.HoraInicio = compromissoSelecionado.HoraInicio;
            novoCompromisso.HoraFim = compromissoSelecionado.HoraFim;
            novoCompromisso.Contato = compromissoSelecionado.Contato;

            TelaCadastrarCompromisso telaCadCompromisso = new(novoCompromisso, _repositorioContato!);

            DialogResult res = telaCadCompromisso.ShowDialog();

            if (res == DialogResult.OK)
            {
                string status = _repositorioCompromisso.Editar(telaCadCompromisso.Compromisso, compromissoSelecionado);
                if (status == "REGISTRO_VALIDO")
                    MessageBox.Show("Compromisso editado com sucesso!", "Contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show($"{status}\nTente novamente", "Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                CarregarCompromissosPassados();
                CarregarCompromissosFuturos();
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            Compromisso compromissoSelecionado = (Compromisso)listBoxCompromissosFuturos.SelectedItem;

            bool temAlgo = VerificarContinuidade(compromissoSelecionado, "Excluir");
            if (!temAlgo)
                return;

            DialogResult resultado = MessageBox.Show("Excluir compromisso?",
                "Excluir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                _repositorioCompromisso.Excluir(compromissoSelecionado);
                CarregarCompromissosPassados();
                CarregarCompromissosFuturos();
            }
        }


        public bool VerificarContinuidade(Compromisso compromissoSelecionado, string tipo)
        {
            bool temAlgo = _repositorioCompromisso.ExisteRegistro();
            if (!temAlgo)
            {
                MessageBox.Show($"Nenhum compromisso para {tipo}", tipo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (compromissoSelecionado == null)
            {
                MessageBox.Show($"Selecione um compromisso para {tipo}", tipo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        public void CarregarCompromissosPassados()
        {
            List<Compromisso> compromissosPassados = _repositorioCompromisso.Filtrar(x => x.DataCompromisso <= DateTime.Now);
            listBoxCompromissosPassados.Items.Clear();
            foreach (Compromisso c in compromissosPassados)
            {
                listBoxCompromissosPassados.Items.Add(c);
            }
        }

        public void CarregarCompromissosFuturos()
        {
            List<Compromisso> compromissosFuturos = _repositorioCompromisso.Filtrar(x => x.DataCompromisso > DateTime.Now);
            listBoxCompromissosFuturos.Items.Clear();
            foreach (Compromisso c in compromissosFuturos)
            {
                listBoxCompromissosFuturos.Items.Add(c);
            }
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}