using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InputsOutputs.Models.Database
{
    [Table("Data")]
    public class DataModel
    {
        [Key]
        public int Id { get; set; }

        [StringLength(128)]
        public string SellerName { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [StringLength(1024)]
        public string Name { get; set; }

        public int? PriceRonCash { get; set; }

        public int? PriceRonCashRegister { get; set; }

        public int? PriceEuro { get; set; }

        public int? PricePounds { get; set; }

        [Required]
        public DataType Type { get; set; }
    }

    public enum DataType
    {
        Sale,
        Cost,
        Return
    }
}
