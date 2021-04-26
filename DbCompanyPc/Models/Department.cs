using System.Collections.Generic;

namespace DbCompanyPc.Models
{
    public class Department
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public ICollection<DepartmentRelation> ParentOf { get; set; }
        public ICollection<DepartmentRelation> ChildOf { get; set; }

        public ICollection<LocalNetwork> LocalNetworks { get; set; }
    }
}