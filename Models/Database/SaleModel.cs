using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InputsOutputs.Models.Database
{
    [Table("Sales")]
    public class SaleModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
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
    }
}
