using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Category Name")]
        [MaxLength(20)]
        [DisplayName("Category Name")]
        public string  Name { get; set; }

        [Required]
        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage ="Display Order must be between 1 - 100")]
        public int DisplayOrder { get; set; }
    }
}
