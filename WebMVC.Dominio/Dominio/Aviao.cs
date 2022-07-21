using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMVC.Dominio.Dominio
{
    [Table("tb_Aviao")]
    public class Aviao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdAviao { get; set; }

        public string Compania { get; set; }

        public string NomeAviao { get; set; }

        public string Poltrona { get; set; }

        public string Portao { get; set; }

        public int Id_Aeroporto { get; set; }

        [ForeignKey("Id_Aeroporto")]
        public Aeroporto Aeroporto { get; set; }
    }
}
