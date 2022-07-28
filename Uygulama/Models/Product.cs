using System.ComponentModel.DataAnnotations;

namespace Uygulama.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Display(Name ="Ürün Adı"),StringLength(50)]
        public string Name { get; set; }
        [Display(Name="Ürün Stok")]
        public int Stok { get; set; }
        [Display(Name ="Ürün Fiyatı ")]
        public decimal UnitPrice { get; set; }
        [Display(Name="Ürün Resimi"), StringLength(100)]
        public string? Image { get; set; }
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }

    }
}
