using System;

namespace WebMVC.Models
{
    public class AeroportoView
    {
        public int IdAero { get; set; }

        public string NomeAero { get; set; }

        public DateTime DataEntrada { get; set; }

        public int Id_Passageiro { get; set; }

        public AviaoView aviaoView { get; set; }
    }
}
