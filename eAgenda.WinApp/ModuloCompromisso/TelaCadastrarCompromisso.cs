using eAgenda.Dominio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloCompromisso
{
    public partial class TelaCadastrarCompromisso : Form
    {
        private Compromisso? _compromisso;
        private Repositorio<Contato> _repositorioContato;
        public TelaCadastrarCompromisso(Compromisso compromissoVazio, Repositorio<Contato> repositorioContato)
        {
            InitializeComponent();
            _repositorioContato = repositorioContato;
            _compromisso = compromissoVazio;

            List<Contato> contatos = _repositorioContato.SelecionarTodos();

            listBoxContatos.Items.Clear();
            foreach (Contato c in contatos)
            {
                listBoxContatos.Items.Add(c);
            }

            if (_compromisso != null)
            {
                textBoxAssunto.Text = _compromisso.Assunto;
                textBoxLocal.Text = _compromisso.Local;
                maskedTextBoxData.Text = _compromisso.DataCompromisso.ToString();
                maskedTextBoxHoraInicio.Text = _compromisso.HoraInicio.ToString();
                maskedTextBoxHoraFim.Text = _compromisso.HoraFim.ToString();
                if (_compromisso.Contato != null)
                    labelContato.Text = "Nenhum";
                else
                    labelContato.Text = _compromisso.Contato!.ToString();
            }
        }

        public Compromisso Compromisso
        {
            get { return _compromisso!; }
            set { _compromisso = value; }
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            _compromisso!.Assunto = textBoxAssunto.Text;
            _compromisso.Local = textBoxLocal.Text;
            if (maskedTextBoxData.Text != "  /  /")
                _compromisso.DataCompromisso = DateTime.Parse(maskedTextBoxData.Text);
            else
                _compromisso.DataCompromisso = null;
            _compromisso.HoraInicio = TimeSpan.Parse(maskedTextBoxHoraInicio.Text);
            _compromisso.HoraFim = TimeSpan.Parse(maskedTextBoxHoraFim.Text);
            if (listBoxContatos.SelectedItem == null)
            {
                listBoxContatos.SelectedItem = _compromisso.Contato;
            }
            _compromisso.Contato = (Contato)listBoxContatos.SelectedItem;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}