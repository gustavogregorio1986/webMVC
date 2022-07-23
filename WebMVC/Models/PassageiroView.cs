namespace WebMVC.Models
{
    public class PassageiroView
    {
        public int IdPassageiro { get; set; }

        public string NomePssageiro { get; set; }

        public string EmaqilPassageiro { get; set; }

        public string Sexo { get; set; }

        public string Telefone { get; set; }

        public EnderecoView enderecoView { get; set; }

        public AeroportoView aeroportoView { get; set; }
    }
}
