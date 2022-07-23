namespace WebMVC.Models
{
    public class AviaoView
    {
        public int IdAviao { get; set; }

        public string Compania { get; set; }

        public string NomeAviao { get; set; }

        public string Poltrona { get; set; }

        public string Portao { get; set; }

        public int Id_Aeroporto { get; set; }

        public OrigemView origemView { get; set; }

        public DestinoView destinoView { get; set; }
    }
}
