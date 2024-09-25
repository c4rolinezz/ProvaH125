

    namespace ProvaH125.Controller
    {

        using Microsoft.AspNetCore.Mvc;
        using System.Collections.Generic;
        using System.ComponentModel.DataAnnotations;

        public class Carta
        {
            [Required(ErrorMessage = "A idade da Criança é obrigatória.")]
            [Range(16, int.MaxValue, ErrorMessage = "A idade deve ser maior que 15 anos.")]
            public int Idade { get; set; }

            [Required(ErrorMessage = "O campo Nome da criança é obrigatório.")]
            [StringLength(255, MinimumLength = 3, ErrorMessage = "O nome da criança deve ter no mínimo 3 caracteres e no máximo 255 caracteres.")]
            public string Nome { get; set; }

            [Required(ErrorMessage = "O campo Rua é obrigatório.")]
            [StringLength(255, MinimumLength = 3, ErrorMessage = "A rua deve ter no mínimo 3 caracteres e no máximo 255 caracteres.")]
            public string Rua { get; set; }

            [Required(ErrorMessage = "O campo Número é obrigatório.")]
            [StringLength(10, ErrorMessage = "O número deve ter no máximo 10 caracteres.")]
            public string Numero { get; set; }

            [Required(ErrorMessage = "O campo Bairro é obrigatório.")]
            [StringLength(100, MinimumLength = 3, ErrorMessage = "O bairro deve ter no mínimo 3 caracteres e no máximo 100 caracteres.")]
            public string Bairro { get; set; }

            [Required(ErrorMessage = "O campo Cidade é obrigatório.")]
            [StringLength(100, MinimumLength = 2, ErrorMessage = "A cidade deve ter no mínimo 2 caracteres e no máximo 100 caracteres.")]
            public string Cidade { get; set; }

            [Required(ErrorMessage = "O campo Estado é obrigatório.")]
            [StringLength(2, ErrorMessage = "O estado deve ter 2 caracteres (sigla).")]
            public string Estado { get; set; }

            [Required(ErrorMessage = "O campo Texto da carta é obrigatório.")]
            [StringLength(500, ErrorMessage = "O texto da carta deve ter no máximo 500 caracteres.")]
            public string TextoDaCarta { get; set; }
        }
    }




   