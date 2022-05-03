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
    public partial class TelaConcluirItens : Form
    {
        private readonly Tarefa _tarefa;
        public TelaConcluirItens(Tarefa tarefa)
        {
            InitializeComponent();
            _tarefa = tarefa;

            labelTarefaSelecionada.Text = _tarefa.Titulo;

            CarregarItensTarefa(_tarefa);
        }

        private void CarregarItensTarefa(Tarefa tarefa)
        {
            int i = 0;
            foreach (var item in tarefa.Itens)
            {
                checkedListBoxItensTarefa.Items.Add(item);

                if (item.Concluido)
                    checkedListBoxItensTarefa.SetItemChecked(i, true);

                i++;
            }
        }

        public List<Item> ItensConcluidos
        {
            get
            {
                return checkedListBoxItensTarefa.CheckedItems
                    .Cast<Item>()
                    .ToList();
            }
        }

        public List<Item> ItensPendentes
        {
            get
            {
                return checkedListBoxItensTarefa.Items
                    .Cast<Item>()
                    .Except(ItensConcluidos)
                    .ToList();
            }
        }
    }
}