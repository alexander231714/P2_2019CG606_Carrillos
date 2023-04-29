using System.ComponentModel.DataAnnotations;

namespace P2_2019CG606.Models
{
    public class generos
    {
        [Key] 
        public int id_genero { get; set; }
        public string? genero { get; set; }
    }
}
