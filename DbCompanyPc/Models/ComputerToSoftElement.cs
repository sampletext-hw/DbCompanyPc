using System.ComponentModel.DataAnnotations.Schema;

namespace DbCompanyPc.Models
{
    public class ComputerToSoftElement
    {
        [ForeignKey(nameof(Computer))]
        public int ComputerId { get; set; }

        public Computer Computer { get; set; }

        [ForeignKey(nameof(SoftElement))]
        public int SoftElementId { get; set; }

        public SoftElement SoftElement { get; set; }
    }
}