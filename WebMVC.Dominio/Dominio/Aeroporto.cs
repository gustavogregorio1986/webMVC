using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMVC.Dominio.Dominio
{
    [Table("tb_Aeroporto")]
    public class Aeroporto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdAero { get; set; }

        public string NomeAero { get; set; }

        public DateTime DataEntrada { get; set; }

        public int Id_Passageiro { get; set; }

        [ForeignKey("Id_Passageiro")]
        public Passageiro Passageiro { get; set; }
    }
}
