using System.Collections.Generic;

namespace DbCompanyPc.Models
{
    public class Soft
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public ICollection<SoftElement> SoftElements { get; set; }

        public SoftType SoftType { get; set; }
    }
}