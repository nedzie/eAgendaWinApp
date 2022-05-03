using eAgenda.Dominio.Compartilhado;
using System;
using System.Collections.Generic;

namespace eAgenda.Dominio
{
    public class Repositorio<T> where T : EntidadeBase
    {
        private readonly ISerializador<T> _serializador; // Para serializar [gravar] as informações em .json
        protected readonly List<T> registros;
        protected int contadorID;

        #region Construtor
        public Repositorio(ISerializador<T> ser)
        {
            _serializador = ser;
            registros = ser.Carregar();
            contadorID = registros.Count;
        }
        #endregion

        public string Inserir(T registro)
        {
            string resultado = registro.Validar();
            if (resultado != "REGISTRO_VALIDO")
                return resultado;

            registro.id = ++contadorID;
            registros.Add(registro);
            _serializador.Salvar(registros);
            return "REGISTRO_VALIDO";
        }

        public string Editar(T novoRegistro, T antigoRegistro)
        {
            string resultado = novoRegistro.Validar();
            if (resultado != "REGISTRO_VALIDO")
                return resultado;

            int indice = registros.FindIndex(x => x.id == antigoRegistro.id);
            registros[indice] = novoRegistro;
            _serializador.Salvar(registros);
            return "REGISTRO_VALIDO";
        }
        public bool Excluir(T registro)
        {
            _serializador.Salvar(registros);
            return registros.Remove(registro);
        }

        public List<T> SelecionarTodos()
        {
            return registros;
        }

        public List<T> Filtrar(Predicate<T> condicao)
        {
            List<T> registrosFiltrados = new List<T>();

            foreach (T registro in registros)
                if (condicao(registro))
                    registrosFiltrados.Add(registro);

            return registrosFiltrados;
        }

        public List<T> Filtrar(Predicate<T> condicao, Predicate<T> condicao2)
        {
            List<T> registrosFiltrados = new List<T>();

            foreach (T registro in registros)
                if (condicao(registro) && condicao2(registro))
                    registrosFiltrados.Add(registro);

            return registrosFiltrados;
        }

        public bool ExisteRegistro()
        {
            int quantia = registros.Count;
            if (quantia == 0)
                return false;
            else
                return true;
        }
    }
}