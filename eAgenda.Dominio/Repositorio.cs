using System.Collections.Generic;
using System.Linq;

namespace eAgenda.Dominio
{
    public class Repositorio<T> where T : EntidadeBase
    {
        protected readonly List<T> registros;
        protected int contadorID;

        #region Construtor
        public Repositorio()
        {
            registros = new List<T>();
        }
        #endregion

        public string Inserir(T registro)
        {
            string resultado = registro.Validar();
            if (resultado != "REGISTRO_VALIDO")
                return resultado;

            registro.id = ++contadorID;
            registros.Add(registro);
            return "REGISTRO_VALIDO";
        }

        public string Editar(T novoRegistro, T antigoRegistro)
        {
            string resultado = novoRegistro.Validar();
            if (resultado != "REGISTRO_VALIDO")
                return resultado;

            int indice = registros.FindIndex(x => x.id == antigoRegistro.id);
            registros[indice] = novoRegistro;
            return "REGISTRO_VALIDO";
        }
        public bool Excluir(T registro)
        {
            return registros.Remove(registro);
        }

        public List<T> SelecionarTodos()
        {
            return registros;
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