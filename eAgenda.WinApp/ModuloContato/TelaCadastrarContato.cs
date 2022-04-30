using eAgenda.Dominio;
using System;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloContato
{
    public partial class TelaCadastrarContato : Form
    {
        #region Atributos
        private Contato? _contato;
        #endregion

        public TelaCadastrarContato(Contato contato)
        {
            InitializeComponent();
            _contato = contato;
            if (contato != null)
            {
                textBoxNome.Text = contato.Nome;
                textBoxEmail.Text = contato.Email;
                textBoxTelefone.Text = contato.Telefone;
                textBoxEmpresa.Text = contato.Empresa;
                textBoxCargo.Text = contato.Cargo;
            }
        }

        public Contato Contato
        {
            get { return _contato!; }
            set { _contato = value; }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            _contato!.Nome = textBoxNome.Text;
            _contato!.Email = textBoxEmail.Text;
            _contato!.Telefone = textBoxTelefone.Text;
            _contato!.Empresa = textBoxEmpresa.Text;
            _contato!.Cargo = textBoxCargo.Text;
        }
    }
}
