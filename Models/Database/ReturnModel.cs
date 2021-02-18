using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InputsOutputs.Models.Database
{
    [Table("Returns")]
    public class ReturnModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [StringLength(1024)]
        public string Name { get; set; }

        public int? PriceRon { get; set; }

        public int? PriceEuro { get; set; }

        public int? PricePounds { get; set; }
    }
}
