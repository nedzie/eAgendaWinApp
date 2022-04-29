using eAgenda.Dominio;
using eAgenda.WinApp.ModuloContato;
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
        public Principal()
        {
            Repositorio<Contato> repositorioContato = new();
            //Repositorio<Compromisso> repositorioCompromisso = new();
            //Repositorio<Tarefa> repositorioTarefa = new();
            InitializeComponent();
        }

        private void buttonCompromisso_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonContato_Click(object sender, EventArgs e)
        {
            TelaContato telaContato = new();
            telaContato.Show();
        }

        private void buttonTarefa_Click(object sender, EventArgs e)
        {

        }
    }
}