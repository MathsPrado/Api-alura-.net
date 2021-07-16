using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmeAPI.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O Campo titulo é obrigatorio")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo Genero é obrigatorio")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage ="O genero não pode passar de 30 caracteres" )]
        public string Genero { get; set; }
        [Range(1,600, ErrorMessage = "A duração deve ter no min 1 min e 600 min")]
        public int Duracao { get; set; }
    }
}
