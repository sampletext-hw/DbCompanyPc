using System.ComponentModel.DataAnnotations.Schema;

namespace DbCompanyPc.Models
{
    public class Computer
    {
        public int Id { get; set; }

        [ForeignKey(nameof(Network))]
        public int NetworkId { get; set; }

        [ForeignKey(nameof(Room))]
        public int RoomId { get; set; }

        public LocalNetwork Network { get; set; }

        public Room Room { get; set; }
    }
}