using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.DataModel.Inventory
{
    public class InvUnit
    {
        [Key]
        public int UnitId { get; set; }

        [MaxLength(100)]
        public string? UnitName { get; set; }

        [MaxLength(200)]
        public string? Description { get; set; }

        [MaxLength(100)]
        public string? ConvUnit { get; set; }

        public double? ConvUnitQty { get; set; }

        [MaxLength(50)]
        public string? OCode { get; set; }

        public Guid? EditUser { get; set; }

        public DateTime? EditDate { get; set; }
    }
}
