using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMVC.Dominio.Dominio
{
    [Table("tb_Destino")]
    public class Destino
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDstino { get; set; }

        public string CidadwDestino { get; set; }

        public DateTime DataEmbarque { get; set; }

        public int Id_Aviao { get; set; }

        [ForeignKey("Id_Aviao")]
        public Aviao Aviao { get; set; }
    }
}
