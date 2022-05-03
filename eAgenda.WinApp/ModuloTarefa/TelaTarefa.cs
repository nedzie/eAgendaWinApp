using eAgenda.Dominio;
using eAgenda.Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloTarefa
{
    public partial class TelaTarefa : Form
    {
        Repositorio<Tarefa> _repositorioTarefa;
        JsonSerializador<Tarefa> _jsonTarefa;
        public TelaTarefa(Repositorio<Tarefa> repositorioTarefa, JsonSerializador<Tarefa> jTarefa)
        {
            InitializeComponent();
            _repositorioTarefa = repositorioTarefa;
            _jsonTarefa = jTarefa;
            CarregarTarefasNaTela();
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            TelaCadastrarTarefa telaCadTarefa = new(new Tarefa());
            DialogResult res = telaCadTarefa.ShowDialog();

            if (res == DialogResult.OK)
            {
                Tarefa temp = telaCadTarefa.Tarefa;

                bool podeSeguir = VerificarDuplicidade(temp);
                if (!podeSeguir)
                    return;

                string status = _repositorioTarefa.Inserir(telaCadTarefa.Tarefa);
                if (status == "REGISTRO_VALIDO")
                    MessageBox.Show("Tarefa inserida com sucesso!", "Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show($"{status}\nTente novamente", "Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                CarregarTarefasNaTela();
            }
        }

        private bool VerificarDuplicidade(Tarefa temp)
        {
            List<Tarefa> todos = _repositorioTarefa.SelecionarTodos();

            foreach (Tarefa tarefaJaRegistrada in todos)
            {
                if (tarefaJaRegistrada.Titulo == temp.Titulo)
                {
                    MessageBox.Show("O nome da tarefa já existe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private void CarregarTarefasNaTela()
        {
            CarregasTarefasPendentes();
            CarregarTarefasConcluidas();
        }

        private void CarregasTarefasPendentes()
        {
            List<Tarefa> tarefasPendentes = _repositorioTarefa.Filtrar(x => x.Concluida == false).OrderBy(x => x.Prioridade).ToList();

            listBoxTarefasPendentes.Items.Clear();
            foreach (var item in tarefasPendentes)
            {
                listBoxTarefasPendentes.Items.Add(item);
            }
        }
        private void CarregarTarefasConcluidas()
        {
            List<Tarefa> tarefasConcluidas = _repositorioTarefa.Filtrar(x => x.Concluida == true).OrderBy(x => x.Prioridade).ToList();

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
            Tarefa temp = (Tarefa)listBoxTarefasConcluidas.SelectedItem;
            if(temp != null)
            {
                MessageBox.Show("Você só pode adicionar itens em tarefas pendentes!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TelaCadastrarItens telaItens = new(tarefaSelecionada);
            DialogResult res = telaItens.ShowDialog();
            if (res == DialogResult.OK)
            {
                tarefaSelecionada.AdicionarItens(telaItens.ItensAdicionados);
                _jsonTarefa.Salvar(_repositorioTarefa.SelecionarTodos());
                CarregarTarefasNaTela();
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            Tarefa temp = (Tarefa)listBoxTarefasPendentes.SelectedItem;
            if(temp != null)
            {
                MessageBox.Show("Você só pode excluir tarefas já concluídas!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Tarefa tarefaSelecionada = (Tarefa)listBoxTarefasConcluidas.SelectedItem;
            
            bool temAlgo = VerificarContinuidade(tarefaSelecionada, "Excluir");
            if (!temAlgo)
                return;

            DialogResult resultado = MessageBox.Show("Excluir tarefa?",
                "Excluir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                _repositorioTarefa.Excluir(tarefaSelecionada);
                MessageBox.Show("Tarefa excluída com sucesso",
                "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void buttonConcluirItens_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listBoxTarefasPendentes.SelectedItem;
            Tarefa temp = (Tarefa)listBoxTarefasConcluidas.SelectedItem;
            if (temp != null)
            {
                MessageBox.Show("Você só pode concluir itens em tarefas pendentes!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TelaConcluirItens telaConcItens = new(tarefaSelecionada);
            DialogResult res = telaConcItens.ShowDialog();

            if (res == DialogResult.OK)
            {
                List<Item> itensConcluidos = telaConcItens.ItensConcluidos;

                List<Item> itensPendentes = telaConcItens.ItensPendentes;

                tarefaSelecionada.AtualizarItens(itensConcluidos, itensPendentes);
                _jsonTarefa.Salvar(_repositorioTarefa.SelecionarTodos());
            }
            CarregarTarefasNaTela();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)listBoxTarefasPendentes.SelectedItem;

            Tarefa novaTarefa = new();

            novaTarefa.id = tarefaSelecionada.id;
            novaTarefa.Titulo = tarefaSelecionada.Titulo;
            novaTarefa.DataCriacao = tarefaSelecionada.DataCriacao;
            novaTarefa.Itens = tarefaSelecionada.Itens;
            novaTarefa.Concluida = tarefaSelecionada.Concluida;

            bool temAlgo = VerificarContinuidade(tarefaSelecionada, "Editar");
            if (!temAlgo)
                return;

            TelaCadastrarTarefa telaCadTarefa = new(novaTarefa); // Povoa com as mesmas informações sem editar as antigas

            DialogResult res = telaCadTarefa.ShowDialog();

            if (res == DialogResult.OK)
            {
                Tarefa temp = telaCadTarefa.Tarefa;

                bool podeSeguir = VerificarDuplicidade(temp);
                if (!podeSeguir)
                    return;

                string status = _repositorioTarefa.Editar(novaTarefa, tarefaSelecionada);
                if (status == "REGISTRO_VALIDO")
                {
                    MessageBox.Show("Tarefa editada com sucesso!", "Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    CarregarTarefasNaTela();
                }
                else
                {
                    MessageBox.Show($"{status}\nTente novamente", "Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CarregarTarefasNaTela();
                }
            }
        }
    }
}