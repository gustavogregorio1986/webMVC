using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMVC.Dominio.Dominio
{
    [Table("tb_Orgem")]
    public class Origem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdOrigem { get; set; }

        public string CidadwOrigem { get; set; }

        public DateTime DataEmbarque { get; set; }

        public int Id_Aviao { get; set; }

        [ForeignKey("Id_Aviao")]
        public Aviao Aviao { get; set; }
    }
}
