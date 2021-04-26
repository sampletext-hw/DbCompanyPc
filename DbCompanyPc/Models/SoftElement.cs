using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbCompanyPc.Models
{
    public class SoftElement
    {
        public int Id { get; set; }

        [ForeignKey(nameof(Soft))]
        public int SoftId { get; set; }

        public Soft Soft { get; set; }

        [ForeignKey(nameof(Producer))]
        public int ProducerId { get; set; }
        
        public Producer Producer { get; set; }

        public DateTime LicenseExpirationDate { get; set; }
    }
}