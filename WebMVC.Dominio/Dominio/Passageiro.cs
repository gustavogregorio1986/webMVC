using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMVC.Dominio.Dominio
{
    [Table("tb_Passageiro")]
    public class Passageiro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPassageiro { get; set; }

        public string NomePssageiro { get; set; }

        public string EmaqilPassageiro { get; set; }

        public string Sexo { get; set; }

        public string Telefone { get; set; }
    }
}
