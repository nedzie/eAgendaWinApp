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
            CarregarCompromissosNaTela();
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            TelaCadastrarCompromisso telaCadCompromisso = new(new Compromisso(), _repositorioContato!);
            DialogResult res = telaCadCompromisso.ShowDialog();
            if (res == DialogResult.OK)
            {
                Compromisso temp = telaCadCompromisso.Compromisso;

                bool podeSeguir = ValidarHorarios(temp);
                if (!podeSeguir)
                    return;

                string status = _repositorioCompromisso.Inserir(telaCadCompromisso.Compromisso);

                if (status == "REGISTRO_VALIDO")
                {
                    if (telaCadCompromisso.Compromisso.Contato != null)
                        telaCadCompromisso.Compromisso.Contato.EstaEmCompromisso = true;

                    MessageBox.Show("Compromisso inserido com sucesso!", "Contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show($"{status}\nTente novamente", "Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                CarregarCompromissosNaTela();
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
                Compromisso temp = telaCadCompromisso.Compromisso;

                bool podeSeguir = ValidarHorarios(temp);
                if (!podeSeguir)
                    return;

                string status = _repositorioCompromisso.Editar(telaCadCompromisso.Compromisso, compromissoSelecionado);
                if (status == "REGISTRO_VALIDO")
                    MessageBox.Show("Compromisso editado com sucesso!", "Contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show($"{status}\nTente novamente", "Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                CarregarCompromissosNaTela();
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
                CarregarCompromissosNaTela();
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

        public bool ValidarHorarios(Compromisso novoCompromisso)
        {
            List<Compromisso> todos = _repositorioCompromisso.SelecionarTodos();

            foreach (Compromisso compromissoJaRegistrado in todos)
            {
                if (compromissoJaRegistrado.DataCompromisso == novoCompromisso.DataCompromisso)
                {
                    if (novoCompromisso.HoraInicio >= compromissoJaRegistrado.HoraInicio &&
                        novoCompromisso.HoraInicio <= compromissoJaRegistrado.HoraFim ||
                        novoCompromisso.HoraFim <= compromissoJaRegistrado.HoraFim &&
                        novoCompromisso.HoraFim >= compromissoJaRegistrado.HoraInicio)
                    {
                        MessageBox.Show("O horário deste compromisso conflita com a de outro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }
            }
            return true;
        }

        public void CarregarCompromissosNaTela()
        {
            CarregarCompromissosFuturos();
            CarregarCompromissosPassados();
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

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxInicio.Text != "  /  /" && maskedTextBoxFim.Text != "  /  /")
            {
                DateTime inicio = DateTime.Parse(maskedTextBoxInicio.Text);
                DateTime fim = DateTime.Parse(maskedTextBoxFim.Text);

                if(fim < inicio && listBoxCompromissosFuturos.Items.Count > 0)
                {
                    MessageBox.Show("O início não pode ser menor que o fim!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                List<Compromisso> compromissosNoPeriodo = _repositorioCompromisso.Filtrar(x => x.DataCompromisso >= inicio, x => x.DataCompromisso <= fim);
                if(compromissosNoPeriodo.Count == 0)
                {
                    MessageBox.Show("Sem compromissos neste período!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                listBoxCompromissosFuturos.Items.Clear();
                foreach (Compromisso c in compromissosNoPeriodo)
                {
                    listBoxCompromissosFuturos.Items.Add(c);
                }
            }
            else if (maskedTextBoxInicio.Text == "  /  /" || maskedTextBoxFim.Text == "  /  /" && listBoxCompromissosFuturos.Items.Count > 0)
                MessageBox.Show("Preencha ambos os campos para filtrar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(listBoxCompromissosFuturos.Items.Count == 0)
            {
                MessageBox.Show("Sem compromissos para filtrar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonVisualizarNormal_Click(object sender, EventArgs e)
        {
            CarregarCompromissosNaTela();
        }
    }
}