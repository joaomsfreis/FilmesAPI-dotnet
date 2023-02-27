using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos
{
    public class CreateFilmeDTO
    {
        [Required(ErrorMessage = "O título do filme é obrigatório")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O gênero do filme é obrigatório")]
        [StringLength(50, ErrorMessage = "O gênero do filme deve ter 50 caracteres")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "O duração do filme é obrigatório")]
        [Range(70, 600, ErrorMessage = "O duração deve ser entre 70 e 600 minutos")]
        public int Duracao { get; set; }
    }
}
