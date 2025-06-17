using System.ComponentModel.DataAnnotations;

namespace BulkUpload.DataModel.Inventory
{
    public class InvProductGroup
    {
        [Key]
        public int GroupId { get; set; } // Primary Key
        public string? GroupName { get; set; }
        public string? GroupCode { get; set; }
        public string? Description { get; set; }
        public string? GroupType { get; set; }
        public int? GroupMasterType { get; set; }
        public string? ACDepreciationMethod { get; set; }
        public string? TaxDepreciationMethod { get; set; }
        public string? Tangibility { get; set; }
        public float? ACDepreciationRate { get; set; }
        public float? TaxDepreciationRate { get; set; }
        public DateTime? EditDate { get; set; }
        public Guid? EditUser { get; set; }
        public string? OCode { get; set; }


    }
}
