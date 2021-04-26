using System.ComponentModel.DataAnnotations.Schema;

namespace DbCompanyPc.Models
{
    public class ComputerToPartElement
    {
        [ForeignKey(nameof(Computer))]
        public int ComputerId { get; set; }

        public Computer Computer { get; set; }

        [ForeignKey(nameof(PartElement))]
        public int PartElementId { get; set; }

        public PartElement PartElement { get; set; }
    }
}