using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbCompanyPc.Models
{
    public class Part
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public ICollection<PartElement> PartElements { get; set; }

        public PartType PartType { get; set; }

        public string WarrantyReasons { get; set; }
    }
}