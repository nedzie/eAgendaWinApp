using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace eAgenda.Dominio.Compartilhado
{
    public class JsonSerializador<T> : ISerializador<T> where T : class
    {
        private readonly string _caminho;
        private readonly JsonSerializerSettings _jsonConfigs;

        public JsonSerializador(string caminho)
        {
            this._caminho = caminho + ".json";
            _jsonConfigs = new();
            _jsonConfigs.Formatting = Formatting.Indented;
        }

        public List<T> Carregar()
        {
            if (File.Exists(_caminho) == false)
                return new List<T>();

            string json = File.ReadAllText(_caminho);

            return JsonConvert.DeserializeObject<List<T>>(json, _jsonConfigs);
        }

        public void Salvar(List<T> x)
        {
            string json = JsonConvert.SerializeObject(x, _jsonConfigs);

            File.WriteAllText(_caminho, json);
        }
    }
}