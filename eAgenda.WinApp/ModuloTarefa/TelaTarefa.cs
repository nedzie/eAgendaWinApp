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
            Tarefa tarefaSelecionada = (Tarefa)listBoxTarefasPendentes.SelectedItem;
            TelaCadastrarItens telaItens = new(tarefaSelecionada);
            DialogResult res = telaItens.ShowDialog();
            if (res == DialogResult.OK)
            {
                tarefaSelecionada.AdicionarItens(telaItens.ItensAdicionados);
                CarregarTarefasNaTela();
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            //Tarefa tarefaSelecionada = (Tarefa)listBoxTarefasConcluidas.SelectedItem;    Alterar para apenas concluídas
            Tarefa tarefaSelecionada2 = (Tarefa)listBoxTarefasPendentes.SelectedItem;
            bool temAlgo = VerificarContinuidade(tarefaSelecionada2, "Excluir");
            if (!temAlgo)
                return;

            DialogResult resultado = MessageBox.Show("Excluir tarefa?",
                "Excluir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                _repositorioTarefa.Excluir(tarefaSelecionada2);
                CarregarTarefasNaTela();
            }
        }


        public bool VerificarContinuidade(Tarefa tarefaSelecionada, string tipo)
        {
            bool temAlgo = _repositorioTarefa.ExisteRegistro();
            if (!temAlgo)
            {
                MessageBox.Show($"Nenhuma tarefa para {tipo}", tipo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (tarefaSelecionada == null)
            {
                MessageBox.Show($"Selecione uma tarefa para {tipo}", tipo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }
    }
}