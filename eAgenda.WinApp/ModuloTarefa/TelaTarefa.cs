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
            TelaCadastrarTarefa telaCadTarefa = new(new Tarefa());
            DialogResult res = telaCadTarefa.ShowDialog();

            if(res == DialogResult.OK)
            {
                string status = _repositorioTarefa.Inserir(telaCadTarefa.Tarefa);
                if(status == "REGISTRO_VALIDO")
                    MessageBox.Show("Tarefa inserida com sucesso!", "Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show($"{status}\nTente novamente", "Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                CarregarTarefasNaTela();
            }
        }

        private void CarregarTarefasNaTela()
        {
            CarregasTarefasPendentes();
            CarregarTarefasConcluidas();
        }

        private void CarregasTarefasPendentes()
        {
            List<Tarefa> tarefasPendentes = _repositorioTarefa.Filtrar(x => x.Concluida == false);
            listBoxTarefasPendentes.Items.Clear();
            foreach (var item in tarefasPendentes)
            {
                listBoxTarefasPendentes.Items.Add(item);
            }
        }
        private void CarregarTarefasConcluidas()
        {
            List<Tarefa> tarefasConcluidas = _repositorioTarefa.Filtrar(x => x.Concluida == true);
            listBoxTarefasConcluidas.Items.Clear();
            foreach (var item in tarefasConcluidas)
            {
                listBoxTarefasConcluidas.Items.Add(item);
            }
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdicionarItens_Click(object sender, EventArgs e)
        {
            TelaItens telaItens = new();
            telaItens.Show();
        }
    }
}