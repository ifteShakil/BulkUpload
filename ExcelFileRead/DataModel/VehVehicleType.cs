using System.ComponentModel.DataAnnotations;

namespace BulkUpload.DataModel
{
    public class VehVehicleType
    {
        [Key]
        public int ID { get; set; } // Primary Key

        [MaxLength(100)]
        public string? Vehicle_Type { get; set; }

        [MaxLength(10)]
        public string? OCODE { get; set; }

        public DateTime? EDIT_DATE { get; set; }

        public Guid? EDIT_USER { get; set; }
    }
}
