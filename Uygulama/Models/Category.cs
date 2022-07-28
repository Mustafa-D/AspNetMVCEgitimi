using System.ComponentModel.DataAnnotations;

namespace Uygulama.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Display(Name ="Kategori Adı")]
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }

        public Category()
        {
            Products = new List<Product>();
        }
    }
}
