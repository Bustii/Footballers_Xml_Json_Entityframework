using Footballers.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Footballers.Common;

namespace Footballers.DataProcessor.ImportDto
{
    [XmlType("Footballer")]
    public class ImportFootballerDto
    {
        [Required]
        //[XmlElement("Name")]
        [MinLength(ValidationConst.FootballerNameMinLength)]
        [MaxLength(ValidationConst.FootballerNameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [XmlElement("ContractStartDate")] 
        public string ContractStartDate { get; set; } = null!;

        [Required]
        [XmlElement("ContractEndDate")]
        public string ContractEndDate { get; set; } = null!;

        [Required]
        [XmlElement("BestSkillType")]
        [Range(ValidationConst.BestSkillTypeMinLength, ValidationConst.BestSkillTypeMaxLength)]
        public int BestSkillType { get; set; }

        [Required]
        [XmlElement("PositionType")]
        [Range(ValidationConst.PositionTypeMinLength, ValidationConst.PositionTypeMaxLength)]
        public int PositionType { get; set; }

        
    }
}
