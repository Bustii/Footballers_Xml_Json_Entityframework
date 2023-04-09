using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Footballers.Common;

namespace Footballers.DataProcessor.ExportDto
{
    [XmlType("Coach")]
    public class ExportCoachDto
    {
        [XmlAttribute("FootballersCount")]
        public int FootballersCount { get; set; }

        [XmlElement("CoachName")]
        [MinLength(ValidationConst.CoachNameMinLength)]
        [MaxLength(ValidationConst.CoachNameMaxLength)]
        public string CoachName { get; set; } = null!;

        public ExportFootballerDto[] Footballers { get; set; } = null!;
    }
}
