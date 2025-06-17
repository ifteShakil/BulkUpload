using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.DataModel.Inventory.SFM
{
    public class StockReciveFile
    {
        [Key]
        public int Id { get; set; }

        public string FileName { get; set; }

        public DateTime DateTime { get; set; }



    }
}
