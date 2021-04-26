using System.Collections.Generic;

namespace DbCompanyPc.Models
{
    public class Room
    {
        public int Id { get; set; }

        public string Number { get; set; }

        public ICollection<Computer> Computers { get; set; }
    }
}