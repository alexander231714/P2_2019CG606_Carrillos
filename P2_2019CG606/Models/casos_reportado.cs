using System.ComponentModel.DataAnnotations;

namespace P2_2019CG606.Models
{
    public class casos_reportado
    {
        [Key]
        public int id_caso { get; set; }
        public int casos_confirmados { get; set; }
        public int casos_recuperado { get; set; }
        public int casos_fallecidos { get; set; }
        public int departamentos_id { get; set; }
        public int genero_id { get; set; }
    }
}
