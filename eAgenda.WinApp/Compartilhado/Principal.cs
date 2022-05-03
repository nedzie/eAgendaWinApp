using eAgenda.Dominio;
using eAgenda.Dominio.Compartilhado;
using eAgenda.WinApp.ModuloCompromisso;
using eAgenda.WinApp.ModuloContato;
using eAgenda.WinApp.ModuloTarefa;
using System;
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

        //////////////////////////////////////////////////////////////////////////////
        
        private readonly JsonSerializador<Tarefa> _jsonTarefa;
        private readonly JsonSerializador<Contato> _jsonContato;
        private readonly JsonSerializador<Compromisso> _jsonCompromisso;
        public Principal()
        {
            _jsonContato = new(@"C:\Temp\Contatos");
            _jsonCompromisso = new(@"C:\Temp\Compromissos");
            _jsonTarefa = new(@"C:\Temp\Tarefas");
            repositorioContato = new Repositorio<Contato>(_jsonContato);
            repositorioCompromisso = new Repositorio<Compromisso>(_jsonCompromisso);
            repositorioTarefa = new Repositorio<Tarefa>(_jsonTarefa);
            InitializeComponent();
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
            telaTarefa = new(repositorioTarefa, _jsonTarefa);
            telaTarefa.Show();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}