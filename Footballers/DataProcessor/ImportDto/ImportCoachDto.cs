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
    [XmlType("Coach")]
    public class ImportCoachDto
    {
        [Required]
        [XmlElement("Name")]
        [MaxLength(ValidationConst.CoachNameMaxLength)]
        [MinLength(ValidationConst.CoachNameMinLength)]
        public string Name { get; set; }

        [XmlElement("Nationality")] 
        public string? Nationality { get; set; }

        [XmlArray("Footballers")] 
        public ImportFootballerDto[] Footballers { get; set; }
    }
}
