using System.ComponentModel.DataAnnotations.Schema;

namespace DbCompanyPc.Models
{
    public class DepartmentRelation
    {
        public int Id { get; set; }

        [ForeignKey(nameof(Parent))]
        public int ParentId { get; set; }

        [ForeignKey(nameof(Department))]
        public int DepartmentId { get; set; }

        public Department Parent { get; set; }

        public Department Department { get; set; }
    }
}