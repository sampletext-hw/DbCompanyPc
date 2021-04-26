using System.Collections.Generic;

namespace DbCompanyPc.Models
{
    public class Producer
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public ICollection<PartElement> PartElements { get; set; }

        public ICollection<SoftElement> SoftElements { get; set; }
    }
}