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
    public partial class TelaCadastrarTarefa : Form
    {
        private Tarefa? _tarefa;
        public TelaCadastrarTarefa(Tarefa tarefa)
        {
            InitializeComponent();
            _tarefa = tarefa;
            if(tarefa != null)
            {
                textBoxTituloTarefa.Text = _tarefa.Titulo;
                comboBoxPrioridades.SelectedItem = tarefa.Prioridade;
            }
        }

        public Tarefa Tarefa
        {
            get { return _tarefa!; }
            set { _tarefa = value; }
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            _tarefa!.Titulo = textBoxTituloTarefa.Text;
            _tarefa.Prioridade = (PrioridadeEnum)comboBoxPrioridades.SelectedIndex;
        }
    }
}
