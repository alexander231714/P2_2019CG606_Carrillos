using System.ComponentModel.DataAnnotations;

namespace P2_2019CG606.Models
{
    public class departamentos
    {
        [Key]
        public int id_departamentos { get; set; }
        public string? nombre { get; set; }
    }
}
