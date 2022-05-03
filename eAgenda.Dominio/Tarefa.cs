using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eAgenda.Dominio
{
    public class Tarefa : EntidadeBase, IEnumerable<Tarefa>
    {
        private PrioridadeEnum _prioridade;
        public string Titulo { get; set; }

        private List<Item> itens = new List<Item>();

        public DateTime DataCriacao { get; set; }
        public DateTime? DataConclusao { get; set; }

        public bool Concluida;

        public List<Item> Itens
        {
            get { return itens; }
            set { itens = value; }
        }

        public PrioridadeEnum Prioridade
        {
            get { return _prioridade; }
            set { _prioridade = value; }
        }

        public Tarefa()
        {
            DataCriacao = DateTime.Now;
            DataConclusao = null;
        }

        public void AdicionarItens(List<Item> itens)
        {
            foreach (Item item in itens)
            {
                if (!Itens.Exists(x => x.Equals(item)))
                    this.itens.Add(item);
            }
        }

        public override string Validar()
        {
            StringBuilder sb = new();

            if (string.IsNullOrEmpty(Titulo))
                sb.AppendLine("O título da tarefa é obrigatório");


            if (sb.Length == 0)
                sb.Append("REGISTRO_VALIDO");

            return sb.ToString();
        }
        public override string ToString()
        {
            decimal percentual = CalcularPercentualConclusao();

            if (DataConclusao.HasValue)
                return $"ID: {id} Título: {Titulo} Prioridade: {Prioridade} Data de criação: {DataCriacao} Percentual: {percentual}% Conclusão: {DataConclusao}";

            return $"ID: {id} Título: {Titulo} Prioridade: {Prioridade} Data de criação: {DataCriacao} Percentual: {percentual}%";
        }

        private decimal CalcularPercentualConclusao()
        {
            if (itens.Count == 0)
                return 0;

            int qtdConcluidas = Itens.Count(x => x.Concluido);

            var percentualConcluido = (qtdConcluidas / (decimal)Itens.Count) * 100;

            return Math.Round(percentualConcluido, 2);
        }

        public void AtualizarItens(List<Item> itensConcluidos, List<Item> itensPendentes)
        {
            foreach (var item in itensConcluidos)
            {
                ConcluirItem(item);
            }

            foreach (var item in itensPendentes)
            {
                MarcarPendente(item);
            }
        }

        public void ConcluirItem(Item item)
        {
            Item itemTarefa = itens.Find(x => x.Equals(item));

            itemTarefa?.Concluir();

            var percentual = CalcularPercentualConclusao();

            if (percentual == 100)
            {
                DataConclusao = DateTime.Now;
                Concluida = true;
            }
        }

        public void MarcarPendente(Item item)
        {
            Item itemTarefa = itens.Find(x => x.Equals(item));

            itemTarefa?.MarcarPendente();
        }

        public IEnumerator<Tarefa> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}