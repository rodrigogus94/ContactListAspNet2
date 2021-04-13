using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebMySQL.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Display(Name = "Id")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "DTN_ID")]
        [Required(ErrorMessage = "O DTN_ID é obrigatório e tem que ser de 00 à 9999.")]
        [Range(0,1000)]
        [Column("DTN_ID")]
        [StringLength(20)]
        public string DTN_ID { get; set; }

        [Display(Name = "DTN_DESTINATION")]
        [Required(ErrorMessage = "O DTN_ID é obrigatório e tem que ser de 0 à 1000.")]
        [Range(00,10000)]
        [Column("DTN_DESTINATION")]
        [StringLength(10)]
        public string DTN_DESTINATION { get; set; }
       

        
    }
    
    
}
