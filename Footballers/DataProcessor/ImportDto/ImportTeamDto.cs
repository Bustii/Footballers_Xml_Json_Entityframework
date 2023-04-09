using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Components.DictionaryAdapter;
using Footballers.Common;
using Newtonsoft.Json;

namespace Footballers.DataProcessor.ImportDto
{
    public class ImportTeamDto
    {
        [JsonProperty("Name")]
        [Required]
        [MinLength(ValidationConst.TeamNameMinLength)]
        [MaxLength(ValidationConst.TeamNameMaxLength)]
        [RegularExpression(ValidationConst.TeamLettersContains)]
        public string Name { get; set; } = null!;

        [JsonProperty("Nationality")]
        [Required]
        [MinLength(ValidationConst.TeamNationalityNameMinLength)]
        [MaxLength(ValidationConst.TeamNationalityNameMaxLength)]
        public string Nationality { get; set; } = null!;

        [JsonProperty("Trophies")]
        [Required] 
        public int Trophies { get; set; }

        [JsonProperty("Footballers")]
        [Required]
        public int[] Footballers { get; set; } = null!;
    }
}
