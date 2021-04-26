using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbCompanyPc.Models
{
    public class LocalNetwork
    {
        public int Id { get; set; }

        public string Address { get; set; }

        public string Mask { get; set; }

        public ICollection<Computer> Computers { get; set; }

        [ForeignKey(nameof(Department))]
        public int DepartmentId { get; set; }
        
        public Department Department { get; set; }
    }
}