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

namespace eAgenda.WinApp.ModuloCompromisso
{
    public partial class TelaCompromisso : Form
    {
        Repositorio<Compromisso> _repositorioCompromisso;
        public TelaCompromisso(Repositorio<Compromisso> repositorio)
        {
            InitializeComponent();
            _repositorioCompromisso = repositorio;
            //CarregarCompromissosPassados();
            //CarregarCompromissosFuturos();
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            TelaCadastrarCompromisso telaCadCompromisso = new(new Compromisso());
            DialogResult res = telaCadCompromisso.ShowDialog();
        }
    }
}
