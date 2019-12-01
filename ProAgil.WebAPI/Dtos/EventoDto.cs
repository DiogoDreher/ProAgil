using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProAgil.WebAPI.Dtos
{
    public class EventoDto
    {
        public int Id { get; set; }

        [Required (ErrorMessage = "Campo obrigatorio!")]
        [StringLength (100, MinimumLength=3, ErrorMessage = "Local e entre 3 e 100 caracteres")]
        public string Local { get; set; }
        public string DataEvento { get; set; }

        [Required (ErrorMessage = "O Tema deve ser preenchido!")]
        public string Tema { get; set; }

        [Range(2, 120000, ErrorMessage= "Quantidade de pessoas deve ser entre 2 e 120 mil.")]
        public int QtdPessoas { get; set; }
        public string ImagemURL { get; set; }

        [Phone]
        public string Telefone { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public List<LoteDto> Lotes { get; set; }
        public List<RedeSocialDto> RedesSociais { get; set; }
        public List<PalestranteDto> Palestrante { get; set; }
    }
}