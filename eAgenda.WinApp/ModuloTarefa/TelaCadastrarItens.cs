using eAgenda.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloTarefa
{
    public partial class TelaCadastrarItens : Form
    {
        public Tarefa? _tarefa;
        public List<Item> _itensAdicionados = new List<Item>();
        public TelaCadastrarItens(Tarefa tarefa)
        {
            InitializeComponent();
            _tarefa = tarefa;
            if (_tarefa != null)
            {
                labelTarefaSelecionada.Text = _tarefa.Titulo;
                foreach (Item item in tarefa.Itens)
                {
                    listBoxItensTarefa.Items.Add(item);
                }
            }
        }

        public List<Item> ItensAdicionados
        {
            get { return _itensAdicionados; }
        }
        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            List<string> titulos = listBoxItensTarefa.Items.Cast<Item>().ToList().Select(x => x.Titulo).ToList();

            if (titulos.Count == 0 || titulos.Contains(textBoxTitulo.Text) == false)
            {
                Item itemTarefa = new();

                itemTarefa.Titulo = textBoxTitulo.Text;

                listBoxItensTarefa.Items.Add(itemTarefa);
                
                ItensAdicionados.Add(itemTarefa);
            }
            else
            {
                MessageBox.Show("Não pode Inserir Itens com o mesmo Nome", "Itens",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}