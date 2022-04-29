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
    public partial class CadastrarContato : Form
    {
        #region Atributos
        private Contato? contato;
        #endregion

        public CadastrarContato()
        {
            InitializeComponent();
        }

        public Contato Contato
        {
            get { return contato!; }
            set { contato = value; }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            contato!.Nome = textBoxNome.Text;
            contato!.Email = textBoxEmail.Text;
            contato!.Telefone = textBoxTelefone.Text;
            contato!.Empresa = textBoxEmpresa.Text;
            contato!.Cargo = textBoxCargo.Text;
        }
    }
}
