using System.ComponentModel.DataAnnotations;

namespace Entities
{
    internal class User
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="FirstName is required")]
        public string FirstName { get; set; }
    }
}
