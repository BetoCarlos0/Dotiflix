﻿using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ApiDotflix.Entities.Models.Dtos
{
    public class MoviePostInputDto
    {
        [Required(ErrorMessage = "Título obrigatório")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Título menor que 5 caracteres")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Sinopse obrigatória")]
        [StringLength(250, MinimumLength = 5, ErrorMessage = "Sinopse menor que 5 caracteres")]
        public string Sinopse { get; set; }

        [JsonIgnore]
        public string? ImageUrl { get; set; }

        [NotMapped ,Required(ErrorMessage = "Imagem obrogatória")]
        public IFormFile Image { get; set; }

        [Required(ErrorMessage = "Classificação indicativa Id obrigatória")]
        public string AgeGroupId { get; set; }

        [JsonIgnore]
        public AgeGroup AgeGroup { get; set; }      // faixa etária

        [Required(ErrorMessage = "Relevância do filme obrigatório")]
        [Range(0, 100, ErrorMessage = "Porcentagem inválida")]
        public int Relevance { get; set; }        // relevância

        [Required(ErrorMessage = "Data de lançamento obrigaório")]
        [RegularExpression(@"^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[13-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$"
            , ErrorMessage = "Data Inválida")]
        public string ReleaseData { get; set; } // data lançamento

        [Required(ErrorMessage = "Tempo do Filme obrigatório")]
        [RegularExpression(@"^([01234]{1}):([012345]\d):([012345]\d)", ErrorMessage = "Tempo inválido")]
        public string RunTime { get; set; }

        [Required(ErrorMessage = "Id de Sobre obrigatório")]
        public AboutInputDto About { get; set; }
    }
}
