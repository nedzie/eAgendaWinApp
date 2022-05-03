using eAgenda.Dominio;
using eAgenda.WinApp.ModuloCompromisso;
using eAgenda.WinApp.ModuloContato;
using eAgenda.WinApp.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WinApp
{
    public partial class Principal : Form
    {
        Repositorio<Contato> repositorioContato;
        TelaContato? telaContato;
        Repositorio<Compromisso> repositorioCompromisso;
        TelaCompromisso? telaCompromisso;
        Repositorio<Tarefa> repositorioTarefa;
        TelaTarefa? telaTarefa;
        public Principal()
        {
            InitializeComponent();
            repositorioContato = new Repositorio<Contato>();
            repositorioCompromisso = new Repositorio<Compromisso>();
            repositorioTarefa = new Repositorio<Tarefa>();
        }

        private void buttonCompromisso_Click(object sender, EventArgs e)
        {
            telaCompromisso = new(repositorioCompromisso, repositorioContato);
            telaCompromisso.Show();
        }

        private void buttonContato_Click(object sender, EventArgs e)
        {
            telaContato = new(repositorioContato);
            telaContato.Show();
        }

        private void buttonTarefa_Click(object sender, EventArgs e)
        {
            telaTarefa = new(repositorioTarefa);
            telaTarefa.Show();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}