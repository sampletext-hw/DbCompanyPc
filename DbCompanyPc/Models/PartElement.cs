using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbCompanyPc.Models
{
    public class PartElement
    {
        public int Id { get; set; }

        public DateTime PurchaseDate { get; set; }

        public TimeSpan WarrantyDuration { get; set; }
        
        [ForeignKey(nameof(Producer))]
        public int ProducerId { get; set; }

        public Producer Producer { get; set; }

        [ForeignKey(nameof(Part))]
        public int PartId { get; set; }

        public Part Part { get; set; }
    }
}