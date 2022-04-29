namespace eAgenda.Dominio
{
    public class Contato : EntidadeBase
    {
        #region Atributos
        private string nome;
        private string email;
        private string telefone;
        #endregion

        #region Propriedades
        public string Nome { get { return nome; } set { nome = value; } }
        public string Email { get { return email; }  set { email = value; } }
        public string Telefone { get { return telefone; } set { telefone = value; } }
        public string Empresa { get; set; }
        public string Cargo { get; set; }
        #endregion

        #region Construtores

        public Contato()
        {

        }

        public Contato(string nome, string email, string telefone, string empresa, string cargo)
        {
            this.nome = nome;
            this.email = email;
            this.telefone = telefone;
            Empresa = empresa;
            Cargo = cargo;
        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            return "id: " + id + "\n" +
                   "Nome: " + Nome + "\n" +
                   "Email: " + Email + "\n" +
                   "Telefone: " + Telefone + "\n" +
                   "Empresa: " + Empresa + "\n" +
                   "Cargo: " + Cargo + "\n";
        }
        #endregion
    }
}