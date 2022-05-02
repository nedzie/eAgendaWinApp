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

namespace eAgenda.WinApp.ModuloTarefa
{
    public partial class TelaTarefa : Form
    {
        Repositorio<Tarefa> _repositorioTarefa;
        public TelaTarefa(Repositorio<Tarefa> repositorioTarefa)
        {
            InitializeComponent();
            _repositorioTarefa = repositorioTarefa;
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            TelaCadastrarTarefa telaCadTarefa = new();
            telaCadTarefa.ShowDialog();
        }
    }
}
